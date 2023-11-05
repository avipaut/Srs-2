using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Алгоритм";
            label3.Text = "Сортировка Шелла примерно так же получается из сортировки вставками, как пузырьковая сортировка трансформируется в сортировку расчёской.Сортируем вставкой подгруппы элементов, но только в подгруппе они идут не в ряд, а равномерно  выбираются с некоторой дельтой по индексу. После первоначальных грубых проходов, дельта методично уменьшается, пока расстояние между элементами этих несвязных подмножеств не достигнет единицы. Благодаря первоначальным проходам с большим шагом, большинство малых по значению элементов перебрасываются в левую часть массива,большинство крупных элементов массива попадают в праву.Как известно, вставочный метод очень эффективно обрабатывает почти отсортированные массивы. Сортировка Шелла при первоначальных проходах достаточно быстро и доводит массив к состоянию неполной упорядоченности. На заключительном этапе шаг равен единице, т.е. \"Шелл\" естественным образом трансформируется в сортировку простыми вставками.";
            label3.MaximumSize = new Size(700, 0);
            label3.AutoSize = true;

            label1.Text = "Описание Алгоритма ShellSort";
            label1.Font = new Font("Arial", 30, FontStyle.Regular);
            label2.Font = new Font("Arial", 15, FontStyle.Regular);
            pictureBox1.Image = new Bitmap("C:\\Users\\Admin\\Downloads\\igrbaajcuoxuj4q-l-38x0qsoq4.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
