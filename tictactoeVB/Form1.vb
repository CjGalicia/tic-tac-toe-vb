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
            CheckResult()

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

    Public Function CheckResult()
        If NorthWest.Text = North.Text And North.Text = NorthEast.Text Then
            winner(NorthWest, North, NorthEast)
        ElseIf NorthWest.Text = Center.Text And Center.Text = SouthEast.Text Then
            winner(NorthWest, Center, SouthEast)
        ElseIf West.Text = Center.Text And Center.Text = East.Text Then
            winner(West, Center, East)
        ElseIf SouthWest.Text = South.Text And South.Text = SouthEast.Text Then
            winner(SouthWest, South, SouthEast)
        ElseIf NorthWest.Text = West.Text And West.Text = SouthWest.Text Then
            winner(NorthWest, West, SouthWest)
        ElseIf North.Text = Center.Text And Center.Text = South.Text Then
            winner(North, Center, South)
        ElseIf NorthEast.Text = East.Text And East.Text = SouthEast.Text Then
            winner(NorthEast, East, SouthEast)
        ElseIf NorthEast.Text = Center.Text And Center.Text = SouthWest.Text Then
            winner(NorthEast, Center, SouthWest)
        End If
    End Function

    Public Function winner(ByVal Button1 As Button, ByVal Button2 As Button, ByVal Button3 As Button)
        If Button1.Text = "" Or Button2.Text = "" Or Button3.Text = "" Then
        Else
            MessageBox.Show(Button1.Text.ToString + " Winner")
        End If

    End Function
End Class
