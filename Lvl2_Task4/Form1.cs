using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lvl2_Task4
{
    public partial class Form1 : Form
    {
        int[] originalArray = new int[5];
        int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentIndex < 5) // проверяем лимит
            {
                if (int.TryParse(txtInput.Text, out int value))
                {
                    originalArray[currentIndex] = value;
                    listBoxOriginal.Items.Add($"Элемент {currentIndex + 1}: {value}");
                    currentIndex++;
                    txtInput.Clear();
                    txtInput.Focus();

                    // если ввели 5 чисел
                    if (currentIndex == 5)
                    {
                        btnAdd.Enabled = false;
                        txtInput.Enabled = false;
                        btnReverse.Enabled = true;
                        btnReverseInPlace.Enabled = true;
                        lblStatus.Text = "Введены все 5 чисел. Выберите способ реверса.";
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректное целое число!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
        
            int[] reversedArray = new int[5]; // создаем новый
            // заполняем массив в обратном порядке
            for (int i = 0; i < originalArray.Length; i++)
            {
                reversedArray[i] = originalArray[originalArray.Length - 1 - i];
            }

            listBoxReversed.Items.Clear();
            // отображаем перевернутый массив
            for (int i = 0; i < reversedArray.Length; i++)
            {
                listBoxReversed.Items.Add($"Элемент {i + 1}: {reversedArray[i]}");
            }
        }

        private void btnReverseInPlace_Click(object sender, EventArgs e)
        {
            // меняем местами симметричные элементы
            for (int i = 0; i < originalArray.Length / 2; i++)
            {
                int temp = originalArray[i]; // сохраняем левый
                originalArray[i] = originalArray[originalArray.Length - 1 - i]; // левый = правый
                originalArray[originalArray.Length - 1 - i] = temp; // правый = левый
            }

            listBoxReversed.Items.Clear();
            for (int i = 0; i < originalArray.Length; i++)
            {
                listBoxReversed.Items.Add($"Элемент {i + 1}: {originalArray[i]}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            originalArray = new int[5];
            currentIndex = 0;
            listBoxOriginal.Items.Clear();
            listBoxReversed.Items.Clear();
            txtInput.Clear();
            txtInput.Enabled = true;
            btnAdd.Enabled = true;
            btnReverse.Enabled = false;
            btnReverseInPlace.Enabled = false;
            lblStatus.Text = "Введите 5 чисел:";
            txtInput.Focus();
        }
    }
}
