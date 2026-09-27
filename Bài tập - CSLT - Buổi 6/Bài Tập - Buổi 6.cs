using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_tập___CSLT___Buổi_6
{
    internal class Bài_Tập___Buổi_6
    {
        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;

            foreach (int so in arr)
            {
                tong += so;
            }

            return (double)tong / arr.Length;
        }

        static bool KiemTraTonTai(int[] arr, int x)
        {
            foreach (int so in arr)
            {
                if (so == x)
                {
                    return true;
                }
            }
            return false;
        }

        static int TimChiSo(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] XoaPhanTu(int[] arr, int x)
        {
            int dem = 0;

            foreach (int so in arr)
            {
                if (so == x) dem++;
            }

            int[] ketQua = new int[arr.Length - dem];

            int j = 0;

            foreach (int so in arr)
            {
                if (so != x)
                {
                    ketQua[j] = so;
                    j++;
                }
            }
            return ketQua;
        }

        static int TimMax(int[] arr)
        {
            int max = arr[0];

            foreach (int so in arr)
            {
                if (so > max)
                {
                    max = so;
                }
            }
            return max;
        }

        static int TimMin(int[] arr)
        {
            int min = arr[0];

            foreach (int so in arr)
            {
                if (so < min)
                {
                    min = so;
                }
            }
            return min;
        }

        static int[] DaoNguocMang(int[] arr)
        {
            int[] ketQua = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                ketQua[i] = arr[arr.Length - 1 - i];
            }
            return ketQua;
        }

        static int[] TimTrungLap(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool TrungLap = false;
                for (int j = i + 1; j < arr.Length; j ++)
                {
                    if (arr[i] == arr[j])
                    {
                        TrungLap = true;
                        break;
                    }
                }
                if (TrungLap)
                {
                    bool DaTonTai = false;
                    for (int k = 0; k < count; k++)
                    {
                        if (arr[i] == temp[k])
                        {
                            DaTonTai = true;
                            break;
                        }
                    }
                    if (!DaTonTai)
                    {
                        temp[count] = arr[i];
                        count++;
                    }
                }
            }
            int[] KetQua = new int[count];
            
            for (int i = 0; i < count; i++)
            {
                KetQua[i] = temp[i];
            }
            return KetQua;
        }
        static int[] XoaTrungLap(int[] arr)
        {
            // arr = [1,2,4,4,2,2,6,8,6] 
            // temp= [0,0,0,0,0,0,0,0,0]
            // 
            //KetQua=[]
            int[] temp = new int[arr.Length];

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool DaTonTai = false;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        DaTonTai = true;
                        break;
                    }
                }

                if (!DaTonTai)
                {
                    temp[count] = arr[i];
                    count++;
                }
            }
            int[] KetQua = new int[count];

            for (int i = 0; i < count; i++)
            {
                KetQua[i] = temp[i];
            }
            return KetQua;
        }
        static void BaiTap01()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");

            int n = int.Parse(Console.ReadLine()!);

            int[] mang = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử thứ {i}: ");

                mang[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine();

            Console.WriteLine($"Giá trị trung bình: {TinhTrungBinh(mang)}");

            Console.WriteLine();

            Console.WriteLine($"Giá trị lớn nhất: {TimMax(mang)}");

            Console.WriteLine($"Giá trị nhỏ nhất: {TimMin(mang)}");

            Console.WriteLine();

            Console.Write("Nhập giá trị cần kiểm tra/tìm kiếm X: ");

            int x = int.Parse(Console.ReadLine()!);

            if (KiemTraTonTai(mang, x))
            {
                Console.WriteLine($"Giá trị {x} CÓ tồn tại trong mảng.");

                Console.WriteLine($"Chỉ số xuất hiện đầu tiên của {x} là: {TimChiSo(mang, x)}");
            }
            else
            {
                Console.WriteLine($"Giá trị {x} KHÔNG tồn tại trong mảng.");
            }

            Console.WriteLine();

            Console.Write("Nhập giá trị muốn xóa khỏi mảng Y: ");

            int y = int.Parse(Console.ReadLine()!);

            int[] mangSauKhiXoa = XoaPhanTu(mang, y);

            Console.WriteLine();

            Console.Write("Mảng sau khi xóa: ");

            foreach (int so in mangSauKhiXoa)
            {
                Console.Write($"{so} ");
            }

            int[] mangDaoNguoc = DaoNguocMang(mang);

            Console.WriteLine();

            Console.Write("\nMảng sau khi đảo ngược: ");

            foreach (int so in mangDaoNguoc)
            {
                Console.Write($"{so} ");
            }
            Console.WriteLine();

            Console.Write("\nCác phần tử bị trùng lặp trong mảng: ");

            int[] mangTrungLap = TimTrungLap(mang);

            if (mangTrungLap.Length > 0)
            {
                foreach (int so in mangTrungLap)
                {
                    Console.Write($"{so} ");
                }
            }
            else
            {
                Console.Write("Không có phần tử trùng lặp");
            }
            Console.WriteLine();

            Console.Write("\nMảng sau khi xóa toàn bộ phần tử trùng lặp: ");

            int[] mangXoaTrungLap = XoaTrungLap(mang);

            foreach (int so in mangXoaTrungLap)
            {
                Console.Write($"{so} ");
            }
        }
        

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];

                        arr[j] = arr[j + 1];

                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static int TimKiemTuyenTinh(string[] mangTu, string tuCanTim)
        {
            string tuCanTimLower = tuCanTim.ToLower();

            for (int i = 0; i < mangTu.Length; i++)
            {
                if (mangTu[i].ToLower() == tuCanTimLower)
                {
                    return i;
                }
            }
            return -1;
        }
        static void BaiTap02()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");

            int n = int.Parse(Console.ReadLine()!);

            int[] mang = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử thứ {i}: ");

                mang[i] = int.Parse(Console.ReadLine()!);
            }
            Console.Write("Mảng sau khi đã sắp xếp: ");

            BubbleSort(mang);

            foreach (int so in mang)
            {
                Console.Write($"{so} ");
            }

            // Kiểm tra từ trong câu:

            Console.Write("Nhập vào một câu: ");
            string cau = Console.ReadLine()!;

            Console.Write("Nhập từ cần tìm kiếm: ");
            string tuCanTim = Console.ReadLine()!;

            string[] mangTu = cau.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int viTri = TimKiemTuyenTinh(mangTu, tuCanTim);

            Console.WriteLine("\n--- KẾT QUẢ TÌM KIẾM ---");
            if (viTri != -1)
            {
                Console.WriteLine($"Từ '{tuCanTim}' CÓ xuất hiện trong câu.");

                Console.WriteLine($"Nằm ở vị trí thứ {viTri} trong mảng từ (tính từ 0).");
            }
            else
            {
                Console.WriteLine($"Từ '{tuCanTim}' KHÔNG xuất hiện trong câu.");
            }
        }


        static int[,] TaoMaTranNgauNhien(int n, int m)
        {
            Random rand = new Random();
            int[,] maTran = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    maTran[i, j] = rand.Next(1, 100);
                }
            }
            return maTran;
        }
        static int[] LayHang(int[,] maTran, int rowIndex)
        {
            int soCot = maTran.GetLength(1);
            int[] hang = new int[soCot];
            for (int j = 0; j < soCot; j++)
            {
                hang[j] = maTran[rowIndex, j];
            }
            return hang;
        }
        static int[] LayCot(int[,] maTran, int colIndex)
        {
            int soHang = maTran.GetLength(0);
            int[] cot = new int[soHang];
            for (int i = 0; i < soHang; i++)
            {
                cot[i] = maTran[i, colIndex];
            }
            return cot;
        }
        static int TimMaxMaTran(int[,] maTran)
        {
            int max = maTran[0, 0];
            foreach (int giaTri in maTran)
            {
                if (giaTri > max) max = giaTri;
            }
            return max;
        }
        static int TimMinMang(int[] mang)
        {
            int min = mang[0];
            foreach (int giaTri in mang)
            {
                if (giaTri < min) min = giaTri;
            }
            return min;
        }
        static int[,] ChuyenViMaTran(int[,] maTran)
        {
            int soHang = maTran.GetLength(0);

            int soCot = maTran.GetLength(1);

            int[,] maTranChuyenVi = new int[soCot, soHang];

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    maTranChuyenVi[j, i] = maTran[i, j];
                }
            }
            return maTranChuyenVi;
        }
        static int[] LayCheoChinh(int[,] maTran)
        {
            int n = maTran.GetLength(0);

            int[] cheoChinh = new int[n];

            for (int i = 0; i < n; i++)
            {
                cheoChinh[i] = maTran[i, i];
            }
            return cheoChinh;
        }
        static int[] LayCheoPhu(int[,] maTran)
        {
            int n = maTran.GetLength(0);

            int[] cheoPhu = new int[n];

            for (int i = 0; i < n; i++)
            {
                cheoPhu[i] = maTran[i, n - 1 - i];
            }
            return cheoPhu;
        }
        static void InMaTran(int[,] maTran)
        {
            int soHang = maTran.GetLength(0);

            int soCot = maTran.GetLength(1);

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"{maTran[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        static void InMang(int[] mang)
        {
            foreach (int giaTri in mang)
            {
                Console.Write($"{giaTri} ");
            }
            Console.WriteLine();
        }

        static void BaiTap03()
        {
            Console.Write("Nhập số hàng N: ");

            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập số cột M: ");

            int m = int.Parse(Console.ReadLine()!);

            int[,] maTran = TaoMaTranNgauNhien(n, m);

            Console.WriteLine("\n--- MA TRẬN BAN ĐẦU ---");

            InMaTran(maTran);

            Console.WriteLine($"\nGiá trị lớn nhất của ma trận: {TimMaxMaTran(maTran)}");

            Console.Write("\nNhập chỉ số hàng cần xem (bắt đầu từ 0): ");

            int iHang = int.Parse(Console.ReadLine()!);

            if (iHang >= 0 && iHang < n)
            {
                int[] hangI = LayHang(maTran, iHang);
                Console.Write($"Hàng {iHang}: ");
                InMang(hangI);
                Console.WriteLine($"Giá trị nhỏ nhất của hàng {iHang}: {TimMinMang(hangI)}");
            }

            Console.Write("\nNhập chỉ số cột cần xem (bắt đầu từ 0): ");

            int iCot = int.Parse(Console.ReadLine()!);

            if (iCot >= 0 && iCot < m)
            {
                int[] cotI = LayCot(maTran, iCot);
                Console.Write($"Cột {iCot}: ");
                InMang(cotI);
                Console.WriteLine($"Giá trị nhỏ nhất của cột {iCot}: {TimMinMang(cotI)}");
            }

            Console.WriteLine("\n--- MA TRẬN CHUYỂN VỊ ---");

            int[,] maTranChuyenVi = ChuyenViMaTran(maTran);

            InMaTran(maTranChuyenVi);

            if (n == m)
            {
                Console.WriteLine("\n--- ĐƯỜNG CHÉO (MA TRẬN VUÔNG) ---");

                Console.Write("Đường chéo chính: ");
                InMang(LayCheoChinh(maTran));

                Console.Write("Đường chéo phụ: ");
                InMang(LayCheoPhu(maTran));
            }
            else
            {
                Console.WriteLine("\n(Bỏ qua đường chéo vì đây không phải ma trận vuông N x N)");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.InputEncoding = Encoding.UTF8;

            //BaiTap01();

            //BaiTap02();

            //BaiTap03();
        }
    }
}

