using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP12_Nd11_Metody
{
    class Program
    {
        static int fib(int n)
        {
            // Rekurencja
            if (n <= 2) return n;
            return fib(n - 1) + fib(n - 2);
        }

        static void Main(string[] args)
        {
            // cwiczenie1();

            /*
            Napisz program konsolowy, zawierający dwie metody 
            które jako parametry przyjmują tablicę intów. 
            Jedna metoda ma zwracać odwróconą tablice int[], natomiast druga
            metoda ma zwracać void i wypisywać na ekranie tę odwróconą tablicę.
            */
            int[] tablica = { 3, 5, -5, -3, 1, -7, 9, 20, -654, 60, 1};
            int[] tablica_odwrocona = OdwrocTablice1(tablica);
            
            WyswietlTablice(tablica);
            WyswietlTablice(tablica_odwrocona);
            WyswietlTablice(OdwrocTablice2(tablica));

            Console.ReadKey();
        }
        static int[] OdwrocTablice1(int[] tab)
        {
            // Utworzenie nowej pustej tablicy
            // o rozmiarze równym otrzymanej tablicy
            int[] tab2 = new int[tab.Length];
            // Przypisanie wartości tablicy 
            // (odczytanie wartości od końca)
            for (int i = 0; i < tab.Length; ++i)
            {
                tab2[i] = tab[tab.Length - 1 - i];
            }
            // Zwrócenie tablicy
            return tab2;
        }
        static int[] OdwrocTablice2(int[] tab)
        {
            // Kopiujemy tablicę
            int[] tab2 = tab;
            // Podmiana dwóch wartości jednocześnie
            for (int i = 0; i < tab2.Length / 2; ++i)
            {
                // Podmiana dwóch wartości wymaga użycia jeszcze jednej
                //  zmiennej pomocniczej
                int helper = tab2[i];
                tab2[i] = tab2[tab2.Length - 1 - i];
                tab2[tab2.Length - 1 - i] = helper;
            }
            // Zwrócenie tablicy
            return tab2;
        }
        static void WyswietlTablice2(int[] tab)
        {
            for (int i = 0; i < tab.Length; ++i)
            {
                if (i == tab.Length - 1)
                {
                    // Ostatni element
                    Console.Write("{0}", tab[i]);
                }
                else
                {
                    // Każdy element oprocz ostatniego
                    Console.Write("{0},\t", tab[i]);
                }
            }
            Console.Write("\n");
        }
        static void WyswietlTablice(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; ++i)
            {
                Console.Write("{0},\t", tab[i]);
            }
            Console.Write("{0}", tab[tab.Length - 1]);
            Console.Write("\n");
        }
        // // // // // // // // // // // // // // // // // // // // // // //
        static void cwiczenie1()
        {
            float liczba1 = 5.64f;
            float liczba2 = -3.24f;

            float wynik_dodawanie = dodawanie(liczba1, liczba2);
            float wynik_odejmowanie = odejmowanie(liczba1, liczba2);

            wypiszNaEkran(liczba1, "+", liczba2, wynik_dodawanie);
            wypiszNaEkran(liczba1, "-", liczba2, wynik_odejmowanie);

            wypiszNaEkran(liczba1, "*", liczba2, mnozenie(liczba1, liczba2));
            wypiszNaEkran(liczba1, "/", liczba2, dzielenie(liczba1, liczba2));
        }

        void foo2() { }
        // [Modyfikator] TypZwracany NazwaMetody ( [ListaArgumentow] )
        //{
        //  CiałoMetody
        //}
        /*
        Modyfikator:
            I rodzaj: modyfikator dostępu
                - public: metoda jest dostępna dla innych klas (jest publiczna)
                - private: metoda nie jest dostępna dla innych klas (jest prywatna)
                    Tylko ona sama ma dostęp do własnej metody
                    private jest domyślną opcją
            II rodzaj: modyfikator zachowania
                - static: metoda statyczna
        TypZwracany:
            - void - Nic nie jest zwracane
            - int - Metoda zawsze zwraca int
            - string -  ---||---         string
            - itd
        NazwaMetody:
            - Można używać cyfr, jednak nie wolno od niej zacząć
            - Można używać znak _
            - Nie wolno używać spacji
            - Nie używamy polskich znaków
        ListaArgumentow:
            - Kolejne argumenty oddzielamy przecinkami
            - Określamy typ każdego z argumentów
        Czym są argumenty metody:
            - Informacje potrzebne do wykonania pewnej czynności przez daną metodę
            - Patrząc z perspektywy metody (patrząc od środka), 
                traktujemy je jak zwykłe zmienna
        CiałoMetody:
            - Kod, który jest wykonywany, kiedy ta metoda zostanie wywołana
        Czym jest wywołanie metody?
            - Jest to wykonanie kodu z tej metody z dowolnego miejsca w naszym kodzie,
                za pomocą NazwaMetody([ListaArgumentów])
         */
        static void foo()
        {
            // CiałoMetody
            Console.WriteLine("Wywołano metodę foo()");
        }

        // Zadanie:
        // Napisanie metod dla:
        //  dodawania, odejmowania, mnożenia i dzielenia
        //  Dla liczb typu float

        static float dodawanie(float a, float b)
        {
            return a + b;
        }
        static float odejmowanie(float a, float b)
        {
            return a - b;
        }
        static float mnozenie(float a, float b)
        {
            return a * b;
        }
        static float dzielenie(float a, float b)
        {
            return a / b;
        }
        static void wypiszNaEkran(float a, string dzialanie, float b, float wynik)
        {
            //Console.WriteLine("a + b = wynik");
            if (b >= 0)
            {
                Console.WriteLine("{0} {1} {2} = {3}", a, dzialanie, b, wynik);
            }
            else
            {
                Console.WriteLine("{0} {1} ({2}) = {3}", a, dzialanie, b, wynik);
            }
        }
    }
}
