using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MadLibsApp
{
    public partial class MainPage : ContentPage
    {
        string story = "Hi my name is Tom Holland, but my friends call me fun whippersnapper. " +
            "My favorite color is the color of scissors and my favorite thing to do is dance. " +
            "My parents were a cheetah and baker, which is why we lived in theater. " +
            "You probably know me from my TV commercial for soda. I'm the one who says, 'Life is like a box of chocolates' at the very end!";
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnGenerateMadlib_Clicked(object sender, EventArgs e)
        {

        }
    }
}
