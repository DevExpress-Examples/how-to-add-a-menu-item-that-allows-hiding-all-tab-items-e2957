Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core
Imports System
Imports System.Reflection

Namespace WpfApplication3
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			AddHandler DXTabControl.TabShown, AddressOf DXTabControl_TabShown
		End Sub


		Private Sub DXTabControl_TabShown(ByVal sender As Object, ByVal e As TabControlTabShownEventArgs)
			Dim tabItem = DXTabControl.Items(e.TabIndex)
			If DXTabItem IsNot tabItem Then
				Return
			End If
			For Each item As DXTabItem In DXTabControl.Items
				DXTabControl.HideTabItem(item)
			Next item
			CloseHeaderMenu()
		End Sub

		Private Sub CloseHeaderMenu()
			TryCast(DXTabControl.HeaderMenu, CustomHeaderMenu).Close()
		'    Type headerMenu = DXTabControl.HeaderMenu.GetType();
			'MethodInfo mi = headerMenu.GetMethod("PopupClose", BindingFlags.NonPublic | BindingFlags.Instance);
			'mi.Invoke(DXTabControl.HeaderMenu, null);
		End Sub
	End Class
End Namespace
