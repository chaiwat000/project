Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Module Code
    Public strcon As String = ConfigurationManager.ConnectionStrings("vbProject_Luggage.My.MySettings.strcon").ConnectionString
    Public con As New SqlConnection(strcon)
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public cmd As SqlCommand
    Public sql As String
    Public tran As SqlTransaction

    Public Sub connectionDB()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Public Function ReDGV()
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "tb")
        Return ds.Tables("tb")
    End Function


End Module
