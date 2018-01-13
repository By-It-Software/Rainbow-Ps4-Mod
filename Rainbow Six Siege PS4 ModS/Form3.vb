
Imports System.Net

Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(GetIP)
    End Sub

    Function GetIP() As String
        Dim IP As New WebClient
        Return IP.DownloadString("http://bot.whatismyipaddress.com/")

    End Function

End Class