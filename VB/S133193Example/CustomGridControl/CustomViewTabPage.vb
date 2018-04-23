Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Tab
Imports DevExpress.XtraTab
Imports System.Drawing

Namespace S133193Example
	Public Class CustomViewTabPage
		Inherits ViewTabPage
		Implements IXtraTabPage

		Public Sub New(ByVal tabControl As ViewTab)
			MyBase.New(tabControl)
		End Sub
		Private privateImage As Image
        Public Property Image() As Image
            Get
                Return privateImage
            End Get
            Set(ByVal value As Image)
                privateImage = value
            End Set
        End Property
        Private ReadOnly Property IXtraTabPage_Image() As Image Implements IXtraTabPage.Image
            Get
                Return Image
            End Get
        End Property
    End Class
End Namespace
