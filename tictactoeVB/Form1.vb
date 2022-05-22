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

    Private Sub NorthWest_Click(sender As Object, e As EventArgs) Handles NorthWest.Click
        PrintButtonText(NorthWest)
    End Sub

    Public Function PrintButtonText(ByVal btn As Button)
        If btn.Text = "" Then
            btn.Text = currentPlayer
            ShowTurn()
        End If
        Return True
    End Function

    Private Sub North_Click(sender As Object, e As EventArgs) Handles North.Click
        PrintButtonText(North)
    End Sub

    Private Sub NorthEast_Click(sender As Object, e As EventArgs) Handles NorthEast.Click
        PrintButtonText(NorthEast)
    End Sub

    Private Sub West_Click(sender As Object, e As EventArgs) Handles West.Click
        PrintButtonText(West)
    End Sub

    Private Sub Center_Click(sender As Object, e As EventArgs) Handles Center.Click
        PrintButtonText(Center)
    End Sub

    Private Sub East_Click(sender As Object, e As EventArgs) Handles East.Click
        PrintButtonText(East)
    End Sub

    Private Sub SouthWest_Click(sender As Object, e As EventArgs) Handles SouthWest.Click
        PrintButtonText(SouthWest)
    End Sub

    Private Sub South_Click(sender As Object, e As EventArgs) Handles South.Click
        PrintButtonText(South)
    End Sub

    Private Sub SouthEast_Click(sender As Object, e As EventArgs) Handles SouthEast.Click
        PrintButtonText(SouthEast)
    End Sub
End Class
