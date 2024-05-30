namespace Interface_Course_work
{
    partial class GenerationForm
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
            dimensionBox = new TextBox();
            dimensionLabel = new Label();
            limitLabel = new Label();
            mainNameLabel = new Label();
            GenerationButton = new Button();
            lowerLimitBox = new TextBox();
            upperLimitBox = new TextBox();
            displayArrayBox = new TextBox();
            ElementToFindLabel = new Label();
            ElementBox = new TextBox();
            FindButton = new Button();
            methodLabel = new Label();
            generatedArrayLabel = new Label();
            ChooseMethodBox = new ComboBox();
            InstructionButton = new Button();
            SuspendLayout();
            // 
            // dimensionBox
            // 
            dimensionBox.BackColor = Color.White;
            dimensionBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dimensionBox.Location = new Point(281, 95);
            dimensionBox.Name = "dimensionBox";
            dimensionBox.Size = new Size(85, 28);
            dimensionBox.TabIndex = 2;
            // 
            // dimensionLabel
            // 
            dimensionLabel.AutoSize = true;
            dimensionLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dimensionLabel.Location = new Point(41, 95);
            dimensionLabel.Name = "dimensionLabel";
            dimensionLabel.Size = new Size(234, 24);
            dimensionLabel.TabIndex = 3;
            dimensionLabel.Text = "Введіть розмірність масиву:";
            // 
            // limitLabel
            // 
            limitLabel.AutoSize = true;
            limitLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            limitLabel.Location = new Point(41, 138);
            limitLabel.Name = "limitLabel";
            limitLabel.Size = new Size(443, 24);
            limitLabel.TabIndex = 4;
            limitLabel.Text = "Вкажіть межі генерування масиву: від                     до";
            // 
            // mainNameLabel
            // 
            mainNameLabel.AutoSize = true;
            mainNameLabel.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mainNameLabel.ForeColor = Color.DarkBlue;
            mainNameLabel.Location = new Point(159, 9);
            mainNameLabel.Name = "mainNameLabel";
            mainNameLabel.Size = new Size(622, 48);
            mainNameLabel.TabIndex = 5;
            mainNameLabel.Text = "Пошук заданих елементів у масиві";
            // 
            // GenerationButton
            // 
            GenerationButton.BackColor = SystemColors.ButtonHighlight;
            GenerationButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GenerationButton.Location = new Point(671, 95);
            GenerationButton.Name = "GenerationButton";
            GenerationButton.Size = new Size(101, 49);
            GenerationButton.TabIndex = 6;
            GenerationButton.Text = "Генерувати масив";
            GenerationButton.UseVisualStyleBackColor = false;
            GenerationButton.Click += GenerationButton_Click;
            // 
            // lowerLimitBox
            // 
            lowerLimitBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lowerLimitBox.Location = new Point(365, 135);
            lowerLimitBox.Name = "lowerLimitBox";
            lowerLimitBox.Size = new Size(81, 28);
            lowerLimitBox.TabIndex = 7;
            // 
            // upperLimitBox
            // 
            upperLimitBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            upperLimitBox.Location = new Point(490, 135);
            upperLimitBox.Name = "upperLimitBox";
            upperLimitBox.Size = new Size(81, 28);
            upperLimitBox.TabIndex = 8;
            // 
            // displayArrayBox
            // 
            displayArrayBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            displayArrayBox.Location = new Point(41, 215);
            displayArrayBox.Multiline = true;
            displayArrayBox.Name = "displayArrayBox";
            displayArrayBox.ScrollBars = ScrollBars.Vertical;
            displayArrayBox.Size = new Size(863, 323);
            displayArrayBox.TabIndex = 9;
            // 
            // ElementToFindLabel
            // 
            ElementToFindLabel.AutoSize = true;
            ElementToFindLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ElementToFindLabel.Location = new Point(41, 572);
            ElementToFindLabel.Name = "ElementToFindLabel";
            ElementToFindLabel.Size = new Size(321, 24);
            ElementToFindLabel.TabIndex = 10;
            ElementToFindLabel.Text = "Вкажіть значення шуканого елемента:";
            // 
            // ElementBox
            // 
            ElementBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ElementBox.Location = new Point(368, 569);
            ElementBox.Name = "ElementBox";
            ElementBox.Size = new Size(81, 28);
            ElementBox.TabIndex = 11;
            // 
            // FindButton
            // 
            FindButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FindButton.Location = new Point(426, 628);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(94, 29);
            FindButton.TabIndex = 12;
            FindButton.Text = "Знайти елемент";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // methodLabel
            // 
            methodLabel.AutoSize = true;
            methodLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            methodLabel.Location = new Point(501, 572);
            methodLabel.Name = "methodLabel";
            methodLabel.Size = new Size(197, 24);
            methodLabel.TabIndex = 13;
            methodLabel.Text = "Оберіть метод пошуку:";
            // 
            // generatedArrayLabel
            // 
            generatedArrayLabel.AutoSize = true;
            generatedArrayLabel.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            generatedArrayLabel.Location = new Point(337, 181);
            generatedArrayLabel.Name = "generatedArrayLabel";
            generatedArrayLabel.Size = new Size(251, 32);
            generatedArrayLabel.TabIndex = 15;
            generatedArrayLabel.Text = "Згенерований масив";
            // 
            // ChooseMethodBox
            // 
            ChooseMethodBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChooseMethodBox.FormattingEnabled = true;
            ChooseMethodBox.Items.AddRange(new object[] { "послідовний метод", "метод Фібоначчі", "інтерполяційний метод", "метод хеш-функції" });
            ChooseMethodBox.Location = new Point(704, 569);
            ChooseMethodBox.Name = "ChooseMethodBox";
            ChooseMethodBox.Size = new Size(200, 28);
            ChooseMethodBox.TabIndex = 16;
            // 
            // InstructionButton
            // 
            InstructionButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InstructionButton.Location = new Point(794, 95);
            InstructionButton.Name = "InstructionButton";
            InstructionButton.Size = new Size(110, 49);
            InstructionButton.TabIndex = 18;
            InstructionButton.Text = "Правила введення";
            InstructionButton.UseVisualStyleBackColor = true;
            InstructionButton.Click += InstructionButton_Click;
            // 
            // GenerationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(937, 684);
            Controls.Add(InstructionButton);
            Controls.Add(ChooseMethodBox);
            Controls.Add(generatedArrayLabel);
            Controls.Add(methodLabel);
            Controls.Add(FindButton);
            Controls.Add(ElementBox);
            Controls.Add(ElementToFindLabel);
            Controls.Add(displayArrayBox);
            Controls.Add(upperLimitBox);
            Controls.Add(lowerLimitBox);
            Controls.Add(GenerationButton);
            Controls.Add(mainNameLabel);
            Controls.Add(limitLabel);
            Controls.Add(dimensionLabel);
            Controls.Add(dimensionBox);
            Name = "GenerationForm";
            Text = "Пошук заданих елементів у масиві";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox dimensionBox;
        private Label dimensionLabel;
        private Label limitLabel;
        private Label mainNameLabel;
        private Button GenerationButton;
        private TextBox lowerLimitBox;
        private TextBox upperLimitBox;
        private TextBox displayArrayBox;
        private Label ElementToFindLabel;
        private TextBox ElementBox;
        private Button FindButton;
        private Label methodLabel;
        private Label generatedArrayLabel;
        private ComboBox ChooseMethodBox;
        private Button InstructionButton;
    }
}
