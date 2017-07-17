
Imports System.ComponentModel

Public Class CTelefono

	Implements INotifyPropertyChanged
	Private _nombre As String = "Un Nombre"
	Private _telefono As Decimal = "000000000"

	Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

	Private Sub NotificarCambio(nombreProp As String)

		RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(nombreProp))

	End Sub

	Public Property Nombre() As String
		Get
			Return _nombre
		End Get
		Set(value As String)
			_nombre = value
			NotificarCambio("Nombre")
		End Set
	End Property

	Public Property Telefono() As Decimal
		Get
			Return _telefono
		End Get
		Set(value As Decimal)
			_telefono = value
			NotificarCambio("Telefono")
		End Set
	End Property

End Class
