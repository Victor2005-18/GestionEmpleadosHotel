Public Class Operario
    Inherits Empleado

    Private _turno As String
    Private _horasExtras As Integer

    Public Property Turno As String
        Get
            Return _turno
        End Get
        Set(value As String)
            If Not ModuloValidaciones.EsTurnoValido(value) Then
                Throw New Exception("Turno inválido")
            End If

            _turno = value
        End Set
    End Property

    Public Property HorasExtras As Integer
        Get
            Return _horasExtras
        End Get
        Set(value As Integer)
            If value < 0 OrElse value > 80 Then
                Throw New Exception("Horas extra inválidas")
            End If

            _horasExtras = value
        End Set
    End Property

    Public Sub New(
        nombre As String,
        rfc As String,
        salario As Decimal,
        departamento As String,
        turno As String,
        horas As Integer)

        MyBase.New(
            nombre,
            rfc,
            salario,
            departamento)

        turno = turno
        HorasExtras = horas

    End Sub

    Public Overrides Function CalcularPagoMensual() As Decimal
        Return SalarioBase +
               (HorasExtras *
               (SalarioBase / 160D) *
               1.5D)
    End Function

    Public Overrides Function ObtenerFicha() As String

        Return MyBase.ObtenerFicha() &
               vbCrLf &
               "Turno: " & Turno &
               vbCrLf &
               "Horas extra: " & HorasExtras

    End Function

End Class