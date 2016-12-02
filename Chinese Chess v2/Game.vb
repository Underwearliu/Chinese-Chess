Public Class Game

    Public Sub New()

        Dim Player1 As New Player(True)         'Setup for Player1
        Dim Player2 As New Player(False)        'Setup for Player2

        'Play(Form1.CurrentPlayer)

    End Sub

    Public Sub Play(ByRef CurrentPlayer As Boolean)

    End Sub

    Public Sub CheckWin()

    End Sub

    'Public Sub ActionCheck(ByVal CurrentPlayer As Boolean) ' test
    '    If CurrentPlayer = True Then
    '       MsgBox("Hello World")
    '   Else
    '        MsgBox("Bye World")
    '    End If

    'End Sub

End Class
