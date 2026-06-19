Imports System.Windows.Forms

Public Class FormNuevoOperario
    Inherits Form

    Private txtNombre As TextBox
    Private txtRFC As TextBox
    Private txtSalario As TextBox
    Private txtDepartamento As TextBox
    Private txtTurno As TextBox
    Private txtHoras As TextBox
    Private btnOK As Button
    Private btnCancel As Button

    Public Property EmpleadoCreado As Operario

    Public Sub New()
        Me.Text = "Nuevo Operario"
        Me.Size = New Drawing.Size(420, 320)

        Dim lblY As Integer = 15

        Me.Controls.Add(New Label() With {.Text = "Nombre:", .Location = New Drawing.Point(15, lblY)})
        txtNombre = New TextBox() With {.Location = New Drawing.Point(150, lblY), .Width = 230}
        Me.Controls.Add(txtNombre)
        lblY += 30

        Me.Controls.Add(New Label() With {.Text = "RFC:", .Location = New Drawing.Point(15, lblY)})
        txtRFC = New TextBox() With {.Location = New Drawing.Point(150, lblY), .Width = 230}
        Me.Controls.Add(txtRFC)
        lblY += 30

        Me.Controls.Add(New Label() With {.Text = "Salario Base:", .Location = New Drawing.Point(15, lblY)})
        txtSalario = New TextBox() With {.Location = New Drawing.Point(150, lblY), .Width = 230}
        Me.Controls.Add(txtSalario)
        lblY += 30

        Me.Controls.Add(New Label() With {.Text = "Departamento:", .Location = New Drawing.Point(15, lblY)})
        txtDepartamento = New TextBox() With {.Location = New Drawing.Point(150, lblY), .Width = 230}
        Me.Controls.Add(txtDepartamento)
        lblY += 30

        Me.Controls.Add(New Label() With {.Text = "Turno:", .Location = New Drawing.Point(15, lblY)})
        txtTurno = New TextBox() With {.Location = New Drawing.Point(150, lblY), .Width = 230}
        Me.Controls.Add(txtTurno)
        lblY += 30

        Me.Controls.Add(New Label() With {.Text = "Horas Extras:", .Location = New Drawing.Point(15, lblY)})
        txtHoras = New TextBox() With {.Location = New Drawing.Point(150, lblY), .Width = 230}
        Me.Controls.Add(txtHoras)
        lblY += 40

        btnOK = New Button() With {.Text = "OK", .Location = New Drawing.Point(150, lblY), .Width = 100}
        AddHandler btnOK.Click, AddressOf OnOk
        Me.Controls.Add(btnOK)

        btnCancel = New Button() With {.Text = "Cancelar", .Location = New Drawing.Point(280, lblY), .Width = 100}
        AddHandler btnCancel.Click, Sub(s, e)
                                        Me.DialogResult = DialogResult.Cancel
                                        Me.Close()
                                    End Sub
        Me.Controls.Add(btnCancel)
    End Sub

    Private Sub OnOk(sender As Object, e As EventArgs)
        Try
            Dim nombre = txtNombre.Text
            Dim rfc = txtRFC.Text
            Dim salario = Decimal.Parse(txtSalario.Text)
            Dim departamento = txtDepartamento.Text
            Dim turno = txtTurno.Text
            Dim horas = Integer.Parse(txtHoras.Text)

            Dim op As New Operario(nombre, rfc, salario, departamento, turno, horas)
            EmpleadoCreado = op
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error creando Operario: " & ex.Message)
        End Try
    End Sub
End Class
