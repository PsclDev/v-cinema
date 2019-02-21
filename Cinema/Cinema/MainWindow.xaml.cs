using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;

namespace Cinema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int ROWS = 4;
        private const int COLUMNS = 5;
        private List<List<Seat>> room2 = new List<List<Seat>>();
        private Room room;

        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        public MainWindow()
        {
            InitializeComponent();
            //createRoom();
            //createModularRoom();
            room = new Room(ROWS, COLUMNS);
            updateSeatDisplay();
            AllocConsole();
        }

        public void updateSeatDisplay()
        {
            _Room_Grid.Children.Clear();
            _Room_Grid.ColumnDefinitions.Clear();
            _Room_Grid.RowDefinitions.Clear();

            for (int j = 0; j < room.seats[0].Count; j++)
            {
                _Room_Grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < room.seats.Count; i++)
            {
                _Room_Grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < room.seats.Count; i++)
            {
                for (int j = 0; j < room.seats[0].Count; j++)
                {
                    Seat s = room.seats[i][j];
                    //s.Content = string.Format("Seat: {0}, R {1}, S {2}", (4 * i) + j + 1, i + 1, j + 1);
                    s.Content = string.Format("R {0}, S {1}", i, j);
                    Grid.SetRow(s, i);
                    Grid.SetColumn(s, j);
                    _Room_Grid.Children.Add(s);

                }
            }
        }

        private void Btn_AddColumn_Click(object sender, RoutedEventArgs e)
        {
            this.room.addRow();

            updateSeatDisplay();
        }

        private void Btn_AddRow_Click(object sender, RoutedEventArgs e)
        {
            this.room.addColumn();

            updateSeatDisplay();
        }

        private void Btn_RemoveColumn_Click(object sender, RoutedEventArgs e)
        {
            this.room.removeRow();

            updateSeatDisplay();
        }

        private void Btn_RemoveRow_Click(object sender, RoutedEventArgs e)
        {
            this.room.removeCoumn();

            updateSeatDisplay();
        }
    }
}
