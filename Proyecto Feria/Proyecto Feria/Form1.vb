Public Class Form1

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim contraseña As Double



        If TxtContra.Text = "SantoAdmin" Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Contraseña incorrecta")
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
       
    End Sub

    Private Sub Txtusuario_TextChanged(sender As Object, e As EventArgs) Handles Txtusuario.TextChanged

    End Sub

    Private Sub TxtContra_TextChanged(sender As Object, e As EventArgs) Handles TxtContra.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static n As Integer
        n = n + 1
        If n = 1 Then
            Label1.ForeColor = Color.AntiqueWhite
            Contra.ForeColor = Color.AntiqueWhite
        ElseIf n = 2 Then
            Label1.ForeColor = Color.Black
            Contra.ForeColor = Color.Black
        ElseIf n = 3 Then
            Label1.ForeColor = Color.AntiqueWhite
            Contra.ForeColor = Color.AntiqueWhite
        ElseIf n = 4 Then
            Label1.ForeColor = Color.Black
            Contra.ForeColor = Color.Black
        Else : n = 5
            n = 0
        End If

       
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
