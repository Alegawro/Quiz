using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Odpowiedz
    {
        public string Tresc { set; get; }
        public bool Poprawna { set; get; }
    }

    public class Pytanie
    {
        public string Tresc { set; get; } 
        public bool Obrazek { set; get; }
        public List<Odpowiedz> Odpowiedzi { set; get; }
    }

    public class Pula
    {

        public List<Pytanie> ListaPytan { set; get; }

        public Pula()
        {
            ListaPytan = new List<Pytanie>()
            {
                new Pytanie() 
                {
                    Tresc = "W którym roku założono Politechnikę Gdańską \n (jako polska państwowa szkoła akademicka)?",
                    Odpowiedzi = new List<Odpowiedz>()
                    {
                        new Odpowiedz() { Poprawna = false, Tresc = "1933" },
                        new Odpowiedz() { Poprawna = false, Tresc = "1904" },
                        new Odpowiedz() { Poprawna = false, Tresc = "1898" },
                        new Odpowiedz() { Poprawna = true, Tresc = "1945" },
                    }
                },
                new Pytanie()
                {
                    Obrazek=true,
                    Tresc = "Którego logo jest logiem Politechniki Gdańskiej?",
                    Odpowiedzi = new List<Odpowiedz>()
                    {
                        new Odpowiedz() { Poprawna = false, Tresc =  ""},
                        new Odpowiedz() { Poprawna = false, Tresc = "" },
                        new Odpowiedz() { Poprawna = true, Tresc = "" },
                        new Odpowiedz() { Poprawna = false, Tresc = "" },
                    }
                },
                new Pytanie()
                {
                    Tresc = "Ile wydziałów jest na Politechnice Gdańskiej?",
                    Odpowiedzi = new List<Odpowiedz>()
                    {
                        new Odpowiedz() { Poprawna = true, Tresc = "9" },
                        new Odpowiedz() { Poprawna = false, Tresc = "8" },
                        new Odpowiedz() { Poprawna = false, Tresc = "5" },
                        new Odpowiedz() { Poprawna = false, Tresc = "7" },
                    }
                },
                new Pytanie()
                {
                    Tresc = "Które miejsce w rankingu Perspektyw z 2016 \n roku zajmuje Politechnika Gdańska?",
                    Odpowiedzi = new List<Odpowiedz>()
                    {
                        new Odpowiedz() { Poprawna = false, Tresc = "11" },
                        new Odpowiedz() { Poprawna = false, Tresc = "4" },
                        new Odpowiedz() { Poprawna = true, Tresc = "15" },
                        new Odpowiedz() { Poprawna = false, Tresc = "32" },
                    }
                },
                new Pytanie()
                {
                    Tresc = "Jaki pełny tytuł naukowy ma prof. Eligiusz Mieloszyk? ",
                    Odpowiedzi = new List<Odpowiedz>()
                    {
                        new Odpowiedz() { Poprawna = false, Tresc = "prof. dr inż." },
                        new Odpowiedz() { Poprawna = true, Tresc = "prof. dr hab. inż." },
                        new Odpowiedz() { Poprawna = false, Tresc = "prof. dr mgr" },
                        new Odpowiedz() { Poprawna = false, Tresc = "prof. dr hab. mgr" },
                    }
                },
              
            };



        }


    }

}
