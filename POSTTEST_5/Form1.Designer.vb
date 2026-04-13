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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtCode = New TextBox()
        txtName = New TextBox()
        txtStock = New TextBox()
        txtPrice = New TextBox()
        cbTeam = New ComboBox()
        cbCategory = New ComboBox()
        ErrorProvider1 = New ErrorProvider(components)
        dgvMerch = New DataGridView()
        txtSearch = New TextBox()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnReset = New Button()
        Label8 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvMerch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(95, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 21)
        Label1.TabIndex = 0
        Label1.Text = "Merch Code"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(95, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 21)
        Label2.TabIndex = 1
        Label2.Text = "Merch Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(95, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 21)
        Label3.TabIndex = 2
        Label3.Text = "Merch Team"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(95, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 21)
        Label4.TabIndex = 3
        Label4.Text = "Merch Category"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(95, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 21)
        Label5.TabIndex = 4
        Label5.Text = "Merch Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(95, 260)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 21)
        Label6.TabIndex = 5
        Label6.Text = "Merch Price"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(95, 307)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 21)
        Label7.TabIndex = 6
        Label7.Text = "Search Merch"
        ' 
        ' txtCode
        ' 
        txtCode.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        txtCode.ForeColor = Color.Black
        txtCode.Location = New Point(274, 70)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(368, 29)
        txtCode.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        txtName.ForeColor = Color.Black
        txtName.Location = New Point(274, 107)
        txtName.Name = "txtName"
        txtName.Size = New Size(368, 29)
        txtName.TabIndex = 8
        ' 
        ' txtStock
        ' 
        txtStock.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        txtStock.ForeColor = Color.Black
        txtStock.Location = New Point(274, 220)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(368, 29)
        txtStock.TabIndex = 9
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        txtPrice.ForeColor = Color.Black
        txtPrice.Location = New Point(274, 257)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(368, 29)
        txtPrice.TabIndex = 10
        ' 
        ' cbTeam
        ' 
        cbTeam.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        cbTeam.ForeColor = Color.Black
        cbTeam.FormattingEnabled = True
        cbTeam.Items.AddRange(New Object() {"McLaren", "Ferrari", "Aston Martin", "Williams", "Red Bull", "Cadilac", "Alpine", "Audi", "Mercedes", "Haas", "Racing Bulls"})
        cbTeam.Location = New Point(274, 144)
        cbTeam.Name = "cbTeam"
        cbTeam.Size = New Size(368, 29)
        cbTeam.TabIndex = 11
        ' 
        ' cbCategory
        ' 
        cbCategory.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        cbCategory.ForeColor = Color.Black
        cbCategory.FormattingEnabled = True
        cbCategory.Items.AddRange(New Object() {"T-Shirt", "Headwear", "Polos", "Outerwear", "Accessories", "Jerseys"})
        cbCategory.Location = New Point(274, 182)
        cbCategory.Name = "cbCategory"
        cbCategory.Size = New Size(368, 29)
        cbCategory.TabIndex = 12
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' dgvMerch
        ' 
        dgvMerch.BackgroundColor = Color.White
        dgvMerch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMerch.Location = New Point(12, 380)
        dgvMerch.Name = "dgvMerch"
        dgvMerch.RowHeadersWidth = 51
        dgvMerch.Size = New Size(716, 199)
        dgvMerch.TabIndex = 13
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        txtSearch.ForeColor = Color.Black
        txtSearch.Location = New Point(274, 304)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(368, 29)
        txtSearch.TabIndex = 14
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        btnSave.Location = New Point(95, 345)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(121, 28)
        btnSave.TabIndex = 15
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        btnUpdate.Location = New Point(237, 345)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(121, 28)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        btnDelete.Location = New Point(379, 345)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(121, 28)
        btnDelete.TabIndex = 17
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Adobe Caslon", 10.8F, FontStyle.Bold Or FontStyle.Italic)
        btnReset.Location = New Point(521, 345)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(121, 28)
        btnReset.TabIndex = 18
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Adobe Caslon", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(47, 16)
        Label8.Name = "Label8"
        Label8.Size = New Size(641, 40)
        Label8.TabIndex = 19
        Label8.Text = "Formula 1 Merchandise Management System"
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(740, 591)
        Controls.Add(Label8)
        Controls.Add(btnReset)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(txtSearch)
        Controls.Add(dgvMerch)
        Controls.Add(cbCategory)
        Controls.Add(cbTeam)
        Controls.Add(txtPrice)
        Controls.Add(txtStock)
        Controls.Add(txtName)
        Controls.Add(txtCode)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Management System"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvMerch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cbTeam As ComboBox
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvMerch As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label8 As Label

End Class
