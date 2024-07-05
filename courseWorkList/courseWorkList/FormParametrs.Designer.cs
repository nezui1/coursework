namespace courseWorkList
{
    partial class FormParametrs
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
            buttonCancle = new Button();
            buttonCreat = new Button();
            numericUpDownSize = new NumericUpDown();
            labelSize = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).BeginInit();
            SuspendLayout();
            // 
            // buttonCancle
            // 
            buttonCancle.Location = new Point(269, 55);
            buttonCancle.Name = "buttonCancle";
            buttonCancle.Size = new Size(75, 23);
            buttonCancle.TabIndex = 0;
            buttonCancle.Text = "Отмена";
            buttonCancle.UseVisualStyleBackColor = true;
            buttonCancle.Click += buttonCancle_Click;
            // 
            // buttonCreat
            // 
            buttonCreat.Location = new Point(2, 55);
            buttonCreat.Name = "buttonCreat";
            buttonCreat.Size = new Size(75, 23);
            buttonCreat.TabIndex = 1;
            buttonCreat.Text = "Создать";
            buttonCreat.UseVisualStyleBackColor = true;
            buttonCreat.Click += buttonCreat_Click;
            // 
            // numericUpDownSize
            // 
            numericUpDownSize.Location = new Point(2, 26);
            numericUpDownSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownSize.Name = "numericUpDownSize";
            numericUpDownSize.Size = new Size(120, 23);
            numericUpDownSize.TabIndex = 2;
            numericUpDownSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(18, 5);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(47, 15);
            labelSize.TabIndex = 3;
            labelSize.Text = "Размер";
            // 
            // FormParametrs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 79);
            Controls.Add(labelSize);
            Controls.Add(numericUpDownSize);
            Controls.Add(buttonCreat);
            Controls.Add(buttonCancle);
            Name = "FormParametrs";
            Text = "FormParametrs";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancle;
        private Button buttonCreat;
        private NumericUpDown numericUpDownSize;
        private Label labelSize;
    }
}