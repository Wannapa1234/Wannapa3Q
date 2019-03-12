<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign3
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
        Me.txtDigis = New System.Windows.Forms.TextBox()
        Me.btnHight = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gb1.SuspendLayout()
        Me.gb2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDigis
        '
        Me.txtDigis.Location = New System.Drawing.Point(251, 52)
        Me.txtDigis.Multiline = True
        Me.txtDigis.Name = "txtDigis"
        Me.txtDigis.Size = New System.Drawing.Size(260, 58)
        Me.txtDigis.TabIndex = 0
        '
        'btnHight
        '
        Me.btnHight.Location = New System.Drawing.Point(512, 58)
        Me.btnHight.Name = "btnHight"
        Me.btnHight.Size = New System.Drawing.Size(31, 23)
        Me.btnHight.TabIndex = 1
        Me.btnHight.Text = "+"
        Me.btnHight.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(512, 79)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(31, 23)
        Me.btnLow.TabIndex = 1
        Me.btnLow.Text = "-"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'cboSelect
        '
        Me.cboSelect.AutoCompleteCustomSource.AddRange(New String() {"2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22"})
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14", "16", "18", "20"})
        Me.cboSelect.Location = New System.Drawing.Point(475, 149)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(115, 21)
        Me.cboSelect.TabIndex = 2
        '
        'gb1
        '
        Me.gb1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.gb1.Controls.Add(Me.lblFSky)
        Me.gb1.Controls.Add(Me.lblFBlue)
        Me.gb1.Controls.Add(Me.lblFWhite)
        Me.gb1.Controls.Add(Me.lblFRed)
        Me.gb1.Controls.Add(Me.lblFBlack)
        Me.gb1.Controls.Add(Me.lblFOrange)
        Me.gb1.Controls.Add(Me.lblFBrown)
        Me.gb1.Controls.Add(Me.lblFGreen)
        Me.gb1.Controls.Add(Me.lblFViolet)
        Me.gb1.Controls.Add(Me.lblFYellow)
        Me.gb1.Location = New System.Drawing.Point(75, 249)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(241, 110)
        Me.gb1.TabIndex = 3
        Me.gb1.TabStop = False
        Me.gb1.Text = " ForColor"
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.Aqua
        Me.lblFSky.Location = New System.Drawing.Point(177, 66)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(34, 29)
        Me.lblFSky.TabIndex = 55
        Me.lblFSky.Text = " "
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(57, 27)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(34, 29)
        Me.lblFBlue.TabIndex = 51
        Me.lblFBlue.Text = " "
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.Snow
        Me.lblFWhite.Location = New System.Drawing.Point(137, 66)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(34, 29)
        Me.lblFWhite.TabIndex = 58
        Me.lblFWhite.Text = " "
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(17, 27)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(34, 29)
        Me.lblFRed.TabIndex = 54
        Me.lblFRed.Text = " "
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(177, 27)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(34, 29)
        Me.lblFBlack.TabIndex = 57
        Me.lblFBlack.Text = " "
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.OrangeRed
        Me.lblFOrange.Location = New System.Drawing.Point(17, 66)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(34, 29)
        Me.lblFOrange.TabIndex = 52
        Me.lblFOrange.Text = " "
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.Brown
        Me.lblFBrown.Location = New System.Drawing.Point(97, 66)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(34, 29)
        Me.lblFBrown.TabIndex = 56
        Me.lblFBrown.Text = " "
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Green
        Me.lblFGreen.Location = New System.Drawing.Point(97, 27)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(34, 29)
        Me.lblFGreen.TabIndex = 53
        Me.lblFGreen.Text = " "
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Violet
        Me.lblFViolet.Location = New System.Drawing.Point(137, 27)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(34, 29)
        Me.lblFViolet.TabIndex = 50
        Me.lblFViolet.Text = " "
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(57, 66)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(34, 29)
        Me.lblFYellow.TabIndex = 49
        Me.lblFYellow.Text = " "
        '
        'gb2
        '
        Me.gb2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.gb2.Controls.Add(Me.Label10)
        Me.gb2.Controls.Add(Me.Label2)
        Me.gb2.Controls.Add(Me.Label9)
        Me.gb2.Controls.Add(Me.Label1)
        Me.gb2.Controls.Add(Me.Label8)
        Me.gb2.Controls.Add(Me.Label3)
        Me.gb2.Controls.Add(Me.Label7)
        Me.gb2.Controls.Add(Me.Label4)
        Me.gb2.Controls.Add(Me.Label6)
        Me.gb2.Controls.Add(Me.Label5)
        Me.gb2.Location = New System.Drawing.Point(322, 249)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(241, 110)
        Me.gb2.TabIndex = 3
        Me.gb2.TabStop = False
        Me.gb2.Text = "BgColor"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Aqua
        Me.Label10.Location = New System.Drawing.Point(180, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 29)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = " "
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Violet
        Me.Label2.Location = New System.Drawing.Point(140, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 29)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = " "
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(60, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 29)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = " "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(60, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 29)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = " "
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(140, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 29)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = " "
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(100, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 29)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = " "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(20, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 29)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = " "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(100, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 29)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = " "
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(180, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 29)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = " "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(20, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 29)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = " "
        '
        'frmAssign3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 441)
        Me.Controls.Add(Me.gb2)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHight)
        Me.Controls.Add(Me.txtDigis)
        Me.Name = "frmAssign3"
        Me.Text = "Form3"
        Me.gb1.ResumeLayout(False)
        Me.gb2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDigis As System.Windows.Forms.TextBox
    Friend WithEvents btnHight As System.Windows.Forms.Button
    Friend WithEvents btnLow As System.Windows.Forms.Button
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFSky As System.Windows.Forms.Label
    Friend WithEvents lblFBlue As System.Windows.Forms.Label
    Friend WithEvents lblFWhite As System.Windows.Forms.Label
    Friend WithEvents lblFRed As System.Windows.Forms.Label
    Friend WithEvents lblFBlack As System.Windows.Forms.Label
    Friend WithEvents lblFOrange As System.Windows.Forms.Label
    Friend WithEvents lblFBrown As System.Windows.Forms.Label
    Friend WithEvents lblFGreen As System.Windows.Forms.Label
    Friend WithEvents lblFViolet As System.Windows.Forms.Label
    Friend WithEvents lblFYellow As System.Windows.Forms.Label
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
