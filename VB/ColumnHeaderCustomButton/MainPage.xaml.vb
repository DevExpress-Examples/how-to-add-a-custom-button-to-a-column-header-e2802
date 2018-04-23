Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls

Namespace ColumnHeaderCustomButton
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New ProductList()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' Process mouse clicks.
		End Sub
	End Class
End Namespace
