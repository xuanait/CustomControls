using CommunityToolkit.Mvvm.ComponentModel;
using CustomPicker.Models;
using System.Collections.ObjectModel;

namespace CustomPicker.ViewModels
{
    public partial class PickerVM: ObservableObject
    {
        //[ObservableProperty]
        //private Color borderColor = Colors.Gray;

        //[ObservableProperty]
        //private string title = "Tracking Account";

        [ObservableProperty]
        private ObservableCollection<Product> products = new()
        {
            new Product(1, "TV"),
            new Product(2, "Laptop"),
            new Product(3, "Radio"),
            new Product(4, "Mug"),
            new Product(5, "Water bottle", false),
            new Product(6, "Cables"),
            new Product(7, "Coffee", false),
            new Product(8, "Biscuit", false)
        };

        [ObservableProperty]
        private string displayValue = "Name";

        [ObservableProperty]
        private int? selectedIndex;

        [ObservableProperty]
        private Product selectedItem;

    }
}
