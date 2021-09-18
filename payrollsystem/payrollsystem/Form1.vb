Public Class frmPayroll

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim hourlyrate, hoursworked, grosssalary, ammountdeducted, netsalary As Integer
        hourlyrate = CInt(txthoursrate.Text)
        hoursworked = CInt(txthours.Text)
        grosssalary = hourlyrate * hoursworked
        grosspay.Text = grosssalary
        ammountdeducted = (taxrate.Text / 100) * grosssalary
        ammountded.Text = ammountdeducted
        netsalary = grosssalary - ammountdeducted
        netsal.Text = netsalary.ToString
        userout.Text = txtUsername.Text
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txthoursrate.Text = ""
        txthours.Text = ""
        grosspay.Text = ""
        taxrate.Text = ""
        ammountded.Text = ""
        netsal.Text = ""
        txtUsername.Text = ""
        userout.Text = ""
    End Sub
End Class
