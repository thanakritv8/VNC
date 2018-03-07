Imports DAL
Public Class BLL_Server
    Public Function GetDataServer()
        Dim _SQL As String = "SELECT * FROM [VNC].[dbo].[DataServer]"
        Return DB.ExecuteSQL(_SQL, DB.con.DB41)
    End Function
End Class
