﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App_Xamarin.PhoneWord();
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
