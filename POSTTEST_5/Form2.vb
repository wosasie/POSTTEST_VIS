Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Form1.Show()
        Me.Hide()
    End Sub
End Class