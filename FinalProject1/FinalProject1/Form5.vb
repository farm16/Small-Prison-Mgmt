Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Form5
    Dim gender As String
    Dim con As New MySqlConnection("host=localhost; username=root; password=janelle1 ; database=premiere")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

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
            cmd.CommandText = "SELECT * FROM PRISONERS WHERE PRISONERS_NUM='" & TextBox1.Text & "'"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                TextBox2.Text = dr("PRISONERS_FNAME").ToString
                TextBox3.Text = dr("PRISONERS_LNAME").ToString
                Dim temp As String
                temp = dr("GENDER")
                If temp = "Male" Then
                    MALER.Checked = True
                Else
                    FEMALER.Checked = False
                End If

                TextBox8.Text = dr("dob").ToString
                ComboBox1.Text = dr("race").ToString
                TextBox4.Text = dr("weight").ToString
                TextBox5.Text = dr("height").ToString
                TextBox6.Text = dr("sentence_time").ToString
                TextBox7.Text = dr("prisoners_cell").ToString
                ComboBox2.Text = dr("threat_level").ToString

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
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class