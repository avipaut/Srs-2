using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = "Алгоритм";
            label3.Text = "Двоичная куча представляет собой полное бинарное дерево, для которого выполняется основное свойство кучи: приоритет каждой вершины больше приоритетов её потомков. В простейшем случае приоритет каждой вершины можно считать равным её значению. В таком случае структура называется max-heap, поскольку корень поддерева является максимумом из значений элементов поддерева. В этой статье для простоты используется именно такое представление. Напомню также, что дерево называется полным бинарным, если у каждой вершины есть не более двух потомков, а заполнение уровней вершин идет сверху вниз (в пределах одного уровня – слева направо).";
            UpdateLabelWidth();
            pictureBox1.Image = new Bitmap("C:\\Users\\Admin\\Downloads\\1_t5B9NRgJKTxgZYsLhwU8Zg.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form3_SizeChanged(object sender, EventArgs e)
        {
            UpdateLabelWidth();
        }

        private void UpdateLabelWidth()
        {
            int maxWidth = this.ClientSize.Width - 20; // Учтем небольшой зазор от края окна
            label3.MaximumSize = new Size(maxWidth, 0);
            label3.AutoSize = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


