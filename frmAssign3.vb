Public Class frmAssign3

    Private Sub frmAssign3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb1.Enter, gb2.Enter

    End Sub

    Private Sub btnHight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHight.Click
        Dim Plus As Integer
        Plus = Val(txtDigis.Text + 2)
        txtDigis.Text = Plus

    End Sub

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim size As Integer = Val(cboSelect.Text)
        txtDigis.Font = New Font(txtDigis.Font.Name, size, FontStyle.Regular)
        txtDigis.Text = FormatNumber(Val(txtDigis.Text), 2)
    End Sub

    Private Sub btnLow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLow.Click
        Dim Down As Integer
        Down = Val(txtDigis.Text - 2)
        txtDigis.Text = Down
    End Sub

    Private Sub lblFRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFRed.Click
        txtDigis.ForeColor = lblFRed.BackColor
    End Sub

    Private Sub lblFBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlue.Click
        txtDigis.ForeColor = lblFBlue.BackColor
    End Sub

    Private Sub lblFGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFGreen.Click
        txtDigis.ForeColor = lblFGreen.BackColor
    End Sub

    Private Sub lblFViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFViolet.Click
        txtDigis.ForeColor = lblFViolet.BackColor
    End Sub

    Private Sub lblFBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlack.Click
        txtDigis.ForeColor = lblFBlack.BackColor
    End Sub

    Private Sub lblFOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFOrange.Click
        txtDigis.ForeColor = lblFOrange.BackColor
    End Sub

    Private Sub lblFYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFYellow.Click
        txtDigis.ForeColor = lblFYellow.BackColor
    End Sub

    Private Sub lblFBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBrown.Click
        txtDigis.ForeColor = lblFBrown.BackColor
    End Sub

    Private Sub lblFWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFWhite.Click
        txtDigis.ForeColor = lblFWhite.BackColor
    End Sub

    Private Sub lblFSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFSky.Click
        txtDigis.ForeColor = lblFSky.BackColor
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        txtDigis.BackColor = lblFRed.BackColor
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        txtDigis.BackColor = lblFBlue.BackColor
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        txtDigis.BackColor = lblFGreen.BackColor
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        txtDigis.BackColor = lblFViolet.BackColor
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        txtDigis.BackColor = lblFBlack.BackColor
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        txtDigis.BackColor = lblFOrange.BackColor
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        txtDigis.BackColor = lblFYellow.BackColor
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        txtDigis.BackColor = lblFBrown.BackColor
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        txtDigis.BackColor = lblFWhite.BackColor
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        txtDigis.BackColor = lblFSky.BackColor
    End Sub
End Class