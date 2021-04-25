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
            Console.Write("Podaj nazwê dnia tygodnia lub numer dnia tygodnia (1-7): ");
            // Odczyt odpowiedzi u¿ytkownika
            string odpowiedz = Console.ReadLine().ToLower();
            
            switch (odpowiedz)
            {
                case "1":
                case "poniedzia³ek":
                    Console.WriteLine("1. dzieñ tygodnia to Monday");
                    break;
                case "2":
                case "wtorek":
                    Console.WriteLine("2. dzieñ tygodnia to Tuesday");
                    break;
                case "3":
                case "œroda":
                    Console.WriteLine("3. dzieñ tygodnia to Wednesday");
                    break;
                case "4":
                case "czwartek":
                    Console.WriteLine("4. dzieñ tygodnia to Thrusday");
                    break;
                case "5":
                case "pi¹tek":
                    Console.WriteLine("5. dzieñ tygodnia to Friday");
                    break;
                case "6":
                case "sobota":
                    Console.WriteLine("6. dzieñ tygodnia to Saturday");
                    break;
                case "7":
                case "niedziela":
                    Console.WriteLine("7. dzieñ tygodnia to Sunday");
                    break;
                default:
                    Console.WriteLine("Podano nieprawid³owe dane!");
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