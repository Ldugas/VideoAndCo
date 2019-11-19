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
    public partial class FormAfficheFilm : Form
    {
        private videoppe3_Dugas_Guilloteau_PereiraEntities1 maConnexion;
        public FormAfficheFilm()
        {
            InitializeComponent();
            maConnexion = new videoppe3_Dugas_Guilloteau_PereiraEntities1();
            /* le  bindingSource  bsVille est connecté à la table Ville de la BDD  via la chaîne de connexion */
            BSFilm.DataSource = maConnexion.film.ToList();

        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
