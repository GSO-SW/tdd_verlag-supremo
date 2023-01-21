using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public Buch(string autor, string titel)
        {
                this.autor = autor;
                this.titel = titel;
                auflage = 1;
        }

        public Buch(string autor, string titel, int auflage) :this(autor, titel)
        {
            if (auflage < 1)
            {
                throw new ArgumentOutOfRangeException("Auflage Darf Nicht Kleiner als 1 Sein");
            }
            else
            {
                this.auflage = auflage;
            }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Titel
        {
            get { return titel; }
        }
        public int Auflage
        {
            get { return auflage; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Auflage Darf Nicht Kleiner als 1 Sein");
                }
                else
                {
                    auflage = value;
                }
            }
        }

        public void AuflageDarfNichtKleinSein()
        {
            if (auflage < 1)
            {
                throw new ArgumentOutOfRangeException("Auflage Darf Nicht Kleiner als 1 Sein");
            }
        }

        public void NurSinnvolleEingabenErlaubt1(char unerlaubtesZeichen)
        {
            if (autor.Contains(unerlaubtesZeichen))
            {
                throw new ArgumentException("Der auto soll kein sonder zeichen entälten");
            }
            else if (autor == null) 
            {
                throw new ArgumentNullException("der auto soll keine null enthälten");
            }
        }
    }
}
