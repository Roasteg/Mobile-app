using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konovalov_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        public Valgusfoor()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int clicc = 0;
        private void toggle_Clicked(object sender, EventArgs e)
        {
            clicc++;
            if(clicc%2==0)
            {
                while(true) //
                {
                    int value = rnd.Next(0, 2); // создаём переменную, в которую будет записываться это число
                    if (value == 0) // создаём варианты того, что может произойти
                    {
                        yl.BackgroundColor = Color.White;
                        lg.BackgroundColor = Color.White;
                        rd.BackgroundColor = Color.Red;
                        //Thread.Sleep(1000); // задержка после смены цвета
                    }
                    else if (value == 1)
                    {
                        rd.BackgroundColor = Color.White;
                        yl.BackgroundColor = Color.White;
                        lg.BackgroundColor = Color.LightGreen;
                        //Thread.Sleep(1000);
                        
                    }
                    else if (value == 2)
                    {
                        rd.BackgroundColor = Color.White;
                        lg.BackgroundColor = Color.White;
                        yl.BackgroundColor = Color.Yellow;
                        //Thread.Sleep(1000);
                    }

                }                
            }
            else
            {
                while (false) ; //остановка смены цветов
                yl.BackgroundColor = Color.White;
                lg.BackgroundColor = Color.White;
                rd.BackgroundColor = Color.White;

            }
      
            
        }
    }
}