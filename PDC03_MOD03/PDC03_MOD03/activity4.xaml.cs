using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity4 : ContentPage
    {
        public activity4()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            await DisplayAlert("Registered Voter", "You are a now registered voter located in Brgy. Duale, Limay, Bataan. Please vote wisely!", "OK");
        }
    }
}