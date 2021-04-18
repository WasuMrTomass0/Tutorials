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
        // Stworzenie zmiennych, kt�re b�d� dost�pne dla wielu funkcji
        int a, b;       // Liczby, kt�re b�dziemy dodawa�
        int odp_poprawne = 0, odp_bledne = 0; // Liczniki odpowiedzi poprawnych i blednych
        const int min_val = 0, max_val = 100; // Sta�e okre�laj�ce zakres losowanych liczb
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
            // Pierwsze wpisanie tekstu do lbl_Bledne i lbl_Poprawne. Zawsze s� to zera
            lbl_Bledne.Text = odp_bledne.ToString();
            lbl_Poprawne.Text = odp_poprawne.ToString();
            // // // // // // // // // // // // // // // // // // // // // 
            // Odgadywanie liczby

            // Wylosowanie liczby, ktora mamy odgadnac
            wylosowana_liczba = random.Next(min_losowana, max_losowana);

            // Ustawienie napis�w
            //                     Wstawienie zmiennych do tekstu
            lbl_ZakresLiczb.Text = $"Zakres liczb: od {min_losowana} do {max_losowana}";
            // Ile pr�b pozosta�o?  (pozosta�o pr�b) konwerstujemy do stringa WYNIK Z ODEJMOWANIA
            lbl_PozostaloProb.Text = (limit_prob - wykonanych_prob).ToString();
        }

        private void btn_Sprawdz_Click(object sender, EventArgs e)
        {
            // Funkcja wywo�ywana za ka�dym razem kiedy klikniemmy przycisk btn_Sprawdz
            string haslo = txt_Haslo.Text;  // Odczytanie hasla z textboxa

            // Czy has�o jest puste lub czy s� to tylko spacje?
            if (string.IsNullOrWhiteSpace(haslo))
            {
                // Kod wykonywany je�eli has�o jest puste lub sa to tylko space
                MessageBox.Show("Has�o nie mo�e by� puste!");
            }
            // Czy has�o jest wystarczaj�co d�ugie?
            else if (haslo.Length < 8 || haslo.Length > 16)
            {
                // Has�o ma mniej ni� 8 znak�w LUB ma wi�cej ni� 16 znak�w
                MessageBox.Show("Niepoprawna d�ugo�� has�a! Has�o musi mi�c od 8 do 16 znak�w!");
            }
            // Czy has�o zawiera niedozwolone znaki? Znaki: ? - !
            else if (haslo.Contains("?") || haslo.Contains("-") || haslo.Contains("!"))
            {
                // Has�o zawiera niedozwolone znaki
                MessageBox.Show("Has�o zawiera niedozwolone znaki! '?' '-' '!'");
            }
            else
            {
                // Je�eli nei znaleziono �adnego b��du has�a wy�wietlamy
                // komunikat o jego poprawno�ci
                MessageBox.Show("Has�o jest poprawne");
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
            // Funkcja sprawdzaj�ca poprawno�� odgadniecia

            // 1. Zwiekszenie liczby wykonanych prob
            // 2. Odswiezenie napisu o pozostalych probach
            // 3. Odczytanie jaka liczba zostala wpisana do text boxa
            // 4. Sprawdzenie czy podana liczba jest prawidlowa
            //     jesli tak:
            //        Wyswietlic komunikat o wygranej
            //        Losujemy nowa liczbe i resetujemy licznik prob
            // 5. W innym przypadku sprawdzamy czy mamy jeszcze kolejne proby
            //      jesli tak:
            //   Podana liczba jest: zbyt ma�a / zbyt duza?

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
            // Sprawdzamy, czy podana liczba jest prawdi�owa
            if (liczba_gracza == wylosowana_liczba)
            {   // Prawda, odgadnieto liczbe
                // Komunikat o wygranej
                MessageBox.Show($"Gratulacj�! Uda�o Ci si� odgadn�� " +
                    $"wylosowan� liczb� {wylosowana_liczba} w {wykonanych_prob} pr�b.");
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
                        lbl_KomunikatZgadywanie.Text = $"{liczba_gracza} jest zbyt du�a.";
                    }
                    else
                    { // Nasza liczba jest zbyt mala
                        lbl_KomunikatZgadywanie.Text = $"{liczba_gracza} jest zbyt ma�a.";
                    }
                }
                else
                {   // Brak kolejnych prob zgadywania
                    // Komunikat o przegranej
                    MessageBox.Show($"Wyczerpano limit pr�b! Nie uda�o Ci si� odgadn�� " +
                        $"wylosowanej liczby {wylosowana_liczba}. Kliknij OK, aby uruchomi� now� rund�.");
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
                // Zresetowanie licznika wykonanych pr�b
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

            // Sprawdzamy poprawno�� wyniku
            if (poprawnyWynik == podanyWynik)
            {
                // Uaktualnienie licznika (czyli zmiennej) poprawnych odpowiedzi
                odp_poprawne++;  // Zwiekszamy zmienna o 1
                                 // odp_poprawne += 1; // Pozwala na zwi�kszenie zmiennej o wskazan� warto�� 
                                 //                      A nie tylko o jeden jak w sposobie zmienna++;
                                 // odp_poprawne = odp_poprawne + 1;  // Brzydki spos�b na zwi�kszenie warto�ci zmiennej

                // Od�wiezenie napisu lbl_Poprawne
                lbl_Poprawne.Text = odp_poprawne.ToString();  // Zmienna int odp_poprawne zostala
                //                                              przekonwertowana do typu string

                // Wy�wietlenie komunikatu
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

                // wy�wietlenie komunikatu
                MessageBox.Show("To nie jest poprawny wynik!");
            }

            // Wyczyszczenie pola tekstowego na odpowied�
            txt_Wynik.Text = "";
        }
    }
}
