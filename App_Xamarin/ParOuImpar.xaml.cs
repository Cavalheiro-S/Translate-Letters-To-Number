using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
            btnExecutar.Clicked += BtnExecutar_Clicked;
            etNumber.TextChanged += EtNumber_TextChanged;
        }

        private void EtNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbResultado.Text = "";
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            int numero = Int32.Parse(etNumber.Text);

            if(numero % 2 == 0)
            {
                lbResultado.Text = "É par";
            }
            else
            {
                lbResultado.Text = "É Impar";
            }

        }
    }
}