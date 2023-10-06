namespace algorithm_assignment.algorithm
{
    internal class OptionB
    {
        public static void Insert(string[] A, ref int n, string NewCustomer)
        {
            if (n<A.Length)
            {
                int i = 0;
                while (i<n && A[i].CompareTo(NewCustomer)<0)
                {
                    i += 1;
                }
                int j = n - 1;
                while (j >= i)
                {
                    A[j + 1] = A[j];
                    j -= 1;
                }
                A[i] = NewCustomer;
                n += 1;
            }
            else
            {
                Console.WriteLine("The array is already full");
            }
        }

        public static int Search(string[] A, ref int n, string Customer)
        {
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (A[m] == Customer)
                {
                    return m;
                }
                else if (A[m].CompareTo(Customer)>0)
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            return -1;
        }

        public static void Delete(string[] A, ref int n, string Customer)
        {
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (A[m] == Customer)
                {
                    while (m < n-1)
                    {
                        A[m] = A[m + 1];
                        m = m + 1;
                    }
                    n -= 1;
                    return;
                }
                else if (A[m].CompareTo(Customer) > 0)
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            Console.WriteLine("This customer is not in the array");
        }
    }
}
