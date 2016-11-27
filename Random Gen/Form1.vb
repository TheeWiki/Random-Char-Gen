Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = GenerateRandomString(TextBox2.Text, False)
    End Sub

    Public Function GenerateRandomString(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim random As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ".ToCharArray()
        Dim allowableNumChars() As Char = "0123456789".ToCharArray()
        Dim allowableComplexChars() As Char = "!@#$%^&*()-=_~`.,';[]\:{}+?></".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            If (CheckBox1.Checked) Then
                final += allowableChars(random.Next(allowableChars.Length - 1))
            End If
            If (CheckBox2.Checked) Then
                final += allowableNumChars(random.Next(allowableNumChars.Length - 1))
            End If
            If (CheckBox4.Checked) Then
                final += allowableChars(random.Next(allowableChars.Length - 1)) & allowableNumChars(random.Next(allowableNumChars.Length - 1)) & allowableComplexChars(random.Next(allowableComplexChars.Length - 1))
            End If
        Next
        Return IIf(upper, final.ToUpper(), final)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub
End Class
