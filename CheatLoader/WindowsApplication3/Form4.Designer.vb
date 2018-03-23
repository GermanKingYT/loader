<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim MephButton200000 As WindowsApplication3.MephButton
        Me.MephTheme1 = New WindowsApplication3.MephTheme()
        Me.MephButton500000 = New WindowsApplication3.MephButton()
        Me.MephButton4 = New WindowsApplication3.MephButton()
        Me.MephButton3 = New WindowsApplication3.MephButton()
        Me.MephButton2 = New WindowsApplication3.MephButton()
        Me.MephButton1 = New WindowsApplication3.MephButton()
        MephButton200000 = New WindowsApplication3.MephButton()
        Me.MephTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MephButton200000
        '
        MephButton200000.BackColor = System.Drawing.Color.Transparent
        MephButton200000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MephButton200000.Location = New System.Drawing.Point(196, 227)
        MephButton200000.Name = "MephButton200000"
        MephButton200000.Size = New System.Drawing.Size(75, 23)
        MephButton200000.TabIndex = 1
        MephButton200000.Text = "EXIT"
        AddHandler MephButton200000.Click, AddressOf Me.MephButton200000_Click
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.MephButton500000)
        Me.MephTheme1.Controls.Add(Me.MephButton4)
        Me.MephTheme1.Controls.Add(Me.MephButton3)
        Me.MephTheme1.Controls.Add(Me.MephButton2)
        Me.MephTheme1.Controls.Add(MephButton200000)
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(284, 262)
        Me.MephTheme1.SubHeader = "We have currently x Cheats !"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "CHEAT"
        '
        'MephButton500000
        '
        Me.MephButton500000.BackColor = System.Drawing.Color.Transparent
        Me.MephButton500000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton500000.Location = New System.Drawing.Point(12, 227)
        Me.MephButton500000.Name = "MephButton500000"
        Me.MephButton500000.Size = New System.Drawing.Size(75, 23)
        Me.MephButton500000.TabIndex = 5
        Me.MephButton500000.Text = "BACK"
        '
        'MephButton4
        '
        Me.MephButton4.BackColor = System.Drawing.Color.Transparent
        Me.MephButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton4.Location = New System.Drawing.Point(12, 155)
        Me.MephButton4.Name = "MephButton4"
        Me.MephButton4.Size = New System.Drawing.Size(259, 23)
        Me.MephButton4.TabIndex = 4
        Me.MephButton4.Text = "CHEAT"
        '
        'MephButton3
        '
        Me.MephButton3.BackColor = System.Drawing.Color.Transparent
        Me.MephButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton3.Location = New System.Drawing.Point(12, 126)
        Me.MephButton3.Name = "MephButton3"
        Me.MephButton3.Size = New System.Drawing.Size(260, 23)
        Me.MephButton3.TabIndex = 3
        Me.MephButton3.Text = "CHEAT"
        '
        'MephButton2
        '
        Me.MephButton2.BackColor = System.Drawing.Color.Transparent
        Me.MephButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton2.Location = New System.Drawing.Point(12, 97)
        Me.MephButton2.Name = "MephButton2"
        Me.MephButton2.Size = New System.Drawing.Size(259, 23)
        Me.MephButton2.TabIndex = 2
        Me.MephButton2.Text = "CHEAT"
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(12, 68)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(260, 23)
        Me.MephButton1.TabIndex = 0
        Me.MephButton1.Text = "CHEAT"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents MephButton1 As MephButton
    Friend WithEvents MephButton2 As MephButton
    Friend WithEvents MephButton3 As MephButton
    Friend WithEvents MephButton4 As MephButton
    Friend WithEvents MephButton500000 As MephButton
End Class
