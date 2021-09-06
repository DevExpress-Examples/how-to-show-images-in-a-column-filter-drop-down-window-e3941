<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653047/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3941)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [FilterPopupConverter.cs](./CS/Default MVVM/FilterPopupConverter.cs) (VB: [FilterPopupConverter.vb](./VB/Default MVVM/FilterPopupConverter.vb))
* [MainWindow.xaml](./CS/Default MVVM/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Default MVVM/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/Default MVVM/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Default MVVM/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/Default MVVM/ViewModel.cs) (VB: [ViewModel.vb](./VB/Default MVVM/ViewModel.vb))
<!-- default file list end -->
# How to show images in a column filter drop-down window


<p>You can determine your custom column filter drop-down window via the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridColumnBase_CustomColumnFilterPopupTemplatetopic"><u>GridColumn.CustomColumnFilterPopupTemplate property</u></a>. In this case, the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridColumnBase_FilterPopupModetopic"><u>GridColumn.FilterPopupMode property</u></a> should be set to Custom. </p><p>Simply place ListBoxEdit within DataTemplate and override its ItemTemplate property, so it is possible to show an image along with a text for every item. </p><br />
<br />


<br/>


