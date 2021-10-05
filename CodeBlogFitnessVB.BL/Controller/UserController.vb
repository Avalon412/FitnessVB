Imports System
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports CodeBlogFitnessVB.BL.Model

Public Class UserController
    Private user_ As User
    Public ReadOnly Property User() As User
        Get
            Return user_
        End Get
    End Property
    Sub New(userName As String, genderName As String, birthDate As DateTime, weight As Double, height As Double)
        Dim gender = New Gender(genderName)
        user_ = New User(userName, gender, birthDate, weight, height)
    End Sub
    Sub New()
        Dim formatter = New BinaryFormatter()
        Using fs As New FileStream("users.dat", FileMode.OpenOrCreate)
            Try
                user_ = formatter.Deserialize(fs)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End Using
    End Sub
    Sub Save()
        Dim formatter = New BinaryFormatter()

        Using fs As New FileStream("users.dat", FileMode.OpenOrCreate)
            formatter.Serialize(fs, User)
        End Using
    End Sub
End Class
