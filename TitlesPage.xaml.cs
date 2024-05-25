using PocketReferenceBook.Views;
using Microsoft.Maui.Controls;


namespace PocketReferenceBook
{

    public partial class TitlesPage : ContentPage
    {
        public TitlesPage()
        {
            InitializeComponent();
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            // Perform navigation based on the clicked button text
            switch (buttonText)
            {
                case "Standard Drill Size Conversions":
                    await Navigation.PushAsync(new Page02());
                    break;
                case "Standard Thread Forms":
                    await Navigation.PushAsync(new Page03());
                    break;
                case "Tapping Drill Sizes For Fluteless Taps":
                    await Navigation.PushAsync(new Page04());
                    break;
                case "Thread Notation":
                    await Navigation.PushAsync(new Page05());
                    break;
                case "Metric Screw and Hole Sizes":
                    await Navigation.PushAsync(new Page06());
                    break;
                case "Tensile Strength and Hardness":
                    await Navigation.PushAsync(new Page07());
                    break;
                case "Material Groups":
                    await Navigation.PushAsync(new Page08());
                    break;
                case "Cutting Speed Calculator":
                    await Navigation.PushAsync(new Page09());
                    break;
                case "Basic Forms Of Heat Treatment":
                    await Navigation.PushAsync(new Page10());
                    break;
                case "Lubricant Selection":
                    await Navigation.PushAsync(new Page11());
                    break;
                case "Standards For Engineering Drawings":
                    await Navigation.PushAsync(new Page12());
                    break;
                case "Common Abbreviations Used In Engineering Drawings":
                    await Navigation.PushAsync(new Page13());
                    break;
                case "Hole And Shaft Tolerances":
                    await Navigation.PushAsync(new Page14());
                    break;
                case "Common CNC Control Codes":
                    await Navigation.PushAsync(new Page15());
                    break;
                case "Axis Nomenclature For Machine Tools":
                    await Navigation.PushAsync(new Page16());
                    break;
                case "Screwed and Weldon Shank Dimensions":
                    await Navigation.PushAsync(new Page17());
                    break;
                case "Morse Taper Shank Dimensions":
                    await Navigation.PushAsync(new Page18());
                    break;
                case "DIN, BT and ISO Shank Dimensions":
                    await Navigation.PushAsync(new Page19());
                    break;
                case "Co-Ordinates For Equally Pitched Holes":
                    await Navigation.PushAsync(new Page20());
                    break;
                case "Table Of Chords":
                    await Navigation.PushAsync(new Page21());
                    break;
                case "Trigonometry Formulae":
                    await Navigation.PushAsync(new Page22());
                    break;
                case "Malleable Material Bending Allowances":
                    await Navigation.PushAsync(new Page23());
                    break;
                case "Sines and Cosines":
                    await Navigation.PushAsync(new Page24());
                    break;
                case "Tangents and Cotangents":
                    await Navigation.PushAsync(new Page25());
                    break;
                case "Abbreviations and Formulae":
                    await Navigation.PushAsync(new Page26());
                    break;
                case "Weights And Measures Systems":
                    await Navigation.PushAsync(new Page27());
                    break;
            }
        }
    }
}