namespace tabliczkla;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true){
            CreateMenu();
        }
    }
    
    public static void CreateMenu(){
        Console.WriteLine("Wybierz funkcję");
        Console.WriteLine("UtworzTablice[1]");
        Console.WriteLine("WypelnijTablice[2]");    
        Console.WriteLine("Wyswietltablice[3]");
        Console.WriteLine("ObliczSume[4]");
        string input = Console.ReadLine();
        if (input == "1"){
            int[,] tab= CreateArray();
        }
        else if (input == "2"){
            //FillArray(tab);
        }
        else if (input == "3"){
            
        }
        else if (input == "4"){
            
        }
        

    }
    public static int LoadInt(){
        System.Console.WriteLine("Podaj liczbe lub q");
        string input = Console.ReadLine();
        if (input == "q"){
            Environment.Exit(0);
            return 0;   
        }
        else{
            int n = int.Parse(input);
            return n;
        }
    }
    public static int[,] CreateArray(){
        Console.WriteLine("Podaj rozmiar tablicy");
        int n = LoadInt();
        int[,] tab = new int[n,n];
        return tab;
    }

    public static void FillArray(int[,] array){
            for (int i = 0; i < array.Length; i++){
                for (int j = 0;j < array.Length; j++){
                    Random rnd = new Random();
                    array[i,j] = rnd.Next(0,10);
                }
            }
    }
}
