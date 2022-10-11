using CustomPicker.Models;
using CustomPicker.ViewModels;

namespace CustomPicker;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Content.BindingContext = new PickerVM();
	}
	
}

