using System;

using Xamarin.Forms;

namespace freight
{
    public class App : Application
    {
        public App()
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
         
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    
                    Children =
                    {
                        BF
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
    }
}

