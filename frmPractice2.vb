Public Class frmPractice2

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label3.Click

    End Sub

    Private Sub radUs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUs.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 39
    End Sub

    Private Sub radFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFrench.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 37
    End Sub

    Private Sub radKorea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radKorea.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 30
    End Sub

    Private Sub radLock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLock.CheckedChanged
        txtBaht.Enabled = False
        radUs.Enabled = False
        radFrench.Enabled = False
        radKorea.Enabled = False
    End Sub

    Private Sub radUnLock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUnLock.CheckedChanged
        txtBaht.Enabled = False
        radUs.Enabled = False
        radFrench.Enabled = True
        radKorea.Enabled = True

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class