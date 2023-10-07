using algorithm_assignment.algorithm;
using static System.Console;

namespace algorithm_assignment.test
{
    internal class EfficiencyTest
    {
        static Random rd = new Random();
        static int N_max = 11000000;
        static int[] size = new int[] { 1000 ,10000, 100000, 1000000, 10000000 };
        static int round = 3;
        static string[] source = File.ReadAllLines("D:\\projects\\algorithm-assignment\\test.txt");
        static string[] sortedSource = File.ReadAllLines("D:\\projects\\algorithm-assignment\\test_sort.txt");

        // Time cost test for Insert of Option A
        public static void InsertOptionA()
        {
            WriteLine("=== Time cost test for Insert of Option A ===");
            for (int r = 1; r <= round; ++r)
            {
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(source, n);
                    int index = rd.Next(source.Length);
                    long begin = DateTime.Now.Ticks;
                    OptionA.Insert(arr, ref n, source[index]);
                    long end = DateTime.Now.Ticks;
                    WriteLine("round {2}: Insert Option A, size of array: {0}, {1}", size[i], end - begin, r);
                }
            }
        }

        public static void InsertOptionB()
        {
            WriteLine("=== Time cost test for Insert of Option B ===");
            for (int r = 1; r <= round; ++r)
            {
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(source, n);
                    int index = rd.Next(source.Length);
                    long begin = DateTime.Now.Ticks;
                    OptionB.Insert(arr, ref n, source[index]);
                    long end = DateTime.Now.Ticks;
                    WriteLine("round {2}: Insert Option B, size of array: {0}, {1}", size[i], end - begin, r);
                }
            }
        }

        // Time cost test for Search of OptionA
        public static void SearchOptionA()
        {
            WriteLine("=== Time cost test for Search of OptionA ===");
            for (int r = 1; r <= round; ++r)
            {
                WriteLine("round {0}: best case", r);
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(source, n);
                    string key = arr[0];
                    long begin = DateTime.Now.Ticks;
                    OptionA.Search(arr, ref n, key);
                    long end = DateTime.Now.Ticks;
                    WriteLine("size of array: {0}, {1}", size[i], end-begin);
                }
                WriteLine("round {0}: worst case", r);
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(source, n);
                    string key = arr[n-1];
                    long begin = DateTime.Now.Ticks;
                    OptionA.Search(arr, ref n, key);
                    long end = DateTime.Now.Ticks;
                    WriteLine("size of array: {0}, {1}", size[i], end - begin);
                }
            }
        }

        // Time cost test for Search of OptionB
        public static void SearchOptionB()
        {
            WriteLine("=== Time cost test for Search of OptionB ===");
            for (int r = 1; r <= round; ++r)
            {
                WriteLine("round {0}: best case", r);
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(sortedSource, n);
                    string key = arr[(n-1)/2];
                    long begin = DateTime.Now.Ticks;
                    OptionB.Search(arr, ref n, key);
                    long end = DateTime.Now.Ticks;
                    WriteLine("size of array: {0}, {1}", size[i], end - begin);
                }
                WriteLine("round {0}: worst case", r);
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(sortedSource, n);
                    string key = arr[n - 1];
                    long begin = DateTime.Now.Ticks;
                    OptionB.Search(arr, ref n, key);
                    long end = DateTime.Now.Ticks;
                    WriteLine("size of array: {0}, {1}", size[i], end - begin);
                }
            }
        }

        // Time cost test for delete of OptionA
        public static void DeleteOptionA()
        {
            WriteLine("=== Time cost test for delete of OptionA ===");
            for (int r = 1; r <= round; ++r)
            {
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(source, n);
                    int index = rd.Next(n);
                    string key = arr[index];
                    long begin = DateTime.Now.Ticks;
                    OptionA.Delete(arr, ref n, key);
                    long end = DateTime.Now.Ticks;
                    WriteLine("round {0}, size of array: {1}, {2}", r, size[i], end-begin);

                }
            }
        }

        // Time cost test for delete of OptionB
        public static void DeleteOptionB()
        {
            WriteLine("=== Time cost test for delete of OptionB ===");
            for (int r = 1; r <= round; ++r)
            {
                WriteLine("round {0}: best case", r);
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(sortedSource, n);
                    string key = arr[n-1];
                    long begin = DateTime.Now.Ticks;
                    OptionB.Delete(arr, ref n, key);
                    long end = DateTime.Now.Ticks;
                    WriteLine("size of array: {0}, {1}", size[i], end - begin);
                }
                WriteLine("round {0}: worst case", r);
                for (int i = 0; i < size.Length; ++i)
                {
                    int n = size[i];
                    string[] arr = FillArr(sortedSource, n);
                    string key = arr[0];
                    long begin = DateTime.Now.Ticks;
                    OptionB.Delete(arr, ref n, key);
                    long end = DateTime.Now.Ticks;
                    WriteLine("size of array: {0}, {1}", size[i], end - begin);
                }
            }

        }

        // genereate array with n valid items using specific array
        private static string[] FillArr(string[] arr, int n)
        {
            string[] newArr = new string[N_max];
            for (int i = 0; i < n; ++i)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }
    }
}
