namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ResultLabel = new Label();
            ShellSortRadioButton = new RadioButton();
            PriorityQueueSortRadioButton = new RadioButton();
            QuickSortRadioButton = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            StepsListBox = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            menuStrip3 = new MenuStrip();
            описаниеАлгаритмовToolStripMenuItem = new ToolStripMenuItem();
            shellSortToolStripMenuItem = new ToolStripMenuItem();
            heapifyToolStripMenuItem = new ToolStripMenuItem();
            quikSortToolStripMenuItem = new ToolStripMenuItem();
            сравнениеАлгаритмовToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(12, 130);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(61, 20);
            ResultLabel.TabIndex = 4;
            ResultLabel.Text = "Массив";
            ResultLabel.Click += ResultLabel_Click;
            // 
            // ShellSortRadioButton
            // 
            ShellSortRadioButton.AutoSize = true;
            ShellSortRadioButton.Location = new Point(13, 185);
            ShellSortRadioButton.Name = "ShellSortRadioButton";
            ShellSortRadioButton.Size = new Size(89, 24);
            ShellSortRadioButton.TabIndex = 5;
            ShellSortRadioButton.TabStop = true;
            ShellSortRadioButton.Text = "ShellSort";
            ShellSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // PriorityQueueSortRadioButton
            // 
            PriorityQueueSortRadioButton.AutoSize = true;
            PriorityQueueSortRadioButton.Location = new Point(12, 213);
            PriorityQueueSortRadioButton.Name = "PriorityQueueSortRadioButton";
            PriorityQueueSortRadioButton.Size = new Size(82, 24);
            PriorityQueueSortRadioButton.TabIndex = 6;
            PriorityQueueSortRadioButton.TabStop = true;
            PriorityQueueSortRadioButton.Text = "Heapify";
            PriorityQueueSortRadioButton.UseVisualStyleBackColor = true;
            PriorityQueueSortRadioButton.CheckedChanged += PriorityQueueSortRadioButton_CheckedChanged;
            // 
            // QuickSortRadioButton
            // 
            QuickSortRadioButton.AutoSize = true;
            QuickSortRadioButton.Location = new Point(12, 243);
            QuickSortRadioButton.Name = "QuickSortRadioButton";
            QuickSortRadioButton.Size = new Size(94, 24);
            QuickSortRadioButton.TabIndex = 7;
            QuickSortRadioButton.TabStop = true;
            QuickSortRadioButton.Text = "QuickSort";
            QuickSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(8, 292);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Сортировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 9;
            label1.Text = "Отсортированный массив";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(8, 79);
            button2.Name = "button2";
            button2.Size = new Size(155, 29);
            button2.TabIndex = 10;
            button2.Text = "Генерация массива";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StepsListBox
            // 
            StepsListBox.FormattingEnabled = true;
            StepsListBox.ItemHeight = 20;
            StepsListBox.Location = new Point(373, 52);
            StepsListBox.Name = "StepsListBox";
            StepsListBox.Size = new Size(1094, 384);
            StepsListBox.TabIndex = 11;
            StepsListBox.SelectedIndexChanged += StepsListBox_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(373, 442);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1094, 316);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 52);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1479, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1479, 24);
            menuStrip2.TabIndex = 15;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { описаниеАлгаритмовToolStripMenuItem, сравнениеАлгаритмовToolStripMenuItem });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1479, 28);
            menuStrip3.TabIndex = 16;
            menuStrip3.Text = "menuStrip3";
            // 
            // описаниеАлгаритмовToolStripMenuItem
            // 
            описаниеАлгаритмовToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shellSortToolStripMenuItem, heapifyToolStripMenuItem, quikSortToolStripMenuItem });
            описаниеАлгаритмовToolStripMenuItem.Name = "описаниеАлгаритмовToolStripMenuItem";
            описаниеАлгаритмовToolStripMenuItem.Size = new Size(179, 24);
            описаниеАлгаритмовToolStripMenuItem.Text = "Описание алгаритмов";
            // 
            // shellSortToolStripMenuItem
            // 
            shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            shellSortToolStripMenuItem.Size = new Size(224, 26);
            shellSortToolStripMenuItem.Text = "ShellSort";
            shellSortToolStripMenuItem.Click += shellSortToolStripMenuItem_Click;
            // 
            // heapifyToolStripMenuItem
            // 
            heapifyToolStripMenuItem.Name = "heapifyToolStripMenuItem";
            heapifyToolStripMenuItem.Size = new Size(224, 26);
            heapifyToolStripMenuItem.Text = "Heapify";
            heapifyToolStripMenuItem.Click += heapifyToolStripMenuItem_Click;
            // 
            // quikSortToolStripMenuItem
            // 
            quikSortToolStripMenuItem.Name = "quikSortToolStripMenuItem";
            quikSortToolStripMenuItem.Size = new Size(224, 26);
            quikSortToolStripMenuItem.Text = "QuikSort";
            quikSortToolStripMenuItem.Click += quikSortToolStripMenuItem_Click;
            // 
            // сравнениеАлгаритмовToolStripMenuItem
            // 
            сравнениеАлгаритмовToolStripMenuItem.Name = "сравнениеАлгаритмовToolStripMenuItem";
            сравнениеАлгаритмовToolStripMenuItem.Size = new Size(186, 24);
            сравнениеАлгаритмовToolStripMenuItem.Text = "Сравнение алгаритмов";
            сравнениеАлгаритмовToolStripMenuItem.Click += сравнениеАлгаритмовToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 746);
            Controls.Add(pictureBox1);
            Controls.Add(StepsListBox);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(QuickSortRadioButton);
            Controls.Add(PriorityQueueSortRadioButton);
            Controls.Add(ShellSortRadioButton);
            Controls.Add(ResultLabel);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ResultLabel;
        private RadioButton ShellSortRadioButton;
        private RadioButton PriorityQueueSortRadioButton;
        private RadioButton QuickSortRadioButton;
        private Button button1;
        private Label label1;
        private Button button2;
        private ListBox StepsListBox;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem описаниеАлгаритмовToolStripMenuItem;
        private ToolStripMenuItem shellSortToolStripMenuItem;
        private ToolStripMenuItem heapifyToolStripMenuItem;
        private ToolStripMenuItem quikSortToolStripMenuItem;
        private ToolStripMenuItem сравнениеАлгаритмовToolStripMenuItem;
    }
}