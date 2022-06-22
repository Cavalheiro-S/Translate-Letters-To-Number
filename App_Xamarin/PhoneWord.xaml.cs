using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhoneWord : ContentPage
    {
        public PhoneWord()
        {
            InitializeComponent();
            btnTranslate.Clicked += BtnTranslate_Clicked;
            btnCall.Clicked += BtnCall_Clicked;
        }

        async private void BtnCall_Clicked(object sender, EventArgs e)
        {
            string[] numberToCall = btnCall.Text.Split(' ');
            if(await this.DisplayAlert("Discar número", "Você gostaria de discar o número: " + numberToCall[1], "Discar", "Não"))
                PhoneDialer.Open(numberToCall[1]);
        }

        private void BtnTranslate_Clicked(object sender, EventArgs e)
        {
            string textToTranslate = etTextToNumber.Text;
            string textTranslated = TranslateNumber(textToTranslate);
            btnCall.Text = "CALL " + textTranslated;
        }

        private string TranslateNumber(string textToTranslate)
        {
            char[] wordToTranslate = textToTranslate.ToCharArray();
            string wordTranslated = "";
            foreach(char word in wordToTranslate)
            {
                switch (word)
                {
                    case '+':
                        wordTranslated += "0";
                        break;

                    case '-':
                        wordTranslated += "1";
                        break;

                    case 'a':
                    case 'b':
                    case 'c':
                        wordTranslated += "2";
                        break;

                    case 'd':
                    case 'e':
                    case 'f':
                        wordTranslated += "3";
                        break;

                    case 'g':
                    case 'h':
                    case 'i':
                        wordTranslated += "4";
                        break;

                    case 'j':
                    case 'k':
                    case 'l':
                        wordTranslated += "5";
                        break;

                    case 'm':
                    case 'n':
                    case 'o':
                        wordTranslated += "6";
                        break;

                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        wordTranslated += "7";
                        break;

                    case 't':
                    case 'u':
                    case 'v':
                        wordTranslated += "8";
                        break;

                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        wordTranslated += "9";
                        break;

                    default:
                        wordTranslated += word;
                        break;
                }
            }

            return wordTranslated;
        }
    }
}