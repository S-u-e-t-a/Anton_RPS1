using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace firstLab
{
    public class InputData
    {

        public int[] ManualInputting(string arr)
        {
            int[] errorArr = {0};
            string[] splittedArr = arr.Split(' ');

            int[] tempArray = new int[splittedArr.Length];
            try
            {
                for (int i = 0; i < splittedArr.Length; i++)
                {
                    tempArray[i] = Convert.ToInt32(splittedArr[i]);
                }
            }
            catch
            {
                MessageBox.Show("Массив содержит символы или буквы. Попробуйте еще раз",
                    "Ошибка!");
                return errorArr;
            }
            return tempArray;
        }

        public int[] RandomFilling(int size)
        {
            Random rand = new Random();
            int[] tempArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                tempArray[i] = rand.Next(-50, 50);
            }
            return tempArray;
        }

        public int[] FromFileFilling(string path)
        {
            int[] errorArr = { 0 };
            string arrayStr;
            arrayStr = System.IO.File.ReadAllText(path);

            string[] splittedArr = arrayStr.Split(' ');

            int[] tempArray = new int[splittedArr.Length];
            try
            {
                for (int i = 0; i < splittedArr.Length; i++)
                {
                    tempArray[i] = Convert.ToInt32(splittedArr[i]);
                }
            }
            catch
            {
                MessageBox.Show("Массив в файле содержит символы или буквы. Проверьте правильность данных в файле или укажите путь на другой файл ",
                    "Ошибка!");
                return errorArr;
            }
            return tempArray;
        }

        public int CountNegative(int[] array)
        {
            int max = array[0];
            int indexOfMax = 0;
            int countofNegative = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max && array[i] > 0)
                {
                    max = array[i];
                    indexOfMax = i;
                }
            }

            for (int i = 0; i < indexOfMax; i++)
            {
                if (array[i] < 0)
                {
                    countofNegative++;
                }
            }
            if (indexOfMax == 0)
                return -1;
            return countofNegative;
        }
    }
}
