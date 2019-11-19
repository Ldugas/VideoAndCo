using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoAndCo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*eeeeettttttteee*/
        }

        private void ComposantFilmAjout_Click(object sender, EventArgs e)
        {
       

        }

        private void ComposantSaisonAjout_Click(object sender, EventArgs e)
        {
            
        }

        private void ComposantClientAjout_Click(object sender, EventArgs e)
        {
           
        }

        private void ComposantFilmAfficher_Click(object sender, EventArgs e)
        {
            FormAfficheFilm ffilme = new FormAfficheFilm(); //Rôle de l’instruction ?
            ffilme.Show(); //Rôle de l’instruction ?
        }

        private void ComposantGenreAfficher_Click(object sender, EventArgs e)
        {

        }

        private void ComposantSerieAfficher_Click(object sender, EventArgs e)
        {

        }

        private void ComposantSaisonAfficher_Click(object sender, EventArgs e)
        {
            FormAfficheSaison fsaison = new FormAfficheSaison(); //Rôle de l’instruction ?
            fsaison.Show(); //Rôle de l’instruction ?
        }

        private void ComposantClientAfficher_Click(object sender, EventArgs e)
        {
            FormAfficheClient fclient = new FormAfficheClient(); //Rôle de l’instruction ?
            fclient.Show(); //Rôle de l’instruction ?
        }

        private void ComposantFilmModif_Click(object sender, EventArgs e)
        {
            FormModifFilm fmodiffilm = new FormModifFilm(); //Rôle de l’instruction ?
            fmodiffilm.Show(); //Rôle de l’instruction ?
        }
    }
}
