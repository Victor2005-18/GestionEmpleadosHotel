Public Class FormDetalle

    Private _empleado As Empleado

    Public Sub New(emp As Empleado)
        InitializeComponent()
        _empleado = emp
        MostrarFicha()
    End Sub

    Private Sub MostrarFicha()
        If _empleado Is Nothing Then Return

        Label2.Text = _empleado.ObtenerFicha()
        Label3.Text = "Salario Base"
        Label4.Text = "Bonos $: "
        Label5.Text = "Horas Extra: "
        Label6.Text = "Pago Mensual Calculado"
        Label7.Text = ModuloValidaciones.FormatearMoneda(_empleado.CalcularPagoMensual())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Guardar cambios: editar salario y campo específico según tipo
        Try
            Dim nuevoSalarioText = InputBox("Nuevo Salario Base:", "Editar Salario", _empleado.SalarioBase.ToString())
            Dim nuevoSalario As Decimal = Decimal.Parse(nuevoSalarioText)
            _empleado.SalarioBase = nuevoSalario

            If TypeOf _empleado Is Gerente Then
                Dim g = CType(_empleado, Gerente)
                Dim nuevoBonoText = InputBox("Porcentaje Bono (5-40):", "Editar Bono", g.PorcentajeBono.ToString())
                Dim nuevoBono As Integer = Integer.Parse(nuevoBonoText)
                g.PorcentajeBono = nuevoBono
            ElseIf TypeOf _empleado Is Operario Then
                Dim o = CType(_empleado, Operario)
                Dim nuevasHorasText = InputBox("Horas Extras (0-80):", "Editar Horas Extras", o.HorasExtras.ToString())
                Dim nuevasHoras As Integer = Integer.Parse(nuevasHorasText)
                o.HorasExtras = nuevasHoras
            End If

            MostrarFicha()
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
