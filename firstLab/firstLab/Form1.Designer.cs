namespace firstLab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.ButtonSaveEnteredData = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.ButtonSaveResults = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.InputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSize)).BeginInit();
            this.ResultBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.InputBox.Location = new System.Drawing.Point(13, 13);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(615, 140);
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
            this.ButtonEnterArray.Location = new System.Drawing.Point(522, 48);
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
            this.UpDownSize.Name = "UpDownSize";
            this.UpDownSize.Size = new System.Drawing.Size(117, 25);
            this.UpDownSize.TabIndex = 3;
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
            this.InputArrayTextBox.Enabled = false;
            this.InputArrayTextBox.Location = new System.Drawing.Point(112, 48);
            this.InputArrayTextBox.Name = "InputArrayTextBox";
            this.InputArrayTextBox.Size = new System.Drawing.Size(404, 25);
            this.InputArrayTextBox.TabIndex = 0;
            // 
            // ButtonSaveEnteredData
            // 
            this.ButtonSaveEnteredData.Enabled = false;
            this.ButtonSaveEnteredData.Location = new System.Drawing.Point(16, 21);
            this.ButtonSaveEnteredData.Name = "ButtonSaveEnteredData";
            this.ButtonSaveEnteredData.Size = new System.Drawing.Size(197, 33);
            this.ButtonSaveEnteredData.TabIndex = 9;
            this.ButtonSaveEnteredData.Text = "Сохранить входные данные\r\n";
            this.ButtonSaveEnteredData.UseVisualStyleBackColor = true;
            this.ButtonSaveEnteredData.Click += new System.EventHandler(this.ButtonSaveEnteredData_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.labelResult);
            this.ResultBox.Controls.Add(this.label2);
            this.ResultBox.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ResultBox.Location = new System.Drawing.Point(13, 160);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(252, 116);
            this.ResultBox.TabIndex = 1;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Результаты";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(56, 75);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 28);
            this.labelResult.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество отрицательных\r\nчисел в массиве перед\r\nнаибольшим положительным:";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(225, 60);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(122, 33);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.Location = new System.Drawing.Point(225, 21);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(122, 33);
            this.ButtonInfo.TabIndex = 2;
            this.ButtonInfo.Text = "Информация";
            this.ButtonInfo.UseVisualStyleBackColor = true;
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // ButtonSaveResults
            // 
            this.ButtonSaveResults.Enabled = false;
            this.ButtonSaveResults.Location = new System.Drawing.Point(16, 60);
            this.ButtonSaveResults.Name = "ButtonSaveResults";
            this.ButtonSaveResults.Size = new System.Drawing.Size(197, 33);
            this.ButtonSaveResults.TabIndex = 1;
            this.ButtonSaveResults.Text = "Сохранить результаты";
            this.ButtonSaveResults.UseVisualStyleBackColor = true;
            this.ButtonSaveResults.Click += new System.EventHandler(this.ButtonSaveResults_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonSaveResults);
            this.groupBox1.Controls.Add(this.ButtonExit);
            this.groupBox1.Controls.Add(this.ButtonInfo);
            this.groupBox1.Controls.Add(this.ButtonSaveEnteredData);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(271, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опции";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.InputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Лаб №1 Вариант №3";
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSize)).EndInit();
            this.ResultBox.ResumeLayout(false);
            this.ResultBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.Button ButtonSaveResults;
        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.NumericUpDown UpDownSize;
        private System.Windows.Forms.Button ButtonEnterArray;
        private System.Windows.Forms.Button ButtonSaveEnteredData;
        private System.Windows.Forms.TextBox InputArrayTextBox;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonChooseFile;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonManual;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

