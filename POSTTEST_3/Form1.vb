Public Class Form1
    Dim openFilePath As String



    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFile.ShowDialog = DialogResult.OK Then
            openFilePath = openFile.FileName
            PictureBox1.Image = Image.FromFile(openFilePath)
        End If
    End Sub


    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtPhoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNo.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnPrintCard_Click(sender As Object, e As EventArgs) Handles btnPrintCard.Click

        If txtName.Text = "" Or txtAge.Text = "" Or txtPhoneNo.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("Beep Beep! Warning! Please complete the form.")
            Exit Sub
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Beep Beep! Warning! Please upload a picture")
            Exit Sub
        End If

        Dim gender As String = ""

        If rbBoy.Checked Then
            gender = "Boy"
        ElseIf rbGirl.Checked Then
            gender = "Girl"
        End If

        Dim hobbies As String = ""

        If cbReading.Checked Then hobbies &= "Reading "
        If cbCooking.Checked Then hobbies &= "Cooking "
        If cbDrawing.Checked Then hobbies &= "Drawing "
        If cbKnitting.Checked Then hobbies &= "Knitting "
        If cbShopping.Checked Then hobbies &= "Shopping "
        If cbEmbroidery.Checked Then hobbies &= "Embroidery "
        If cbSinging.Checked Then hobbies &= "Singing "
        If cbPhotography.Checked Then hobbies &= "Photography "
        If cbJournaling.Checked Then hobbies &= "Journaling "
        If cbTraveling.Checked Then hobbies &= "Traveling "

        DataModule.Name = txtName.Text
        DataModule.Age = txtAge.Text
        DataModule.PhoneNumber = txtPhoneNo.Text
        DataModule.Address = txtAddress.Text
        DataModule.DateOfBirth = dtpDateBirth.Value
        DataModule.Gender = gender
        DataModule.Hobbies = hobbies
        DataModule.Picture = openFilePath

        Form2.Show()

    End Sub


End Class
