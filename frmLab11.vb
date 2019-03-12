Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmLab11
    Dim strConn As String = ConfigurationManager.ConnectionStrings("Project3Q.My.MySettings.mycon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim selectRow As Integer
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnChoice1_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice1.Click
        strSql = "select * from products where productname LIKE 'n%'"

        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        da.Fill(ds, "tbData")

        dgvData.DataSource = ds.Tables("tbData")
        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 200
        dgvData.Columns(2).Width = 100
        dgvData.Columns(3).Width = 100
        dgvData.Columns(4).Width = 200
        dgvData.Columns(5).Width = 100
        dgvData.Columns(6).Width = 100
        dgvData.Columns(7).Width = 100
        dgvData.Columns(8).Width = 100
        dgvData.Columns(9).Width = 100

    End Sub
    Private Sub convb()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()

        End If
        Conn.ConnectionString = strConn
        Conn.Open()

    End Sub

    Private Sub frmLab11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Conn.State = ConnectionState.Open Then
            Conn.Close()

        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub

   
    Private Sub btnChoice2_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice2.Click
       Call convb()

        strSql = "select productID,productname,unitprice,unitsinstock,(unitprice*unitsinstock)from products where productID  LIKE '%64%'"

        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        da.Fill(ds, "tbData1")

        dgvData.DataSource = ds.Tables("tbData1")
        
        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 150
        dgvData.Columns(2).Width = 100
        dgvData.Columns(3).Width = 100
        dgvData.Columns(4).Width = 100

        Conn.Close()

    End Sub

    Private Sub btnChoice3_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice3.Click
        Call convb()
        strSql = "select country,count(customerID) from customers GROUP BY country HAVING country='Brazil' "
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        

        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 100

        Conn.Close()

    End Sub

    Private Sub btnChoice4_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice4.Click
        Call convb()
        strSql = "SELECT dbo.Products.ProductName,dbo.[Order Details].Quantity,dbo.Customers.ContactName FROM dbo.[Order Details]INNER JOIN dbo.Orders ON dbo.[Order Details].OrderID = dbo.Orders.OrderID INNER JOIN dbo.Customers ON dbo.Customers.CustomerID = dbo.Orders.CustomerID INNER JOIN dbo.Products ON dbo.[Order Details].ProductID = dbo.Products.ProductID where Customers.ContactName ='Yang Wang' "
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData4")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData4")
        

        dgvData.Columns(0).Width = 200
        dgvData.Columns(1).Width = 200
        dgvData.Columns(2).Width = 200

        Conn.Close()
    End Sub

    Private Sub btnChoice5_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice5.Click
        Call convb()
        strSql = "select productname,unitsinstock from products where unitsinstock < '10'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData5")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData5")
       


        dgvData.Columns(0).Width = 200
        dgvData.Columns(1).Width = 200


        Conn.Close()
    End Sub

    Private Sub btnChoice6_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice6.Click
        Call convb()
        strSql = "SELECT dbo.[Order Details].OrderID,dbo.Products.ProductName,dbo.[Order Details].Quantity FROM dbo.Products INNER JOIN dbo.[Order Details] ON dbo.Products.ProductID = dbo.[Order Details].ProductID WHERE [Order Details].OrderID = '10255'"

        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData6")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData6")
        dgvData.Columns(0).Width = 200
        dgvData.Columns(1).Width = 200
        dgvData.Columns(2).Width = 200


        Conn.Close()
    End Sub

    Private Sub btnChoice7_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice7.Click
        Call convb()

        strSql = "SELECT [Order Details].OrderID,sum(Quantity * UnitPrice) as Total from [Order Details] where [Order Details].OrderID='10255' GROUP BY OrderID"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        dgvData.Columns(0).HeaderCell.Value = "เลขที่ใบสั่งซื้อ"

        dgvData.Columns(0).Width = 100


        Conn.Close()
       

      


    End Sub

    Private Sub btnChoice8_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice8.Click
        Call convb()
        strSql = "SELECT dbo.Orders.OrderID,dbo.Customers.CustomerID,dbo.Customers.CompanyName,dbo.Customers.ContactName,dbo.Customers.ContactTitle,dbo.Customers.Address,dbo.Customers.City,dbo.Customers.Region,dbo.Customers.PostalCode,dbo.Customers.Country FROM dbo.Customers INNER JOIN dbo.Orders ON dbo.Orders.CustomerID = dbo.Customers.CustomerID WHERE Orders.OrderID = '10347'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData7")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData7")
        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 200
        dgvData.Columns(2).Width = 200
        dgvData.Columns(3).Width = 200
        dgvData.Columns(4).Width = 200
        dgvData.Columns(5).Width = 200
        dgvData.Columns(6).Width = 100
        dgvData.Columns(7).Width = 100
        dgvData.Columns(8).Width = 200
        dgvData.Columns(9).Width = 100
        Conn.Close()

    End Sub

    Private Sub btnChoice9_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice9.Click
        Call convb()
        strSql = "SELECT dbo.Suppliers.CompanyName,dbo.Products.ProductName FROM dbo.Suppliers INNER JOIN dbo.Products ON dbo.Suppliers.SupplierID = dbo.Products.SupplierID WHERE dbo.Suppliers.CompanyName = 'Exotic Liquids' "
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData7")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData7")
        dgvData.Columns(0).Width = 200
        dgvData.Columns(1).Width = 200

        Conn.Close()


    End Sub

    Private Sub btnChoice10_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice10.Click
        Call convb()
        strSql = "SELECT  count (dbo.Customers.Country) from Orders, Customers where (Orders.CustomerID = Customers.CustomerID)and  Customers.Country='italy'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData7")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData7")
        dgvData.Columns(0).HeaderCell.Value = "จำนวนครั้ง"
        dgvData.Columns(0).Width = 150
        Conn.Close()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class