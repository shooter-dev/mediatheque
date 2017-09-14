using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace IHM
{
    public partial class PersonneViewControl : UserControl
    {
        private Personne personne;
        public PersonneViewControl(Personne personne)
        {
            InitializeComponent();
            this.personne = personne;
        }

        private void PersonneViewControl_Load(object sender, EventArgs e)
        {
            labelName.Text = personne.Name;
            labelPrenom.Text = personne.Prenom;
            labelNaissance.Text = personne.Naissance.ToString();
            pictureBoxCover.Image = personne.Cover;

        }
    }
}
