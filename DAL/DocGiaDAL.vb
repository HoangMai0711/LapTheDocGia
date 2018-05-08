Imports System.Data.SqlClient
Imports System.Configuration
Imports DTO


Public Class DocgiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(dg As DocGiaDTO) As Integer

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[dbo.tblDocGia]([HoTen],[LoaiDocGia],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NguoiLapThe])"
        query &= "VALUES (@HoTen,@LoaiDocGia,@NgaySinh, @DiaChi, @Email, @NgayLapThe,@NguoiLapThe)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@HoTen", dg.HoTen)
                    .Parameters.AddWithValue("@LoaiDocGia", dg.LoaiDocGia)
                    .Parameters.AddWithValue("@NgaySinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@DiaChi", dg.DiaChi)
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@NgayLapThe", dg.NgayLapThe)
                    .Parameters.AddWithValue("@NguoiLapThe", dg.NguoiLapThe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return 0
                End Try
            End Using
        End Using
        Return 1
    End Function

End Class
