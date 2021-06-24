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
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnGenerateMadlib_Clicked(object sender, EventArgs e)
        {
            LblMadlib.Text = $"Hi my name is {EntCeleb.Text}, but my friends call me the {EntAdjective.Text} {EntFood.Text}. " +
            $"My favorite color is the color of {EntThings.Text} and my favorite thing to do is {EntVerb.Text} upside down. " +
            $"My parents were a {EntAnimal.Text} and {EntJob.Text}, which is why we lived in {EntPlace.Text}. " +
            $"You probably know me from my TV commercials for {EntBuy.Text}. I'm the one who says, '{EntPhrase.Text}' at the very end!";
        }
    }
}
