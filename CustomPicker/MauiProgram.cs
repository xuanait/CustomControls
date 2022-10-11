using CommunityToolkit.Maui;

namespace CustomPicker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
#if DEBUG
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkit()
#else
			.UseMauiCommunityToolkit(options =>
			{
				options.SetShouldSuppressExceptionsInConverters(false);
				options.SetShouldSuppressExceptionsInBehaviors(false);
				options.SetShouldSuppressExceptionsInAnimations(false);
			})
			.UseMauiCommunityToolkit(options =>
			{
				options.SetShouldSuppressExceptionsInConverters(false);
				options.SetShouldSuppressExceptionsInBehaviors(false);
				options.SetShouldSuppressExceptionsInAnimations(false);
			})
#endif
            .UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
