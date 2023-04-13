Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtMinuman.Text
            Case "JP" : TextBox2.Text = "Jeruk Peras"

            Case "MNL" : TextBox2.Text = "Mineral"

            Case "JA" : TextBox2.Text = "Jus Apel"

            Case Else : TextBox2.Text = "Tomat"
        End Select
    End Sub
End Class
