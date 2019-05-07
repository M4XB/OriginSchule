Public Class customPreset

    'Variables
    Public m_blackChecked As Boolean
    Public m_greyChecked As Boolean
    Public m_brownChecked As Boolean
    Public m_yellowChecked As Boolean
    Public m_redChecked As Boolean
    Public m_orangeChecked As Boolean
    Public m_blueChecked As Boolean
    Public m_greenChecked As Boolean
    Public m_pinkChecked As Boolean
    Public m_populationValue As Integer
    Private m_populationSet As Boolean
    Private m_partiesChecked As Integer
    Private m_e As EventArgs

    Private Sub CustomPreset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BevoeklerungsgroesseText_TextChanged(sender As Object, e As EventArgs) Handles BevoeklerungsgroesseText.KeyPress
        m_e = e
    End Sub

    Private Function isNumber(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isSquareNumber(value As Integer) As Boolean
        For index = 1 To value
            If index * index = value Then
                Return True
            End If
        Next
        Return False
    End Function

    'Methods for the checkboxes
    Private Sub CheckBoxBlack_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBlack.CheckedChanged
        If m_blackChecked Then
            m_blackChecked = False
        Else
            m_blackChecked = True
        End If
        MainWindow.m_blackChecked = m_blackChecked
    End Sub

    Private Sub CheckBoxGrey_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxGrey.CheckedChanged
        If m_greyChecked Then
            m_greyChecked = False
        Else
            m_greyChecked = True
        End If
        MainWindow.m_greyChecked = m_greyChecked
    End Sub

    Private Sub CheckBoxBrown_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBrown.CheckedChanged
        If m_brownChecked Then
            m_brownChecked = False
        Else
            m_brownChecked = True
        End If
        MainWindow.m_brownChecked = m_brownChecked
    End Sub

    Private Sub CheckBoxYellow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxYellow.CheckedChanged
        If m_yellowChecked Then
            m_yellowChecked = False
        Else
            m_yellowChecked = True
        End If
        MainWindow.m_yellowChecked = m_yellowChecked
    End Sub

    Private Sub CheckBoxRed_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRed.CheckedChanged
        If m_redChecked Then
            m_redChecked = False
        Else
            m_redChecked = True
        End If
        MainWindow.m_redChecked = m_redChecked
    End Sub

    Private Sub CheckBoxOrange_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOrange.CheckedChanged
        If m_orangeChecked Then
            m_orangeChecked = False
        Else
            m_orangeChecked = True
        End If
        MainWindow.m_orangeChecked = m_orangeChecked
    End Sub

    Private Sub CheckBoxBlue_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBlue.CheckedChanged
        If m_blueChecked Then
            m_blueChecked = False
        Else
            m_blueChecked = True
        End If
        MainWindow.m_blueChecked = m_blueChecked
    End Sub

    Private Sub CheckBoxGreen_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxGreen.CheckedChanged
        If m_greenChecked Then
            m_greenChecked = False
        Else
            m_greenChecked = True
        End If
        MainWindow.m_greenChecked = m_greenChecked
    End Sub

    Private Sub CheckBoxPink_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPink.CheckedChanged
        If m_pinkChecked Then
            m_pinkChecked = False
        Else
            m_pinkChecked = True
        End If
        MainWindow.m_pinkChecked = m_pinkChecked
    End Sub

    Private Sub CustomPresetOkButton_Click(sender As Object, e As EventArgs) Handles CustomPresetOkButton.Click
        If isNumber(m_e) Then
            If Not isSquareNumber(Val(BevoeklerungsgroesseText.Text)) Then
                MsgBox("Es sind nur Quadratzahlen erlaubt!")
            Else
                If Not enoughParties() Then
                    MsgBox("Es müssen mindestens 2 Parteien ausgewählt werden!")
                End If
                If Not BevoeklerungsgroesseText.Text Mod m_partiesChecked = 0 Then
                    MsgBox("Die Bevölkerung muss durch die Anzahl der Parteien teilbar sein, ohne Rest!")
                End If
                m_populationValue = BevoeklerungsgroesseText.Text
                MainWindow.m_populationValue = m_populationValue
                m_populationSet = True
                MainWindow.m_VariablesSet = True
            End If

        Else
            m_populationSet = False
            MsgBox("Es sind nur Zahlen erlaubt!")
        End If

        Me.Close()
    End Sub

    Private Function enoughParties() As Boolean
        m_partiesChecked = 0
        If m_blackChecked Then m_partiesChecked += 1
        If m_greyChecked Then m_partiesChecked += 1
        If m_brownChecked Then m_partiesChecked += 1
        If m_yellowChecked Then m_partiesChecked += 1
        If m_redChecked Then m_partiesChecked += 1
        If m_orangeChecked Then m_partiesChecked += 1
        If m_blueChecked Then m_partiesChecked += 1
        If m_greenChecked Then m_partiesChecked += 1
        If m_pinkChecked Then m_partiesChecked += 1

        If m_partiesChecked >= 2 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class