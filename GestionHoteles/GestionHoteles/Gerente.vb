Public Class Gerente
    Inherits Empleado

    Private _porcentajeBono As Integer
    Private _personasACargo As Integer

    Public Property PorcentajeBono As Integer
        Get
            Return _porcentajeBono
        End Get
        Set(value As Integer)

            If Not ModuloValidaciones.EsBonoValido(value) Then
                Throw New Exception("El bono debe estar entre 5 y 40")
            End If

            _porcentajeBono = value

        End Set
    End Property

    Public Property PersonasACargo As Integer
        Get
            Return _personasACargo
        End Get
        Set(value As Integer)

            If Not ModuloValidaciones.EsDepartamentoValido("") Then
                ' Mantener validación existente para rango de personas
            End If

            If value < 1 OrElse value > 50 Then
                Throw New Exception("Las personas a cargo deben estar entre 1 y 50")
            End If

            _personasACargo = value

        End Set
    End Property

    Public Sub New(
        nombre As String,
        rfc As String,
        salario As Decimal,
        departamento As String,
        bono As Integer,
        personas As Integer)

        MyBase.New(
            nombre,
            rfc,
            salario,
            departamento)

        PorcentajeBono = bono
        PersonasACargo = personas

    End Sub

    Public Overrides Function CalcularPagoMensual() As Decimal

        Return SalarioBase +
               (SalarioBase * PorcentajeBono / 100D)

    End Function

    Public Overrides Function ObtenerFicha() As String

        Return MyBase.ObtenerFicha() &
               vbCrLf &
               "Bono: " & PorcentajeBono & "%" &
               vbCrLf &
               "Personas a cargo: " & PersonasACargo

    End Function

End Class
