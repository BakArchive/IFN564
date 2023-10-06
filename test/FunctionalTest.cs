using static System.Console;
using algorithm_assignment.algorithm;

namespace algorithm_assignment.test
{
    internal class FunctionalTest
    {
        static int N_max = 3; 
        static string[] source = new string[] {
            "test3",
            "test2",
            "test1",
        };
        static string[] sortedSource = new string[]
        {
            "test1",
            "test2",
            "test3",
        };

        // Functional test for Insert of Option A
        public static void InsertOptionA()
        {
            string[] arr = new string[N_max];
            int n = 0;
            WriteLine("=== Functional test for Insert of Option A ===");
            for (int i = 0; i < source.Length; ++i)
            {
                WriteLine("add new item {0}", source[i]);
                OptionA.Insert(arr, ref n, source[i]);
                WriteLine("existing items in array: {0}", ShowItems(arr, n));
            }
            WriteLine("n is {0}, N_max is {1}", n, N_max);
            OptionA.Insert(arr, ref n, "test4");
        }

        // Functional test for Insert of Option B
        public static void InsertOptionB()
        {
            string[] arr = new string[N_max];
            int n = 0;
            WriteLine("=== Functional test for Insert of Option B ===");
            for (int i = 0; i < source.Length; ++i)
            {
                WriteLine("add new item {0}", source[i]);
                OptionB.Insert(arr, ref n, source[i]);
                WriteLine("existing items in array: {0}", ShowItems(arr, n));
            }
            WriteLine("n is {0}, N_max is {1}", n, N_max);
            OptionB.Insert(arr, ref n, "test4");
        }


        // Functional test for Search of Option A
        public static void SearchOptionA()
        {
            string[] arr = source;
            int n = N_max;
            string inArrStr = arr[1];
            string notInArrStr = "test4";
            WriteLine("=== Functional test for Search of Option A ===");
            int index = OptionA.Search(arr, ref n, inArrStr);
            WriteLine("the key item is {0}", arr[index]);
            WriteLine("its index is {0}", index);
            WriteLine("is it the same as the target? {0}", arr[index] == inArrStr);
            index = OptionA.Search(arr, ref n, notInArrStr);
            WriteLine("for unexisting item, the index is {0}", index);
        }

        // Functional test for Search of Option B
        public static void SearchOptionB()
        {
            string[] arr = sortedSource;
            int n = N_max;
            string inArrStr = arr[1];
            string notInArrStr = "test4";
            WriteLine("=== Functional test for Search of Option B ===");
            int index = OptionB.Search(arr, ref n, inArrStr);
            WriteLine("the key item is {0}", arr[index]);
            WriteLine("its index is {0}", index);
            WriteLine("is it the same as the target? {0}", arr[index] == inArrStr);
            index = OptionB.Search(arr, ref n, notInArrStr);
            WriteLine("for unexisting item, the index is {0}", index);
        }

        // Functional test for Delete of Option A
        public static void DeleteOptionA()
        {
            string[] arr = source;
            int n = N_max;
            string inArrStr = arr[1];
            string notInArrStr = "test4";
            WriteLine("=== Functional test for Delete of Option A ===");
            WriteLine("existing items in array: {0}", ShowItems(arr, n));
            WriteLine("delete an item in the array: {0}", inArrStr);
            OptionA.Delete(arr, ref n, inArrStr);
            WriteLine("existing items in array: {0}", ShowItems(arr, n));
            WriteLine("the size of current array: {0}", n);
            WriteLine("delete an unexisting item: {0}", notInArrStr);
            OptionA.Delete(arr, ref n, notInArrStr);
            WriteLine("the size of current array: {0}", n);
        }

        // Functional test for Delete of Option B
        public static void DeleteOptionB()
        {
            string[] arr = sortedSource;
            int n = N_max;
            string inArrStr = arr[1];
            string notInArrStr = "test4";
            WriteLine("=== Functional test for Delete of Option B ===");
            WriteLine("existing items in array: {0}", ShowItems(arr, n));
            WriteLine("delete an item in the array: {0}", inArrStr);
            OptionB.Delete(arr, ref n, inArrStr);
            WriteLine("existing items in array: {0}", ShowItems(arr, n));
            WriteLine("the size of current array: {0}", n);
            WriteLine("delete an unexisting item: {0}", notInArrStr);
            OptionB.Delete(arr, ref n, notInArrStr);
            WriteLine("the size of current array: {0}", n);
        }

        // print available items in array
        private static string ShowItems(string[] arr, int n)
        {
            string result = "[";
            for (int i = 0; i < n; ++i)
            {
                result += arr[i];
                if (i < n - 1)
                {
                    result += ", ";
                }
            }
            result += "]";
            return result;
        }
    }
}
