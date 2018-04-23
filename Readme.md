# How to show images in a column filter drop-down window


<p>You can determine your custom column filter drop-down window via the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridColumnBase_CustomColumnFilterPopupTemplatetopic"><u>GridColumn.CustomColumnFilterPopupTemplate property</u></a>. In this case, the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridColumnBase_FilterPopupModetopic"><u>GridColumn.FilterPopupMode property</u></a> should be set to Custom. </p><p>Simply place ListBoxEdit within DataTemplate and override its ItemTemplate property, so it is possible to show an image along with a text for every item. </p><br />
<br />


<br/>


