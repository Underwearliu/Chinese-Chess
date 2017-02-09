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

    Public Sub New(ByVal Value As Byte, ByVal ChessSide As Boolean, ByRef ChessX As Byte, ByRef Chessy As Byte)
        Select Case Value
            Case 1 'Soldier
                If ChessSide Then
                    If Chessy <= 5 Then
                        ShowPossible()
                    End If
                End If
            Case 2 'General
            Case 3 'Chariot
            Case 4 'Horse
            Case 5 'Elephant
            Case 6 'Advisor
            Case 7 'Cannon
        End Select
    End Sub

    Private Sub ShowPossible(ByVal Xs As Byte, ByVal Ys As Byte)
       Board.PossBox(x,y).
    End Sub

End Class
