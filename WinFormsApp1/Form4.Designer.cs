namespace WinFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelArraySize = new Label();
            ArraySizeTextBox = new TextBox();
            CompareAlgorithmsButton = new Button();
            ResultsDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            AnalysisLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ResultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // labelArraySize
            // 
            labelArraySize.AutoSize = true;
            labelArraySize.Location = new Point(30, 19);
            labelArraySize.Name = "labelArraySize";
            labelArraySize.Size = new Size(196, 20);
            labelArraySize.TabIndex = 0;
            labelArraySize.Text = "Выберите размер массива";
            // 
            // ArraySizeTextBox
            // 
            ArraySizeTextBox.Location = new Point(30, 42);
            ArraySizeTextBox.Name = "ArraySizeTextBox";
            ArraySizeTextBox.Size = new Size(161, 27);
            ArraySizeTextBox.TabIndex = 1;
            // 
            // CompareAlgorithmsButton
            // 
            CompareAlgorithmsButton.Location = new Point(30, 75);
            CompareAlgorithmsButton.Name = "CompareAlgorithmsButton";
            CompareAlgorithmsButton.Size = new Size(94, 29);
            CompareAlgorithmsButton.TabIndex = 2;
            CompareAlgorithmsButton.Text = "Сравнить алгоритмы";
            CompareAlgorithmsButton.UseVisualStyleBackColor = true;
            CompareAlgorithmsButton.Click += CompareAlgorithmsButton_Click_1;
            // 
            // ResultsDataGridView
            // 
            ResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            ResultsDataGridView.Location = new Point(30, 126);
            ResultsDataGridView.Name = "ResultsDataGridView";
            ResultsDataGridView.RowHeadersWidth = 51;
            ResultsDataGridView.RowTemplate.Height = 29;
            ResultsDataGridView.Size = new Size(349, 312);
            ResultsDataGridView.TabIndex = 3;
            ResultsDataGridView.CellContentClick += ResultsDataGridView_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // AnalysisLabel
            // 
            AnalysisLabel.AutoSize = true;
            AnalysisLabel.Location = new Point(33, 477);
            AnalysisLabel.Name = "AnalysisLabel";
            AnalysisLabel.Size = new Size(50, 20);
            AnalysisLabel.TabIndex = 4;
            AnalysisLabel.Text = "label1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 700);
            Controls.Add(AnalysisLabel);
            Controls.Add(ResultsDataGridView);
            Controls.Add(CompareAlgorithmsButton);
            Controls.Add(ArraySizeTextBox);
            Controls.Add(labelArraySize);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)ResultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelArraySize;
        private TextBox ArraySizeTextBox;
        private Button CompareAlgorithmsButton;
        private DataGridView ResultsDataGridView;
        private Label AnalysisLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}