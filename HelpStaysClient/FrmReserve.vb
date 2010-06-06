Public Class FrmReserve

    Public cancelled As Boolean

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmReserve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cancelled = True
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        cancelled = False
        Me.Close()
    End Sub
End Class