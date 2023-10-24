using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileAppMachSimple
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void collectionView_SelectionChenged(object sender, SelectionChangedEventArgs e)
        {
            var AddPage = new AddGame();
                App.Current.MainPage.Navigation.PushAsync(AddPage);
        }
    }
}
