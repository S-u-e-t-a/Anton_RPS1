using System;
using System.Windows.Forms;

namespace firstLab
{
    class SaveData
    {
        public void SaveEnteredData(string path, int[] arrayToSave)
        {
            try
            {
                System.IO.File.WriteAllText(path, string.Empty);
                for (int i = 0; i < arrayToSave.Length; i++)
                {
                    System.IO.File.AppendAllText(path, arrayToSave[i].ToString());
                    if(i != arrayToSave.Length-1)
                    {
                        System.IO.File.AppendAllText(path, " ");
                    }
                }
                MessageBox.Show("Данные сохранены",
                                    "Информация");
            }
            catch
            {
                MessageBox.Show("Выбранный Вами файл предназначен только для чтения",
                    "Ошибка!");
            }
        }

        public void SaveResults(string path, int[] arrayToSave, string result)
        {
            try
            {
                System.IO.File.WriteAllText(path, string.Empty);
                System.IO.File.AppendAllText(path, "Вы ввели массив длинной: " + arrayToSave.Length + Environment.NewLine);
                System.IO.File.AppendAllText(path, "Массив: " + Environment.NewLine);
                for (int i = 0; i < arrayToSave.Length; i++)
                {
                    System.IO.File.AppendAllText(path, "[" + arrayToSave[i].ToString() + "]");
                    if (i != arrayToSave.Length - 1)
                    {
                        System.IO.File.AppendAllText(path, " ");
                    }
                }
                System.IO.File.AppendAllText(path, Environment.NewLine);
                System.IO.File.AppendAllText(path, "Количество отрицательных чисел перед наибольшим в массиве: " + result + Environment.NewLine);
                MessageBox.Show("Results are saved",
                                    "Information");
            }
            catch
            {
                MessageBox.Show("Выбранный Вами файл предназначен только для чтения",
                    "Ошибка!");
            }
        }
    }
}
