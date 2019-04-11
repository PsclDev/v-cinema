using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MaterialDesignThemes;

namespace Cinema
{
    class Seat : Button
    {
        public Seat() : base()
        {
            Style = (Style)Resources["MaterialDesignRaisedButton"];
            FontFamily = new FontFamily("Raleway");
            Foreground = Brushes.Black;
            Background = Brushes.Lime;
            Margin = new System.Windows.Thickness(5);
            Click += toggleColor;
        }

        public void toggleColor(object sender, RoutedEventArgs e)
        {
            if (Background == Brushes.Lime)
            {
                Background = Brushes.IndianRed;
            }
            else
            {
                Background = Brushes.Lime;
            }
        }
    }
}
