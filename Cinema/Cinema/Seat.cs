using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Cinema
{
    class Seat : Button
    {
        public Seat() : base()
        {
            Background = Brushes.Green;
            Margin = new System.Windows.Thickness(5);
            Click += toggleColor;
        }

        public void toggleColor(object sender, RoutedEventArgs e)
        {
            if (Background == Brushes.Green)
            {
                Background = Brushes.Red;
            }
            else
            {
                Background = Brushes.Green;
            }
        }
    }
}
