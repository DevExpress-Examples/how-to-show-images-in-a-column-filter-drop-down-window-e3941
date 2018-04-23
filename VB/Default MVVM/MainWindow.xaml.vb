' Developer Express Code Central Example:
' How to show images in a column filter drop-down window
' 
' You can determine your custom column filter drop-down window via the
' GridColumn.CustomColumnFilterPopupTemplate property
' (ms-help://DevExpress.NETv11.2/DevExpress.Wpf/DevExpressXpfGridColumnBase_CustomColumnFilterPopupTemplatetopic.htm).
' In this case, the GridColumn.FilterPopupMode property
' (ms-help://DevExpress.NETv11.2/DevExpress.Wpf/DevExpressXpfGridColumnBase_FilterPopupModetopic.htm)
' should be set to Custom. Simply place ListBoxEdit within DataTemplate and
' override its ItemTemplate property, so it is possible to show an image along
' with a text for every item.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3941


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DXWpfApplication
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Editors

Namespace Default_MVVM
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			DataContext = New TestDataViewsModel()
		End Sub
	End Class
End Namespace
