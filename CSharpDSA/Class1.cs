namespace Main
{
    public class Class1
    {
        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        static int BinarySearch(int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                int val = array[middle];
                Console.WriteLine("Middle: " + val);
                if (val < target)
                {
                    low = middle + 1;
                }
                else if (val > target)
                {
                    high = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
        static int interpolationSearch(int[] array, int value)
        {
            int high = array.Length - 1;
            int low = 0;
            while (value >= array[low] && value <= array[high] && low <= high)
            {
                int probe = low + (high - low) * (value - array[low]) / (array[high] - array[low]);
                Console.WriteLine("Probe: " + probe);
                if (array[probe] == value)
                {
                    return probe;
                }
                else if (array[probe] < value)
                {
                    low = probe + 1;
                }
                else
                {
                    high = probe - 1;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] array = [9, 213, 21, 42, 1, 7, 2, 8, 23213];
            BubbleSort(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(BinarySearch([0, 1, 2, 4, 8, 16, 123, 343, 43], 2));
            int index = interpolationSearch(array, 213);
            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
        }
    }
}