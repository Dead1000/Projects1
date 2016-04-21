using System;
using Xamarin.Forms;

namespace münzwurf
{
	public class App : Application
	{
		public App ()
		{
			var Bild1 = new FileImageSource {
				File = "Bild1.png"
			};
			var Bild2 = new FileImageSource {
				File = "Bild2.jpg"
			};

			var Ergebnis = new FileImageSource ();

			var Münzen = new Button {
				TextColor = Color.Black,
				BackgroundColor = Color.White,
				Text = "lol",


			};

			Münzen.Clicked += delegate {
				var spintowin = new Random();
				var zufallsnummer = spintowin.Next(0,2);

				if (zufallsnummer == 0) {
					Ergebnis = Bild1;
			}else{
					Ergebnis = Bild2;
				}
				Münzen.Image = Ergebnis;
			};

			MainPage = new ContentPage {
				Content = Münzen,
				BackgroundColor = Color.Black
			};

		
		
		
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