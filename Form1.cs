namespace Square
{
    public partial class Form1 : Form
    {
        int topsCounter = 0;
        int pointsCounter = 0;
        Figure figure = new Figure();
        public Form1()
        {
            InitializeComponent();
            InputXBox.ReadOnly = true;
            InputYBox.ReadOnly = true;
            EnterXYButton.Enabled = false;
            СalculateButton.Enabled = false;
        }

        private void TopsNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void InputXBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(InputXBox.Text + e.KeyChar.ToString(), out _) && e.KeyChar != 8 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void InputYBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(InputYBox.Text + e.KeyChar.ToString(), out _) && e.KeyChar != 8 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void EnterTopsNumberButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(TopsNumberBox.Text, out topsCounter))
            {
                if (topsCounter > 2)
                {
                    TopsNumberBox.ReadOnly = true;
                    EnterTopsNumberButton.Enabled = false;
                    InputXBox.ReadOnly = false;
                    InputYBox.ReadOnly = false;
                    EnterXYButton.Enabled = true;
                    figure.coordinates = new double[2, topsCounter];
                }
                else
                {
                    MessageBox.Show("Количество вершин должно быть больше 2!");
                    TopsNumberBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Нельзя оставлять поле пустым!");
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            TopsNumberBox.Clear();
            InputXBox.Clear();
            InputYBox.Clear();
            TopsNumberBox.ReadOnly = false;
            EnterTopsNumberButton.Enabled = true;
            InputXBox.ReadOnly = true;
            InputYBox.ReadOnly = true;
            EnterXYButton.Enabled = false;
            СalculateButton.Enabled = false;
            topsCounter = 0;
            pointsCounter = 0;
        }

        private void СalculateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Площадь фигуры равна {figure.SquareCalculation(figure.coordinates)}");
            TopsNumberBox.Clear();
            InputXBox.Clear();
            InputYBox.Clear();
            TopsNumberBox.ReadOnly = false;
            EnterTopsNumberButton.Enabled = true;
            InputXBox.ReadOnly = true;
            InputYBox.ReadOnly = true;
            EnterXYButton.Enabled = false;
            topsCounter = 0;
            pointsCounter = 0;
        }

        private void EnterXYButton_Click(object sender, EventArgs e)
        {
            if (pointsCounter != topsCounter)
            {
                if (!String.IsNullOrEmpty(InputXBox.Text) || !String.IsNullOrEmpty(InputYBox.Text))
                {
                    figure.coordinates[0, pointsCounter] = double.Parse(InputXBox.Text);
                    figure.coordinates[1, pointsCounter] = double.Parse(InputYBox.Text);
                    InputXBox.Clear();
                    InputYBox.Clear();
                    pointsCounter++;
                }
                else
                {
                    MessageBox.Show("Нельзя оставлять поля координат пустыми!");
                }

            }

            if (pointsCounter == topsCounter)
            {
                EnterXYButton.Enabled = false;
                СalculateButton.Enabled = true;
            }

        }
    }
}