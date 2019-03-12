Public Class frmPractice8
    Dim saleTotal, commTotal As Decimal
    Private Sub frmPractice8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Function getCommission(ByVal yourSale As Decimal) As Decimal
        If yourSale <= 5000 Then
            Return 0
        ElseIf yourSale <= 10000 Then
            Return yourSale * 0.025
        ElseIf yourSale <= 50000 Then
            Return yourSale * 0.05
        Else
            Return yourSale * 0.1

        End If
    End Function
    Private Sub startUp()
        txtName.Clear()
        txtYourSale.Clear()
        txtName.Focus()
    End Sub

    Private Sub txtYourSale_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYourSale.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 46 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing

        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim commission As Decimal
        If txtName.Text.Trim() = "" Or txtYourSale.Text.Trim() = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "Error...", MessageBoxButtons.OK)
            txtName.Focus()
            Exit Sub
        Else
            commission = getCommission(Val(txtYourSale.Text))
            saleTotal += CDec(txtYourSale.Text)
            commTotal += commission
            lstData.Items.Add(txtName.Text & "," & txtYourSale.Text & "," & commission)
            lblSaleTotal.Text = saleTotal
            lblCommTotal.Text = commTotal
            Call startUp()
        End If
    End Sub
End Class