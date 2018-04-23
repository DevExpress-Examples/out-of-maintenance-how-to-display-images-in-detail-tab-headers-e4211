Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid

Namespace S133193Example
	<System.ComponentModel.DesignerCategory("")> _
	Friend Class CustomGridControl
		Inherits GridControl
		Protected Overrides Function CreateDefaultView() As DevExpress.XtraGrid.Views.Base.BaseView
			Return (CreateView("CustomGridView"))
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As DevExpress.XtraGrid.Registrator.InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New CustomGridViewRegistrator())
		End Sub
	End Class
End Namespace
