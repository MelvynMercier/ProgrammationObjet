﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PERSONNES.Classes
{
    public class Personne: IDisposable
    {
        private static int nb = 0;
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private int Age { get; set; }
        

        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            nb++;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {this.Nom}");
            Console.WriteLine($"Prénom: {this.Prenom}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine("");
        }

        public void Combien()
        {
            Console.WriteLine($"Nb personne créer : {nb}");
        }

        public void Dispose()
        {
            nb--;
        }
    }
}
