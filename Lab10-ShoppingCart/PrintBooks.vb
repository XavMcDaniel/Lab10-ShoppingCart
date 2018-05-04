Public Class PrintBooks


    Public Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Declare Variables and Constants
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decShipping As Decimal
        Dim decTotal As Decimal
        Const decTaxTotal As Decimal = 0.6D
        Const decShippingRate As Decimal = 2D

        If lstPrintBooks.SelectedIndex = 0 Then
            decSubtotal = CDec(11.95)
            decTax = CDec(11.95 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        ElseIf lstPrintBooks.SelectedIndex = 1 Then
            decSubtotal = CDec(14.5)
            decTax = CDec(14.5 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        ElseIf lstPrintBooks.SelectedIndex = 2 Then
            decSubtotal = CDec(29.95)
            decTax = CDec(29.95 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        ElseIf lstPrintBooks.SelectedIndex = 3 Then
            decSubtotal = CDec(18.5)
            decTax = CDec(18.5 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If

        g_decSUBTOTAL += decSubtotal
        g_decTAX += decTax
        g_decSHIPPING += decShipping
        g_decTOTAL += decTotal

        ' Show total due
        DisplayCharges()
        DisplayPrintBook()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class