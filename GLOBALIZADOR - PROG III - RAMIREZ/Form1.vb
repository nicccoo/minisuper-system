Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()



        Dim CadenaSQL As String
        Dim Tabla As DataTable

        CadenaSQL = "SELECT * FROM Productos Order by Producto asc"
        Tabla = New DataTable
        Recuperar(CadenaSQL, Tabla)

        cmbTipoP.DataSource = Tabla
        cmbTipoP.DisplayMember = "Producto"
        cmbTipoP.ValueMember = "IdTipoDeProducto"
        cmbTipoP.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipoP.SelectedIndex = 0

        Dim Archivo As FileStream
        Dim Lector As StreamReader
        Dim linea As String



        Archivo = New FileStream("Unidades.txt", FileMode.Open)
        Lector = New StreamReader(Archivo)

        While Lector.EndOfStream = False

            linea = Lector.ReadLine()

            With cmbUnidadM

                cmbUnidadM.Items.Add(linea)

            End With

        End While
        cmbUnidadM.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUnidadM.SelectedIndex = 0


        txtProducto.MaxLength = 30

        mskCodigo.MaxLength = 5 'PARA UTILIZARLA DEBE SELECCIONAR AL PRINCIPIO DEL MASKEDBOX
        dtpFechaL.Format = DateTimePickerFormat.Custom
        dtpFechaL.CustomFormat = "dd/MM/yy"
        dtpFechaL.MaxDate = DateTime.Today


    End Sub

    Private Function Validar() As Boolean
        Dim CadenaSQL As String
        Dim Tabla As DataTable
        Dim TodoOk As Boolean
        Dim Numero As Integer

        TodoOk = False

        If txtPrecio.Text.Trim <> String.Empty Then
            If Integer.TryParse(txtPrecio.Text, Numero) Then
                If Numero > 0 Then
                    CadenaSQL = "Select * from Productos where Codigo ='" & mskCodigo.Text.Trim & "'"
                    Tabla = New DataTable
                    Recuperar(CadenaSQL, Tabla)
                    If Tabla.Rows.Count = 0 Then
                        TodoOk = True
                    Else
                        MessageBox.Show("El codigo ingresado se encuentra asignado", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    MessageBox.Show("El precio debe ser mayor a 0", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("El precio debe ser numerico", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No ingreso precio", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return TodoOk
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim CadenaSQL As String

        If Validar() Then

            CadenaSQL = "INSERT INTO Productos(Codigo, Producto, IdTipoDeProducto, PrecioVenta, FechaLanzamiento, UnidadMedida)"
            CadenaSQL = CadenaSQL & " VALUES('" & mskCodigo.Text.Trim & "','" & txtProducto.Text.Trim & "'," & cmbTipoP.SelectedValue & ","
            CadenaSQL = CadenaSQL & txtPrecio.Text.Trim & ",'" & dtpFechaL.Value.ToShortDateString & "','" & cmbUnidadM.SelectedValue & "')"


            Try

                Ejecutar(CadenaSQL)
                MessageBox.Show("Producto registrado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mskCodigo.Text = String.Empty
                txtPrecio.Text = String.Empty
                txtProducto.Text = String.Empty
                cmbTipoP.Focus()

            Catch ex As Exception

                MessageBox.Show("La operación fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


        End If

    End Sub

    Private Sub mskCodigo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskCodigo.MaskInputRejected
        Me.Focus()
    End Sub
End Class
