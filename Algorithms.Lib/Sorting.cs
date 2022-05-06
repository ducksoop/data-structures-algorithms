namespace Algorithms.Lib
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            for (var partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (var i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (var partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;
                for (var i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }

                Swap(array, largestAt, partIndex);
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j) return;

            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}
