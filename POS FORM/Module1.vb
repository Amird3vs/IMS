Imports System.Data.OracleClient

<Obsolete>
Module Module1
    Public strSTATUS As String = "Pending" 'this is temporary status
    Public strUser As String = "POINTOFSALE" 'this is temporary user
    Public connection As String = "Data Source=localhost;User ID=SEPROJ;Password=seproj;Unicode=True"
    Public cn As New OracleConnection(connection)
    Public cm As OracleCommand
    Public dr As OracleDataReader
    Public da As OracleDataAdapter
    Public dt As New DataTable
    Public str As String

    Function GetVat() As Double
        cn.Open()
        cm = New OracleCommand("Select * from TBLVAT", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then GetVat = CDbl(dr.Item("VAT").ToString) Else GetVat = "0.00"

        dr.Close()
        cn.Close()
        Return GetVat
    End Function
End Module
