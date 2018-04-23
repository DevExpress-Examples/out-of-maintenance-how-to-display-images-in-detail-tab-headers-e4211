Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing

Namespace S133193Example
   Public Class DrawTabImageEventArgs
	   Inherits EventArgs

	   Private privateRowHandle As Integer
	   Public Property RowHandle() As Integer
		   Get
			   Return privateRowHandle
		   End Get
		   Set(ByVal value As Integer)
			   privateRowHandle = value
		   End Set
	   End Property
	   Private privateImage As Image
	   Public Property Image() As Image
		   Get
			   Return privateImage
		   End Get
		   Set(ByVal value As Image)
			   privateImage = value
		   End Set
	   End Property
	   Private privateRelationIndex As Integer
	   Public Property RelationIndex() As Integer
		   Get
			   Return privateRelationIndex
		   End Get
		   Set(ByVal value As Integer)
			   privateRelationIndex = value
		   End Set
	   End Property

        Public Sub New(ByVal _rowHandle As Integer, ByVal _image As Image, ByVal _relationIndex As Integer)
            RowHandle = _rowHandle
            Image = _image
            RelationIndex = _relationIndex
        End Sub
   End Class
End Namespace
