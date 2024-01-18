namespace Programming
{
    class IntMatrix
    {
        private int[,] matr;

        public IntMatrix(int col, int row)
        {
            // Понял, надо было проверки поменять в конструкторе, спасибо! 
            if (col > 1)
            {
                if (row > 1)
                {
                    matr = new int[col, row];
                }
                else
                {
                    throw new ArgumentException("Второй индекс имеет недопустимое значение (ожидалось число большее или равное двум)!");
                }
            }
            else
            {
                throw new ArgumentException("Первый индекс имеет недопустимое значение (ожидалось число большее или равное двум)!");
            }
        }

        public int this[int col, int row]
        {
            get
            {
                if (col >= 0 && col < matr.GetLength(0))
                {
                    if (row >= 0 && row < matr.GetLength(1))
                    {
                        return matr[col, row];
                    }
                    else
                    {
                        throw new ArgumentException("Второй индекс имеет недопустимое значение!");
                    }
                }
                else
                {
                    throw new ArgumentException("Первый индекс имеет недопустимое значение!");
                }
            }
            set
            {
                if (col >= 0 && col < matr.GetLength(0))
                {
                    if (row >= 0 && row < matr.GetLength(1))
                    {
                        matr[col, row] = value;
                    }
                    else
                    {
                        throw new ArgumentException("Второй индекс имеет недопустимое значение!");
                    }
                }
                else
                {
                    throw new ArgumentException("Первый индекс имеет недопустимое значение!");
                }
            }
        }

        public int this[int col]
        {
            get
            {
                if (col >= 0 && col < matr.GetLength(0))
                {
                    int max = matr[col, 0];
                    for (int i = 1; i < matr.GetLength(1); i++)
                    {
                        if (matr[col, i] > max) max = matr[col, i];
                    }
                    return max;
                }
                else
                {
                    throw new ArgumentException("Первый индекс имеет недопустимое значение!");
                }
            }
        }
    }
}
