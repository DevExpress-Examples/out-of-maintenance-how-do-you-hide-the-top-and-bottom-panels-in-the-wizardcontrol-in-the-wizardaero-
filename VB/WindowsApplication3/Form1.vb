Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraWizard

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class MyWizardControl
		Inherits WizardControl
		Protected Overrides Function CreateViewInfo() As WizardViewInfo
			Return New MyWizardViewInfo(Me)
		End Function

	End Class
	Public Class MyWizardViewInfo
		Inherits WizardViewInfo
		Public Sub New(ByVal w As MyWizardControl)
			MyBase.New(w)
		End Sub
		Protected Overrides Function CreateWizardModelCore(ByVal style As WizardStyle) As WizardViewInfo.WizardModelBase
            If style = WizardStyle.WizardAero Then
                Return New MyWizardAeroModel(Me)
            End If
			Return MyBase.CreateWizardModelCore(style)
		End Function
	End Class
	Public Class MyWizardAeroModel
		Inherits DevExpress.XtraWizard.WizardViewInfo.WizardAeroModel
		Public Sub New(ByVal v As MyWizardViewInfo)
			MyBase.New(v)
		End Sub

		Public Overrides Function GetContentBounds() As Rectangle
			Dim rect As Rectangle = GetClientRectangle()
			rect.Y -= WizardAeroConsts.TitleBarHeight
			rect.Height += WizardAeroConsts.TitleBarHeight
			Return rect
		End Function

		Public Overrides Function GetTitleBarBounds() As Rectangle
			Return Rectangle.Empty
		End Function
	End Class
End Namespace
