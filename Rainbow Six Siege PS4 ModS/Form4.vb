Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If InternetConnection() = True Then
                Label1.Text = "Internet Connection: " & "Connected!"
            ElseIf InternetConnection() = False Then
                Label1.Text = "Internet Connection: " & "Not Connected!"

            End If
        Catch ex As Exception
            Label1.Text = "Internet Connection: " & "Not Connected!"
        End Try
    End Sub

    Function InternetConnection() As Boolean
        Return My.Computer.Network.Ping("8.8.8.8")
    End Function
End Class