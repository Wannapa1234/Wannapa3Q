Public Class Practice_sheet1_1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, lblFullName.Click

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        lblFullName.Text = txtFirstName.Text & " " & txtLastName.Text
    End Sub
End Class