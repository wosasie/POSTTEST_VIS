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
        lblIPS = New Label()
        lblIPKumulatif = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' lblIPS
        ' 
        lblIPS.AutoSize = True
        lblIPS.Location = New Point(153, 142)
        lblIPS.Name = "lblIPS"
        lblIPS.Size = New Size(86, 20)
        lblIPS.TabIndex = 0
        lblIPS.Text = "IP Semester"
        ' 
        ' lblIPKumulatif
        ' 
        lblIPKumulatif.AutoSize = True
        lblIPKumulatif.Location = New Point(153, 267)
        lblIPKumulatif.Name = "lblIPKumulatif"
        lblIPKumulatif.Size = New Size(89, 20)
        lblIPKumulatif.TabIndex = 1
        lblIPKumulatif.Text = "IP Kumulatif"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(286, 199)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(410, 199)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(286, 139)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(218, 27)
        txtIPS.TabIndex = 4
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(286, 264)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(218, 27)
        txtIPK.TabIndex = 5
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(286, 321)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(63, 20)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "Predikat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(695, 450)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(lblIPKumulatif)
        Controls.Add(lblIPS)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPKumulatif As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label

End Class
