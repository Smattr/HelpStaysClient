Public Class FrmFilter

    Public cancelled As Boolean

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cancelled = True
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        cancelled = False
        Me.Close()
    End Sub

    Private Sub radBetween_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBetween.CheckedChanged
        If radBetween.Checked Then
            dtpStart.Enabled = True
            dtpEndDate.Enabled = True
        Else
            dtpStart.Enabled = False
            dtpEndDate.Enabled = False
        End If
    End Sub

    Private Sub radNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNone.CheckedChanged
        If radNone.Checked Then
            dtpStart.Enabled = False
            dtpEndDate.Enabled = False
            dtpOn.Enabled = False
        End If
    End Sub

    Private Sub radOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOn.CheckedChanged
        If radOn.Checked Then
            dtpOn.Enabled = True
            dtpStart.Enabled = False
            dtpEndDate.Enabled = False
        End If
    End Sub
End Class