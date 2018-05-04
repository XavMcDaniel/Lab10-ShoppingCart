Module Module1

    Public g_decSUBTOTAL As Decimal
    Public g_decTAX As Decimal
    Public g_decSHIPPING As Decimal
    Public g_decTOTAL As Decimal

    Public Sub CalculateCharges()
        'Calculate the quantity of books
        Dim intBookQuantity As Integer
        intBookQuantity = Form1.lstProducts.Items.Count

        'Calculate the tax, shipping, and total
        g_decTAX = g_decSUBTOTAL * 0.0635D
        g_decSHIPPING = intBookQuantity * 2
        g_decTOTAL = g_decSUBTOTAL + g_decTAX + g_decSHIPPING
    End Sub

    Public Sub DisplayCharges()
        'Display the Data
        Form1.lblSubtotal.Text = g_decSUBTOTAL.ToString("c")
        Form1.lblTax.Text = g_decTAX.ToString("c")
        Form1.lblShipping.Text = g_decSHIPPING.ToString("c")
        Form1.lblTotal.Text = g_decTOTAL.ToString("c")
    End Sub

    Public Sub DisplayPrintBook()
        'Display the Book
        Form1.lstProducts.Items.Add(PrintBooks.lstPrintBooks.Text)
    End Sub

    Public Sub DisplayAudioBook()
        'Display the Book
        Form1.lstProducts.Items.Add(AudioBooks.lstAudioBooks.Text)
    End Sub

    Public Sub RemoveItem()
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decShipping As Decimal
        Dim decTotal As Decimal
        Const decTaxTotal As Decimal = 0.6D
        Const decShippingRate As Decimal = 2D

        If Form1.lstProducts.SelectedIndex = 0 Then
            decSubtotal = CDec(11.95)
            decTax = CDec(11.95 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        ElseIf Form1.lstProducts.SelectedIndex = 1 Then
            decSubtotal = CDec(14.5)
            decTax = CDec(14.5 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        ElseIf Form1.lstProducts.SelectedIndex = 2 Then
            decSubtotal = CDec(29.95)
            decTax = CDec(29.95 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        ElseIf Form1.lstProducts.SelectedIndex = 3 Then
            decSubtotal = CDec(18.5)
            decTax = CDec(18.5 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If

        g_decSUBTOTAL -= decSubtotal
        g_decTAX -= decTax
        g_decSHIPPING -= decShipping
        g_decTOTAL -= decTotal

        Try
            If Form1.lstProducts.SelectedIndex > -1 Then
                Form1.lstProducts.Items.RemoveAt(Form1.lstProducts.SelectedIndex)
            Else
                MessageBox.Show("Select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Form1.lstProducts.SelectedIndex = -1
    End Sub

End Module