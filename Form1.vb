Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim suma As Integer = 0
        Dim i As Integer = 1
        While i <= 100
            If i%2 = 0 Then
                suma += i
                suma += i
            ElseIf i%2 = 1 And i%5 = 0 Then
                suma -= 5
            End If
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suma As Integer = 0
        For i = 1 To 100
            suma += i
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim suma As Integer = 0
        Dim i As Integer = 1
        Do While i <= 100
            If i%2 = 1 Then
                suma += i
            End If
            i += 1
        Loop
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        suma
    End Sub
End Class
