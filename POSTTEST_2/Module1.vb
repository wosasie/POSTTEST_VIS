Module Module1
    Public listBuku(99, 1) As String
    Public totalBuku As Integer = 0

    Public Sub tambahBuku(judul As String, genre As String)
        If totalBuku < 100 Then
            listBuku(totalBuku, 0) = judul
            listBuku(totalBuku, 1) = genre
            totalBuku += 1
        End If
    End Sub

    Public Function formatBuku(judul As String, genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

    Public Sub tampilkanBuku(list As ListBox)
        list.Items.Clear()

        For i As Integer = 0 To totalBuku - 1
            list.Items.Add(formatBuku(listBuku(i, 0), listBuku(i, 1)))
        Next
    End Sub

End Module
