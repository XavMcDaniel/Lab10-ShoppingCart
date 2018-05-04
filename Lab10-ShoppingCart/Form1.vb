Public Class Form1

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        'resets labels and listbox
        lblSubtotal.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
        lstProducts.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'closes application
        Me.Close()
    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        PrintBooks.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RemoveItem()
        DisplayCharges()
    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        AudioBooks.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created By Xavier McDaniel")
    End Sub
End Class
