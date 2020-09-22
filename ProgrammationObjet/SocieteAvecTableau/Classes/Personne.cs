using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteAvecTableau.Classes
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Personne() { }

        public Personne(string nom, string prenom, int age)
        {
            this.Prenom = prenom;
            this.Nom = nom;
            this.Age = age;
        }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom + " " + this.Age;
        }
    }
}
