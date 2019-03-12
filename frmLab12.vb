Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmLab12
    Dim strConn As String = ConfigurationManager.ConnectionStrings("Project3Q.My.MySettings.myconn").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim selectRow As Integer
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim userAct As String
    Dim oldEmpID As String
    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub
    Private Sub frmLab12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        Call LoadDepartment()
        panEmp.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

    End Sub
    Private Sub LoadData()
        Call conDB()
        strSql = "SELECT dbo.tbEmployee.empId,dbo.tbEmployee.empName,dbo.tbEmployee.empLname,dbo.tbEmployee.salary,dbo.tbDepartment.depName FROM dbo.tbEmployee INNER JOIN dbo.tbDepartment ON dbo.tbEmployee.depId = dbo.tbDepartment.depId"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbEmployee")
        DgvEmp.ReadOnly = True
        DgvEmp.DataSource = ds.Tables("tbEmployee")

        DgvEmp.Columns(0).Width = 100
        DgvEmp.Columns(1).Width = 100
        DgvEmp.Columns(2).Width = 100
        DgvEmp.Columns(3).Width = 100
        DgvEmp.Columns(4).Width = 100
        Conn.Close()
    End Sub
    Private Sub LoadDepartment()
        Call conDB()
        strSql = "select * from tbDepartment"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandTimeout = 15
        mycomm.CommandType = CommandType.Text
        myDR = mycomm.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read
                cboDepart.Items.Add(myDR.Item("depName"))
            End While
            cboDepart.SelectedIndex = 0
            myDR.Close()
        Else
            MessageBox.Show("ยังไม่มีข้อมูลตำแหน่งในระบบ ไม่สามารถจัดการข้อมูลพนักงานได้" & Chr(10) & "กรุณาดำเนินการในส่วนการจัดการตำแหน่งก่อน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myDR.Close()
            Me.Close()
        End If


    End Sub


    Private Sub DgvEmp_CellContentClick(sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvEmp.CellEnter
        If DgvEmp.RowCount = 0 Or DgvEmp.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim r As Integer = DgvEmp.CurrentCell.RowIndex
        Dim eid As String = DgvEmp.Item(0, r).Value
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        conDB()
        strSql = "SELECT tbEmployee.*,tbDepartment.depName from tbEmployee,tbDepartment where tbEmployee.depId = tbDepartment.depId and tbEmployee.empId = @eid"

        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@eid", eid)
        myDR = mycomm.ExecuteReader
        myDR.Read()
        txtEmpId.Text = myDR.Item("empId")
        txtEmpName.Text = myDR.Item("empName")
        txtLname.Text = myDR.Item("empLname")
        txtAddress.Text = myDR.Item("address")
        txtSalary.Text = myDR.Item("Salary")
        If myDR.Item("sex") = "1" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If

        For i = 0 To cboDepart.Items.Count - 1
            If cboDepart.Items(i) = myDR.Item("depName") Then
                cboDepart.SelectedIndex = i
                Exit For
            End If
        Next
        myDR.Close()
        myDR.Close()
    End Sub

    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
        panEmp.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        txtEmpName.Clear()
        txtLname.Clear()
        txtAddress.Clear()
        txtSalary.Clear()
        txtEmpId.Clear()

        userAct = "Insert"
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        panEmp.Enabled = False
        txtEmpName.Clear()
        txtLname.Clear()
        txtAddress.Clear()
        txtSalary.Clear()
        txtEmpId.Clear()
        DgvEmp.Enabled = True
        btnClose.Enabled = True
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnInsert.Enabled = True


    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        DgvEmp.Enabled = False
        panEmp.Enabled = True
        txtEmpId.Focus()
        btnInsert.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        txtEmpId.Enabled = True
        userAct = "Edit"
        oldEmpID = txtEmpId.Text
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("โปรดยืนยันการลบข้อมูลพนักงาน รหัส: " & txtEmpId.Text & " ชื่อ: " & txtEmpName.Text & "  " & txtLname.Text, "โปรดระวัง..", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If dgr = Windows.Forms.DialogResult.Yes Then
            conDB()
            strSql = "Delete From tbEmployee where empID = @eid "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("eid", txtEmpId.Text)
            mycomm.ExecuteNonQuery()
            Call LoadData()
            MessageBox.Show("ลบข้อมูลพนักงานที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        txtEmpId.Text = txtEmpId.Text.Trim()
        txtEmpName.Text = txtEmpName.Text.Trim()
        txtLname.Text = txtLname.Text.Trim()
        txtAddress.Text = txtAddress.Text.Trim()
        If txtEmpId.Text = "" Or txtEmpName.Text = "" Or txtLname.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmpId.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtSalary.Text) Then
            MessageBox.Show("ท่านป้อนข้อมูลเงินเดือนไม่ถูกต้อง" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSalary.Focus()
            Exit Sub
        Else
            'บันทึก 
            Dim gender As String
            Dim depID As String

            If radMale.Checked Then
                gender = "1"
            Else
                gender = "2"
            End If

            conDB()
            strSql = "select depID from tbDepartment where depName = @cname "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("cname", cboDepart.SelectedItem)
            myDR = mycomm.ExecuteReader
            myDR.Read()
            depID = myDR.Item("depID")
            myDR.Close()


            If userAct = "Insert" Then 'เพิ่ม
                'เช็ค PK
                strSql = "select empID from tbEmployee where empID = @eid "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myDR = mycomm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสพนักงานที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If

                myDR.Close()
                strSql = "Insert into tbEmployee(empId, empName, empLname, Address, sex, salary, depID) " & _
                    " Values(@eid, @ename, @eLname, @eadd, @egen, @esalary, @depid)  "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("eid", txtEmpId.Text)
                mycomm.Parameters.AddWithValue("ename", txtEmpName.Text)
                mycomm.Parameters.AddWithValue("eLname", txtLname.Text)
                mycomm.Parameters.AddWithValue("eadd", txtAddress.Text)
                mycomm.Parameters.AddWithValue("egen", gender)
                mycomm.Parameters.AddWithValue("esalary", txtSalary.Text)
                mycomm.Parameters.AddWithValue("depid", depID)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else 'แก้ไข 
                If oldEmpID <> txtEmpId.Text Then 'มีการเปลี่ยนแปลงรหัสพนักงาน
                    'เช็ค PK
                    strSql = "select empID from tbEmployee where empID = @eid "
                    mycomm = New SqlCommand(strSql, Conn)
                    mycomm.CommandType = CommandType.Text
                    mycomm.CommandTimeout = 15
                    mycomm.Parameters.AddWithValue("eid", txtEmpId.Text)
                    myDR = mycomm.ExecuteReader
                    If myDR.HasRows Then
                        myDR.Read()
                        If myDR.Item("empID") <> oldEmpID Then
                            MessageBox.Show("รหัสพนักงานที่ท่านเปลี่ยนแปลง เป็นรหัสของพนักงานคนอื่นที่ใช้อยู่ในระบบ" & Chr(10) & "ต้องการที่จะแก้ไขรหัสพนักงานนี้ใช่หรือไม่ ?", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            myDR.Close()
                            Exit Sub
                        End If
                    End If
                    myDR.Close()

                End If

                strSql = "Update tbEmployee Set empId = @eid, empName=@ename, empLname=@esurname, sex=@eadd, address=@egen,salary=@esalary,depId=@depid where empId = @eoid"
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("eid", txtEmpId.Text)
                mycomm.Parameters.AddWithValue("ename", txtEmpName.Text)
                mycomm.Parameters.AddWithValue("esurname", txtLname.Text)
                mycomm.Parameters.AddWithValue("eadd", txtAddress.Text)
                mycomm.Parameters.AddWithValue("egen", gender)
                mycomm.Parameters.AddWithValue("esalary", txtSalary.Text)
                mycomm.Parameters.AddWithValue("depid", depID)
                mycomm.Parameters.AddWithValue("eoid", oldEmpID)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("แก้ไขข้อมูลพนักงานเรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

End Class