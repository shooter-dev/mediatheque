using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Personne : Model
    {
        private int id;
        private string name,prenom;
        private DateTime naissance;
        private Image cover;

        public Personne()
        {

        }
        public Personne(int id, string name, string prenom, DateTime naissance, Image cover = null)
        {
            this.id = id;
            this.name = name;
            this.prenom = prenom;
            this.naissance = naissance;
            this.cover = cover;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime Naissance { get => naissance; set => naissance = value; }
        public Image Cover { get => cover; set => cover = value; }
    }
}
