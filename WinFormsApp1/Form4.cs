using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void CompareAlgorithmsButton_Click(object sender, EventArgs e)
        {
        }

        private int[] GenerateRandomArray(int size)
        {
            int[] randomArray = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(1, 1000);
            }
            return randomArray;
        }

        private void ShellSort(int[] arr)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }
            }
        }

        private void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }

        private void QuickSort(int[] arr, int low, int high)
        {
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
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int swapTemp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapTemp;

            return i + 1;
        }

        private void CompareAlgorithmsButton_Click_1(object sender, EventArgs e)
        {

            int arraySize = int.Parse(ArraySizeTextBox.Text);


            int[] randomArray = GenerateRandomArray(arraySize);


            Stopwatch shellSortStopwatch = new Stopwatch();
            shellSortStopwatch.Start();
            ShellSort(randomArray);
            shellSortStopwatch.Stop();


            int[] heapSortArray = (int[])randomArray.Clone();
            Stopwatch heapSortStopwatch = new Stopwatch();
            heapSortStopwatch.Start();
            HeapSort(heapSortArray);
            heapSortStopwatch.Stop();


            int[] quickSortArray = (int[])randomArray.Clone();
            Stopwatch quickSortStopwatch = new Stopwatch();
            quickSortStopwatch.Start();
            QuickSort(quickSortArray, 0, quickSortArray.Length - 1);
            quickSortStopwatch.Stop();


            DataGridViewRow row1 = new DataGridViewRow();
            row1.CreateCells(ResultsDataGridView);
            row1.SetValues("Shell Sort", shellSortStopwatch.ElapsedMilliseconds + " ms");
            ResultsDataGridView.Rows.Add(row1);

            DataGridViewRow row2 = new DataGridViewRow();
            row2.CreateCells(ResultsDataGridView);
            row2.SetValues("Heap Sort", heapSortStopwatch.ElapsedMilliseconds + " ms");
            ResultsDataGridView.Rows.Add(row2);

            DataGridViewRow row3 = new DataGridViewRow();
            row3.CreateCells(ResultsDataGridView);
            row3.SetValues("Quick Sort", quickSortStopwatch.ElapsedMilliseconds + " ms");
            ResultsDataGridView.Rows.Add(row3);

            // Выводим анализ
            string analysis = "Сравнительный анализ:\n";
            analysis += "Shell Sort:\r\n\r\nПреимущества: Shell Sort сочетает преимущества сортировки вставками (эффективен на почти упорядоченных данных) и быстродействие алгоритма с уменьшающимся шагом.\r\nНедостатки: Хотя Shell Sort лучше сортирует массивы, чем сортировка вставками, он не столь быстр, как некоторые другие алгоритмы, такие как Quick Sort или Сортировка кучей.\r\nСложность: Сложность Shell Sort в среднем составляет O(n log^2 n), но может варьироваться в зависимости от выбора интервалов.\r\n\r\n";
            analysis += "Сортировка кучей (Heap Sort):\r\n\r\nПреимущества: Сортировка кучей имеет постоянное использование дополнительной памяти, хорошо подходит для сортировки больших массивов и стабильна по времени выполнения.\r\nНедостатки: Операции построения кучи могут потребовать дополнительного времени и памяти.\r\nСложность: Сортировка кучей имеет сложность O(n log n) в худшем и среднем случаях.\r\n\r\n";
            analysis += "Quick Sort:\r\n\r\nПреимущества: Quick Sort - один из самых быстрых алгоритмов сортировки, если опорные элементы хорошо выбраны. Он не требует дополнительной памяти для сортировки и часто быстрее сортировки слиянием на практике.\r\nНедостатки: Quick Sort не стабилен, и в некоторых случаях (например, отсортированный массив) его производительность может снижаться.\r\nСложность: Средняя сложность Quick Sort составляет O(n log n), но в худшем случае (плохой выбор опорных элементов) может достигать O(n^2).\r\n\r\n";
            AnalysisLabel.Text = analysis;
            UpdateLabelWidth();

        }
        private void Form3_SizeChanged(object sender, EventArgs e)
        {
            UpdateLabelWidth();
        }

        private void UpdateLabelWidth()
        {
            int maxWidth = this.ClientSize.Width - 20; // Учтем небольшой зазор от края окна
            AnalysisLabel.MaximumSize = new Size(maxWidth, 0);
            AnalysisLabel.AutoSize = true;
        }

        private void ResultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
