using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void Activity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity1());
        }

        public async void Activity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2());
        }

        public async void Activity03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity3());
        }

        public async void Activity04(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity4());
        }

        public async void Activity05(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity5());
        }

        public async void Activity06(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity6());
        }
    }
}
