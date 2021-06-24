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

        /// <summary>
        /// Randomly selects a madlib story to use with the provided input
        /// from the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerateMadlib_Clicked(object sender, EventArgs e)
        {
            // random values are retrieved
            Random random = new Random();
            int randomNum = random.Next(3);

            // select a story to show
            if (randomNum == 0)
            {
                LblMadlib.Text = $"Hi my name is {EntCeleb.Text}, but my friends call me the {EntAdjective.Text} {EntFood.Text}. " +
                $"My favorite color is the color of {EntThings.Text} and my favorite thing to do is {EntVerb.Text} while blindfolded. " +
                $"My parents were a {EntAnimal.Text} and {EntJob.Text}, which is why we lived in a {EntPlace.Text}. " +
                $"You probably know me from my TV commercials for {EntBuy.Text}. I'm the one who says, '{EntPhrase.Text}!' at the very end!";
            }
            else if (randomNum == 1)
            {
                LblMadlib.Text = $"I once saw {EntCeleb.Text} running out of a {EntPlace.Text}, yelling the words '{EntPhrase.Text}!' " +
                    $"I stopped eating my {EntAdjective.Text} {EntFood.Text} and jumped on my trusty {EntAnimal.Text} to go see what was going on in the {EntPlace.Text}. " +
                    $"To my surprise, I saw a {EntJob.Text} trying to {EntVerb.Text} with a bunch of {EntThings.Text}... " +
                    $"I promptly left and decided it would be best to spend the rest of my day shopping for {EntBuy.Text}.";
            }
            else
            {
                LblMadlib.Text = $"Today I went to my favorite taco stand called the '{EntAdjective.Text} {EntAnimal.Text}'. " +
                    $"Unlike most food stands, they cook and prepare the food in a {EntPlace.Text} while you {EntVerb.Text}. " +
                    $"The best thing on the menu is the {EntAdjective.Text} {EntFood.Text}! " +
                    $"And instead of ground beef they fill their tacos with {EntThings.Text}, cheese, and top it off with a salsa made from {EntBuy.Text}. " +
                    $"If that doesn't make your mouth water, then it's just like what my {EntJob.Text}, {EntCeleb.Text}, always says: '{EntPhrase.Text}!'";
            }
        }
    }
}
