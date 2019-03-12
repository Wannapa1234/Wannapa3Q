Public Class frmLab10
    Dim decSale(4, 2) As Integer
    Dim saleName(4) As String
    Dim intIndex, decSumSale As Integer
    Dim sumA, SumB, SumC As Integer
    Dim Max, Total(4) As Integer

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim i As Integer
        If CboIndex.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกพนักงานขาย", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If


        If Not IsNumeric(txtSaleA.Text) Or Not IsNumeric(txtSaleB.Text) Or Not IsNumeric(txtSaleC.Text) Then
            MessageBox.Show("กรุณาใส่ข้อความเป็นตัวเลขเท่านั้น", "ข้อมูลไม่ครบท้วน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleName.Clear()
            CboIndex.Text = ""
            Exit Sub
        Else
            i = Val(CboIndex.SelectedItem) - 1
            saleName(i) = txtSaleName.Text
            decSale(i, 0) = Val(txtSaleA.Text)
            decSale(i, 1) = Val(txtSaleB.Text)
            decSale(i, 2) = Val(txtSaleC.Text)
            txtSaleA.Text = ""
            txtSaleB.Text = ""
            txtSaleC.Text = ""
            txtSaleName.Text = ""

            Call showData()
            sumA = decSale(0, 0) + decSale(1, 0) + decSale(2, 0) + decSale(3, 0) + decSale(4, 0)
            SumB = decSale(0, 1) + decSale(1, 1) + decSale(2, 1) + decSale(3, 1) + decSale(4, 1)
            SumC = decSale(0, 2) + decSale(1, 2) + decSale(2, 2) + decSale(3, 2) + decSale(4, 2)

            lblSumA.Text = sumA
            lblSumB.Text = SumB
            lblSumC.Text = SumC

            Call BomBerB()
            lblMaxSaleName.Text = Name
            lblMaxSaleAmout.Text = Max

        End If



    End Sub

    Private Sub showData()
        lstData.Items.Clear()
        For i = 0 To 4
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))
            Total(i) = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)

        Next

    End Sub

    Private Sub BomBerB()
        For i = 0 To 4
            If Total(i) > Max Then
                Max = Total(i)
                Name = saleName(i)
            Else
                Max = Max
                Name = Name


            End If

        Next

    End Sub



End Class