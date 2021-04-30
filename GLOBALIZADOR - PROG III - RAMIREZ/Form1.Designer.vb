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
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.cmbUnidadM = New System.Windows.Forms.ComboBox()
        Me.cmbTipoP = New System.Windows.Forms.ComboBox()
        Me.dtpFechaL = New System.Windows.Forms.DateTimePicker()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(219, 127)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtProducto.TabIndex = 1
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(219, 194)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 2
        '
        'cmbUnidadM
        '
        Me.cmbUnidadM.FormattingEnabled = True
        Me.cmbUnidadM.Location = New System.Drawing.Point(219, 274)
        Me.cmbUnidadM.Name = "cmbUnidadM"
        Me.cmbUnidadM.Size = New System.Drawing.Size(121, 21)
        Me.cmbUnidadM.TabIndex = 3
        '
        'cmbTipoP
        '
        Me.cmbTipoP.FormattingEnabled = True
        Me.cmbTipoP.Location = New System.Drawing.Point(219, 163)
        Me.cmbTipoP.Name = "cmbTipoP"
        Me.cmbTipoP.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoP.TabIndex = 4
        '
        'dtpFechaL
        '
        Me.dtpFechaL.Location = New System.Drawing.Point(219, 234)
        Me.dtpFechaL.Name = "dtpFechaL"
        Me.dtpFechaL.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaL.TabIndex = 5
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(289, 328)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 6
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo de producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Precio de venta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha de lanzamiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Unidad de medida"
        '
        'mskCodigo
        '
        Me.mskCodigo.Location = New System.Drawing.Point(219, 93)
        Me.mskCodigo.Mask = "?0000"
        Me.mskCodigo.Name = "mskCodigo"
        Me.mskCodigo.Size = New System.Drawing.Size(135, 20)
        Me.mskCodigo.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mskCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.dtpFechaL)
        Me.Controls.Add(Me.cmbTipoP)
        Me.Controls.Add(Me.cmbUnidadM)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtProducto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents cmbUnidadM As ComboBox
    Friend WithEvents cmbTipoP As ComboBox
    Friend WithEvents dtpFechaL As DateTimePicker
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mskCodigo As MaskedTextBox
End Class
