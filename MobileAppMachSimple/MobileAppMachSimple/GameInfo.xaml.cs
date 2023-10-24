using MobileAppMachSimple.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppMachSimple
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameInfo : ContentPage
    {
        public Game Game { get; set; }

        public GameInfo()
        {
            InitializeComponent();
        }

        private async void Del_Clicked(object sender, EventArgs e)
        {
            await App.DB.RemoveGame(Game);
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {

            if (Game.Title != "" && Game.Description != "" && comboBox.SelectedItem != null)
            {
                Game.Title = GameName.Text;
                Game.Description = GameDiscription.Text;
                Game.IdPublisher = ((Publisher)comboBox.SelectedItem).Id;
                Game.Publish = (Publisher)comboBox.SelectedItem;
                await App.DB.EditGame(Game);
            }
        }
    }
}