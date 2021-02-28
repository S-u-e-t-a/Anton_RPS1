using System;
using System.IO;
using System.Windows.Forms;

namespace firstLab
{
    public class InputData
    {
        public int[] ManualInputting(string arr)
        {
            int[] errorArr = {0};
            var splittedArr = arr.Split(' ');
            for (var i = 1; i < splittedArr.Length; i++)
                if (splittedArr[i] == splittedArr[i - 1] && splittedArr[i] == " ")
                    splittedArr[i] = splittedArr[i].Remove(1);
            var tempArray = new int[splittedArr.Length];
            try
            {
                for (var i = 0; i < splittedArr.Length; i++) tempArray[i] = Convert.ToInt32(splittedArr[i]);
            }
            catch
            {
                MessageBox.Show(@"Массив содержит символы или буквы. Попробуйте еще раз",
                    @"Ошибка!");
                return errorArr;
            }

            return tempArray;
        }

        public int[] RandomFilling(int size)
        {
            var rand = new Random();
            var tempArray = new int[size];
            for (var i = 0; i < size; i++) tempArray[i] = rand.Next(-50, 50);
            return tempArray;
        }

        public int[] FromFileFilling(string path)
        {
            var arrayStr = File.ReadAllText(path);

            var splittedArr = arrayStr.Split(' ');

            var tempArray = new int[splittedArr.Length];
            try
            {
                for (var i = 0; i < splittedArr.Length; i++) tempArray[i] = Convert.ToInt32(splittedArr[i]);
            }
            catch
            {
                MessageBox.Show(
                    @"Массив в файле содержит символы или буквы. Проверьте правильность данных в файле или укажите путь на другой файл ",
                    @"Ошибка!");
                return null;
            }

            return tempArray;
        }
    }
}