using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class FormIndex : Form
    {

        //
        private Form formCurrentModif;
        //
        private Form formCurrentInfo;

        public FormIndex()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormIndex_Load(object sender, EventArgs e)
        {
            DefaultBtnVisible();
           

        }

        private void DefaultBtnVisible()
        {
            //Livre
            btnLivreAdd.Visible = false;
            btnLivreMod.Visible = false;
            btnLivreSup.Visible = false;
            //Serie
            btnSerieAdd.Visible = false;
            btnSerieMod.Visible = false;
            btnSerieSup.Visible = false;
            //Edition
            btnEditionAdd.Visible = false;
            btnEditionMod.Visible = false;
            btnEditionSup.Visible = false;
            //Genre
            btnGenreAdd.Visible = false;
            btnGenreMod.Visible = false;
            btnGenreSup.Visible = false;
            //Personne
            btnPersonneAdd.Visible = false;
            btnPersonneMod.Visible = false;
            btnPersonneSup.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Modifie le chemin de la page
            CheminIndex(((Button)sender).Text.ToString());
            // Cache tout les sous button Menue
            DefaultBtnVisible();
            // Actualise le controleur 
            panelModif.Controls.Clear();
            // Rend visible les trois sous button du menu selectionné
            switch (((Button)sender).Name)
            {
                case "btnLivre":
                    btnLivreAdd.Visible = true;
                    btnLivreMod.Visible = true;
                    btnLivreSup.Visible = true;
                    break;
                case "btnSerie":
                    btnSerieAdd.Visible = true;
                    btnSerieMod.Visible = true;
                    btnSerieSup.Visible = true;
                    break;
                case "btnEdition":
                    btnEditionAdd.Visible = true;
                    btnEditionMod.Visible = true;
                    btnEditionSup.Visible = true;
                    break;
                case "btnGenre":
                    btnGenreAdd.Visible = true;
                    btnGenreMod.Visible = true;
                    btnGenreSup.Visible = true;
                    break;
                case "btnPersonne":
                    FormPersonne fPersonne = new FormPersonne();
                    fPersonne.TopLevel = false;
                    fPersonne.FormBorderStyle = FormBorderStyle.None;
                    fPersonne.Parent = panelContent;
                    fPersonne.Top = 0;
                    fPersonne.Left = 0;
                    fPersonne.Size = panelContent.ClientSize;
                    fPersonne.Dock = DockStyle.Fill;
                    fPersonne.BringToFront();
                    fPersonne.Show();
                    btnPersonneAdd.Visible = true;
                    btnPersonneMod.Visible = true;
                    btnPersonneSup.Visible = true;
                    break;
            }
        }

        private void CheminIndex(string param1 = "",string param2 = "")
        {
            
            if(param2 == null || param2 == "".Trim())
                labelIndex.Text = String.Format(@"Index \ {0} \", param1);
            else
                labelIndex.Text = String.Format(@"Index \ {0} \ {1} \", param1,param2);
        }

        private void btnSousMenu_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnLivreAdd":

                    break;
                case "btnLivreMod":

                    break;
                case "btnLivreSup":

                    break;
                case "btnSerieAdd":

                    break;
                case "btnSerieMod":

                    break;
                case "btnSerieSup":

                    break;
                case "btnEditionAdd":

                    break;
                case "btnEditionMod":

                    break;
                case "btnEditionSup":

                    break;
                case "btnGenreAdd":

                    break;
                case "btnGenreMod":

                    break;
                case "btnGenreSup":

                    break;
                case "btnPersonneAdd":
                    PersonneAddForm p = PersonneAddForm.GetInstance();
                    FormOuvertureModif(p);
                    break;
                case "btnPersonneMod":

                    break;
                case "btnPersonneSup":
                    
                    break;
            }
            
        }

        private void FormOuvertureModif(Form fenetre)
        {
            //si un control est encour alor il dispose le control
            //if (formCurrentModif != null)
            //{
            //    formCurrentModif.Dispose();
            //}
                //panelModif.Controls.Clear();
                fenetre.TopLevel = false;
                fenetre.FormBorderStyle = FormBorderStyle.None;
                fenetre.Location = new Point(0, 0);
                fenetre.Size = panelModif.ClientSize;
                fenetre.Dock = DockStyle.Fill;
                fenetre.BringToFront();
                formCurrentModif = fenetre;
                fenetre.Parent = panelModif;
                fenetre.Show();
            
        }
    }
}
