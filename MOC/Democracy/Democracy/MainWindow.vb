Imports Democracy.Democracy.Person
Imports System.Math

Public Class MainWindow
    'Variables
    Public m_PartyNumber As Integer
    Public m_Delay As Integer
    Public m_OutputAfterRuns As Integer
    Public m_VariablesSet As Boolean
    Public m_ListofPartys As New List(Of String)
    'Variables from custom Preset
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
    Public m_PartPerParty As Integer
    Dim m_Row As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub inizialise()
        m_Row = Sqrt(m_populationValue)

        m_ListofPartys.Clear()
        Dim m_Field(m_Row, m_Row) As Person
        If m_blackChecked Then m_ListofPartys.Add("Black")
        If m_greyChecked Then m_ListofPartys.Add("Grey")
        If m_brownChecked Then m_ListofPartys.Add("Brown")
        If m_yellowChecked Then m_ListofPartys.Add("Yellow")
        If m_redChecked Then m_ListofPartys.Add("Red")
        If m_orangeChecked Then m_ListofPartys.Add("Orange")
        If m_blueChecked Then m_ListofPartys.Add("Blue")
        If m_greenChecked Then m_ListofPartys.Add("Green")
        If m_pinkChecked Then m_ListofPartys.Add("Pink")
        m_PartPerParty = m_populationValue / m_ListofPartys.Count
        Dim rows = Math.Sqrt(m_populationValue)
        Dim counter As Integer = 0
        For indexX = 0 To rows - 1
            For indexY = 0 To rows - 1
                If counter >= 0 AndAlso counter < m_PartPerParty Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(0), indexX, indexY, rows)
                ElseIf counter >= m_PartPerParty AndAlso counter < m_PartPerParty * 2 Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(1), indexX, indexY, rows)
                ElseIf counter >= m_PartPerParty * 2 AndAlso counter < m_PartPerParty * 3 Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(2), indexX, indexY, rows)
                ElseIf counter >= m_PartPerParty * 3 AndAlso counter < m_PartPerParty * 4 Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(3), indexX, indexY, rows)
                ElseIf counter >= m_PartPerParty * 4 AndAlso counter < m_PartPerParty * 5 Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(4), indexX, indexY, rows)
                ElseIf counter >= m_PartPerParty * 5 AndAlso counter < m_PartPerParty * 6 Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(5), indexX, indexY, rows)
                ElseIf counter >= m_PartPerParty * 6 AndAlso counter < m_PartPerParty * 7 Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(6), indexX, indexY, rows)
                ElseIf counter >= m_PartPerParty * 7 AndAlso counter < m_PartPerParty * 8 Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(7), indexX, indexY, rows)
                ElseIf counter >= m_PartPerParty * 8 AndAlso counter < m_PartPerParty * 9 Then
                    m_Field(indexX, indexY) = New Person(m_ListofPartys(8), indexX, indexY, rows)
                End If

                counter += 1
            Next

        Next
        LogStats(m_Field)
    End Sub

    Private Sub Preset1Button_Click(sender As Object, e As EventArgs) Handles Preset1Button.Click
        m_populationValue = 400
        m_PartyNumber = 2
        m_Delay = 500
        m_OutputAfterRuns = 10000
        m_blackChecked = True
        m_greenChecked = True

        m_VariablesSet = True
        MsgBox("Preset 1:

        Bevölkerungsgröße: 400
        Anzahl der Parteien: 2
        Partei 1: Black
        Partei 2: Green")
    End Sub

    Private Sub Preset2Button_Click(sender As Object, e As EventArgs) Handles Preset2Button.Click
        m_populationValue = 900
        m_PartyNumber = 3
        m_Delay = 500
        m_OutputAfterRuns = 10000
        m_blackChecked = True
        m_redChecked = True
        m_greenChecked = True
        m_VariablesSet = True
        MsgBox("Preset 2:

        Bevölkerungsgröße: 900
        Anzahl der Parteien: 3
        Partei 1: Black
        Partei 2: Red
        Partei 3: Green")
    End Sub

    Private Sub CustomPresetButton_Click(sender As Object, e As EventArgs) Handles CustomPresetButton.Click
        Dim custom As New customPreset
        custom.Show()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If Not m_VariablesSet Then
            MsgBox("Bitte wähle ein Preset aus, oder erstelle selber eins")
        Else
            inizialise()
        End If
    End Sub

    Private Sub LogStats(field(,) As Person)
        Dim absolute(m_ListofPartys.Count) As Integer
        Dim relative(m_ListofPartys.Count) As Double

        For indexX = 0 To m_Row - 1
            For indexY = 0 To m_Row - 1
                Dim partyIndex = getPartyIndex(field(indexX, indexY).getParty)
                absolute(partyIndex) += 1
            Next
        Next

        For index = 0 To absolute.Count - 2
            relative(index) = (100 / m_populationValue * absolute(index))
            outputStats.Text += m_ListofPartys(index) & ": " & absolute(index) & ", " & relative(index).ToString("0.00") & "%" & vbCrLf
        Next
        outputStats.Show()
    End Sub

    Private Function getPartyIndex(partyName As String) As Integer
        Dim index = 0
        For partyIndex = 0 To m_ListofPartys.Count - 1
            If m_ListofPartys(partyIndex) = partyName Then
                index = partyIndex
            End If
        Next
        Return index
    End Function

    Private Sub Output(field(,) As Person)
        Dim outputGridString = ""
        For indexX = 0 To m_Row
            For indexY = 0 To m_Row

            Next
        Next
    End Sub

End Class