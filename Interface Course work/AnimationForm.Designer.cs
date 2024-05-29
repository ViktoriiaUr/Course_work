namespace Interface_Course_work
{
    partial class AnimationForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            animationNameLabel = new Label();
            ArrayDataGrid = new DataGridView();
            NoElementLabel = new Label();
            SearchedElementBox = new TextBox();
            GoBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ArrayDataGrid).BeginInit();
            SuspendLayout();
            // 
            // animationNameLabel
            // 
            animationNameLabel.AutoSize = true;
            animationNameLabel.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            animationNameLabel.ForeColor = Color.DarkBlue;
            animationNameLabel.Location = new Point(125, 9);
            animationNameLabel.Name = "animationNameLabel";
            animationNameLabel.Size = new Size(542, 48);
            animationNameLabel.TabIndex = 0;
            animationNameLabel.Text = "Графічне відображення пошуку";
            // 
            // ArrayDataGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            ArrayDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ArrayDataGrid.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ArrayDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ArrayDataGrid.ColumnHeadersHeight = 29;
            ArrayDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ArrayDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            ArrayDataGrid.GridColor = SystemColors.ActiveBorder;
            ArrayDataGrid.Location = new Point(47, 99);
            ArrayDataGrid.Name = "ArrayDataGrid";
            ArrayDataGrid.ReadOnly = true;
            ArrayDataGrid.RowHeadersVisible = false;
            ArrayDataGrid.RowHeadersWidth = 51;
            ArrayDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ArrayDataGrid.Size = new Size(683, 293);
            ArrayDataGrid.TabIndex = 1;
            // 
            // NoElementLabel
            // 
            NoElementLabel.AutoSize = true;
            NoElementLabel.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NoElementLabel.ForeColor = Color.MediumBlue;
            NoElementLabel.Location = new Point(194, 409);
            NoElementLabel.Name = "NoElementLabel";
            NoElementLabel.Size = new Size(375, 32);
            NoElementLabel.TabIndex = 3;
            NoElementLabel.Text = "Вказаний елемент не знайдено";
            // 
            // SearchedElementBox
            // 
            SearchedElementBox.BackColor = SystemColors.Menu;
            SearchedElementBox.BorderStyle = BorderStyle.None;
            SearchedElementBox.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SearchedElementBox.ForeColor = Color.MediumBlue;
            SearchedElementBox.Location = new Point(306, 60);
            SearchedElementBox.Name = "SearchedElementBox";
            SearchedElementBox.Size = new Size(197, 33);
            SearchedElementBox.TabIndex = 4;
            // 
            // GoBackButton
            // 
            GoBackButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoBackButton.Location = new Point(12, 9);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(68, 29);
            GoBackButton.TabIndex = 5;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // AnimationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(772, 450);
            Controls.Add(GoBackButton);
            Controls.Add(SearchedElementBox);
            Controls.Add(NoElementLabel);
            Controls.Add(ArrayDataGrid);
            Controls.Add(animationNameLabel);
            Name = "AnimationForm";
            Text = "Графічне відображення пошуку";
            ((System.ComponentModel.ISupportInitialize)ArrayDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label animationNameLabel;
        private DataGridView ArrayDataGrid;
        private Label NoElementLabel;
        private TextBox SearchedElementBox;
        private Button GoBackButton;
    }
}