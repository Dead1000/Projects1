using System;

using Xamarin.Forms;

namespace Testyesno
{
    public class App : Application
    {
        public App()
        {
            var y1 = new Button
            {
                Text = "Mädchen",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
            };
   

            var n1 = new Button
            {
                Text = "Junge",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime
            };

            MainPage = new ContentPage
            {
                    Content = StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y1,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "Mädchen oder Junge?"
                        },
                        n1
                    }
                }
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

        public class pageJ1 : ContentPage
        {
            public pageJ1()
            {

                var y2 = new Button
                {
                    Text = "Nein",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                var n2 = new Button
                {
                    Text = "Ja",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y2,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "?"
                        },
                        n2
                    }
                };
            }
        }

        public class pageM1 : ContentPage
        {
            public pageM1()
            {
                var y3 = new Button
                {
                    Text = "Nein",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                var n3 = new Button
                {
                    Text = "Ja",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y3,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "?"
                        },
                        n3
                    }
                };
            }
        }

        public class pageJ2 : ContentPage
        {
            public pageJ2()
            {
                var y4 = new Button
                {
                    Text = "Nein",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                var n4 = new Button
                {
                    Text = "Ja",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y4,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "?"
                        },
                        n4
                    }
                };
            }
        }

        public class pageM2 : ContentPage
        {
            public pageM2()
            {
                var y5 = new Button
                {
                    Text = "Nein",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                var n5 = new Button
                {
                    Text = "Ja",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y5,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "?"
                        },
                        n5
                    }
                };
            }
        }

        public class pageJ3 : ContentPage
        {
            public pageJ3()
            {

                var y6 = new Button
                {
                    Text = "Nein",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                var n6 = new Button
                {
                    Text = "Ja",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y6,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "Mädchen oder Junge?"
                        },
                        n6
                    }
                };
            }
        }

        public class pageM3 : ContentPage
        {
            public pageM3()
            {
                var y7 = new Button
                {
                    Text = "Nein",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                var n7 = new Button
                {
                    Text = "Ja",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y7,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "?"
                        },
                        n7
                    }
                };
            }
        }

        public class pageJ4 : ContentPage
        {
            public pageJ4()
            {
                var y8 = new Button
                {
                    Text = "Nein",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                var n8 = new Button
                {
                    Text = "Ja",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y8,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "?"
                        },
                        n8
                    }
                };
            }
        }

        public class pageM5 : ContentPage
        {
            public pageM5()
            {
                var y9 = new Button
                {
                    Text = "Nein",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                var n9 = new Button
                {
                    Text = "Ja",
                    TextColor = Color.Green,
                    BackgroundColor = Color.Lime
                };
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        y9,
                        new Label
                        {
                            XAlign = TextAlignment.Center,
                            Text = "?"
                        },
                        n9
                    }
                };
            }
        }
    
    }
}

