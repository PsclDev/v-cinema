using System.Collections.Generic;

namespace Cinema
{
    class Room
    {
        private int rows;
        private int columns;
        public List<List<Seat>> seats;

        public Room(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;

            seats = new List<List<Seat>>();

            for (int i = 0; i < rows; i++)
            {
                seats.Add(new List<Seat>());

                for (int j = 0; j < columns; j++)
                {
                    seats[i].Add(new Seat());
                }
            }
        }

        public void addRow()
        {
            seats.Add(new List<Seat>());

            for (int i = 0; i < seats[0].Count; i++)
            {
                seats[seats.Count - 1].Add(new Seat());
            }
        }

        public void removeRow()
        {
            seats.RemoveAt(seats.Count - 1);
        }

        public void addColumn()
        {
            for (int i = 0; i < seats.Count; i++)
            {
                seats[i].Add(new Seat());
            }
        }

        public void removeCoumn()
        {
            for (int i = 0; i < seats.Count; i++)
            {
                seats[i].RemoveAt(seats[i].Count - 1);
            }
        }
    }
}
