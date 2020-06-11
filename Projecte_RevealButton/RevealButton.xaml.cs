using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projecte_RevealButton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RevealButton : ContentView
    {
        public RevealButton()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await ExteriorFrame.FadeTo(0);
            ExteriorFrame.IsVisible = false;
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            ExteriorFrame.IsVisible = true;
            await ExteriorFrame.FadeTo(1);
        }
    }
}