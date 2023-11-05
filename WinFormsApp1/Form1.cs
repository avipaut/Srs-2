


using System;
using System.Collections;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Form4 form4 = new Form4();
        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        private Form5 form5 = new Form5();

        private Label TimeLabel;
        private System.Windows.Forms.Timer animationTimer;
        private Random random = new Random();
        private int[] intArray;
        private List<int[]> sortingSteps;
        private int currentStep;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public Form1()
        {
            TimeLabel = new Label();
            TimeLabel.Location = new Point(1, 335);
            TimeLabel.Size = new Size(300, 30);
            this.Controls.Add(TimeLabel);
            InitializeComponent();
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 1000; // �������� � �������������
            animationTimer.Tick += AnimationTimer_Tick;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            if (ShellSortRadioButton.Checked)
            {
                stopwatch.Start();
                ShellSort(intArray);
                stopwatch.Stop();
            }
            if (PriorityQueueSortRadioButton.Checked)
            {
                stopwatch.Start();
                PriorityQueueSort(intArray);
                stopwatch.Stop();
            }
            if (QuickSortRadioButton.Checked)
            {
                stopwatch.Start();
                ShellSort(intArray);
                stopwatch.Stop();
            }
            // ������ ����������

            string elapsedTime = string.Format("����� ����������: {0} �����������", stopwatch.ElapsedMilliseconds);
            TimeLabel.Text = elapsedTime;
            currentStep = 0;

            // ��������� ���������� � ��������� ������ ���
            sortingSteps = new List<int[]>();
            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);
            sortingSteps.Add(copyArray);

            // ���������� ��������������� ������ �� ������

            // ������� ListBox ����� ������� ����������
            StepsListBox.Items.Clear();

            if (ShellSortRadioButton.Checked)
            {
                ShellSort(intArray);
            }
            else if (PriorityQueueSortRadioButton.Checked)
            {
                PriorityQueueSort(intArray);
            }
            else if (QuickSortRadioButton.Checked)
            {
                string algorithmDescription = "QuickSort - ��� �������� ����������, ������� ���������� ��������� ���������� � ������������.�� �������� ������� ������� � ��������� ������ �� ��� ���������:  ";
                string algorithmDescription2 = "���� �������� ��������, ������� ��������,� ������ - ��������, ������� ��������. ����� ��������� ��� ��������� ����������. ";


                AddStepToListBox(algorithmDescription);
                AddStepToListBox(algorithmDescription2);
                QuickSort(intArray, 0, intArray.Length - 1);

            }
            label1.Text = "��������������� ������: " + string.Join(" ", intArray);
            animationTimer.Start();

        }

        // ����� ��� ��������� ���������� �������
        private int[] GenerateRandomArray(int size)
        {
            int[] randomArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(1, 100); // ���������� ��������� ����� �� 1 �� 100
            }
            return randomArray;
        }

        // ����� ��� ���������� ���� ���������� � ListBox
        private void AddStepToListBox(string stepDescription)
        {
            StepsListBox.Items.Add(stepDescription);
        }

        // �������� ListBox, ����� ���������� ����� ��������
        private void RefreshListBox()
        {
            StepsListBox.Refresh();
        }
        private void RefreshListBox(int[] visualArray)
        {
            StepsListBox.Items.Clear();
            foreach (var item in visualArray)
            {
                StepsListBox.Items.Add(item);
            }
        }

        private void ShellSort(int[] arr)
        {
            string algorithmDescription = "ShellSort - ��� ������������������� �������� ���������� ���������. �� ��������� ������ ����������� � ��������� ������ ��������� ����������� ���������. ";
            string algorithmDescription2 = "���� ����� ���������� ���������� ���������� �����������, ��� ������ �������� ����������� ��� ������� ��������.";



            AddStepToListBox(algorithmDescription);
            AddStepToListBox(algorithmDescription2);
            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        int movedElement = arr[j - gap];
                        arr[j] = movedElement;
                        DrawArray(arr);
                        AddStepToListBox($"�����������: {movedElement} �� ������� {j}");
                        string stepDescription = $"����������� �������� {movedElement} �� ������� {j} ��� ���������� � ����� {gap}. ����������� �����������, ��� ��� {movedElement} ������ {temp}.";
                        AddStepToListBox(stepDescription);
                        DrawArray(arr);

                    }
                    arr[j] = temp;
                    AddStepToListBox($"�����������: {temp} �� ������� {j}");
                }
            }
        }



        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (currentStep < sortingSteps.Count)
            {
                int[] stepArray = sortingSteps[currentStep];

                // �������� ���������, ������� ��������� ������� �� ������� ����
                label1.Text = "������� ��������� �������: " + string.Join(" ", stepArray);

                // ���������� ��������, ������� ���� ���������, ��������� �� � �. �.

                currentStep++;
            }
            else
            {
                // ���� �������� �����������, ���������� Timer
                animationTimer.Stop();
                label1.Text = "��������������� ������: " + string.Join(" ", intArray);
            }
        }



        private void PriorityQueueSort(int[] arr)
        {
            string algorithmDescription1 = "HeapSort - ��� �������� ���������� �� ������ �������� ����. �� ������� �������� ���� �� �������,��� ������ ���� ������ ����� �����. ";
            string algorithmDescription2 = "����� �� ��������� ������������ (��� �����������) ������� �� ���� � ��������� ������� �� ���������� ����� �������.";



            AddStepToListBox(algorithmDescription1);
            AddStepToListBox(algorithmDescription2);
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0);

                string stepDescription = $"����������� �������� {temp} �� ������� {i} ��� ������� ������������� ��������. ����������� �����������, ��� ��� {temp} - ������������ �������.";

                DrawArray(arr);
                AddStepToListBox(stepDescription);
            }
        }

        private void Heapify(int[] arr, int n, int root)
        {

            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != root)
            {
                int swap = arr[root];
                arr[root] = arr[largest];
                arr[largest] = swap;

                string stepDescription = $"����������� �������� {swap} �� ������� {largest} ��� ����������� �������� ����. ����������� �����������, ��� ��� {swap} - ������������ ������� � ������� ����.";

                DrawArray(arr);
                AddStepToListBox(stepDescription);

                Heapify(arr, n, largest);
            }
        }

        private void QuickSort(int[] arr, int low, int high)
        {
            // �������� ��������� QuickSort

            if (low < high)
            {
                int pivot = Partition(arr, low, high);
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    string stepDescription1 = $"����������� �������� {temp} �� ������� {i}. ����������� �����������, ��� ��� {temp} ������ �������� �������� {pivot}.";
                    DrawArray(arr);

                    AddStepToListBox(stepDescription1);
                }
            }

            int swapTemp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapTemp;

            string stepDescription2 = $"����������� �������� {swapTemp} �� ������� {i + 1} ����� ��������� �������� ����������.";
            DrawArray(arr);

            AddStepToListBox(stepDescription2);

            return i + 1;
        }




        private void SortButton_Click_1(object sender, EventArgs e)
        {

        }



        private void PriorityQueueSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "��������������� ������: " + string.Join(" ", intArray);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int arraySize = 10; // ������ ������� (������ �������� �� ������ �������)
            intArray = GenerateRandomArray(arraySize); // ���������� ��������� ������
            ResultLabel.Text = "��������������� ������: " + string.Join(" ", intArray);



        }
        private void DrawArray(int[] arr)
        {
            // �������� PictureBox ����� ���������� ������ ���������
            pictureBox1.Image = null;

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            int maxElement = arr.Max();
            int elementWidth = width / arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                int elementHeight = (int)((double)arr[i] / maxElement * height); // ������ ��������
                int x = i * elementWidth;
                int y = height - elementHeight;

                // ��������� ��������
                g.FillRectangle(Brushes.Blue, x, y, elementWidth, elementHeight);
            }

            // ���������� ����������� � PictureBox
            pictureBox1.Image = bmp;
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void StepsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void heapifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void quikSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form5.Show();
        }
    }
}
