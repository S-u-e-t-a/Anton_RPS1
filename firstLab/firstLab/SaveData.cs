using System;
using System.IO;
using System.Windows.Forms;

namespace firstLab
{
    internal class SaveData
    {
        public void SaveEnteredData(string path, int[] arrayToSave)
        {
            try
            {
                File.WriteAllText(path, string.Empty);
                for (var i = 0; i < arrayToSave.Length; i++)
                {
                    File.AppendAllText(path, arrayToSave[i].ToString());
                    if (i != arrayToSave.Length - 1) File.AppendAllText(path, @" ");
                }

                MessageBox.Show(@"Данные сохранены",
                    @"Информация");
            }
            catch
            {
                MessageBox.Show(@"Выбранный Вами файл предназначен только для чтения",
                    @"Ошибка!");
            }
        }

        public void SaveResults(string path, int[] arrayToSave, string result)
        {
            try
            {
                File.WriteAllText(path, string.Empty);
                File.AppendAllText(path, @"Вы ввели массив длинной: " + arrayToSave.Length + Environment.NewLine);
                File.AppendAllText(path, @"Массив: " + Environment.NewLine);
                for (var i = 0; i < arrayToSave.Length; i++)
                {
                    File.AppendAllText(path, @"[" + arrayToSave[i] + @"]");
                    if (i != arrayToSave.Length - 1) File.AppendAllText(path, @" ");
                }

                File.AppendAllText(path, Environment.NewLine);
                File.AppendAllText(path,
                    @"Количество отрицательных чисел перед наибольшим положительным элементом в массиве: " + result +
                    Environment.NewLine);
                MessageBox.Show(@"Результаты сохранены",
                    @"Информация");
            }
            catch
            {
                MessageBox.Show(@"Выбранный Вами файл предназначен только для чтения",
                    @"Ошибка!");
            }
        }
    }
}