using System;
using System.Net.NetworkInformation;

public class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T angka1, T angka2, T angka3)
    {
        dynamic temp1 = (dynamic)angka1;
        dynamic temp2 = (dynamic)angka2;
        dynamic temp3 = (dynamic)angka3;
        dynamic largest = temp1;

        if (temp2 > largest)
        {
            largest = temp2;
        }
        else
        {
            largest = temp3;
        }
        Console.WriteLine(largest);
    }

    class program
    {
        static void Main(string[] args)
        {
            PemrosesData data = new PemrosesData();
            double angka1 = 10;
            double angka2 = 30;
            double angka3 = 25;

            data.DapatkanNilaiTerbesar(angka1, angka2, angka3);
        }
    }
}
