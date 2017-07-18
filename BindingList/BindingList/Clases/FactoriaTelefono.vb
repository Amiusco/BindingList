
Imports System.ComponentModel

Public Class FactoriaTelefono

	Private Shared _telefonos As BindingList(Of CTelefono)

	'Nuevo CTelefono
	Public Shared Function CrearCTelefono(nom As String, tfn As Decimal) As CTelefono

		Dim tfno As New CTelefono()
		tfno.Nombre = nom
		tfno.Telefono = tfn

		Return tfno

	End Function

	Public Shared Function ObtenerColeccionCTelefono() As BindingList(Of CTelefono)

		_telefonos = New BindingList(Of CTelefono)()
		Dim rnd As New Random()
		For i As Integer = 1 To 9
			_telefonos.Add(CrearCTelefono("Persona " & i, rnd.Next(191000000, 191999999)))
		Next
		Return _telefonos
	End Function

End Class
