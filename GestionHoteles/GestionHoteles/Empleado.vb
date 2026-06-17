Public MustInherit Class Empleado
    'Campos privados
    Private _nombre As String
    Private _rfc As String
    Private _salarioBase As Decimal
    Private _departamento As String

    'Campo compartido
    Private Shared _totalEmpleados As Integer = 0

    'Constructor
    Public Sub New(nombre As String,
                   rfc As String,
                   salarioBase As Decimal,
                   departamento As String)

        Me.Nombre = nombre
        Me.RFC = rfc
        Me.SalarioBase = salarioBase
        Me.Departamento = departamento

        _totalEmpleados += 1
    End Sub

    'Propiedad Nombre
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)

            If Not EsNombreValido(value) Then
                Throw New Exception("Nombre inválido.")
            End If

            _nombre = value
        End Set
    End Property

    'Propiedad RFC
    Public Property RFC As String
        Get
            Return _rfc
        End Get
        Set(value As String)

            If Not EsRFCValido(value) Then
                Throw New Exception("RFC inválido. Debe tener 13 caracteres en mayúsculas.")
            End If

            _rfc = value
        End Set
    End Property

    'Propiedad SalarioBase
    Public Property SalarioBase As Decimal
        Get
            Return _salarioBase
        End Get
        Set(value As Decimal)

            If Not EsSalarioValido(value) Then
                Throw New Exception("El salario debe ser mayor a 0 y menor o igual a 500,000.")
            End If

            _salarioBase = value
        End Set
    End Property

    'Propiedad Departamento
    Public Property Departamento As String
        Get
            Return _departamento
        End Get
        Set(value As String)
            _departamento = value
        End Set
    End Property

    'Propiedad de solo lectura
    Public ReadOnly Property NombreCompleto As String
        Get
            Return $"{Nombre} ({RFC})"
        End Get
    End Property

    'Método abstracto
    Public MustOverride Function CalcularPagoMensual() As Decimal

    'Método virtual
    Public Overridable Function ObtenerFicha() As String

        Return $"Nombre: {Nombre}" & vbCrLf &
               $"RFC: {RFC}" & vbCrLf &
               $"Departamento: {Departamento}" & vbCrLf &
               $"Salario Base: {FormatearMoneda(SalarioBase)}"
    End Function

    'Métodos auxiliares de validación y formato
    Private Function EsNombreValido(value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            Return False
        End If

        Return value.Trim().Length >= 3
    End Function

    Private Function EsRFCValido(value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            Return False
        End If

        Dim r As String = value.Trim()
        Return r.Length = 13 AndAlso r = r.ToUpperInvariant()
    End Function

    Private Function EsSalarioValido(value As Decimal) As Boolean
        Return value > 0D AndAlso value <= 500000D
    End Function

    Private Function FormatearMoneda(value As Decimal) As String
        Return value.ToString("C2", System.Globalization.CultureInfo.CurrentCulture)
    End Function

    'Método Shared
    Public Shared Function GetTotal() As Integer
        Return _totalEmpleados
    End Function

End Class
