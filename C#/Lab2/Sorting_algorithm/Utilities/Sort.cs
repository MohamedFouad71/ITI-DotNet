namespace Sorting_algorithm.UTILITIES
{
    class Sort
    {

        #region UTILITIES
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[(high + low) / 2]; //Median of three
            high++; low--; // Preparing Crusers Preventing Stuck in infinite loop

            while (true)
            {
                do { --high; } while (arr[high] < pivot);
                do { ++low; } while (arr[low] > pivot);

                if (high <= low) return high;

                swap(ref arr[high], ref arr[low]);
            }

        }
        #endregion
        
        public static void Quicksort(int[] arr, int low, int high)
        {
            if (high <= low) return;

            int pivotIndex = Partition(arr, low, high);
            Quicksort(arr, low, pivotIndex);
            Quicksort(arr, pivotIndex + 1, high);
        }
    

}

}
