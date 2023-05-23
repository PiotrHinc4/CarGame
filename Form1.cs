using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        private static readonly int DEFAULT_TURA=1;
        private static readonly int DEFAULT_BUDZET=20000;
        private static readonly int DEFAULT_ILOSC_SAMOCHODOW=0;
        public int tura = DEFAULT_TURA;
        public int budzet = DEFAULT_BUDZET;
        public int iloscSamochodow = DEFAULT_ILOSC_SAMOCHODOW;
        public string[,] samochody = new string[5, 4];
        public Form1()
        {
            InitializeComponent();
        }
        private void aktualizacjaDanych()
        {
            lblBudzet.Text = "Budżet: " + budzet;
            lblTura.Text = "Tura: " + tura;
        }
        string czyJestInformacja(string informacja)
        {
            if (informacja == null)
            {
                return "---";
            }
            else
            {
                return informacja;
            }
        }
        private void aktualizacjaTabeli()
        {
            lblNazwa1.Text = czyJestInformacja(samochody[0,0]);
            lblWartosc1.Text = czyJestInformacja(samochody[0, 1]);
            lblUszkodzenia1.Text = czyJestInformacja(samochody[0, 2]);
            lblWartoscRynkowa1.Text = czyJestInformacja(samochody[0, 3]);

            lblNazwa2.Text = czyJestInformacja(samochody[1, 0]);
            lblWartosc2.Text = czyJestInformacja(samochody[1, 1]);
            lblUszkodzenia2.Text = czyJestInformacja(samochody[1, 2]);
            lblWartoscRynkowa2.Text = czyJestInformacja(samochody[1, 3]);

            lblNazwa3.Text = czyJestInformacja(samochody[2, 0]);
            lblWartosc3.Text = czyJestInformacja(samochody[2, 1]);
            lblUszkodzenia3.Text = czyJestInformacja(samochody[2, 2]);
            lblWartoscRynkowa3.Text = czyJestInformacja(samochody[2, 3]);

            lblNazwa4.Text = czyJestInformacja(samochody[3, 0]);
            lblWartosc4.Text = czyJestInformacja(samochody[3, 1]);
            lblUszkodzenia4.Text = czyJestInformacja(samochody[3, 2]);
            lblWartoscRynkowa4.Text = czyJestInformacja(samochody[3, 3]);

            lblNazwa5.Text = czyJestInformacja(samochody[4, 0]);
            lblWartosc5.Text = czyJestInformacja(samochody[4, 1]);
            lblUszkodzenia5.Text = czyJestInformacja(samochody[4, 2]);
            lblWartoscRynkowa5.Text = czyJestInformacja(samochody[4, 3]);
        }

        private void bttnKupno_Click(object sender, EventArgs e)
        {
            if (iloscSamochodow >= 5)
            {
                lblInformacja.Text = "Informacje: Zbyt mało miejsca w garażu, aby kupić nowy samochód!!!!";
            }
            else
            { 
                
            }
        }
    }
}
