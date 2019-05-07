Namespace Democracy.Person
    Public Class Person
        'Variables
        Private m_PersonsPerRow As Integer
        Private m_Party As String
        Private m_xPos As Integer
        Private m_yPos As Integer
        Private m_neighbours(4) As String


        'Constructor
        Public Sub New(party As String, xPos As Integer, yPos As Integer, personsPerRow As Integer)
            m_Party = party
            m_xPos = xPos
            m_yPos = yPos
            m_PersonsPerRow = personsPerRow
        End Sub

        'Functions to get Persons stuff
        Public Function getParty()
            Return m_Party
        End Function

        Public Function getXPosition()
            Return m_xPos
        End Function

        Public Function getYPosition()
            Return m_yPos
        End Function

        Public Function pickRandomNeighbour() As String
            Dim randNeighbour = Int(3 - 0 + 1) * Rnd() + 0
            Return m_neighbours(randNeighbour)
        End Function

        ''' <summary>
        ''' Function to fill the array of the neighbours wit their positions in the array
        ''' </summary>
        Private Sub getNeighbours()
            m_neighbours(0) = findNeighbours(0, -1) 'Person on the top
            m_neighbours(1) = findNeighbours(1, 0)  'Person on the right
            m_neighbours(2) = findNeighbours(0, 1)  'Person on the bottom
            m_neighbours(3) = findNeighbours(-1, 0) 'Person on the left
        End Sub
        ''' <summary>
        ''' Gets the Position of the neighbour with the given Directions and lane
        ''' </summary>
        ''' <param name="xDirection">-1 means to the left, 1 to the right, 0 ignore</param>
        ''' <param name="yDirection">-1 means to the top, 1 to the bottom, 0 ignore</param>
        ''' <returns></returns>
        Private Function findNeighbours(xDirection As Integer, yDirection As Integer) As String
            Dim neighboursXPos As Integer
            Dim neighboursYPos As Integer
            'Case over the xPositon of the Person
            Select Case m_xPos
                'At the left side of the field
                Case 0
                    'Case over the xDirection
                    Select Case xDirection
                        Case -1
                            neighboursXPos = m_PersonsPerRow
                        Case 0
                            neighboursXPos = m_xPos
                        Case 1
                            neighboursXPos = m_xPos + xDirection
                    End Select
                'At the right side of the field
                Case m_PersonsPerRow
                    'Case over the xDirection
                    Select Case xDirection
                        Case -1
                            neighboursXPos = m_xPos + xDirection
                        Case 0
                            neighboursXPos = m_xPos
                        Case 1
                            neighboursXPos = 0
                    End Select
                    'Somewhere in between
                Case Else
                    'Case over the xDirection
                    Select Case xDirection
                        Case -1
                            neighboursXPos = m_xPos + xDirection
                        Case 0
                            neighboursXPos = m_xPos
                        Case 1
                            neighboursXPos = m_xPos + xDirection
                    End Select
            End Select
            'Case over the yPosition of the Position
            Select Case m_yPos
                'At the top of the field
                Case 0
                    'Case over the yDirection
                    Select Case yDirection
                        Case -1
                            neighboursXPos = m_PersonsPerRow
                        Case 0
                            neighboursYPos = m_yPos
                        Case 1
                            neighboursXPos = m_yPos + yDirection
                    End Select
                'At the bottom of the field
                Case m_PersonsPerRow
                    'Case over the yDirection
                    Select Case yDirection
                        Case -1
                            neighboursXPos = m_yPos + yDirection
                        Case 0
                            neighboursYPos = m_yPos
                        Case 1
                            neighboursXPos = 0
                    End Select
                    'Somewhere in between
                Case Else
                    'Case over the yDirection
                    Select Case yDirection
                        Case -1
                            neighboursXPos = m_yPos + yDirection
                        Case 0
                            neighboursYPos = m_yPos
                        Case 1
                            neighboursXPos = m_yPos + yDirection
                    End Select
            End Select

            Return neighboursXPos + "," + neighboursYPos
        End Function

    End Class
End Namespace
