Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Form4
    Dim gender As String
    Dim con As New MySqlConnection("host=localhost; username=root; password=janelle1 ; database=premiere")
    Dim cmd As New MySqlCommand

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MALER.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub FEMALER_CheckedChanged(sender As Object, e As EventArgs) Handles FEMALER.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox8.Text = Format(DateTimePicker1.Value, "MM/dd/yyyy")
    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into prisoners(PRISONERS_NUM,PRISONERS_LNAME,PRISONERS_FNAME,THREAT_LEVEL,RACE,WEIGHT,HEIGHT,DOB,SENTENCE_TIME,PRISONERS_CELL,GENDER) values('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox8.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & gender & "')"
            cmd.ExecuteNonQuery()
            MsgBox("SUCCESSFULLY SAVED!!")
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
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
End Class