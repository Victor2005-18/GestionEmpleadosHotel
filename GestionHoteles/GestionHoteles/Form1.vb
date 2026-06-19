Public Class Form1

    Private empleados As New List(Of Empleado)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGridAndTotals()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Nuevo Operario
        Try
            Dim nombre = InputBox("Nombre:", "Nuevo Operario")
            Dim rfc = InputBox("RFC (13 chars):", "Nuevo Operario")
            Dim salarioText = InputBox("Salario Base:", "Nuevo Operario")
            Dim departamento = InputBox("Departamento (Sistemas/Ventas/Administración/Producción):", "Nuevo Operario")
            Dim turno = InputBox("Turno (Matutino/Vespertino/Nocturno):", "Nuevo Operario")
            Dim horasText = InputBox("Horas Extras (0-80):", "Nuevo Operario")

            Dim salario As Decimal = Decimal.Parse(salarioText)
            Dim horas As Integer = Integer.Parse(horasText)

            Dim op As New Operario(nombre, rfc, salario, departamento, turno, horas)
            empleados.Add(op)

            RefreshGridAndTotals()

        Catch ex As Exception
            MessageBox.Show("Error creando Operario: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Nuevo Gerente
        Try
            Dim nombre = InputBox("Nombre:", "Nuevo Gerente")
            Dim rfc = InputBox("RFC (13 chars):", "Nuevo Gerente")
            Dim salarioText = InputBox("Salario Base:", "Nuevo Gerente")
            Dim departamento = InputBox("Departamento (Sistemas/Ventas/Administración/Producción):", "Nuevo Gerente")
            Dim bonoText = InputBox("Porcentaje Bono (5-40):", "Nuevo Gerente")
            Dim personasText = InputBox("Personas a cargo (1-50):", "Nuevo Gerente")

            Dim salario As Decimal = Decimal.Parse(salarioText)
            Dim bono As Integer = Integer.Parse(bonoText)
            Dim personas As Integer = Integer.Parse(personasText)

            Dim g As New Gerente(nombre, rfc, salario, departamento, bono, personas)
            empleados.Add(g)

            RefreshGridAndTotals()

        Catch ex As Exception
            MessageBox.Show("Error creando Gerente: " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshGridAndTotals()
        DataGridView1.Rows.Clear()

        Dim totalNomina As Decimal = 0D

        For Each emp In empleados
            Dim tipo As String = If(TypeOf emp Is Gerente, "Gerente", "Operario")
            Dim pago As Decimal = 0D
            Try
                pago = emp.CalcularPagoMensual()
            Catch
            End Try

            DataGridView1.Rows.Add(emp.Nombre, emp.RFC, tipo, emp.Departamento, ModuloValidaciones.FormatearMoneda(pago))
            totalNomina += pago
        Next

        Label2.Text = "Total Empleados: " & Empleado.GetTotal().ToString()
        Label3.Text = "Total Nomina: " & ModuloValidaciones.FormatearMoneda(totalNomina)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Eliminar seleccionado
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una fila para eliminar.")
            Return
        End If

        Dim idx = DataGridView1.SelectedRows(0).Index
        If idx < 0 OrElse idx >= empleados.Count Then
            MessageBox.Show("Índice inválido.")
            Return
        End If

        Dim resp = MessageBox.Show("¿Eliminar empleado seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If resp = DialogResult.Yes Then
            empleados.RemoveAt(idx)
            RefreshGridAndTotals()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ver Detalle
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una fila para ver detalles.")
            Return
        End If

        Dim idx = DataGridView1.SelectedRows(0).Index
        If idx < 0 OrElse idx >= empleados.Count Then
            MessageBox.Show("Índice inválido.")
            Return
        End If

        Dim emp = empleados(idx)
        Using f As New FormDetalle(emp)
            Dim res = f.ShowDialog()
            If res = DialogResult.OK Then
                RefreshGridAndTotals()
            End If
        End Using
    End Sub

End Class
