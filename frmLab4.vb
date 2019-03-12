Public Class frmLab4
    Dim Today As Date = Date.Now
    Private Sub radShort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShort.CheckedChanged
        lblDate1.Text = FormatDateTime(Today, DateFormat.ShortDate)

    End Sub
    Private Sub radGen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGen.CheckedChanged
        lblDate1.Text = FormatDateTime(Today, DateFormat.GeneralDate)

    End Sub
    Private Sub radLong_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLong.CheckedChanged
        lblDate1.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub

    Private Sub btnCaltax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaltax.Click

        Dim Tax, yearsalary, bonut, total, Limbleg As Double
        Dim bonut1 As Double = 0.2
        Dim Limbleg1 As Double = 0.01
        Dim tax1 As Double = 0.07

        yearsalary = Val(txtSalary.Text) * 12
        bonut = Val(txtSale.Text * bonut1)
        total = Val(yearsalary + bonut)
        Limbleg = Val(total * Limbleg1)
        Tax = Val(total - Limbleg) * tax1

        lblSalary1.Text = FormatNumber(yearsalary, 2)
        lblBonut1.Text = FormatNumber(bonut, 2)
        lblTotal1.Text = FormatNumber(total, 2)
        lblDeduct1.Text = FormatNumber(Limbleg, 2)
        lblTax1.Text = FormatNumber(Tax, 2)


    End Sub

    Private Sub frmLab4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate1.Text = FormatDateTime(Today, DateFormat.GeneralDate)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class