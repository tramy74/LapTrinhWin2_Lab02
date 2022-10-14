using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bai1
{
    internal class Program
    {

        public static Boolean songuyento(int n)
        {
            /*bool check = true;
            for (int i = 2; i < n; i++)
                if (n % i == 0) check = false;
            if (check) return true;
            else return false;*/
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            //nhap mang a gom n phan tu. Xuat mang a
            //nhap mang
            Console.Write("Moi nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[1000];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Moi nhap mang a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //xuat mang
            Console.Write("mang : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();

            //liet ke cac phan tu le o vi tri chan
            Console.Write("Phan tu le o vi tri chan : ");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    if (a[i] % 2 != 0)
                    {
                        Console.Write("{0} ", a[i]);
                    }
                }
            }
            Console.WriteLine();

            //liet ke so nguyen to
            Console.Write("So nguyen to : ");
            for (int i = 0; i < n; i++)
            {
                if (songuyento(a[i]))
                {
                    Console.Write("{0} ", a[i]);
                }
            }
            Console.WriteLine();

            //tim phan tu am dau tien
            Console.Write("Phan tu am dau tien : ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    Console.Write("{0} ", a[i]);
                    return;
                }
            }
            Console.WriteLine();

            //tim max,min
            Console.Write("Max : ");
            int MAX = a[0], MIN = a[0];
            for (int i = 1; i < n; i++)
            {
                if (MAX < a[i])
                    MAX = a[i];
                if (MIN > a[i])
                    MIN = a[i];
            }
            Console.WriteLine(MAX);
            Console.Write("Min : ");
            Console.WriteLine(MIN);

            //tinh tong cac phan tu trong mang
            Console.Write("Tong : ");
            int sum = a[0];
            for (int i = 1; i < n; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
            //Console.ReadKey();
        }
    }
}
