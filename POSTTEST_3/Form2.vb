Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = DataModule.Name
        lblAge.Text = DataModule.Age
        lblDateBirth.Text = DataModule.DateOfBirth
        lblPhoneNo.Text = DataModule.PhoneNumber
        lblAddress.Text = DataModule.Address
        lblGender.Text = DataModule.Gender
        lblHobbies.Text = DataModule.Hobbies

        PictureBox2.Image = Image.FromFile(DataModule.Picture)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class