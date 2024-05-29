namespace Interface_Course_work
{
    partial class ResultsForm
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
            txtButton = new Button();
            AnimationButton = new Button();
            SearchedIndexBox = new TextBox();
            resultNameLabel = new Label();
            ComplexityBox = new TextBox();
            GoBackButton = new Button();
            SuspendLayout();
            // 
            // txtButton
            // 
            txtButton.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtButton.Location = new Point(45, 206);
            txtButton.Name = "txtButton";
            txtButton.Size = new Size(199, 66);
            txtButton.TabIndex = 1;
            txtButton.Text = "Завантажити текстовий файл";
            txtButton.UseVisualStyleBackColor = true;
            txtButton.Click += txtButton_Click;
            // 
            // AnimationButton
            // 
            AnimationButton.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimationButton.Location = new Point(288, 206);
            AnimationButton.Name = "AnimationButton";
            AnimationButton.Size = new Size(199, 66);
            AnimationButton.TabIndex = 2;
            AnimationButton.Text = "Анімація пошуку";
            AnimationButton.UseVisualStyleBackColor = true;
            AnimationButton.Click += AnimationButton_Click;
            // 
            // SearchedIndexBox
            // 
            SearchedIndexBox.BackColor = SystemColors.Menu;
            SearchedIndexBox.BorderStyle = BorderStyle.None;
            SearchedIndexBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchedIndexBox.Location = new Point(29, 81);
            SearchedIndexBox.Name = "SearchedIndexBox";
            SearchedIndexBox.Size = new Size(458, 24);
            SearchedIndexBox.TabIndex = 3;
            // 
            // resultNameLabel
            // 
            resultNameLabel.AutoSize = true;
            resultNameLabel.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultNameLabel.ForeColor = Color.DarkBlue;
            resultNameLabel.Location = new Point(100, 9);
            resultNameLabel.Name = "resultNameLabel";
            resultNameLabel.Size = new Size(341, 48);
            resultNameLabel.TabIndex = 5;
            resultNameLabel.Text = "Результати пошуку";
            // 
            // ComplexityBox
            // 
            ComplexityBox.BackColor = SystemColors.Menu;
            ComplexityBox.BorderStyle = BorderStyle.None;
            ComplexityBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ComplexityBox.Location = new Point(29, 121);
            ComplexityBox.Name = "ComplexityBox";
            ComplexityBox.Size = new Size(505, 24);
            ComplexityBox.TabIndex = 7;
            // 
            // GoBackButton
            // 
            GoBackButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoBackButton.Location = new Point(12, 9);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(68, 29);
            GoBackButton.TabIndex = 8;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(546, 358);
            Controls.Add(GoBackButton);
            Controls.Add(ComplexityBox);
            Controls.Add(resultNameLabel);
            Controls.Add(SearchedIndexBox);
            Controls.Add(AnimationButton);
            Controls.Add(txtButton);
            Name = "ResultsForm";
            Text = "Результати пошуку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button txtButton;
        private Button AnimationButton;
        private TextBox SearchedIndexBox;
        private Label resultNameLabel;
        private TextBox ComplexityBox;
        private Button GoBackButton;
    }
}