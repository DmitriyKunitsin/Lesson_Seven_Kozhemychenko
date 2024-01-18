namespace Programming
{
    class MaxMass
    {
        private int[] mass;

        public MaxMass(int col)
        {
            if (col > 0)
            {
                mass = new int[col];
            }
            else
            {
                throw new ArgumentException("Индекс имеет недопустимое значение (ожидалось число большее или равное двум)!");
            }
        }

        public int this[int col]
        {
            get
            {
                if (col >= 0 && col < mass.GetLength(0))
                {
                    return mass[col];
                }
                else { throw new ArgumentException("Индекс имеет недопустимое значение!"); }
            }
            set
            {
                if (col >= 0 && col < mass.GetLength(0))
                {
                    mass[col] = value;
                }
                else { throw new ArgumentException("Индекс имеет недопустимое значение!"); }
            }
        }
    }
}
