Public Class clsEasyBill

    Dim objConnection As New clsConnection
    Dim sqlCommand As SqlClient.SqlCommand

    Public Sub InsertProduct(ByVal strProductCode As String, ByVal strBarcode As String, ByVal strProductName As String, ByVal strUnit As String)

        sqlCommand = New SqlClient.SqlCommand("InsertProduct", objConnection.Connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        sqlCommand.Parameters.AddWithValue("@vaProductCode", strProductCode)
        sqlCommand.Parameters.AddWithValue("@vaBarcode", strBarcode)
        sqlCommand.Parameters.AddWithValue("@vaProductName", strProductName)
        sqlCommand.Parameters.AddWithValue("@vaUnit", strUnit)
        sqlCommand.ExecuteNonQuery()

    End Sub


    Public Sub InsertCategory(ByVal strCategoryName As String, ByVal dcIGST As Decimal, ByVal dcCGST As Decimal, ByVal dcSGST As Decimal)

        sqlCommand = New SqlClient.SqlCommand("InsertCategory", objConnection.Connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        sqlCommand.Parameters.AddWithValue("@vaCategoryName", strCategoryName)
        sqlCommand.Parameters.AddWithValue("@dcIGST", dcIGST)
        sqlCommand.Parameters.AddWithValue("@dcCGST", dcCGST)
        sqlCommand.Parameters.AddWithValue("@dcSGST", dcSGST)
        sqlCommand.ExecuteNonQuery()

    End Sub


    Public Sub UpdateCategory(ByVal intCategoryID As Integer, ByVal strCategoryName As String, ByVal dcIGST As Decimal, ByVal dcCGST As Decimal, ByVal dcSGST As Decimal)

        sqlCommand = New SqlClient.SqlCommand("UpdateCategory", objConnection.Connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        sqlCommand.Parameters.AddWithValue("@intCategoryID", intCategoryID)
        sqlCommand.Parameters.AddWithValue("@vaCategoryName", strCategoryName)
        sqlCommand.Parameters.AddWithValue("@dcIGST", dcIGST)
        sqlCommand.Parameters.AddWithValue("@dcCGST", dcCGST)
        sqlCommand.Parameters.AddWithValue("@dcSGST", dcSGST)
        sqlCommand.ExecuteNonQuery()

    End Sub

    Public Function FetchProductBasedOnCode(ByVal strCriteria As String, ByVal strValue As String) As SqlClient.SqlDataReader

        sqlCommand = New SqlClient.SqlCommand("FetchProductBasedOnCode", objConnection.Connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        sqlCommand.Parameters.AddWithValue("@vaCriteria", strCriteria)
        sqlCommand.Parameters.AddWithValue("@vaValue", strValue)
        Return sqlCommand.ExecuteReader

    End Function

    Public Function FetchAllProductCode() As SqlClient.SqlDataReader

        sqlCommand = New SqlClient.SqlCommand("FetchAllProductCode", objConnection.Connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        Return sqlCommand.ExecuteReader

    End Function

    Public Function FetchAllCategory() As SqlClient.SqlDataReader

        sqlCommand = New SqlClient.SqlCommand("FetchAllCategory", objConnection.Connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        Return sqlCommand.ExecuteReader

    End Function


    Public Function FetchAllBarcode() As SqlClient.SqlDataReader

        sqlCommand = New SqlClient.SqlCommand("FetchAllBarcode", objConnection.Connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        Return sqlCommand.ExecuteReader

    End Function

    Public Function FetchAllProductName() As SqlClient.SqlDataReader

        sqlCommand = New SqlClient.SqlCommand("FetchAllProductName", objConnection.Connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        Return sqlCommand.ExecuteReader

    End Function

End Class
