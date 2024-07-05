namespace courseWorkList
{
    partial class MainForm
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
            pictureBoxDrawningObj = new PictureBox();
            panelButton = new Panel();
            buttonStepDown = new Button();
            buttonStep = new Button();
            numericUpDownSearchElem = new NumericUpDown();
            buttonSearch = new Button();
            numericUpDownElemList = new NumericUpDown();
            buttonAdd = new Button();
            buttonCreate = new Button();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            информацияToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrawningObj).BeginInit();
            panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchElem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownElemList).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxDrawningObj
            // 
            pictureBoxDrawningObj.Location = new Point(-1, 27);
            pictureBoxDrawningObj.Name = "pictureBoxDrawningObj";
            pictureBoxDrawningObj.Size = new Size(636, 422);
            pictureBoxDrawningObj.TabIndex = 0;
            pictureBoxDrawningObj.TabStop = false;
            // 
            // panelButton
            // 
            panelButton.Controls.Add(buttonStepDown);
            panelButton.Controls.Add(buttonStep);
            panelButton.Controls.Add(numericUpDownSearchElem);
            panelButton.Controls.Add(buttonSearch);
            panelButton.Controls.Add(numericUpDownElemList);
            panelButton.Controls.Add(buttonAdd);
            panelButton.Controls.Add(buttonCreate);
            panelButton.Location = new Point(638, 12);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(160, 437);
            panelButton.TabIndex = 1;
            // 
            // buttonStepDown
            // 
            buttonStepDown.Location = new Point(3, 396);
            buttonStepDown.Name = "buttonStepDown";
            buttonStepDown.Size = new Size(154, 38);
            buttonStepDown.TabIndex = 6;
            buttonStepDown.Text = "Шаг назад";
            buttonStepDown.UseVisualStyleBackColor = true;
            buttonStepDown.Click += buttonStepDown_Click;
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(3, 352);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(154, 38);
            buttonStep.TabIndex = 5;
            buttonStep.Text = "Шаг вперед";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // numericUpDownSearchElem
            // 
            numericUpDownSearchElem.Location = new Point(18, 326);
            numericUpDownSearchElem.Name = "numericUpDownSearchElem";
            numericUpDownSearchElem.Size = new Size(120, 23);
            numericUpDownSearchElem.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(3, 272);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(154, 48);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // numericUpDownElemList
            // 
            numericUpDownElemList.Location = new Point(18, 212);
            numericUpDownElemList.Name = "numericUpDownElemList";
            numericUpDownElemList.Size = new Size(120, 23);
            numericUpDownElemList.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 158);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(154, 48);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(3, 27);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(154, 54);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Создать список";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, LoadToolStripMenuItem, информацияToolStripMenuItem });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(48, 20);
            ToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(148, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click_1;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.Size = new Size(148, 22);
            LoadToolStripMenuItem.Text = "Загрузить";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // информацияToolStripMenuItem
            // 
            информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            информацияToolStripMenuItem.Size = new Size(148, 22);
            информацияToolStripMenuItem.Text = "Информация";
            информацияToolStripMenuItem.Click += InfoToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelButton);
            Controls.Add(pictureBoxDrawningObj);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrawningObj).EndInit();
            panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchElem).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownElemList).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDrawningObj;
        private Panel panelButton;
        private Button buttonSearch;
        private NumericUpDown numericUpDownElemList;
        private Button buttonAdd;
        private Button buttonCreate;
        private Button buttonStep;
        private NumericUpDown numericUpDownSearchElem;
        private Button buttonStepDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem информацияToolStripMenuItem;
    }
}