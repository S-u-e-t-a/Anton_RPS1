namespace firstLab
{
    public class Counting
    {
        public int CountNegative(int[] array)
        {
            var max = array[0];
            var indexOfMax = 0;
            var countNegative = 0;
            for (var i = 0; i < array.Length; i++)
                if (array[i] > max && array[i] > 0)
                {
                    max = array[i];
                    indexOfMax = i;
                }

            for (var i = 0; i < indexOfMax; i++)
                if (array[i] < 0)
                    countNegative++;
            if (max == array[0] && (indexOfMax != 0 || max < 0))
                return -1;
            return countNegative;
        }
    }
}