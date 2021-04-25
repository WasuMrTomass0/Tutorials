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
            //// Wypisa� u�ytkownikowi o co go pytamy
            //Console.Write("Podaj numer dnia tygodnia (1-7): ");
            //// Wczyta� dzie� tyogdnia od u�ytkownika
            //int numer_dnia = int.Parse(Console.ReadLine());
            //// Wy�wietlenie odpowiedzi
            //if (numer_dnia == 1)
            //{
            //    Console.WriteLine("1. dzie� tygodnia to poniedzia�ek");
            //}
            //else if (numer_dnia == 2)
            //{
            //    Console.WriteLine("2. dzie� tygodnia to wtorek");
            //}
            ////
            ////
            ////
            //else if (numer_dnia == 7)
            //{
            //    Console.WriteLine("7. dzie� tygodnia to niedziela");
            //}
            //else
            //{
            //    Console.WriteLine("Wprowadzono niepoprawny numer dnia!");
            //}

            //// Odczytanie znaku, aby konsola si� nie zamkn�a
            //Console.ReadKey();

            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            //// Wypisa� u�ytkownikowi o co go pytamy
            //Console.Write("Podaj numer dnia tygodnia (1-7): ");
            //// Wczyta� dzie� tyogdnia od u�ytkownika
            //int numer_dnia = int.Parse(Console.ReadLine());
            //// Wy�wietlenie odpowiedzi

            //switch (numer_dnia)
            //{
            //    case 1:
            //        Console.WriteLine("1. dzie� tygodnia to poniedzia�ek");
            //        break;  // Przerwij wykonywanie kolejnych case'�w
            //    case 2:
            //        Console.WriteLine("2. dzie� tygodnia to wtorek");
            //        break;
            //    //
            //    //
            //    //
            //    case 7:
            //        Console.WriteLine("7. dzie� tygodnia to niedziela");
            //        break;
            //    default:
            //        Console.WriteLine("Wprowadzono niepoprawny numer dnia tygodnia.");
            //        break;
            //}

            //// Odczytanie znaku, aby konsola si� nie zamkn�a
            //Console.ReadKey();

            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            // Wypisa� u�ytkownikowi o co go pytamy
            Console.Write("Podaj nazw� dnia tygodnia lub numer dnia tygodnia (1-7): ");
            // Odczyt odpowiedzi u�ytkownika
            string odpowiedz = Console.ReadLine().ToLower();
            
            switch (odpowiedz)
            {
                case "1":
                case "poniedzia�ek":
                    Console.WriteLine("1. dzie� tygodnia to Monday");
                    break;
                case "2":
                case "wtorek":
                    Console.WriteLine("2. dzie� tygodnia to Tuesday");
                    break;
                case "3":
                case "�roda":
                    Console.WriteLine("3. dzie� tygodnia to Wednesday");
                    break;
                case "4":
                case "czwartek":
                    Console.WriteLine("4. dzie� tygodnia to Thrusday");
                    break;
                case "5":
                case "pi�tek":
                    Console.WriteLine("5. dzie� tygodnia to Friday");
                    break;
                case "6":
                case "sobota":
                    Console.WriteLine("6. dzie� tygodnia to Saturday");
                    break;
                case "7":
                case "niedziela":
                    Console.WriteLine("7. dzie� tygodnia to Sunday");
                    break;
                default:
                    Console.WriteLine("Podano nieprawid�owe dane!");
                    break;
            }

            

            // Odczytanie znaku, aby konsola si� nie zamkn�a
            Console.ReadKey();

        }
    }
}

/*   ZADANIE ROZGRZEWKOWE 
 * 
Napisz program konsolowy, kt�ry po wczytaniu wpisanego przez u�ytkownika
numeru dnia tygodnia (1-7) wy�wietli nazw� tego dnia (np. 
"3 dzie� tygodnia to �roda."
). Zak�adamy, �e pierwszym dniem tygodnia jest poniedzia�ek. Wykorzystaj
instrukcj� if.. else if.
 * 
 */