using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
        }

        private string pathOpen;
        private int[] mainArray = null;

        ///<summary>
        ///Область описания поведения элементов интерфейса для ввода массива
        ///</summary>
        private void RadioButtonManual_CheckedChanged(object sender, EventArgs e)
        {
            InputArrayTextBox.ReadOnly = false;
            InputArrayTextBox.Enabled = true;

            UpDownSize.Enabled = false;
            ButtonChooseFile.Enabled = false;
        }
        private void RadioButtonRandom_CheckedChanged(object sender, EventArgs e)
        {
            UpDownSize.Enabled = true;

            InputArrayTextBox.Enabled = false;
            ButtonChooseFile.Enabled = false;
        }
        private void RadioButtonFile_CheckedChanged(object sender, EventArgs e)
        {
            ButtonChooseFile.Enabled = true;

            UpDownSize.Enabled = false;
            InputArrayTextBox.Enabled = false;
        }

        ///<summary>
        ///Описания поведения при нажатии кнопки Enter
        ///</summary>
        private void ButtonEnterArray_Click(object sender, EventArgs e)
        { 

            InputData Process = new InputData();
            if (radioButtonManual.Checked == true)
            {

                string InputtedArray = InputArrayTextBox.Text;
                if (InputtedArray == "")
                {
                    MessageBox.Show("Вы пытаетесь ввести пустую строку. Попытайтесь еще раз", "Внимание!");
                }
                else
                {
                    mainArray = Process.ManualInputting(InputtedArray);
                    string result = Process.CountNegative(mainArray).ToString();
                    if (result == "-1")
                    {
                        labelResult.Text = "Нет чисел > 0";
                    }
                    else
                    {
                        labelResult.Text = result;
                    }
                }
                
            }
            else if (radioButtonRandom.Checked == true)
            {
                int size = Convert.ToInt32(UpDownSize.Text);
                mainArray = Process.RandomFilling(size);
                string result = Process.CountNegative(mainArray).ToString();
                if (result == "-1")
                {
                    labelResult.Text = "Нет чисел > 0";
                }
                else
                {
                    labelResult.Text = result;
                }

                InputArrayTextBox.Enabled = true;
                InputArrayTextBox.ReadOnly = true;
                for (int i = 0; i < mainArray.Length; i++)
                {
                    InputArrayTextBox.Text += mainArray[i];
                    InputArrayTextBox.Text += " ";
                }
            }
            else if (radioButtonFile.Checked == true)
            {
                if (pathOpen == "")
                {
                    MessageBox.Show("Вы не выбрали файл. Сначала укажите из какого файла ввести данные", "Внимание!");
                }
                else
                {
                    mainArray = Process.FromFileFilling(pathOpen);
                    string result = Process.CountNegative(mainArray).ToString();
                    if (result == "-1") {
                        labelResult.Text = "Нет чисел > 0";
                    }
                    else
                    {
                        labelResult.Text = result;
                    }
                }
                InputArrayTextBox.Enabled = true;
                InputArrayTextBox.ReadOnly = true;
                for (int i = 0; i < mainArray.Length; i++)
                {
                    InputArrayTextBox.Text += mainArray[i];
                    InputArrayTextBox.Text += " ";
                }
                pathOpen = "";
            }

            if (mainArray != null)
            {
                ButtonSaveEnteredData.Enabled = true;  
            }

            if (labelResult.Text != "?")
            {
                ButtonSaveResults.Enabled = true;
            }
        }

        private void ButtonChooseFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратите внимание, что файл, который Вы хотите открыть, должен содержать только числа, разделённые знаком пробела. Символы, буквы и лишние знаки пробела приведут к ошибке!",
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            pathOpen = openFileDialog.FileName;

        }

        private void ButtonSaveEnteredData_Click(object sender, EventArgs e)
        {
            SaveData Saving = new SaveData();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filenameSaveEnteredData = saveFileDialog.FileName;
            Saving.SaveEnteredData(filenameSaveEnteredData, mainArray);
        }

        private void ButtonSaveResults_Click(object sender, EventArgs e)
        {
            SaveData Saving = new SaveData();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filenameSaveRes = saveFileDialog.FileName;
            Saving.SaveResults(filenameSaveRes, mainArray, labelResult.Text);
        }
        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            AboutBox infoWindow = new AboutBox();
            infoWindow.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите закрыть программу?",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                );
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
