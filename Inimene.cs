using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inimene
{
    
    
    public class Inimene
    {
        string eesnimi;
        string perenimi;
        int vanus;
        string pol;
        double rost;
        string staatus;
        int palk;

        Emakeel emakeel;
        Sugu sugu;
        public Inimene() { }//конструктор
        public Inimene(string Eesnimi,string Perenimi)
        {
            eesnimi = Eesnimi;
            perenimi = Perenimi;
        }
        public Inimene(string Eesnimi, string Pol, double Rost)
        {
            eesnimi = Eesnimi;
            pol = Pol;
            rost = Rost;
        }
        public Inimene(string Eesnimi, Emakeel emakeel, Sugu sugu)
        {
            eesnimi = Eesnimi;
            this.emakeel = emakeel;
            this.sugu = sugu;
        }
        public Sugu Sugu
        {
            get { return sugu; }
        }
        public Emakeel Emakeel
        {
            get { return emakeel; }
        }
        //свойства
        public string Eesnimi
        {
            set
            {
                if (eesnimi == null) eesnimi = value;
            }
            get { return eesnimi; }
        }
        public int Vanus
        {
            set
            {
                vanus = value;
                if (vanus < 7)
                {
                    staatus = "väike laps";
                }
                else if (vanus < 17)
                {
                    staatus = "kooli laps";
                }
                else if (vanus < 65)
                {
                    staatus = "tööline inimene";
                }
                else
                {
                    staatus = "senior";
                }
            }
            get { return vanus; }

        }
        public string Staatus
        {
            get
            {
                var staatus = "";
                if (vanus < 7)
                {
                    staatus = "väike laps";
                }
                else if (vanus < 17)
                {
                    staatus = "kooli laps";
                }
                else if (vanus < 65)
                {
                    staatus = "tööline inimene";
                }
                else
                {
                    staatus = "senior";
                }
                return staatus;
            }
        }
        //public string Answer 
        //{
        //    set
        //    {
        //        answer = value;
        //        if (vanus % 2 == 0)
        //        {
        //            answer = "Да";
        //        }

        //        else
        //        {
        //            answer = "Нет";
        //        }
        //    }
        //    get { return answer; }
        //}
        public int Palk
        {
            set { palk = value; }
            get { return palk; }
        }
        public void Tervitame()//метод
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("Minu nimi on {0} Olen {1} aastat vana. Minu staatus on {2}. Ma olen {3}", eesnimi, vanus, Staatus, sugu);
        }
        public double Tulumaks()//метод
        {
            double tulu = 0;
            tulu = palk * 0.2;
            return tulu;
        }
    }
    
}