using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestPlaceholderProblem
{
    public class MainPageViewModel: DevExpress.Maui.Core.BindableBase
    {

        public class Product
        {
            public string? Code { get; set; }
            public string? DisplayedProduct { get; set; }
        }

        public ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                RaisePropertyChanged(nameof(Products));
            }
        }

        public MainPageViewModel()
        {
            Products = new ObservableCollection<Product>();
            Products.Add(new Product { Code = "1001", DisplayedProduct = "Product1" });
            Products.Add(new Product { Code = "1002", DisplayedProduct = "Product2" });
        }


        public class BindableBase : INotifyPropertyChanging, INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler? PropertyChanged;

            public event System.ComponentModel.PropertyChangingEventHandler? PropertyChanging;

            public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
