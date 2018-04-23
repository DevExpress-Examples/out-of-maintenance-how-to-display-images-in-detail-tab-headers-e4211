Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid

Namespace S133193Example
	Friend Class CustomGridViewRegistrator
		Inherits GridInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomGridView"
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As DevExpress.XtraGrid.GridControl) As DevExpress.XtraGrid.Views.Base.BaseView
			Return New CustomGridView(TryCast(grid, GridControl))
		End Function
	End Class
End Namespace
