Public Class Form1

    Private NewGame As Game
    Public CurrentPlayer As Boolean = False 'Red Side always start first
    Public PosX As Integer
    Public PosY As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

        NewGame = New Game


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If CurrentPlayer = True Then 'Display Player Turn
            PlayerTurn.Image = My.Resources.Black
        Else
            PlayerTurn.Image = My.Resources.Red
        End If

    End Sub

    Private Sub PlayerTurn_Click(sender As Object, e As EventArgs) Handles PlayerTurn.Click

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown 'For testing purposes
        If e.Button = MouseButtons.Left Then
            'PosX = e.X
            'PosY = e.Y
            'MsgBox(PosX & PosY)
        End If
    End Sub
End Class
