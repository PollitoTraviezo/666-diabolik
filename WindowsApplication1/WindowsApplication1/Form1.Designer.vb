<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_a = New System.Windows.Forms.TextBox()
        Me.TB_b = New System.Windows.Forms.TextBox()
        Me.TB_c = New System.Windows.Forms.TextBox()
        Me.TB_X1 = New System.Windows.Forms.TextBox()
        Me.TB_X2 = New System.Windows.Forms.TextBox()
        Me.Btn_aceptar = New System.Windows.Forms.Button()
        Me.Btn_limpiar = New System.Windows.Forms.Button()
        Me.Btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coeficiente A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(558, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coeficiente B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(926, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Coeficiente C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "X1 = "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(826, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "X2 = "
        '
        'TB_a
        '
        Me.TB_a.Location = New System.Drawing.Point(190, 113)
        Me.TB_a.Name = "TB_a"
        Me.TB_a.Size = New System.Drawing.Size(100, 22)
        Me.TB_a.TabIndex = 5
        '
        'TB_b
        '
        Me.TB_b.Location = New System.Drawing.Point(561, 113)
        Me.TB_b.Name = "TB_b"
        Me.TB_b.Size = New System.Drawing.Size(100, 22)
        Me.TB_b.TabIndex = 6
        '
        'TB_c
        '
        Me.TB_c.Location = New System.Drawing.Point(929, 122)
        Me.TB_c.Name = "TB_c"
        Me.TB_c.Size = New System.Drawing.Size(100, 22)
        Me.TB_c.TabIndex = 7
        '
        'TB_X1
        '
        Me.TB_X1.Location = New System.Drawing.Point(328, 326)
        Me.TB_X1.Name = "TB_X1"
        Me.TB_X1.Size = New System.Drawing.Size(100, 22)
        Me.TB_X1.TabIndex = 8
        '
        'TB_X2
        '
        Me.TB_X2.Location = New System.Drawing.Point(884, 326)
        Me.TB_X2.Name = "TB_X2"
        Me.TB_X2.Size = New System.Drawing.Size(100, 22)
        Me.TB_X2.TabIndex = 9
        '
        'Btn_aceptar
        '
        Me.Btn_aceptar.Location = New System.Drawing.Point(476, 204)
        Me.Btn_aceptar.Name = "Btn_aceptar"
        Me.Btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_aceptar.TabIndex = 10
        Me.Btn_aceptar.Text = "Aceptar"
        Me.Btn_aceptar.UseVisualStyleBackColor = True
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.Location = New System.Drawing.Point(621, 204)
        Me.Btn_limpiar.Name = "Btn_limpiar"
        Me.Btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_limpiar.TabIndex = 11
        Me.Btn_limpiar.Text = "Limpiar"
        Me.Btn_limpiar.UseVisualStyleBackColor = True
        '
        'Btn_salir
        '
        Me.Btn_salir.Location = New System.Drawing.Point(778, 204)
        Me.Btn_salir.Name = "Btn_salir"
        Me.Btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_salir.TabIndex = 12
        Me.Btn_salir.Text = "Salir"
        Me.Btn_salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 508)
        Me.Controls.Add(Me.Btn_salir)
        Me.Controls.Add(Me.Btn_limpiar)
        Me.Controls.Add(Me.Btn_aceptar)
        Me.Controls.Add(Me.TB_X2)
        Me.Controls.Add(Me.TB_X1)
        Me.Controls.Add(Me.TB_c)
        Me.Controls.Add(Me.TB_b)
        Me.Controls.Add(Me.TB_a)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "FORMULA GENERAL "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_a As System.Windows.Forms.TextBox
    Friend WithEvents TB_b As System.Windows.Forms.TextBox
    Friend WithEvents TB_c As System.Windows.Forms.TextBox
    Friend WithEvents TB_X1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_X2 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_salir As System.Windows.Forms.Button

End Class
