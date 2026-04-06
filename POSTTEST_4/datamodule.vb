Imports System.IO
Imports System.Text

Module DataModule

    Public Function BuatIsiFile(
        nama As String,
        id As String,
        noHp As String,
        team As String,
        role As String,
        aktivitas As String,
        alamat As String
    ) As String

        Dim sb As New StringBuilder()

        sb.AppendLine("Nama=" & nama)
        sb.AppendLine("ID=" & id)
        sb.AppendLine("NoHP=" & noHp)
        sb.AppendLine("Team=" & team)
        sb.AppendLine("Role=" & role)
        sb.AppendLine("Aktivitas=" & aktivitas)
        sb.Append("Alamat=" & alamat)

        Return sb.ToString()
    End Function

    Public Function SimpanDataKeFile(sfd As SaveFileDialog, isi As String, namaDefault As String) As Boolean
        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data"
        sfd.FileName = namaDefault

        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If

        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)

        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        ofd.Title = "Buka Data"

        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Dim data As New Dictionary(Of String, String)
        Dim lines() As String = File.ReadAllLines(ofd.FileName)

        For Each line As String In lines
            If String.IsNullOrWhiteSpace(line) Then Continue For

            Dim bagian() As String = line.Split("="c)

            If bagian.Length = 2 Then
                data(bagian(0)) = bagian(1)
            End If
        Next

        Return data
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data.ContainsKey(key) Then
            Return data(key)
        End If
        Return ""
    End Function

End Module