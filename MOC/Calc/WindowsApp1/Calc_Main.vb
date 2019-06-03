Public Class Calc_Main
    'Variables
    Dim values As New List(Of Double)
    Dim operators As New List(Of Char)

    ''' <summary>
    ''' Erzeugt das Fenster
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    ''' <summary>
    ''' Wenn ein Term angegeben wird, wird dieser zur Berechnung weiter gegeben, ansonsten wird eine Fehlermeldung geworfen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Equals_Click(sender As Object, e As EventArgs) Handles Button_Equals.Click
        If DoubleOperators(inputBox.Text) Then
            MsgBox("Es gibt 2 Operator, die direkt aneinander stehen!")
        ElseIf Not inputBox.Text = "" Then
            Main(inputBox.Text)
        Else
            MsgBox("Es wurde kein Term zur Berechnung angegeben!")
        End If
    End Sub

    ''' <summary>
    ''' Setzt alle Listen, sowie die Input und Output Box auf Nothing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        operators = New List(Of Char)
        values = New List(Of Double)
        inputBox.Text = Nothing
        OutputBox.Text = Nothing
    End Sub

    ''' <summary>
    ''' Setzt den Zwischenspeicher zurück
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_ClearMemory_Click(sender As Object, e As EventArgs) Handles Button_ClearMemory.Click
        MemoryBox.Text = Nothing
    End Sub

    ''' <summary>
    ''' Schreibt das Ergebnis der letzten Berechnung in die InputBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_PlaceResultInInput_Click(sender As Object, e As EventArgs) Handles Button_PlaceResultInInput.Click
        Dim firstIndexOfResult = MemoryBox.Text.IndexOf("=") + 2
        Dim lengthOfResult = MemoryBox.Text.IndexOf("#") - firstIndexOfResult
        inputBox.Text += MemoryBox.Text.Substring(firstIndexOfResult, lengthOfResult)
    End Sub

    ''' <summary>
    ''' Die Hauptmethode, die das Berechnen des übergebenen Strings ausführt
    ''' Das Ergebnis wird dann in der Output Box ausgegeben
    ''' Die beiden Listen der Werte und der Operatoren werden auch zurück gesetzt
    ''' </summary>
    ''' <param name="input">Term, der berechnet werden soll</param>
    Private Sub Main(input As String)
        Dim numberofBrackets = 0
        Dim openBracketIndex = New List(Of Integer)
        Dim closedBracketIndex = New List(Of Integer)
        getBracketIndex(input, numberofBrackets, openBracketIndex, closedBracketIndex)
        If Not numberofBrackets Mod 2 = 0 Then
            MsgBox("Es gibt noch offene Klammern!")
        End If
        If numberofBrackets = 0 Then
            Calculate(input)
        Else
            Dim innerBracket = numberofBrackets / 2
            Dim innerBracketsExist = innerBrackets(input)
            'Berechnet die Klammern, die ineinander sind
            While innerBracketsExist = True
                openBracketIndex = New List(Of Integer)
                closedBracketIndex = New List(Of Integer)
                getBracketIndex(input, 0, openBracketIndex, closedBracketIndex)
                Dim nextHighestClosedBracket = GetnextHighestClosedBracket(openBracketIndex.Last, closedBracketIndex)
                Dim buffer = Calculate(input.Substring(openBracketIndex.Last + 1, nextHighestClosedBracket - openBracketIndex.Last - 1))
                input = ReplaceBracketWithValue(input, openBracketIndex.Last, nextHighestClosedBracket, buffer)
                innerBracketsExist = innerBrackets(input)
            End While
            'Berechnet die Klammern, wenn die Kammern nur hintereinander sind
            For index = 0 To innerBracket - 1
                openBracketIndex = New List(Of Integer)
                closedBracketIndex = New List(Of Integer)
                getBracketIndex(input, 0, openBracketIndex, closedBracketIndex)
                Dim buffer As Double
                If openBracketIndex.Count = 1 Then
                    buffer = Calculate(input.Substring(openBracketIndex(0) + 1, closedBracketIndex(0) - openBracketIndex(0) - 1))
                ElseIf openBracketIndex.Count = 0 Then
                    Exit For
                Else
                    buffer = Calculate(input.Substring(openBracketIndex(index) + 1, closedBracketIndex(index) - openBracketIndex(index) - 1))
                End If
                If openBracketIndex.Count = 1 Then
                    input = ReplaceBracketWithValue(input, openBracketIndex(0), closedBracketIndex(0), buffer)
                ElseIf openBracketIndex.Count = 0 Then
                    Exit For
                Else
                    input = ReplaceBracketWithValue(input, openBracketIndex(index), closedBracketIndex(index), buffer)
                End If
            Next
        End If
        Dim result = Calculate(input).ToString
        OutputBox.Text = result
        MemoryBox.Text = input & " = " & result & "#" & vbCrLf + MemoryBox.Text
        operators = New List(Of Char)
        values = New List(Of Double)
    End Sub

    ''' <summary>
    ''' Im String wird nach Rechenoperatoren geschaut. 
    ''' Wird einer gefunden, so wird er in die Liste für Operatoren eingetragen und sein Index in die Liste für die Indexe der Operatoren eingetragen
    ''' Der erste Wert (vor dem ersten Operator) wird in die Liste für Werte eingetragen
    ''' Alle Werte, die dann zwischen zwischen 2 Operatoren stehen, werden bestimmt und auch in die Liste für Werte eingetragen
    ''' Der letzte Wert (nach dem letzten Operator) wird auch in die Liste für Werte eingetragen
    ''' </summary>
    ''' <param name="input">Eingabe als String</param>
    Private Function Calculate(input As String) As Double
        operators = New List(Of Char)
        values = New List(Of Double)
        Dim indexOfOperators As New List(Of Integer)
        indexOfOperators.Add(0)
        Dim countOfOperators As Integer
        For i = 0 To input.Length
            If i <> input.Length Then
                If input.Substring(i, 1) = "+" OrElse
                   input.Substring(i, 1) = "-" OrElse
                   input.Substring(i, 1) = "*" OrElse
                   input.Substring(i, 1) = "/" OrElse
                   input.Substring(i, 1) = "^" Then
                    countOfOperators += 1
                    indexOfOperators.Add(i)
                    operators.Add(input.Substring(i, 1))
                    If values.Count = 0 Then
                        If i = 1 Then
                            values.Add(input.Substring(0, 1))
                        Else
                            values.Add(input.Substring(0, i))
                        End If
                    Else
                        'firstIndexOfValue: der hinzugefügte Index im letzten Durchlauf +1
                        'lengthOfValue: Index des gerade hinzugefügten Index - den hinzugefügten Index aus dem letzten Durchlauf
                        Dim firstIndexOfValue = indexOfOperators(countOfOperators - 1) + 1
                        Dim lengthofValue = indexOfOperators(countOfOperators) - firstIndexOfValue
                        values.Add(input.Substring(firstIndexOfValue, lengthofValue))
                    End If
                End If
            Else
                values.Add(input.Substring(indexOfOperators.Last + 1, (i - indexOfOperators.Last) - 1))
            End If
        Next
        'Für die Exponenten wird hier nach Exponent Operatoren gesucht und die jeweiligen Exponenten gezogen
        For operatorIndex = 0 To operators.Count - 1
            If getNumberofExponentOperators() = 0 Then Exit For
            If operators.Count = 0 Then Exit For
            If operators.Count = 1 Then operatorIndex = 0
            If operators(operatorIndex) = "^" Then
                values(operatorIndex) = Exponent(values(operatorIndex), values(operatorIndex + 1))
                RefactoringLists(operatorIndex)
            End If
        Next
        'Für die Punkt vor Strich Rechnung wird hier nach den Punkt Operatoren gesucht und die jeweiligen Zahlen miteinander multipliziert bzw. dividiert
        For operatorIndex = 0 To operators.Count - 1
            If getNumberOfDotOperators() = 0 Then Exit For
            If operators.Count = 0 Then Exit For
            If operators.Count = 1 Then operatorIndex = 0
            If operatorIndex >= operators.Count Then operatorIndex = operators.Count - 2
            If operators(operatorIndex) = "*" Then
                values(operatorIndex) = Multiplication(values(operatorIndex), values(operatorIndex + 1))
                RefactoringLists(operatorIndex)
            ElseIf operators(operatorIndex) = "/" Then
                values(operatorIndex) = Division(values(operatorIndex), values(operatorIndex + 1))
                RefactoringLists(operatorIndex)
            End If
        Next
        'Hier wird jetzt der Term von Links nach Rechts berechnet, da jetzt nurnoch Strich Operatoren (+ und -) vorhanden sind
        For operatorIndex = 0 To operators.Count - 1
            If getNumberOfDashOperators() = 0 Then Exit For
            If operators.Count = 0 Then Exit For
            If operators.Count = 1 Then operatorIndex = 0
            If operatorIndex >= operators.Count Then operatorIndex = operators.Count - 2
            If operators(operatorIndex) = "+" Then
                values(operatorIndex) = Addition(values(operatorIndex), values(operatorIndex + 1))
                RefactoringLists(operatorIndex)
            ElseIf operators(operatorIndex) = "-" Then
                values(operatorIndex) = Substraction(values(operatorIndex), values(operatorIndex + 1))
                RefactoringLists(operatorIndex)
            End If
        Next

        'Gibt das Ergebnis in der OutputBox aus
        Return values(0)
    End Function

    ''' <summary>
    ''' Diese Funktion wird nach dem Addieren, Substrahieren, Multiplizieren und nach dem Dividieren aufgerufen, 
    ''' um die Liste der Werte und der Operatoren zu kürzen
    ''' </summary>
    ''' <param name="operatorIndex">Index des Operators</param>
    Private Sub RefactoringLists(operatorIndex As Integer)
        Dim bufferoperator = operatorIndex
        While operatorIndex + 2 < values.Count
            values(operatorIndex + 1) = values(operatorIndex + 2)
            operatorIndex += 1
        End While
        values.RemoveAt(values.Count - 1)
        While bufferoperator + 1 < operators.Count
            operators(bufferoperator) = operators(bufferoperator + 1)
            bufferoperator += 1
        End While
        operators.RemoveAt(operators.Count - 1)
    End Sub

    ''' <summary>
    ''' Ermittelt die Anzahl der Exponent Operatoren (^) in der Eingabe für den Abbruch der For Schleife für die Exponent Operatoren
    ''' </summary>
    ''' <returns></returns>
    Private Function getNumberofExponentOperators() As Integer
        Dim res = 0
        For Each element In operators
            If element = "^" Then res = res + 1
        Next
        Return res
    End Function


    ''' <summary>
    ''' Ermittelt die Anzahl der Punkt Operatoren (* und /) in der Eingabe für den Abbruch der For Schleife für die Punkt Operatoren
    ''' </summary>
    ''' <returns></returns>
    Private Function getNumberOfDotOperators() As Integer
        Dim res = 0
        For Each element In operators
            If element = "*" OrElse element = "/" Then res = res + 1
        Next
        Return res
    End Function

    ''' <summary>
    ''' Ermittelt die Anzahl der Strich (+ und -) Operatoren in der Eingabe für den Abbruch der For Schleife für die Strich Operatoren
    ''' </summary>
    ''' <returns></returns>
    Private Function getNumberOfDashOperators() As Integer
        Dim res = 0
        For Each element In operators
            If element = "+" OrElse element = "-" Then res = res + 1
        Next
        Return res
    End Function

    ''' <summary>
    ''' Die Funktion ermittelt, ob es Klammern in Klammern gibt
    ''' Bsp.: (5-(1+3*2)+5)*2
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    Private Function innerBrackets(input As String) As Boolean
        Dim firstOpenBracket = input.IndexOf("(")
        Dim buffedInput = input.Remove(firstOpenBracket, 1)
        Dim firstClosedBracket = buffedInput.IndexOf(")")
        Dim secondOpenBracket = buffedInput.IndexOf("(")
        If secondOpenBracket < 0 Then
            Return False
        ElseIf secondOpenBracket > firstClosedBracket Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Die Methode ermittelt die Indexe der öffnenden und schließenden Klammer und die Anzahl an Klammern im übergebenen String
    ''' </summary>
    ''' <param name="input">Input</param>
    ''' <param name="numberofBrackets">Anzahl der Klammern</param>
    ''' <param name="openBracketIndex">Liste mit den Indexen der geöffneten Klammern</param>
    ''' <param name="closedBracketIndex">Liste mit den Indexen der geschlossenen Klammern</param>
    Private Sub getBracketIndex(input As String, ByRef numberofBrackets As Integer, ByRef openBracketIndex As List(Of Integer), ByRef closedBracketIndex As List(Of Integer))
        For index = 0 To input.Length - 1
            If input.Substring(index, 1) = "(" OrElse input.Substring(index, 1) = ")" Then
                numberofBrackets += 1
                If input.Substring(index, 1) = "(" Then
                    openBracketIndex.Add(index)
                ElseIf input.Substring(index, 1) = ")" Then
                    closedBracketIndex.Add(index)
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' Die Funktion ersetzt den durch die Indexe festgelegten Bereich im String durch den Wert und gibt das Ergebnis dann zurück
    ''' </summary>
    ''' <param name="input">Eingabe</param>
    ''' <param name="startIndex">Geöffnete Klammer</param>
    ''' <param name="endIndex">geschlossene Klammer</param>
    ''' <param name="value">Wert</param>
    ''' <returns></returns>
    Private Function ReplaceBracketWithValue(input As String, startIndex As Integer, endIndex As Integer, value As Double) As String
        Dim valueAsArray = value.ToString.ToCharArray
        Dim inputAsArray = input.ToCharArray

        For index = 0 To valueAsArray.Count - 1
            inputAsArray(startIndex + index) = valueAsArray(index)
        Next
        Dim changedInput As New String(inputAsArray)
        If valueAsArray.Count = 1 Then
            Dim finalChange = changedInput.Remove(startIndex + 1, endIndex - startIndex)
            Return finalChange
        Else
            Dim finalChange = changedInput.Remove(startIndex + valueAsArray.Count, endIndex - startIndex - 1)
            Return finalChange
        End If
    End Function

    ''' <summary>
    ''' Ermittelt, ob in dem übergebenen String zwei Operator (+,-,*,/,^) direkt aneinander stehen
    ''' Ist dies der Fall gibt die Methode ein True zurück, ansonsten ein False
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    Private Function DoubleOperators(input As String) As Boolean
        Dim bufferChar = input.First
        For index = 1 To input.Length - 1
            If (input.Substring(index, 1) = "+" OrElse
                input.Substring(index, 1) = "-" OrElse
                input.Substring(index, 1) = "*" OrElse
                input.Substring(index, 1) = "/" OrElse
                input.Substring(index, 1) = "^") AndAlso (
                bufferChar = "+" OrElse
                bufferChar = "-" OrElse
                bufferChar = "*" OrElse
                bufferChar = "/" OrElse
                bufferChar = "^") Then
                Return True
            Else
                bufferChar = input.Substring(index, 1)
            End If
        Next
        Return False
    End Function

    Private Function GetnextHighestClosedBracket(opendBrackedIndex As Integer, closedBracketList As List(Of Integer)) As Integer
        For index = 0 To closedBracketList.Count - 1
            If closedBracketList(index) > opendBrackedIndex Then Return closedBracketList(index)
        Next
    End Function

    'Addition
    Private Function Addition(firstValue As Double, secondValue As Double) As Double
        Return firstValue + secondValue
    End Function

    'Substraktion
    Private Function Substraction(firstValue As Double, secondValue As Double) As Double
        Return firstValue - secondValue
    End Function

    'Multiplikation
    Private Function Multiplication(firstValue As Double, secondValue As Double) As Double
        Return firstValue * secondValue
    End Function

    'Division
    Private Function Division(firstValue As Double, secondValue As Double) As Double
        Return firstValue / secondValue
    End Function

    'Exponent
    Private Function Exponent(firstValue As Double, secondValue As Double) As Double
        Return firstValue ^ secondValue
    End Function

End Class