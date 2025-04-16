using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _2laboop
{
    public partial class Form1 : Form
    {
        private MatrixHelper matrix;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(txtRows.Text);
            int cols = int.Parse(txtCols.Text);
            int min = int.Parse(txtMin.Text);
            int max = int.Parse(txtMax.Text);

            if (rows == cols)
            {
                MessageBox.Show("Матриця повинна бути прямокутною!", "Помилка");
                return;
            }

            matrix = new MatrixHelper(rows, cols);
            matrix.FillRandom(min, max);

            DisplayMatrix(matrix.Matrix);

            int sum = matrix.SumRowsWithNegative();
            var saddles = matrix.GetSaddlePoints();

            textBoxSum.Text = sum.ToString();

            if (saddles.Count == 0)
            {
                textBoxSaddles.Text = "Немає сідлових точок.";
            }
            else
            {
                string result = "";
                foreach (var point in saddles)
                {
                    result += $"Рядок: {point.row + 1}, Стовпець: {point.col + 1}{Environment.NewLine}";
                }
                textBoxSaddles.Text = result;
            }

        }

        private void DisplayMatrix(int[,] data)
        {
            DataTable table = new DataTable();
            for (int i = 0; i < data.GetLength(1); i++)
                table.Columns.Add($"Col {i + 1}", typeof(int));

            for (int i = 0; i < data.GetLength(0); i++)
            {
                DataRow row = table.NewRow();
                for (int j = 0; j < data.GetLength(1); j++)
                    row[j] = data[i, j];
                table.Rows.Add(row);
            }

            dataGridViewMatrix.DataSource = table;
        }

        private void txtRows_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }

        private void lblSum_Click(object sender, EventArgs e)
        {

        }
    }
}
