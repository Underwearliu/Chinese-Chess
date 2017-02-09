Public Class ChessPiece

    Private ChessValue As Byte
    Private PicBox As New PictureBox
    Private ChessX As Integer
    Private ChessY As Integer
    Private Side As Boolean '(True = Black; False = Red)
    Private Alive As Boolean
    Private ChessMove As Move

    Const PicBoxWidth As Integer = Board.IntervalX - 22
    Const PicBoxHeight As Integer = Board.IntervalY - 11


    Public Sub New(ByVal Value As Byte, ByVal Icon As Image, ByVal BoardX As Byte, ByVal BoardY As Byte, ByRef ChessSide As Boolean)

        ChessValue = Value
        If ChessSide = True Then
            Side = True
        Else
            Side = False
        End If
        ChessX = BoardX
        ChessY = BoardY
        Alive = True
        PicBox.Parent = Form1
        PicBox.Image = New Bitmap(Icon, New Size(PicBoxWidth, PicBoxHeight))
        PicBox.Size = PicBox.Image.Size
        PicBox.Location = New Point(Board.StartX + (BoardX * Board.IntervalX), Board.StartY + (BoardY * Board.IntervalY))
        PicBox.Visible = True

        AddHandler PicBox.Click, AddressOf picBox_Click

    End Sub

    Private Sub picBox_Click(sender As Object, e As EventArgs)
        'Console.WriteLine("{0}", Convert.ToString(PicBox.Location))
        If Side = Form1.CurrentPlayer Then
            ChessMove = New Move(ChessValue, Side, ChessX, ChessY)
            MsgBox(ChessValue)
        End If
    End Sub

    'Public Sub ShowPossible() '(ByVal Value As Byte, ByVal Side As Boolean, ByRef ChessX As Byte, ByRef ChessY As Byte) Maybe useless
    '    MsgBox(ChessX & ChessY & Alive) 'Checking Purposes

    'End Sub

End Class
