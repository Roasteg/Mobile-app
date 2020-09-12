using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Konovalov_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label punane, kollane, roheline;
        Frame pun, kol, roh;
        Button on, off;
        bool on_off;
        public Valgusfoor2()
        {
            //InitializeComponent();

            punane = new Label()
            {
                Text = "punane",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            kollane = new Label()
            {
                Text = "kollane",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            roheline = new Label()
            {
                Text = "roheline",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,


            };
            pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,

            };
            roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,

            };
            on = new Button()
            {                
                Text = "start",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,

            };
            off = new Button()
            {                
                Text = "Stop",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,

            };
            StackLayout btns = new StackLayout()
            {
                Orientation=StackOrientation.Horizontal,
                HeightRequest = 65,
                Children = {on, off}
            };
            StackLayout stackLayout = new StackLayout()
            {
               Children = { pun, kol, roh, btns}
            };
  

            on.Clicked += On_Clicked;
            off.Clicked += Off_Clicked;


            Content = stackLayout;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);
            kol.GestureRecognizers.Add(tap);
            roh.GestureRecognizers.Add(tap);



        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (clicc == 0)
            {
                punane.Text = "Lülita valgusfoor";
            }
            else
            {               
                if (fr == pun) { punane.Text = "Oota!"; }
                else if (fr == kol) { kollane.Text = "Valmistsa!"; }
                else if (fr == roh) { roheline.Text = "On vaja sõitma!"; }
            }
           
        }

        private void Off_Clicked(object sender, EventArgs e)
        {
            On_Clicked
            kollane.Text = "kollane";
            punane.Text = "punane";
            roheline.Text = "roheline";
            pun.BackgroundColor = Color.Gray;
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.Gray;
            clicc = 0;
            
            

        }
        int clicc = 0;
        private Random rnd = new Random();
        bool cycle = true;
        private async void On_Clicked(object sender, EventArgs e)
        {
            
            clicc++;
            cycle = true;
            while (cycle)
            {
                if (clicc % 2 == 0)
                {                   
                    kollane.Text = "";
                    punane.Text = "";
                    roheline.Text = "";
                    Color randomColor = System.Drawing.Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    Color randomColor2 = System.Drawing.Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    Color randomColor3 = System.Drawing.Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    pun.BackgroundColor = randomColor;
                    kol.BackgroundColor = randomColor2;
                    roh.BackgroundColor = randomColor3;
                    await Task.Run(() => Thread.Sleep(1000));
                    
                }


            
                else
                {
                    {
                        kollane.Text = "kollane";
                        punane.Text = "punane";
                        roheline.Text = "roheline";
                        roh.BackgroundColor = Color.Gray;
                        kol.BackgroundColor = Color.Gray;
                        pun.BackgroundColor = Color.Red;
                        await Task.Run(() => Thread.Sleep(1000));
                        roh.BackgroundColor = Color.Gray;
                        kol.BackgroundColor = Color.Yellow;
                        pun.BackgroundColor = Color.Gray;
                        await Task.Run(() => Thread.Sleep(1000));
                        roh.BackgroundColor = Color.Green;
                        kol.BackgroundColor = Color.Gray;
                        pun.BackgroundColor = Color.Gray;
                        await Task.Run(() => Thread.Sleep(1000));
         

                    }

                }
            }
        }
    }
}