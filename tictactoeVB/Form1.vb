Public Class Form1
    Dim currentPlayer As Char = "X"


    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Reset()
        ShowTurn()
    End Sub

    Public Function Reset()
        NorthWest.Text = ""
        North.Text = ""
        NorthEast.Text = ""
        West.Text = ""
        Center.Text = ""
        East.Text = ""
        SouthWest.Text = ""
        South.Text = ""
        SouthEast.Text = ""
        Return True
    End Function

    Public Function ShowTurn()
        If (currentPlayer = "X") Then
            currentPlayer = "O"
        ElseIf (currentPlayer = "O") Then
            currentPlayer = "X"
        End If

        turnLabel.Text = "Current Player: " + currentPlayer
        Return currentPlayer
    End Function





End Class
