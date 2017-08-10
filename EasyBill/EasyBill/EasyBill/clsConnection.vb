Public Class clsConnection

    ' Dim sqlConnection As New SqlClient.SqlConnection("server=" & toGetIPAddress() & ";database=EasyBill;uid=sa;pwd=orange;")

    Dim sqlConnection As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True")

    Public Function Connection() As SqlClient.SqlConnection


        If sqlConnection.State = ConnectionState.Open Then
            sqlConnection.Close()
        End If

        sqlConnection.Open()
     
        Return sqlConnection

    End Function

    Public Function toGetIPAddress() As String

        toGetIPAddress = IO.File.ReadAllText(Application.StartupPath & "\" & "IPAddress.txt")

    End Function

End Class
