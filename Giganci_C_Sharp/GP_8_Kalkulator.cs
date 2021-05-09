using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_10_Rozgrzewka_Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Oblicz_Click(object sender, EventArgs e)
        {
            /*
             * Wpisanie liczby z przecinkiem oraz z kropką powinno działać tak samo
             * (Podpowiedz podmiana znaku)
             * 
             * Przy kliknięciu oblicz dla niepoprawnie wpisanej liczby program powinien 
             * poinformować użytkownika o pomyłce. Nie powinien się zawieszać / crashować
             * (Łapanie wyjątku - odszukanie w naszym poprzednim projekcie)
             * 
             */
            float pierwszaLiczba = float.Parse(txt_PierwszaLiczba.Text);
            float drugaLiczba = float.Parse(txt_DrugaLiczba.Text);
            float wynik;

            switch(cmb_Dzialanie.Text)
            {
                case "Dodawanie":
                    wynik = pierwszaLiczba + drugaLiczba;
                    txt_Wynik.Text = wynik.ToString();
                    break;
                case "Odejmowanie":
                    wynik = pierwszaLiczba - drugaLiczba;
                    txt_Wynik.Text = wynik.ToString();
                    break;
                case "Mnożenie":
                    wynik = pierwszaLiczba * drugaLiczba;
                    txt_Wynik.Text = wynik.ToString();
                    break;
                case "Dzielenie":
                    wynik = pierwszaLiczba / drugaLiczba;
                    txt_Wynik.Text = wynik.ToString();
                    break;
                default:
                    txt_Wynik.Text = "Wybierz działanie!";
                    break;
            }
        }
    }
}
