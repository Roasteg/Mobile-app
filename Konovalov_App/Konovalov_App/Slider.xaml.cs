using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konovalov_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slider : ContentPage
    {
        public Slider()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        
        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(sender == Slider1)
            {
                redLabel.Text = String.Format("{0:X2}", (int)e.NewValue);
            }
            else if (sender==Slider2)
            {
                redLabel.Text = String.Format("{0:X2}", (int)e.NewValue);
            }
            else if (sender==Slider3)
            {
                redLabel.Text = String.Format("{0:X2}", (int)e.NewValue);
            }
            box.Color = System.Drawing.Color.FromArgb((int)Slider1.Value,
                (int)Slider2.Value,
                (int)Slider3.Value);            
        }

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue>0)
            {
                Slider1.Value = e.NewValue;
            }
        }
        Random clr = new Random();
        private async void Rand_Clicked(object sender, EventArgs e)
        {
            Slider1.Value = clr.Next(0, 255);
            Slider2.Value = clr.Next(0, 255);
            Slider3.Value = clr.Next(0, 255);

        }

    }
}