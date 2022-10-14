using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static bool chuoiDoiXung(char[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != A[A.Length - 1 - i])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //Nhap chuoi
            Console.WriteLine("Nhap chuoi: ");
            string s = "";
            s = Console.ReadLine();
            Console.WriteLine();

            //chuyen doi chuoi sang mang
            char[] mangChuoi = s.ToCharArray();
            Console.WriteLine("\nChuoi ban dau: " + s);


            //chuoi doi xung
            if (chuoiDoiXung(mangChuoi))
            {
                Console.Write("Chuoi doi xung");
            }
            else
            {
                Console.Write("Chuoi khong doi xung");
            }
            Console.WriteLine();

            //Doi ky tu dau thanh chu hoa
            Console.WriteLine("Doi ky tu dau thanh chu hoa:");
            if (mangChuoi[0] == ' ')
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (mangChuoi[i] == ' ' && mangChuoi[i + 1] != ' ')
                    {
                        mangChuoi[i + 1] = char.ToUpper(mangChuoi[i + 1]);
                    }
                }
            }
            else
            {
                mangChuoi[0] = char.ToUpper(mangChuoi[0]);
                for (int i = 0; i < s.Length; i++)
                {
                    if (mangChuoi[i] == ' ' && mangChuoi[i + 1] != ' ')
                    {
                        mangChuoi[i + 1] = char.ToUpper(mangChuoi[i + 1]);
                    }
                }
            }
            Console.WriteLine(mangChuoi);

            //Doi ky tu thuong thanh chu hoa va nguoc lai
            Console.Write("Doi ky tu thuong thanh chu hoa va nguoc lai: ");
            for (int i = 0; i < s.Length; i++)
            {
                if (mangChuoi[i] == char.ToUpper(mangChuoi[i]))
                {
                    mangChuoi[i] = char.ToLower(mangChuoi[i]);
                }
                else
                {
                    mangChuoi[i] = char.ToUpper(mangChuoi[i]);
                }
            }
            Console.WriteLine(mangChuoi);

            //Nguyen am, phu am, khoang trang trong chuoi s
            int nguyenAm = 0, phuAm = 0, khoangTrang = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (mangChuoi[i] == 'a' || mangChuoi[i] == 'e' || mangChuoi[i] == 'i' || mangChuoi[i] == 'o' || mangChuoi[i] == 'o' || mangChuoi[i] == 'u' || mangChuoi[i] == 'y' || mangChuoi[i] == 'A' || mangChuoi[i] == 'E' || mangChuoi[i] == 'I' || mangChuoi[i] == 'O' || mangChuoi[i] == 'U' || mangChuoi[i] == 'Y')
                {
                    nguyenAm++;
                }

                else if (mangChuoi[i] == ' ')
                {
                    khoangTrang++;
                }

                else
                {
                    phuAm++;
                }
            }
            Console.WriteLine($"Nguyen am: {nguyenAm}\nPhu am: {phuAm}\nKhoang trang: {khoangTrang}");

        }
    }
}
