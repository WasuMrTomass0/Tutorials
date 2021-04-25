using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_8_Switch_ThemePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Odczytujemy obecnie wybran¹ opcjê z listy
            string schematKolorow = cmb_ComboBox.Text;

            // Obs³u¿enie odpowiedniego schematu kolorów
            switch (schematKolorow)
            {
                case "Dark":
                    // Zmiana LABEL
                    BackColor = Color.DarkSlateGray;    // Ustawienie t³a okienka aplikacji
                    ForeColor = Color.White;            // Pierwszy kolor aplikacji
                    // Zmiana TEXTBOX
                    txt_TextBox.BackColor = Color.DarkSlateGray;
                    txt_TextBox.ForeColor = Color.White;
                    // Zmiana ComboBox
                    cmb_ComboBox.BackColor = Color.DarkSlateGray;
                    cmb_ComboBox.ForeColor = Color.White;
                    break;
                case "Light":
                    // Zmiana LABEL
                    BackColor = Color.White;    // Ustawienie t³a okienka aplikacji
                    ForeColor = Color.Black;    // Pierwszy kolor aplikacji
                    // Zmiana TEXTBOX
                    txt_TextBox.BackColor = Color.White;
                    txt_TextBox.ForeColor = Color.Black;
                    // Zmiana ComboBox
                    cmb_ComboBox.BackColor = Color.White;
                    cmb_ComboBox.ForeColor = Color.Black;
                    break;
                case "Blue":
                    // Zmiana LABEL
                    BackColor = Color.Blue;     // Ustawienie t³a okienka aplikacji
                    ForeColor = Color.White;    // Pierwszy kolor aplikacji
                    // Zmiana TEXTBOX
                    txt_TextBox.BackColor = Color.Blue;
                    txt_TextBox.ForeColor = Color.White;
                    // Zmiana ComboBox
                    cmb_ComboBox.BackColor = Color.Blue;
                    cmb_ComboBox.ForeColor = Color.White;
                    break;
            }
        }
    }
}
