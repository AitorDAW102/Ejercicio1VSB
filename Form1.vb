Public Class Form1
    Dim suma As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        suma = 0
        Dim i As Integer = 1
        While i <= 100
            If i Mod 2 = 0 Then
                suma += i
                suma += i
            ElseIf i Mod 2 = 1 And i Mod 5 = 0 Then
                suma -= 5
            End If
            i += 1
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        suma = 0
        For i = 1 To 100
            suma += i
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        suma = 0
        Dim i As Integer = 1
        Do While i <= 100
            If i Mod 2 = 1 Then
                suma += i
            End If
            i += 1
        Loop
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = suma.ToString()
    End Sub
End Class
