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

    Public Sub New()

    End Sub

    Public Sub MakePossInvisible(ByVal PossX As Byte, ByVal PossY As Byte)
        Board.PossBox(PossX, PossY).Visible = False
    End Sub

    Private Sub possBox_Click(sender As Object, e As EventArgs)
        'If ChessPiece( = Form1.CurrentPlayer And Form1.ChessUp = True Then
        '    Selected = True
        '    ChessUp = New PickUpChess(ChessValue, Side, ChessX, ChessY)
        '    'MsgBox(ChessValue) 'Testing Purposes
        '    Selected = False
        '    Form1.CurrentPlayer = Not Form1.CurrentPlayer
        'End If
        'Selected = False
        'Form1.CurrentPlayer = Not Form1.CurrentPlayer
        'Form1.ChessUp = False
        'For b = 1 To PossCounter
        '    MakePossInvisible(XPoss(b), YPoss(b))
        'Next
        '-----To be done during Easter-----
    End Sub
End Class
