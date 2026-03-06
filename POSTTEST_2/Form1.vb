Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        tambahBuku(txtTambahJudul.Text, txtGenre.Text)
        tampilkanBuku(lbBuku)

        txtHapusJudul.Clear()
        txtTambahJudul.Clear()
        txtGenre.Clear()
    End Sub

    Private Sub lbJudulBuku_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBuku.SelectedIndexChanged

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtHapusJudul.Text

        For i As Integer = 0 To totalBuku - 1
            If listBuku(i, 0) = judul Then
                For j As Integer = i To totalBuku - 2
                    listBuku(j, 0) = listBuku(j + 1, 0)
                    listBuku(j, 1) = listBuku(j + 1, 1)
                Next

                totalBuku -= 1
                Exit For
            End If
        Next

        tampilkanBuku(lbBuku)
        txtHapusJudul.Clear()
    End Sub

End Class
