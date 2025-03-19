using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase() //membuat list
    {
        storedData = new List<T>(); 
        inputDates = new List<DateTime>();  
    }
    public void AddNewData(T data) //menginput data
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now); //memprint tanggal
    }
    public void printAllData() //memprint data
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan waktu UTC: {inputDates[i]} AM");
        }
    }
}


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
             SimpleDataBase<string> nim = new SimpleDataBase<string> ();
         nim.AddNewData("10"); //data yang diinput
        nim.AddNewData("30");
        nim.AddNewData("25");

        nim.printAllData(); //memprint data
        }
    }

