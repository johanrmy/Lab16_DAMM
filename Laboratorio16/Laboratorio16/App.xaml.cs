﻿using Laboratorio16.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio16
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CharacterList();
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
