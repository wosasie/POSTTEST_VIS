Imports System.Net.NetworkInformation

Public Class Form1

    Private Sub tbName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbName.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub tbMemberID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMemberID.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub mtbPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbPhoneNumber.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        ValidasiTextBox(ErrorProvider1, tbName, "Name cannot be empty !!")
    End Sub

    Private Sub tbMemberID_TextChanged(sender As Object, e As EventArgs) Handles tbMemberID.TextChanged
        ValidasiTextBox(ErrorProvider1, tbMemberID, "ID cannot be empty !!")
    End Sub

    Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged
        ValidasiTextBox(ErrorProvider1, tbEmail, "Email cannot be empty !!")
    End Sub

    Private Sub tbAddress_TextChanged(sender As Object, e As EventArgs) Handles tbAddress.TextChanged
        ValidasiTextBox(ErrorProvider1, tbAddress, "Address cannot be empty !!")
    End Sub

    Private Sub mtbPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles mtbPhoneNumber.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtbPhoneNumber, "the Phone Number cannot be empty !!")
    End Sub

    Public Function PilihanRole() As String
        If rbtnTeamLeader.Checked Then Return "Team Leader"
        If rbtnAdminCrew.Checked Then Return "Admin Crew"
        If rbtnEventCrew.Checked Then Return "Event Crew"
        If rbtnClubMember.Checked Then Return "Club Member"
        Return ""
    End Function

    Public Function PilihanActivitiesAndInterest() As String
        Dim hasil As String = ""

        If cbSimRacing.Checked Then hasil &= "Sim Racing, "
        If cbRaceWatching.Checked Then hasil &= "Race Watching, "
        If cbStrategyDiscussion.Checked Then hasil &= "Strategy Discussion, "
        If cbCarModification.Checked Then hasil &= "Car Modification, "
        If cbMerchCollecting.Checked Then hasil &= "Merch Collecting, "
        If cbMotorsportPhotography.Checked Then hasil &= "Motorsport Photography, "
        If cbQualifyingTracking.Checked Then hasil &= "Qualifying Tracking, "
        If cbRaceReview.Checked Then hasil &= "Race Review, "

        If hasil.EndsWith(", ") Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil
    End Function



    Private Sub btnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles btnBrowsePhoto.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbProfilePicture.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not ValidasiTextBox(ErrorProvider1, tbName, "Name cannot be empty !!") _
       Or Not ValidasiTextBox(ErrorProvider1, tbMemberID, "ID cannot be empty !!") _
       Or Not ValidasiMaskedTextBox(ErrorProvider1, mtbPhoneNumber, "the Phone Number cannot be empty !!") _
       Or Not ValidasiTextBox(ErrorProvider1, tbAddress, "Address cannot be empty !!") Then

            MessageBox.Show("Input cannot be empty!", "Warning!!")
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Save data?", "Konfirmasi", MessageBoxButtons.YesNoCancel)

        If hasil = DialogResult.Yes Then

            Dim isi As String = BuatIsiFile(
            tbName.Text,
            tbMemberID.Text,
            mtbPhoneNumber.Text,
            cbTeam.Text,
            PilihanRole(),
            PilihanActivitiesAndInterest(),
            tbAddress.Text
        )

            If SimpanDataKeFile(SaveFileDialog1, isi, "data.txt") Then
                MessageBox.Show("Data berhasil disimpan!")
            End If

        End If

        If PilihanRole() = "" Then
            MessageBox.Show("Role cannot be empty !!")
            Exit Sub
        End If

        If PilihanActivitiesAndInterest() = "" Then
            MessageBox.Show("Activity and interest cannot be empty !!")
            Exit Sub
        End If

    End Sub


    Private Sub btnPrintCard_Click(sender As Object, e As EventArgs) Handles btnPrintCard.Click

        Dim f As New Form2

        f.lblName.Text = tbName.Text
        f.lblMemberID.Text = tbMemberID.Text
        f.lblPhoneNumber.Text = mtbPhoneNumber.Text
        f.lblTeam.Text = cbTeam.Text
        f.lblRole.Text = PilihanRole()
        f.lblAnI.Text = PilihanActivitiesAndInterest()

        f.PictureBox1.Image = pbProfilePicture.Image

        f.Show()

    End Sub


    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        btnPrintCard.PerformClick()
    End Sub

    Private Sub BukaKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaKartuToolStripMenuItem.Click
        Dim data = BukaDataDariFile(OpenFileDialog1)
        If data Is Nothing Then Exit Sub

        tbName.Text = AmbilNilai(data, "Nama")
        tbMemberID.Text = AmbilNilai(data, "ID")
        mtbPhoneNumber.Text = AmbilNilai(data, "NoHP")
        cbTeam.Text = AmbilNilai(data, "Team")
        tbAddress.Text = AmbilNilai(data, "Alamat")

        MessageBox.Show("Data Opened !!")
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
