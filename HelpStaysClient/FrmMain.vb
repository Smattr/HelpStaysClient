Public Class FrmMain

    Private Const REPORT_STATUS As Integer = -1
    Private Const REPORT_CLEAR_LIST As Integer = -2
    Private Const REPORT_REFRESH_ERROR As Integer = -3
    Private Const REPORT_ADD_BED As Integer = -4
    Private Const DATE_FILTER_NONE As Integer = 0
    Private Const DATE_FILTER_RANGE As Integer = 1
    Private Const DATE_FILTER_DAY As Integer = 2

    Private Structure Filter
        Dim startDate As Date
        Dim endDate As Date
        Dim beds As Integer
        Dim latitude As Double
        Dim longitude As Double
        Dim radius As Integer
        Dim locationFilter As Boolean
        Dim dateFilter As Integer
    End Structure

    Public url As String
    Public credentials As Net.NetworkCredential
    Private bedFilter As Filter
    Private hasFilter As Boolean
    Private filterForm As FrmFilter
    Private reservationForm As FrmReserve
    Private defaultResultCount As Integer

    Public Sub refreshList()
        If bgwRefresh.IsBusy Then
            Exit Sub
        End If
        tsbRefresh.Enabled = False
        RefreshToolStripMenuItem.Enabled = False
        mnuReserve.Enabled = False
        bgwRefresh.RunWorkerAsync()
    End Sub

    Public Sub cancelRefresh()
        If bgwRefresh.IsBusy Then
            bgwRefresh.CancelAsync()
        End If
    End Sub

    Private Sub bgwRefresh_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwRefresh.DoWork
        Dim requestUrl As String
        Dim webRequest As Net.WebRequest
        Dim webResponse As Net.WebResponse
        Dim filterString As String
        Dim reader As IO.StreamReader
        Dim xmlResponse As Xml.XmlDocument
        Dim bedFound As Bed

        bgwRefresh.ReportProgress(REPORT_CLEAR_LIST)
        bgwRefresh.ReportProgress(REPORT_STATUS, "Loading records...")

        requestUrl = url & "/api/v1/beds/available"

        filterString = ""
        If hasFilter Then
            If bedFilter.dateFilter = DATE_FILTER_RANGE Then
                filterString &= "start_date=" & bedFilter.startDate.ToString("yyyy-MM-dd") & "&end_date=" & bedFilter.endDate.ToString("yyyy-MM-dd") & "&"
            ElseIf bedFilter.dateFilter = DATE_FILTER_DAY Then
                filterString &= "single_day=" & bedFilter.startDate.ToString("yyyy-MM-dd") & "&"
            End If
            If Not IsNothing(bedFilter.beds) AndAlso bedFilter.beds <> 0 Then
                filterString &= "beds=" & bedFilter.beds.ToString() & "&"
            Else
                filterString &= "beds=" & defaultResultCount.ToString() & "&"
            End If
            If bedFilter.locationFilter AndAlso Not IsNothing(bedFilter.longitude) AndAlso bedFilter.longitude <> 0 Then
                filterString &= "longitude=" & bedFilter.longitude.ToString() & "&"
            End If
            If bedFilter.locationFilter AndAlso Not IsNothing(bedFilter.latitude) AndAlso bedFilter.latitude <> 0 Then
                filterString &= "latitude=" & bedFilter.latitude.ToString() & "&"
            End If
            If bedFilter.locationFilter AndAlso Not IsNothing(bedFilter.radius) AndAlso bedFilter.radius <> 0 Then
                filterString &= "radius=" & bedFilter.radius.ToString() & "&"
            End If
            If filterString.EndsWith("&") Then
                filterString = filterString.Substring(0, filterString.Length - 1)
            End If
        Else
            filterString = "single_day=" & Date.Now.ToString("yyyy-MM-dd") & "&beds=" & defaultResultCount.ToString()
        End If

        webRequest = Net.WebRequest.Create(requestUrl)
        webRequest.Method = "POST"
        webRequest.Credentials = credentials

        If filterString <> "" Then
            Dim writer As IO.StreamWriter = New IO.StreamWriter(webRequest.GetRequestStream())
            writer.Write(filterString)
            writer.Flush()
            writer.Close()
        End If

        Try
            webResponse = webRequest.GetResponse()
            'webResponse.Headers
            If DirectCast(webResponse, Net.HttpWebResponse).StatusCode <> Net.HttpStatusCode.NoContent Then
                reader = New IO.StreamReader(webResponse.GetResponseStream())
                xmlResponse = New Xml.XmlDocument()
                xmlResponse.LoadXml(reader.ReadToEnd())
                reader.Close()
                webResponse.Close()

                For Each i As Xml.XmlNode In xmlResponse.Item("beds").ChildNodes
                    Try
                        bedFound = New Bed()
                        Integer.TryParse(i.Item("bed-id").InnerText, bedFound.id)
                        bedFound.owner = i.Item("owner-name").InnerText
                        bedFound.phoneNumber = i.Item("phone-number").InnerText
                        bedFound.address1 = i.Item("address-1").InnerText
                        bedFound.address2 = i.Item("address-2").InnerText
                        bedFound.suburb = i.Item("suburb").InnerText
                        bedFound.state = i.Item("state").InnerText
                        bedFound.postcode = i.Item("post-code").InnerText
                        bedFound.country = i.Item("country").InnerText
                        Double.TryParse(i.Item("longitude").InnerText, bedFound.longitude)
                        Double.TryParse(i.Item("latitude").InnerText, bedFound.latitude)
                        bgwRefresh.ReportProgress(REPORT_ADD_BED, bedFound)
                    Catch ex As Exception
                        bgwRefresh.ReportProgress(REPORT_STATUS, "Error while reading bed: " & ex.Message)
                    End Try
                Next i
            End If
        Catch ex As Exception
            bgwRefresh.ReportProgress(REPORT_REFRESH_ERROR, ex.Message)
        End Try
    End Sub

    Private Sub bgwRefresh_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwRefresh.ProgressChanged
        If e.ProgressPercentage = REPORT_CLEAR_LIST Then
            lstMain.Items.Clear()
            lstMain.Items.Add("Refreshing list...")
            lstMain.Enabled = False
        ElseIf e.ProgressPercentage = REPORT_STATUS Then
            lblStatus.Text = e.UserState.ToString()
        ElseIf e.ProgressPercentage = REPORT_ADD_BED Then
            Dim bedFound As Bed
            If Not lstMain.Enabled Then
                lstMain.Items.Clear()
                lstMain.Enabled = True
            End If
            bedFound = DirectCast(e.UserState, Bed)
            lstMain.Items.Add(New ListViewItem(New String() {bedFound.id.ToString(), bedFound.owner, bedFound.phoneNumber, bedFound.fullAddress()}))
        ElseIf e.ProgressPercentage = REPORT_REFRESH_ERROR Then
            MessageBox.Show("Unable to load beds: " & e.UserState.ToString() & ".", "Error Refreshing Beds", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub bgwRefresh_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwRefresh.RunWorkerCompleted
        tsbRefresh.Enabled = True
        RefreshToolStripMenuItem.Enabled = True
        lblStatus.Text = "Idle"
        If Not lstMain.Enabled Then
            lstMain.Items.Clear()
            lstMain.Enabled = True
        End If
    End Sub

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'credentials = New Net.NetworkCredential("red_cross_rep", "test123")
        'url = "http://helpstays.org"
        'url = "http://129.94.108.19:3000"
        defaultResultCount = 50
        hasFilter = False
        'hasFilter = True
        'bedFilter.latitude = -33.88
        'bedFilter.longitude = 151.2
        'bedFilter.radius = 10
        refreshList()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        refreshList()
    End Sub

    Private Sub ApplyFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyFilterToolStripMenuItem.Click
        If IsNothing(filterForm) Then
            filterForm = New FrmFilter()
        End If
        filterForm.ShowDialog()
        If Not filterForm.cancelled Then
            hasFilter = True
            If filterForm.radNone.Checked Then
                bedFilter.dateFilter = DATE_FILTER_NONE
                bedFilter.startDate = Nothing
                bedFilter.endDate = Nothing
            ElseIf filterForm.radBetween.Checked Then
                bedFilter.dateFilter = DATE_FILTER_RANGE
                bedFilter.startDate = filterForm.dtpStart.Value
                bedFilter.endDate = filterForm.dtpEndDate.Value
            Else
                bedFilter.dateFilter = DATE_FILTER_DAY
                bedFilter.startDate = filterForm.dtpOn.Value
                bedFilter.endDate = Nothing
            End If
            If filterForm.chkLocation.Checked Then
                bedFilter.latitude = filterForm.nudLatitude.Value
                bedFilter.longitude = filterForm.nudLongitude.Value
                bedFilter.radius = filterForm.nudRadius.Value
                bedFilter.locationFilter = True
            Else
                bedFilter.latitude = 0
                bedFilter.longitude = 0
                bedFilter.radius = 0
                bedFilter.locationFilter = False
            End If
            If filterForm.chkBeds.Checked Then
                bedFilter.beds = filterForm.nudBeds.Value
            Else
                bedFilter.beds = 0
            End If
            refreshList()
        End If
    End Sub

    Private Sub RemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemToolStripMenuItem.Click
        hasFilter = False
        refreshList()
    End Sub

    Private Sub lstMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMain.SelectedIndexChanged
        mnuReserve.Enabled = (lstMain.SelectedItems.Count <> 0)
    End Sub

    Private Sub reserveBed(ByVal id As Integer, ByVal startDate As Date, ByVal endDate As Date)
        Dim requestUrl As String
        Dim webRequest As Net.WebRequest
        Dim writer As IO.StreamWriter

        lblStatus.Text = "Reserving bed..."
        Try
            requestUrl = url & "/api/v1/beds/reserve_beds"
            webRequest = Net.WebRequest.Create(requestUrl)
            webRequest.Method = "POST"
            webRequest.Credentials = credentials

            writer = New IO.StreamWriter(webRequest.GetRequestStream())
            writer.Write("bed_ids[]=" & id.ToString() & "&start_date=" & startDate.ToString("yyyy-MM-dd") & "&end_date=" & endDate.ToString("yyyy-MM-dd"))
            writer.Flush()
            writer.Close()
            webRequest.GetResponse()
        Catch ex As Exception
            MessageBox.Show("Error while reserving bed: " & ex.Message & ".", "Unable To Reserve Bed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        refreshList()
        lblStatus.Text = "Idle"
    End Sub


    Private Sub mnuReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReserve.Click
        If IsNothing(reservationForm) Then
            reservationForm = New FrmReserve()
        End If
        reservationForm.ShowDialog()
        If Not reservationForm.cancelled Then
            reserveBed(Integer.Parse(lstMain.SelectedItems(0).Text), reservationForm.dtpStartDate.Value, reservationForm.dtpEndDate.Value)
        End If
    End Sub


    Private Sub tsbRefresh_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefresh.ButtonClick
        refreshList()
    End Sub

    Private Sub tsbDefaultCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDefaultCount.Click
        Dim tempCount As String
        Dim parsedInt As Integer

        tempCount = InputBox("Default number of beds to return:", "Default Result Count", "")
        If Integer.TryParse(tempCount, parsedInt) Then
            defaultResultCount = parsedInt
        End If
    End Sub
End Class
