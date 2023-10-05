using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Cinema
    {
        private Cinema cine;
        private List<Acteur> lesActeurs;
        private List<Film> lesFilmes;

        public Cinema()
        {
            this.lesActeurs = new List<Acteur>();
            this.lesFilmes = new List<Film>();
        }

        public void getInstance()
        {
            Cinema c = new Cinema();
        }
        public Acteur getActeur(int id)
        {
            Acteur a = new Acteur();
            foreach (Acteur acteur in lesActeurs)
            {
                
                if(acteur.Id == id)
                {
                    a= acteur;
                }
            }
            return a;
        }

        public Film getFilm(int id)
        {
            Film a = new Film();
            foreach (Film film in lesFilmes)
            {

                if (film.IdFilm == id)
                {
                    a = film;
                }
            }
            return a;
        }

        public int nbActeurs()
        {
            int i = 0;
            foreach (Acteur acteur in lesActeurs)
            {
                i++;   
            }

            return i;
        }

        public void setFilm(int annee, string genre, int idFilm, string resume, string titre)
        {
            Film film = new Film(annee,genre,idFilm,resume,titre);
            lesFilmes.Add(film);
        }

        public void setActeurs(int anneNaissance, int id, string nom, string prenom)
        {
            Acteur act = new Acteur(anneNaissance, id, nom, prenom);
            lesActeurs.Add(act);
        }
    }
}
