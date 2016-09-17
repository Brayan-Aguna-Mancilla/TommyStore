Public Class MensajeDeCompra
    Private Sub MensajeDeCompra_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblTotal.Text = MainForm.lblTotal.Text
        Timer1.Enabled = True
        Timer1.Interval = 5000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Timer1.Enabled = False
    End Sub
End Class