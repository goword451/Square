namespace Square
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
            this.СalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TopsNumberBox = new System.Windows.Forms.TextBox();
            this.TopsNumberInfo = new System.Windows.Forms.Label();
            this.EnterTopsNumberButton = new System.Windows.Forms.Button();
            this.InputXInfo = new System.Windows.Forms.Label();
            this.InputXBox = new System.Windows.Forms.TextBox();
            this.InputYInfo = new System.Windows.Forms.Label();
            this.InputYBox = new System.Windows.Forms.TextBox();
            this.EnterXYButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // СalculateButton
            // 
            this.СalculateButton.Location = new System.Drawing.Point(23, 199);
            this.СalculateButton.Name = "СalculateButton";
            this.СalculateButton.Size = new System.Drawing.Size(141, 60);
            this.СalculateButton.TabIndex = 0;
            this.СalculateButton.Text = "Рассчитать";
            this.СalculateButton.UseVisualStyleBackColor = true;
            this.СalculateButton.Click += new System.EventHandler(this.СalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(202, 199);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(141, 60);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // TopsNumberBox
            // 
            this.TopsNumberBox.Location = new System.Drawing.Point(231, 12);
            this.TopsNumberBox.Name = "TopsNumberBox";
            this.TopsNumberBox.Size = new System.Drawing.Size(112, 23);
            this.TopsNumberBox.TabIndex = 3;
            this.TopsNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TopsNumberBox_KeyPress);
            // 
            // TopsNumberInfo
            // 
            this.TopsNumberInfo.AutoSize = true;
            this.TopsNumberInfo.Location = new System.Drawing.Point(23, 15);
            this.TopsNumberInfo.Name = "TopsNumberInfo";
            this.TopsNumberInfo.Size = new System.Drawing.Size(164, 15);
            this.TopsNumberInfo.TabIndex = 4;
            this.TopsNumberInfo.Text = "Введите количество вершин";
            // 
            // EnterTopsNumberButton
            // 
            this.EnterTopsNumberButton.Location = new System.Drawing.Point(231, 41);
            this.EnterTopsNumberButton.Name = "EnterTopsNumberButton";
            this.EnterTopsNumberButton.Size = new System.Drawing.Size(112, 23);
            this.EnterTopsNumberButton.TabIndex = 5;
            this.EnterTopsNumberButton.Text = "Ввод";
            this.EnterTopsNumberButton.UseVisualStyleBackColor = true;
            this.EnterTopsNumberButton.Click += new System.EventHandler(this.EnterTopsNumberButton_Click);
            // 
            // InputXInfo
            // 
            this.InputXInfo.AutoSize = true;
            this.InputXInfo.Location = new System.Drawing.Point(23, 92);
            this.InputXInfo.Name = "InputXInfo";
            this.InputXInfo.Size = new System.Drawing.Size(126, 15);
            this.InputXInfo.TabIndex = 6;
            this.InputXInfo.Text = "Введите координату x";
            // 
            // InputXBox
            // 
            this.InputXBox.Location = new System.Drawing.Point(231, 89);
            this.InputXBox.Name = "InputXBox";
            this.InputXBox.Size = new System.Drawing.Size(112, 23);
            this.InputXBox.TabIndex = 7;
            this.InputXBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputXBox_KeyPress);
            // 
            // InputYInfo
            // 
            this.InputYInfo.AutoSize = true;
            this.InputYInfo.Location = new System.Drawing.Point(23, 125);
            this.InputYInfo.Name = "InputYInfo";
            this.InputYInfo.Size = new System.Drawing.Size(126, 15);
            this.InputYInfo.TabIndex = 9;
            this.InputYInfo.Text = "Введите координату y";
            this.InputYBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputYBox_KeyPress);
            // 
            // InputYBox
            // 
            this.InputYBox.Location = new System.Drawing.Point(231, 122);
            this.InputYBox.Name = "InputYBox";
            this.InputYBox.Size = new System.Drawing.Size(112, 23);
            this.InputYBox.TabIndex = 10;
            // 
            // EnterXYButton
            // 
            this.EnterXYButton.Location = new System.Drawing.Point(231, 151);
            this.EnterXYButton.Name = "EnterXYButton";
            this.EnterXYButton.Size = new System.Drawing.Size(112, 23);
            this.EnterXYButton.TabIndex = 11;
            this.EnterXYButton.Text = "Ввод";
            this.EnterXYButton.UseVisualStyleBackColor = true;
            this.EnterXYButton.Click += new System.EventHandler(this.EnterXYButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 282);
            this.Controls.Add(this.EnterXYButton);
            this.Controls.Add(this.InputYBox);
            this.Controls.Add(this.InputYInfo);
            this.Controls.Add(this.InputXBox);
            this.Controls.Add(this.InputXInfo);
            this.Controls.Add(this.EnterTopsNumberButton);
            this.Controls.Add(this.TopsNumberInfo);
            this.Controls.Add(this.TopsNumberBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.СalculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт площади";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button СalculateButton;
        private Button ResetButton;
        private TextBox TopsNumberBox;
        private Label TopsNumberInfo;
        private Button EnterTopsNumberButton;
        private Label InputXInfo;
        private TextBox InputXBox;
        private Label InputYInfo;
        private TextBox InputYBox;
        private Button EnterXYButton;
    }
}