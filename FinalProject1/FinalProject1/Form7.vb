Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Form7
    Dim gender As String
    Dim con As New MySqlConnection("host=localhost; username=root; password=janelle1 ; database=premiere")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM STAFF WHERE STAFF_ID='" & TextBox1.Text & "'"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                TextBox2.Text = dr("FIRSTNAME").ToString
                TextBox3.Text = dr("LASTNAME").ToString
                TextBox4.Text = dr("POSITION").ToString


                dr.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update STAFF set FIRSTname='" & TextBox2.Text & "',LASTNAME='" & TextBox3.Text & "',POSITION='" & TextBox4.Text & "'where STAFF_ID='" & TextBox1.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Update")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM prisoners WHERE STAFF_ID='" & TextBox1.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Successfully DELETED", MsgBoxStyle.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class