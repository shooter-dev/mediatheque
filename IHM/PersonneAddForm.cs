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
using System.IO;

namespace IHM
{
    public partial class PersonneAddForm : Form
    {
        public static PersonneAddForm instance;

        private Personne personne;

        public static PersonneAddForm GetInstance()
        {
            if (instance == null) instance = new PersonneAddForm();
            else MessageBox.Show("la fenetre est deja en cour !", "Fenetre");
            return instance;
        }

        private PersonneAddForm()
        {
            InitializeComponent();
        }

        private void PersonneAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void groupBoxContent_Enter(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    personne.Cover = Image.FromFile(dialog.FileName);
                    pictureBoxCover.Image = personne.Cover;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Trim() != "")
                personne.Name = tbName.Text;
            if (tbPrenom.Text.Trim() != "")
                personne.Prenom = tbPrenom.Text;
            if (dateTimeNaissance.Value.Date < DateTime.Today)
                personne.Naissance = dateTimeNaissance.Value.Date;
            else
                personne.Naissance = new DateTime();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonneAddForm_Load(object sender, EventArgs e)
        {
            personne = new Personne();
        }
    }
}
