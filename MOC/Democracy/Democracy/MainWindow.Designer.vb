<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.Preset1Button = New System.Windows.Forms.Button()
        Me.CustomPresetButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Preset2Button = New System.Windows.Forms.Button()
        Me.outputStats = New System.Windows.Forms.TextBox()
        Me.outputGrid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Preset1Button
        '
        Me.Preset1Button.BackColor = System.Drawing.SystemColors.Control
        Me.Preset1Button.Location = New System.Drawing.Point(873, 66)
        Me.Preset1Button.Name = "Preset1Button"
        Me.Preset1Button.Size = New System.Drawing.Size(138, 27)
        Me.Preset1Button.TabIndex = 0
        Me.Preset1Button.Text = "Preset 1"
        Me.Preset1Button.UseVisualStyleBackColor = False
        '
        'CustomPresetButton
        '
        Me.CustomPresetButton.Location = New System.Drawing.Point(873, 132)
        Me.CustomPresetButton.Name = "CustomPresetButton"
        Me.CustomPresetButton.Size = New System.Drawing.Size(138, 27)
        Me.CustomPresetButton.TabIndex = 2
        Me.CustomPresetButton.Text = "Custom Preset"
        Me.CustomPresetButton.UseVisualStyleBackColor = False
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(873, 165)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(138, 27)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'Preset2Button
        '
        Me.Preset2Button.BackColor = System.Drawing.SystemColors.Control
        Me.Preset2Button.Location = New System.Drawing.Point(873, 99)
        Me.Preset2Button.Name = "Preset2Button"
        Me.Preset2Button.Size = New System.Drawing.Size(138, 27)
        Me.Preset2Button.TabIndex = 1
        Me.Preset2Button.Text = "Preset 2"
        Me.Preset2Button.UseVisualStyleBackColor = False
        '
        'outputStats
        '
        Me.outputStats.Location = New System.Drawing.Point(873, 199)
        Me.outputStats.Multiline = True
        Me.outputStats.Name = "outputStats"
        Me.outputStats.Size = New System.Drawing.Size(138, 175)
        Me.outputStats.TabIndex = 4
        '
        'outputGrid
        '
        Me.outputGrid.Location = New System.Drawing.Point(12, 66)
        Me.outputGrid.Multiline = True
        Me.outputGrid.Name = "outputGrid"
        Me.outputGrid.Size = New System.Drawing.Size(764, 308)
        Me.outputGrid.TabIndex = 5
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 391)
        Me.Controls.Add(Me.outputGrid)
        Me.Controls.Add(Me.outputStats)
        Me.Controls.Add(Me.Preset2Button)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.CustomPresetButton)
        Me.Controls.Add(Me.Preset1Button)
        Me.Name = "MainWindow"
        Me.Text = "Democracy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Preset1Button As Button
    Friend WithEvents CustomPresetButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents Preset2Button As Button
    Friend WithEvents outputStats As TextBox
    Friend WithEvents outputGrid As TextBox
End Class
