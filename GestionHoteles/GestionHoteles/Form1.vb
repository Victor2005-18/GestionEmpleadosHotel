Public Class Form1

    Private empleados As New List(Of Empleado)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGridAndTotals()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Nuevo Operario (formulario)
        Using f As New FormNuevoOperario()
            Dim res = f.ShowDialog()
            If res = DialogResult.OK AndAlso f.EmpleadoCreado IsNot Nothing Then
                empleados.Add(f.EmpleadoCreado)
                RefreshGridAndTotals()
            End If
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Nuevo Gerente (formulario)
        Using f As New FormNuevoGerente()
            Dim res = f.ShowDialog()
            If res = DialogResult.OK AndAlso f.EmpleadoCreado IsNot Nothing Then
                empleados.Add(f.EmpleadoCreado)
                RefreshGridAndTotals()
            End If
        End Using
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
