Public Class frmPractice7

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub lstNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNumber.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtAdd.Text.Trim() = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล")
        ElseIf Not IsNumeric(txtAdd.Text) Then
            MessageBox.Show("กรุณาป้อนตัวเลข")
        Else
            lstNumber.Items.Add(txtAdd.Text)
            Call cal_sys()
        End If
        txtAdd.Clear()
        txtAdd.Focus()
    End Sub
    Private Sub cal_sys()
        Dim i, total, max, min, Avg As Single
        max = lstNumber.Items(0)
        min = lstNumber.Items(0)
        For i = 0 To lstNumber.Items.Count - 1
            total += Val(lstNumber.Items(i))
            If max < Val(lstNumber.Items(i)) Then
                max = Val(lstNumber.Items(i))
            End If
            If min > Val(lstNumber.Items(i)) Then
                min = Val(lstNumber.Items(i))
            End If
        Next i
        Avg = total / lstNumber.Items.Count
        lblTotal.Text = total
        lblMax.Text = max
        lblMin.Text = min
        lblAverage.Text = FormatNumber(Avg)
    End Sub
End Class