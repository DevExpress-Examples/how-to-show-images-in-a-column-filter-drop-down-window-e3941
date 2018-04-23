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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DXWpfApplication
{
    //Model
    public class TestData
    {
        public string Text { get; set; }
        public int Number { get; set; }
        public Uri Image { get; set; }
    }

    //Base View Model

    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    //View Model
    public class TestDataViewModel : BaseViewModel
    {

        TestData data;
        public TestDataViewModel(TestData data)
        {
            this.data = data;
        }

        public TestDataViewModel() : this(new TestData()) { }

        public string Text
        {
            get { return data.Text; }
            set
            {
                if (data.Text != value)
                {
                    data.Text = value;
                    OnPropertyChanged("Text");
                }
            }
        }

        public int Number
        {
            get { return data.Number; }
            set
            {
                if (data.Number != value)
                {
                    data.Number = value;
                    OnPropertyChanged("Number");
                }
            }
        }

        public Uri Image
        {
            get { return data.Image; }
            set
            {
                if (data.Image != value)
                {
                    data.Image = value;
                    OnPropertyChanged("Image");
                }
            }
        }
    }

    //Views Model
    public class TestDataViewsModel : BaseViewModel
    {
        public TestDataViewsModel()
        {
            Records = new ObservableCollection<TestDataViewModel>();
            List<TestData> list = new List<TestData>();
            for (int i = 1; i < 50; i++)
                Records.Add(new TestDataViewModel(new TestData() { Text = "Row" + i, Number = i, Image = new Uri(string.Format("/Resources/{0}.jpg", i % 7 + 1), UriKind.Relative)}));
        }

        ObservableCollection<TestDataViewModel> records;

        public ObservableCollection<TestDataViewModel> Records
        {
            get { return records; }
            set
            {
                if (records != value)
                {
                    records = value;
                    OnPropertyChanged("Records");
                }
            }
        }
    }
}
