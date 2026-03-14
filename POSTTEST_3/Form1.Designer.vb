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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblName = New Label()
        lblAge = New Label()
        lblDateBirth = New Label()
        lblAddress = New Label()
        lblPhoneNo = New Label()
        gbxGender = New GroupBox()
        rbGirl = New RadioButton()
        rbBoy = New RadioButton()
        gbxHobbies = New GroupBox()
        cbTraveling = New CheckBox()
        cbJournaling = New CheckBox()
        cbPhotography = New CheckBox()
        cbSinging = New CheckBox()
        cbEmbroidery = New CheckBox()
        cbShopping = New CheckBox()
        cbKnitting = New CheckBox()
        cbDrawing = New CheckBox()
        cbCooking = New CheckBox()
        cbReading = New CheckBox()
        btnPrintCard = New Button()
        btnBrowse = New Button()
        dtpDateBirth = New DateTimePicker()
        txtName = New TextBox()
        txtAge = New TextBox()
        txtPhoneNo = New TextBox()
        txtAddress = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        gbxGender.SuspendLayout()
        gbxHobbies.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("STSong", 11.999999F, FontStyle.Bold)
        lblName.ForeColor = Color.Pink
        lblName.Location = New Point(263, 9)
        lblName.Name = "lblName"
        lblName.Padding = New Padding(1)
        lblName.Size = New Size(62, 24)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.BackColor = Color.Transparent
        lblAge.Font = New Font("STSong", 11.999999F, FontStyle.Bold)
        lblAge.ForeColor = Color.Pink
        lblAge.Location = New Point(263, 51)
        lblAge.Name = "lblAge"
        lblAge.Padding = New Padding(1)
        lblAge.Size = New Size(46, 24)
        lblAge.TabIndex = 1
        lblAge.Text = "Age"
        ' 
        ' lblDateBirth
        ' 
        lblDateBirth.AutoSize = True
        lblDateBirth.BackColor = Color.Transparent
        lblDateBirth.Font = New Font("STSong", 11.999999F, FontStyle.Bold)
        lblDateBirth.ForeColor = Color.Pink
        lblDateBirth.Location = New Point(263, 96)
        lblDateBirth.Name = "lblDateBirth"
        lblDateBirth.Padding = New Padding(1)
        lblDateBirth.Size = New Size(128, 24)
        lblDateBirth.TabIndex = 2
        lblDateBirth.Text = "Date of Birth"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("STSong", 11.999999F, FontStyle.Bold)
        lblAddress.ForeColor = Color.Pink
        lblAddress.Location = New Point(263, 185)
        lblAddress.Margin = New Padding(3)
        lblAddress.Name = "lblAddress"
        lblAddress.Padding = New Padding(1)
        lblAddress.Size = New Size(82, 24)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address"
        ' 
        ' lblPhoneNo
        ' 
        lblPhoneNo.AutoSize = True
        lblPhoneNo.BackColor = Color.Transparent
        lblPhoneNo.Font = New Font("STSong", 11.999999F, FontStyle.Bold)
        lblPhoneNo.ForeColor = Color.Pink
        lblPhoneNo.Location = New Point(263, 142)
        lblPhoneNo.Name = "lblPhoneNo"
        lblPhoneNo.Padding = New Padding(1)
        lblPhoneNo.Size = New Size(104, 24)
        lblPhoneNo.TabIndex = 4
        lblPhoneNo.Text = "Phone No."
        ' 
        ' gbxGender
        ' 
        gbxGender.BackColor = Color.Transparent
        gbxGender.Controls.Add(rbGirl)
        gbxGender.Controls.Add(rbBoy)
        gbxGender.Font = New Font("STSong", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxGender.ForeColor = Color.Pink
        gbxGender.Location = New Point(263, 221)
        gbxGender.Name = "gbxGender"
        gbxGender.Size = New Size(165, 181)
        gbxGender.TabIndex = 5
        gbxGender.TabStop = False
        gbxGender.Text = "Gender"
        ' 
        ' rbGirl
        ' 
        rbGirl.AutoSize = True
        rbGirl.Location = New Point(6, 64)
        rbGirl.Name = "rbGirl"
        rbGirl.Size = New Size(61, 23)
        rbGirl.TabIndex = 16
        rbGirl.TabStop = True
        rbGirl.Text = "Girl"
        rbGirl.UseVisualStyleBackColor = True
        ' 
        ' rbBoy
        ' 
        rbBoy.AutoSize = True
        rbBoy.Location = New Point(6, 36)
        rbBoy.Name = "rbBoy"
        rbBoy.Size = New Size(59, 23)
        rbBoy.TabIndex = 0
        rbBoy.TabStop = True
        rbBoy.Text = "Boy"
        rbBoy.UseVisualStyleBackColor = True
        ' 
        ' gbxHobbies
        ' 
        gbxHobbies.BackColor = Color.Transparent
        gbxHobbies.Controls.Add(cbTraveling)
        gbxHobbies.Controls.Add(cbJournaling)
        gbxHobbies.Controls.Add(cbPhotography)
        gbxHobbies.Controls.Add(cbSinging)
        gbxHobbies.Controls.Add(cbEmbroidery)
        gbxHobbies.Controls.Add(cbShopping)
        gbxHobbies.Controls.Add(cbKnitting)
        gbxHobbies.Controls.Add(cbDrawing)
        gbxHobbies.Controls.Add(cbCooking)
        gbxHobbies.Controls.Add(cbReading)
        gbxHobbies.Font = New Font("STSong", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxHobbies.ForeColor = Color.Pink
        gbxHobbies.Location = New Point(434, 221)
        gbxHobbies.Name = "gbxHobbies"
        gbxHobbies.Size = New Size(277, 181)
        gbxHobbies.TabIndex = 6
        gbxHobbies.TabStop = False
        gbxHobbies.Text = "Hobbies"
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(152, 152)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(103, 23)
        cbTraveling.TabIndex = 17
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbJournaling
        ' 
        cbJournaling.AutoSize = True
        cbJournaling.Location = New Point(6, 152)
        cbJournaling.Name = "cbJournaling"
        cbJournaling.Size = New Size(111, 23)
        cbJournaling.TabIndex = 18
        cbJournaling.Text = "Journaling"
        cbJournaling.UseVisualStyleBackColor = True
        ' 
        ' cbPhotography
        ' 
        cbPhotography.AutoSize = True
        cbPhotography.Location = New Point(152, 123)
        cbPhotography.Name = "cbPhotography"
        cbPhotography.Size = New Size(130, 23)
        cbPhotography.TabIndex = 19
        cbPhotography.Text = "Photography"
        cbPhotography.UseVisualStyleBackColor = True
        ' 
        ' cbSinging
        ' 
        cbSinging.AutoSize = True
        cbSinging.Location = New Point(152, 94)
        cbSinging.Name = "cbSinging"
        cbSinging.Size = New Size(88, 23)
        cbSinging.TabIndex = 17
        cbSinging.Text = "Singing"
        cbSinging.UseVisualStyleBackColor = True
        ' 
        ' cbEmbroidery
        ' 
        cbEmbroidery.AutoSize = True
        cbEmbroidery.Location = New Point(152, 66)
        cbEmbroidery.Name = "cbEmbroidery"
        cbEmbroidery.Size = New Size(121, 23)
        cbEmbroidery.TabIndex = 18
        cbEmbroidery.Text = "Embroidery"
        cbEmbroidery.UseVisualStyleBackColor = True
        ' 
        ' cbShopping
        ' 
        cbShopping.AutoSize = True
        cbShopping.Location = New Point(152, 37)
        cbShopping.Name = "cbShopping"
        cbShopping.Size = New Size(104, 23)
        cbShopping.TabIndex = 19
        cbShopping.Text = "Shopping"
        cbShopping.UseVisualStyleBackColor = True
        ' 
        ' cbKnitting
        ' 
        cbKnitting.AutoSize = True
        cbKnitting.Location = New Point(6, 123)
        cbKnitting.Name = "cbKnitting"
        cbKnitting.Size = New Size(96, 23)
        cbKnitting.TabIndex = 20
        cbKnitting.Text = "Knitting"
        cbKnitting.UseVisualStyleBackColor = True
        ' 
        ' cbDrawing
        ' 
        cbDrawing.AutoSize = True
        cbDrawing.Location = New Point(6, 94)
        cbDrawing.Name = "cbDrawing"
        cbDrawing.Size = New Size(96, 23)
        cbDrawing.TabIndex = 21
        cbDrawing.Text = "Drawing"
        cbDrawing.UseVisualStyleBackColor = True
        ' 
        ' cbCooking
        ' 
        cbCooking.AutoSize = True
        cbCooking.Location = New Point(6, 65)
        cbCooking.Name = "cbCooking"
        cbCooking.Size = New Size(96, 23)
        cbCooking.TabIndex = 16
        cbCooking.Text = "Cooking"
        cbCooking.UseVisualStyleBackColor = True
        ' 
        ' cbReading
        ' 
        cbReading.AutoSize = True
        cbReading.Location = New Point(6, 36)
        cbReading.Name = "cbReading"
        cbReading.Size = New Size(92, 23)
        cbReading.TabIndex = 0
        cbReading.Text = "Reading"
        cbReading.UseVisualStyleBackColor = True
        ' 
        ' btnPrintCard
        ' 
        btnPrintCard.BackColor = Color.LavenderBlush
        btnPrintCard.Font = New Font("STSong", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrintCard.Location = New Point(263, 407)
        btnPrintCard.Name = "btnPrintCard"
        btnPrintCard.Size = New Size(448, 29)
        btnPrintCard.TabIndex = 7
        btnPrintCard.Text = "Print Card"
        btnPrintCard.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.LavenderBlush
        btnBrowse.Font = New Font("STSong", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(12, 407)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(245, 29)
        btnBrowse.TabIndex = 8
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' dtpDateBirth
        ' 
        dtpDateBirth.CalendarForeColor = Color.HotPink
        dtpDateBirth.CalendarMonthBackground = Color.LavenderBlush
        dtpDateBirth.CalendarTitleBackColor = Color.Pink
        dtpDateBirth.CalendarTitleForeColor = Color.LightPink
        dtpDateBirth.CalendarTrailingForeColor = Color.PaleVioletRed
        dtpDateBirth.Font = New Font("STSong", 10.1999989F)
        dtpDateBirth.Format = DateTimePickerFormat.Custom
        dtpDateBirth.Location = New Point(396, 93)
        dtpDateBirth.Name = "dtpDateBirth"
        dtpDateBirth.Size = New Size(315, 30)
        dtpDateBirth.TabIndex = 9
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.LavenderBlush
        txtName.Font = New Font("STSong", 10.1999989F)
        txtName.Location = New Point(396, 6)
        txtName.Name = "txtName"
        txtName.Size = New Size(315, 30)
        txtName.TabIndex = 10
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.LavenderBlush
        txtAge.Font = New Font("STSong", 10.1999989F)
        txtAge.Location = New Point(396, 48)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(315, 30)
        txtAge.TabIndex = 11
        ' 
        ' txtPhoneNo
        ' 
        txtPhoneNo.BackColor = Color.LavenderBlush
        txtPhoneNo.Font = New Font("STSong", 10.1999989F)
        txtPhoneNo.Location = New Point(396, 139)
        txtPhoneNo.Name = "txtPhoneNo"
        txtPhoneNo.Size = New Size(315, 30)
        txtPhoneNo.TabIndex = 12
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.LavenderBlush
        txtAddress.Font = New Font("STSong", 10.1999989F)
        txtAddress.Location = New Point(396, 182)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(315, 30)
        txtAddress.TabIndex = 13
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LavenderBlush
        PictureBox1.Location = New Point(49, 158)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 212)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.Group_17
        PictureBox4.Location = New Point(12, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(245, 123)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.frame
        PictureBox2.Location = New Point(34, 142)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(200, 244)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(723, 442)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox4)
        Controls.Add(txtAddress)
        Controls.Add(txtPhoneNo)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(dtpDateBirth)
        Controls.Add(btnBrowse)
        Controls.Add(btnPrintCard)
        Controls.Add(gbxHobbies)
        Controls.Add(gbxGender)
        Controls.Add(lblPhoneNo)
        Controls.Add(lblAddress)
        Controls.Add(lblDateBirth)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        gbxGender.ResumeLayout(False)
        gbxGender.PerformLayout()
        gbxHobbies.ResumeLayout(False)
        gbxHobbies.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblDateBirth As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents gbxGender As GroupBox
    Friend WithEvents gbxHobbies As GroupBox
    Friend WithEvents btnPrintCard As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents dtpDateBirth As DateTimePicker
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Protected Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rbBoy As RadioButton
    Friend WithEvents cbReading As CheckBox
    Friend WithEvents rbGirl As RadioButton
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbJournaling As CheckBox
    Friend WithEvents cbPhotography As CheckBox
    Friend WithEvents cbSinging As CheckBox
    Friend WithEvents cbEmbroidery As CheckBox
    Friend WithEvents cbShopping As CheckBox
    Friend WithEvents cbKnitting As CheckBox
    Friend WithEvents cbDrawing As CheckBox
    Friend WithEvents cbCooking As CheckBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
