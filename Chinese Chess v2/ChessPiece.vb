﻿Public Class ChessPiece

    Private Value As Byte
    Private PicBox As New PictureBox
    Const PicBoxWidth As Integer = Board.IntervalX - 22
    Const PicBoxHeight As Integer = Board.IntervalY - 11
    Private Side As Boolean


    Public Sub New(ByVal Value As Byte, ByVal Icon As Image, ByVal BoardX As Byte, ByVal BoardY As Byte, ByRef Side As Boolean)

        Value = Value
        Side = Side
        PicBox.Parent = Form1
        PicBox.Image = New Bitmap(Icon, New Size(PicBoxWidth, PicBoxHeight))
        PicBox.Size = PicBox.Image.Size
        PicBox.Location = New Point(Board.StartX + (BoardX * Board.IntervalX), Board.StartY + (BoardY * Board.IntervalY))
        PicBox.Visible = True
        'PicBox.BringToFront()
        AddHandler PicBox.Click, AddressOf picBox_Click

    End Sub

    'Public Sub Move(ByVal Value As Byte, ByVal Side As Boolean, ByRef CoordX As Byte, CoordY As Byte)

    '    Dim Moved As Boolean = False
    '    Dim BoardX As Byte
    '    Dim BoardY As Byte
    '    'Dim Possible As Boolean

    '    BoardX = (CoordX - Board.StartX) Mod Board.IntervalX
    '    BoardY = (CoordY - Board.StartY) Mod Board.IntervalY

    '    Select Case Value
    '        Case 1 'Soldier
    '            If Side = True Then
    '                Do
    '                    If BoardX <= 4 Then
    '                        BoardY += 1
    '                        'Else
    '                    End If
    '                Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 3 And BoardY <= 9
    '                Moved = True
    '            Else
    '                Do
    '                    If BoardX <= 5 Then
    '                        BoardY -= 1
    '                        'Else
    '                    End If
    '                Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 6
    '            End If

    '        Case 2 'General
    '            If Side = True Then
    '                Do

    '                Loop Until BoardX >= 3 And BoardX <= 5 And BoardY >= 0 And BoardY <= 2
    '            Else
    '                Do

    '                Loop Until BoardX >= 3 And BoardX <= 5 And BoardY >= 7 And BoardY <= 9
    '            End If
    '        Case 3 'Chariot
    '            Do

    '            Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 9
    '        Case 4 'Horse
    '            Do

    '            Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 9
    '        Case 5 'Elephant
    '            If Side = True Then
    '                Do

    '                Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 4
    '            Else
    '                Do

    '                Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 5 And BoardY <= 9
    '            End If
    '        Case 6 'Advisor
    '            If Side = True Then
    '                Do

    '                Loop Until BoardX >= 3 And BoardX <= 5 And BoardY >= 0 And BoardY >= 2
    '            Else
    '                Do

    '                Loop Until BoardX >= 3 And BoardX <= 5 And BoardY >= 7 And BoardY <= 9
    '            End If
    '        Case 7 'Cannon
    '            Do

    '            Loop Until BoardX >= 0 And BoardX <= 8 And BoardY >= 0 And BoardY <= 9
    '    End Select
    'End Sub

    Private Sub picBox_Click(sender As Object, e As EventArgs)
        'Console.WriteLine("{0}", Convert.ToString(PicBox.Location))
        If Form1.CurrentPlayer = Side Then
            ShowPossible(Value, Side, (PicBox.Location.X Mod Board.IntervalX), (PicBox.Location.Y Mod Board.IntervalY))
        End If
    End Sub

    Public Sub ShowPossible(ByVal Value As Byte, ByVal Side As Boolean, ByRef CoordX As Byte, CoordY As Byte)
        MsgBox("1")
    End Sub

    'FIX SIDE PROBLEM!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

End Class
