using System;
using Xamarin.Forms;

namespace HorseShow.View
{
	public class HomePage : ContentPage
	{
		

		public HomePage ()
		{
		  

			// Accomodate iPhone status bar.
			this.Padding = new Thickness (1, Device.OnPlatform (20, 20, 0), 2, 5);
			this.BackgroundColor = Color.White;

			NavigationPage.SetHasNavigationBar(this, false);
			this.Title = "Home";
			var layout = new StackLayout
			{
				Orientation = StackOrientation.Vertical,

				Spacing = 20

			};

			var imgLogo = new Image {
				Source ="logobanner.png",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand,
				HeightRequest = 100f,
				WidthRequest = App.ScreenWidth
			};

			StackLayout stackLogo = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Start
			};
			stackLogo.Children.Add (imgLogo);

			var grid = new Grid
			{
				RowSpacing = 30,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Start
			};
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
			grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
			grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});

			var imgClasses = new Button { 				
				Image = "schedule.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			var labelClasses = new Label{
				Text = "Classes",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			imgClasses.Clicked += OnButtonClassClicked;

			StackLayout stackClasses = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackClasses.Children.Add (imgClasses);
			stackClasses.Children.Add (labelClasses);

			var imgStalls = new Button { 
				Image = "stalls.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			var labelStalls = new Label 
			{
				Text = "Stalls",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			StackLayout stackStalls = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackStalls.Children.Add (imgStalls);
			stackStalls.Children.Add (labelStalls);

			var imgPatterns = new Button { 
				Image = "patterns.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			var labelPatterns = new Label{
				Text = "Patterns",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			StackLayout stackPatterns = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackPatterns.Children.Add (imgPatterns);
			stackPatterns.Children.Add (labelPatterns);

			var imgEvents = new Button { 
				Image = "events.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			var labelEvents = new Label{
				Text = "Events",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			StackLayout stackEvents = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackEvents.Children.Add (imgEvents);
			stackEvents.Children.Add (labelEvents);

			var imgNews = new Button { 
				Image = "news.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			var labelNews = new Label{
				Text = "News",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			StackLayout stackNews = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackNews.Children.Add (imgNews);
			stackNews.Children.Add (labelNews);

			var imgShow = new Button { 
				Image = "changeshow.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			var labelShow = new Label{
				Text = "Show",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			StackLayout stackShow = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackShow.Children.Add (imgShow);
			stackShow.Children.Add (labelShow);

			var imgBusiness = new Button { 
				Image = "business.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			var labelBusiness = new Label{
				Text = "Business",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			StackLayout stackBusiness = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackBusiness.Children.Add (imgBusiness);
			stackBusiness.Children.Add (labelBusiness);

			var imgMaps = new Button { 
				Image = "map.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Start
			};
			var labelMaps = new Label{
				Text = "Maps",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			StackLayout stackMaps = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackMaps.Children.Add (imgMaps);
			stackMaps.Children.Add (labelMaps);

			var imgMore = new Button { 
				Image = "more.png",
				HeightRequest = 60f,
				WidthRequest = 60f,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			var labelMore = new Label{
				Text = "More...",
				TextColor = Color.Blue,
				HorizontalTextAlignment=TextAlignment.Center
			};
			StackLayout stackMore = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				Padding=0
			};
			stackMore.Children.Add (imgMore);
			stackMore.Children.Add (labelMore);

			grid.Children.Add(stackClasses, 0, 0);
			grid.Children.Add(stackStalls, 1, 0);
			grid.Children.Add(stackPatterns, 2, 0);
			grid.Children.Add(stackEvents, 0, 1);
			grid.Children.Add(stackNews, 1, 1);
			grid.Children.Add(stackShow, 2, 1);
			grid.Children.Add(stackBusiness, 0, 2);
			grid.Children.Add(stackMaps, 1, 2);
			grid.Children.Add(stackMore, 2, 2);

			StackLayout gridLayout = new StackLayout {
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Start,

			};
			gridLayout.Children.Add (grid);

			layout.Children.Add (stackLogo);
			layout.Children.Add (gridLayout);

			Content = layout;
		}

		async void OnButtonClassClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ClassesGroup());
		}

	}
}

