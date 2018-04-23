Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections
Imports S133193Example
Imports System.Reflection
Imports System.IO

Namespace S133193Example
    Partial Public Class Form1
        Inherits Form


        Public Sub New()
            InitializeComponent()
            dataBase = DataHelper.CreateDataBase()
            customGridControl2.DataSource = dataBase.Tables(0)
            AddHandler customGridView1.GetTabImage, AddressOf GetTabImage
        End Sub
        Private dataBase As DataSet

        Private Enum CustomerType
            Person
            Company
        End Enum

        Private Sub GetTabImage(ByVal sender As Object, ByVal e As DrawTabImageEventArgs)
            Dim value As CustomerType = CType(customGridView1.GetRowCellValue(e.RowHandle, customGridView1.Columns("CustomerType")), CustomerType)
            If e.RelationIndex = 0 Then
                Select Case value
                    Case CustomerType.Person
                        e.Image = GetImageByName(e, "Person.bmp")
                    Case CustomerType.Company
                        e.Image = GetImageByName(e, "Company.png")
                    Case Else
                End Select
            Else
                e.Image = GetImageByName(e, "Delivered.png")
            End If
        End Sub

        Private Function GetImageByName(ByVal e As DrawTabImageEventArgs, ByVal imageName As String) As Image
            Dim executing_assemly As [Assembly] = [Assembly].GetExecutingAssembly()
            Dim ImageStream As Stream = executing_assemly.GetManifestResourceStream(imageName)
            Dim bm As Image
            bm = Image.FromStream(ImageStream)

            Return bm

        End Function

    End Class
End Namespace
