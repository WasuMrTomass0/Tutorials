using System;

namespace GP_10_Petle_cz2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //// Pętla for
            //for(int i = 0; i < 10; ++i)  // Wykonanie pętli TYLKO jeżeli warunek jest prawdziwy
            //{
            //    // Ciało pętli - wykonywany kod
            //}

            //// Pętle while
            //// W pętli while warunek jest sprawdzany jako pierwszy, a dopiero potem
            //// Wykonywany jest kod z ciała pętli
            //int a = 0;
            //while(a < 10)  // Wykonanie pętli TYLKO jeżeli warunek jest prawdziwy
            //{   
            //    // Ciało pętli
            //    a += 5;
            //}

            // Pętle do..while
            // W pętli do..while najpierw wykonujemy kod, a dopiero później sprawdzamy warunek
            // czy należy wykonać go jeszcze raz
            //a = 0;
            //do
            //{
            //    a += 5;
            //} while (a < 10);

            ///*
            // *  Napisać program konsolowy z wykorzystaniem pętli while, w którym będziemy
            // *   emitować dźwięk (Console.Beep()) przez 700 milisekund o częstotliwości od 500 do
            // *   15000 Hz, co 500 Hz.
            // *   500, 1000, 1500, 2000, ..., 14500, 15000
            // */

            //int czestotliwosc = 500;
            //while(czestotliwosc <= 15000)
            //{
            //    Console.Beep(czestotliwosc, 700);
            //    czestotliwosc += 500;
            //}

            //for(int freq = 500; freq <= 15000; freq += 500)
            //{
            //    Console.Beep(freq, 700);
            //}

            //int freq2 = 500;
            //do
            //{
            //    Console.Beep(czestotliwosc, 700);
            //    freq2 += 500;
            //} while (freq2 <= 15000);

            // // // // // // // // // // 
            /* Dwaj koledzy Janek i Karol zadłużyli się na 80 zł.Umówili się między sobą, że każdy
            z nich codziennie będzie odkładał na spłatę zadłużenia 20 % swojego dziennego
            zarobku, Janek zarabia dziennie 50 zł, a Karol 40 zł.Napisz program, który przy
            pomocy pętli do ..while sprawdzi po ilu dniach obaj koledzy uzbierają kwotę potrzebną
            do spłaty swojego długu. */

            const float dlug = 8000f;
            const float zarobekJanek = 500f;
            const float zarobekKarol = 400f;
            const float czescOdkladaniaPieniedzy = 0.2f;

            float odlozonePieniadze = 0f;

            int liczbaDni = 0;
            do
            {
                liczbaDni += 1;
                odlozonePieniadze +=
                    czescOdkladaniaPieniedzy * zarobekJanek + czescOdkladaniaPieniedzy * zarobekKarol;
                // Console.WriteLine("dzien: {0}. odlozono: {1} zl", liczbaDni, odlozonePieniadze);
            } while (odlozonePieniadze < dlug);

            Console.WriteLine("Dlug splacony po {0} dniach", liczbaDni);
            Console.ReadKey();

        }
    }
}
