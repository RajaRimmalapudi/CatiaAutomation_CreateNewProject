Option Explicit On

Imports INFITF
Imports MECMOD
Imports PARTITF

Public Class Form1

    Dim mycatia As INFITF.Application

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            mycatia = GetObject(, "CATIA.Application")
        Catch ex As Exception
            mycatia = CreateObject("CATIA.Application")
        End Try

        mycatia.Visible = True
        mycatia.DisplayFileAlerts = True

        mycatia.Documents.Add("Part")
        MsgBox("Part create Successfully!!!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            mycatia = GetObject(, "CATIA.Application")
        Catch ex As Exception
            mycatia = CreateObject("CATIA.Application")
        End Try

        mycatia.Visible = True
        mycatia.DisplayFileAlerts = True

        mycatia.Documents.Add("Product")
        MsgBox("Product create Successfully!!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            mycatia = GetObject(, "CATIA.Application")
        Catch ex As Exception
            mycatia = CreateObject("CATIA.Application")
        End Try

        mycatia.Visible = True
        mycatia.DisplayFileAlerts = True

        mycatia.Documents.Add("Drawing")
        MsgBox("Drawing create Successfully!!!")
    End Sub

End Class
