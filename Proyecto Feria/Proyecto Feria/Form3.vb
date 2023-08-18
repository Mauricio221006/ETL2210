Imports System.Data
Imports System.Data.OleDb


Public Class Form3
    Dim cadena As New OleDbConnection
    Dim comando As New OleDbCommand
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID As Integer
        Dim I As Integer

        ID = (Rnd() * 1000)
        Do While ID <= 100


            If ID >= 100 Then
                ID = ID
            Else
                ID = (Rnd() * 1000)
            End If
        Loop



        ListBox1.Items.Add(ID)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            cadena.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\eltio\Desktop\Vscode2012\Proyecto Feria\Database1.mdb"
            cadena.Open()

            comando = New OleDbCommand("Insert into Base de datos ESTUDIANTES ")

        Catch ex As Exception

        End Try
    End Sub
End Class