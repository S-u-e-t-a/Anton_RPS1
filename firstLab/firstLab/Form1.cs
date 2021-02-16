﻿using System;
using System.Windows.Forms;


namespace firstLab
{
    public partial class Form1 : Form
    {
        private const string smthGoesWrong = "-1"; // код потенциальной ошибки работы 
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false; // запрет изменения размера окна
            saveFileDialog.Filter = "Text files(*.txt)|*.txt"; // фильтр файлов при сохранении (All?)
        }

        private string pathOpen; 
        private int[] mainArray = null;

        ///<summary>
        ///Область описания поведения элементов интерфейса для ввода массива
        ///</summary>
        
        /* EventArgs - это класс, дающий возможность передать какую-нибудь дополнительную 
         * информацию обработчику (например, текущие координаты мыши при событии MouseMove).
        sender - это объект, который вызвал событие.*/
        private void RadioButtonManual_CheckedChanged(object sender, EventArgs e)  // если выбран ручной ввод
        {
            // включение и отключение различных ограничений в интерфейсе
            InputArrayTextBox.ReadOnly = false; // поле ввода можно редактировать     

            UpDownSize.Enabled = false; // элемент выбора размера заблокирован
            ButtonChooseFile.Enabled = false; // кнопка выбор файла заблокирована
        }
        private void RadioButtonRandom_CheckedChanged(object sender, EventArgs e) // если выбран рандомное заполнение
        {
            UpDownSize.Enabled = true; // выбор размера разблокирован

            InputArrayTextBox.ReadOnly = true; // редактирование поле вывода массива запрещено
            ButtonChooseFile.Enabled = false; // кнопка выбора файла заблокирована
        }
        private void RadioButtonFile_CheckedChanged(object sender, EventArgs e) // если выбран ввод из файла
        {
            ButtonChooseFile.Enabled = true; // кнопка выбора файла разблокирована

            InputArrayTextBox.ReadOnly = true; // редактирование поле вывода массива запрещено
            UpDownSize.Enabled = false; // элемент выбора размера заблокирован
        }

        ///<summary>
        ///Описание поведения при нажатии кнопки Enter
        ///</summary>
        private void ButtonEnterArray_Click(object sender, EventArgs e) // если нажата кнопка Запуск
        { 
            InputData Process = new InputData(); // создаём объект класса InputData
            if (radioButtonManual.Checked == true) // если выбран ручной ввод
            {
                string InputtedArray = InputArrayTextBox.Text; // вводим массив
                if (InputtedArray == string.Empty) // обработка пустой строки
                {
                    MessageBox.Show("Вы пытаетесь ввести пустую строку. Попытайтесь еще раз", "Внимание!");
                }
                else
                {
                    mainArray = Process.ManualInputting(InputtedArray); // формирование массива из чисел
                    string result = Process.CountNegative(mainArray).ToString(); // формирование результата
                    if (result == smthGoesWrong) // обработка возможности отсутствия результата
                    {
                        labelResult.Text = "Нет решений";
                    }
                    else
                    {
                        labelResult.Text = result; // вывод результата
                    }
                }
                
            }
            else if (radioButtonRandom.Checked == true) // если выбрано заполнение рандомными числами
            {
                int size = Convert.ToInt32(UpDownSize.Text); // получение размера будущего массива
                mainArray = Process.RandomFilling(size); // формирование массива размером size

                InputArrayTextBox.Text = string.Empty; // очистка области вывода массива
                for (int i = 0; i < mainArray.Length; i++) // вывод сформированного массива 
                {
                    InputArrayTextBox.Text += mainArray[i];
                    if(i != mainArray.Length - 1)
                        InputArrayTextBox.Text += " ";
                }

                string result = Process.CountNegative(mainArray).ToString(); // формирование результата
                if (result == smthGoesWrong) // обработка отсутствия результата
                {
                    labelResult.Text = "Нет решений";
                }
                else
                {
                    labelResult.Text = result; // вывод результата
                }

            }
            else if (radioButtonFile.Checked == true) // если выбран ввод из файла
            {
                if (pathOpen == string.Empty) // обработка пустого имени файла
                {
                    MessageBox.Show("Вы не выбрали файл. Сначала укажите из какого файла ввести данные", "Внимание!");
                }
                else
                {
                    mainArray = Process.FromFileFilling(pathOpen); // формирование массива из данных из файла

                    InputArrayTextBox.Text = string.Empty;// очистка области вывода массива
                    for (int i = 0; i < mainArray.Length; i++) // вывод сформированного массива 
                    {
                        InputArrayTextBox.Text += mainArray[i];
                        if (i != mainArray.Length - 1)
                            InputArrayTextBox.Text += " ";
                    }

                    string result = Process.CountNegative(mainArray).ToString(); // формирование результата задачи
                    if (result == smthGoesWrong) { // обработка отсутствия решений
                        labelResult.Text = "Нет решений";
                    }
                    else
                    {
                        labelResult.Text = result; // вывод результата
                    }
                }
                pathOpen = string.Empty; // очистка имени файла
            }

            if (mainArray != null) // если массив существует 
            {
                ButtonSaveEnteredData.Enabled = true;  // разблокировка кнопки сохранения введенного массива
            }

            if (labelResult.Text != string.Empty) // если результат существует
            {
                ButtonSaveResults.Enabled = true;// разблокировка кнопки сохранения результатов
            }
        }

        private void ButtonChooseFile_Click(object sender, EventArgs e) // нажатие кнопки выбора файла из которого загружаем массив
        {
            MessageBox.Show("Обратите внимание, что файл, который Вы хотите открыть, должен содержать только числа, разделённые знаком пробела. Символы, буквы и лишние знаки пробела приведут к ошибке!",
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                ); // предупреждение о формате вводимых данных
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                pathOpen = string.Empty;
                return; // обработка закрытия окна выбора файла
            }
            pathOpen = openFileDialog.FileName; // получение имени файла 

        }

        private void ButtonSaveEnteredData_Click(object sender, EventArgs e) // нажатие кнопки сохранения введенных данных
        {
            SaveData Saving = new SaveData(); // создание объекта класса SaveData
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return; // обработка закрытия окна сохранения введенных данных
            string filenameSaveEnteredData = saveFileDialog.FileName;// получение имени файла 
            Saving.SaveEnteredData(filenameSaveEnteredData, mainArray); // сохранение введённых данных
        }

        private void ButtonSaveResults_Click(object sender, EventArgs e) // нажатие кнопки сохранения результатов
        {
            SaveData Saving = new SaveData(); // создание объекта класса SaveData
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return; // обработка закрытия окна сохранения результатов
            string filenameSaveRes = saveFileDialog.FileName; // получение имени файла 
            Saving.SaveResults(filenameSaveRes, mainArray, labelResult.Text); // сохранение результатов
        }
        private void ButtonInfo_Click(object sender, EventArgs e) // нажатие кнопки Информация
        {
            AboutBox infoWindow = new AboutBox(); // создание объекта класса AboutBox
            infoWindow.Show(); // открываем форму с информацией
        }

        private void ButtonExit_Click(object sender, EventArgs e) // нажатие кнопки выход
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите закрыть программу?",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                ); // обработка решения
            if (res == DialogResult.Yes)
            {
                Close(); // выход
            }
        }

    }
}
