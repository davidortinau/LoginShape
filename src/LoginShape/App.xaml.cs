using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginShape
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental", "AppTheme_Experimental", "IndicatorView_Experimental" });

            InitializeComponent();

            MainPage = new MainPage();
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
