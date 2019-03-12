Public Class frmPractice6
    Dim intSumScore As Integer
    Dim strGrade As String
    Dim drResult As DialogResult
    Private Sub frmPractice6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        txtStudentName.Text = txtStudentName.Text.Trim()
        If txtStudentName.Text.Length = 0 Then
            MessageBox.Show("ท่านไม่ได้ป้อนชื่อนักศึกษากรุณาป้อนให้เรียบร้อย", "lnvalid Data", MessageBoxButtons.OK)
            Exit Sub
        ElseIf Not (IsNumeric(txtLabScore.Text) And IsNumeric(txtMidterm.Enabled) And IsNumeric(txtFinal.Text)) Then
            MessageBox.Show("ท่านป้อนคะแนนบางรายการไม่เป็นตัวเลข", "lnvalid Data", MessageBoxButtons.OK)
            Exit Sub
        ElseIf Val(txtLabScore.Text) < 0 Or Val(txtFinal.Text > 30) Then
            MessageBox.Show("ท่านป้อนคะแนนต่ำหรือสูงเกินเกณฑ์คะแนนที่กำหนด", "lnvalid Data", MessageBoxButtons.OK)
            Exit Sub
        Else
            intSumScore = Val(txtLabScore.Text) + Val(txtMidterm.Text) + Val(txtFinal.Text)
            If intSumScore < 50 Then
                If (40 + Val(txtMidterm.Text) + Val(txtFinal.Text)) >= 50 Then
                    drResult = MessageBox.Show("ระดับคะแนนอยู่ในเกณฑ์ช่วยได้ หากปรับคะแนนเก็บเพิ่มขึ้น" & ControlChars.NewLine & "ท่านต้องการติด I ไว้ก่อนหรือไม่", "สอบถาม", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If drResult = Windows.Forms.DialogResult.Yes Then
                        strGrade = "I"
                    Else
                        strGrade = "F"
                    End If
                Else
                    strGrade = "F"
                End If
            Else
                Select Case intSumScore
                    Case Is < 55 : strGrade = "D"
                    Case Is < 60 : strGrade = "D+"
                    Case Is < 65 : strGrade = "C"
                    Case Is < 70 : strGrade = "C+"
                    Case Is < 75 : strGrade = "B"
                    Case Is < 80 : strGrade = "B+"
                    Case Else : strGrade = "A"
                End Select
            End If
        End If
        lblSumScore.Text = intSumScore
        lblGrade.Text = strGrade
    End Sub
End Class