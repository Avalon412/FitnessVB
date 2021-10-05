Imports System

<Serializable> Public Class Gender

    Dim name_ As String

    Public ReadOnly Property Name As String
        Get
            Return name_
        End Get
    End Property

    Sub New(name As String)
        If (String.IsNullOrWhiteSpace(name)) Then
            Throw New ArgumentNullException("Name can`t be empty or null", NameOf(name))
        End If

        name_ = name
    End Sub

    Public Overrides Function ToString() As String
        Return name_
    End Function
End Class
