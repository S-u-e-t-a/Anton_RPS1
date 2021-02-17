namespace firstLab
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.ButtonChooseFile = new System.Windows.Forms.Button();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonManual = new System.Windows.Forms.RadioButton();
            this.labelSize = new System.Windows.Forms.Label();
            this.ButtonEnterArray = new System.Windows.Forms.Button();
            this.UpDownSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.InputArrayTextBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSize)).BeginInit();
            this.ResultBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Controls.Add(this.ButtonChooseFile);
            this.InputBox.Controls.Add(this.radioButtonFile);
            this.InputBox.Controls.Add(this.radioButtonRandom);
            this.InputBox.Controls.Add(this.radioButtonManual);
            this.InputBox.Controls.Add(this.labelSize);
            this.InputBox.Controls.Add(this.ButtonEnterArray);
            this.InputBox.Controls.Add(this.UpDownSize);
            this.InputBox.Controls.Add(this.label1);
            this.InputBox.Controls.Add(this.InputArrayTextBox);
            this.InputBox.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.InputBox.Location = new System.Drawing.Point(13, 27);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(577, 140);
            this.InputBox.TabIndex = 0;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "Ввод данных";
            // 
            // ButtonChooseFile
            // 
            this.ButtonChooseFile.Enabled = false;
            this.ButtonChooseFile.Location = new System.Drawing.Point(252, 106);
            this.ButtonChooseFile.Name = "ButtonChooseFile";
            this.ButtonChooseFile.Size = new System.Drawing.Size(151, 26);
            this.ButtonChooseFile.TabIndex = 13;
            this.ButtonChooseFile.Text = "Открыть файл...";
            this.ButtonChooseFile.UseVisualStyleBackColor = true;
            this.ButtonChooseFile.Click += new System.EventHandler(this.ButtonChooseFile_Click);
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(6, 106);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(170, 22);
            this.radioButtonFile.TabIndex = 12;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "Ввести массив из файла";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            this.radioButtonFile.CheckedChanged += new System.EventHandler(this.RadioButtonFile_CheckedChanged);
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(6, 78);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(221, 22);
            this.radioButtonRandom.TabIndex = 11;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Заполнить случайными числами";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.RadioButtonRandom_CheckedChanged);
            // 
            // radioButtonManual
            // 
            this.radioButtonManual.AutoSize = true;
            this.radioButtonManual.Location = new System.Drawing.Point(6, 48);
            this.radioButtonManual.Name = "radioButtonManual";
            this.radioButtonManual.Size = new System.Drawing.Size(99, 22);
            this.radioButtonManual.TabIndex = 10;
            this.radioButtonManual.TabStop = true;
            this.radioButtonManual.Text = "Ручной ввод";
            this.radioButtonManual.UseVisualStyleBackColor = true;
            this.radioButtonManual.CheckedChanged += new System.EventHandler(this.RadioButtonManual_CheckedChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(249, 79);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(106, 18);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Размер массива:";
            // 
            // ButtonEnterArray
            // 
            this.ButtonEnterArray.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ButtonEnterArray.ForeColor = System.Drawing.Color.OrangeRed;
            this.ButtonEnterArray.Location = new System.Drawing.Point(484, 48);
            this.ButtonEnterArray.Name = "ButtonEnterArray";
            this.ButtonEnterArray.Size = new System.Drawing.Size(83, 26);
            this.ButtonEnterArray.TabIndex = 4;
            this.ButtonEnterArray.Text = "Запуск";
            this.ButtonEnterArray.UseVisualStyleBackColor = true;
            this.ButtonEnterArray.Click += new System.EventHandler(this.ButtonEnterArray_Click);
            // 
            // UpDownSize
            // 
            this.UpDownSize.Enabled = false;
            this.UpDownSize.Location = new System.Drawing.Point(361, 79);
            this.UpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownSize.Name = "UpDownSize";
            this.UpDownSize.Size = new System.Drawing.Size(117, 25);
            this.UpDownSize.TabIndex = 3;
            this.UpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите элементы массива через пробел";
            // 
            // InputArrayTextBox
            // 
            this.InputArrayTextBox.Location = new System.Drawing.Point(112, 48);
            this.InputArrayTextBox.Name = "InputArrayTextBox";
            this.InputArrayTextBox.ReadOnly = true;
            this.InputArrayTextBox.Size = new System.Drawing.Size(366, 25);
            this.InputArrayTextBox.TabIndex = 0;
            // 
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.labelResult);
            this.ResultBox.Controls.Add(this.label2);
            this.ResultBox.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ResultBox.Location = new System.Drawing.Point(13, 177);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(577, 116);
            this.ResultBox.TabIndex = 1;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Результаты";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(291, 48);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 28);
            this.labelResult.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество отрицательных чисел в массиве перед наибольшим положительным:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.InfoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveINToolStripMenuItem,
            this.SaveOUTToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.справкаToolStripMenuItem.Text = "Файл";
            // 
            // SaveINToolStripMenuItem
            // 
            this.SaveINToolStripMenuItem.Enabled = false;
            this.SaveINToolStripMenuItem.Name = "SaveINToolStripMenuItem";
            this.SaveINToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.SaveINToolStripMenuItem.Text = "Сохранить входные данные";
            this.SaveINToolStripMenuItem.Click += new System.EventHandler(this.SaveINToolStripMenuItem_Click);
            // 
            // SaveOUTToolStripMenuItem
            // 
            this.SaveOUTToolStripMenuItem.Enabled = false;
            this.SaveOUTToolStripMenuItem.Name = "SaveOUTToolStripMenuItem";
            this.SaveOUTToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.SaveOUTToolStripMenuItem.Text = "Сохранить результат";
            this.SaveOUTToolStripMenuItem.Click += new System.EventHandler(this.SaveOUTToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem1
            // 
            this.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1";
            this.InfoToolStripMenuItem1.Size = new System.Drawing.Size(65, 22);
            this.InfoToolStripMenuItem1.Text = "Справка";
            this.InfoToolStripMenuItem1.Click += new System.EventHandler(this.InfoToolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 305);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Лаб №1 Вариант №3";
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSize)).EndInit();
            this.ResultBox.ResumeLayout(false);
            this.ResultBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.NumericUpDown UpDownSize;
        private System.Windows.Forms.Button ButtonEnterArray;
        private System.Windows.Forms.TextBox InputArrayTextBox;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonChooseFile;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonManual;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveOUTToolStripMenuItem;
    }
}

