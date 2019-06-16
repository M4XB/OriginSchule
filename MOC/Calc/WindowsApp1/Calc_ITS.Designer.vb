<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calc_ITS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMinimize = New System.Windows.Forms.Label()
        Me.LabelClose = New System.Windows.Forms.Label()
        Me.inputBox_URI_U = New System.Windows.Forms.TextBox()
        Me.inputBox_URI_R = New System.Windows.Forms.TextBox()
        Me.inputBox_URI_I = New System.Windows.Forms.TextBox()
        Me.inputBox_PUI_I = New System.Windows.Forms.TextBox()
        Me.inputBox_PUI_U = New System.Windows.Forms.TextBox()
        Me.inputBox_PUI_P = New System.Windows.Forms.TextBox()
        Me.Button_Calculate_URI = New System.Windows.Forms.Button()
        Me.Button_Calculate_PUI = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button_URI_Delete = New System.Windows.Forms.Button()
        Me.Button_PUI_Delete = New System.Windows.Forms.Button()
        Me.InputBox_SiPräfix = New System.Windows.Forms.TextBox()
        Me.InputBox_BinärPräfix = New System.Windows.Forms.TextBox()
        Me.Button_Calculate_Präfix = New System.Windows.Forms.Button()
        Me.Button_Delete_Präfix = New System.Windows.Forms.Button()
        Me.Button_Change_Direction = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 56)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ITS"
        '
        'LabelMinimize
        '
        Me.LabelMinimize.AutoSize = True
        Me.LabelMinimize.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMinimize.ForeColor = System.Drawing.Color.Aqua
        Me.LabelMinimize.Location = New System.Drawing.Point(540, 0)
        Me.LabelMinimize.Name = "LabelMinimize"
        Me.LabelMinimize.Size = New System.Drawing.Size(15, 17)
        Me.LabelMinimize.TabIndex = 11
        Me.LabelMinimize.Text = "_"
        '
        'LabelClose
        '
        Me.LabelClose.AutoSize = True
        Me.LabelClose.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClose.ForeColor = System.Drawing.Color.Aqua
        Me.LabelClose.Location = New System.Drawing.Point(560, 3)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(15, 17)
        Me.LabelClose.TabIndex = 12
        Me.LabelClose.Text = "X"
        '
        'inputBox_URI_U
        '
        Me.inputBox_URI_U.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputBox_URI_U.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inputBox_URI_U.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputBox_URI_U.ForeColor = System.Drawing.Color.Aqua
        Me.inputBox_URI_U.Location = New System.Drawing.Point(22, 111)
        Me.inputBox_URI_U.Name = "inputBox_URI_U"
        Me.inputBox_URI_U.Size = New System.Drawing.Size(91, 25)
        Me.inputBox_URI_U.TabIndex = 1
        '
        'inputBox_URI_R
        '
        Me.inputBox_URI_R.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputBox_URI_R.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inputBox_URI_R.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputBox_URI_R.ForeColor = System.Drawing.Color.Aqua
        Me.inputBox_URI_R.Location = New System.Drawing.Point(119, 111)
        Me.inputBox_URI_R.Name = "inputBox_URI_R"
        Me.inputBox_URI_R.Size = New System.Drawing.Size(91, 25)
        Me.inputBox_URI_R.TabIndex = 2
        '
        'inputBox_URI_I
        '
        Me.inputBox_URI_I.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputBox_URI_I.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inputBox_URI_I.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputBox_URI_I.ForeColor = System.Drawing.Color.Aqua
        Me.inputBox_URI_I.Location = New System.Drawing.Point(216, 111)
        Me.inputBox_URI_I.Name = "inputBox_URI_I"
        Me.inputBox_URI_I.Size = New System.Drawing.Size(91, 25)
        Me.inputBox_URI_I.TabIndex = 3
        '
        'inputBox_PUI_I
        '
        Me.inputBox_PUI_I.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputBox_PUI_I.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inputBox_PUI_I.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputBox_PUI_I.ForeColor = System.Drawing.Color.Aqua
        Me.inputBox_PUI_I.Location = New System.Drawing.Point(216, 180)
        Me.inputBox_PUI_I.Name = "inputBox_PUI_I"
        Me.inputBox_PUI_I.Size = New System.Drawing.Size(91, 25)
        Me.inputBox_PUI_I.TabIndex = 8
        '
        'inputBox_PUI_U
        '
        Me.inputBox_PUI_U.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputBox_PUI_U.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inputBox_PUI_U.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputBox_PUI_U.ForeColor = System.Drawing.Color.Aqua
        Me.inputBox_PUI_U.Location = New System.Drawing.Point(119, 180)
        Me.inputBox_PUI_U.Name = "inputBox_PUI_U"
        Me.inputBox_PUI_U.Size = New System.Drawing.Size(91, 25)
        Me.inputBox_PUI_U.TabIndex = 7
        '
        'inputBox_PUI_P
        '
        Me.inputBox_PUI_P.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputBox_PUI_P.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inputBox_PUI_P.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputBox_PUI_P.ForeColor = System.Drawing.Color.Aqua
        Me.inputBox_PUI_P.Location = New System.Drawing.Point(22, 180)
        Me.inputBox_PUI_P.Name = "inputBox_PUI_P"
        Me.inputBox_PUI_P.Size = New System.Drawing.Size(91, 25)
        Me.inputBox_PUI_P.TabIndex = 6
        '
        'Button_Calculate_URI
        '
        Me.Button_Calculate_URI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Calculate_URI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Calculate_URI.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Calculate_URI.ForeColor = System.Drawing.Color.Aqua
        Me.Button_Calculate_URI.Location = New System.Drawing.Point(330, 111)
        Me.Button_Calculate_URI.Name = "Button_Calculate_URI"
        Me.Button_Calculate_URI.Size = New System.Drawing.Size(91, 25)
        Me.Button_Calculate_URI.TabIndex = 4
        Me.Button_Calculate_URI.Text = "Calculate"
        Me.Button_Calculate_URI.UseVisualStyleBackColor = True
        '
        'Button_Calculate_PUI
        '
        Me.Button_Calculate_PUI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Calculate_PUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Calculate_PUI.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Calculate_PUI.ForeColor = System.Drawing.Color.Aqua
        Me.Button_Calculate_PUI.Location = New System.Drawing.Point(330, 180)
        Me.Button_Calculate_PUI.Name = "Button_Calculate_PUI"
        Me.Button_Calculate_PUI.Size = New System.Drawing.Size(91, 25)
        Me.Button_Calculate_PUI.TabIndex = 9
        Me.Button_Calculate_PUI.Text = "Calculate"
        Me.Button_Calculate_PUI.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(48, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "U (V)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(145, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "U (V)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(145, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "R (Ω)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(242, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "I (A)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Aqua
        Me.Label6.Location = New System.Drawing.Point(48, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "P (W)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Aqua
        Me.Label7.Location = New System.Drawing.Point(242, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "I (A)"
        '
        'Button_URI_Delete
        '
        Me.Button_URI_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_URI_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_URI_Delete.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_URI_Delete.ForeColor = System.Drawing.Color.Aqua
        Me.Button_URI_Delete.Location = New System.Drawing.Point(427, 111)
        Me.Button_URI_Delete.Name = "Button_URI_Delete"
        Me.Button_URI_Delete.Size = New System.Drawing.Size(91, 25)
        Me.Button_URI_Delete.TabIndex = 5
        Me.Button_URI_Delete.Text = "Delete"
        Me.Button_URI_Delete.UseVisualStyleBackColor = True
        '
        'Button_PUI_Delete
        '
        Me.Button_PUI_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_PUI_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_PUI_Delete.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_PUI_Delete.ForeColor = System.Drawing.Color.Aqua
        Me.Button_PUI_Delete.Location = New System.Drawing.Point(427, 180)
        Me.Button_PUI_Delete.Name = "Button_PUI_Delete"
        Me.Button_PUI_Delete.Size = New System.Drawing.Size(91, 25)
        Me.Button_PUI_Delete.TabIndex = 10
        Me.Button_PUI_Delete.Text = "Delete"
        Me.Button_PUI_Delete.UseVisualStyleBackColor = True
        '
        'InputBox_SiPräfix
        '
        Me.InputBox_SiPräfix.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InputBox_SiPräfix.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InputBox_SiPräfix.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBox_SiPräfix.ForeColor = System.Drawing.Color.Aqua
        Me.InputBox_SiPräfix.Location = New System.Drawing.Point(183, 258)
        Me.InputBox_SiPräfix.Name = "InputBox_SiPräfix"
        Me.InputBox_SiPräfix.Size = New System.Drawing.Size(91, 25)
        Me.InputBox_SiPräfix.TabIndex = 13
        '
        'InputBox_BinärPräfix
        '
        Me.InputBox_BinärPräfix.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InputBox_BinärPräfix.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InputBox_BinärPräfix.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBox_BinärPräfix.ForeColor = System.Drawing.Color.Aqua
        Me.InputBox_BinärPräfix.Location = New System.Drawing.Point(50, 258)
        Me.InputBox_BinärPräfix.Name = "InputBox_BinärPräfix"
        Me.InputBox_BinärPräfix.Size = New System.Drawing.Size(91, 25)
        Me.InputBox_BinärPräfix.TabIndex = 11
        '
        'Button_Calculate_Präfix
        '
        Me.Button_Calculate_Präfix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Calculate_Präfix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Calculate_Präfix.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Calculate_Präfix.ForeColor = System.Drawing.Color.Aqua
        Me.Button_Calculate_Präfix.Location = New System.Drawing.Point(330, 258)
        Me.Button_Calculate_Präfix.Name = "Button_Calculate_Präfix"
        Me.Button_Calculate_Präfix.Size = New System.Drawing.Size(91, 25)
        Me.Button_Calculate_Präfix.TabIndex = 14
        Me.Button_Calculate_Präfix.Text = "Calculate"
        Me.Button_Calculate_Präfix.UseVisualStyleBackColor = True
        '
        'Button_Delete_Präfix
        '
        Me.Button_Delete_Präfix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Delete_Präfix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Delete_Präfix.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete_Präfix.ForeColor = System.Drawing.Color.Aqua
        Me.Button_Delete_Präfix.Location = New System.Drawing.Point(427, 258)
        Me.Button_Delete_Präfix.Name = "Button_Delete_Präfix"
        Me.Button_Delete_Präfix.Size = New System.Drawing.Size(91, 25)
        Me.Button_Delete_Präfix.TabIndex = 15
        Me.Button_Delete_Präfix.Text = "Delete"
        Me.Button_Delete_Präfix.UseVisualStyleBackColor = True
        '
        'Button_Change_Direction
        '
        Me.Button_Change_Direction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Change_Direction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Change_Direction.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Change_Direction.ForeColor = System.Drawing.Color.Aqua
        Me.Button_Change_Direction.Location = New System.Drawing.Point(147, 258)
        Me.Button_Change_Direction.Name = "Button_Change_Direction"
        Me.Button_Change_Direction.Size = New System.Drawing.Size(30, 25)
        Me.Button_Change_Direction.TabIndex = 12
        Me.Button_Change_Direction.Text = ">"
        Me.Button_Change_Direction.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Aqua
        Me.Label8.Location = New System.Drawing.Point(63, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Binärpräfix"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Aqua
        Me.Label9.Location = New System.Drawing.Point(196, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Si-Präfix"
        '
        'Calc_ITS
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(577, 392)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button_Change_Direction)
        Me.Controls.Add(Me.Button_Delete_Präfix)
        Me.Controls.Add(Me.Button_Calculate_Präfix)
        Me.Controls.Add(Me.InputBox_BinärPräfix)
        Me.Controls.Add(Me.InputBox_SiPräfix)
        Me.Controls.Add(Me.Button_PUI_Delete)
        Me.Controls.Add(Me.Button_URI_Delete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Calculate_PUI)
        Me.Controls.Add(Me.Button_Calculate_URI)
        Me.Controls.Add(Me.inputBox_PUI_I)
        Me.Controls.Add(Me.inputBox_PUI_U)
        Me.Controls.Add(Me.inputBox_PUI_P)
        Me.Controls.Add(Me.inputBox_URI_I)
        Me.Controls.Add(Me.inputBox_URI_R)
        Me.Controls.Add(Me.inputBox_URI_U)
        Me.Controls.Add(Me.LabelClose)
        Me.Controls.Add(Me.LabelMinimize)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calc_ITS"
        Me.Text = "Calc_ITS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelMinimize As Label
    Friend WithEvents LabelClose As Label
    Friend WithEvents inputBox_URI_U As TextBox
    Friend WithEvents inputBox_URI_R As TextBox
    Friend WithEvents inputBox_URI_I As TextBox
    Friend WithEvents inputBox_PUI_I As TextBox
    Friend WithEvents inputBox_PUI_U As TextBox
    Friend WithEvents inputBox_PUI_P As TextBox
    Friend WithEvents Button_Calculate_URI As Button
    Friend WithEvents Button_Calculate_PUI As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button_URI_Delete As Button
    Friend WithEvents Button_PUI_Delete As Button
    Friend WithEvents InputBox_SiPräfix As TextBox
    Friend WithEvents InputBox_BinärPräfix As TextBox
    Friend WithEvents Button_Calculate_Präfix As Button
    Friend WithEvents Button_Delete_Präfix As Button
    Friend WithEvents Button_Change_Direction As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
