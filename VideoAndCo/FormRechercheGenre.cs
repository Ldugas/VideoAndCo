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
    public partial class FormRechercheGenre : Form
    {
        private videoppe3_Dugas_Guilloteau_PereiraEntities1 maConnexion;
        public FormRechercheGenre()
        {
            InitializeComponent();
            maConnexion = new videoppe3_Dugas_Guilloteau_PereiraEntities1();
            BSRechercheGenre.DataSource = maConnexion.genre.ToList();


        }

        private void ComboIdGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }




        //maConnexion = new videoppe3_Dugas_Guilloteau_PereiraEntities1();
        //BSRechercheGenre.DataSource = maConnexion.genre.ToList();
        //BSIdGenre.DataSource = maConnexion.genre.ToList();
        //genre vcurrent = (genre)ComboIdGenre.SelectedItem;
        //var filterData = maConnexion.genre.ToList()
        //  .Where(x => x.idGenre == vcurrent.idGenre);

        //BSRechercheGenre.DataSource = filterData;
        //DGRechercheGenre.DataSource = BSRechercheGenre;
    }

      
}

