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
Imports System.Windows.Markup
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports System.Collections
Imports DevExpress.Data.Filtering.Helpers
Imports System.ComponentModel
Imports DevExpress.Data.Filtering
Imports DXWpfApplication
Imports System.Collections.ObjectModel

Namespace Default_MVVM
	Public Class FilterPopupConverter
		Inherits MarkupExtension
		Implements IValueConverter

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim grid As GridControl = TryCast(value, GridControl)
			Dim source As ObservableCollection(Of TestDataViewModel) = TryCast(grid.ItemsSource, ObservableCollection(Of TestDataViewModel))
			source = GetUniqueValues(source)
			If source IsNot Nothing AndAlso source.Count > 0 Then

				Dim column As GridColumn = grid.Columns("Number")
				If grid.IsFilterEnabled AndAlso (Not column.IsFiltered) Then
					Dim descriptors As PropertyDescriptorCollection = TypeDescriptor.GetProperties(source(0).GetType())
					Dim evaluator As New ExpressionEvaluator(descriptors, grid.FilterCriteria)
					Return evaluator.Filter(source)
				End If
				Return source
			End If
			Return Nothing
		End Function

		Private Function GetUniqueValues(ByVal source As ObservableCollection(Of TestDataViewModel)) As ObservableCollection(Of TestDataViewModel)
			Dim uniqueValues As New ObservableCollection(Of TestDataViewModel)()
			For Each dataRow As TestDataViewModel In source
				If uniqueValues.Where(Function(val) val.Number.Equals(dataRow.Number)).Count() = 0 Then
					uniqueValues.Add(dataRow)
				End If
			Next dataRow
			Return uniqueValues
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class

	Public Class CriteriaOperatorConverter
		Inherits MarkupExtension
		Implements IMultiValueConverter
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function

		Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
			Dim op As BinaryOperator = TryCast(values(0), BinaryOperator)
			If Object.ReferenceEquals(op, Nothing) Then
				Return Nothing
			End If
			Dim operandValue As OperandValue = TryCast(op.RightOperand, OperandValue)
			Return operandValue.Value
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
			If TypeOf value Is Int32 Then
				Return New Object() { New BinaryOperator("Number", CInt(Fix(value)), BinaryOperatorType.Equal), False }
			End If
			Return New Object(){Nothing, True}
		End Function
	End Class
End Namespace
