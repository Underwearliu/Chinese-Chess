Public Class PickUpChess

    Public XPoss(17) As Byte
    Public YPoss(17) As Byte
    Public PossCounter As Byte



    Public Sub New(ByVal Value As Byte, ByVal ChessSide As Boolean, ByRef ChessX As Byte, ByRef ChessY As Byte)
        PossCounter = 0
        Form1.ChessUp = False
        CalculatePossibles(Value, ChessSide, ChessX, ChessY)
        
        If PossCounter = 1 Then
            Form1.StatusLabel.Text = ("There is " & PossCounter & " possible move.")
        Else
            Form1.StatusLabel.Text = ("There are " & PossCounter & " possible moves.")
        End If


        For a = 1 To PossCounter
            MakePossVisible(XPoss(a), YPoss(a))
        Next
        Form1.ChessUp = True


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
                If ChessX >= 3 And ChessX <= 4 Then
                    If IsOwnChessThere(ChessSide, ChessX + 1, ChessY) = False Then
                        PossCounter += 1
                        XPoss(PossCounter) = ChessX + 1
                        YPoss(PossCounter) = ChessY
                    End If
                End If
                If ChessX >= 4 And ChessX <= 5 Then
                    PossCounter += 1
                    XPoss(PossCounter) = ChessX - 1
                    YPoss(PossCounter) = ChessY
                End If
                If ChessSide = True Then
                    'If 
                    'End If
                Else

                End If
            Case 3 'Chariot
            Case 4 'Horse
            Case 5 'Elephant
            Case 6 'Advisor
            Case 7 'Cannon
        End Select

    End Sub
    Public Function IsOwnChessThere(ByRef Side As Boolean, ByVal PossChessX As Byte, ByVal PossChessY As Byte)
        'If ChessPiece.ID Then
        '    Return False
        'End If
        'Return True
        Return False
    End Function

    Private Sub MakePossVisible(ByVal PossX As Byte, ByVal PossY As Byte)
        Board.PossBox(PossX, PossY).Visible = True
    End Sub

End Class
