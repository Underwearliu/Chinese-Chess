Public Class ChessPiece

    Private ID As Byte
    Private PicBox As New PictureBox

    Private Const StartX = 16 '45 'Top left hand corner of the board
    Private Const StartY = 3 '58 'Top left hand corner of the board
    Private Const IntervalX As SByte = 82
    Private Const IntervalY As SByte = 71



    Public Sub New(ByVal Value As Byte, ByVal Icon As Image, ByVal BoardX As Byte, ByVal BoardY As Byte)
        ID = Value

        PicBox.Width = IntervalX - 22
        PicBox.Height = IntervalY - 11
        PicBox.Image = New Bitmap(Icon, New Size(PicBox.Size))
        PicBox.Location = New Point(StartX + (BoardX * IntervalX), StartY + (BoardY * IntervalY))
        PicBox.Visible = True
        PicBox.BringToFront()

        Form1.Controls.Add(PicBox)

    End Sub

    

    Public Sub Move(ByVal Value As Byte, ByVal Side As Boolean, BoardX As Byte, BoardY As Byte)
        Dim Moved As Boolean = False
        'Dim Possible As Boolean

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

End Class
