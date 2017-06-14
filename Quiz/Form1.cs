using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Pula Pula { set; get; }
        public int AktualnePytanie { set; get; }
        public int PoprawneOdpowiedzi { set; get; }

        public Form1()
        {
            //Tworze pule Pytań
            Pula = new Pula();
            AktualnePytanie = 0;
            PoprawneOdpowiedzi = 0;

            //Tworze kontrolki i przekazuje tam pule pytań
            InitializeComponent();

            UkryjPytania();
            UkryjObrazki();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            ZaladujPytanie(0);

        }

        private void OdpowiedzA_Click(object sender, EventArgs e)
        {
            SprawdzOdpowiedz(0);
        }

        private void OdpowiedzB_Click(object sender, EventArgs e)
        {
            SprawdzOdpowiedz(1);
        }

        private void OdpowiedzC_Click(object sender, EventArgs e)
        {
            SprawdzOdpowiedz(2);
        }

        private void OdpowiedzD_Click(object sender, EventArgs e)
        {
            SprawdzOdpowiedz(3);
        }


        private void SprawdzOdpowiedz(int odpowiedz)
        {
            if (Pula.ListaPytan[AktualnePytanie].Odpowiedzi[odpowiedz].Poprawna == true)
            {
                PoprawneOdpowiedzi++;
                Score.Text = PoprawneOdpowiedzi * 5 + " pkt";
            }

            AktualnePytanie++;

            ZaladujPytanie(AktualnePytanie);

        }

        private void ZaladujPytanie(int numerPytania)
        {
            if (numerPytania == 0)
            {
                Powitanie.Hide();
                Powitanie2.Hide();
                Start.Hide();
                PokazPytania();
            }


            if (numerPytania < Pula.ListaPytan.Count)
            {
                var pytanie = Pula.ListaPytan[numerPytania];

                if (pytanie.Obrazek == true)
                {
                    //OdpowiedzA_Tresc.Hide();
                    //OdpowiedzB_Tresc.Hide();
                    //OdpowiedzC_Tresc.Hide();
                    //OdpowiedzD_Tresc.Hide();
                    PokazObrazek();
                }
                else
                {
                    UkryjObrazki();


                }

                Pytanie.Text = pytanie.Tresc;
                OdpowiedzA_Tresc.Text = pytanie.Odpowiedzi[0].Tresc;
                OdpowiedzB_Tresc.Text = pytanie.Odpowiedzi[1].Tresc;
                OdpowiedzC_Tresc.Text = pytanie.Odpowiedzi[2].Tresc;
                OdpowiedzD_Tresc.Text = pytanie.Odpowiedzi[3].Tresc;
            }
            else
            {
                Powitanie.Text = "Twój wynik to " + PoprawneOdpowiedzi * 5 + " / 25 pkt.";

                if (PoprawneOdpowiedzi >= 4)
                {
                    Powitanie2.Text = "Brawo!";
                }
                else
                {
                    Powitanie2.Text = "Poćwicz jeszcze.";
                }

                Powitanie.Show();
                Powitanie2.Show();

                UkryjPytania();
            }

        }

        private void UkryjPytania()
        {
            Pytanie.Hide();
            OdpowiedzA_Tresc.Hide();
            OdpowiedzA.Hide();
            OdpowiedzB_Tresc.Hide();
            OdpowiedzB.Hide();
            OdpowiedzC_Tresc.Hide();
            OdpowiedzC.Hide();
            OdpowiedzD_Tresc.Hide();
            OdpowiedzD.Hide();

        }


        private void PokazPytania()
        {
            Pytanie.Show();
            OdpowiedzA_Tresc.Show();
            OdpowiedzA.Show();
            OdpowiedzB_Tresc.Show();
            OdpowiedzB.Show();
            OdpowiedzC_Tresc.Show();
            OdpowiedzC.Show();
            OdpowiedzD_Tresc.Show();
            OdpowiedzD.Show();

        }

        private void UkryjObrazki()
        {
            Obrazek1.Hide();
            Obrazek2.Hide();
            Obrazek3.Hide();
            Obrazek4.Hide();

        }

        private void PokazObrazek()
        {
            Obrazek1.Show();
            Obrazek2.Show();
            Obrazek3.Show();
            Obrazek4.Show();

        }

        private void Obrazek2_Click(object sender, EventArgs e)
        {

        }

        private void Obrazek3_Click(object sender, EventArgs e)
        {

        }
    }
}
