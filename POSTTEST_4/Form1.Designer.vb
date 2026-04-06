<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaKartuToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        tbMemberID = New TextBox()
        rbtnGirl = New RadioButton()
        rbtnBoy = New RadioButton()
        cbTeam = New ComboBox()
        dtpBirthDate = New DateTimePicker()
        tbName = New TextBox()
        lblName = New Label()
        lblTeam = New Label()
        lblBirthDate = New Label()
        lblMemberID = New Label()
        lblGender = New Label()
        TabPage2 = New TabPage()
        mtbPhoneNumber = New MaskedTextBox()
        tbAddress = New TextBox()
        tbEmail = New TextBox()
        lblAddress = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        TabPage3 = New TabPage()
        btnBrowsePhoto = New Button()
        btnPrintCard = New Button()
        btnSave = New Button()
        pbProfilePicture = New PictureBox()
        gbAnI = New GroupBox()
        cbCarModification = New CheckBox()
        cbRaceReview = New CheckBox()
        cbStrategyDiscussion = New CheckBox()
        cbQualifyingTracking = New CheckBox()
        cbRaceWatching = New CheckBox()
        cbMotorsportPhotography = New CheckBox()
        cbSimRacing = New CheckBox()
        cbMerchCollecting = New CheckBox()
        gbRole = New GroupBox()
        rbtnTeamLeader = New RadioButton()
        rbtnAdminCrew = New RadioButton()
        rbtnEventCrew = New RadioButton()
        rbtnClubMember = New RadioButton()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(pbProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        gbAnI.SuspendLayout()
        gbRole.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Red
        MenuStrip1.Font = New Font("Helvetica LT Narrow", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(40, 40)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaKartuToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(619, 32)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(103, 28)
        InputDataToolStripMenuItem.Text = "Enter Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(100, 28)
        LihatKartuToolStripMenuItem.Text = "View Card"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(101, 28)
        SimpanDataToolStripMenuItem.Text = "Save Data"
        ' 
        ' BukaKartuToolStripMenuItem
        ' 
        BukaKartuToolStripMenuItem.Name = "BukaKartuToolStripMenuItem"
        BukaKartuToolStripMenuItem.Size = New Size(104, 28)
        BukaKartuToolStripMenuItem.Text = "Open Card"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 28)
        KeluarToolStripMenuItem.Text = "Exit"
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Bottom
        TabControl1.Font = New Font("Helvetica LT Narrow", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(0, 35)
        TabControl1.Multiline = True
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(619, 476)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), Image)
        TabPage1.Controls.Add(tbMemberID)
        TabPage1.Controls.Add(rbtnGirl)
        TabPage1.Controls.Add(rbtnBoy)
        TabPage1.Controls.Add(cbTeam)
        TabPage1.Controls.Add(dtpBirthDate)
        TabPage1.Controls.Add(tbName)
        TabPage1.Controls.Add(lblName)
        TabPage1.Controls.Add(lblTeam)
        TabPage1.Controls.Add(lblBirthDate)
        TabPage1.Controls.Add(lblMemberID)
        TabPage1.Controls.Add(lblGender)
        TabPage1.Location = New Point(4, 36)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(611, 436)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Main Data"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' tbMemberID
        ' 
        tbMemberID.Location = New Point(208, 143)
        tbMemberID.Name = "tbMemberID"
        tbMemberID.Size = New Size(295, 31)
        tbMemberID.TabIndex = 13
        ' 
        ' rbtnGirl
        ' 
        rbtnGirl.AutoSize = True
        rbtnGirl.BackColor = Color.Transparent
        rbtnGirl.Location = New Point(286, 232)
        rbtnGirl.Name = "rbtnGirl"
        rbtnGirl.Size = New Size(57, 28)
        rbtnGirl.TabIndex = 12
        rbtnGirl.TabStop = True
        rbtnGirl.Text = "Girl"
        rbtnGirl.UseVisualStyleBackColor = False
        ' 
        ' rbtnBoy
        ' 
        rbtnBoy.AutoSize = True
        rbtnBoy.BackColor = Color.Transparent
        rbtnBoy.Location = New Point(208, 232)
        rbtnBoy.Name = "rbtnBoy"
        rbtnBoy.Size = New Size(59, 28)
        rbtnBoy.TabIndex = 11
        rbtnBoy.TabStop = True
        rbtnBoy.Text = "Boy"
        rbtnBoy.UseVisualStyleBackColor = False
        ' 
        ' cbTeam
        ' 
        cbTeam.FormattingEnabled = True
        cbTeam.Items.AddRange(New Object() {"McLaren", "Ferrari", "Aston Martin", "Red Bull", "Mercedes", "Alpine", "Williams", "Cadilac", "Haas"})
        cbTeam.Location = New Point(208, 275)
        cbTeam.Name = "cbTeam"
        cbTeam.Size = New Size(295, 32)
        cbTeam.TabIndex = 10
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Location = New Point(208, 185)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(295, 31)
        dtpBirthDate.TabIndex = 9
        dtpBirthDate.Value = New Date(2026, 4, 2, 22, 7, 38, 0)
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(208, 99)
        tbName.Name = "tbName"
        tbName.Size = New Size(295, 31)
        tbName.TabIndex = 8
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Location = New Point(68, 102)
        lblName.Name = "lblName"
        lblName.Size = New Size(54, 24)
        lblName.TabIndex = 7
        lblName.Text = "Name"
        ' 
        ' lblTeam
        ' 
        lblTeam.AutoSize = True
        lblTeam.BackColor = Color.Transparent
        lblTeam.Location = New Point(68, 278)
        lblTeam.Name = "lblTeam"
        lblTeam.Size = New Size(52, 24)
        lblTeam.TabIndex = 5
        lblTeam.Text = "Team"
        ' 
        ' lblBirthDate
        ' 
        lblBirthDate.AutoSize = True
        lblBirthDate.BackColor = Color.Transparent
        lblBirthDate.Location = New Point(68, 190)
        lblBirthDate.Name = "lblBirthDate"
        lblBirthDate.Size = New Size(84, 24)
        lblBirthDate.TabIndex = 4
        lblBirthDate.Text = "Birth Date"
        ' 
        ' lblMemberID
        ' 
        lblMemberID.AutoSize = True
        lblMemberID.BackColor = Color.Transparent
        lblMemberID.Location = New Point(68, 146)
        lblMemberID.Name = "lblMemberID"
        lblMemberID.Size = New Size(92, 24)
        lblMemberID.TabIndex = 3
        lblMemberID.Text = "Member ID"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.Transparent
        lblGender.Location = New Point(68, 234)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(64, 24)
        lblGender.TabIndex = 2
        lblGender.Text = "Gender"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.Controls.Add(mtbPhoneNumber)
        TabPage2.Controls.Add(tbAddress)
        TabPage2.Controls.Add(tbEmail)
        TabPage2.Controls.Add(lblAddress)
        TabPage2.Controls.Add(lblEmail)
        TabPage2.Controls.Add(lblPhoneNumber)
        TabPage2.Location = New Point(4, 36)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(611, 436)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Contact & Information"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' mtbPhoneNumber
        ' 
        mtbPhoneNumber.Location = New Point(221, 141)
        mtbPhoneNumber.Mask = "0000-0000-0000"
        mtbPhoneNumber.Name = "mtbPhoneNumber"
        mtbPhoneNumber.Size = New Size(295, 31)
        mtbPhoneNumber.TabIndex = 7
        ' 
        ' tbAddress
        ' 
        tbAddress.Location = New Point(221, 229)
        tbAddress.Name = "tbAddress"
        tbAddress.Size = New Size(295, 31)
        tbAddress.TabIndex = 6
        ' 
        ' tbEmail
        ' 
        tbEmail.Location = New Point(221, 185)
        tbEmail.Name = "tbEmail"
        tbEmail.Size = New Size(295, 31)
        tbEmail.TabIndex = 5
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Location = New Point(70, 232)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(69, 24)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.Transparent
        lblEmail.Location = New Point(70, 188)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(52, 24)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.BackColor = Color.Transparent
        lblPhoneNumber.Location = New Point(70, 144)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(120, 24)
        lblPhoneNumber.TabIndex = 0
        lblPhoneNumber.Text = "Phone Number"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.White
        TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), Image)
        TabPage3.Controls.Add(btnBrowsePhoto)
        TabPage3.Controls.Add(btnPrintCard)
        TabPage3.Controls.Add(btnSave)
        TabPage3.Controls.Add(pbProfilePicture)
        TabPage3.Controls.Add(gbAnI)
        TabPage3.Controls.Add(gbRole)
        TabPage3.Location = New Point(4, 36)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(611, 436)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profile & Activities"
        ' 
        ' btnBrowsePhoto
        ' 
        btnBrowsePhoto.Location = New Point(8, 314)
        btnBrowsePhoto.Name = "btnBrowsePhoto"
        btnBrowsePhoto.Size = New Size(172, 29)
        btnBrowsePhoto.TabIndex = 25
        btnBrowsePhoto.Text = "Browse Photo"
        btnBrowsePhoto.UseVisualStyleBackColor = True
        ' 
        ' btnPrintCard
        ' 
        btnPrintCard.Location = New Point(304, 358)
        btnPrintCard.Name = "btnPrintCard"
        btnPrintCard.Size = New Size(296, 29)
        btnPrintCard.TabIndex = 12
        btnPrintCard.Text = "Print Card"
        btnPrintCard.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(9, 358)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(285, 29)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' pbProfilePicture
        ' 
        pbProfilePicture.Location = New Point(9, 76)
        pbProfilePicture.Name = "pbProfilePicture"
        pbProfilePicture.Size = New Size(172, 218)
        pbProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfilePicture.TabIndex = 8
        pbProfilePicture.TabStop = False
        ' 
        ' gbAnI
        ' 
        gbAnI.BackColor = Color.Transparent
        gbAnI.Controls.Add(cbCarModification)
        gbAnI.Controls.Add(cbRaceReview)
        gbAnI.Controls.Add(cbStrategyDiscussion)
        gbAnI.Controls.Add(cbQualifyingTracking)
        gbAnI.Controls.Add(cbRaceWatching)
        gbAnI.Controls.Add(cbMotorsportPhotography)
        gbAnI.Controls.Add(cbSimRacing)
        gbAnI.Controls.Add(cbMerchCollecting)
        gbAnI.Location = New Point(195, 175)
        gbAnI.Name = "gbAnI"
        gbAnI.Size = New Size(406, 169)
        gbAnI.TabIndex = 27
        gbAnI.TabStop = False
        gbAnI.Text = "Activities and Interest"
        ' 
        ' cbCarModification
        ' 
        cbCarModification.AutoSize = True
        cbCarModification.BackColor = Color.Transparent
        cbCarModification.Location = New Point(15, 124)
        cbCarModification.Name = "cbCarModification"
        cbCarModification.Size = New Size(152, 28)
        cbCarModification.TabIndex = 20
        cbCarModification.Text = "Car Modification"
        cbCarModification.UseVisualStyleBackColor = False
        ' 
        ' cbRaceReview
        ' 
        cbRaceReview.AutoSize = True
        cbRaceReview.BackColor = Color.Transparent
        cbRaceReview.Location = New Point(201, 125)
        cbRaceReview.Name = "cbRaceReview"
        cbRaceReview.Size = New Size(127, 28)
        cbRaceReview.TabIndex = 24
        cbRaceReview.Text = "Race Review"
        cbRaceReview.UseVisualStyleBackColor = False
        ' 
        ' cbStrategyDiscussion
        ' 
        cbStrategyDiscussion.AutoSize = True
        cbStrategyDiscussion.BackColor = Color.Transparent
        cbStrategyDiscussion.Location = New Point(15, 90)
        cbStrategyDiscussion.Name = "cbStrategyDiscussion"
        cbStrategyDiscussion.Size = New Size(177, 28)
        cbStrategyDiscussion.TabIndex = 19
        cbStrategyDiscussion.Text = "Strategy Discussion"
        cbStrategyDiscussion.UseVisualStyleBackColor = False
        ' 
        ' cbQualifyingTracking
        ' 
        cbQualifyingTracking.AutoSize = True
        cbQualifyingTracking.BackColor = Color.Transparent
        cbQualifyingTracking.Location = New Point(198, 91)
        cbQualifyingTracking.Name = "cbQualifyingTracking"
        cbQualifyingTracking.Size = New Size(173, 28)
        cbQualifyingTracking.TabIndex = 23
        cbQualifyingTracking.Text = "Qualifying Tracking"
        cbQualifyingTracking.UseVisualStyleBackColor = False
        ' 
        ' cbRaceWatching
        ' 
        cbRaceWatching.AutoSize = True
        cbRaceWatching.BackColor = Color.Transparent
        cbRaceWatching.Location = New Point(15, 56)
        cbRaceWatching.Name = "cbRaceWatching"
        cbRaceWatching.Size = New Size(142, 28)
        cbRaceWatching.TabIndex = 18
        cbRaceWatching.Text = "Race Watching"
        cbRaceWatching.UseVisualStyleBackColor = False
        ' 
        ' cbMotorsportPhotography
        ' 
        cbMotorsportPhotography.AutoSize = True
        cbMotorsportPhotography.BackColor = Color.Transparent
        cbMotorsportPhotography.Location = New Point(198, 56)
        cbMotorsportPhotography.Name = "cbMotorsportPhotography"
        cbMotorsportPhotography.Size = New Size(207, 28)
        cbMotorsportPhotography.TabIndex = 22
        cbMotorsportPhotography.Text = "Motorsport Photography"
        cbMotorsportPhotography.UseVisualStyleBackColor = False
        ' 
        ' cbSimRacing
        ' 
        cbSimRacing.AutoSize = True
        cbSimRacing.BackColor = Color.Transparent
        cbSimRacing.Location = New Point(15, 22)
        cbSimRacing.Name = "cbSimRacing"
        cbSimRacing.Size = New Size(116, 28)
        cbSimRacing.TabIndex = 13
        cbSimRacing.Text = "Sim Racing"
        cbSimRacing.UseVisualStyleBackColor = False
        ' 
        ' cbMerchCollecting
        ' 
        cbMerchCollecting.AutoSize = True
        cbMerchCollecting.BackColor = Color.Transparent
        cbMerchCollecting.Location = New Point(198, 22)
        cbMerchCollecting.Name = "cbMerchCollecting"
        cbMerchCollecting.Size = New Size(155, 28)
        cbMerchCollecting.TabIndex = 21
        cbMerchCollecting.Text = "Merch Collecting"
        cbMerchCollecting.UseVisualStyleBackColor = False
        ' 
        ' gbRole
        ' 
        gbRole.BackColor = Color.Transparent
        gbRole.Controls.Add(rbtnTeamLeader)
        gbRole.Controls.Add(rbtnAdminCrew)
        gbRole.Controls.Add(rbtnEventCrew)
        gbRole.Controls.Add(rbtnClubMember)
        gbRole.Location = New Point(195, 44)
        gbRole.Name = "gbRole"
        gbRole.Size = New Size(406, 125)
        gbRole.TabIndex = 26
        gbRole.TabStop = False
        gbRole.Text = "Role"
        ' 
        ' rbtnTeamLeader
        ' 
        rbtnTeamLeader.AutoSize = True
        rbtnTeamLeader.BackColor = Color.Transparent
        rbtnTeamLeader.Location = New Point(15, 30)
        rbtnTeamLeader.Name = "rbtnTeamLeader"
        rbtnTeamLeader.Size = New Size(128, 28)
        rbtnTeamLeader.TabIndex = 15
        rbtnTeamLeader.TabStop = True
        rbtnTeamLeader.Text = "Team Leader"
        rbtnTeamLeader.UseVisualStyleBackColor = False
        ' 
        ' rbtnAdminCrew
        ' 
        rbtnAdminCrew.AutoSize = True
        rbtnAdminCrew.BackColor = Color.Transparent
        rbtnAdminCrew.Location = New Point(15, 66)
        rbtnAdminCrew.Name = "rbtnAdminCrew"
        rbtnAdminCrew.Size = New Size(121, 28)
        rbtnAdminCrew.TabIndex = 17
        rbtnAdminCrew.TabStop = True
        rbtnAdminCrew.Text = "Admin Crew"
        rbtnAdminCrew.UseVisualStyleBackColor = False
        ' 
        ' rbtnEventCrew
        ' 
        rbtnEventCrew.AutoSize = True
        rbtnEventCrew.BackColor = Color.Transparent
        rbtnEventCrew.Location = New Point(198, 32)
        rbtnEventCrew.Name = "rbtnEventCrew"
        rbtnEventCrew.Size = New Size(116, 28)
        rbtnEventCrew.TabIndex = 16
        rbtnEventCrew.TabStop = True
        rbtnEventCrew.Text = "Event Crew"
        rbtnEventCrew.UseVisualStyleBackColor = False
        ' 
        ' rbtnClubMember
        ' 
        rbtnClubMember.AutoSize = True
        rbtnClubMember.BackColor = Color.Transparent
        rbtnClubMember.Location = New Point(198, 66)
        rbtnClubMember.Name = "rbtnClubMember"
        rbtnClubMember.Size = New Size(130, 28)
        rbtnClubMember.TabIndex = 14
        rbtnClubMember.TabStop = True
        rbtnClubMember.Text = "Club Member"
        rbtnClubMember.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 511)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(pbProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        gbAnI.ResumeLayout(False)
        gbAnI.PerformLayout()
        gbRole.ResumeLayout(False)
        gbRole.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblName As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblMemberID As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblAnI As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents pbProfilePicture As PictureBox
    Friend WithEvents tbMemberID As TextBox
    Friend WithEvents rbtnGirl As RadioButton
    Friend WithEvents rbtnBoy As RadioButton
    Friend WithEvents cbTeam As ComboBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnPrintCard As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents rbtnClubMember As RadioButton
    Friend WithEvents cbSimRacing As CheckBox
    Friend WithEvents cbStrategyDiscussion As CheckBox
    Friend WithEvents cbRaceWatching As CheckBox
    Friend WithEvents rbtnAdminCrew As RadioButton
    Friend WithEvents rbtnEventCrew As RadioButton
    Friend WithEvents rbtnTeamLeader As RadioButton
    Friend WithEvents cbRaceReview As CheckBox
    Friend WithEvents cbQualifyingTracking As CheckBox
    Friend WithEvents cbMotorsportPhotography As CheckBox
    Friend WithEvents cbMerchCollecting As CheckBox
    Friend WithEvents cbCarModification As CheckBox
    Friend WithEvents mtbPhoneNumber As MaskedTextBox
    Friend WithEvents btnBrowsePhoto As Button
    Friend WithEvents gbRole As GroupBox
    Friend WithEvents gbAnI As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
