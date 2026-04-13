Public Class Form1

    Private Sub ClearForm()
        txtCode.Clear()
        txtName.Clear()
        cbTeam.SelectedIndex = -1
        cbCategory.SelectedIndex = -1
        txtStock.Clear()
        txtPrice.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtCode.Focus()
    End Sub

    Private Sub LoadData()
        dgvMerch.DataSource = GetAllMerch()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        ClearForm()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ErrorProvider1.Clear()

        If Not ValidateMerch(ErrorProvider1, txtCode, txtName, cbTeam, cbCategory, txtStock, txtPrice) Then Exit Sub

        Dim kode As String = txtCode.Text.Trim()

        If CodeExists(kode) Then
            MessageBox.Show("Merch code already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCode.Focus()
            Exit Sub
        End If

        Dim confirm As DialogResult
        confirm = MessageBox.Show("Are you sure you want to save this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            If SaveMerch(kode, txtName.Text, cbTeam.Text, cbCategory.Text, CInt(txtStock.Text), CInt(txtPrice.Text)) Then
                MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearForm()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ErrorProvider1.Clear()

        If Not ValidateMerch(ErrorProvider1, txtCode, txtName, cbTeam, cbCategory, txtStock, txtPrice) Then Exit Sub

        Dim confirm As DialogResult
        confirm = MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            If UpdateMerch(txtCode.Text.Trim(), txtName.Text, cbTeam.Text, cbCategory.Text, CInt(txtStock.Text), CInt(txtPrice.Text)) Then
                MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearForm()
            Else
                MessageBox.Show("Data not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtCode.Text.Trim() = "" Then
            MessageBox.Show("Please select data first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCode.Focus()
            Exit Sub
        End If

        Dim confirm As DialogResult
        confirm = MessageBox.Show("Are you sure you want to delete this merch?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            If DeleteMerch(txtCode.Text.Trim()) Then
                MessageBox.Show("Data deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearForm()
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()
        LoadData()
    End Sub

    Private Sub dgvMerch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMerch.CellClick
        If e.RowIndex >= 0 Then
            txtCode.Text = dgvMerch.Rows(e.RowIndex).Cells("merchCode").Value.ToString()
            txtName.Text = dgvMerch.Rows(e.RowIndex).Cells("merchName").Value.ToString()
            cbTeam.Text = dgvMerch.Rows(e.RowIndex).Cells("merchTeam").Value.ToString()
            cbCategory.Text = dgvMerch.Rows(e.RowIndex).Cells("merchCategory").Value.ToString()
            txtStock.Text = dgvMerch.Rows(e.RowIndex).Cells("merchStock").Value.ToString()
            txtPrice.Text = dgvMerch.Rows(e.RowIndex).Cells("merchPrice").Value.ToString()
        End If
    End Sub

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True

            Dim dt As DataTable = GetMerchByCode(txtCode.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtName.Text = dt.Rows(0)("merchName").ToString()
                cbTeam.Text = dt.Rows(0)("merchTeam").ToString()
                cbCategory.Text = dt.Rows(0)("merchCategory").ToString()
                txtStock.Text = dt.Rows(0)("merchStock").ToString()
                txtPrice.Text = dt.Rows(0)("merchPrice").ToString()
            Else
                txtName.Clear()
                txtStock.Clear()
                txtPrice.Clear()
            End If

            txtName.Focus()
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        OnlyLetters(e)
    End Sub

    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            LoadData()
        Else
            dgvMerch.DataSource = SearchMerch(txtSearch.Text.Trim())
        End If
    End Sub

End Class
