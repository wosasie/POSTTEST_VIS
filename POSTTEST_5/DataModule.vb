Imports MySqlConnector

Module DataModule

    Public Function GetAllMerch() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT merchCode, merchName, merchTeam, merchCategory, merchStock, merchPrice FROM tb_merchandise ORDER BY merchCode ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to display data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SearchMerch(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT merchCode, merchName, merchTeam, merchCategory, merchStock, merchPrice FROM tb_merchandise " &
                "WHERE merchCode LIKE @keyword OR merchName LIKE @keyword OR merchTeam LIKE @keyword OR merchCategory LIKE @keyword OR merchStock LIKE @keyword OR merchPrice LIKE @keyword" &
                "ORDER BY merchCode ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to search data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function GetMerchByCode(kode As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tb_merchandise WHERE merchCode = @merchCode"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@merchCode", kode)

                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to get data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function CodeExists(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_merchandise WHERE merchCode = @merchCode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@merchCode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to check data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SaveMerch(kode As String, nama As String, team As String, kategori As String, stok As Integer, harga As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_merchandise (merchCode, merchName, merchTeam, merchCategory, merchStock, merchPrice) VALUES (@code, @name, @team, @category, @stock, @price)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@code", kode)
                    cmd.Parameters.AddWithValue("@name", nama)
                    cmd.Parameters.AddWithValue("@team", team)
                    cmd.Parameters.AddWithValue("@category", kategori)
                    cmd.Parameters.AddWithValue("@stock", stok)
                    cmd.Parameters.AddWithValue("@price", harga)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True

        Catch ex As Exception
            MessageBox.Show("Failed to save data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UpdateMerch(kode As String, nama As String, team As String, kategori As String, stok As Integer, harga As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tb_merchandise SET merchName=@name, merchTeam=@team, merchCategory=@category, merchStock=@stock, merchPrice=@price WHERE merchCode=@code"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@code", kode)
                    cmd.Parameters.AddWithValue("@name", nama)
                    cmd.Parameters.AddWithValue("@team", team)
                    cmd.Parameters.AddWithValue("@category", kategori)
                    cmd.Parameters.AddWithValue("@stock", stok)
                    cmd.Parameters.AddWithValue("@price", harga)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to update data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function DeleteMerch(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_merchandise WHERE merchCode=@code"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@code", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to delete data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module

