<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.cmbServer = New System.Windows.Forms.ComboBox
        Me.lblServer = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.lblUsername = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.picLoading = New System.Windows.Forms.PictureBox
        Me.bgwLogin = New System.ComponentModel.BackgroundWorker
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbServer
        '
        Me.cmbServer.FormattingEnabled = True
        Me.cmbServer.Items.AddRange(New Object() {"http://helpstays.org", "http://129.94.108.19:3000"})
        Me.cmbServer.Location = New System.Drawing.Point(79, 21)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Size = New System.Drawing.Size(201, 21)
        Me.cmbServer.TabIndex = 0
        Me.cmbServer.Text = "http://helpstays.org"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(32, 24)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(41, 13)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "&Server:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(79, 48)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(201, 20)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Text = "red_cross_rep"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(15, 51)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(79, 74)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(201, 20)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "test123"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(17, 77)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(63, 114)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(144, 114)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picLoading
        '
        Me.picLoading.Image = CType(resources.GetObject("picLoading.Image"), System.Drawing.Image)
        Me.picLoading.Location = New System.Drawing.Point(225, 117)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(16, 16)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLoading.TabIndex = 8
        Me.picLoading.TabStop = False
        Me.picLoading.Visible = False
        '
        'bgwLogin
        '
        Me.bgwLogin.WorkerReportsProgress = True
        Me.bgwLogin.WorkerSupportsCancellation = True
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(292, 157)
        Me.Controls.Add(Me.picLoading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.cmbServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HelpStays Login"
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbServer As System.Windows.Forms.ComboBox
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picLoading As System.Windows.Forms.PictureBox
    Friend WithEvents bgwLogin As System.ComponentModel.BackgroundWorker
End Class
