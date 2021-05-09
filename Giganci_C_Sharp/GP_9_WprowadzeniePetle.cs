using System;

namespace GP_9_WprowadzenieDoPetli
{
    class Program
    {
        static void Main(string[] args)
        {

            // Pętle:
            // FOR
            // WHILE
            // DO...WHILE
            //  inicjalizacja ; warunek logiczny ; zmiana licznika
            //for (int a = 0    ; a < 5           ; ++a)
            //{
            //    // Ciało pętli, czyli kod, który się powtarza
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine("Koniec");

            /*
             * Napisać program w konsoli, który będzie wyświetlać 
             * wszystkie kolejne liczby podzielne przez 17 od 1 do 5000.
             */
            // Liczby, które musimy sprawdzić:
            // Sprawdzimy KAŻDĄ liczbę od 1 do 5000
            //for(int i = 1; i <= 5000; ++i)
            //{
            //    if (i % 17 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Szybszy sposób na zrealizowanie programu
            //for (int i = 17; i <= 5000; i+=17)
            //{
            //    Console.WriteLine(i);
            //}

            // Ćw2
            //double maxWykladnik = 7;
            //double podstawa = 21;
            //// podstawa do 0 = 1
            //// podstawa do 1 = 2
            //// ...
            //// podstawa do maxWykladnik = wynik

            //// Przypomnienie
            //// podstawa do wykładnika - tak nazywamy liczby w potęgowaniu

            //// Chcemy wyswietlic rozwiazanie dla maxWykladnik, dlatego stosujemy
            //// porównanie <= (mniejsze lub rowne)
            //for (double wykladnik = 0; wykladnik <= maxWykladnik; ++wykladnik)
            //{
            //    // Obliczenie wyniku potęgowania
            //    double wynik = Math.Pow(podstawa, wykladnik);
            //    // Wypisanie w konsoli komunikatu
            //    // 2 do wykladnik = wynik
            //    Console.WriteLine("{0} do {1} = {2}", podstawa, wykladnik, wynik);
            //}


            // Ćw 3 - Tabliczka mnożenia
            // Zagnieżdżone pętle
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    //Console.Write();        // Piszemy tam gdzie był 'kursor'
                    //Console.WriteLine();    // Najpierw dodajemy enter dopiero piszemy

                    // '\n' przejście do nowej lini
                    // '\t' tabulator

                    Console.Write("{0}\t", i * j);
                }
                Console.Write("\n");
            }

            // PD 
            // Uzupełnić deklaracje pętli w taki sposób, aby wynik 9*9 pokazywał się w lewym górnym rogu
            for (/* */)
            {
                for (/* */)
                {
                    //Console.Write();        // Piszemy tam gdzie był 'kursor'
                    //Console.WriteLine();    // Najpierw dodajemy enter dopiero piszemy

                    // '\n' przejście do nowej lini
                    // '\t' tabulator

                    Console.Write("{0}\t", i * j);
                }
                Console.Write("\n");
            }
        }
    }
}
