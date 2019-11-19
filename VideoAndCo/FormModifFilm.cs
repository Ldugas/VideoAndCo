using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace VideoAndCo
{
    public partial class FormModifFilm : Form
    {
        private videoppe3_Dugas_Guilloteau_PereiraEntities1 maConnexion;
        private string Titre;
        private string Realistaeur;
        private string Duree;
        private string Genre;


        public FormModifFilm()
        {
            InitializeComponent();
            maConnexion = new videoppe3_Dugas_Guilloteau_PereiraEntities1();
            /* le  bindingSource  bsVille est connecté à la table Ville de la BDD  via la chaîne de connexion */
            BSFilm.DataSource = maConnexion.film.ToList();
            BSUnFilm.DataSource = maConnexion.film.ToList();

            film vcurrent = (film)BSFilm.Current;
            // création d'un filtre pour les salles sur l' idBati de l'enregistrement courant
            var filteredData = maConnexion.film.ToList()
                     .Where(x => x.idFilm == vcurrent.idFilm);
            // x représente un enregistrement de salle
            BSUnFilm.DataSource = filteredData; // application du filtre
            //dgBatiment.DataSource = bsSalle;

            TBNomFilm.Text = vcurrent.support.titreSupport.ToString();
            TBRealisateur.Text = vcurrent.support.realisateur.ToString();
            TBDuree.Text = vcurrent.duree.ToString();

        }

        private void BSFilm_CurrentChanged(object sender, EventArgs e)
        {
            
            maConnexion = new videoppe3_Dugas_Guilloteau_PereiraEntities1();
            /* le  bindingSource  bsVille est connecté à la table Ville de la BDD  via la chaîne de connexion */

            film vcurrent = (film)BSFilm.Current;
            // création d'un filtre pour les salles sur l' idBati de l'enregistrement courant
            var filteredData = maConnexion.film.ToList()
                         .Where(x => x.idFilm == vcurrent.idFilm);
            // x représente un enregistrement de salle
            BSUnFilm.DataSource = filteredData; // application du filtre
                                                //dgBatiment.DataSource = bsSalle;

            TBNomFilm.Text = vcurrent.support.titreSupport.ToString();
            TBRealisateur.Text = vcurrent.support.realisateur.ToString();
            TBDuree.Text = vcurrent.duree.ToString();
            TBGenre.Text = vcurrent.support.genre.libelleGenre.ToString();
            PBImageFilm.ImageLocation = "C:/wamp64/www/ApplicationDeBase/Images/" + vcurrent.support.image.ToString();


        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (Titre != TBNomFilm.Text.ToString() || Realistaeur != TBRealisateur.Text.ToString() || Duree != TBDuree.Text.ToString() || Genre != TBGenre.Text.ToString())
            {
                
            }
        }

    }
}
