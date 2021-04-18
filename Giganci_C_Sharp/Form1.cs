using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_6_Instrukcja_if
{
    public partial class Form1 : Form
    {
        // Stworzenie zmiennych, które bêd¹ dostêpne dla wielu funkcji
        int a, b;       // Liczby, które bêdziemy dodawaæ
        int odp_poprawne = 0, odp_bledne = 0; // Liczniki odpowiedzi poprawnych i blednych
        const int min_val = 0, max_val = 100; // Sta³e okreœlaj¹ce zakres losowanych liczb
        Random random;  // Generator liczb losowych
        // Zmienne dla pdgadywania liczby z zakresu
        int wylosowana_liczba, wykonanych_prob = 0;
        const int min_losowana = 0, max_losowana = 100;  // Zakres losowanych liczb
        const int limit_prob = 10;  // Limit dostepnych prob

        public Form1()
        {
            // Kod wykonywany podczas uruchomienia aplikacji
            InitializeComponent();

            // Utworzenie nowego obiektu klasy random
            random = new Random();

            // Pierwsze losowanie liczb
            a = random.Next(min_val, max_val);
            b = random.Next(min_val, max_val);

            // Pierwsze wpisanie tekstu do lbl_Napis
            lbl_Napis.Text = $"{a} + {b} = ";
            // Pierwsze wpisanie tekstu do lbl_Bledne i lbl_Poprawne. Zawsze s¹ to zera
            lbl_Bledne.Text = odp_bledne.ToString();
            lbl_Poprawne.Text = odp_poprawne.ToString();
            // // // // // // // // // // // // // // // // // // // // // 
            // Odgadywanie liczby

            // Wylosowanie liczby, ktora mamy odgadnac
            wylosowana_liczba = random.Next(min_losowana, max_losowana);

            // Ustawienie napisów
            //                     Wstawienie zmiennych do tekstu
            lbl_ZakresLiczb.Text = $"Zakres liczb: od {min_losowana} do {max_losowana}";
            // Ile prób pozosta³o?  (pozosta³o prób) konwerstujemy do stringa WYNIK Z ODEJMOWANIA
            lbl_PozostaloProb.Text = (limit_prob - wykonanych_prob).ToString();
        }

        private void btn_Sprawdz_Click(object sender, EventArgs e)
        {
            // Funkcja wywo³ywana za ka¿dym razem kiedy klikniemmy przycisk btn_Sprawdz
            string haslo = txt_Haslo.Text;  // Odczytanie hasla z textboxa

            // Czy has³o jest puste lub czy s¹ to tylko spacje?
            if (string.IsNullOrWhiteSpace(haslo))
            {
                // Kod wykonywany je¿eli has³o jest puste lub sa to tylko space
                MessageBox.Show("Has³o nie mo¿e byæ puste!");
            }
            // Czy has³o jest wystarczaj¹co d³ugie?
            else if (haslo.Length < 8 || haslo.Length > 16)
            {
                // Has³o ma mniej ni¿ 8 znaków LUB ma wiêcej ni¿ 16 znaków
                MessageBox.Show("Niepoprawna d³ugoœæ has³a! Has³o musi miêc od 8 do 16 znaków!");
            }
            // Czy has³o zawiera niedozwolone znaki? Znaki: ? - !
            else if (haslo.Contains("?") || haslo.Contains("-") || haslo.Contains("!"))
            {
                // Has³o zawiera niedozwolone znaki
                MessageBox.Show("Has³o zawiera niedozwolone znaki! '?' '-' '!'");
            }
            else
            {
                // Je¿eli nei znaleziono ¿adnego b³êdu has³a wyœwietlamy
                // komunikat o jego poprawnoœci
                MessageBox.Show("Has³o jest poprawne");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ZakresLiczb_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_SprawdzZgadywanie_Click(object sender, EventArgs e)
        {
            // Funkcja sprawdzaj¹ca poprawnoœæ odgadniecia

            // 1. Zwiekszenie liczby wykonanych prob
            // 2. Odswiezenie napisu o pozostalych probach
            // 3. Odczytanie jaka liczba zostala wpisana do text boxa
            // 4. Sprawdzenie czy podana liczba jest prawidlowa
            //     jesli tak:
            //        Wyswietlic komunikat o wygranej
            //        Losujemy nowa liczbe i resetujemy licznik prob
            // 5. W innym przypadku sprawdzamy czy mamy jeszcze kolejne proby
            //      jesli tak:
            //   Podana liczba jest: zbyt ma³a / zbyt duza?

            // Zmienna okreslajaca czy nalezy uruchomic nowa runde gry
            bool czy_uruchomic_nowa_runde = false;

            // Zwiekszenie licznika wykonanych prob
            wykonanych_prob++;
            // Obliczenie ile prob zostalo oraz wpisanie do pola tekstowego
            lbl_PozostaloProb.Text = (limit_prob - wykonanych_prob).ToString();
            // Odczytanie liczby podanej przez gracza
            int liczba_gracza = int.Parse(txt_LiczbaZgadywanie.Text);
            // Wyczysczenie textboxa
            txt_LiczbaZgadywanie.Text = "";
            // Sprawdzamy, czy podana liczba jest prawdi³owa
            if (liczba_gracza == wylosowana_liczba)
            {   // Prawda, odgadnieto liczbe
                // Komunikat o wygranej
                MessageBox.Show($"Gratulacjê! Uda³o Ci siê odgadn¹æ " +
                    $"wylosowan¹ liczbê {wylosowana_liczba} w {wykonanych_prob} prób.");
                // Nalezy uruchomic nowa runde
                czy_uruchomic_nowa_runde = true;
            }
            else  // Nie odgadnieto liczby
            {
                // Czy pozostaly nam jeszcze jakies proby?
                if (limit_prob - wykonanych_prob > 0)
                {   // Tak, mamy jeszcze mozliwosc zgadywania
                    if (liczba_gracza > wylosowana_liczba)
                    { // Nasza liczba jest za duza
                        lbl_KomunikatZgadywanie.Text = $"{liczba_gracza} jest zbyt du¿a.";
                    }
                    else
                    { // Nasza liczba jest zbyt mala
                        lbl_KomunikatZgadywanie.Text = $"{liczba_gracza} jest zbyt ma³a.";
                    }
                }
                else
                {   // Brak kolejnych prob zgadywania
                    // Komunikat o przegranej
                    MessageBox.Show($"Wyczerpano limit prób! Nie uda³o Ci siê odgadn¹æ " +
                        $"wylosowanej liczby {wylosowana_liczba}. Kliknij OK, aby uruchomiæ now¹ rundê.");
                    // Nalezy uruchomic nowa runde
                    czy_uruchomic_nowa_runde = true;
                }
            }

            // Uruchomienie nowej rundy
            if (czy_uruchomic_nowa_runde)
            {
                // Wyczyszczenie komunikatu o tym czy liczba jest za mala/za duza
                lbl_KomunikatZgadywanie.Text = "";
                // Wylosowanie nowej liczby
                wylosowana_liczba = random.Next(min_losowana, max_losowana);
                // Zresetowanie licznika wykonanych prób
                wykonanych_prob = 0;
                // Ustawienie pozostalych prob na LIMIT PROB
                lbl_PozostaloProb.Text = limit_prob.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_Wynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SprawdzWynik_Click(object sender, EventArgs e)
        {
            // Zmienna dla poprawnego wyniku
            int poprawnyWynik = a + b;
            // Zmienna dla podanego wyniku - konwertujemy string do inta
            int podanyWynik = int.Parse(txt_Wynik.Text);

            // Sprawdzamy poprawnoœæ wyniku
            if (poprawnyWynik == podanyWynik)
            {
                // Uaktualnienie licznika (czyli zmiennej) poprawnych odpowiedzi
                odp_poprawne++;  // Zwiekszamy zmienna o 1
                                 // odp_poprawne += 1; // Pozwala na zwiêkszenie zmiennej o wskazan¹ wartoœæ 
                                 //                      A nie tylko o jeden jak w sposobie zmienna++;
                                 // odp_poprawne = odp_poprawne + 1;  // Brzydki sposób na zwiêkszenie wartoœci zmiennej

                // Odœwiezenie napisu lbl_Poprawne
                lbl_Poprawne.Text = odp_poprawne.ToString();  // Zmienna int odp_poprawne zostala
                //                                              przekonwertowana do typu string

                // Wyœwietlenie komunikatu
                MessageBox.Show("Poprawny wynik!");

                // Losowanie nowych liczb
                a = random.Next(min_val, max_val);
                b = random.Next(min_val, max_val);

                // Wpisanie tekstu do lbl_Napis
                lbl_Napis.Text = $"{a} + {b} = ";
            }
            else  // Udzielono niepoprawnej odpowiedzi
            {
                // Zwiekszenie licznika blednych odpowiedzi
                odp_bledne++;

                // Odswiezenie napisu lbl_Bledne
                lbl_Bledne.Text = odp_bledne.ToString();

                // wyœwietlenie komunikatu
                MessageBox.Show("To nie jest poprawny wynik!");
            }

            // Wyczyszczenie pola tekstowego na odpowiedŸ
            txt_Wynik.Text = "";
        }
    }
}
