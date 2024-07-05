using System.Collections.Generic;

namespace courseWorkList
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(571, 698);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(563, 670);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Добавление в голову";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(218, 652);
            label9.Name = "label9";
            label9.Size = new Size(165, 15);
            label9.TabIndex = 8;
            label9.Text = "Увеличиваем размер списка";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 532);
            label8.Name = "label8";
            label8.Size = new Size(343, 105);
            label8.TabIndex = 7;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 461);
            label7.Name = "label7";
            label7.Size = new Size(339, 60);
            label7.TabIndex = 6;
            label7.Text = "Если список пуст (т.е. голова списка равна null), новый узел\r\n становится головой списка. Указатели Next и Previous\r\n нового узла и так равны null, поэтому их не нужно\r\n дополнительно устанавливать";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 421);
            label6.Name = "label6";
            label6.Size = new Size(267, 30);
            label6.TabIndex = 5;
            label6.Text = "Создается новый узел с указанным значением.\r\n Это будет новый элемент списка.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 359);
            label5.Name = "label5";
            label5.Size = new Size(316, 45);
            label5.TabIndex = 4;
            label5.Text = " Здесь осуществляется проверка, достигнут ли максим-\r\n-альный размер списка (list.capacity). Если да,\r\n метод возвращается без добавления нового узла.\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 337);
            label4.Name = "label4";
            label4.Size = new Size(208, 300);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 109);
            label2.Name = "label2";
            label2.Size = new Size(537, 195);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 3);
            label1.Name = "label1";
            label1.Size = new Size(516, 75);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(563, 670);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Поиск";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(226, 521);
            label15.Name = "label15";
            label15.Size = new Size(271, 45);
            label15.TabIndex = 6;
            label15.Text = "Если после прохождения цикла мы не находим\r\nнужный нам элемент, то возвращаем -1\r\n\r\n";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(226, 424);
            label14.Name = "label14";
            label14.Size = new Size(214, 75);
            label14.TabIndex = 5;
            label14.Text = "Если значение current\r\nи значение, которое нам дано равны,\r\nто возвращаем n и выходим\r\nиз цикла. Иначе current становится\r\nследующим узлом.\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(226, 387);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 4;
            label13.Text = "Начало цикла";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(226, 330);
            label12.Name = "label12";
            label12.Size = new Size(188, 45);
            label12.TabIndex = 3;
            label12.Text = "Объявляем переменную current,\r\nкоторая равна голове списка\r\n и счетчик n\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 339);
            label11.Name = "label11";
            label11.Size = new Size(168, 255);
            label11.TabIndex = 2;
            label11.Text = resources.GetString("label11.Text");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 95);
            label10.Name = "label10";
            label10.Size = new Size(550, 210);
            label10.TabIndex = 1;
            label10.Text = resources.GetString("label10.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 23);
            label3.Name = "label3";
            label3.Size = new Size(545, 60);
            label3.TabIndex = 0;
            label3.Text = resources.GetString("label3.Text");
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 699);
            Controls.Add(tabControl1);
            Name = "FormInfo";
            Text = "Информация";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label15;
    }
}