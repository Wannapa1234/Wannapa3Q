Public Class frmJob6
    Dim a As DialogResult
    Dim price As Integer

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, lblSartPrice.Click, lblItemsPrice3.Click, lblItemsPrice2.Click, lblItemsPrice1.Click, lblItemsPrice4.Click, lblFree3.Click, lblFree2.Click, lblFree1.Click, lblPaidPrice.Click, Label10.Click

    End Sub

    Private Sub chkCarForMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.Click
        Dim Free1, Free2, Free3 As Integer
        Free1 = lblFree1.Text
        Free2 = lblFree2.Text
        Free3 = lblFree3.Text
        If chkCarForMe.Checked = False Then

            a = MessageBox.Show("ต้องการยกเลิกการซื้อรถใช่หรือไม่", "ERROR", MessageBoxButtons.YesNo)
            If a = Windows.Forms.DialogResult.Yes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = ""

            Else
                chkCarForMe.Checked = True
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                
            End If
        Else
            price = Val(lblSartPrice.Text)
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Text = price + Free1 + Free2 + Free3
            Exit Sub
        End If



    End Sub

    Private Sub frmJob6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPaidPrice.Text = ""

    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        Dim price1 As Integer
        price1 = lblItemsPrice1.Text
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + price1
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - price1

        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged
        Dim price2 As Integer
        price2 = lblItemsPrice2.Text
        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + price2
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - price2
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
        Dim price3 As Integer
        price3 = lblItemsPrice3.Text
        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + price3
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - price3
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        Dim price4 As Integer
        price4 = lblItemsPrice4.Text
        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + price4
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - price4
        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        Dim Free1 As Integer
        Free1 = lblFree1.Text
        If chkFree1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Free1

        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Free1
        End If



    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        Dim Free2 As Integer
        Free2 = lblFree2.Text
        If chkFree2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Free2
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Free2
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        Dim Free3 As Integer
        Free3 = lblFree3.Text
        If chkFree3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Free3
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Free3
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class