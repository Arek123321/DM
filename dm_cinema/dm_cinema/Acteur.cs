
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Acteur
    {

        private int anneNaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur() { }
        public Acteur(int anneNaissance, int id, string nom, string prenom)
        {
            this.anneNaissance = anneNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int AnneNaissance { get => anneNaissance; set => anneNaissance = value; }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public void getInstance()
        {
            Acteur a= new Acteur();
        }
        public int getAnneNaissance()
        {
            return this.anneNaissance;
        }
        public int getId()
        {
            return this.id;
        }
        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public void ToString()
        {
            Console.WriteLine("Nom: " + this.nom + " Prenom: " + this.prenom + " Annee de naissance: " + this.anneNaissance);
        }
    }
}
