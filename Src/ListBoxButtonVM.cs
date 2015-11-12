using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfTest
{
    public class ListBoxButtonVM : ViewModelBase
    {
        public ObservableCollection<ListBoxButtonItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                RaisePropertyChanged("Samples");
            }
        }
        private ObservableCollection<ListBoxButtonItem> _items = new ObservableCollection<ListBoxButtonItem>();

        public void Initialize()
        {
            Items.Add(new ListBoxButtonItem("a"));
            Items.Add(new ListBoxButtonItem("b"));
        }

    }

    public class ListBoxButtonItem
    {
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }
        private string _name;

        public ListBoxButtonItem(string name)
        {
            Name = name;
        }
    }
}
