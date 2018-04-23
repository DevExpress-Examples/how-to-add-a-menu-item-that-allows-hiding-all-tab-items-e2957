Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Core
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WpfApplication3
	Public Class CustomHeaderMenu
		Inherits HeaderMenu
		Public Sub Close()
			PopupClose()
		End Sub
	End Class
End Namespace
