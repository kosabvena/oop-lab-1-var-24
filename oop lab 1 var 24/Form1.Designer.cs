namespace oop_lab_1_var_24
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
            label1 = new Label();
            label2 = new Label();
            lblMin = new Label();
            lblMinIndex = new Label();
            lblMax = new Label();
            lblMaxIndex = new Label();
            txtInput = new TextBox();
            txtCount = new TextBox();
            btnKeyboard = new Button();
            btnRandom = new Button();
            btnFile = new Button();
            lstArray = new ListBox();
            btnFind = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 15);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Кількість елементів:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 48);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Масив:";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(9, 418);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(166, 20);
            lblMin.TabIndex = 2;
            lblMin.Text = "Мінімальний елемент:";
            // 
            // lblMinIndex
            // 
            lblMinIndex.AutoSize = true;
            lblMinIndex.Location = new Point(9, 447);
            lblMinIndex.Name = "lblMinIndex";
            lblMinIndex.Size = new Size(225, 20);
            lblMinIndex.TabIndex = 3;
            lblMinIndex.Text = "Індекс мінімального елемента:";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(9, 485);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(180, 20);
            lblMax.TabIndex = 4;
            lblMax.Text = "Максимальний елемент:";
            // 
            // lblMaxIndex
            // 
            lblMaxIndex.AutoSize = true;
            lblMaxIndex.Location = new Point(9, 515);
            lblMaxIndex.Name = "lblMaxIndex";
            lblMaxIndex.Size = new Size(239, 20);
            lblMaxIndex.TabIndex = 5;
            lblMaxIndex.Text = "Індекс максимального елемента:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(65, 45);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(215, 27);
            txtInput.TabIndex = 6;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(155, 12);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(125, 27);
            txtCount.TabIndex = 7;
            // 
            // btnKeyboard
            // 
            btnKeyboard.Location = new Point(2, 90);
            btnKeyboard.Name = "btnKeyboard";
            btnKeyboard.Size = new Size(94, 29);
            btnKeyboard.TabIndex = 8;
            btnKeyboard.Text = "Ввести";
            btnKeyboard.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(102, 90);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(94, 29);
            btnRandom.TabIndex = 9;
            btnRandom.Text = "Випадкові";
            btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnFile
            // 
            btnFile.Location = new Point(202, 90);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(94, 29);
            btnFile.TabIndex = 10;
            btnFile.Text = "З файлу";
            btnFile.UseVisualStyleBackColor = true;
            // 
            // lstArray
            // 
            lstArray.FormattingEnabled = true;
            lstArray.Location = new Point(2, 125);
            lstArray.Name = "lstArray";
            lstArray.Size = new Size(294, 244);
            lstArray.TabIndex = 11;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(20, 375);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(260, 29);
            btnFind.TabIndex = 12;
            btnFind.Text = "Знайти Min / Max";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 559);
            Controls.Add(btnFind);
            Controls.Add(lstArray);
            Controls.Add(btnFile);
            Controls.Add(btnRandom);
            Controls.Add(btnKeyboard);
            Controls.Add(txtCount);
            Controls.Add(txtInput);
            Controls.Add(lblMaxIndex);
            Controls.Add(lblMax);
            Controls.Add(lblMinIndex);
            Controls.Add(lblMin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblMin;
        private Label lblMinIndex;
        private Label lblMax;
        private Label lblMaxIndex;
        private TextBox txtInput;
        private TextBox txtCount;
        private Button btnKeyboard;
        private Button btnRandom;
        private Button btnFile;
        private ListBox lstArray;
        private Button btnFind;
    }
}
