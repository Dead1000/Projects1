using System;

using Xamarin.Forms;

namespace witzemap
{
    public class App : Application
    {
        public App()
        {
            var witze1 = new Button
            {
                Text = "Witze",
                BackgroundColor = Color.Black,
                TextColor = Color.White
            };

            MainPage = new ContentPage
            {
                Content = witze1
            };

        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
            
        }
    }
}

