Public Class Game
    Public Const StartX = 16 'Top left hand corner of the board
    Public Const StartY = 3  'Top left hand corner of the board
    Public Const IntervalX As SByte = 82
    Public Const IntervalY As SByte = 71

    Public Sub New()

        SetupPossible() 'Setup all possible locations
        Dim Player1 As New Player(True)         'Setup for Player1
        Dim Player2 As New Player(False)        'Setup for Player2

        'Play(Form1.CurrentPlayer)

    End Sub

    Public Sub SetupPossible()

    End Sub

End Class
