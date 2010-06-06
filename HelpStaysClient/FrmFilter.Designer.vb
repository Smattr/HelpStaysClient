<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nudBeds = New System.Windows.Forms.NumericUpDown
        Me.grpDate = New System.Windows.Forms.GroupBox
        Me.dtpOn = New System.Windows.Forms.DateTimePicker
        Me.radOn = New System.Windows.Forms.RadioButton
        Me.radBetween = New System.Windows.Forms.RadioButton
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.lblEndDate = New System.Windows.Forms.Label
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.radNone = New System.Windows.Forms.RadioButton
        Me.chkBeds = New System.Windows.Forms.CheckBox
        Me.grpLocation = New System.Windows.Forms.GroupBox
        Me.nudLongitude = New System.Windows.Forms.NumericUpDown
        Me.lblLongitude = New System.Windows.Forms.Label
        Me.nudLatitude = New System.Windows.Forms.NumericUpDown
        Me.lblLatitude = New System.Windows.Forms.Label
        Me.lblRadius = New System.Windows.Forms.Label
        Me.nudRadius = New System.Windows.Forms.NumericUpDown
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.chkLocation = New System.Windows.Forms.CheckBox
        CType(Me.nudBeds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDate.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        CType(Me.nudLongitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLatitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRadius, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudBeds
        '
        Me.nudBeds.Location = New System.Drawing.Point(159, 229)
        Me.nudBeds.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBeds.Name = "nudBeds"
        Me.nudBeds.Size = New System.Drawing.Size(120, 20)
        Me.nudBeds.TabIndex = 7
        Me.nudBeds.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grpDate
        '
        Me.grpDate.Controls.Add(Me.radNone)
        Me.grpDate.Controls.Add(Me.dtpOn)
        Me.grpDate.Controls.Add(Me.radOn)
        Me.grpDate.Controls.Add(Me.radBetween)
        Me.grpDate.Controls.Add(Me.dtpEndDate)
        Me.grpDate.Controls.Add(Me.lblEndDate)
        Me.grpDate.Controls.Add(Me.dtpStart)
        Me.grpDate.Controls.Add(Me.lblStartDate)
        Me.grpDate.Location = New System.Drawing.Point(18, 22)
        Me.grpDate.Name = "grpDate"
        Me.grpDate.Size = New System.Drawing.Size(367, 183)
        Me.grpDate.TabIndex = 8
        Me.grpDate.TabStop = False
        Me.grpDate.Text = "&Date Filter"
        '
        'dtpOn
        '
        Me.dtpOn.Location = New System.Drawing.Point(61, 140)
        Me.dtpOn.Name = "dtpOn"
        Me.dtpOn.Size = New System.Drawing.Size(200, 20)
        Me.dtpOn.TabIndex = 13
        '
        'radOn
        '
        Me.radOn.AutoSize = True
        Me.radOn.Location = New System.Drawing.Point(16, 140)
        Me.radOn.Name = "radOn"
        Me.radOn.Size = New System.Drawing.Size(39, 17)
        Me.radOn.TabIndex = 12
        Me.radOn.Text = "&On"
        Me.radOn.UseVisualStyleBackColor = True
        '
        'radBetween
        '
        Me.radBetween.AutoSize = True
        Me.radBetween.Location = New System.Drawing.Point(16, 74)
        Me.radBetween.Name = "radBetween"
        Me.radBetween.Size = New System.Drawing.Size(67, 17)
        Me.radBetween.TabIndex = 11
        Me.radBetween.Text = "&Between"
        Me.radBetween.UseVisualStyleBackColor = True
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(149, 88)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpEndDate.TabIndex = 10
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(91, 92)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(52, 13)
        Me.lblEndDate.TabIndex = 9
        Me.lblEndDate.Text = "&End Date"
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(149, 62)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 8
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(88, 66)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(55, 13)
        Me.lblStartDate.TabIndex = 7
        Me.lblStartDate.Text = "&Start Date"
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Checked = True
        Me.radNone.Location = New System.Drawing.Point(16, 30)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 14
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'chkBeds
        '
        Me.chkBeds.AutoSize = True
        Me.chkBeds.Location = New System.Drawing.Point(103, 230)
        Me.chkBeds.Name = "chkBeds"
        Me.chkBeds.Size = New System.Drawing.Size(50, 17)
        Me.chkBeds.TabIndex = 9
        Me.chkBeds.Text = "B&eds"
        Me.chkBeds.UseVisualStyleBackColor = True
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.chkLocation)
        Me.grpLocation.Controls.Add(Me.nudRadius)
        Me.grpLocation.Controls.Add(Me.lblRadius)
        Me.grpLocation.Controls.Add(Me.lblLatitude)
        Me.grpLocation.Controls.Add(Me.nudLatitude)
        Me.grpLocation.Controls.Add(Me.lblLongitude)
        Me.grpLocation.Controls.Add(Me.nudLongitude)
        Me.grpLocation.Location = New System.Drawing.Point(18, 271)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(367, 123)
        Me.grpLocation.TabIndex = 10
        Me.grpLocation.TabStop = False
        '
        'nudLongitude
        '
        Me.nudLongitude.DecimalPlaces = 2
        Me.nudLongitude.Location = New System.Drawing.Point(89, 31)
        Me.nudLongitude.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudLongitude.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.nudLongitude.Name = "nudLongitude"
        Me.nudLongitude.Size = New System.Drawing.Size(120, 20)
        Me.nudLongitude.TabIndex = 0
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(29, 33)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(54, 13)
        Me.lblLongitude.TabIndex = 1
        Me.lblLongitude.Text = "Longitude"
        '
        'nudLatitude
        '
        Me.nudLatitude.DecimalPlaces = 2
        Me.nudLatitude.Location = New System.Drawing.Point(90, 57)
        Me.nudLatitude.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudLatitude.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.nudLatitude.Name = "nudLatitude"
        Me.nudLatitude.Size = New System.Drawing.Size(120, 20)
        Me.nudLatitude.TabIndex = 2
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(37, 59)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(45, 13)
        Me.lblLatitude.TabIndex = 3
        Me.lblLatitude.Text = "Latitude"
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(40, 85)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(40, 13)
        Me.lblRadius.TabIndex = 4
        Me.lblRadius.Text = "Radius"
        '
        'nudRadius
        '
        Me.nudRadius.Location = New System.Drawing.Point(90, 83)
        Me.nudRadius.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRadius.Name = "nudRadius"
        Me.nudRadius.Size = New System.Drawing.Size(120, 20)
        Me.nudRadius.TabIndex = 5
        Me.nudRadius.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(112, 411)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(193, 411)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkLocation
        '
        Me.chkLocation.AutoSize = True
        Me.chkLocation.Location = New System.Drawing.Point(16, 0)
        Me.chkLocation.Name = "chkLocation"
        Me.chkLocation.Size = New System.Drawing.Size(67, 17)
        Me.chkLocation.TabIndex = 6
        Me.chkLocation.Text = "&Location"
        Me.chkLocation.UseVisualStyleBackColor = True
        '
        'FrmFilter
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(408, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.chkBeds)
        Me.Controls.Add(Me.grpDate)
        Me.Controls.Add(Me.nudBeds)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apply Filter"
        CType(Me.nudBeds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDate.ResumeLayout(False)
        Me.grpDate.PerformLayout()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        CType(Me.nudLongitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLatitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRadius, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudBeds As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpDate As System.Windows.Forms.GroupBox
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents dtpOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents radOn As System.Windows.Forms.RadioButton
    Friend WithEvents radBetween As System.Windows.Forms.RadioButton
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents chkBeds As System.Windows.Forms.CheckBox
    Friend WithEvents grpLocation As System.Windows.Forms.GroupBox
    Friend WithEvents lblLongitude As System.Windows.Forms.Label
    Friend WithEvents nudLongitude As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRadius As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents lblLatitude As System.Windows.Forms.Label
    Friend WithEvents nudLatitude As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkLocation As System.Windows.Forms.CheckBox
End Class
