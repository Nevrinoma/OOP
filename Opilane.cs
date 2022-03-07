using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inimene
{
    class Opilane : Inimene
    {
        string ruhm;
        double hinne;
        bool toetus;
        public Opilane() { }
        public Opilane(string eesnimi,string perenimi):base(eesnimi,perenimi)
        {
            ruhm = Ruhm;
        }

        public Opilane(string eesnimi, string perenimi, string v) : this(eesnimi, perenimi)
        {
            V = v;
        }

        public string Ruhm
        {
            set { ruhm = value; }
            get { return ruhm; }
        }

        public double Hinne
        {
            set { if (value > 1 && value < 5) hinne = value; }
            get { return hinne; }
        }
        public bool Toetus
        {
            get
            {
                if (hinne>3)
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;
            }
        }

        
        public string V { get; }

        public void Info()
        {
            string t = "";
            Console.WriteLine("Tere! Minu nimi on {0} {1}",Eesnimi,Perenimi);
            if (Toetus==true)
            {
                t = "saan toestust kätte :3"; 
            }
            else if (Toetus==false&& hinne>0)
            {
                t = "ei saa toetust :/";
            }
            else
            {
                t = "andmed hinnetest puuduvad!";
            }
        }



    }



}
