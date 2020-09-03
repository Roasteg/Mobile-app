using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Konovalov_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Button on = new Button()
            {
                
                Text = "Start",
                FontSize = 30,
                FontAttributes= FontAttributes.Bold

            };
            Label punane = new Label()
            {
                Text = "punane",
                TextColor = Color.Red,
                FontSize = 30,

            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                Margin = new Thickness(80, 0, 80, 0),
                CornerRadius = 90,
            };
            Label kollane = new Label()
            {
                Text = "kollane",
                TextColor = Color.Yellow,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold

            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                Margin = new Thickness( 80, 0, 80, 0),
                CornerRadius = 90,

                
                
            };
            Label roheline = new Label()
            {
                Text = "roheline",
                TextColor = Color.Green,
                FontSize = 30,

            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                Margin = new Thickness(80, 0, 80, 0),
                CornerRadius = 90,
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = {pun, kol, roh}

            };
            Content = stackLayout;
            stackLayout.Orientation = StackOrientation.Horizontal;
            

           

        }
     

    }
}