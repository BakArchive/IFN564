

namespace algorithm_assignment.algorithm
{
    internal class OptionA
    {
        public static void Insert(string[] A, ref int n, string NewCustomer)
        {
            if (n < A.Length)
            {
                A[n] = NewCustomer;
                n += 1;
            }else
            {
                Console.WriteLine("The array is already full");
            }
        }

        public static int Search(string[] A, ref int n, string Customer)
        {
            for (int i = 0; i<n; ++i)
            {
                if (A[i] == Customer)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Delete(string[] A, ref int n, string Customer)
        {
            int i = 0;
            while (i<n && A[i] != Customer)
            {
                i += 1;
            }
            if (i == n)
            {
                Console.WriteLine("This customer is not in the array");
            }
            else
            {
                while (i < (n - 1))
                {
                    A[i] = A[i + 1];
                    i += 1;
                }
                n -= 1;
            }
        }
    }
}
