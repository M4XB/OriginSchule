Public Class Calc_ITS

    'Variables
    Dim mouseOffset As Point
    Dim uriU As Double
    Dim uriR As Double
    Dim uriI As Double
    Dim uriUSet As Boolean
    Dim uriRSet As Boolean
    Dim uriISet As Boolean

    Dim puiP As Double
    Dim puiU As Double
    Dim puiI As Double
    Dim puiPSet As Boolean
    Dim puiUSet As Boolean
    Dim puiISet As Boolean

    Dim binaryToSi As Boolean = True


    ''' <summary>
    ''' Erzeugt das Fenster
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Calc_ITS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Schließt die App
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LabelClose_Click(sender As Object, e As EventArgs) Handles LabelClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Minimmiert das Fenster
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LabelMinimize_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    ''' <summary>
    ''' Wendet die URI Regln an
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Calculate_URI_Click(sender As Object, e As EventArgs) Handles Button_Calculate_URI.Click
        If CountEmptyBoxesUri() Then Exit Sub
        If uriUSet AndAlso uriRSet Then
            inputBox_URI_I.Text = uriU / uriR
        ElseIf uriUSet AndAlso uriISet Then
            inputBox_URI_R.Text = uriU / uriI
        ElseIf uriRSet AndAlso uriISet Then
            inputBox_URI_U.Text = uriR * uriI
        End If
    End Sub

    ''' <summary>
    ''' Löscht alle Eingaben in den Feldern für URI
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_URI_Delete_Click(sender As Object, e As EventArgs) Handles Button_URI_Delete.Click
        inputBox_URI_U.Text = Nothing
        inputBox_URI_R.Text = Nothing
        inputBox_URI_I.Text = Nothing
        uriUSet = False
        uriRSet = False
        uriISet = False
    End Sub

    ''' <summary>
    ''' Wendet die PUI Regln an
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Calculate_PUI_Click(sender As Object, e As EventArgs) Handles Button_Calculate_PUI.Click
        If CountEmptyBoxesPUI() Then Exit Sub
        If puiPSet AndAlso puiUSet Then
            inputBox_PUI_I.Text = puiP / puiU
        ElseIf puiPSet AndAlso puiISet Then
            inputBox_PUI_U.Text = puiP / puiI
        ElseIf puiUSet AndAlso puiISet Then
            inputBox_PUI_P.Text = puiU * puiI
        End If
    End Sub

    ''' <summary>
    ''' Löscht alle Eingaben in den Feldern für PUI
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_PUI_Delete_Click(sender As Object, e As EventArgs) Handles Button_PUI_Delete.Click
        inputBox_PUI_P.Text = Nothing
        inputBox_PUI_U.Text = Nothing
        inputBox_PUI_I.Text = Nothing
        puiPSet = False
        puiUSet = False
        puiISet = False
    End Sub

    ''' <summary>
    ''' Zählt die nicht gefüllten Boxen der PUI Felder
    ''' </summary>
    ''' <returns></returns>
    Private Function CountEmptyBoxesUri() As Boolean
        Dim count = 0
        If inputBox_URI_U.Text = Nothing Then
            count += 1
        Else
            uriU = inputBox_URI_U.Text
            uriUSet = True
        End If
        If inputBox_URI_R.Text = Nothing Then
            count += 1
        Else
            uriR = inputBox_URI_R.Text
            uriRSet = True
        End If
        If inputBox_URI_I.Text = Nothing Then
            count += 1
        Else
            uriI = inputBox_URI_I.Text
            uriISet = True
        End If
        If count = 2 Then
            Return True
            MsgBox("Es müssen 2 Werte angegeben sein")
        ElseIf count = 3 Then
            Return True
            MsgBox("Es sind bereits 3 Werte angegeben")
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Zählt die nicht gefüllten Boxen der PUI Felder
    ''' </summary>
    ''' <returns></returns>
    Private Function CountEmptyBoxesPUI() As Boolean
        Dim count = 0
        If inputBox_PUI_P.Text = Nothing Then
            count += 1
        Else
            puiP = inputBox_PUI_P.Text
            puiPSet = True
        End If
        If inputBox_PUI_U.Text = Nothing Then
            count += 1
        Else
            puiU = inputBox_PUI_U.Text
            puiUSet = True
        End If
        If inputBox_PUI_I.Text = Nothing Then
            count += 1
        Else
            puiI = inputBox_PUI_I.Text
            puiISet = True
        End If
        If count = 2 Then
            Return True
            MsgBox("Es müssen 2 Werte angegeben sein!")
        ElseIf count = 3 Then
            Return True
            MsgBox("Es sind bereits 3 Werte angegeben!")
        Else
            Return False
        End If
    End Function

    Private Sub Button_Change_Direction_Click(sender As Object, e As EventArgs) Handles Button_Change_Direction.Click
        If Button_Change_Direction.Text = ">" Then
            Button_Change_Direction.Text = "<"
            binaryToSi = False
        ElseIf Button_Change_Direction.Text = "<" Then
            Button_Change_Direction.Text = ">"
            binaryToSi = True
        End If
    End Sub

    Private Sub Button_Delete_Präfix_Click(sender As Object, e As EventArgs) Handles Button_Delete_Präfix.Click
        InputBox_BinärPräfix.Text = Nothing
        InputBox_SiPräfix.Text = Nothing
    End Sub

    Private Sub Button_Calculate_Präfix_Click(sender As Object, e As EventArgs) Handles Button_Calculate_Präfix.Click
        If binaryToSi Then
            InputBox_SiPräfix.Text = InputBox_BinärPräfix.Text * 1.024
        Else
            InputBox_BinärPräfix.Text = InputBox_SiPräfix.Text / 1.024
        End If
    End Sub
End Class