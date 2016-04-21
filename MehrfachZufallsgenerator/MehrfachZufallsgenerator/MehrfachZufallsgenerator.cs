using System;

using Xamarin.Forms;

namespace MehrfachZufallsgenerator
{
    public class App : Application
    {

        public App()
        {
            var Ergebnis = "Versuch es!";

            var Kopf = new Button
            {
                Text = "Kopf",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var Reset = new Button
            {
                Text = "Reset",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var Zahl = new Button
            {
                Text = "Zahl",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var Label = new Label
            {
                Text = Ergebnis,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };


            MainPage = new ContentPage
            {
                Content = new StackLayout
                {

                    Children =
                    {
                        Kopf, Reset, Zahl, Label,


                    }
                }
                        
            };
		
		
		
            var spintowin = new Random();
            var zufallsnummer = spintowin.Next(0, 2);
           

            Kopf.Clicked += delegate
            {
                if (zufallsnummer == 0)
                {
                    Ergebnis = "Gewonnen!";
                }
                else
                {
                    Ergebnis = "Verloren!";
                }
                Label.Text = Ergebnis;
            };


            Zahl.Clicked += delegate
            {
                if (zufallsnummer == 1)
                {
                    Ergebnis = "Gewonnen!";
                }
                else
                {
                    Ergebnis = "Verloren!";
                }
                Label.Text = Ergebnis;
            };
      
            Reset.Clicked += delegate
            {
                spintowin = new Random();
                zufallsnummer = spintowin.Next(0, 2);
                if (Ergebnis != "")
                {
                    Ergebnis = "Versuch es!";
					
                }
                Label.Text = Ergebnis;
            };
        }

		
		
		



      

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
	
        }
	
	
        //	}
        //	public class Layoutstack: StackLayout
        //	{
        //		public Layoutstack()
        //		{
        //			HeightRequest = 70;
        //			Spacing = 5;
        //			Orientation = StackOrientation.Horizontal;
        //
        //			Children.Add(new StackLayout{
        //				Spacing = 2,
        //				WidthRequest = 0,
        //				HorizontalOptions = LayoutOptions.FillAndExpand ,
        //				Children = {
        //					new Button("Kopf"),
        //					new Button("Reset"),
        //					new Button("Zahl"),
        //				},
        //			});
        //		}


        //                    VerticalOptions = LayoutOptions.Center,
        //                    Children =
        //                    {
        ////                        new Button()
        ////                        {
        ////                            Text = "Kopf",
        ////                        },
        ////                        new Button()
        ////                        {
        ////                            Text = "Reset",
        ////                        },
        ////                        new Button()
        ////                        {
        ////                            Text = "Zahl",
        //
        //                        },
    }
}