using System;

using Xamarin.Forms;

namespace trollapp
{
	public class App : Application
	{
		public App ()
		{
			var animationbutton = new Button {
				Text = "GETROLLT!",
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};
			// The root page of your application
			MainPage = new ContentPage { 
				Content = animationbutton,
				BackgroundColor = Color.Black
					};

			animationbutton.Command = new Command (async () => {
				animationbutton.ScaleTo (10, 1000, Easing.CubicInOut);
				await animationbutton.RotateTo (2500000, 1000, Easing.CubicInOut);
				animationbutton.ScaleTo (1, 1000, Easing.CubicInOut);
				await animationbutton.RotateTo (2, 1000, Easing.CubicInOut);
			});
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//						new Label {
//							XAlign = TextAlignment.Center,
//							Text = "ne Getrollte app!"
						

		}


		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

