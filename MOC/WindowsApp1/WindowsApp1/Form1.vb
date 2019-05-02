Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function Addition(firstValue As Double, seconValue As Double) As Double
        Return firstValue + seconValue
    End Function

    Private Function Substraction(firstValue As Double, seconValue As Double) As Double
        Return firstValue - seconValue
    End Function

    Private Function Multiplication(firstValue As Double, seconValue As Double) As Double
        Return firstValue * seconValue
    End Function

    Private Function Division(firstValue As Double, seconValue As Double) As Double
        Return firstValue / seconValue
    End Function

    Private Sub Modulo()

    End Sub

    Private Sub Button_Equals_Click(sender As Object, e As EventArgs) Handles Button_Equals.Click
        Dim input = inputBox.Text
        Calculate(input)
    End Sub

    Private Sub Calculate(input As String)
        Dim firstValue As Double?
        Dim secondValue As Double?
        Dim calcType As String = ""
        Dim indexOfCalcType As Integer?
        Dim res As Double?
        Dim intermimResult As Double?
        For i = 0 To input.Length
            If input.Substring(i, 1) = "+" OrElse
               input.Substring(i, 1) = "-" OrElse
               input.Substring(i, 1) = "*" OrElse
               input.Substring(i, 1) = "/" OrElse
               i = input.Length - 1 Then

                If intermimResult.HasValue Then
                    indexOfCalcType = i - 1
                    calcType = input.Substring(indexOfCalcType, 1)
                End If

                If indexOfCalcType.HasValue AndAlso firstValue.HasValue Then
                    secondValue = input.Substring(indexOfCalcType + 1, i - indexOfCalcType)
                End If

                If Not firstValue.HasValue Then
                    firstValue = input.Substring(0, i)
                    indexOfCalcType = i
                    calcType = input.Substring(i, 1)
                End If
            End If

            If firstValue.HasValue AndAlso secondValue.HasValue Then
                Select Case calcType
                    Case "+"
                        intermimResult = Addition(firstValue, secondValue)
                    Case "-"
                        intermimResult = Substraction(firstValue, secondValue)
                    Case "*"
                        intermimResult = Multiplication(firstValue, secondValue)
                    Case "/"
                        intermimResult = Division(firstValue, secondValue)
                End Select
            End If
            If firstValue.HasValue AndAlso secondValue.HasValue Then
                If i = input.Length - 1 Then
                    res = intermimResult
                    Exit For
                Else
                    firstValue = intermimResult
                    secondValue = Nothing
                End If
            End If

        Next
        OutputBox.Text = res
    End Sub
End Class
