<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MephTheme1 = New WindowsApplication3.MephTheme()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MephButton3 = New WindowsApplication3.MephButton()
        Me.MephButton2 = New WindowsApplication3.MephButton()
        Me.MephButton1 = New WindowsApplication3.MephButton()
        Me.MephTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.Label4)
        Me.MephTheme1.Controls.Add(Me.Label1)
        Me.MephTheme1.Controls.Add(Me.MephButton3)
        Me.MephTheme1.Controls.Add(Me.MephButton2)
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(658, 163)
        Me.MephTheme1.SubHeader = "SUBTITLE"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(583, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Version: 0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(307, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ServerStatus: "
        '
        'MephButton3
        '
        Me.MephButton3.BackColor = System.Drawing.Color.Transparent
        Me.MephButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton3.Location = New System.Drawing.Point(12, 127)
        Me.MephButton3.Name = "MephButton3"
        Me.MephButton3.Size = New System.Drawing.Size(289, 23)
        Me.MephButton3.TabIndex = 2
        Me.MephButton3.Text = "GTA 5"
        '
        'MephButton2
        '
        Me.MephButton2.BackColor = System.Drawing.Color.Transparent
        Me.MephButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton2.Location = New System.Drawing.Point(12, 98)
        Me.MephButton2.Name = "MephButton2"
        Me.MephButton2.Size = New System.Drawing.Size(289, 23)
        Me.MephButton2.TabIndex = 1
        Me.MephButton2.Text = "CS:S"
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(12, 69)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(289, 23)
        Me.MephButton1.TabIndex = 0
        Me.MephButton1.Text = "CSGO"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 163)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.MephTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents MephButton1 As MephButton
    Friend WithEvents MephButton2 As MephButton
    Friend WithEvents MephButton3 As MephButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label4 As Label
End Class
