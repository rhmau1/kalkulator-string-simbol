using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR MODEL STRING + SYMBOL");
            Console.WriteLine("================================\n");
            string ulang="";
            do
            {
                Console.Write("Masukkan operasi hitung [berisi angka dan simbol] : ");
                string input = Console.ReadLine();

                if (input.Contains("="))
                {
                    char[] simbol = { '+', '-', '*', ':' };
                    int posisi = input.IndexOfAny(simbol);
                    int posisiEquals = input.IndexOf('=');
                    int x = input.Length - (posisi + 1) - 1;
                    int pertama = Convert.ToInt32(input.Substring(0, posisi));
                    int kedua = Convert.ToInt32(input.Substring(posisi + 1, x));
                    char operasi = input[posisi];

                    switch (operasi)
                    {
                        case '+':
                            Console.WriteLine("Hasil = " + Tambah(pertama, kedua));
                            break;
                        case '-':
                            Console.WriteLine("Hasil = " + Kurang(pertama, kedua));
                            break;
                        case '*':
                            Console.WriteLine("Hasil = " + Kali(pertama, kedua));
                            break;
                        case ':':
                            Console.WriteLine("Hasil = " + Bagi(pertama, kedua));
                            break;
                        default:
                            Console.WriteLine("\nPilihan anda tidak tersedia");
                            break;
                    }
                    Console.Write("Apakah anda ingin melakukan perhitungan lagi [Y/N] : ");
                    ulang = Console.ReadLine().ToUpper();
                    }
                else
                {
                    Console.Write("Operasi tidak valid karena tidak ada tanda = ");
                }
            } while (ulang == "Y");
        }                

        static int Tambah(int angka1, int angka2)
        {
            int hasil = angka1 + angka2;
            return hasil;
        }

        static int Kurang(int angka1, int angka2)
        {
            int hasil = angka1 - angka2;
            return hasil;
        }

        static int Kali(int angka1, int angka2)
        {
            int hasil = angka1 * angka2;
            return hasil;
        }

        static int Bagi(int angka1, int angka2)
        {
            int hasil = angka1 / angka2;
            return hasil;
        }
    }
}        
