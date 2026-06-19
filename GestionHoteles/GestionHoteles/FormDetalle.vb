Public Class FormDetalle

    Private _empleado As Empleado
    Private txtSalario As TextBox
    Private txtExtra As TextBox
    Private txtFicha As TextBox

    Public Sub New(emp As Empleado)
        InitializeComponent()
        _empleado = emp
        CrearControlesDinamicos()
        MostrarFicha()
    End Sub

    Private Sub MostrarFicha()
        If _empleado Is Nothing Then Return
        txtFicha.Text = _empleado.ObtenerFicha()
        txtSalario.Text = _empleado.SalarioBase.ToString()

        If TypeOf _empleado Is Gerente Then
            Dim g = CType(_empleado, Gerente)
            Label4.Text = "Porcentaje Bono:"
            txtExtra.Text = g.PorcentajeBono.ToString()
        ElseIf TypeOf _empleado Is Operario Then
            Dim o = CType(_empleado, Operario)
            Label4.Text = "Horas Extras:"
            txtExtra.Text = o.HorasExtras.ToString()
        Else
            Label4.Text = ""
            txtExtra.Text = ""
        End If

        Label6.Text = "Pago Mensual Calculado"
        Label7.Text = ModuloValidaciones.FormatearMoneda(_empleado.CalcularPagoMensual())
    End Sub

    Private Sub CrearControlesDinamicos()
        ' Ficha multiline dentro del GroupBox1
        txtFicha = New TextBox() With {
            .Multiline = True,
            .ReadOnly = True,
            .Location = New Drawing.Point(10, 22),
            .Size = New Drawing.Size(420, 120),
            .ScrollBars = ScrollBars.Vertical
        }
        GroupBox1.Controls.Add(txtFicha)

        ' TextBox Salario
        txtSalario = New TextBox() With {
            .Location = New Drawing.Point(220, 300),
            .Width = 200
        }
        Me.Controls.Add(txtSalario)

        ' TextBox Bono/Horas
        txtExtra = New TextBox() With {
            .Location = New Drawing.Point(220, 356),
            .Width = 200
        }
        Me.Controls.Add(txtExtra)

        AddHandler txtSalario.TextChanged, AddressOf OnInputsChanged
        AddHandler txtExtra.TextChanged, AddressOf OnInputsChanged
    End Sub

    Private Sub OnInputsChanged(sender As Object, e As EventArgs)
        ' Actualizar cálculo en tiempo real
        Try
            Dim sal As Decimal = _empleado.SalarioBase
            Dim pago As Decimal = 0D

            If Decimal.TryParse(txtSalario.Text, sal) = False Then
                sal = _empleado.SalarioBase
            End If

            If TypeOf _empleado Is Gerente Then
                Dim bono As Integer = CType(_empleado, Gerente).PorcentajeBono
                Integer.TryParse(txtExtra.Text, bono)
                pago = sal + (sal * bono / 100D)
            ElseIf TypeOf _empleado Is Operario Then
                Dim horas As Integer = CType(_empleado, Operario).HorasExtras
                Integer.TryParse(txtExtra.Text, horas)
                Dim valorHora As Decimal = sal / 160D
                pago = sal + horas * valorHora * 1.5D
            Else
                pago = sal
            End If

            Label7.Text = ModuloValidaciones.FormatearMoneda(pago)
        Catch
            ' silencioso
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Guardar cambios desde los TextBox
        Try
            Dim nuevoSalario As Decimal = Decimal.Parse(txtSalario.Text)
            _empleado.SalarioBase = nuevoSalario

            If TypeOf _empleado Is Gerente Then
                Dim g = CType(_empleado, Gerente)
                Dim nuevoBono As Integer = Integer.Parse(txtExtra.Text)
                g.PorcentajeBono = nuevoBono
            ElseIf TypeOf _empleado Is Operario Then
                Dim o = CType(_empleado, Operario)
                Dim nuevasHoras As Integer = Integer.Parse(txtExtra.Text)
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
