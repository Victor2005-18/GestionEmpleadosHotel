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
                Throw New Exception("Horas extras inválidas")
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
        horasExtras As Integer)

        MyBase.New(nombre, rfc, salario, departamento)

        Me.Turno = turno
        Me.HorasExtras = horasExtras

    End Sub

    Public Overrides Function CalcularPagoMensual() As Decimal

        ' Suponemos que cada hora extra se paga al 1.5 del valor por hora (salarioBase/160 horas)
        Dim valorHora As Decimal = SalarioBase / 160D
        Dim pagoHorasExtras As Decimal = HorasExtras * valorHora * 1.5D

        Return SalarioBase + pagoHorasExtras

    End Function

    Public Overrides Function ObtenerFicha() As String

        Return MyBase.ObtenerFicha() &
               vbCrLf &
               "Turno: " & Turno &
               vbCrLf &
               "Horas Extras: " & HorasExtras

    End Function

End Class
