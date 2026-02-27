Public Class Form1

    Dim totalIPS As Double
    Dim jumlahSemester As Integer
    Dim ipk As Double

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ips As Double

        If Double.TryParse(txtIPS.Text, ips) Then

            totalIPS = totalIPS + ips
            jumlahSemester = jumlahSemester + 1
            ipk = totalIPS / jumlahSemester

            txtIPK.Text = ipk

            If ipk >= 2.0 And ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

            txtIPS.Clear()
            txtIPS.Focus()

        Else
            MessageBox.Show("Input nya harus angka yap")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIPS = 0
        jumlahSemester = 0
        ipk = 0

        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = "-"
    End Sub

End Class