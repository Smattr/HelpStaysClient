Public Class FrmLogin

    Private Const REPORT_FAILURE As Integer = -1
    Private Const REPORT_SUCCESS As Integer = -2

    Public cancelled As Boolean

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        cmbServer.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        btnOK.Enabled = False
        picLoading.Visible = True

        bgwLogin.RunWorkerAsync(cmbServer.Text)
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cancelled = True
    End Sub

    Private Sub bgwLogin_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwLogin.DoWork
        Dim credentials As Net.NetworkCredential
        Dim url As String
        Dim webRequest As Net.WebRequest

        Try
            credentials = New Net.NetworkCredential(txtUsername.Text, txtPassword.Text)

            url = e.Argument.ToString()
            If url.EndsWith("/") Then
                url = url.Substring(0, url.Length - 1)
            End If
            url &= "/api/v1/beds"
            webRequest = Net.WebRequest.Create(url)
            webRequest.Method = "POST"
            webRequest.Credentials = credentials
            webRequest.GetResponse()
            bgwLogin.ReportProgress(REPORT_SUCCESS)
        Catch ex As Exception
            bgwLogin.ReportProgress(REPORT_FAILURE, "Login Failed: " & ex.Message)
        End Try
    End Sub

    Private Sub bgwLogin_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwLogin.ProgressChanged
        If e.ProgressPercentage = REPORT_SUCCESS Then
            cancelled = False
            Me.Close()
        Else
            MessageBox.Show(e.UserState.ToString(), "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub bgwLogin_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLogin.RunWorkerCompleted
        cmbServer.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        btnOK.Enabled = True
        picLoading.Visible = False
    End Sub
End Class