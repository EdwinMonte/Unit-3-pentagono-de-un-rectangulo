using System;
using Geometria;

class Program
{
    static void Main(string[] args)
    {
        Pentagono pentagono1 = new Pentagono(5);
        pentagono1.MostrarDatos(); 

        Pentagono pentagono2 = new Pentagono(3, 10);
        pentagono2.MostrarDatos(); 

        Console.ReadKey(); 
    }
}


