using PrimerExamenProgra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamenProgra { }
 static class Menu 
{
    static Menu() { }

    public static void Principal()

        
    {
        Console.WriteLine("Elija la opcion que desee:\n" +

               "\n1.Vehiculos. " +
               "\n2.Ventas. " +
               "\n3.Reportes. " +
               "\n4.Salir. ");

        string s1 = null;

        s1 = Console.ReadLine();

        switch (s1)
        {
            case "1":
                Console.WriteLine("Estos son los vehiculos disponibles:");
            break;

            case "2":
                Console.WriteLine("Estas son las ventas:");
                break;

            case "3":
                Console.WriteLine("Estos son los reportes:");
                break;

            case "4":
                Console.WriteLine("Hasta luego!");
                break;
           }


        Console.ReadKey();
    }
    

    
}


