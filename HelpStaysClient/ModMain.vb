Module ModMain

    Public Sub Main()
        Dim loginForm As FrmLogin
        Dim mainForm As FrmMain

        Application.EnableVisualStyles()

        loginForm = New FrmLogin()
        loginForm.ShowDialog()
        If Not loginForm.cancelled Then
            mainForm = New FrmMain()
            mainForm.url = loginForm.cmbServer.Text
            If mainForm.url.EndsWith("/") Then
                mainForm.url = mainForm.url.Substring(0, mainForm.url.Length)
            End If
            mainForm.credentials = New Net.NetworkCredential(loginForm.txtUsername.Text, loginForm.txtPassword.Text)
            Application.Run(mainForm)
        End If
    End Sub
End Module
