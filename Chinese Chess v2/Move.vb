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

    Dim XPoss(17) As Byte
    Dim YPoss(17) As Byte
    Dim PossCounter As Byte

    Public Sub New(ByVal Value As Byte, ByVal ChessSide As Boolean, ByRef ChessX As Byte, ByRef ChessY As Byte)
        PossCounter = 0
        CalculatePossibles(Value, ChessSide, ChessX, ChessY)
        MsgBox("There are {0} possible moves.", PossCounter)
        For a = 0 To PossCounter
            MakePossVisible(XPoss(a), YPoss(a))
        Next
        System.Threading.Thread.Sleep(2000) 'Testing Purposes
        For b = 0 To PossCounter
            MakePossInvisible(XPoss(b), YPoss(b))
        Next
    End Sub

    Private Sub CalculatePossibles(ByVal Value As Byte, ByVal ChessSide As Boolean, ByRef ChessX As Byte, ByRef ChessY As Byte)
        Select Case Value
            Case 1 'Soldier
                'Before River
                If ChessSide = True And ChessY < 9 Then
                    PossCounter += 1
                    XPoss(PossCounter) = ChessX
                    YPoss(PossCounter) = ChessY + 1
                End If
                If ChessSide = False And ChessY > 0 Then
                    PossCounter += 1
                    XPoss(PossCounter) = ChessX
                    YPoss(PossCounter) = ChessY - 1
                End If
                If (ChessSide = True And ChessY >= 5) Or (ChessSide = False And ChessY <= 4) Then
                    'Passed River               
                    If ChessX <> 0 Then
                        'Move Left
                        PossCounter += 1
                        XPoss(PossCounter) = ChessX - 1
                        YPoss(PossCounter) = ChessY
                    ElseIf ChessX <> 9 Then
                        'Move Right
                        PossCounter += 1
                        XPoss(PossCounter) = ChessX + 1
                        YPoss(PossCounter) = ChessY
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

    Private Sub MakePossVisible(ByVal PossX As Byte, ByVal PossY As Byte)
        Board.PossBox(PossX, PossY).Visible = True
    End Sub

    Private Sub MakePossInvisible(ByVal PossX As Byte, ByVal PossY As Byte)
        Board.PossBox(PossX, PossY).Visible = False
    End Sub
End Class
