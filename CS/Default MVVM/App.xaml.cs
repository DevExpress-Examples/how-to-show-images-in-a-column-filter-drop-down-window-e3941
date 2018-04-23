// Developer Express Code Central Example:
// How to show images in a column filter drop-down window
// 
// You can determine your custom column filter drop-down window via the
// GridColumn.CustomColumnFilterPopupTemplate property
// (ms-help://DevExpress.NETv11.2/DevExpress.Wpf/DevExpressXpfGridColumnBase_CustomColumnFilterPopupTemplatetopic.htm).
// In this case, the GridColumn.FilterPopupMode property
// (ms-help://DevExpress.NETv11.2/DevExpress.Wpf/DevExpressXpfGridColumnBase_FilterPopupModetopic.htm)
// should be set to Custom. Simply place ListBoxEdit within DataTemplate and
// override its ItemTemplate property, so it is possible to show an image along
// with a text for every item.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3941

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Default_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}
