using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] Auditorium = new Button[6, 9];

            for (int row = 0; row < 6; row++)
            {
                for (int seat = 0; seat < 9; seat++)
                {
                    Auditorium[row, seat] = new Button
                    {
                        FlatStyle = FlatStyle.Flat,
                        Height = 25,
                        Width = 40,
                        Parent = this,
                        Left = ( 10 + (seat * 100)),
                        Top = ( 10 + (row * 100)),
                        Text = $"{row + 1}/{seat + 1}",
                        BackColor = Color.Lime
                    };
                    Auditorium[row, seat].Click += Book;
                }
            }
        }

        private void Book(object sender, EventArgs e)
        {
            Button b = ((Button)sender);

            if (b.BackColor == Color.Lime)
                b.BackColor = Color.Red;
            else
                b.BackColor = Color.Lime;
        }
    }
}
