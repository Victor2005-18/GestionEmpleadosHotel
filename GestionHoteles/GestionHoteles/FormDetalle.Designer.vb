<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(218, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 25)
        Label1.TabIndex = 0
        Label1.Text = "Detalles Empleado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 25)
        Label2.TabIndex = 1
        Label2.Text = "Informacion Completa"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 302)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 25)
        Label3.TabIndex = 2
        Label3.Text = "Salario Base"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(66, 359)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 3
        Label4.Text = "Bonos $: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(66, 416)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 25)
        Label5.TabIndex = 4
        Label5.Text = "Horas Extra: "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(66, 481)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(205, 25)
        Label6.TabIndex = 5
        Label6.Text = "Pago Mensual Calculado"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(446, 481)
        Label7.Name = "Label7"
        Label7.Size = New Size(22, 25)
        Label7.TabIndex = 6
        Label7.Text = "$"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(165, 561)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 7
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(419, 561)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 8
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(66, 129)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(453, 150)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' FormDetalle
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 643)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormDetalle"
        Text = "FormDetalle"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
