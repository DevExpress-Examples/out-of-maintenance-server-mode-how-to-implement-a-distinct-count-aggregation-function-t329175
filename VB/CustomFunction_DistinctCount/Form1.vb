Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace XPG_ServerMode_EF
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New DistinctCountFunction())
			InitializeComponent()
			entityServerModeSource1.QueryableSource = New NorthwindEntities().Invoices
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pivotGridControl1.BestFit()
		End Sub
	End Class


End Namespace
