using MobileAppMachSimple.Class;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppMachSimple
{
    public partial class App : Application
    {
        private static GameDB db;

        public static GameDB DB
        {
            get
            {
                if (db == null)
                    db = new GameDB();
                return db;
            }
        }

        public App()
        {
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
