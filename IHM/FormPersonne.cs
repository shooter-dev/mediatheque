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
    public partial class FormPersonne : Form
    {
        public FormPersonne()
        {
            InitializeComponent();
            this.VScroll = VScroll;
        }

        private void FormPersonne_Load(object sender, EventArgs e)
        {
            List<Personne> listP = new List<Personne>();
            Personne per1 = new Personne(01, "a", "aa", new DateTime());
            Personne per2 = new Personne(02, "b", "bb", new DateTime());
            Personne per3 = new Personne(03, "c", "cc", new DateTime());
            Personne per4 = new Personne(04, "d", "dd", new DateTime());
            Personne per5 = new Personne(05, "e", "ee", new DateTime());
            listP.Add(per1);
            listP.Add(per2);
            listP.Add(per3);
            listP.Add(per4);
            listP.Add(per5);
            PersonneViewControl personneControl;
            int x = 0, y = 0,cur = 0,dim = 100;
            foreach (var item in listP)
            {
                personneControl = new PersonneViewControl(item);
                this.Controls.Add(personneControl);
                personneControl.Location = new Point(0,y);
                personneControl.Show();
                y = y + dim;
            }
        }

        public void Atualiser()
        {

        }
    }
}
