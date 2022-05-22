Public Class Form1
    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Reset()
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
End Class
