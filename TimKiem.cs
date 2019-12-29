        static int TimKiemTuanTuVetCan(int[] a, int n, int x)
        {
            int pos = -1;
            for (int i = 0; i < n; i++)
                if (a[i] == x)
                {
                    pos = i;
                    break;
                }
            return pos;
        }
        static int TimKiemTuanTuLinhCanh(int[] a, int n, int x)
        {
            int[] b = new int[n + 1];
            Array.Copy(a, b, n);
            b[n] = x;
            int i = 0;
            while(b[i] != x)
                i++;
            if (i == n)
                return -1;
            return i;
        }
        static int TimKiemNhiPhan(int[] a, int n, int x)
        {
            int pos = -1;
            int left = 0;
            int right = n - 1;
            while(left <= right)
            {
                int mid = (left + right)/ 2;
                if (a[mid] == x)
                {
                    pos = mid;
                    break;
                }
                if (a[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return pos;
        }
        static int TimKiemNhiPhanDeQuy(int[] a, int left, int right, int x)
        {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            if (a[mid] == x) return mid;
            if (x < a[mid]) return TimKiemNhiPhanDeQuy(a, left, mid - 1, x);
            return TimKiemNhiPhanDeQuy(a, mid + 1, right, x);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int i = TimKiemTuanTuVetCan(A, n, x);
            //int i = TimKiemTuanTuLinhCanh(A, n, x);
            //int i = TimKiemNhiPhan(A, n, x);
            //int i = TimKiemNhiPhanDeQuy(A, 0, n-1, x);
            if (pos == -1)
                Console.WriteLine($"Khong tim thay {x}");
            Console.Write($"{x} o vi tri {i}");
            Console.ReadLine();
        }
