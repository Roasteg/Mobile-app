using System;
using System.Collections.Generic;
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
                FontAttributes = FontAttributes.Bold
            };
            kollane = new Label()
            {
                Text = "kollane",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            roheline = new Label()
            {
                Text = "roheline",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
                HorizontalOptions = LayoutOptions.Center,

            };
            pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
                HorizontalOptions = LayoutOptions.Center,
            };
            roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
                HorizontalOptions = LayoutOptions.Center,
            };
            on = new Button()
            {
                WidthRequest = 60,
                HeightRequest = 60,
                Text = "start",
            };
            off = new Button()
            {
                WidthRequest = 60,
                HeightRequest = 60,
                Text = "Stop",
                HorizontalOptions = LayoutOptions.End,

            };
            StackLayout stackLayout = new StackLayout()
            {

                Padding = 50,
                Children = { pun, kol, roh, on, off }
            };

            // StackLayout lay = new StackLayout()
            // {
            //     Children = {on, off}
            // };

            on.Clicked += On_Clicked;
            off.Clicked += Off_Clicked;


            Content = stackLayout;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);


        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == pun) { punane.Text = "Oota!"; }
            if (fr== kol) {kollane.Text="Valmistsa!"; }
            if (fr == roh) { roheline.Text = "On vaja sõitma!"; }
        }

        private void Off_Clicked(object sender, EventArgs e)
        {
            kollane.Text = "kollane";
            punane.Text = "punane";
            roheline.Text = "roheline";
            pun.BackgroundColor = Color.Gray;
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.Gray;
            cycle = false;
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