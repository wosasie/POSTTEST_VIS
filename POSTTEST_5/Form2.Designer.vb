<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 2000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Adobe Caslon", 35.9999962F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 189)
        Label1.Name = "Label1"
        Label1.Size = New Size(451, 71)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Adobe Caslon", 35.9999962F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(244, 260)
        Label2.Name = "Label2"
        Label2.Size = New Size(484, 71)
        Label2.TabIndex = 1
        Label2.Text = "FORMULA ONE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Adobe Caslon", 21F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(15, 331)
        Label3.Name = "Label3"
        Label3.Size = New Size(712, 41)
        Label3.TabIndex = 2
        Label3.Text = "MERCHANDISE MANAGEMENT SYSTEM"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(740, 591)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Opening"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
