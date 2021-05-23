using System;

namespace GP11_Nd11_Tablice
{
    class Program
    {
        static void wprowadzenie()
        {
            ///* 
            ////Jakie pętle poznaliśmy?
            //    - for
            //    - while
            //    - do...while
            //// Różnica między while a do...while?
            //while - najpierw sprawdzamy warunek, dopiero potem (ewentualnie)
            //    wykonujemy kod z ciala pętli

            //do...while - pierwszy raz na pewno wykonujemy kod z ciała pętli,
            //    a później w zależności od warunku możliwe jest ponowne wykonanie kodu

            //// Jakie wynik warunku pętli oznacza ponowne wykoannie kodu?
            //True - ponowne wykonanie kodu
            //False - pominięcie ciałą pętli

            //// Co robi instrukcja "continue"?
            //Oznacza to pominięcie pozostałej części kodu w ciele pętli 
            //    oraz przejście do sprawdzenia warunku i ewentualne kolejne uruchomienie 
            //    (w zależności od warunku pętli)

            //// Co robi instrukcja "break"?
            //Natychmiastowe wyjście z pętli - przejście za pętlę do dalszej części programu
            //*/

            ///*
            // * Tablice - "schowek" na wiele elementó tego samego typu
            // * 
            // */
            int uczestnik_1 = 10;
            int uczestnik_2 = 18;
            int uczestnik_3 = 28;
            int uczestnik_4 = 54;
            int uczestnik_5 = 47;
            double srednia_wieku =
                (uczestnik_1 + uczestnik_2 + uczestnik_3 + uczestnik_4 + uczestnik_5) / 5.0;
            //5     int
            //5.0   double
            //5.0f  float
            Console.WriteLine(srednia_wieku);  // 31,4

            // Obliczenie sredniej wieku uczestnikow przy wykorzystaniu tablicy
            int[] uczestnicy = { 10, 18, 28, 54, 47, 25, 24, 13, 50 };

            //Console.WriteLine(uczestnicy[0]); // Element o indeksie 0 -> 10 
            //Console.WriteLine(uczestnicy[1]); // Element o indeksie 1 -> 18
            //Console.WriteLine(uczestnicy[2]); // Element o indeksie 2 -> 28
            //Console.WriteLine(uczestnicy[3]); // Element o indeksie 3 -> 54
            //Console.WriteLine(uczestnicy[4]); // Element o indeksie 4 -> 47
            //Console.WriteLine(uczestnicy);  // System.Int32[]

            // Wykorzystanie pętli oraz tablic
            double suma = 0.0;
            double wynik = 0.0;
            for (int i = 0; i < uczestnicy.Length; ++i)
            {  // uczestnicy.Length - liczba elementów w tablicy
                suma += uczestnicy[i];
            }
            // Po wykonaniu pętli w zmiennej suma znajduje się suma elementów tablicy
            wynik = suma / uczestnicy.Length;
            Console.WriteLine(wynik);

            const int ROZMIAR = 5;

            // Sposob 1 - Utworzenie pustej tablicy o wskazanym rozmiarze 
            //          (i wybranym typie przechowywanych zmiennych)
            int[] uczestnicy_1 = new int[ROZMIAR];

            // Sposob 2 - Utworzenie zmiennej tablicowej, a dopiero w pozniejszym etapie
            //          programu wskazanie ile miejsc powinno zostac utworzonych
            int[] uczestnicy_2;
            // Jakiś kod
            uczestnicy_2 = new int[ROZMIAR];

            // Sposob 3 - Utworzenie tablicy oraz autoatyczne wypełnienie jej wartościami
            //          liczba elementów zależy od LISTY INICJALIZACYJNEJ
            int[] uczestnicy_3 = new int[] { 1, 50, -45, 21 };

            // Sposob 4 - Skrócony zapis sposobu nr 3
            int[] uczestnicy_4 = { 1, 50, -45, 21 };

            //Indeks elementu liczony jest od ZERA
            //      Pierwszy element posiada indeks 0
            //      Drugi element posiada indeks 1
            //      itd

            // Liczba elementów w tablicy:
            //      nazwa_tablicy.Length

            // Wykorzystanie pętli pozwala w łatwy sposób wykonać pewien kod
            //      dla każdego elementu tej tablicy

            // Wpisywanie zawartosci zmiennych do tablicy
            int bok_1 = 231;
            int bok_2 = 321;
            int pole = bok_1 * bok_2;
            int obwod = 2 * bok_1 + 2 * bok_2;

            int[] liczby = { bok_1, bok_2, pole, obwod };
            int[] liczby_2 = { bok_1, bok_2, bok_1 * bok_2, 2 * bok_1 + 2 * bok_2 };
        }

        static void cwiczenie_1()
        {
            // Ćwiczenie 1
            // Stwórz tablicę 7 - elementową, zawierającą imiona.
            // a następnie wypisz je na ekranie
            string[] imiona = { 
            //      INDEKSY ELEMENTÓW TABLICY
            //     0        1       2       3       4           5           6
                "Tomek", "Paweł", "Ola", "Kasia", "Gaweł", "Aleksander", "Julia"
            };
            // Wyświetlenie każdego imienia w osobnej lini
            // Console.WriteLine(); // Wyświetlenie CZEGOŚ w konsoli
            // imiona[index]        // Odwołanie do konkretnego elementu tablicy

            for (int i = 0; i < imiona.Length; ++i)
            {
                Console.WriteLine(imiona[i]);
            }
            // p=0; 0 < 7 -> PRAWDA; wyświetl imiona[0] - Tomek -> ++p
            // p=1; 1 < 7 -> PRAWDA; wyświetl imiona[1] - Paweł -> ++p
            // ...
            // p=6; 6 < 7 -> PRAWDA; wyświetl imiona[6] - Julia -> ++p
            // p=7; 7 < 7 -> FAŁSZ -> Wyjście z pętli

            // Wyświetlenie imion w odwrotnej kolejności - od końca
            // Sposób nr 1
            for (int i = imiona.Length - 1; i >= 0; --i)
            {
                Console.WriteLine(imiona[i]);
            }
            // Sposób nr 2
            for (int i = 0; i < imiona.Length; ++i)
            {
                Console.WriteLine(imiona[imiona.Length - 1 - i]);
            }
            // i = 0; imiona.Length-1-i = 7-1-0 = 6
            // i = 1; imiona.Length-1-i = 7-1-1 = 5
            // i = 2; imiona.Length-1-i = 7-1-2 = 4
            // ...
            // i = 6; imiona.Length-1-i = 7-1-6 = 0
        }

        static void cwiczenie_2()
        {
            int[] liczby = { -15, -60, -3, -10, -4, 54, 4, 13, 140, 54, 04, 9, 0, 12, 234, 56 };
            // Ćwiczenie 2
            // Napisać program, który znajdzie największy element tej tablicy, 
            //      a na koniec go wyświetli

            // Przypisujemy do najwiekszej wartosci pierwszy element z tablicy
            int max_wartosc = liczby[0];    // Zmienna przechowujaca najwieksza wartosc
            int min_wartosc = liczby[0];    // Zmienna przechowujaca najmniejsza wartosc

            for (int i = 0; i < liczby.Length; ++i)
            {
                // Porównaj "max_wartosc" z elementem z tablicy "liczby[i]"
                // jeżeli element z tablicy jest wiekszy, niz "max_wartosc"
                // do zmiennej "max_wartosc" wpisz element z tablicy "liczby[i]"
                if (max_wartosc < liczby[i])
                {
                    max_wartosc = liczby[i];
                }
                if (min_wartosc > liczby[i])
                {
                    min_wartosc = liczby[i];
                }
            }
            Console.WriteLine("Największa wartość to: {0}", max_wartosc);
            Console.WriteLine("Najmiejsza wartość to: {0}", min_wartosc);
        }

        static void Main(string[] args)
        {
            // Cwiczenie 3
            /*
            Napisać program konsolowy, który symuluje system sprzedaży biletów do kina.
            Należy stworzyć repertuar, pobrać od klienta dane osobowe 
            (wybrany film, imię, nazwisko, telefon, mail oraz liczbę biletów) 
            a następnie wyświetlić podsumowanie zamówienia.
             */
            // Stałe indeksy
            const int indeks_film = 0;
            const int indeks_imie = 1;
            const int indeks_nazwisko = 2;
            const int indeks_telefon = 3;
            const int indeks_mail = 4;
            const int indeks_liczba_biletow = 5;
            // Tworzymy tablicę typu string dla 6 elementów
            string[] info = new string[6];
            // Dostępne filmy
            string[] filmy = { "Władca Pierścieni", "Matrix" };

            //// Przykładowe użycie stałych
            //info[indeks_film] = "QWERTY historia";
            //info[indeks_imie] = "Tomasz";
            //info[indeks_nazwisko] = "Molęda";
            //info[indeks_telefon] = "505-404-303";
            //info[indeks_mail] = "tmoleda@g.com";
            //info[indeks_liczba_biletow] = "3";
            // // // // // // // // // // // // // // // // // // // // // // // // 
            // Zapytanie o film
            int indeks_wskazany_przez_uzytkownika;
            // // Wyświetlenie informacji o dostępnych filmach
            // // Numer X: Nazwa_Filmu

            // // Numer 0: Władca Pierścieni
            // // Numer 1: Matrix


            // // Odczytanie odpowiedzi od uzytkownika 
            // //- wprowadzenie danych przez uzytkownika
            // // Pamiętamy o konwersji do inta (z string) 
            // // oraz o sprawdzeniu, czy wprowadzono poprawny numer
            // // Polecam uzyc do...while
            do
            {

            } while (); // Powtarzaj tak dlugo, jak wprowadzony indeks jest NIEPOPRAWNY
            info[indeks_film] = filmy[indeks_wskazany_przez_uzytkownika];


            // Zapytanie o imię
            // // Popros o wprowadzenie imienia
            Console.WriteLine("Wprowadź swoje imię: ");
            // // Zapisz informacje w info
            info[indeks_imie] = Console.ReadLine();

            // Zapytanie o nazwisko

            // Zapytanie o telefon

            // Zapytanie o mail

            // Zapytanie o liczbę biletów

            Console.ReadKey();
        }
    }
}
