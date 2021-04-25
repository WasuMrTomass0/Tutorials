using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_8_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            //// Wypisaæ u¿ytkownikowi o co go pytamy
            //Console.Write("Podaj numer dnia tygodnia (1-7): ");
            //// Wczytaæ dzieñ tyogdnia od u¿ytkownika
            //int numer_dnia = int.Parse(Console.ReadLine());
            //// Wyœwietlenie odpowiedzi
            //if (numer_dnia == 1)
            //{
            //    Console.WriteLine("1. dzieñ tygodnia to poniedzia³ek");
            //}
            //else if (numer_dnia == 2)
            //{
            //    Console.WriteLine("2. dzieñ tygodnia to wtorek");
            //}
            ////
            ////
            ////
            //else if (numer_dnia == 7)
            //{
            //    Console.WriteLine("7. dzieñ tygodnia to niedziela");
            //}
            //else
            //{
            //    Console.WriteLine("Wprowadzono niepoprawny numer dnia!");
            //}

            //// Odczytanie znaku, aby konsola siê nie zamknê³a
            //Console.ReadKey();

            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            //// Wypisaæ u¿ytkownikowi o co go pytamy
            //Console.Write("Podaj numer dnia tygodnia (1-7): ");
            //// Wczytaæ dzieñ tyogdnia od u¿ytkownika
            //int numer_dnia = int.Parse(Console.ReadLine());
            //// Wyœwietlenie odpowiedzi

            //switch (numer_dnia)
            //{
            //    case 1:
            //        Console.WriteLine("1. dzieñ tygodnia to poniedzia³ek");
            //        break;  // Przerwij wykonywanie kolejnych case'ów
            //    case 2:
            //        Console.WriteLine("2. dzieñ tygodnia to wtorek");
            //        break;
            //    //
            //    //
            //    //
            //    case 7:
            //        Console.WriteLine("7. dzieñ tygodnia to niedziela");
            //        break;
            //    default:
            //        Console.WriteLine("Wprowadzono niepoprawny numer dnia tygodnia.");
            //        break;
            //}

            //// Odczytanie znaku, aby konsola siê nie zamknê³a
            //Console.ReadKey();

            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            // Wypisaæ u¿ytkownikowi o co go pytamy
            Console.Write("Podaj numer dnia tygodnia (1-7): ");
            // Wczytaæ dzieñ tyogdnia od u¿ytkownika
            int numer_dnia = int.Parse(Console.ReadLine());
            // Wyœwietlenie odpowiedzi

            switch (numer_dnia)
            {
                case 1:
                    Console.WriteLine("1. dzieñ tygodnia to poniedzia³ek");
                    break;  // Przerwij wykonywanie kolejnych case'ów
                case 2:
                    Console.WriteLine("2. dzieñ tygodnia to wtorek");
                    break;
                //
                //
                //
                case 7:
                    Console.WriteLine("7. dzieñ tygodnia to niedziela");
                    break;
                default:
                    Console.WriteLine("Wprowadzono niepoprawny numer dnia tygodnia.");
                    break;
            }

            // Odczytanie znaku, aby konsola siê nie zamknê³a
            Console.ReadKey();

        }
    }
}

/*   ZADANIE ROZGRZEWKOWE 
 * 
Napisz program konsolowy, który po wczytaniu wpisanego przez u¿ytkownika
numeru dnia tygodnia (1-7) wyœwietli nazwê tego dnia (np. 
"3 dzieñ tygodnia to œroda."
). Zak³adamy, ¿e pierwszym dniem tygodnia jest poniedzia³ek. Wykorzystaj
instrukcjê if.. else if.
 * 
 */