using MauiCarouselView.Models;

namespace MauiCarouselView.Pages;

public partial class CarouselViewDemo : ContentPage
{
	public CarouselViewDemo()
	{
		
		InitializeComponent();

        var items = new List<CarouselItems>
        {
            new CarouselItems{title="Utens", Description="Welcome to Utens Code"},
            new CarouselItems{title="Title 2", Description="Description 2"},
            new CarouselItems{title="Title 3", Description="Description 3"},
            new CarouselItems{title="Title 4", Description="Description 4"},
            new CarouselItems{title="Title 5", Description="Description 5"}
        };

        carouselView.ItemsSource = items;

    }
}