Public Class ChessPiece

    Private Value As Byte
    Private PicBox As New PictureBox
    Private Side As Boolean

    Public Sub New(ByVal Value As Byte, ByVal Icon As Image, ByVal BoardX As Byte, ByVal BoardY As Byte, ByRef Side As Boolean)

        Value = Value
        Side = Side
        PicBox.Parent = Form1
        PicBox.Width = Board.IntervalX - 22
        PicBox.Height = Board.IntervalY - 11
        PicBox.Image = New Bitmap(Icon, New Size(PicBox.Size))
        PicBox.Location = New Point(Board.StartX + (BoardX * Board.IntervalX), Board.StartY + (BoardY * Board.IntervalY))
        PicBox.Visible = False
        PicBox.BringToFront()
        PicBox.AllowDrop = True
        AddHandler PicBox.Click, AddressOf picBox_Click

    End Sub

    Public Sub Move(ByVal Value As Byte, ByVal Side As Boolean, ByRef CoordX As Byte, CoordY As Byte)

        Dim Moved As Boolean = False
        Dim BoardX As Byte
        Dim BoardY As Byte
        'Dim Possible As Boolean

        BoardX = (CoordX - Board.StartX) Mod Board.IntervalX
        BoardY = (CoordY - Board.StartY) Mod Board.IntervalY

        Select Case Value
            Case 1 'Soldier
                If Side = True Then
                    Do
                        If BoardX <= 4 Then
                            BoardY += 1
                            'Else
                        End If
                    Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 3 And BoardY <= 9
                    Moved = True
                Else
                    Do
                        If BoardX <= 5 Then
                            BoardY -= 1
                            'Else
                        End If
                    Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 6
                End If

            Case 2 'General
                If Side = True Then
                    Do

                    Loop Until BoardX >= 3 And BoardX <= 5 And BoardY >= 0 And BoardY <= 2
                Else
                    Do

                    Loop Until BoardX >= 3 And BoardX <= 5 And BoardY >= 7 And BoardY <= 9
                End If
            Case 3 'Chariot
                Do

                Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 9
            Case 4 'Horse
                Do

                Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 9
            Case 5 'Elephant
                If Side = True Then
                    Do

                    Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 4
                Else
                    Do

                    Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 5 And BoardY <= 9
                End If
            Case 6 'Advisor
                If Side = True Then
                    Do

                    Loop Until BoardX >= 3 And BoardX <= 5 And BoardY >= 0 And BoardY >= 2
                Else
                    Do

                    Loop Until BoardX >= 3 And BoardX <= 5 And BoardY >= 7 And BoardY <= 9
                End If
            Case 7 'Cannon
                Do

                Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 9
        End Select
    End Sub

    Private Sub picBox_Click(sender As Object, e As EventArgs)
        Console.WriteLine("{0}", Convert.ToString(PicBox.Location))
        If Form1.CurrentPlayer = Side Then
            'Move(Value, Side, PicBox.Location.X, PicBox.Location.Y)
        End If
    End Sub

    Private Sub ShowPossible()

    End Sub
End Class
