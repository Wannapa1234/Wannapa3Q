<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice4
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblProId = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblProTotal = New System.Windows.Forms.Label()
        Me.lblProNet = New System.Windows.Forms.Label()
        Me.txtProAmount = New System.Windows.Forms.TextBox()
        Me.radProCash = New System.Windows.Forms.RadioButton()
        Me.radProCredit = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคาต่อหน่วย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "การชำระเงิน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(336, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ยอดชำระ"
        '
        'lblProId
        '
        Me.lblProId.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblProId.Location = New System.Drawing.Point(440, 44)
        Me.lblProId.Name = "lblProId"
        Me.lblProId.Size = New System.Drawing.Size(158, 26)
        Me.lblProId.TabIndex = 0
        Me.lblProId.Text = " "
        '
        'lblProName
        '
        Me.lblProName.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblProName.Location = New System.Drawing.Point(440, 86)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(158, 26)
        Me.lblProName.TabIndex = 0
        Me.lblProName.Text = " "
        '
        'lblProPrice
        '
        Me.lblProPrice.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblProPrice.Location = New System.Drawing.Point(440, 123)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(158, 26)
        Me.lblProPrice.TabIndex = 0
        Me.lblProPrice.Text = " "
        Me.lblProPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProTotal
        '
        Me.lblProTotal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblProTotal.Location = New System.Drawing.Point(440, 200)
        Me.lblProTotal.Name = "lblProTotal"
        Me.lblProTotal.Size = New System.Drawing.Size(158, 26)
        Me.lblProTotal.TabIndex = 0
        Me.lblProTotal.Text = " "
        '
        'lblProNet
        '
        Me.lblProNet.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblProNet.Location = New System.Drawing.Point(440, 299)
        Me.lblProNet.Name = "lblProNet"
        Me.lblProNet.Size = New System.Drawing.Size(158, 43)
        Me.lblProNet.TabIndex = 0
        Me.lblProNet.Text = " "
        '
        'txtProAmount
        '
        Me.txtProAmount.Location = New System.Drawing.Point(442, 164)
        Me.txtProAmount.Name = "txtProAmount"
        Me.txtProAmount.Size = New System.Drawing.Size(156, 20)
        Me.txtProAmount.TabIndex = 1
        '
        'radProCash
        '
        Me.radProCash.AutoSize = True
        Me.radProCash.Location = New System.Drawing.Point(444, 257)
        Me.radProCash.Name = "radProCash"
        Me.radProCash.Size = New System.Drawing.Size(56, 17)
        Me.radProCash.TabIndex = 2
        Me.radProCash.TabStop = True
        Me.radProCash.Text = "เงินสด"
        Me.radProCash.UseVisualStyleBackColor = True
        '
        'radProCredit
        '
        Me.radProCredit.AutoSize = True
        Me.radProCredit.Location = New System.Drawing.Point(515, 257)
        Me.radProCredit.Name = "radProCredit"
        Me.radProCredit.Size = New System.Drawing.Size(61, 17)
        Me.radProCredit.TabIndex = 2
        Me.radProCredit.TabStop = True
        Me.radProCredit.Text = "เงินเชื่อ"
        Me.radProCredit.UseVisualStyleBackColor = True
        '
        'frmPractice4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 497)
        Me.Controls.Add(Me.radProCredit)
        Me.Controls.Add(Me.radProCash)
        Me.Controls.Add(Me.txtProAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblProNet)
        Me.Controls.Add(Me.lblProTotal)
        Me.Controls.Add(Me.lblProPrice)
        Me.Controls.Add(Me.lblProName)
        Me.Controls.Add(Me.lblProId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice4"
        Me.Text = "frmPractice4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblProId As System.Windows.Forms.Label
    Friend WithEvents lblProName As System.Windows.Forms.Label
    Friend WithEvents lblProPrice As System.Windows.Forms.Label
    Friend WithEvents lblProTotal As System.Windows.Forms.Label
    Friend WithEvents lblProNet As System.Windows.Forms.Label
    Friend WithEvents txtProAmount As System.Windows.Forms.TextBox
    Friend WithEvents radProCash As System.Windows.Forms.RadioButton
    Friend WithEvents radProCredit As System.Windows.Forms.RadioButton
End Class
