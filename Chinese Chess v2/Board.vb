Public Class Board
    Public Const StartX = 16 'Top left hand corner of the board
    Public Const StartY = 3  'Top left hand corner of the board
    Public Const IntervalX As SByte = 82
    Public Const IntervalY As SByte = 71
    Public Const BoardX As Byte = 8
    Public Const BoardY As Byte = 9

    Private PossBox As New PictureBox

    Public Sub New()

        SetupPossible()

    End Sub

    Public Sub SetupPossible()
        'ask harry for magic
        For x = 0 To BoardX
            For y = 0 To BoardY
                PossBox.Parent = Form1
                PossBox.Width = IntervalX - 22
                PossBox.Height = IntervalY - 11
                PossBox.Image = New Bitmap(My.Resources.Target, New Size(PossBox.Size))
                PossBox.Location = New Point(StartX + (x * IntervalX), StartY + (y * IntervalY))
                PossBox.Visible = True
                PossBox.BringToFront()
                PossBox.AllowDrop = True
            Next
        Next
    End Sub
End Class
