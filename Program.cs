﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class SimpleDataBase<T>
{
    private List<T> storedData = new List<T>();
    private List<DateTime> inputDates = new List<DateTime>();

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine(storedData[i].ToString() + inputDates[i].ToString());
        }
    }

    public class Program
    {
        static void Main()
        {
            SimpleDataBase<T> dataBase = new SimpleDataBase<T>();
            Console.WriteLine("Masukkan input 1: ");
            int d = Convert.ToInt32(Console.ReadLine());
            dataBase.AddNewData(d);
            Console.WriteLine("Masukkan input 2: ");
            int d2 = Convert.ToInt32(Console.ReadLine());
            dataBase.AddNewData(d2);
            Console.WriteLine("Masukkan input 1: ");
            int d3 = Convert.ToInt32(Console.ReadLine());
            dataBase.AddNewData(d3);
            dataBase.PrintAllData();

        }
    }
}