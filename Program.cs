using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

class program
{
    static void Main(string[] args)
    {
        SimpleDataBase<string> nim = new SimpleDataBase<string> ();
        nim.AddNewData("10"); //data yang diinput
        nim.AddNewData("30");
        nim.AddNewData("25");

        nim.printAllData(); //memprint data
    }
}