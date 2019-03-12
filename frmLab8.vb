Public Class frmLab8
    Dim sumScore, sumCredit, score, credit As Decimal
    Dim g As String

    Private Function getGrade(ByVal sumScore As Decimal) As String
        If score >= 80 Then
            Return "A"
        ElseIf score >= 75 Then
            Return "B+"
        ElseIf score >= 70 Then
            Return "B"
        ElseIf score >= 65 Then
            Return "C+"
        ElseIf score >= 60 Then
            Return "C"
        ElseIf score >= 55 Then
            Return "D+"
        ElseIf score >= 50 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function


    Private Function getCalNewGPA()

        getCalNewGPA = Val(sumScore) / Val(sumCredit)
        Return getCalNewGPA
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        txtSubject.Text = ""
        txtScore.Text = ""
        txtCredit.Text = ""
        txtSubject.Focus()



    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtSubject.Text = txtSubject.Text.Trim
        If txtSubject.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่ครบ กรุณาตรวจสอบใหม่อีกครั้ง", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        txtScore.Text = txtScore.Text.Trim
        If Not IsNumeric(txtScore.Text) Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่ครบ คะแนนป้อนตัวเลขเท่านั้น", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        End If

        txtCredit.Text = txtCredit.Text.Trim
        If Not IsNumeric(txtCredit.Text) Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่ครบ หน่วยกิต ป้อนตัวเลข 1-4 เท่านั้น", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        End If
        If txtCredit.Text < 1 Or txtCredit.Text > 4 Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่ครบ หน่วยกิต ป้อนตัวเลข 1-4 เท่านั้น", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        End If
        lstSubject.Items.Add(txtSubject.Text)
        lstSubject.SelectedIndex = lstSubject.Items.Count - 1
        txtSubject.Text = ""


        score = txtScore.Text
        lstScore.Items.Add(txtScore.Text)
        lstScore.SelectedIndex = lstScore.Items.Count - 1
        txtScore.Text = ""


        credit = txtCredit.Text
        lstCredit.Items.Add(txtCredit.Text)
        lstCredit.SelectedIndex = lstCredit.Items.Count - 1
        txtCredit.Text = ""

        lblOldTotalScore.Text = sumScore
        lblTotalCredit.Text = sumCredit

        g = getGrade(sumScore)
        lstGrade.Items.Add(g)
        lstGrade.SelectedIndex = lstCredit.Items.Count - 1

        Call proCalNewData()




    End Sub

    Private Sub lstSubject_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstSubject.MouseClick
        Dim i As Integer
        i = lstSubject.SelectedIndex
        If i <= lstSubject.Items.Count - 1 Then
            lstCredit.SelectedIndex = i
            lstGrade.SelectedIndex = i
            lstScore.SelectedIndex = i
        End If
    End Sub

    Private Sub lstScore_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstScore.MouseClick
        Dim i As Integer
        i = lstScore.SelectedIndex
        If i <= lstScore.Items.Count - 1 Then
            lstCredit.SelectedIndex = i
            lstGrade.SelectedIndex = i
            lstSubject.SelectedIndex = i
        End If
    End Sub

    Private Sub lstCredit_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCredit.MouseClick
        Dim i As Integer
        i = lstCredit.SelectedIndex
        If i <= lstCredit.Items.Count - 1 Then
            lstSubject.SelectedIndex = i
            lstGrade.SelectedIndex = i
            lstScore.SelectedIndex = i
        End If
    End Sub

    Private Sub lstGrade_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstGrade.MouseClick
        Dim i As Integer
        i = lstGrade.SelectedIndex
        If i <= lstGrade.Items.Count - 1 Then
            lstSubject.SelectedIndex = i
            lstCredit.SelectedIndex = i
            lstScore.SelectedIndex = i
        End If
    End Sub
    Private Sub proCalNewData()
        Dim i As Integer = 0
        Dim Grade, Credit, NewGrade As Decimal
        Do Until i > lstGrade.Items.Count - 1
            Select Case lstGrade.Items(i)
                Case "F" : Grade = 0
                Case "D" : Grade = 1
                Case "D+" : Grade = 1.5
                Case "C" : Grade = 2
                Case "C+" : Grade = 2.5
                Case "B" : Grade = 3
                Case "B+" : Grade = 3.5
                Case "A" : Grade = 4
            End Select
            NewGrade += Grade * lstCredit.Items(i)
            Credit += lstCredit.Items(i)
            i += 1
        Loop
        sumScore = 150 + NewGrade
        sumCredit = 50 + Credit
        lblNewGPA.Text = FormatNumber(sumScore / sumCredit, 2)
    End Sub

    Private Sub frmLab8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sumCredit = 50
        sumScore = 150
        lblOldTotalScore.Text = sumScore
        lblTotalCredit.Text = sumCredit
        lblOldGPA.Text = "3.00"
    End Sub
End Class

