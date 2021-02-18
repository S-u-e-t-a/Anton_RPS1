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
            for(int i = 1; i < splittedArr.Length; i++)
            {
                if(splittedArr[i] == splittedArr[i-1] && splittedArr[i] == " ")
                {
                    splittedArr[i] = splittedArr[i].Remove(1);
                }
            }
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
                return null;
            }
            return tempArray;
        }  
    }
}
