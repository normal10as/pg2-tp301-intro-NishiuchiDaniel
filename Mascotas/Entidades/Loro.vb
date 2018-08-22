Public Class Loro
    Private _edad As Short
    Private _fechaNacimiento As Date
    Private _nombre As String
    Private _memoria As String

    Public Sub New()
        Me.FechaNacimiento = Date.Now()
        Me.Nombre = "Anonimo"
    End Sub

    Public Sub New(FechaNacimiento As Date, Nombre As String)
        Me.FechaNacimiento = FechaNacimiento
        Me.Nombre = Nombre
    End Sub

    Public Property Memoria As Queue
        Get
            Return Memoria.Dequeue
        End Get
        Set(value As Queue)

        End Set
    End Property


    Public ReadOnly Property Edad As Short
        Get
            Return _edad
        End Get
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Private Function CalcularEdad(FechaNacimiento As Date) As UShort
        Return Year(Date.Now) - Year(FechaNacimiento)
    End Function

    Public Sub Escuchar(Frase As String)
        _memoria
    End Sub

    Public Function Hablar() As String

    End Function


End Class
