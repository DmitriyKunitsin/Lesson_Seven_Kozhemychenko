namespace Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            //resultMatrixDGV - это финальный массив. Его миниммально возможный размер - 1х2
            resultMatrixDGV.RowCount = 1;
            resultMatrixDGV.ColumnCount = originMatrixDGV.ColumnCount;
            IntMatrix matrix = new IntMatrix(originMatrixDGV.ColumnCount, originMatrixDGV.RowCount);
            MaxMass mass = new MaxMass(resultMatrixDGV.ColumnCount);
            int row, col;
            try {
                for (col = 0; col < originMatrixDGV.ColumnCount; col++)
                {
                    for (row = 0; row < originMatrixDGV.RowCount; row++)
                    {
                        matrix[col, row] = Convert.ToInt32(originMatrixDGV[col, row].Value);
                    }
                }
                for (col = 0; col < originMatrixDGV.ColumnCount; col++)
                {
                    mass[col] = matrix[col];
                }
                for (int i = 0; i < resultMatrixDGV.ColumnCount - 1; i++)
                {
                    for (int j = i + 1; j < resultMatrixDGV.ColumnCount; j++)
                    {
                        if (mass[i] > mass[j])
                        {
                            int temp = mass[i];
                            mass[i] = mass[j];
                            mass[j] = temp;
                        }
                    }
                }
                for (col = 0; col < resultMatrixDGV.ColumnCount; col++)
                {
                    resultMatrixDGV[col, 0].Value = mass[col];
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Некорректные данные во входной матрице. Проверьте содержимое ячеек!", "Произошла ошибка, расчёт остановлен!");
            }
        }

        private void matrixN_ValueChanged(object sender, EventArgs e)
        {
            // matrixN имеет ограничение на минимальное значение 2
            originMatrixDGV.RowCount = (int)matrixN.Value;
        }
        private void matrixM_ValueChanged(object sender, EventArgs e)
        {
            // matrixM имеет ограничение на минимальное значение 2
            originMatrixDGV.ColumnCount = (int)matrixM.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // При загрузке формы у входной матрицы сразу задаются количества строк и столбцов
            originMatrixDGV.RowCount = (int)matrixN.Value;
            originMatrixDGV.ColumnCount = (int)matrixM.Value;
            // Если как-то можно создать 1х1 - поделитесь, но я не знаю как у Вас это получилось
        }
    }
}