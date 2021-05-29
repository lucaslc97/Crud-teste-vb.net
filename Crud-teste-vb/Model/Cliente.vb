Public Class Cliente

    Private _idCliente As Integer
    Public Property id() As String
        Get
            Return _idCliente
        End Get
        Set(ByVal value As String)
            _idCliente = value
        End Set
    End Property
    Public Property _nomeCliente As String
    Public Property nomeCliente() As String
        Get
            Return _nomeCliente
        End Get
        Set(ByVal value As String)
            _nomeCliente = value
        End Set
    End Property

    Public Property _dataNascimento As String
    Public Property dataNascimento() As String
        Get
            Return _dataNascimento
        End Get
        Set(ByVal value As String)
            _dataNascimento = value
        End Set
    End Property

    Public Property _ativo As String
    Public Property ativo() As String
        Get
            Return _ativo
        End Get
        Set(ByVal value As String)
            _ativo = value
        End Set
    End Property

End Class
