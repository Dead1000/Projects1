using System;
using Xamarin.Forms;

namespace HelloWorld
{
    public class App : Application
    {
        public App()
        {
            Color buttonStartColor = Color.Black;
            Color buttonChangeColor = Color.White;
		
            var changeColorButton = new Button
            {
                BackgroundColor = buttonStartColor,
                Text = "Drück mich",
                TextColor = Color.White,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            var animationbutton = new Button
            {
                Text = "GETROLLT!",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
//            var Ergebnis = "Versuch es!";
//
//            var Kopf = new Button
//            {
//                Text = "Kopf",
//                VerticalOptions = LayoutOptions.FillAndExpand,
//                HorizontalOptions = LayoutOptions.CenterAndExpand
//            };
//
//            var Reset = new Button
//            {
//                Text = "Reset",
//                VerticalOptions = LayoutOptions.FillAndExpand,
//                HorizontalOptions = LayoutOptions.CenterAndExpand
//            };
//
//            var Zahl = new Button
//            {
//                Text = "Zahl",
//                VerticalOptions = LayoutOptions.FillAndExpand,
//                HorizontalOptions = LayoutOptions.CenterAndExpand
//            };
//
//            var Label = new Label
//            {
//                Text = Ergebnis,
//                VerticalOptions = LayoutOptions.FillAndExpand,
//                HorizontalOptions = LayoutOptions.CenterAndExpand
//            };
          

            MainPage = new NavigationPage(new PageWithButton());
            var PageWithButton = new Button
            {
                Text = "pls press me",
            };
            var page2 = new Button
            {
                Text = "pls press me too",
            };
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
            var EBE = new Button
            {
                Text = "",
            };
           
            changeColorButton.Clicked += delegate
            {
                if (changeColorButton.BackgroundColor == buttonStartColor)
                {
                    changeColorButton.BackgroundColor = buttonChangeColor;
                }
                else if (1 == 2)
                {
                    changeColorButton.BackgroundColor = buttonStartColor;
                }
            };

            changeColorButton.Clicked += delegate
            {
                if (MainPage.BackgroundColor == Color.White)
                {
                    MainPage.BackgroundColor = Color.Black;
                }
                else
                {
                    MainPage.BackgroundColor = Color.White;
                }
            };

            changeColorButton.Clicked += delegate
            {
                if (changeColorButton.TextColor == Color.White)
                {
                    changeColorButton.TextColor = Color.Black;
                }
                else
                {
                    changeColorButton.TextColor = Color.White;

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
    }

    public class PageWithButton : ContentPage
    {
        public PageWithButton()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Button
                    {
                        BackgroundColor = Color.Black,
                        Text = "Bilder Erraten",
                        TextColor = Color.White,
                        Command = new Command(() => Navigation.PushAsync(new BE())),
                    },
                    new Button
                    {
                        BackgroundColor = Color.Black,
                        TextColor = Color.White,
                        Text = "Kopf oder Zahl gegen Bot",
                        Command = new Command(() => Navigation.PushAsync(new münzenspieler())),
                    },
                    new Button
                    {
                        BackgroundColor = Color.Black,
                        TextColor = Color.White,
                        Text = "Trollface oder Smilie",
                        Command = new Command(() => Navigation.PushAsync(new page2())),
                    },
                    new Button
                    {
                        BackgroundColor = Color.Black,
                        TextColor = Color.White,
                        Text = "Witze",
                        Command = new Command(() => Navigation.PushAsync(new page3())),
                    },
                    new Button
                    {
                        BackgroundColor = Color.Black,
                        TextColor = Color.White,
                        Text = "FrageBogen",
                        Command = new Command(() => Navigation.PushAsync(new pageMoJ())),
                    },
                    new Button
                    {
                        BackgroundColor = Color.Black,
                        TextColor = Color.White,
                        Text = "Anime",
                        Command = new Command(() => Navigation.PushAsync(new pageEA())),
                    },
                    new Button
                    {
                        BackgroundColor = Color.Black,
                        TextColor = Color.White,
                        Text = "Endseite finden",
                        Command = new Command(() => Navigation.PushAsync(new pageVer())),
                    },
                    new Button
                    {
                        BackgroundColor = Color.Black,
                        TextColor = Color.White,
                        Text = "Top Songs",
                        Command = new Command(() => Navigation.PushAsync(new pageTs())),
                    },
                }
            };
        }
    };

    public class PageWithImage : ContentPage
    {
        public PageWithImage()
        {
            var animationbutton = new Button
            {
                Text = "Öffne YouTube",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            animationbutton.Clicked += delegate
            {
                animationbutton.Text = "Getrollt!";
            };

            animationbutton.Command = new Command(async () =>
                {
                    animationbutton.ScaleTo(10, 1000, Easing.CubicInOut);
                    await animationbutton.RotateTo(2500000, 1000, Easing.CubicInOut);
                    animationbutton.ScaleTo(1, 1000, Easing.CubicInOut);
                    await animationbutton.RotateTo(2, 1000, Easing.CubicInOut);
                });
				
            Content = animationbutton;
        }
	
    }

    public class münzenspieler : ContentPage
    {
        public münzenspieler()
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

            Content = new StackLayout
            {
            
                Children =
                {
                    Kopf, Reset, Zahl, Label,
            
            
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
    }

    public class page2 : ContentPage
    {
        public page2()
        {
            var Bild1 = new FileImageSource
            {
                File = "Bild1.png"
            };
            var Bild2 = new FileImageSource
            {
                File = "Bild2.jpg"
            };

            var Ergebnis1 = new FileImageSource();

            var Münzen = new Button
            {
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                Text = "Trollface oder Smilie?",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Children =
                {
                    Münzen
                }
            };
                       
            Münzen.Clicked += delegate
            {
                var spintowin = new Random();
                var zufallsnummer = spintowin.Next(0, 2);

                if (zufallsnummer == 0)
                {
                    Ergebnis1 = Bild1;
                }
                else
                {
                    Ergebnis1 = Bild2;
                }
                Münzen.Image = Ergebnis1;
            };

        }
    }

    public class page3 : ContentPage
    {
        public page3()
        {
            var ERgb = new FileImageSource();

            var BF = new Button
            {
                Text = "LoL",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var B1 = new FileImageSource
            {
                File = "Bild11.jpg"
            };

            var B2 = new FileImageSource
            {
                File = "Bild22.jpg"
            };

            var B3 = new FileImageSource
            {
                File = "Bild33.jpg"
            };

            var B4 = new FileImageSource
            {
                File = "Bild44.jpg"
            };

            var B5 = new FileImageSource
            {
                File = "Bild55.jpg"
            };

            var B6 = new FileImageSource
            {
                File = "Bild66.jpg"
            };

            var B7 = new FileImageSource
            {
                File = "Bild77.jpg"
            };

            var B8 = new FileImageSource
            {
                File = "Bild88.jpg"
            };

            var B9 = new FileImageSource
            {
                File = "Bild99.jpg"
            };

            var B10 = new FileImageSource
            {
                File = "Bild1010.jpg"
            };

            var B11 = new FileImageSource
            {
                File = "Bild1111.jpg"
            };

            var B12 = new FileImageSource
            {
                File = "Bild1212.jpg"
            };

            var B13 = new FileImageSource
            {
                File = "Bild1313.jpg"
            };

            var B14 = new FileImageSource
            {
                File = "Bild1414.jpg"
            };

            var B15 = new FileImageSource
            {
                File = "images-2.jpeg"
            };

            var B16 = new FileImageSource
            {
                File = "images-3.jpeg"
            };

            var B17 = new FileImageSource
            {
                File = "images-4.jpeg"
            };

            var B18 = new FileImageSource
            {
                File = "images-5.jpeg"
            };

            var B19 = new FileImageSource
            {
                File = "images-6.jpeg"
            };

            var B20 = new FileImageSource
            {
                File = "images-7.jpeg"
            };

            var B21 = new FileImageSource
            {
                File = "images-8.jpeg"
            };

            var B22 = new FileImageSource
            {
                File = "images-9.jpeg"
            };

            var B23 = new FileImageSource
            {
                File = "images-10.jpeg"
            };

            var B24 = new FileImageSource
            {
                File = "images-11.jpeg"
            };

            var B25 = new FileImageSource
            {
                File = "images-12.jpeg"
            };

            var B26 = new FileImageSource
            {
                File = "images-13.jpeg"
            };

            var B27 = new FileImageSource
            {
                File = "images-14.jpeg"
            };

            var B28 = new FileImageSource
            {
                File = "images-15.jpeg"
            };

            var B29 = new FileImageSource
            {
                File = "images-16.jpeg"
            };

            var B30 = new FileImageSource
            {
                File = "images-17.jpeg"
            };

//            BF.Clicked += delegate
//            {
//                var RB = new Random();
//                var RBV = RB.Next(1, 30);
//
//                if (RBV == 1)
//                {
//                    ERgb = B1;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 2)
//                {
//                    ERgb = B2;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 3)
//                {
//                    ERgb = B3;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 4)
//                {
//                    ERgb = B4;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 5)
//                {
//                    ERgb = B5;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 6)
//                {
//                    ERgb = B6;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 7)
//                {
//                    ERgb = B7;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 8)
//                {
//                    ERgb = B8;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 9)
//                {
//                    ERgb = B9;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 10)
//                {
//                    ERgb = B10;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 11)
//                {
//                    ERgb = B11;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 12)
//                {
//                    ERgb = B12;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 13)
//                {
//                    ERgb = B13;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 14)
//                {
//                    ERgb = B14;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 15)
//                {
//                    ERgb = B15;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 16)
//                {
//                    ERgb = B16;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 17)
//                {
//                    ERgb = B17;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 18)
//                {
//                    ERgb = B18;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 19)
//                {
//                    ERgb = B19;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 20)
//                {
//                    ERgb = B20;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 21)
//                {
//                    ERgb = B21;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 22)
//                {
//                    ERgb = B22;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 23)
//                {
//                    ERgb = B23;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 24)
//                {
//                    ERgb = B24;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 25)
//                {
//                    ERgb = B25;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 26)
//                {
//                    ERgb = B26;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 27)
//                {
//                    ERgb = B27;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 28)
//                {
//                    ERgb = B28;
//                }
//                BF.Image = ERgb;
//
//                if (RBV == 29)
//                {
//                    ERgb = B29;
//                } 
//                BF.Image = ERgb;
//
//                if (RBV == 30)
//                {
//                    ERgb = B30;
//                }
//                BF.Image = ERgb;
//            };
            Content = new StackLayout
            {
                Children =
                {
                    BF
                }
            };
            BF.Clicked += delegate
            {
                var RB = new Random();
                var RBV = RB.Next(1, 30);

                if (RBV == 1)
                {
                    ERgb = B1;
                } 
                BF.Image = ERgb;

                if (RBV == 2)
                {
                    ERgb = B2;
                }
                BF.Image = ERgb;

                if (RBV == 3)
                {
                    ERgb = B3;
                }
                BF.Image = ERgb;

                if (RBV == 4)
                {
                    ERgb = B4;
                }
                BF.Image = ERgb;

                if (RBV == 5)
                {
                    ERgb = B5;
                } 
                BF.Image = ERgb;

                if (RBV == 6)
                {
                    ERgb = B6;
                }
                BF.Image = ERgb;

                if (RBV == 7)
                {
                    ERgb = B7;
                }
                BF.Image = ERgb;

                if (RBV == 8)
                {
                    ERgb = B8;
                }
                BF.Image = ERgb;

                if (RBV == 9)
                {
                    ERgb = B9;
                }
                BF.Image = ERgb;

                if (RBV == 10)
                {
                    ERgb = B10;
                }
                BF.Image = ERgb;

                if (RBV == 11)
                {
                    ERgb = B11;
                } 
                BF.Image = ERgb;

                if (RBV == 12)
                {
                    ERgb = B12;
                }
                BF.Image = ERgb;

                if (RBV == 13)
                {
                    ERgb = B13;
                } 
                BF.Image = ERgb;

                if (RBV == 14)
                {
                    ERgb = B14;
                }
                BF.Image = ERgb;

                if (RBV == 15)
                {
                    ERgb = B15;
                } 
                BF.Image = ERgb;

                if (RBV == 16)
                {
                    ERgb = B16;
                }
                BF.Image = ERgb;

                if (RBV == 17)
                {
                    ERgb = B17;
                }
                BF.Image = ERgb;

                if (RBV == 18)
                {
                    ERgb = B18;
                }
                BF.Image = ERgb;

                if (RBV == 19)
                {
                    ERgb = B19;
                } 
                BF.Image = ERgb;

                if (RBV == 20)
                {
                    ERgb = B20;
                }
                BF.Image = ERgb;

                if (RBV == 21)
                {
                    ERgb = B21;
                }
                BF.Image = ERgb;

                if (RBV == 22)
                {
                    ERgb = B22;
                }
                BF.Image = ERgb;

                if (RBV == 23)
                {
                    ERgb = B23;
                }
                BF.Image = ERgb;

                if (RBV == 24)
                {
                    ERgb = B24;
                }
                BF.Image = ERgb;

                if (RBV == 25)
                {
                    ERgb = B25;
                } 
                BF.Image = ERgb;

                if (RBV == 26)
                {
                    ERgb = B26;
                }
                BF.Image = ERgb;

                if (RBV == 27)
                {
                    ERgb = B27;
                } 
                BF.Image = ERgb;

                if (RBV == 28)
                {
                    ERgb = B28;
                }
                BF.Image = ERgb;

                if (RBV == 29)
                {
                    ERgb = B29;
                } 
                BF.Image = ERgb;

                if (RBV == 30)
                {
                    ERgb = B30;
                }
                BF.Image = ERgb;
            };
        }
    };

  

    public class pageMoJ : ContentPage
    {
        public pageMoJ()
        {

            var y1 = new Button
            {
                Text = "Mädchen",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM1())),
            };

            var n1 = new Button
            {
                Text = "Junge",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageJ1())),
            };
            Content = new StackLayout
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
            };
        }
    }

    public class pageJ1 : ContentPage
    {
        public pageJ1()
        {
            var y33 = new Button
            {
                Text = "Sport machen",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageSp())),
            };
            var n44 = new Button
            {
                Text = "nach Draußen gehen",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM66())),
            };
            var y2 = new Button
            {
                Text = "Youtube gucken",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM2())),
            };
            var n2 = new Button
            {
                Text = "Zocken",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageJ3())),
            };
            var n555 = new Button
            {
                Text = "Anime gucken",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageEA())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    n555,
                    y2,
                    n44,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "was machst du lieber??"
                    },
                    n2,
                    y33
                }
            };
        }
    }

    public class pageM1 : ContentPage
    {
        public pageM1()
        {
            var y33 = new Button
            {
                Text = "Sport machen",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM2())),
            };
            var n44 = new Button
            {
                Text = "nach Draußen gehen",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM66())),
            };
            var y2 = new Button
            {
                Text = "Youtube gucken",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM2())),
            };
            var n2 = new Button
            {
                Text = "Zocken",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM3())),
            };
            var n555 = new Button
            {
                Text = "Anime gucken",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageEA())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    n555,
                    y2,
                    n44,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "was machst du lieber??"
                    },
                    n2,
                    y33
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
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),

            };
            var n4 = new Button
            {
                Text = "Ja",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new PageWithImage())),
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
                        Text = "Guckst du Gern YouTube?"
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
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton()))
            };
            var n5 = new Button
            {
                Text = "Ja",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new PageWithImage())),
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
                        Text = "Guckst du Gerne YouTube?"
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
                Text = "…ActionSpiele?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageJ4())),
            };
            var n6 = new Button
            {
                Text = "…FriedlichereSpiele?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageJ5())),
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
                        Text = "Magst du Lieber…"
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
                Text = "…ActionSpiele?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM4())),
            };
            var n7 = new Button
            {
                Text = "…FriedlichereSpiele?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageM5())),
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
                        Text = "Magst du Lieber…"
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
                Text = "…Bo3?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageBo())),
            };
            var n8 = new Button
            {
                Text = "…GTA5?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageGta())),
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
                        Text = "Magst du Lieber…"
                    },
                    n8
                }
            };
        }
    }

    public class pageM4 : ContentPage
    {
        public pageM4()
        {
            var y9 = new Button
            {
                Text = "…Bo3?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageBo())),
            };
            var n9 = new Button
            {
                Text = "…GTA5?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageGta())),
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
                        Text = "Magst du Lieber…"
                    },
                    n9
                }
            };
        }
    }

    public class pageJ5 : ContentPage
    {
        public pageJ5()
        {

            var y11 = new Button
            {
                Text = "…Minecraft?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageMc())),
            };
            var n11 = new Button
            {
                Text = "…FiFa?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageFF())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    y11,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Magst du lieber…"
                    },
                    n11
                }
            };
        }
    }

    public class pageM5 : ContentPage
    {
        public pageM5()
        {

            var y111 = new Button
            {
                Text = "…Mario Party?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageMP())),
            };
            var n111 = new Button
            {
                Text = "…Sims?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageSi())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    y111,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Magst du lieber"
                    },
                    n111
                }
            };
        }
    }


    public class pageM66 : ContentPage
    {
        public pageM66()
        {

            var y33 = new Button
            {
                Text = "Nein",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            var n44 = new Button
            {
                Text = "Ja",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    y33,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Schätzt du die Natur??"
                    },
                    n44
                }
            };
        }
    }

    public class pageGta : ContentPage
    {
        public pageGta()
        {
            var Gtawasted1 = new FileImageSource
            {
                File = "Gta5.jpg"
            };
            var EBVXXXY = new Button
            {
                Image = Gtawasted1,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    EBVXXXY
                }
            };
        }
    }

    public class pageBo : ContentPage
    {
        public pageBo()
        {
            var Bo3file = new FileImageSource
            {
                File = "Bo3.jpg"
            };
            var EBVYX = new Button
            {
                Image = Bo3file,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    EBVYX
                }
            };
        }
    }

    public class pageMc : ContentPage
    {
        public pageMc()
        {
            var mcfile = new FileImageSource
            {
                File = "Mc.jpg"
            };
            var EBVXX = new Button
            {
                Image = mcfile,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    EBVXX
                }
            };
        }
    }

    public class pageFF : ContentPage
    {
        public pageFF()
        {
            var fifafile = new FileImageSource
            {
                File = "Fifa.jpg"
            };
            var EBVxx = new Button
            {
                Image = fifafile,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    EBVxx
                }
            };
        }
    }

    public class pageMP : ContentPage
    {
        public pageMP()
        {
            var mariofile = new FileImageSource
            {
                File = "Mario.jpg"
            };
            var EBVc = new Button
            {
                Image = mariofile,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    EBVc  
                }
            };
        }
    }

    public class pageSi : ContentPage
    {
        public pageSi()
        {
            var simsfile = new FileImageSource
            {
                File = "Sims.jpg"
            };
            var DXC = new Button
            {
                Image = simsfile,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    DXC
                }
            };
        }
    }

    public class pageSp : ContentPage
    {
        public pageSp()
        {

            var ysp = new Button
            {
                Text = "Richtung Kampf",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageKf())),
            };
            var nsp = new Button
            {
                Text = "Richtung Athletic",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageAc())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    ysp,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Was denn dür welchen?"
                    },
                    nsp
                }
            };
        }
    }

    public class pageAc : ContentPage
    {
        public pageAc()
        {

            var ya123 = new Button
            {
                Text = "Nein",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            var na123 = new Button
            {
                Text = "Ja",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageSSpp())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    ya123,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Und Noch mehr Details?"
                    },
                    na123
                }
            };
        }
    }

    public class pageSSpp : ContentPage
    {
        public pageSSpp()
        {

            var yapp = new Button
            {
                Text = "…Ausdauertraining?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageAT())),
            };
            var napp = new Button
            {
                Text = "…Krafttraining?",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageKT())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    yapp,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Machst du…"
                    },
                    napp
                }
            };
        }
    }

    public class pageKT : ContentPage
    {
        public pageKT()
        {
            var kraftfile = new FileImageSource
            {
                File = "Kraft.jpg"
            };
            var Exx = new Button
            {
                Image = kraftfile,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    Exx
                }
            };
        }
    }

    public class pageAT : ContentPage
    {
        public pageAT()
        {
            var Ausdauerfile = new FileImageSource
            {
                File = "Ausdauer.jpg"
            };
            var Egg = new Button
            {
                Image = Ausdauerfile,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    Egg     
                }
            };
        }
    }

    public class pageKf : ContentPage
    {
        public pageKf()
        {
            var Kampffile = new FileImageSource
            {
                File = "Kampf.jpg"
            };
            var ECD = new Button
            {
                Image = Kampffile,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    ECD
                }
            };
            
        }
    }

    public class pageEA : ContentPage
    {
        public pageEA()
        {

            var ya212 = new Button
            {
                Text = "Pure Action",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new Actionpage())),
            };
            var na212 = new Button
            {
                Text = "Massen Harem",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new Harempage())),
            };
            var na2121 = new Button
            {
                Text = "Komische Fantasy",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new Fantasypage())),
            };
            var nabb = new Button
            {
                Text = "Romantische Romance",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new Romancepage())),
            };
            var nabb1 = new Button
            {
                Text = "Gruseliger Horror",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new Horrorpage())),
            };
            var B1 = new Button
            {
                Text = "Zum schießende Comedy",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new Comedypage())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    B1,
                    na2121,
                    ya212,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Welche Genere?"
                    },
                    na212,
                    nabb,
                    nabb1
                }
            };
        }
    }

    public class Actionpage: ButtonPage
    {
        public Actionpage()
        {
            var B1 = CreatePushButton("Kazme no Stigma", new KNS_test());
            var B2 = CreatePushButton("Sword art Online", new SAO());
            var B3 = CreatePushButton("Rakudai Kishi no Caverly", new RKNC());
            var B4 = CreatePushButton("Gakusen toshi Asteriks", new GTA());
            var B5 = CreatePushButton("Ao no Exorcist", new Aono());
            var B6 = CreatePushButton("Fate/stay Night", new Fate());
            var B7 = CreatePushButton("Projekt K", new K());
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7
                }
            };
        }
    }

    public class Harempage : ButtonPage
    {
        public Harempage()
        {
            var B1 = CreatePushButton("Highschool DxD", new hsdxd());
            var B2 = CreatePushButton("Shinmai maou no Testament", new si());
            var B3 = CreatePushButton("Rosario + Vampire", new Rosario());
            var B4 = CreatePushButton("Sora no Otoshimono", new sora());
            var B5 = CreatePushButton("to Love RU", new RU());
            var B6 = CreatePushButton("Demon King Daimaou", new DemonK());
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    B1, B2, B3, B4, B5, B6
                }
            };
        }
    }

    public class Fantasypage : ButtonPage
    {
        public Fantasypage()
        {
            var B1 = CreatePushButton("Trinity seven", new TS());
            var B2 = CreatePushButton("Fairy Tail", new FTi());
            var B3 = CreatePushButton("Soul Eater", new Soul());
            var B4 = CreatePushButton("Magi: the Labyrinth of Magic", new Magi());

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    B1, B2, B3, B4
                }
            };
        }
    }

    public class Romancepage : ButtonPage
    {
        public Romancepage()
        {
            var B1 = CreatePushButton("Zero no Tsukaima", new ZNT());
            var B2 = CreatePushButton("Date a Live", new DAL());
            var B3 = CreatePushButton("Plastic Memories", new PM());
            var B4 = CreatePushButton("Toradora", new T());
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    B2, B3, B4, B1
                }
            };
        }
    }

    public class Comedypage : ButtonPage
    {
        public Comedypage()
        {
            var B1 = CreatePushButton("Ore, Twintails ni Narimasu", new OTNN());
            var B2 = CreatePushButton("Hataraku Maou-sama!", new sin2());
            var B3 = CreatePushButton("Sakurasou no Pet na Kanojo", new sin3());
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    B1, B3, B2,
                }
            };
        }
    }

    public class Horrorpage : ButtonPage
    {
        public Horrorpage()
        {     
            var B1 = CreatePushButton("Mirai Nikki", new sin());
            var B2 = CreatePushButton("Tokyo Ghoul", new sin1());
            var B3 = CreatePushButton("Hataraku Maou-sama!", new elfen());
            var B4 = CreatePushButton("Highschool of the Dead", new dead());
            var B5 = CreatePushButton("Hellsing", new Ultimate());
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    B1, B2, B3, B4, B5
                }
            };
        }
    }

    public class pageA2 : ContentPage
    {
        public pageA2()
        {

            var yA0 = new Button
            {
                Text = "Action",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageAAA())),
            };
            var nA0 = new Button
            {
                Text = "Romance",
                TextColor = Color.Green,
                BackgroundColor = Color.Lime,
                Command = new Command(() => Navigation.PushAsync(new pageAb())),
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    yA0,
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Welche Genere magst du lieber?"
                    },
                    nA0
                }
            };
        }
    }

    public class pageAb : ContentPage
    {
        public pageAb()
        {
            var lomancefile = new FileImageSource
            {
                File = "romance.jpg"
            };
            var lol = new Button
            {
                Image = lomancefile,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    lol
                }
            };
        }
    }

    public class pageAAA : ContentPage
    {
        public pageAAA()
        {
            var Gtawasted = new FileImageSource
            {
                File = "Action.jpg"
            };
            var EBV = new Button
            {
                Image = Gtawasted,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
       
            Content = new StackLayout
            {
                Children =
                {
                    EBV
                }
            };
        }
    }

    public class T : ContentPage
    {
        public T()
        {
            var si = new Label
            {
                Text = "Ryuuji Takasu ist eigentlich ein ganz normaler High-School-Schüler – wäre da nicht sein Vater, der ihm Augen vererbt hat, die jedem das Blut in den Adern gefrieren lassen. So muss er sich damit abfinden, dass ihn die meisten für einen üblen Schläger halten und er trotz seines umgänglichen Charakters kaum Freunde hat. Doch das soll nicht sein einziges Problem bleiben, denn pünktlich zu Beginn des neuen Schuljahres trifft er auf die einzige Person der Schule, die noch mehr gefürchtet wird als er, nämlich Taiga Aisaka, auch bekannt als „Palmtop Tiger“. Es dauert nicht lange, bis die beiden herausfinden, dass sie jeweils den Freund des anderen heimlich lieben – und so schließen sie eine Art Zweckbündnis, um einander zu verkuppeln."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class si : ContentPage
    {
        public si()
        {
            var si = new Label
            {
                Text = "Basara Toujou wollte schon immer eine kleine Schwester haben. Als sein Vater ihm dann aber eröffnet, dass er wieder heiraten wird, fällt er dennoch aus allen Wolken. Sein Vater bringt die beiden Stiefschwestern Mio und Maria Naruse zu Basara und begibt sich dann auf eine Reise. Die Schwestern scheinen auf den ersten Blick recht normal, sind aber in Wirklichkeit die neue Dämonenkönigin und ein erotisch denkender Sukkubus..."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class MKnR : ContentPage
    {
        public MKnR()
        {
            var si = new Label
            {
                Text = "Magie ist seit jeher ein ganz normaler Bestandteil des Lebens. In dieser Welt leben die Geschwister Tatsuya und Miyuki Shiba. Sie gehen auf die High School für Magier. An der Schule herrscht eine strickte Trennung zwischen guten und schlechten Schülern. Während die guten Schüler, sog. \"Blüten\", eine besondere Ausbildung und Stellung genießen, müssen die schlechten Schüler, die sog. \"Gras\"-Gruppe, als Ersatz für die Blüten herhalten. Die begabte Miyuki kommt in die \"Blüten\"-Klasse, während ihr Bruder Tatsuya in die \"Gras\"-Klasse kommt. Die beiden müssen nun den anstrengenden Schulalltag meistern. Vor ihnen liegen aber kaum ruhige Schultage, sondern viel Aufregung und Gefahren."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class sin : ContentPage
    {
        public sin()
        {
            var si = new Label
            {
                Text = "Den Highschoolschüler Yukiteru Amano plagt das Gefühl der Einsamkeit. Einzig das imaginäre Wesen Deus Ex Machina leistet Yukiteru Gesellschaft und erklärt diesem, dass er der Gott von Raum und Zeit sei. Deus Ex Machina modifiziert Yukiterus Handy um, so dass es die Zukunft seines Besitzers in Form eines Tagebuchs voraussagt. Doch nachdem Yukiteru der Besitzer des neuen Handys wird, muss er zusammen mit 11 anderen Auserwählten an einem Spiel auf Leben und Tod teilnehmen, um am Ende der Nachfolger von Deus Ex Machina zu werden."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class sin1 : ContentPage
    {
        public sin1()
        {
            var si = new Label
            {
                Text = "Wenn es dunkel wird, greifen Ghoule unschuldige Bürger an und ernähren sich von ihrem Fleisch. Äußerlich sind sie von normalen Menschen nicht zu unterscheiden. Wer weiß, vielleicht hat das nette Mädchen aus dem Café oder der Nachbar von nebenan eine kleine Schwäche für Menschenfleisch? So ist es kein Wunder, dass Bücherwurm und Erstsemester Ken mitten in den Armen einer Ghoula landet. Ken überlebt die Ghul-Attacke durch einen unglaublichen Zufall – jedoch mit schweren Verletzungen. Damit er weiterleben kann, müssen ihm die Organe seiner Angreiferin transplantiert werden. Anfangs geht sein Leben recht normal weiter, doch nach und nach entdeckt er einige Ungereimtheiten an sich und entwickelt seltsame Gelüste."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class sin2 : ContentPage
    {
        public sin2()
        {
            var si = new Label
            {
                Text = "Der Dämonenkönig Satan ist kurz davor den Kampf gegen die Menschen in seiner Welt zu verlieren und beschließt daher sich durch ein Portal in eine andere Welt zurückzuziehen. Er findet sich gemeinsam mit seinem Vertrauten im Tokio der Gegenwart wieder, muss zu seinem Entsetzen aber feststellen, dass diese Welt nicht nur ganz anders ist als seine, sondern er auch fast alle seiner magischen Kräfte verloren hat. Um sich seinen Lebensunterhalt zu verdienen, ist er gezwungen als Aushilfskraft in einem Fast-Food-Restaurant zu arbeiten. Seine Eroberungspläne formt er kurzerhand um und beschließt nun Japan zu erobern, wobei für ihn dafür der erste Schritt ist, dass er von einer Aushilfe zu einem fixen Angestellten aufsteigt."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class sin3 : ContentPage
    {
        public sin3()
        {
            var si = new Label
            {
                Text = "Sakurasou, das Wohnheim für Problemschüler. Hier lebt Kanda Sorata. Eines Tages zieht die junge Shiina Mashiro dort ein. Die Lehrerin des Wohnheims betraut ihn mit der Aufgabe sich um sie zu kümmern. Doch Shiina ist nicht wie jedes andere Mädchen: Zum einen sehr talentiert und begabt, zum anderen nicht in der Lage, allein zu leben. Dies führt in eine sehr unwillige Beziehung..."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class SAO : ContentPage
    {
        public SAO()
        {
            var si = new Label
            {
                Text = "Die Story handelt von dem Jungen Kazuto \"Kirito\" Kirigaya, der an einem Massen-Mehrspieler-Online-Rollenspiel, kurz MMORPG, namens \"Sword Art Online\" teilnimmt. Aus diesem Spiel gibt es kein Entkommen, dies bemerken sämtliche Spieler die eingeloggt sind,erst nach dem Eintritt in das Spiel. Das Spiel zu verlassen schafft man nur in dem man es komplett durchspielt, was sich allerdings nicht als eine leichte Aufgabe erweist, denn ein GAME OVER im Spiel bedeutet den Tod im echten Leben."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class DAL : ContentPage
    {
        public DAL()
        {
            var si = new Label
            {
                Text = "Japan wird von \"Raumbeben\" heimgesucht. Diese werden von \"Geisterwesen\" verursacht. Der Junge Shidou Itsuka hat die Gabe die Kräfte der Geisterwesen zu versiegeln. Er muss sie daten und schließlich küssen, um ihre Kräfte in sich zu versiegeln. Doch als das Geisterwesen Kurumi auftaucht, läuft alles anders als geplant ..."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class DBWHGD : ContentPage
    {
        public DBWHGD()
        {
            var si = new Label
            {
                Text = "In Dakara Boku wa, H ga Dekinai dreht sich alles um den perversen Schüler Ryosuke. Eines Tages trifft er ein Mädchen, das alleine auf der Straße im Regen steht. Diese stellt sich kurz darauf als die Todesgöttin Risara heraus, die Ryosuke gleich darauf sein \"sexuelles Verlangen\" aussaugt, da es eine Energiequelle darstellt."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class hsdxd : ContentPage
    {
        public hsdxd()
        {
            var si = new Label
            {
                Text = "Die Geschichte handelt von Issei Hyoudou, einem perversen Highschool Schüler, der von Mädchen verabscheut wird. Nachdem ein Mädchen Interesse an ihm zeigt, wird er von ihr getötet, da sie sich als gefallener Engel entpuppt. Er wird jedoch als Dämon neugeboren und dient seit dem Tage Rias Gremory. Sie ist aber nicht nur eine hochrangige Dämonin, sondern auch das schönste Mädchen der Schule."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class PM : ContentPage
    {
        public PM()
        {
            var si = new Label
            {
                Text = "In einer nicht allzu fernen Zukunft existieren überall auf der Welt Androide, die genauso aussehen wie Menschen. Eine spezielle Android Produktionsfirma, die SA Corp., veröffentlicht ihr neuestes Modell - die Giftia. Diese neue Art von Androiden sind noch menschenähnlicher als alle Vorgänger und besitzen selbst einen Großteil an Emotionen. Da diese Technologie aber noch sehr unerforscht ist, haben die Giftia nur eine gewisse Lebensdauer für diese Qualitäten. Sobald sie ihre Dauer überschritten haben, steht man jedoch vor gewissen Problemen..."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class RKNC : ContentPage
    {
        public RKNC()
        {
            var si = new Label
            {
                Text = "Ikki Kurogane geht auf eine Schule für magische Ritter. Diese bringt den Schülern die moderne Nutzung von Magie bei: Man lernt das Kämpfen mit Waffen, die aus der eigenen Seele umgewandelt werden. Doch Ikki ist der Schlechteste an dieser Schule, da er keine magische Skills besitzt. Eines Tages trifft er auf Stella Vermillion, eine ausländische Prinzessin und die beste Schülerin an dieser Schule. Von dieser wird Ikki zu einem Duell herausgefordert und der Verlierer muss dem Gewinner ein Leben lang gehorsam sein\u2009…"
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class ZNT : ContentPage
    {
        public ZNT()
        {
            var si = new Label
            {
                Text = "Hiraga Saito, ein gewöhnlicher Teenager aus unserer Gegenwart, findet sich urplötzlich in einer Fantasy-Welt voller Magie und Monster wieder. Beschworen wurde er von der Zauberin Louise, die bei ihren Schulkameraden nur unter dem Namen \"Nullnummer Louise\" bekannt ist, der treffend ihre Erfolgschancen beim Zaubern wiedergibt. Saitos Beschwörung war daher auch nicht wirklich geplant, eigentlich wollte sie, wie alle anderen Schüler aus dem gleichen Jahrgang, einen \"Vertrauten\" herbeirufen und das sollte ganz sicher kein Mensch sein. Trotzdem nimmt Saito schnell diese Rolle ein, obwohl sich für ihn bald herausstellt, dass \"Vertrauter\" in Louises Obhut eher Sklave bedeutet und ihr schwieriger Charakter sein Leben nicht gerade einfacher macht."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class TS : ContentPage
    {
        public TS()
        {
            var si = new Label
            {
                Text = "Kasuga Arata lebt ein ganz normales Leben in einer kleinen Stadt. Begleitet wird er dabei von seiner Cousine und Kindheitsfreundin Kasuga Hijiri. Allerdings ändert sich dies am Tag der schwarzen Sonne. Die Magiern Lilith Azami taucht in der Stadt auf und flüstert Arata zu, er müsse aufwachen oder sie werde ihn töten. Die Stadt, in der Arata gelebt hat, existiert nicht mehr, denn sie wurde beim Breakdown Phänomen zerstört. Während der Zerstörung schenkte Hijiri ihm ein Zauberbuch, das die Scheinstadt für ihn erschaffen hat. Nachdem Arata nun aus seiner Scheinwelt erwacht ist, fasst er den Entschluss, Hijiri zu suchen. Hierzu muss er allerdings erst seine Magie meistern.."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    //    public class KNS : ContentPage
    //    {
    //        public KNS()
    //        {
    //            var si = new Label
    //            {
    //                Text = "Ayano und Kazuma sind beides Mitglieder der Kannagi-Familie, einer Familie mit großer Macht über die Feuermagie. Während bei Ayano, der Erbin, diese Macht sehr stark ausgeprägt ist, fehlt Kazuma dafür jegliche Fähigkeit. Nachdem Ayano ihn aufgrund dessen in einer Zeremonie besiegt, verläßt der in Ungnade gefallene Kazuma seine Familie und ändert seinen Nachnamen in Yagami. 4 Jahre später kehrt er zurück, inzwischen ein mächtiger Beherrscher der Windmagie. Kurz darauf werden einige Mitglieder der Kannagi-Familie von einem Windbeherrscher getötet. Kazuma gerät natürlich sofort in Verdacht und muss sich nun trotz seiner Unschuldsbeteuerungen auf einen erbitterten Kampf mit seiner früheren Familie einstellen."
    //            };
    //            Content = new StackLayout
    //            {
    //                Children =
    //                {
    //                    si
    //                }
    //            };
    //        }
    //    }

    public class TextPage : ContentPage
    {
        protected string text;

        protected void CreateContent()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = text,
                    },
                }
            };
        }
    }

    public class KNS_test : TextPage
    {
        public KNS_test()
        {
            text = "Ayano und Kazuma sind beides Mitglieder der Kannagi-Familie, einer Familie mit großer Macht über die Feuermagie. Während bei Ayano, der Erbin, diese Macht sehr stark ausgeprägt ist, fehlt Kazuma dafür jegliche Fähigkeit. Nachdem Ayano ihn aufgrund dessen in einer Zeremonie besiegt, verläßt der in Ungnade gefallene Kazuma seine Familie und ändert seinen Nachnamen in Yagami. 4 Jahre später kehrt er zurück, inzwischen ein mächtiger Beherrscher der Windmagie. Kurz darauf werden einige Mitglieder der Kannagi-Familie von einem Windbeherrscher getötet. Kazuma gerät natürlich sofort in Verdacht und muss sich nun trotz seiner Unschuldsbeteuerungen auf einen erbitterten Kampf mit seiner früheren Familie einstellen.";
            CreateContent();
        }
    }

    public class GTA : ContentPage
    {
        public GTA()
        {
            var si = new Label
            {
                Text = "Nach Invertia, einer Katastrophe, die die ganze Welt veränderte, entstand eine neue Menschenrasse: Die Genestella. Ayato ist so ein Genestella und neu in Asterisk, der Stadt auf dem Wasser, in der junge Genestella zur Schule gehen und bei der Festa ihre Kräfte messen. Dem Sieger der Festa winkt die Erfüllung eines Wunsches. Noch nicht einmal richtig in der Schule angekommen, wird Ayato auch schon von einem hübschen Mädchen namens Julis zum Kampf herausgefordert."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class OTNN : ContentPage
    {
        public OTNN()
        {
            var si = new Label
            {
                Text = "Der Schüler Soji Mitsuka hat eine Vorliebe für Mädchen mit zwei Zöpfen. Eines Tages trifft er auf ein geheimnissvolles und schönes Mädchen namens Thouars, welches aus einem Paralleluniversum kommt. Zur selben Zeit erscheinen Monster in der Stadt, die behaupten, dass alle Mädchen mit zwei Zöpfen ihnen gehören. Thouars leiht ihm für die Rettung der Menschheit und der Mädchen mit zwei Zöpfen das Tail Gear, eine imaginäre Rüstung, welche ihm die Kraft gibt sich in ein rotes Kriegermädchen mit übernatürlichen Kräften - und einem Twintail - zu verwandeln, um die Kreaturen zu bekämpfen."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class FTi : ContentPage
    {
        public FTi()
        {
            var si = new Label
            {
                Text = "Eine von Magie durchdrungene Welt, in der Zauberei noch alltäglich ist... beherrscht von mächtigen Magiergilden, die für Recht und Ordnung sorgen... und zuweilen auch etwas übertreiben...?! FAIRY TAIL ist eine dieser Gilden. Laut, zerstörerisch, immer feiernd und stets für einen Kampf zu haben, zählt diese Gemeinschaft einige der mächtigsten Magier dieser Zeit zu ihren Reihen. Die junge Lucy lernt ihre neue Gilde sowie deren Mitglieder schnell zu schätzen: den draufgängerischen Feuermagier Natsu mit seiner sprechenden Katze Happy, den coolen Eismagier Gray, die unerschrockene Erza, den kleinwüchsigen alten Meister Makarov und, und, und..."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class Magi : ContentPage
    {
        public Magi()
        {
            var si = new Label
            {
                Text = "Magi erzählt die Abenteuer des jungen Aladdin. Dieser besitzt eine magische Flöte, mit der er den kopflosen Djinn Ugo beschwören kann. Seit sich Aladdin gewünscht hat, dass Ugo sein Freund ist, begleitet er ihn auf seinen Reisen. Aladdins Ziel ist es, das Geheimnis um seine Identität zu ergründen, über die er so gut wie nichts weiß. Außer Ugo helfen ihm bei seinen Abenteuern noch viele andere Freunde, die er während seiner Reisen kennenlernt."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class Aono : ContentPage
    {
        public Aono()
        {
            var si = new Label
            {
                Text = "Rin Okumura ist ein nichtsnutziger Junge mit übermenschlichen Kräften, der von einem Exorzisten in einem Kloster großgezogen wurde. Die Mönche verheimlichten ihm 15 Jahre lang, dass er in Wirklichkeit der Sohn des Teufels ist, dessen Kräfte mit Hilfe eines Schwertes versiegelt wurden. Dieses Siegel ist jedoch brüchig geworden und als seine Kräfte wieder zu erwachen beginnen, wird der Teufel auf ihn aufmerksam und tötet Rins Ziehvater. Nun will Rin seine Kräfte nutzen und selbst ein Exorzist werden, um den Satan zu besiegen."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class Soul : ContentPage
    {
        public Soul()
        {
            var si = new Label
            {
                Text = "Der Schauplatz von Soul Eater ist die Shibusen-Universität, deren Schüler sogenannte Meister sind. Jeder von ihnen hat eine Art lebende Waffe als Partner und sie alle verfolgen das Ziel, ihre Waffe zu einer Death Scythe zu machen, indem sie die Seelen böser Menschen aufsammeln. Das ist aber mehr eine Motivationshilfe, denn das eigentliche Ziel der Universität ist es zu verhindern, dass diese Seelen in die falschen Hände geraten. Die Anime-Serie verfolgt die Abenteuer der Meister Maka, Black Star und Death the Kid mit ihren jeweiligen Partnern Soul Eater, Tsubaki, Patty und Liz, die alle mehr oder weniger ernsthaft versuchen, die Welt vor ihrem Untergang zu bewahren."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class Fate : ContentPage
    {
        public Fate()
        {
            var si = new Label
            {
                Text = "Es könnte ein normaler Tag für den Schüler Shirou Emiya werden. Eine Schulfreundin hat ihm Frühstück gemacht, er ist zur Schule gegangen und lebt sein kleines Leben. Doch die Zeit für einen besonderen Wettkampf ist angebrochen. Die Arena ist Shirous Heimatstadt und Teilnehmer agieren im Verborgenen. Magisch begabte beschwören sich einen Diener um diesen gegen andere kämpfen zu lassen. Gewinnen kann man den Heiligen Gral, dem nachgesagt wird, dass er dem Gewinner einen Wunsch erfüllt."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class K : ContentPage
    {
        public K()
        {
            var si = new Label
            {
                Text = " Faul, fauler, am faulsten, Yashiro Isana. Er schnorrt das Essen von den Mitschülern und verpennt den Tag am liebsten auf dem Dach mit seinem Kätzchen. Kein Wunder, dass er als Sonderling gesehen wird. Als er einen kleinen Botengang für eine Mitschülerin machen muss, wird er Zeuge eines Bandenkrieges. Und plötzlich richtet sich alle Aufmerksamkeit auf ihn. Auf seiner Flucht wird er von Kurou Yatogami gerettet, vor dem er aber ebenfalls flüchten muss, trachtet ihm dieser doch genauso nach dem Leben wie alle anderen. Aber besser geht ja bekanntlich immer: kaum Zuhause angekommen, sitzt ein nacktes Mädchen namens Neko auf seinem Bett, das über magische Kräfte zu verfügen scheint. Und dann klingelt auch noch Kurou ganz höflich an der Tür..."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class DemonK : ContentPage
    {
        public DemonK()
        {
            var si = new Label
            {
                Text = " Akuto Sai hat es sich zum Ziel gesetzt, in den höchsten Magierorden seines Landes aufgenommen zu werden, um dann der Gesellschaft als deren Kleriker dienen zu können. Am Tag seiner Aufnahme an der Constan Magieakademie, ergibt sein Eignungstest Folgendes: \"Zukünftiger Beruf - Dämonenkönig\". So beginnt schließlich seine harte Schulzeit, in der er von der eifrigen Klassensprecherin verachtet, von einem Mädchen mit mysteriösen Kräften begehrt, und von einer wunderschönen Androidin bewacht wird."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class RU : ContentPage
    {
        public RU()
        {
            var si = new Label
            {
                Text = " Eines Tages, als er nach Hause kommt und schmollend in der Badewanne sitzt, taucht ein nacktes Mädchen wie aus dem Nichts auf. Ihr Name ist Lala, und sie kommt vom Planeten Deviluke, wo sie die Thronfolgerin ist. Ihr Vater möchte, dass sie wieder heimkehrt, damit sie einen seiner Hochzeitskandidaten heiraten kann. Doch sie entscheidet, dass sie lieber Rito zum Ehemann nehmen will, um auf der Erde zu bleiben. Später wird Commander Zastin geschickt, um sie zurückzubringen. Auf der Erde angekommen kämpft er gegen Rito und berichtet dem Kaiser, dass Rito ein geeigneter Ehemann für Lala ist. Ihr Vater beschließt, dass Rito sie nur heiraten darf, wenn er \"der Mann Nr. 1 des Universums\" wird."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class sora : ContentPage
    {
        public sora()
        {
            var si = new Label
            {
                Text = " Tomoki Sakurai ist ein normaler Schüler, dessen Motto \"Friede hat die oberste Priorität\" ist. In seinen Träumen taucht jedoch oft ein seltsames Mädchen auf, das ihn um Hilfe bittet, nur kann er sich sobald er aufwacht, nie an ihr Gesicht erinnern. Sein Leben wird um einiges komplizierter, als ein unidentifizierbares mysteriöses Tier vom Himmel fällt, das sich schließlich als der Engel Ikaros herausstellt."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class Rosario : ContentPage
    {
        public Rosario()
        {
            var si = new Label
            {
                Text = " Durch einen bizzaren Zufall, hat Tsukune Aono sich versehentlich an einer Dämonen Schule eingeschrieben, einer Schule auf die Monster gehen, zwar sehen sie die meiste Zeit menschlich aus, aber wenn es Ärger oder Kämpfe gibt verwandeln sie sich je nach Gattung in die entsprechende Form (von Werwölfen, Golem, Sucubuss und Schnecken Dämonen über Zyklopen und Nixen und noch viel mehr). Gerade als er realisiert wo er gelandet ist und was womöglich mit ihm passieren wird, wenn die Monster rausfinden, das er ein total normaler Mensch ist (Mensch steht bei einigen der Monster auf dem Speiseplan) möchte er fliehen, doch dann begegnet er der Schulschönheit Moka und seine Stimmung schlägt blitzartig um."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class Boku : ContentPage
    {
        public Boku()
        {
            var si = new Label
            {
                Text = "Hasegawa Kodaka ist neu an der Schule und tut sich schwer dabei, Freunde zu finden. Verschärft wird sein Problem dadurch, dass man ihn aufgrund seiner blonden Haare für einen Schläger hält. Eines Tages stört er seine missmutige, eigenbrötlerische Klassenkameradin Yozora bei einer Unterhaltung mit ihrer imaginären Freundin Tomo. Sie stellen fest, dass keiner von beiden echte Freunde hat, und beschließen zur Abhilfe einen Klub zu gründen. So entstand \"Rinjinbu\", ein Klub speziell für Leute, die wenig Freunde haben. Doch ergeben sich durch diese Ansammlung an sozial unerfahrenen Teenagern auch allerlei Probleme..."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class Zombie : ContentPage
    {
        public Zombie()
        {
            var si = new Label
            {
                Text = " Die Geschichte dreht sich um einen faulen Schüler namens Ayumu Aikawa, der während einer Reihe von geheimnisvollen Morden getötet wird. Allerdings wird Ayumu als ein Zombie wiederbelebt und zwar durch ein Mädchen namens Yuu, welches er kurz vor seinem Tod getroffen hat. Ayumu erwacht in einer Welt von \"Masou Shoujo\", wo Mädchen mit magischen Fähigkeiten und Vampirninjas existieren. Ayumu hat nun die Pflichten eines solchen Mädchen und wird dem magischen Kriegermädchen Haruna zugeteilt."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class Ultimate : ContentPage
    {
        public Ultimate()
        {
            var si = new Label
            {
                Text = "Die moderne Welt sieht sich einer alten, grauen Welt gegenüber. Vampire, vor allem die Freaks, töten und terrorisieren die Bewohner Englands. Zwei Orden kämpfen gegen sie und gegen sich, der protestantische Ritterorden Hellsing mit ihrem geknechteten Vampir Alucard und der Vatikan mit seinen Regeneratoren."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class dead : ContentPage
    {
        public dead()
        {
            var si = new Label
            {
                Text = "Überall auf der Welt ist ein unbekannter und tödlicher Virus ausgebrochen, der die Infizierten in torkelnde und sabbernde Zombies verwandelt. Während des Ausbruchs der unheimlichen Epidemie, befindet sich Takashi Komuro in seiner Schule und bemerkt schnell, dass nicht alles mit rechten Dingen zugeht. Kurzerhand verbarrikadiert er sich mit seiner Jugendliebe Rei Miyamoto auf dem Dach der Schule, um sich vor der wandelnden Leichenflut zu schützen. Ehe die beiden sich versehen, gehören sie einer kleinen Gruppe Überlebender an: Eine im Schwertkampf ausgebildete Mitschülerin, eine mit weiblichen Reizen im Übermaß ausgestatte Schulärztin, die Tochter eines einflussreichen Politikers und ein Waffen-liebender Otaku."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class elfen : ContentPage
    {
        public elfen()
        {
            var si = new Label
            {
                Text = "Den Kern der Story bilden die \"Diclonius\", sie scheinen die nächste Stufe der Evolution zu sein. Es sind Wesen mit hornähnlichen Verformungen an ihren Köpfen. Sie besitzen starke telekinetischen Kräfte, die sich in Form von unsichtbaren Armen ausbilden. Mit diesen Kräften könnten sie mit Leichtigkeit die Menschheit ausrotten.Eines Tages kann eine der Diclonius entkommen (Lucy). Auf ihrer Flucht schlägt sie sich eine blutige Schneise durch die Reihen der Wachmänner. Sie wird jedoch zum Schluss schwer am Kopf verletzt, stürzt ins Meer und als sie wieder zu sich kommt, hat sie ihr Gedächtnis verloren und ist wieder so unschuldig wie ein Kind. Lucy wird von Kouta und Yuka an einem Strand aufgelesen."
            };
            Content = new StackLayout
            {
                Children =
                {
                    si
                }
            };
        }
    }

    public class pageVer : ContentPage
    {
        public pageVer()
        {
            var B = new Button
            {
                Text = "Start Game",
                TextColor = Color.Red,
                BackgroundColor = Color.Blue,
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            Content = B;
        }
    }

    public class pageVer1 : ContentPage
    {
        public pageVer1()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer3())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer6())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer8())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };


            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer2 : ContentPage
    {
        public pageVer2()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer3())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer15())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
 

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer4 : ContentPage
    {
        public pageVer4()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer11())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer14())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };


            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer3 : ContentPage
    {
        public pageVer3()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer15())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer12())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
 

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer8 : ContentPage
    {
        public pageVer8()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer6())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer11())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer16())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer8())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer3())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer14())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer5 : ContentPage
    {
        public pageVer5()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer8())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer12())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer15())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer6())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer6 : ContentPage
    {
        public pageVer6()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer6())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer15())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer12())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer7 : ContentPage
    {
        public pageVer7()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer15())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer12())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer9 : ContentPage
    {
        public pageVer9()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer17())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer6())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer12())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer10 : ContentPage
    {
        public pageVer10()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer6())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer3())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer15())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer11 : ContentPage
    {
        public pageVer11()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer3())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer16())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer12())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer8())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer17())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer12 : ContentPage
    {
        public pageVer12()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer8())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer11())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer6())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer14 : ContentPage
    {
        public pageVer14()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer15())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer12())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer15 : ContentPage
    {
        public pageVer15()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer3())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer15())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer17())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer16 : ContentPage
    {
        public pageVer16()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer3())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer9())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer5())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer10())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVer17 : ContentPage
    {
        public pageVer17()
        {
            var B1 = new Button
            {
                Text = " 1 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B2 = new Button
            {
                Text = " 2 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer4())),
            };
            var B3 = new Button
            {
                Text = " 3 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer11())),
            };
            var B4 = new Button
            {
                Text = " 4 ",
                Command = new Command(() => Navigation.PushAsync(new pageVerG())),
            };
            var B5 = new Button
            {
                Text = " 5 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer8())),
            };
            var B6 = new Button
            {
                Text = " 6 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer2())),
            };
            var B7 = new Button
            {
                Text = " 7 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer1())),
            };
            var B8 = new Button
            {
                Text = " 8 ",
                Command = new Command(() => Navigation.PushAsync(new pageVer7())),
            };

            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4, B5, B6, B7, B8
                }
            };

        }
    }

    public class pageVerG : ContentPage
    {
        public pageVerG()
        {
//            var textgew = new Label
//            {
//                Text = "Gewonnen!"
//            };
            var buttonxD = new Button
            {
                Text = "Gewonnen!                      Zurück",
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    buttonxD
                }
            };
        }
    }

    public class pageTs : ContentPage
    {
        public pageTs()
        {
            var B1 = new Button
            {
                Text = "Amv's",
                Command = new Command(() => Navigation.PushAsync(new pageA1())),
            };
            var B2 = new Button
            {
                Text = "Songs",
                Command = new Command(() => Navigation.PushAsync(new pageS1())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1, B2,
                }
            };
        }
    }

    public class pageS1 : ContentPage
    {
        public pageS1()
        {
            var B1 = new Button
            {
                Text = "Traurige Songs",
                Command = new Command(() => Navigation.PushAsync(new pageSs1())),
            };
            var B2 = new Button
            {
                Text = "Songs die Hoffnung machen",
                Command = new Command(() => Navigation.PushAsync(new pageSs2())),
            };
            var B3 = new Button
            {
                Text = "battle Songs",
                Command = new Command(() => Navigation.PushAsync(new pageSs3())),
            };
            var B4 = new Button
            {
                Text = "Filmsongs",
                Command = new Command(() => Navigation.PushAsync(new pageSs4())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3, B4
                }
            };
        }
    }

    public class pageSs3 : ContentPage
    {
        public pageSs3()
        {
            var B1 = new Button
            {
                Text = "Ashes Remain",
                Command = new Command(() => Navigation.PushAsync(new pageAR())),
            };
            var B2 = new Button
            {
                Text = "Our last Night",
                Command = new Command(() => Navigation.PushAsync(new pageOlN())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1, B2
                }
            };
        }
    }

    public class pageSs2 : ContentPage
    {
        public pageSs2()
        {
            var B1 = new Button
            {
                Text = "Ashes Remain",
                Command = new Command(() => Navigation.PushAsync(new pageAR())),
            };
            var B2 = new Button
            {
                Text = "Our last Night",
                Command = new Command(() => Navigation.PushAsync(new pageOlN())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1, B2
                }
            };
        }
    }

    public class pageAR : ContentPage
    {
        public pageAR()
        {
            var Text1 = new Label
            {
                Text = "1. On my Own"
            };

            var Text2 = new Label
            {
                Text = "2. End of Me"
            };

            var Text3 = new Label
            {
                Text = "3. Right Here"
            };

            var Text4 = new Label
            {
                Text = "4. I wont Run Away"
            };


            Content = new StackLayout
            {
                Children =
                {
                    Text1, Text2, Text3, Text4,
                }
            };
        }
    }

    public class pageOlN : ContentPage
    {
        public pageOlN()
        {
            var Text1 = new Label
            {
                Text = "1. Sunrise"
            };

            var Text2 = new Label
            {
                Text = "2. Same Old War"
            };

            var Text3 = new Label
            {
                Text = "3. Dark Storms"
            };

            var Text4 = new Label
            {
                Text = "4. I wont Run Away"
            };


            Content = new StackLayout
            {
                Children =
                {
                    Text1, Text2, Text3, Text4,
                }
            };
        }
    }

    public class pageVA11: ContentPage
    {
        public pageVA11()
        {
            var B1 = new Button
            {
                Text = "Youtube",
                Command = new Command(() => Navigation.PushAsync(new pageSs1())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1
                }
            };
        }
    }

    public class pageSs1 : ButtonPage
    {
        public pageSs1()
        {
            var B1 = CreatePushButton("Shine", new pageShine());
            var B2 = CreatePushButton("You Know you Like it", new pageYou());
            Content = new StackLayout
            {
                Children =
                {
                    B1, B2
                }
            };
        }
    }

    public class pageSs4 : ContentPage
    {
        public pageSs4()
        {
            var B1 = new Button
            {
                Text = "NCS",
                Command = new Command(() => Navigation.PushAsync(new pageNCS())),
            };
            var B2 = new Button
            {
                Text = "two Steps from the Hell",
                Command = new Command(() => Navigation.PushAsync(new pageHell())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1, B2,
                }
            };
        }
    }

    public class pageNCS : ContentPage
    {
        public pageNCS()
        {
            var Text1 = new Label
            {
                Text = "1. Faded"
            };

            var Text2 = new Label
            {
                Text = "2. Fade"
            };

            var Text3 = new Label
            {
                Text = "3. Candyland"
            };

            var Text4 = new Label
            {
                Text = "4. Force"
            };


            Content = new StackLayout
            {
                Children =
                {
                    Text1, Text2, Text3, Text4,
                }
            };
        }
    }

    public class pageShine : ContentPage
    {
        public pageShine()
        {
            var Text1 = new Label
            {
                Text = "Von NintendoFan12000"
            };

            var Text2 = new Label
            {
                Text = "[Shine] von [Spektrem " +
                "(NCS)" +
                " ]"
            };
            Content = new StackLayout
            {
                Children =
                {
                    Text1, Text2,

                }
            };
        }
    }

    public class pageYou : ContentPage
    {
        public pageYou()
        {
            var Text1 = new Label
            {
                Text = "von [AnimeUnity]"
            };

            var Text2 = new Label
            {
                Text = "[You know You Like it] von [Living in Fiction]"
            };
            Content = new StackLayout
            {
                Children =
                {
                    Text1, Text2,

                }
            };
        }
    }

    public class pageHell : ContentPage
    {
        public pageHell()
        {
            var Text1 = new Label
            {
                Text = "1. Heart of Courage"
            };

            var Text2 = new Label
            {
                Text = "2. Protectors from the Earth"
            };

            var Text3 = new Label
            {
                Text = "3. Strength of a Thousand Men"
            };

            var Text4 = new Label
            {
                Text = "4. Archangel"
            };

            var Text5 = new Label
            {
                Text = "5. Dragon Rider"
            };
            
            Content = new StackLayout
            {
                Children =
                {
                    Text1, Text2, Text3, Text4, Text5
                }
            };
        }
    }

    public class pageA1 : ContentPage
    {
        public pageA1()
        {
            var B1 = new Button
            {
                Text = "Von Mir selbst",
                Command = new Command(() => Navigation.PushAsync(new pageSSS1())),
            };
            var B2 = new Button
            {
                Text = "Von Anderen",
                Command = new Command(() => Navigation.PushAsync(new pageVA11())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1, B2
                }
            };
        }
    }

    public class pageSSS1 : ContentPage
    {
        public pageSSS1()
        {
            var B1 = new Button
            {
                Text = "My Fight [Rakudai Kishi no Caverly]",
                Command = new Command(() => Navigation.PushAsync(new pageVL())),
            };
            var B2 = new Button
            {
                Text = "Awakening [Rakudai Kishi no Caverly]",
                Command = new Command(() => Navigation.PushAsync(new pageVL1())),
            };
            var B3 = new Button
            {
                Text = "Against the world [Zetsuen no Tempest]",
                Command = new Command(() => Navigation.PushAsync(new pageVL2())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1, B2, B3
                }
            };
        }
    }

    public class pageVL : ContentPage
    {
        public pageVL()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "My Fight-From Ashes to New (Nightcore)",
                    }
                }
            };
        }
    }

    public class pageVL1 : ContentPage
    {
        public pageVL1()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "The Awakeining-Onlap",
                    }
                }
            };
        }
    }

    public class pageVL2 : ContentPage
    {
        public pageVL2()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Me against the World-Simple Plan",
                    }
                }

            };
        }
    }

    public class BE : ContentPage
    {
        public BE()
        {
            var B1 = new Button
            {
                Text = "Game Starten",
                Command = new Command(() => Navigation.PushAsync(new q1())),
            };
            Content = new StackLayout
            {
                Children =
                {
                    B1
                }
            };
        }
    }

    public class q1 : ButtonPage
    {
        public q1()
        {
            var BB = CreateImageButton("2.jpeg");
            var B1 = CreatePushButton("Tokyo Ghoul", new q2());
            var B2 = CreatePushButton("Another");
            var B3 = CreatePushButton("Bleach");
            var B4 = CreatePushButton("Shokugeki no shoma");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B2, B3, B4
                }
            };
        }
    }

    public class q2 : ButtonPage
    {
        public q2()
        {
            var BB = CreateImageButton("3.jpeg");
            var B1 = CreatePushButton("Hitman", new q3());
            var B2 = CreatePushButton("Fairy Tail");
            var B3 = CreatePushButton("Rakudai Kishi");
            var B4 = CreatePushButton("Tengen Toppa Gurren Lagann");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B4, B2, B3, B1
                }
            };
        }
    }

    public class q3 : ButtonPage
    {
        public q3()
        {
            var BB = CreateImageButton("4.jpeg");
            var B1 = CreatePushButton("Naruto", new q4());
            var B2 = CreatePushButton("Another");
            var B3 = CreatePushButton("Bleach");
            var B4 = CreatePushButton("Hellsing");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q4 : ButtonPage
    {
        public q4()
        {
            var BB = CreateImageButton("5.jpeg");
            var B1 = CreatePushButton("Gintama", new q5());
            var B2 = CreatePushButton("Tokyo Ghoul");
            var B3 = CreatePushButton("Angel Beats");
            var B4 = CreatePushButton("Fairy Tail");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B4, B2, B3
                }
            };
        }
    }

    public class q5 : ButtonPage
    {
        public q5()
        {
            var BB = CreateImageButton("6.jpeg");
            var B1 = CreatePushButton("Fate/stay night", new q6());
            var B2 = CreatePushButton("Fairy Tail");
            var B3 = CreatePushButton("Hellsing");
            var B4 = CreatePushButton("Rakudai Kishi");
          
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q6 : ButtonPage
    {
        public q6()
        {
            var BB = CreateImageButton("1.jpeg");
            var B1 = CreatePushButton("Sword art Online", new q7());
            var B2 = CreatePushButton("Rakudai kishi");
            var B3 = CreatePushButton("Shakugan no shana");
            var B4 = CreatePushButton("Gakusen no Toshi");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B3, B2, B4
                }
            };
        }

        public class q7 : ButtonPage
        {
            public q7()
            {
                var BB = CreateImageButton("7.jpeg");
                var B1 = CreatePushButton("Tengen Toppa Lagunn", new q21());
                var B2 = CreatePushButton("Sword art Online");
                var B3 = CreatePushButton("Shakugan no shana");
                var B4 = CreatePushButton("Another");
                Content = new StackLayout
                {
                    Children =
                    {
                        BB, B3, B4, B2, B1
                    }
                };
            }
        }

    }

    public class q8 : ButtonPage
    {
        public q8()
        {
            var BB = CreateImageButton("8.jpeg");
            var B1 = CreatePushButton("Bleach", new q9());
            var B2 = CreatePushButton("Serakai");
            var B3 = CreatePushButton("Rakudai Kishi");
            var B4 = CreatePushButton("Fairy Tail");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B2, B1, B4
                }
            };
        }
    }

    public class q9 : ButtonPage
    {
        public q9()
        {
            var BB = CreateImageButton("9.jpeg");
            var B1 = CreatePushButton("Another", new q10());
            var B2 = CreatePushButton("Projekt K");
            var B3 = CreatePushButton("HunterxHunter");
            var B4 = CreatePushButton("Sarekai");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q10 : ButtonPage
    {
        public q10()
        {
            var BB = CreateImageButton("10.jpeg");
            var B1 = CreatePushButton("HunterxHunter", new q11());
            var B2 = CreatePushButton("Serakai");
            var B3 = CreatePushButton("Shakugan no shana");
            var B4 = CreatePushButton("Maid-sama");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B2, B1, B4
                }
            };
        }
    }

    public class q11 : ButtonPage
    {
        public q11()
        {
            var BB = CreateImageButton("11.jpeg");
            var B1 = CreatePushButton("One Punchman", new q12());
            var B2 = CreatePushButton("Projekt K");
            var B3 = CreatePushButton("HunterXHunter");
            var B4 = CreatePushButton("Sarakei");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q12: ButtonPage
    {
        public q12()
        {
            var BB = CreateImageButton("12.jpeg");
            var B1 = CreatePushButton("Hellsing", new q13());
            var B2 = CreatePushButton("Serakai");
            var B3 = CreatePushButton("Naruto");
            var B4 = CreatePushButton("Another");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q13 : ButtonPage
    {
        public q13()
        {
            var BB = CreateImageButton("13.jpeg");
            var B1 = CreatePushButton("Naruto", new q14());
            var B2 = CreatePushButton("Maid-sama");
            var B3 = CreatePushButton("Shakugan no shana");
            var B4 = CreatePushButton("Fairy Tail");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B3, B2, B4
                }
            };
        }
    }

    public class q14 :ButtonPage
    {
        public q14()
        {
            var BB = CreateImageButton("14.jpeg");
            var B1 = CreatePushButton("Guilty Crown", new q15());
            var B2 = CreatePushButton("Serakai");
            var B3 = CreatePushButton("Hellsing");
            var B4 = CreatePushButton("Gintama");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B2, B1, B4
                }
            };
        }
    }

    public class q15 :ButtonPage
    {
        public q15()
        {
            var BB = CreateImageButton("17.jpeg");
            var B1 = CreatePushButton("Magi", new q16());
            var B2 = CreatePushButton("One Piece");
            var B3 = CreatePushButton("One Punchman");
            var B4 = CreatePushButton("Fairy Tail");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B4, B3, B2
                }
            };
        }
    }

    public class q16 : ButtonPage
    {
        public q16()
        {
            var BB = CreateImageButton("Images-20.jpeg");
            var B1 = CreatePushButton("One Piece", new q17());
            var B2 = CreatePushButton("Rakudai kishi");
            var B3 = CreatePushButton("Full Metall Alchemist");
            var B4 = CreatePushButton("Fate/stay Night");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q17 : ButtonPage
    {
        public q17()
        {
            var BB = CreateImageButton("Images-21.jpeg");
            var B1 = CreatePushButton("Full Metall Alchemist", new q18());
            var B2 = CreatePushButton("Serakai");
            var B3 = CreatePushButton("Shakugan no shana");
            var B4 = CreatePushButton("Maid-sama");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B4, B2, B1
                }
            };
        }
    }

    public class q18 : ButtonPage
    {
        public q18()
        {
            var BB = CreateImageButton("Images-22.jpeg");
            var B1 = CreatePushButton("Code: Geas", new q19());
            var B2 = CreatePushButton("Tokyo Ghoul");
            var B3 = CreatePushButton("Hellsing");
            var B4 = CreatePushButton("Rakudai Kishi");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q19 : ButtonPage
    {
        public q19()
        {
            var BB = CreateImageButton("Images-23.jpeg");
            var B1 = CreatePushButton("Shokugeki no Soma", new q20());
            var B2 = CreatePushButton("Pokemon");
            var B3 = CreatePushButton("Hellsing");
            var B4 = CreatePushButton("Tokyo Ghoul");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B4, B2, B3
                }
            };
        }
    }

    public class q20 : ButtonPage
    {
        public q20()
        {
            var BB = CreateImageButton("Images-24.jpeg");
            var B1 = CreatePushButton("Pokemon", new q21());
            var B2 = CreatePushButton("Rakudai kishi");
            var B3 = CreatePushButton("Shakugan no shana");
            var B4 = CreatePushButton("Maid-sama");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q21 : ButtonPage
    {
        public q21()
        {
            var BB = CreateImageButton("Images-25.jpeg");
            var B1 = CreatePushButton("Dragon Ball", new q22());
            var B2 = CreatePushButton("Fairy Tail");
            var B3 = CreatePushButton("Gakusen no Toshi");
            var B4 = CreatePushButton("hellsing");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B3, B1, B2, B4
                }
            };
        }
    }

    public class q22 : ButtonPage
    {
        public q22()
        {
            var BB = CreateImageButton("Images-26.jpeg");
            var B1 = CreatePushButton("Soul Eater", new q23());
            var B2 = CreatePushButton("Rakudai kishi");
            var B3 = CreatePushButton("Bleach");
            var B4 = CreatePushButton("Tokyo Ghoul");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B2, B4, B1, B3
                }
            };
        }
    }

    public class q23 : ButtonPage
    {
        public q23()
        {
            var BB = CreateImageButton("Images-27.jpeg");
            var B1 = CreatePushButton("Angel Beats", new q24());
            var B2 = CreatePushButton("Fairy Tail");
            var B3 = CreatePushButton("Gakusen no Toshi");
            var B4 = CreatePushButton("Pokemon");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B2, B4, B3, B1
                }
            };
        }
    }

    public class q24 : ButtonPage
    {
        public q24()
        {
            var BB = CreateImageButton("Images-28.jpeg");
            var B1 = CreatePushButton("Horizon log", new q25());
            var B2 = CreatePushButton("Another");
            var B3 = CreatePushButton("Maid-sama");
            var B4 = CreatePushButton("Sword art Online");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B2, B4, B3, B1
                }
            };
        }
    }

    public class q25 : ButtonPage
    {
        public q25()
        {
            var BB = CreateImageButton("Images-29.jpeg");
            var B1 = CreatePushButton("Kekkei Sensen", new q26());
            var B2 = CreatePushButton("Assination Classroom");
            var B3 = CreatePushButton("Magi");
            var B4 = CreatePushButton("Shakugan no shana");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B4, B3, B2
                }
            };
        }
    }

    public class q26 : ButtonPage
    {
        public q26()
        {
            var BB = CreateImageButton("Images-40.jpeg");
            var B1 = CreatePushButton("Sword Art Online", new q27());
            var B2 = CreatePushButton("Fairy Tail");
            var B3 = CreatePushButton("Kekkei Sensen");
            var B4 = CreatePushButton("Soul eater");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B2, B1, B3, B4
                }
            };
        }
    }

    public class q27 : ButtonPage
    {
        public q27()
        {
            var BB = CreateImageButton("Images-41.jpeg");
            var B1 = CreatePushButton("Code: Geas", new q28());
            var B2 = CreatePushButton("Rakudai kishi");
            var B3 = CreatePushButton("Bleach");
            var B4 = CreatePushButton("Sword art Online");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B2, B4, B1, B3
                }
            };
        }
    }

    public class q28 : ButtonPage
    {
        public q28()
        {
            var BB = CreateImageButton("Images-43.jpeg");
            var B1 = CreatePushButton("Highschool DxD", new q29());
            var B2 = CreatePushButton("Gakusen Toshi");
            var B3 = CreatePushButton("Soul Eater");
            var B4 = CreatePushButton("Kekkei Sensen");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B2, B3, B4
                }
            };
        }

        public class q29 : ButtonPage
        {
            public q29()
            {
                var BB = CreateImageButton("Images-44.jpeg");
                var B1 = CreatePushButton("Shakugan no shana", new q30());
                var B2 = CreatePushButton("Fairy Tail");
                var B3 = CreatePushButton("Hitman");
                var B4 = CreatePushButton("Dragon Ball");
                Content = new StackLayout
                {
                    Children =
                    {
                        BB, B2, B4, B3, B1

                    }
                };
            }
        }
    }

    public class q30 : ButtonPage
    {
        public q30()
        {
            var BB = CreateImageButton("Images-45.jpeg");
            var B1 = CreatePushButton("Bleach", new q());
            var B2 = CreatePushButton("Rakudai kishi");
            var B3 = CreatePushButton("Gakusen no Toshi");
            var B4 = CreatePushButton("Sword art Online");
            Content = new StackLayout
            {
                Children =
                {
                    BB, B1, B2, B3, B4
                }
            };
        }
    }

    public class q : ContentPage
    {
        public q()
        {
            var Text = new Button
            {
                Text = "Geschaft!",
                Command = new Command(() => Navigation.PushAsync(new PageWithButton())),
            };
            Content = Text;
        }
    }

    public class ButtonPage : ContentPage
    {

        protected Button CreateImageButton(string fileImageSource)
        {
            var Bild = new FileImageSource
            {
                File = fileImageSource
            };
            
            return new Button
            {
                Image = Bild,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
        }

        public  Button CreatePushButton(string text, ContentPage page = null)
        {
            if (page == null)
                page = new PageWithButton();
            
            return  new Button
            {
                Text = text,
                Command = new Command(() => Navigation.PushAsync(page)),
                TextColor = Color.Red,
            };
        }
    }

}