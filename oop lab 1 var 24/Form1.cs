using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace oop_lab_1_var_24
{
    public partial class Form1 : Form
    {
        private int[]? array;

        public Form1()
        {
            InitializeComponent();

            btnKeyboard.Click += btnKeyboard_Click;
            btnRandom.Click += btnRandom_Click;
            btnFile.Click += btnFile_Click;
            btnFind.Click += btnFind_Click;
        }

        private void btnKeyboard_Click(object? sender, EventArgs e)
        {
            try
            {
                array = txtInput.Text
                    .Split(new[] { ' ', '\n', '\r', '\t' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (array.Length == 0)
                {
                    MessageBox.Show("Введіть масив.");
                    return;
                }

                txtCount.Text = array.Length.ToString();

                ShowArray();
            }
            catch
            {
                MessageBox.Show("Введіть тільки цілі числа через пробіл.");
            }
        }

        private void btnRandom_Click(object? sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtCount.Text);

                if (n <= 0)
                {
                    MessageBox.Show("Кількість елементів повинна бути більше 0.");
                    return;
                }

                Random random = new Random();

                array = new int[n];

                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(-100, 101);
                }

                txtInput.Text = string.Join(" ", array);

                ShowArray();
            }
            catch
            {
                MessageBox.Show("Введіть правильну кількість елементів.");
            }
        }

        private void btnFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter =
                "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string text = File.ReadAllText(dialog.FileName);

                    array = text
                        .Split(new[] { ' ', '\n', '\r', '\t' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    if (array.Length == 0)
                    {
                        MessageBox.Show("Файл порожній.");
                        return;
                    }

                    txtCount.Text = array.Length.ToString();
                    txtInput.Text = string.Join(" ", array);

                    ShowArray();
                }
                catch
                {
                    MessageBox.Show("Помилка при читанні файлу.");
                }
            }
        }

        private void ShowArray()
        {
            lstArray.Items.Clear();

            if (array == null)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                lstArray.Items.Add(
                    "Індекс " + i + ": " + array[i]);
            }
        }

        private void btnFind_Click(object? sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Спочатку введіть масив.");
                return;
            }

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }

                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            lblMin.Text =
                "Мінімальний елемент: " + array[minIndex];

            lblMinIndex.Text =
                "Індекс мінімального елемента: " + minIndex;

            lblMax.Text =
                "Максимальний елемент: " + array[maxIndex];

            lblMaxIndex.Text =
                "Індекс максимального елемента: " + maxIndex;
        }
    }
}