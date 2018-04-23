Imports Microsoft.VisualBasic
Imports System
Namespace S133193Example
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.customGridControl2 = New S133193Example.CustomGridControl()
			Me.customGridView1 = New S133193Example.CustomGridView()
			CType(Me.customGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customGridControl2
			' 
			Me.customGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customGridControl2.Location = New System.Drawing.Point(0, 0)
			Me.customGridControl2.MainView = Me.customGridView1
			Me.customGridControl2.Name = "customGridControl2"
			Me.customGridControl2.Size = New System.Drawing.Size(853, 535)
			Me.customGridControl2.TabIndex = 0
			Me.customGridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.customGridView1})
			' 
			' customGridView1
			' 
			Me.customGridView1.GridControl = Me.customGridControl2
			Me.customGridView1.Name = "customGridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(853, 535)
			Me.Controls.Add(Me.customGridControl2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.customGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customGridControl2 As CustomGridControl
		Private customGridView1 As CustomGridView

	End Class
End Namespace

