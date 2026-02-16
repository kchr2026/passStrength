//Somebody
using System;

public static class Program
{
    

static void Main(string[] args)
{
    passStrength pass = new passStrength();
    String password ="";
    //Sjekker om passordet er lang not eller inneholder symboler
    while (!pass.pLength(password.Length) || !pass.pSymbols(password))
    {
        Console.WriteLine("Write a strong password: ");
        password = Console.ReadLine();
        
    }
    Console.WriteLine("good password");
    }
}