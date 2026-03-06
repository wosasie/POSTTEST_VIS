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
        GroupBox2 = New GroupBox()
        txtHapusJudul = New TextBox()
        btnHapus = New Button()
        Label1 = New Label()
        btnTambah = New Button()
        lblGenre = New Label()
        GroupBox1 = New GroupBox()
        txtGenre = New TextBox()
        txtTambahJudul = New TextBox()
        Label2 = New Label()
        lbBuku = New ListBox()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtHapusJudul)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Font = New Font("STFangsong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.DarkGreen
        GroupBox2.Location = New Point(344, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(315, 236)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' txtHapusJudul
        ' 
        txtHapusJudul.ForeColor = Color.DarkGreen
        txtHapusJudul.Location = New Point(125, 72)
        txtHapusJudul.Name = "txtHapusJudul"
        txtHapusJudul.Size = New Size(184, 31)
        txtHapusJudul.TabIndex = 7
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = SystemColors.ButtonHighlight
        btnHapus.Font = New Font("STFangsong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(6, 193)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(303, 37)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("STFangsong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 3
        Label1.Text = "Judul Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = SystemColors.ButtonHighlight
        btnTambah.Font = New Font("STFangsong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(6, 193)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(303, 37)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Font = New Font("STFangsong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGenre.Location = New Point(6, 130)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(54, 20)
        lblGenre.TabIndex = 2
        lblGenre.Text = "Genre"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtTambahJudul)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(lblGenre)
        GroupBox1.Font = New Font("STFangsong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.DarkGreen
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(315, 236)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.ForeColor = Color.DarkGreen
        txtGenre.Location = New Point(105, 127)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(204, 31)
        txtGenre.TabIndex = 8
        ' 
        ' txtTambahJudul
        ' 
        txtTambahJudul.ForeColor = Color.DarkGreen
        txtTambahJudul.Location = New Point(105, 72)
        txtTambahJudul.Name = "txtTambahJudul"
        txtTambahJudul.Size = New Size(204, 31)
        txtTambahJudul.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("STFangsong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 4
        Label2.Text = "Judul Buku"
        ' 
        ' lbBuku
        ' 
        lbBuku.Font = New Font("STFangsong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbBuku.ForeColor = Color.DarkGreen
        lbBuku.FormattingEnabled = True
        lbBuku.Location = New Point(12, 274)
        lbBuku.Name = "lbBuku"
        lbBuku.Size = New Size(647, 164)
        lbBuku.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(671, 450)
        Controls.Add(lbBuku)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        ForeColor = Color.DarkGreen
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Posttest 2"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblGenre As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHapusJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtTambahJudul As TextBox
    Friend WithEvents lbBuku As ListBox

End Class
