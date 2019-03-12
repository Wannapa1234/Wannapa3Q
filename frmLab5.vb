Public Class frmLab5
    Dim decDiscount, decNet, decTotal, decCredit As Decimal
    Private Sub frmLab5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radOther.Checked = True
    End Sub
    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = Val(txtPrice.Text) 
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        decTotal = lblTotal.Text
        If txtProduct.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            txtProduct.Clear()

        End If
        If Not IsNumeric(txtPrice.Text) Or Not IsNumeric(txtUnit.Text) Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            txtPrice.Clear()
            txtUnit.Clear()

        End If
        If radMember.Checked = True Then
            decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
            If decTotal < 1000 Then
                decDiscount = 0
            ElseIf decTotal < 5000 Then
                decDiscount = decTotal * 0.05
            ElseIf decTotal < 10000 Then
                decDiscount = decTotal * 0.1
            Else
                decDiscount = decTotal * 0.15
            End If
        ElseIf radOther.Checked = True Then
            decDiscount = 0

        End If

        decNet = decTotal - decDiscount
        If radPaid.Checked = True Then
            decCredit = 0
        ElseIf radCredit.Checked = True Then
            decCredit = decTotal


        End If

        lblDiscount.Text = FormatNumber(decDiscount)
        lblPaid.Text = FormatNumber(decNet)
        lblCredit.Text = FormatNumber(decCredit)



        If radCredit.Checked = True Then
            lblDiscount.Text = 0
            lblPaid.Text = FormatNumber(decTotal)
            lblCredit.Text = FormatNumber(decCredit)
        End If
    End Sub

    Private Sub radMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
        gpbPaid.Enabled = True
        radPaid.Checked = True
        radCredit.Checked = False
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""

    End Sub

    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged
        radPaid.Checked = True
        gpbPaid.Enabled = False
        lblCredit.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub lblTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.Click

    End Sub
End Class