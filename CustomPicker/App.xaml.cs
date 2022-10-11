using CustomPicker.Controls;

namespace CustomPicker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        ModifyPicker();

        MainPage = new AppShell();
	}
    static void ModifyPicker()
    {
        Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
            if (view is PickerBorderless)
            {
#if ANDROID
                handler.PlatformView.Background = null;
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif IOS || MACCATALYST
                //handler.PlatformView.Background = UIKit.UIColor.Clear;
                handler.PlatformView.Layer.BorderWidth = 0;
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
                
                handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                //handler.PlatformView.BorderBrush = null;
                //handler.PlatformView.Margin = new Microsoft.UI.Xaml.Thickness(0);
                //handler.PlatformView.Padding = new Microsoft.UI.Xaml.Thickness(0);
#endif
            }
        });
    }
}
