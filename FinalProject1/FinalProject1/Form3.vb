Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Form3
    Dim gender As String
    Dim con As New MySqlConnection("host=localhost; username=root; password=janelle1 ; database=premiere")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim state As String
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM CELLS WHERE CELL_NUM=1"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                state = dr("state").ToString
                num = dr("inmate_num").ToString
                dr.Close()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try

        MsgBox("cell is : " & state & " and inmate id is : " & num)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Integer
        Dim state As String
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM CELLS WHERE CELL_NUM=2"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                state = dr("state").ToString
                num = dr("inmate_num").ToString
                dr.Close()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try

        MsgBox("cell is : " & state & " and inmate id is : " & num)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num As Integer
        Dim state As String
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM CELLS WHERE CELL_NUM=3"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                state = dr("state").ToString
                num = dr("inmate_num").ToString
                dr.Close()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try

        MsgBox("cell is : " & state & " and inmate id is : " & num)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num As Integer
        Dim state As String
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM CELLS WHERE CELL_NUM=4"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                state = dr("state").ToString
                num = dr("inmate_num").ToString
                dr.Close()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try

        MsgBox("cell is : " & state & "and inmate id is : " & num)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num As Integer
        Dim state As String
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM CELLS WHERE CELL_NUM=5"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                state = dr("state").ToString
                num = dr("inmate_num").ToString
                dr.Close()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try

        MsgBox("cell is : " & state & " and inmate id is : " & num)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim num As Integer
        Dim state As String
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM CELLS WHERE CELL_NUM=6"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                state = dr("state").ToString
                num = dr("inmate_num").ToString
                dr.Close()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try

        MsgBox("cell is : " & state & " and inmate id is : " & num)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim num As Integer
        Dim state As String
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM CELLS WHERE CELL_NUM=7"
            dr = cmd.ExecuteReader
            If Not dr Is Nothing Then
                dr.Read()
                state = dr("state").ToString
                num = dr("inmate_num").ToString
                dr.Close()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try

        MsgBox("cell is : " & state & " and inmate id is : " & num)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Form8.Show()
    End Sub
End Class