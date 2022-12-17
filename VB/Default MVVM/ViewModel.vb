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
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace DXWpfApplication

    'Model
    Public Class TestData

        Public Property Text As String

        Public Property Number As Integer

        Public Property Image As Uri
    End Class

    'Base View Model
    Public MustInherit Class BaseViewModel
        Implements INotifyPropertyChanged

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    'View Model
    Public Class TestDataViewModel
        Inherits BaseViewModel

        Private data As TestData

        Public Sub New(ByVal data As TestData)
            Me.data = data
        End Sub

        Public Sub New()
            Me.New(New TestData())
        End Sub

        Public Property Text As String
            Get
                Return data.Text
            End Get

            Set(ByVal value As String)
                If Not Equals(data.Text, value) Then
                    data.Text = value
                    OnPropertyChanged("Text")
                End If
            End Set
        End Property

        Public Property Number As Integer
            Get
                Return data.Number
            End Get

            Set(ByVal value As Integer)
                If data.Number <> value Then
                    data.Number = value
                    OnPropertyChanged("Number")
                End If
            End Set
        End Property

        Public Property Image As Uri
            Get
                Return data.Image
            End Get

            Set(ByVal value As Uri)
                If data.Image IsNot value Then
                    data.Image = value
                    OnPropertyChanged("Image")
                End If
            End Set
        End Property
    End Class

    'Views Model
    Public Class TestDataViewsModel
        Inherits BaseViewModel

        Public Sub New()
            Records = New ObservableCollection(Of TestDataViewModel)()
            Dim list As List(Of TestData) = New List(Of TestData)()
            For i As Integer = 1 To 50 - 1
                Records.Add(New TestDataViewModel(New TestData() With {.Text = "Row" & i, .Number = i, .Image = New Uri(String.Format("/Resources/{0}.jpg", i Mod 7 + 1), UriKind.Relative)}))
            Next
        End Sub

        Private recordsField As ObservableCollection(Of TestDataViewModel)

        Public Property Records As ObservableCollection(Of TestDataViewModel)
            Get
                Return recordsField
            End Get

            Set(ByVal value As ObservableCollection(Of TestDataViewModel))
                If recordsField IsNot value Then
                    recordsField = value
                    OnPropertyChanged("Records")
                End If
            End Set
        End Property
    End Class
End Namespace
