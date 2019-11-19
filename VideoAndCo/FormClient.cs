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
    public partial class FormClient : Form
    {
        private videoppe3_Dugas_Guilloteau_PereiraEntities1 maConnexion;
        public FormClient()
        {
            InitializeComponent();
            maConnexion = new videoppe3_Dugas_Guilloteau_PereiraEntities1();
            /* le  bindingSource  bsVille est connecté à la table Ville de la BDD  via la chaîne de connexion */
            BSClient.DataSource = maConnexion.client.ToList();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
