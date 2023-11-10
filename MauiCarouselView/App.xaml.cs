using MauiCarouselView.Pages;

namespace MauiCarouselView;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CarouselViewDemo();
	}
}
