﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calc_Main
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
        Me.inputBox = New System.Windows.Forms.TextBox()
        Me.Button_Equals = New System.Windows.Forms.Button()
        Me.OutputBox = New System.Windows.Forms.TextBox()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MemoryBox = New System.Windows.Forms.TextBox()
        Me.Button_ClearMemory = New System.Windows.Forms.Button()
        Me.Button_PlaceResultInInput = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelClose = New System.Windows.Forms.Label()
        Me.LabelMinimize = New System.Windows.Forms.Label()
        Me.Button_OpenITS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'inputBox
        '
        Me.inputBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inputBox.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputBox.ForeColor = System.Drawing.Color.Aqua
        Me.inputBox.Location = New System.Drawing.Point(34, 32)
        Me.inputBox.Name = "inputBox"
        Me.inputBox.Size = New System.Drawing.Size(333, 25)
        Me.inputBox.TabIndex = 0
        '
        'Button_Equals
        '
        Me.Button_Equals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Equals.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Equals.ForeColor = System.Drawing.Color.Aqua
        Me.Button_Equals.Location = New System.Drawing.Point(474, 77)
        Me.Button_Equals.Name = "Button_Equals"
        Me.Button_Equals.Size = New System.Drawing.Size(91, 28)
        Me.Button_Equals.TabIndex = 2
        Me.Button_Equals.Text = "Equals"
        Me.Button_Equals.UseVisualStyleBackColor = True
        '
        'OutputBox
        '
        Me.OutputBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputBox.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputBox.ForeColor = System.Drawing.Color.Aqua
        Me.OutputBox.Location = New System.Drawing.Point(418, 32)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(147, 25)
        Me.OutputBox.TabIndex = 1
        '
        'Button_Delete
        '
        Me.Button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Delete.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.ForeColor = System.Drawing.Color.Aqua
        Me.Button_Delete.Location = New System.Drawing.Point(474, 111)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(91, 28)
        Me.Button_Delete.TabIndex = 3
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(383, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "="
        '
        'MemoryBox
        '
        Me.MemoryBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MemoryBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MemoryBox.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoryBox.ForeColor = System.Drawing.Color.Aqua
        Me.MemoryBox.Location = New System.Drawing.Point(34, 161)
        Me.MemoryBox.Multiline = True
        Me.MemoryBox.Name = "MemoryBox"
        Me.MemoryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MemoryBox.Size = New System.Drawing.Size(333, 181)
        Me.MemoryBox.TabIndex = 5
        '
        'Button_ClearMemory
        '
        Me.Button_ClearMemory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_ClearMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ClearMemory.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ClearMemory.ForeColor = System.Drawing.SystemColors.Window
        Me.Button_ClearMemory.Location = New System.Drawing.Point(34, 348)
        Me.Button_ClearMemory.Name = "Button_ClearMemory"
        Me.Button_ClearMemory.Size = New System.Drawing.Size(75, 28)
        Me.Button_ClearMemory.TabIndex = 7
        Me.Button_ClearMemory.Text = "Clear"
        Me.Button_ClearMemory.UseVisualStyleBackColor = True
        '
        'Button_PlaceResultInInput
        '
        Me.Button_PlaceResultInInput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_PlaceResultInInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_PlaceResultInInput.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_PlaceResultInInput.ForeColor = System.Drawing.Color.Aqua
        Me.Button_PlaceResultInInput.Location = New System.Drawing.Point(373, 161)
        Me.Button_PlaceResultInInput.Name = "Button_PlaceResultInInput"
        Me.Button_PlaceResultInInput.Size = New System.Drawing.Size(23, 28)
        Me.Button_PlaceResultInInput.TabIndex = 6
        Me.Button_PlaceResultInInput.Text = "^"
        Me.Button_PlaceResultInInput.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(56, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 56)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CALCULATOR"
        '
        'LabelClose
        '
        Me.LabelClose.AutoSize = True
        Me.LabelClose.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClose.ForeColor = System.Drawing.Color.Aqua
        Me.LabelClose.Location = New System.Drawing.Point(560, 3)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(15, 17)
        Me.LabelClose.TabIndex = 9
        Me.LabelClose.Text = "X"
        '
        'LabelMinimize
        '
        Me.LabelMinimize.AutoSize = True
        Me.LabelMinimize.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMinimize.ForeColor = System.Drawing.Color.Aqua
        Me.LabelMinimize.Location = New System.Drawing.Point(542, 0)
        Me.LabelMinimize.Name = "LabelMinimize"
        Me.LabelMinimize.Size = New System.Drawing.Size(15, 17)
        Me.LabelMinimize.TabIndex = 10
        Me.LabelMinimize.Text = "_"
        '
        'Button_OpenITS
        '
        Me.Button_OpenITS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OpenITS.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OpenITS.ForeColor = System.Drawing.Color.Aqua
        Me.Button_OpenITS.Location = New System.Drawing.Point(474, 158)
        Me.Button_OpenITS.Name = "Button_OpenITS"
        Me.Button_OpenITS.Size = New System.Drawing.Size(91, 28)
        Me.Button_OpenITS.TabIndex = 11
        Me.Button_OpenITS.Text = "ITS"
        Me.Button_OpenITS.UseVisualStyleBackColor = True
        '
        'Calc_Main
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(577, 392)
        Me.Controls.Add(Me.Button_OpenITS)
        Me.Controls.Add(Me.LabelMinimize)
        Me.Controls.Add(Me.LabelClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_PlaceResultInInput)
        Me.Controls.Add(Me.Button_ClearMemory)
        Me.Controls.Add(Me.MemoryBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.Button_Equals)
        Me.Controls.Add(Me.inputBox)
        Me.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calc_Main"
        Me.Text = "Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputBox As TextBox
    Friend WithEvents Button_Equals As Button
    Friend WithEvents OutputBox As TextBox
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MemoryBox As TextBox
    Friend WithEvents Button_ClearMemory As Button
    Friend WithEvents Button_PlaceResultInInput As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelClose As Label
    Friend WithEvents LabelMinimize As Label
    Friend WithEvents Button_OpenITS As Button
End Class
