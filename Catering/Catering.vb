'Program: Catering
'Author: Katelyn Coper
'Date: March 27, 2023
'Purpose: This application will calculate teh cost of an item while taking into account the payment option and discount of loyaly points.

Option Strict On
Option Explicit On
Public Class catering
    Private Sub btnCaluculate_Click(sender As Object, e As EventArgs) Handles btnCaluculate.Click
        'These events occur when the user clicks the calculate button.
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtPoints.Text) Then
            intPoints = Convert.ToInt32(txtPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."
            MsgBox(intPoints)

            If radCheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf radWraps.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf radVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radSausage.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If radPrePay.Checked Then
                strPay = " using Pre-Pay"
            ElseIf radPickup.Checked Then
                strPay = " with Pay upon Pickup"
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)
            MsgBox(intPoints)

            decPoints = (intPoints * cdecDiscount) / 100
            MsgBox(decPoints)

            If decPoints > 1 Then
                decPoints = 1
            End If

            MsgBox(decPoints)

            decFinal = decCost * (1 - decPoints)
            MsgBox(decFinal)

            lblOderDetails.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strPoints
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()
        End If
    End Sub

    Private Sub catering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPoints.Text = ""
        txtPoints.Focus()
        lblOderDetails.Text = ""
        radCheese.Checked = True
        radWraps.Checked = False
        radVeggie.Checked = False
        radSausage.Checked = False
        radFruit.Checked = False
        radPrePay.Checked = True
        radPickup.Checked = False
    End Sub
End Class
