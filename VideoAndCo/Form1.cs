﻿using System;
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
            FormFilm ffilme= new FormFilm(); //Rôle de l’instruction ?
            ffilme.Show(); //Rôle de l’instruction ?

        }

        private void ComposantSaisonAjout_Click(object sender, EventArgs e)
        {
            FormSaison fsaison = new FormSaison(); //Rôle de l’instruction ?
            fsaison.Show(); //Rôle de l’instruction ?
        }
    }
}
