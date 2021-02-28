using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;


namespace firstLab
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public partial class MainWindow : Form
    {
        private const string SmthGoesWrong = "-1"; // код потенциальной ошибки работы
        private string pathOpen = "";
        private int[] mainArray;
        public MainWindow()
        {
            InitializeComponent();
            MaximizeBox = false; // запрет изменения размера окна
            saveFileDialog.Filter = @"Text files(*.txt)|*.txt"; // фильтр файлов при сохранении 
        }

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
            if (radioButtonManual.Checked) // если выбран ручной ввод
            {
                string inputtedArray = InputArrayTextBox.Text; // вводим массив
                if (string.IsNullOrEmpty(inputtedArray)) // обработка пустой строки
                {
                    MessageBox.Show(@"Вы пытаетесь ввести пустую строку. Попытайтесь еще раз", @"Внимание!");
                }
                else
                {
                    var countNegative = new Counting(); // создаём объект класса Counting
                    mainArray = Process.ManualInputting(inputtedArray); // формирование массива из чисел
                    var result = countNegative.CountNegative(mainArray).ToString(); // формирование результата
                    if (result == SmthGoesWrong) // обработка возможности отсутствия результата
                    {
                        labelResult.Text = @"Нет решений";
                    }
                    else if (mainArray.Length == 1 && mainArray[0] == 0)
                    {
                        labelResult.Text = "";
                    }
                    else
                    {
                        labelResult.Text = result; // вывод результата
                    }
                }
                
            }
            else if (radioButtonRandom.Checked) // если выбрано заполнение рандомными числами
            {
                var size = Convert.ToInt32(UpDownSize.Text); // получение размера будущего массива
                mainArray = Process.RandomFilling(size); // формирование массива размером size

                InputArrayTextBox.Text = string.Empty; // очистка области вывода массива
                for (var i = 0; i < mainArray.Length; i++) // вывод сформированного массива 
                {
                    InputArrayTextBox.Text += mainArray[i];
                    if(i != mainArray.Length - 1)
                        InputArrayTextBox.Text += @" ";
                }
                var countNegative = new Counting(); // создаём объект класса Counting
                var result = countNegative.CountNegative(mainArray).ToString(); // формирование результата
                labelResult.Text = result == SmthGoesWrong ? "Нет решений" : result;

            }
            else if (radioButtonFile.Checked) // если выбран ввод из файла
            {
                if (pathOpen == string.Empty) // обработка пустого имени файла
                {
                    MessageBox.Show(@"Вы не выбрали файл. Сначала укажите из какого файла ввести данные", @"Внимание!");
                }
                else if(mainArray == null)
                {
                    MessageBox.Show(@"Вы не ввели массив", @"Внимание!");
                }
                else
                {
                    var countNegative = new Counting(); // создаём объект класса Counting
                    var result = countNegative.CountNegative(mainArray).ToString(); // формирование результата задачи
                    labelResult.Text = result == SmthGoesWrong ? "Нет решений" : result;
                }
                
            }
            pathOpen = string.Empty; // очистка имени файла
            if (mainArray != null && !string.IsNullOrEmpty(InputArrayTextBox.Text)) // если массив существует 
            {
                SaveINToolStripMenuItem.Enabled = true;  // разблокировка кнопки сохранения введенного массива
            }

            if (!string.IsNullOrEmpty(InputArrayTextBox.Text)) // если результат существует
            {
                SaveOUTToolStripMenuItem.Enabled = true;// разблокировка кнопки сохранения результатов
            }
            try
            {
                if (mainArray != null)
                {
                    UpDownSize.Value = mainArray.Length;
                }
            }
            catch
            {
                labelSize.Text += @" >";
            }
        }

        private void ButtonChooseFile_Click(object sender, EventArgs e) // нажатие кнопки выбора файла из которого загружаем массив
        {
            MessageBox.Show(@"Обратите внимание, что файл, который Вы хотите открыть, должен содержать только числа, разделённые знаком пробела. Символы, буквы и лишние знаки пробела приведут к ошибке!",
                @"Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                ); // предупреждение о формате вводимых данных
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                pathOpen = string.Empty;
                return; // обработка закрытия окна выбора файла
            }
            pathOpen = openFileDialog.FileName; // получение имени файла 

            var Process = new InputData(); // создаём объект класса InputData
            mainArray = Process.FromFileFilling(pathOpen); // формирование массива из данных из файла

            InputArrayTextBox.Text = string.Empty;// очистка области вывода массива
            if (mainArray != null)
            {
                for (var i = 0; i < mainArray.Length; i++) // вывод сформированного массива 
                {
                    InputArrayTextBox.Text += mainArray[i];
                    if (i != mainArray.Length - 1)
                        InputArrayTextBox.Text += @" ";
                }
            }
            try
            {
                if (mainArray != null)
                {
                    UpDownSize.Value = mainArray.Length;
                }
            }
            catch
            {
                labelSize.Text += @" >";
            }
        }

        private void InfoToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            var infoWindow = new AboutBox(); // создание объекта класса AboutBox
            if (!Application.OpenForms.OfType<AboutBox>().Any())
                infoWindow.Show(); // открываем форму с информацией
        }

        private void SaveINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saving = new SaveData(); // создание объекта класса SaveData
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return; // обработка закрытия окна сохранения введенных данных
            var filenameSaveEnteredData = saveFileDialog.FileName;// получение имени файла 
            saving.SaveEnteredData(filenameSaveEnteredData, mainArray); // сохранение введённых данных
        }

        private void SaveOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saving = new SaveData(); // создание объекта класса SaveData
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return; // обработка закрытия окна сохранения результатов
            var filenameSaveRes = saveFileDialog.FileName; // получение имени файла 
            saving.SaveResults(filenameSaveRes, mainArray, labelResult.Text); // сохранение результатов
        }
    }
}
