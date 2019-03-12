Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim salary As Integer

        name = Txtname.Text
        salary = Txtsalary.Text

        Lelname.Text = name
        Lelsalary.Text = salary
        Lelyear.Text = Lelsalary.Text * 12
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtsalary.TextChanged

    End Sub
End Class
