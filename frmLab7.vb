Public Class frmLab7
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim M As Integer
        If Not IsNumeric(txtAdd.Text) Then
            MessageBox.Show("ใส่ตัวเลขเท่านั้น")
            txtAdd.Clear()
            txtAdd.Focus()
        End If
        If txtAdd.Text.Trim <> "" Then
            lstAdd.Items.Add(txtAdd.Text)
            M = lstAdd.Items.Count
            lstAdd.SelectedIndex = M - 1
            txtAdd.Clear()
            txtAdd.Focus()
        End If

    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Dim M, R As Integer
        If lstAdd.Text = "" Then
            MessageBox.Show("ไม่มีข้อมูล")
        Else
            R = 0
            M = lstAdd.Items.Count
            cboOutput.SelectedIndex = cboOutput.Items.Add(lstAdd.SelectedItem)
            R = lstAdd.SelectedIndex
            lstAdd.Items.RemoveAt(R)

            If R <> M - 1 Then
                lstAdd.SelectedIndex = R

            ElseIf R = M - 1 Then
                M = lstAdd.Items.Count
                lstAdd.SelectedIndex = M - 1
            End If
        End If
    End Sub

    Private Sub btnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        Dim R, M, count As Integer
        If lstAdd.Text = "" Then
            MessageBox.Show("ไม่มีข้อมูล")
        Else
            count = 0
            M = lstAdd.Items.Count
            For count = 0 To M - 1
                cboOutput.Items.Add(lstAdd.Items(count))
            Next
            R = cboOutput.Items.Count
            cboOutput.SelectedIndex = R - 1
            lstAdd.Items.Clear()

        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim R, M As Integer

        If cboOutput.Text = "" Then
            MessageBox.Show("ไม่มีข้อมูล")
        Else
            R = 0
            M = cboOutput.Items.Count
            lstAdd.SelectedIndex = lstAdd.Items.Add(cboOutput.SelectedItem)
            R = cboOutput.SelectedIndex
            cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)

            If R <> M - 1 Then
                cboOutput.SelectedIndex = R
            ElseIf R = M - 1 Then
                M = cboOutput.Items.Count
                cboOutput.SelectedIndex = M - 1
            End If
        End If
    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        Dim R, M, N As Integer
        If cboOutput.Text = "" Then
            MessageBox.Show("ไม่มีข้อมูล")
        Else
            N = 0
            M = cboOutput.Items.Count
            For N = 0 To M - 1
                lstAdd.Items.Add(cboOutput.Items(N))

            Next
            R = lstAdd.Items.Count
            lstAdd.SelectedIndex = R - 1
            cboOutput.Items.Clear()
            cboOutput.Text = ""
            lblOutput.Text = ""
        End If
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.Text
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cboOutput.Items.Clear()
        txtAdd.Clear()
        lstAdd.Items.Clear()
        lblOutput.Text = ""
        cboOutput.Text = ""
    End Sub

    Private Sub txtAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOutput.Click

    End Sub
End Class