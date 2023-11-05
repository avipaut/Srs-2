


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
            animationTimer.Interval = 1000; // Интервал в миллисекундах
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
            // Другие сортировки

            string elapsedTime = string.Format("Время выполнения: {0} миллисекунд", stopwatch.ElapsedMilliseconds);
            TimeLabel.Text = elapsedTime;
            currentStep = 0;

            // Выполните сортировку и сохраните каждый шаг
            sortingSteps = new List<int[]>();
            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);
            sortingSteps.Add(copyArray);

            // Отображаем сгенерированный массив на экране

            // Очищаем ListBox перед началом сортировки
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
                string algorithmDescription = "QuickSort - это алгоритм сортировки, который использует стратегию разделения и властвования.Он выбирает опорный элемент и разделяет массив на две подгруппы:  ";
                string algorithmDescription2 = "одна содержит элементы, меньшие опорного,а другая - элементы, большие опорного. Затем сортирует обе подгруппы рекурсивно. ";


                AddStepToListBox(algorithmDescription);
                AddStepToListBox(algorithmDescription2);
                QuickSort(intArray, 0, intArray.Length - 1);

            }
            label1.Text = "Отсортированный массив: " + string.Join(" ", intArray);
            animationTimer.Start();

        }

        // Метод для генерации случайного массива
        private int[] GenerateRandomArray(int size)
        {
            int[] randomArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(1, 100); // Генерируем случайное число от 1 до 100
            }
            return randomArray;
        }

        // Метод для добавления шага сортировки в ListBox
        private void AddStepToListBox(string stepDescription)
        {
            StepsListBox.Items.Add(stepDescription);
        }

        // Обновить ListBox, чтобы отобразить новые элементы
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
            string algorithmDescription = "ShellSort - это усовершенствованный алгоритм сортировки вставками. Он разделяет массив наподсписки и сортирует каждый подсписок сортировкой вставками. ";
            string algorithmDescription2 = "Шаги между элементами подсписков постепенно уменьшаются, что делает алгоритм эффективным для больших массивов.";



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
                        AddStepToListBox($"Перемещение: {movedElement} на позицию {j}");
                        string stepDescription = $"Перемещение элемента {movedElement} на позицию {j} для сортировки с шагом {gap}. Перемещение выполняется, так как {movedElement} больше {temp}.";
                        AddStepToListBox(stepDescription);
                        DrawArray(arr);

                    }
                    arr[j] = temp;
                    AddStepToListBox($"Перемещение: {temp} на позицию {j}");
                }
            }
        }



        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (currentStep < sortingSteps.Count)
            {
                int[] stepArray = sortingSteps[currentStep];

                // Обновите интерфейс, показав состояние массива на текущем шаге
                label1.Text = "Текущее состояние массива: " + string.Join(" ", stepArray);

                // Реализуйте анимацию, изменяя цвет элементов, перемещая их и т. д.

                currentStep++;
            }
            else
            {
                // Если анимация завершилась, остановите Timer
                animationTimer.Stop();
                label1.Text = "Отсортированный массив: " + string.Join(" ", intArray);
            }
        }



        private void PriorityQueueSort(int[] arr)
        {
            string algorithmDescription1 = "HeapSort - это алгоритм сортировки на основе бинарной кучи. Он создает бинарную кучу из массива,где каждый узел больше своих детей. ";
            string algorithmDescription2 = "Затем он извлекает максимальный (или минимальный) элемент из кучи и повторяет процесс до сортировки всего массива.";



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

                string stepDescription = $"Перемещение элемента {temp} на позицию {i} для выборки максимального элемента. Перемещение выполняется, так как {temp} - максимальный элемент.";

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

                string stepDescription = $"Перемещение элемента {swap} на позицию {largest} для поддержания свойства кучи. Перемещение выполняется, так как {swap} - максимальный элемент в текущей куче.";

                DrawArray(arr);
                AddStepToListBox(stepDescription);

                Heapify(arr, n, largest);
            }
        }

        private void QuickSort(int[] arr, int low, int high)
        {
            // Описание алгоритма QuickSort

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

                    string stepDescription1 = $"Перемещение элемента {temp} на позицию {i}. Перемещение выполняется, так как {temp} меньше опорного элемента {pivot}.";
                    DrawArray(arr);

                    AddStepToListBox(stepDescription1);
                }
            }

            int swapTemp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapTemp;

            string stepDescription2 = $"Перемещение элемента {swapTemp} на позицию {i + 1} после окончания итерации разделения.";
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
            label1.Text = "Отсортированный массив: " + string.Join(" ", intArray);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int arraySize = 10; // Размер массива (можете изменить по вашему желанию)
            intArray = GenerateRandomArray(arraySize); // Генерируем случайный массив
            ResultLabel.Text = "Сгенерированный массив: " + string.Join(" ", intArray);



        }
        private void DrawArray(int[] arr)
        {
            // Очистите PictureBox перед отрисовкой нового состояния
            pictureBox1.Image = null;

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            int maxElement = arr.Max();
            int elementWidth = width / arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                int elementHeight = (int)((double)arr[i] / maxElement * height); // Высота элемента
                int x = i * elementWidth;
                int y = height - elementHeight;

                // Отрисовка элемента
                g.FillRectangle(Brushes.Blue, x, y, elementWidth, elementHeight);
            }

            // Отобразите изображение в PictureBox
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

        private void сравнениеАлгаритмовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void quikSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form5.Show();
        }
    }
}
