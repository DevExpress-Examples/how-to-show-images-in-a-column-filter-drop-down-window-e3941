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
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Windows.Data;
using DevExpress.Xpf.Grid;
using System.Collections;
using DevExpress.Data.Filtering.Helpers;
using System.ComponentModel;
using DevExpress.Data.Filtering;
using DXWpfApplication;
using System.Collections.ObjectModel;

namespace Default_MVVM
{
    public class FilterPopupConverter : MarkupExtension, IValueConverter
    {

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            GridControl grid = value as GridControl;
            ObservableCollection<TestDataViewModel> source = grid.ItemsSource as ObservableCollection<TestDataViewModel>;
            source = GetUniqueValues(source);
            if (source != null && source.Count > 0)
            {

                GridColumn column = grid.Columns["Number"];
                if (grid.IsFilterEnabled && !column.IsFiltered)
                {
                    PropertyDescriptorCollection descriptors = TypeDescriptor.GetProperties(source[0].GetType());
                    ExpressionEvaluator evaluator = new ExpressionEvaluator(descriptors, grid.FilterCriteria);
                    return evaluator.Filter(source);
                }
                return source;
            }
            return null;
        }

        ObservableCollection<TestDataViewModel> GetUniqueValues(ObservableCollection<TestDataViewModel> source)
        {
            ObservableCollection<TestDataViewModel> uniqueValues = new ObservableCollection<TestDataViewModel>();
            foreach (TestDataViewModel dataRow in source)
            {
                if (uniqueValues.Where(val => val.Number.Equals(dataRow.Number)).Count() == 0)
                    uniqueValues.Add(dataRow);
            }
            return uniqueValues;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CriteriaOperatorConverter : MarkupExtension, IMultiValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            BinaryOperator op = values[0] as BinaryOperator;
            if (object.ReferenceEquals(op, null))
                return null;
            OperandValue operandValue = op.RightOperand as OperandValue;
            return operandValue.Value;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Int32)
                return new object[] { new BinaryOperator("Number", (int)value, BinaryOperatorType.Equal), false };
            return new object[]{null, true};
        }
    }
}
