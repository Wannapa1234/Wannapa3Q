<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.lblSalaryyear = New System.Windows.Forms.Label()
        Me.lblBonut = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDeduct = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.lblSalary1 = New System.Windows.Forms.Label()
        Me.lblBonut1 = New System.Windows.Forms.Label()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.lblDeduct1 = New System.Windows.Forms.Label()
        Me.lblTax1 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLong = New System.Windows.Forms.RadioButton()
        Me.radGen = New System.Windows.Forms.RadioButton()
        Me.radShort = New System.Windows.Forms.RadioButton()
        Me.btnCaltax = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณภาษี"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDate.Location = New System.Drawing.Point(145, 151)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(52, 35)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "วันที่"
        '
        'lblSalary
        '
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(145, 186)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(82, 35)
        Me.lblSalary.TabIndex = 1
        Me.lblSalary.Text = "เงินเดือน"
        '
        'lblSale
        '
        Me.lblSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSale.Location = New System.Drawing.Point(145, 221)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(136, 35)
        Me.lblSale.TabIndex = 1
        Me.lblSale.Text = "ยอดขายทั้งปี"
        '
        'lblSalaryyear
        '
        Me.lblSalaryyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSalaryyear.Location = New System.Drawing.Point(145, 256)
        Me.lblSalaryyear.Name = "lblSalaryyear"
        Me.lblSalaryyear.Size = New System.Drawing.Size(136, 35)
        Me.lblSalaryyear.TabIndex = 1
        Me.lblSalaryyear.Text = "เงินเดือนทั้งปี"
        '
        'lblBonut
        '
        Me.lblBonut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBonut.Location = New System.Drawing.Point(145, 291)
        Me.lblBonut.Name = "lblBonut"
        Me.lblBonut.Size = New System.Drawing.Size(110, 35)
        Me.lblBonut.TabIndex = 1
        Me.lblBonut.Text = "รับเงินโบนัส"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(145, 326)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(89, 35)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "รวมรายได้"
        '
        'lblDeduct
        '
        Me.lblDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDeduct.Location = New System.Drawing.Point(145, 361)
        Me.lblDeduct.Name = "lblDeduct"
        Me.lblDeduct.Size = New System.Drawing.Size(89, 35)
        Me.lblDeduct.TabIndex = 1
        Me.lblDeduct.Text = "หักค่าลดหย่อน"
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTax.Location = New System.Drawing.Point(145, 396)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(89, 35)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "ภาษีที่ต้องชำระ"
        '
        'lblDate1
        '
        Me.lblDate1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDate1.Location = New System.Drawing.Point(295, 151)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(240, 26)
        Me.lblDate1.TabIndex = 1
        Me.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSalary1
        '
        Me.lblSalary1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSalary1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSalary1.Location = New System.Drawing.Point(296, 256)
        Me.lblSalary1.Name = "lblSalary1"
        Me.lblSalary1.Size = New System.Drawing.Size(240, 26)
        Me.lblSalary1.TabIndex = 1
        Me.lblSalary1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBonut1
        '
        Me.lblBonut1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBonut1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBonut1.Location = New System.Drawing.Point(296, 291)
        Me.lblBonut1.Name = "lblBonut1"
        Me.lblBonut1.Size = New System.Drawing.Size(240, 26)
        Me.lblBonut1.TabIndex = 1
        Me.lblBonut1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal1
        '
        Me.lblTotal1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal1.Location = New System.Drawing.Point(296, 326)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(240, 26)
        Me.lblTotal1.TabIndex = 1
        Me.lblTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDeduct1
        '
        Me.lblDeduct1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDeduct1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDeduct1.Location = New System.Drawing.Point(296, 361)
        Me.lblDeduct1.Name = "lblDeduct1"
        Me.lblDeduct1.Size = New System.Drawing.Size(240, 26)
        Me.lblDeduct1.TabIndex = 1
        Me.lblDeduct1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax1
        '
        Me.lblTax1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTax1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTax1.Location = New System.Drawing.Point(296, 396)
        Me.lblTax1.Name = "lblTax1"
        Me.lblTax1.Size = New System.Drawing.Size(240, 26)
        Me.lblTax1.TabIndex = 1
        Me.lblTax1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(298, 187)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(237, 20)
        Me.txtSalary.TabIndex = 0
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(298, 221)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(237, 20)
        Me.txtSale.TabIndex = 1
        Me.txtSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radLong)
        Me.GroupBox1.Controls.Add(Me.radGen)
        Me.GroupBox1.Controls.Add(Me.radShort)
        Me.GroupBox1.Location = New System.Drawing.Point(663, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 183)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบวันที่"
        '
        'radLong
        '
        Me.radLong.AutoSize = True
        Me.radLong.Location = New System.Drawing.Point(34, 101)
        Me.radLong.Name = "radLong"
        Me.radLong.Size = New System.Drawing.Size(121, 17)
        Me.radLong.TabIndex = 0
        Me.radLong.TabStop = True
        Me.radLong.Text = "วันที่แบบ Long Date"
        Me.radLong.UseVisualStyleBackColor = True
        '
        'radGen
        '
        Me.radGen.AutoSize = True
        Me.radGen.Location = New System.Drawing.Point(34, 78)
        Me.radGen.Name = "radGen"
        Me.radGen.Size = New System.Drawing.Size(134, 17)
        Me.radGen.TabIndex = 0
        Me.radGen.TabStop = True
        Me.radGen.Text = "วันที่แบบ General Date"
        Me.radGen.UseVisualStyleBackColor = True
        '
        'radShort
        '
        Me.radShort.AutoSize = True
        Me.radShort.Location = New System.Drawing.Point(34, 55)
        Me.radShort.Name = "radShort"
        Me.radShort.Size = New System.Drawing.Size(122, 17)
        Me.radShort.TabIndex = 0
        Me.radShort.TabStop = True
        Me.radShort.Text = "วันที่แบบ Short Date"
        Me.radShort.UseVisualStyleBackColor = True
        '
        'btnCaltax
        '
        Me.btnCaltax.Location = New System.Drawing.Point(670, 399)
        Me.btnCaltax.Name = "btnCaltax"
        Me.btnCaltax.Size = New System.Drawing.Size(147, 50)
        Me.btnCaltax.TabIndex = 5
        Me.btnCaltax.Text = "คำนวณ"
        Me.btnCaltax.UseVisualStyleBackColor = True
        '
        'frmLab4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 544)
        Me.Controls.Add(Me.btnCaltax)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblDeduct)
        Me.Controls.Add(Me.lblTax1)
        Me.Controls.Add(Me.lblDeduct1)
        Me.Controls.Add(Me.lblTotal1)
        Me.Controls.Add(Me.lblBonut1)
        Me.Controls.Add(Me.lblSalary1)
        Me.Controls.Add(Me.lblDate1)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblBonut)
        Me.Controls.Add(Me.lblSalaryyear)
        Me.Controls.Add(Me.lblSale)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab4"
        Me.Text = "frmLab4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents lblSale As System.Windows.Forms.Label
    Friend WithEvents lblSalaryyear As System.Windows.Forms.Label
    Friend WithEvents lblBonut As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDeduct As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents lblSalary1 As System.Windows.Forms.Label
    Friend WithEvents lblBonut1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal1 As System.Windows.Forms.Label
    Friend WithEvents lblDeduct1 As System.Windows.Forms.Label
    Friend WithEvents lblTax1 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtSale As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radLong As System.Windows.Forms.RadioButton
    Friend WithEvents radGen As System.Windows.Forms.RadioButton
    Friend WithEvents radShort As System.Windows.Forms.RadioButton
    Friend WithEvents btnCaltax As System.Windows.Forms.Button
End Class
