﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 30, FontStyle.Regular);
            label2.Font = new Font("Arial", 15, FontStyle.Regular);
            label1.Text = "Алгоритм";
            label2.Text = "QuickSort";
            label3.Text = "QuickSort является существенно улучшенным вариантом алгоритма сортировки с помощью прямого обмена (его варианты известны как «Пузырьковая сортировка» и «Шейкерная сортировка»), известного в том числе своей низкой эффективностью. Принципиальное отличие состоит в том, что в первую очередь производятся перестановки на наибольшем возможном расстоянии и после каждого прохода элементы делятся на две независимые группы (таким образом улучшение самого неэффективного прямого метода сортировки дало в результате один из наиболее эффективных улучшенных методов).\r\n\r\nОбщая идея алгоритма состоит в следующем:\r\n\r\nВыбрать из массива элемент, называемый опорным. Это может быть любой из элементов массива. От выбора опорного элемента не зависит корректность алгоритма, но в отдельных случаях может сильно зависеть его эффективность (см. ниже).\r\nСравнить все остальные элементы с опорным и переставить их в массиве так, чтобы разбить массив на три непрерывных отрезка, следующих друг за другом: «элементы меньшие опорного», «равные» и «большие»[2].\r\nДля отрезков «меньших» и «больших» значений выполнить рекурсивно ту же последовательность операций, если длина отрезка больше единицы.\r\nНа практике массив обычно делят не на три, а на две части: например, «меньшие опорного» и «равные и большие»; такой подход в общем случае эффективнее, так как упрощает алгоритм разделения (см. ниже).\r\n\r\nХоар разработал этот метод применительно к машинному переводу; словарь хранился на магнитной ленте, и сортировка слов обрабатываемого текста позволяла получить их переводы за один прогон ленты, без перемотки её назад. Алгоритм был придуман Хоаром во время его пребывания в Советском Союзе, где он обучался в Московском университете компьютерному переводу и занимался разработкой русско-английского разговорника.";
            UpdateLabelWidth();
            pictureBox1.Image = new Bitmap("C:\\Users\\Admin\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Images\\igrbaajcuoxuj4q-l-38x0qsoq4.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Form5_SizeChanged(object sender, EventArgs e)
        {
            UpdateLabelWidth();
        }

        private void UpdateLabelWidth()
        {
            int maxWidth = this.ClientSize.Width - 20; // Учтем небольшой зазор от края окна
            label3.MaximumSize = new Size(maxWidth, 0);
            label3.AutoSize = true;
        }
    }
}
