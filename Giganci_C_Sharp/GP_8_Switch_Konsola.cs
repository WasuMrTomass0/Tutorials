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

            //// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            //// Wypisaæ u¿ytkownikowi o co go pytamy
            //Console.Write("Podaj nazwê dnia tygodnia lub numer dnia tygodnia (1-7): ");
            //// Odczyt odpowiedzi u¿ytkownika
            //string odpowiedz = Console.ReadLine().ToLower();

            //switch (odpowiedz)
            //{
            //    case "1":
            //    case "poniedzia³ek":
            //        Console.WriteLine("1. dzieñ tygodnia to Monday");
            //        break;
            //    case "2":
            //    case "wtorek":
            //        Console.WriteLine("2. dzieñ tygodnia to Tuesday");
            //        break;
            //    case "3":
            //    case "œroda":
            //        Console.WriteLine("3. dzieñ tygodnia to Wednesday");
            //        break;
            //    case "4":
            //    case "czwartek":
            //        Console.WriteLine("4. dzieñ tygodnia to Thrusday");
            //        break;
            //    case "5":
            //    case "pi¹tek":
            //        Console.WriteLine("5. dzieñ tygodnia to Friday");
            //        break;
            //    case "6":
            //    case "sobota":
            //        Console.WriteLine("6. dzieñ tygodnia to Saturday");
            //        break;
            //    case "7":
            //    case "niedziela":
            //        Console.WriteLine("7. dzieñ tygodnia to Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Podano nieprawid³owe dane!");
            //        break;
            //}
            //// Odczytanie znaku, aby konsola siê nie zamknê³a
            //Console.ReadKey();


            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            // miniMenu: 
            //          pomidor, oliwki, cebula
            // 

            // Zmienne programu
            decimal cenaPizzy = 20m;  // Podstawowa cena pizzy
            bool czyZakonczonoZamowienie = false;  // Zmienna okreslaj¹ca, czy zakonczono zamawianie dodatkow do pizzy
            string odp;  // Utworzenie zmiennej typu string, do której wpiszemy odpowiedz uzytkownika
            string zamowienie = "";  // Do tej zmiennej wpiszemy wszystkie zamówione pozycje

            // Wypisanie o co pytamy u¿ytkownika
            Console.Write("Proszê o wskazanie dodatku do pizzy:\npomidor, cebula, oliwki\nNapisz 'napój', aby przejœæ do zamawiania napoi\n");

            // Powtarzaj pytanie o dodatki, jesli nie zakonczono tego etapu
            while (!czyZakonczonoZamowienie)
            {
                // Odczytanie odpowiedzi u¿ytkownika i zmiana du¿ych liter na ma³e
                odp = Console.ReadLine().ToLower();

                switch (odp)
                {
                    case "pomidor":
                        Console.Write("Czy coœ do tego?\n");
                        cenaPizzy += 2.5m;  // Zwiêkszenie ceny o 2.50
                        zamowienie += "pomidor\n";  // Dopisanie do zamówienia pomidora
                        break;
                    case "cebula":
                        Console.Write("Czy coœ do tego?\n");
                        cenaPizzy += 0.5m;  // Zwiêkszenie ceny o 0.50
                        zamowienie += "cebula\n";  // Dopisanie do zamówienia cebuli
                        break;
                    case "oliwki":
                        Console.Write("Czy coœ do tego?\n");
                        cenaPizzy += 4.5m;  // Zwiêkszenie ceny o 4.50
                        zamowienie += "oliwki\n";  // Dopisanie do zamówienia oliwek
                        break;
                    case "napój":
                    case "napoje":
                        czyZakonczonoZamowienie = true;
                        break;
                    default:
                        Console.Write("Nie zrozumia³em. Proszê o wskazanie dodatku do pizzy:\npomidor, cebula, oliwki\n");
                        break;
                }
            }

            Console.Write("\nJaki napój do tego?\nMamy Cola, Pepsi, Sok, Woda\n");
            czyZakonczonoZamowienie = false; // Nowe zamowienie
            while (!czyZakonczonoZamowienie)
            {
                // Odczytanie odpowiedzi u¿ytkownika i zmiana du¿ych liter na ma³e
                odp = Console.ReadLine().ToLower();
                switch (odp)
                {
                    case "cola":
                        Console.Write("Czy coœ do tego?\n");
                        cenaPizzy += 5.5m;
                        zamowienie += "cola\n";
                        break;
                    case "pepsi":
                        Console.Write("Czy coœ do tego?\n");
                        cenaPizzy += 5.25m;
                        zamowienie += "pepsi\n";
                        break;
                    case "sok":
                        Console.Write("Czy coœ do tego?\n");
                        cenaPizzy += 2.5m;
                        zamowienie += "sok\n";
                        break;
                    case "woda":
                        Console.Write("Czy coœ do tego?\n");
                        cenaPizzy += 1.5m;
                        zamowienie += "woda\n";
                        break;
                    case "to tyle":
                    case "koniec":
                    case "dziêkujê":
                        czyZakonczonoZamowienie = true;
                        break;
                    default:
                        Console.Write("\nPrzepraszam, nie zrozumia³em.\nJaki napój do tego?\nMamy Cola, Pepsi, Sok, Woda\n");
                        break;
                }
            }

            // Wypisanie ³¹cznej ceny pizzy oraz ca³ego zamówienia
            Console.Write("\n\nKoszt pizzy to {0}. Zamówienie:\n{1}", cenaPizzy, zamowienie);
                       


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