using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhap mang
            int m, n;
            Console.Write("Nhap so dong: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            n = int.Parse(Console.ReadLine());
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap phan tu A[{0}][{1}]: ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Xuat mang
            Console.WriteLine("Mang: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("{0}\t ", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //tong phan tu duong
            Console.Write("Tong phan tu duong: ");
            int tongPhanTuDuong = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] > 0)
                    {
                        tongPhanTuDuong += A[i, j];
                    }
                }
            }
            Console.WriteLine(tongPhanTuDuong);
            Console.WriteLine();

            //tong phan tu tren duong cheo chinh
            Console.Write("Tong phan tu tren duong cheo ching: ");
            int tongPhanTuTrenDuongCheoChinh = 0;
            if (n != m)
            {
                Console.WriteLine("Day khong phai la ma tran vuong, ban hay nhap ma tran vuong!!!");
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            tongPhanTuTrenDuongCheoChinh += A[i, j];
                        }
                    }
                }
                Console.WriteLine(tongPhanTuTrenDuongCheoChinh);
            }
            Console.WriteLine();

            //Tong cac phan tu trong tam giac tren
            Console.Write("Tong cac phan tu trong tam giac tren: ");
            int tongPhanTuTrongTamGiacTren = 0;
            if (n != m)
            {
                Console.WriteLine("Day khong phai la ma tran vuong, ban hay nhap ma tran vuong!!!");
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j > i)
                        {
                            tongPhanTuTrongTamGiacTren += A[i, j];
                        }
                    }
                }
                Console.WriteLine(tongPhanTuTrongTamGiacTren);
            }
            Console.WriteLine();

            //Tong phan tu chan
            Console.Write("Tong phan tu chan: ");
            int tongPhanTuChan = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        tongPhanTuChan += A[i, j];
                    }
                }
            }
            Console.WriteLine(tongPhanTuChan);
            Console.WriteLine();

            //Tong cac phan tu o dong thu i
            int tongDongThuI = 0;
            Console.Write("Nhap dong muon tinh tong: ");
            int Dong = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                i = Dong;
                for (int j = 0; j < n; j++)
                {

                    tongDongThuI += A[Dong, j];
                }
            }
            Console.Write("Tong cac phan tu o dong thu {0}: ", Dong);
            Console.WriteLine(tongDongThuI);
        }
    }
}
