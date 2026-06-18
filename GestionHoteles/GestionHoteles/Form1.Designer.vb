<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        nombre = New DataGridViewTextBoxColumn()
        rfc = New DataGridViewTextBoxColumn()
        tipo = New DataGridViewTextBoxColumn()
        departamento = New DataGridViewTextBoxColumn()
        pago_mensual = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 19)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 15)
        Label1.TabIndex = 0
        Label1.Text = "Principal"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {nombre, rfc, tipo, departamento, pago_mensual})
        DataGridView1.Location = New Point(21, 52)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(640, 136)
        DataGridView1.TabIndex = 1
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "Nombre"
        nombre.MinimumWidth = 8
        nombre.Name = "nombre"
        nombre.Width = 150
        ' 
        ' rfc
        ' 
        rfc.HeaderText = "RFC"
        rfc.MinimumWidth = 8
        rfc.Name = "rfc"
        rfc.Width = 150
        ' 
        ' tipo
        ' 
        tipo.HeaderText = "Tipo (Gerente/Operatario)"
        tipo.MinimumWidth = 8
        tipo.Name = "tipo"
        tipo.Width = 150
        ' 
        ' departamento
        ' 
        departamento.HeaderText = "Departamento"
        departamento.MinimumWidth = 8
        departamento.Name = "departamento"
        departamento.Width = 150
        ' 
        ' pago_mensual
        ' 
        pago_mensual.HeaderText = "Pago Mensual"
        pago_mensual.MinimumWidth = 8
        pago_mensual.Name = "pago_mensual"
        pago_mensual.Width = 150
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(21, 225)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 20)
        Button1.TabIndex = 2
        Button1.Text = "Ver Detalle"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(133, 225)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 20)
        Button2.TabIndex = 3
        Button2.Text = "Nuevo Operario"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(268, 225)
        Button3.Margin = New Padding(2, 2, 2, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(111, 20)
        Button3.TabIndex = 4
        Button3.Text = "Nuevo Gerente"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(421, 225)
        Button4.Margin = New Padding(2, 2, 2, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(78, 20)
        Button4.TabIndex = 5
        Button4.Text = "Eliminar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 302)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 6
        Label2.Text = "Total Empleados"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(421, 302)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 7
        Label3.Text = "Total Nomina"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 356)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents rfc As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents departamento As DataGridViewTextBoxColumn
    Friend WithEvents pago_mensual As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
