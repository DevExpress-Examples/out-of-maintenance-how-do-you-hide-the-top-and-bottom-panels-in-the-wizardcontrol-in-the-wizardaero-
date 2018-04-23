Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
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
			Me.wizardControl1 = New WindowsApplication3.MyWizardControl()
			Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
			Me.wizardPage1 = New DevExpress.XtraWizard.WizardPage()
			Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.wizardControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' wizardControl1
			' 
			Me.wizardControl1.AllowPagePadding = False
			Me.wizardControl1.Controls.Add(Me.welcomeWizardPage1)
			Me.wizardControl1.Controls.Add(Me.wizardPage1)
			Me.wizardControl1.Controls.Add(Me.completionWizardPage1)
			Me.wizardControl1.Name = "wizardControl1"
			Me.wizardControl1.NavigationMode = DevExpress.XtraWizard.NavigationMode.Stacked
			Me.wizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() { Me.welcomeWizardPage1, Me.wizardPage1, Me.completionWizardPage1})
			Me.wizardControl1.UseAcceptButton = False
			Me.wizardControl1.UseCancelButton = False
			Me.wizardControl1.UseWaitCursor = True
			Me.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
			' 
			' welcomeWizardPage1
			' 
			Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
			Me.welcomeWizardPage1.Size = New System.Drawing.Size(969, 542)
			Me.welcomeWizardPage1.UseWaitCursor = True
			' 
			' wizardPage1
			' 
			Me.wizardPage1.Name = "wizardPage1"
			Me.wizardPage1.Size = New System.Drawing.Size(969, 542)
			Me.wizardPage1.UseWaitCursor = True
			' 
			' completionWizardPage1
			' 
			Me.completionWizardPage1.Name = "completionWizardPage1"
			Me.completionWizardPage1.Size = New System.Drawing.Size(969, 542)
			Me.completionWizardPage1.UseWaitCursor = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(969, 608)
			Me.Controls.Add(Me.wizardControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.wizardControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private wizardControl1 As MyWizardControl
		Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
		Private wizardPage1 As DevExpress.XtraWizard.WizardPage
		Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
	End Class
End Namespace

