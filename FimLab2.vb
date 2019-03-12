Public Class FimLab2

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vistra, fritra, total As Integer
        Dim com1, com2, commid As Long

        vistra = Txtvista.Text
        fritra = Txtfrista.Text
        total = vistra + fritra
        Leltotal.Text = total

        com1 = vistra * 0.05
        com2 = fritra * 0.1
        commid = com1 + com2

        Lelcom1.Text = com1
        Lelcom2.Text = com2
        Leltotcom.Text = commid


    End Sub
End Class