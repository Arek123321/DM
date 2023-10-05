using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Film
    {
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;


        public Film() { }
        public Film(int annee, string genre, int idFilm, string resume, string titre)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
        }

        public int Annee { get => annee; set => annee = value; }
        public string Genre { get => genre; set => genre = value; }
        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Titre { get => titre; set => titre = value; }


        public int getAnne()
        {
            return this.annee;
        }

        public string getGenre()
        {
            return this.genre;
        }

        public int getidFilm()
        {
            return this.idFilm;
        }

        public void getInstance()
        {
            Film f = new Film();
        }
        public string getResume()
        {
            return this.resume;

        }

        public string getTitre()
        {
            return this.titre;
        }

        public void ToString()
        {
             Console.WriteLine("Titre: " + this.titre + " \nAnnee: " + this.annee + "\nGenre: " + this.genre + "\nResume: " + resume);
        }

        public Acteur getActeurPrincipal()
        {
            return this.acteurPrincipal;
        }
    } }
