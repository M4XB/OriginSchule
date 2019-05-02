<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.inputBox = New System.Windows.Forms.TextBox()
        Me.Button_Equals = New System.Windows.Forms.Button()
        Me.OutputBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'inputBox
        '
        Me.inputBox.Location = New System.Drawing.Point(34, 32)
        Me.inputBox.Name = "inputBox"
        Me.inputBox.Size = New System.Drawing.Size(333, 20)
        Me.inputBox.TabIndex = 0
        '
        'Button_Equals
        '
        Me.Button_Equals.Location = New System.Drawing.Point(436, 331)
        Me.Button_Equals.Name = "Button_Equals"
        Me.Button_Equals.Size = New System.Drawing.Size(129, 28)
        Me.Button_Equals.TabIndex = 1
        Me.Button_Equals.Text = "Equals"
        Me.Button_Equals.UseVisualStyleBackColor = True
        '
        'OutputBox
        '
        Me.OutputBox.Location = New System.Drawing.Point(418, 32)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(147, 20)
        Me.OutputBox.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(577, 450)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.Button_Equals)
        Me.Controls.Add(Me.inputBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputBox As TextBox
    Friend WithEvents Button_Equals As Button
    Friend WithEvents OutputBox As TextBox
End Class
