Public Class Move

    '1 Soldier
    '2 General
    '3 Chariot
    '4 Horse
    '5 Elephant
    '6 Advisor
    '7 Cannon
    'True = Black
    'False = Red

    Dim XList As New List(Of Byte)
    Dim YList As New List(Of Byte)

    Public Sub New(ByVal Value As Byte, ByVal ChessSide As Boolean, ByRef ChessX As Byte, ByRef ChessY As Byte)
        InsertPossibles(Value, ChessSide, ChessX, ChessY)
    End Sub

    Private Sub InsertPossibles(ByVal Value As Byte, ByVal ChessSide As Boolean, ByRef ChessX As Byte, ByRef ChessY As Byte)
        Select Case Value
            Case 1 'Soldier
                If ChessSide = True Then
                    If ChessY >= 3 And ChessY < 9 Then
                        MakePossVisible(ChessX, ChessY + 1)
                    End If
                    If ChessY >= 5 And ChessX > 0 Then
                        MakePossVisible(ChessX + 1, ChessY)
                    End If
                    If ChessY >= 5 And ChessX < 9 Then
                        MakePossVisible(ChessX - 1, ChessY)
                    End If
                Else

                End If
            Case 2 'General
            Case 3 'Chariot
            Case 4 'Horse
            Case 5 'Elephant
            Case 6 'Advisor
            Case 7 'Cannon
        End Select

    End Sub

    Private Sub MakePossVisible(ByVal PossX As Byte, ByVal PossY As Byte)
        Board.PossBox(PossX, PossY).Visible = True
    End Sub
End Class
