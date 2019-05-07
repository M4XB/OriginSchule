Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ''' <summary>
    ''' Im String wird nach Rechenoperatoren geschaut. 
    ''' Wird einer gefunden, so wird er in die Liste für Operatoren eingetragen und sein Index in die Liste für die Indexe der Operatoren eingetragen
    ''' Der erste Wert (vor dem ersten Operator) wird in die Liste für Werte eingetragen
    ''' Alle Werte, die dann zwischen zwischen 2 Operatoren stehen, werden bestimmt und auch in die Liste für WErte eingetragen
    ''' Der letzte Wert (nach dem letzten Operator) wird auch in die Liste für Werte eingetragen
    ''' </summary>
    ''' <param name="input">Eingabe als String</param>
    Private Sub Calculate(input As String)
        Dim res As Integer
        Dim values As New List(Of Integer)
        Dim operators As New List(Of Char)
        Dim indexOfOperators As New List(Of Integer)
        indexOfOperators.Add(0)
        Dim countOfOperators As Integer
        For i = 0 To input.Length
            If i <> input.Length Then
                If input.Substring(i, 1) = "+" OrElse
                   input.Substring(i, 1) = "-" OrElse
                   input.Substring(i, 1) = "*" OrElse
                   input.Substring(i, 1) = "/" Then
                    countOfOperators += 1
                    indexOfOperators.Add(i)
                    operators.Add(input.Substring(i, 1))
                    If values.Count = 0 Then
                        If i = 1 Then
                            values.Add(input.Substring(0, 1))
                        Else
                            values.Add(input.Substring(0, i - 1))
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

        For Each op In operators
            If op = "*" Then

            ElseIf op = "/" Then

            End If
        Next

        For operatorIndex = 0 To operators.Count - 1
            If operators(operatorIndex) = "*" Then

            ElseIf operators(operatorIndex) = "/" Then

            End If
        Next

        OutputBox.Text = res
    End Sub

    Private Sub Button_Equals_Click(sender As Object, e As EventArgs) Handles Button_Equals.Click
        Dim input = inputBox.Text
        Calculate(input)
    End Sub
    'Addition
    Private Function Addition(firstValue As Double, seconValue As Double) As Double
        Return firstValue + seconValue
    End Function
    'Substraktion
    Private Function Substraction(firstValue As Double, seconValue As Double) As Double
        Return firstValue - seconValue
    End Function
    'Multiplikation
    Private Function Multiplication(firstValue As Double, seconValue As Double) As Double
        Return firstValue * seconValue
    End Function
    'Division
    Private Function Division(firstValue As Double, seconValue As Double) As Double
        Return firstValue / seconValue
    End Function

    Private Sub Modulo()

    End Sub

End Class
