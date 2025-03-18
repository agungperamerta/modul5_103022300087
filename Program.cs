using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
public class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic d = (dynamic)a;
        dynamic d2 = (dynamic)b;
        dynamic d3 = (dynamic)c;
        if (d > d2 && d > d3)
        {
            Console.WriteLine($"Nilai Terbesar : {d}");
        }
        else if (d2 > d && d2 > d3)
        {
            Console.WriteLine($"Nilai Terbesar : {d2}");
        }
        else
        {
            Console.WriteLine($"Nilai Terbesar : {d3}");
        }
    }

    public class Program
    {
        static void Main()
        {
            PemrosesData data = new PemrosesData();
            Console.WriteLine("Masukkan input 1: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan input 2: ");
            int d2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan input 1: ");
            int d3 = Convert.ToInt32(Console.ReadLine());
            data.DapatkanNilaiTerbesar(d, d2, d3);
        }
    }
}

