Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Tab


Namespace S133193Example
	<System.ComponentModel.DesignerCategory("")> _
	Public Class CustomGridView
		Inherits GridView
		Public Sub New()
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub
		Public Delegate Sub DrawTabImageHandler(ByVal sender As Object, ByVal e As DrawTabImageEventArgs)
		Public Event GetTabImage As DrawTabImageHandler
		Public Overridable Sub OnDrawTabImage(ByVal e As DrawTabImageEventArgs)
			RaiseEvent GetTabImage(Me, e)

		End Sub

		Protected Overrides Sub PopulateTabMasterData(ByVal tabControl As DevExpress.XtraGrid.Tab.ViewTab, ByVal rowHandle As Integer)
			Dim pages As New List(Of CustomViewTabPage)()
			MyBase.PopulateTabMasterData(tabControl, rowHandle)
			For Each page As ViewTabPage In tabControl.Pages
				Dim cPage As New CustomViewTabPage(tabControl)
				cPage.DetailInfo = page.DetailInfo
				cPage.Tag = page.Tag
				cPage.Text = page.Text
				cPage.Image = GetPageImage(rowHandle,CInt(Fix(cPage.Tag)))
				pages.Add(cPage)
			Next page
			tabControl.Pages.Clear()
			For Each cPage As CustomViewTabPage In pages
				tabControl.Pages.Add(cPage)
			Next cPage
		End Sub

		Private Function GetPageImage(ByVal rowHandle As Integer, ByVal relationIndex As Integer) As Image
			Dim args As New DrawTabImageEventArgs(rowHandle, Nothing,relationIndex)
			OnDrawTabImage(args)
				Return args.Image
		End Function

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomGridView"
			End Get
		End Property



	End Class
End Namespace
