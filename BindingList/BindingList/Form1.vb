Imports System.ComponentModel

Public Class Form1

	Private colTfnos As BindingList(Of CTelefono)

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		colTfnos = FactoriaTelefono.ObtenerColeccionCTelefono()
		listTfnos.DataSource = colTfnos
		listTfnos.DisplayMember = "Nombre"
		ctTfnoSelec.DataBindings.Add("Text", colTfnos, "Telefono")

	End Sub

	Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click

		Dim tef As Decimal = 0
		If ctNombre.Text.Length <> 0 AndAlso ctTfno.Text.Length <> 0 AndAlso Decimal.TryParse(ctTfno.Text, tef) Then

			colTfnos.Add(FactoriaTelefono.CrearCTelefono(ctNombre.Text, tef))

		End If

	End Sub

	Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click

		Dim pos As Integer = listTfnos.SelectedIndex
		If pos < 0 Then Return
		colTfnos.RemoveAt(pos)

	End Sub

	Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click

		Dim pos As Integer = listTfnos.SelectedIndex

		If ctNombre.Text.Length <> 0 Then

			colTfnos(pos).Nombre = ctNombre.Text

		End If

		Dim tef As Decimal = 0
		If ctTfno.Text.Length <> 0 AndAlso Decimal.TryParse(ctTfno.Text, tef) Then

			colTfnos(pos).Telefono = tef

		End If

	End Sub
End Class
