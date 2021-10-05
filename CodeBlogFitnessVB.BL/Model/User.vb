Imports System

<Serializable> Public Class User
    Dim name_ As String
    Dim gender_ As Gender
    Dim birthDate_ As DateTime
    Dim weight_ As Double
    Dim height_ As Double
    Public ReadOnly Property Name As String
        Get
            Return name_
        End Get
    End Property
    Public ReadOnly Property Gender As Gender
        Get
            Return gender_
        End Get
    End Property
    Public ReadOnly Property BirthDate As DateTime
        Get
            Return birthDate_
        End Get
    End Property
    Public Property Weight As Double
        Get
            Return weight_
        End Get
        Set(value As Double)
            weight_ = value
        End Set
    End Property
    Public Property Height As Double
        Get
            Return height_
        End Get
        Set(value As Double)
            height_ = value
        End Set
    End Property
    Sub New(name As String, gender As Gender, birthDate As DateTime, weight As Double, height As Double)
        If (String.IsNullOrWhiteSpace(name)) Then
            Throw New ArgumentNullException("Name can`t be null or empty", NameOf(name))
        End If

        If (gender Is Nothing) Then
            Throw New ArgumentNullException("Gender can`t be null", NameOf(gender))
        End If

        If (birthDate < DateTime.Parse("01.01.1900") Or birthDate >= DateTime.Now) Then
            Throw New ArgumentException("Impossible date of birth", NameOf(birthDate))
        End If

        If (weight < 0) Then
            Throw New ArgumentException("Weight can`t be less or equal to 0", NameOf(weight))
        End If

        If (height < 0) Then
            Throw New ArgumentException("Height can`t be less or equal to 0", NameOf(height))
        End If

        name_ = name
        gender_ = gender
        birthDate_ = birthDate
        weight_ = weight
        height_ = height
    End Sub
End Class
