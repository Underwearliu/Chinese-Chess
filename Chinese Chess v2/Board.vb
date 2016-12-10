Public Class Board
    Public Const StartX = 16 'Top left hand corner of the board
    Public Const StartY = 3  'Top left hand corner of the board
    Public Const IntervalX As SByte = 82 'For Chesspieces gap
    Public Const IntervalY As SByte = 71 'For Chesspieces gap
    Public Const BoardX As Byte = 8
    Public Const BoardY As Byte = 9


    Private PossBox(BoardX, BoardY) As PictureBox
   

    Public Sub New()

        SetupPossible()

    End Sub

    Public Sub SetupPossible()
        Const PossX As Integer = IntervalX - 50
        Const PossY As Integer = IntervalY - 40
        Dim Image As New Bitmap(My.Resources.Target, New Size(PossX, PossY))
        For x = 0 To BoardX
            For y = 0 To BoardY
                PossBox(x, y) = New PictureBox
                PossBox(x, y).Parent = Form1
                PossBox(x, y).Image = Image
                PossBox(x, y).Size = PossBox(x, y).Image.Size()
                PossBox(x, y).Location = New Point(StartX + (x * IntervalX + 10), StartY + (y * IntervalY + 15))
                PossBox(x, y).BringToFront()
                PossBox(x, y).Visible = False
                AddHandler PossBox(x, y).Click, AddressOf possBox_Click
            Next
        Next
    End Sub


    Private Sub possBox_Click(sender As Object, e As EventArgs)

    End Sub

End Class
