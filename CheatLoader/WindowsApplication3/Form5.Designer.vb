<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MephTheme1 = New WindowsApplication3.MephTheme()
        Me.MephButton300000 = New WindowsApplication3.MephButton()
        Me.MephButton2 = New WindowsApplication3.MephButton()
        Me.MephButton20000 = New WindowsApplication3.MephButton()
        Me.MephButton1 = New WindowsApplication3.MephButton()
        Me.MephTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.MephButton300000)
        Me.MephTheme1.Controls.Add(Me.MephButton2)
        Me.MephTheme1.Controls.Add(Me.MephButton20000)
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(284, 262)
        Me.MephTheme1.SubHeader = "We have currently x Cheats !"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "CHEAT"
        '
        'MephButton300000
        '
        Me.MephButton300000.BackColor = System.Drawing.Color.Transparent
        Me.MephButton300000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton300000.Location = New System.Drawing.Point(12, 227)
        Me.MephButton300000.Name = "MephButton300000"
        Me.MephButton300000.Size = New System.Drawing.Size(75, 23)
        Me.MephButton300000.TabIndex = 5
        Me.MephButton300000.Text = "BACK"
        '
        'MephButton2
        '
        Me.MephButton2.BackColor = System.Drawing.Color.Transparent
        Me.MephButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton2.Location = New System.Drawing.Point(12, 98)
        Me.MephButton2.Name = "MephButton2"
        Me.MephButton2.Size = New System.Drawing.Size(260, 23)
        Me.MephButton2.TabIndex = 2
        Me.MephButton2.Text = "CHEAT"
        '
        'MephButton20000
        '
        Me.MephButton20000.BackColor = System.Drawing.Color.Transparent
        Me.MephButton20000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton20000.Location = New System.Drawing.Point(197, 227)
        Me.MephButton20000.Name = "MephButton20000"
        Me.MephButton20000.Size = New System.Drawing.Size(75, 23)
        Me.MephButton20000.TabIndex = 1
        Me.MephButton20000.Text = "EXIT"
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(12, 69)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(260, 23)
        Me.MephButton1.TabIndex = 0
        Me.MephButton1.Text = "CHEAT"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents MephButton1 As MephButton
    Friend WithEvents MephButton20000 As MephButton
    Friend WithEvents MephButton2 As MephButton
    Friend WithEvents MephButton300000 As MephButton
End Class
