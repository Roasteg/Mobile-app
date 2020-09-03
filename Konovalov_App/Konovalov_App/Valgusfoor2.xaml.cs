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
            Label punane = new Label()
            {
                Text = "punane",
                TextColor = Color.Red,
                FontSize = 30,

            };
            Label kollane = new Label()
            {
                Text = "kollane",
                TextColor = Color.Yellow,
                FontSize = 30,

            };
            Label roheline = new Label()
            {
                Text = "roheline",
                TextColor = Color.Green,
                FontSize = 30,

            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = {punane, kollane, roheline}

            };
            Content = stackLayout;
        }

    }
}