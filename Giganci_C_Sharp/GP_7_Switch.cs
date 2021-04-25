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

            //// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            //// Wypisa� u�ytkownikowi o co go pytamy
            //Console.Write("Podaj nazw� dnia tygodnia lub numer dnia tygodnia (1-7): ");
            //// Odczyt odpowiedzi u�ytkownika
            //string odpowiedz = Console.ReadLine().ToLower();

            //switch (odpowiedz)
            //{
            //    case "1":
            //    case "poniedzia�ek":
            //        Console.WriteLine("1. dzie� tygodnia to Monday");
            //        break;
            //    case "2":
            //    case "wtorek":
            //        Console.WriteLine("2. dzie� tygodnia to Tuesday");
            //        break;
            //    case "3":
            //    case "�roda":
            //        Console.WriteLine("3. dzie� tygodnia to Wednesday");
            //        break;
            //    case "4":
            //    case "czwartek":
            //        Console.WriteLine("4. dzie� tygodnia to Thrusday");
            //        break;
            //    case "5":
            //    case "pi�tek":
            //        Console.WriteLine("5. dzie� tygodnia to Friday");
            //        break;
            //    case "6":
            //    case "sobota":
            //        Console.WriteLine("6. dzie� tygodnia to Saturday");
            //        break;
            //    case "7":
            //    case "niedziela":
            //        Console.WriteLine("7. dzie� tygodnia to Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Podano nieprawid�owe dane!");
            //        break;
            //}
            //// Odczytanie znaku, aby konsola si� nie zamkn�a
            //Console.ReadKey();


            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            // miniMenu: 
            //          pomidor, oliwki, cebula
            // 

            // Zmienne programu
            decimal cenaPizzy = 20m;  // Podstawowa cena pizzy
            bool czyZakonczonoZamowienie = false;  // Zmienna okreslaj�ca, czy zakonczono zamawianie dodatkow do pizzy
            string odp;  // Utworzenie zmiennej typu string, do kt�rej wpiszemy odpowiedz uzytkownika
            string zamowienie = "";  // Do tej zmiennej wpiszemy wszystkie zam�wione pozycje

            // Wypisanie o co pytamy u�ytkownika
            Console.Write("Prosz� o wskazanie dodatku do pizzy:\npomidor, cebula, oliwki\nNapisz 'nap�j', aby przej�� do zamawiania napoi\n");

            // Powtarzaj pytanie o dodatki, jesli nie zakonczono tego etapu
            while (!czyZakonczonoZamowienie)
            {
                // Odczytanie odpowiedzi u�ytkownika i zmiana du�ych liter na ma�e
                odp = Console.ReadLine().ToLower();

                switch (odp)
                {
                    case "pomidor":
                        Console.Write("Czy co� do tego?\n");
                        cenaPizzy += 2.5m;  // Zwi�kszenie ceny o 2.50
                        zamowienie += "pomidor\n";  // Dopisanie do zam�wienia pomidora
                        break;
                    case "cebula":
                        Console.Write("Czy co� do tego?\n");
                        cenaPizzy += 0.5m;  // Zwi�kszenie ceny o 0.50
                        zamowienie += "cebula\n";  // Dopisanie do zam�wienia cebuli
                        break;
                    case "oliwki":
                        Console.Write("Czy co� do tego?\n");
                        cenaPizzy += 4.5m;  // Zwi�kszenie ceny o 4.50
                        zamowienie += "oliwki\n";  // Dopisanie do zam�wienia oliwek
                        break;
                    case "nap�j":
                    case "napoje":
                        czyZakonczonoZamowienie = true;
                        break;
                    default:
                        Console.Write("Nie zrozumia�em. Prosz� o wskazanie dodatku do pizzy:\npomidor, cebula, oliwki\n");
                        break;
                }
            }

            Console.Write("\nJaki nap�j do tego?\nMamy Cola, Pepsi, Sok, Woda\n");
            czyZakonczonoZamowienie = false; // Nowe zamowienie
            while (!czyZakonczonoZamowienie)
            {
                // Odczytanie odpowiedzi u�ytkownika i zmiana du�ych liter na ma�e
                odp = Console.ReadLine().ToLower();
                switch (odp)
                {
                    case "cola":
                        Console.Write("Czy co� do tego?\n");
                        cenaPizzy += 5.5m;
                        zamowienie += "cola\n";
                        break;
                    case "pepsi":
                        Console.Write("Czy co� do tego?\n");
                        cenaPizzy += 5.25m;
                        zamowienie += "pepsi\n";
                        break;
                    case "sok":
                        Console.Write("Czy co� do tego?\n");
                        cenaPizzy += 2.5m;
                        zamowienie += "sok\n";
                        break;
                    case "woda":
                        Console.Write("Czy co� do tego?\n");
                        cenaPizzy += 1.5m;
                        zamowienie += "woda\n";
                        break;
                    case "to tyle":
                    case "koniec":
                    case "dzi�kuj�":
                        czyZakonczonoZamowienie = true;
                        break;
                    default:
                        Console.Write("\nPrzepraszam, nie zrozumia�em.\nJaki nap�j do tego?\nMamy Cola, Pepsi, Sok, Woda\n");
                        break;
                }
            }

            // Wypisanie ��cznej ceny pizzy oraz ca�ego zam�wienia
            Console.Write("\n\nKoszt pizzy to {0}. Zam�wienie:\n{1}", cenaPizzy, zamowienie);
                       


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