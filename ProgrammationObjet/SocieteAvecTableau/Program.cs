using SocieteAvecTableau.Classes;
using System;
using System.Collections.Generic;

namespace SocieteAvecTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayPers = new List<Personne>();

            arrayPers.Add(new Employe(2500, "Dubosc", "Franck", 55));
            arrayPers.Add(new Employe(3500, "Youn", "Michael", 40));
            arrayPers.Add(new Employe(4500, "Boon", "Dany", 42));
            arrayPers.Add(new Employe(2300, "Foresti", "Florence", 38));
            arrayPers.Add(new Employe(2300, "Semoune", "Elie", 49));
            arrayPers.Add(new Chef("Humoriste", 5000, "Gardin", "Blanche", 26));
            arrayPers.Add(new Chef("Humoriste", 3000, "Robin", "Murielle", 58));
            arrayPers.Add(new Directeur("Head&Shoulders", "Direction", 2700, "Adams", "Kevin", 24));

            for (int i = 0; i < arrayPers.Count; i++)
            {
                arrayPers[i].Afficher();
            }

            arrayPers.ForEach(pers =>
            {
                pers.Afficher();
            });
        }
    }
}
