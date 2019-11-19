namespace VideoAndCo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.FichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.Recherche = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheGenre1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheSupport1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheClient1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheRefEmprunt = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheDatAbonnement = new System.Windows.Forms.ToolStripMenuItem();
            this.Compte = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteValid = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteVérif = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteFerm = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.Composant = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantGenreAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantGenreModif = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantFilmAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantFilmModif = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantSérie = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantSérieAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantSérieModif = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantSaison = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantSaisonAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantSaisonModif = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantClientAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.ComposantClientModif = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheClient = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheRéférenceEmprunt = new System.Windows.Forms.ToolStripMenuItem();
            this.RechercheDateAbonnement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier,
            this.Recherche,
            this.Compte,
            this.Composant});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Fichier
            // 
            this.Fichier.BackColor = System.Drawing.Color.Silver;
            this.Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FichierQuitter});
            this.Fichier.ForeColor = System.Drawing.Color.Black;
            this.Fichier.Name = "Fichier";
            this.Fichier.Size = new System.Drawing.Size(54, 20);
            this.Fichier.Text = "Fichier";
            // 
            // FichierQuitter
            // 
            this.FichierQuitter.Name = "FichierQuitter";
            this.FichierQuitter.Size = new System.Drawing.Size(180, 22);
            this.FichierQuitter.Text = "Quitter";
            // 
            // Recherche
            // 
            this.Recherche.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RechercheGenre1,
            this.RechercheSupport1,
            this.RechercheClient1,
            this.RechercheRefEmprunt,
            this.RechercheDatAbonnement});
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(74, 20);
            this.Recherche.Text = "Recherche";
            // 
            // RechercheGenre1
            // 
            this.RechercheGenre1.Name = "RechercheGenre1";
            this.RechercheGenre1.Size = new System.Drawing.Size(195, 22);
            this.RechercheGenre1.Text = "Par Genre ";
            // 
            // RechercheSupport1
            // 
            this.RechercheSupport1.Name = "RechercheSupport1";
            this.RechercheSupport1.Size = new System.Drawing.Size(195, 22);
            this.RechercheSupport1.Text = "Par Support";
            // 
            // RechercheClient1
            // 
            this.RechercheClient1.Name = "RechercheClient1";
            this.RechercheClient1.Size = new System.Drawing.Size(195, 22);
            this.RechercheClient1.Text = "Par Client";
            // 
            // RechercheRefEmprunt
            // 
            this.RechercheRefEmprunt.Name = "RechercheRefEmprunt";
            this.RechercheRefEmprunt.Size = new System.Drawing.Size(195, 22);
            this.RechercheRefEmprunt.Text = "Par Référence Emprunt";
            // 
            // RechercheDatAbonnement
            // 
            this.RechercheDatAbonnement.Name = "RechercheDatAbonnement";
            this.RechercheDatAbonnement.Size = new System.Drawing.Size(195, 22);
            this.RechercheDatAbonnement.Text = "Par Date Abonnement";
            // 
            // Compte
            // 
            this.Compte.BackColor = System.Drawing.Color.Silver;
            this.Compte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompteValid,
            this.CompteVérif,
            this.CompteFerm,
            this.CompteAjout});
            this.Compte.Name = "Compte";
            this.Compte.Size = new System.Drawing.Size(67, 20);
            this.Compte.Text = "Comptes";
            // 
            // CompteValid
            // 
            this.CompteValid.Name = "CompteValid";
            this.CompteValid.Size = new System.Drawing.Size(204, 22);
            this.CompteValid.Text = "Validation d\'un compte";
            // 
            // CompteVérif
            // 
            this.CompteVérif.Name = "CompteVérif";
            this.CompteVérif.Size = new System.Drawing.Size(204, 22);
            this.CompteVérif.Text = "Vérification d\'un compte";
            // 
            // CompteFerm
            // 
            this.CompteFerm.Name = "CompteFerm";
            this.CompteFerm.Size = new System.Drawing.Size(204, 22);
            this.CompteFerm.Text = "Fermeture d\'un compte";
            // 
            // CompteAjout
            // 
            this.CompteAjout.Name = "CompteAjout";
            this.CompteAjout.Size = new System.Drawing.Size(204, 22);
            this.CompteAjout.Text = "Ajout d\'un compte";
            // 
            // Composant
            // 
            this.Composant.BackColor = System.Drawing.Color.Silver;
            this.Composant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComposantGenre,
            this.ComposantFilm,
            this.ComposantSérie,
            this.ComposantSaison,
            this.ComposantClient});
            this.Composant.Name = "Composant";
            this.Composant.Size = new System.Drawing.Size(86, 20);
            this.Composant.Text = "Composants";
            // 
            // ComposantGenre
            // 
            this.ComposantGenre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComposantGenreAjout,
            this.ComposantGenreModif});
            this.ComposantGenre.Name = "ComposantGenre";
            this.ComposantGenre.Size = new System.Drawing.Size(180, 22);
            this.ComposantGenre.Text = "Genre";
            // 
            // ComposantGenreAjout
            // 
            this.ComposantGenreAjout.Name = "ComposantGenreAjout";
            this.ComposantGenreAjout.Size = new System.Drawing.Size(142, 22);
            this.ComposantGenreAjout.Text = "Ajout";
            // 
            // ComposantGenreModif
            // 
            this.ComposantGenreModif.Name = "ComposantGenreModif";
            this.ComposantGenreModif.Size = new System.Drawing.Size(142, 22);
            this.ComposantGenreModif.Text = "Modification";
            // 
            // ComposantFilm
            // 
            this.ComposantFilm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComposantFilmAjout,
            this.ComposantFilmModif});
            this.ComposantFilm.Name = "ComposantFilm";
            this.ComposantFilm.Size = new System.Drawing.Size(180, 22);
            this.ComposantFilm.Text = "Film";
            // 
            // ComposantFilmAjout
            // 
            this.ComposantFilmAjout.Name = "ComposantFilmAjout";
            this.ComposantFilmAjout.Size = new System.Drawing.Size(142, 22);
            this.ComposantFilmAjout.Text = "Ajout";
            this.ComposantFilmAjout.Click += new System.EventHandler(this.ComposantFilmAjout_Click);
            // 
            // ComposantFilmModif
            // 
            this.ComposantFilmModif.Name = "ComposantFilmModif";
            this.ComposantFilmModif.Size = new System.Drawing.Size(142, 22);
            this.ComposantFilmModif.Text = "Modification";
            // 
            // ComposantSérie
            // 
            this.ComposantSérie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComposantSérieAjout,
            this.ComposantSérieModif});
            this.ComposantSérie.Name = "ComposantSérie";
            this.ComposantSérie.Size = new System.Drawing.Size(180, 22);
            this.ComposantSérie.Text = "Série";
            // 
            // ComposantSérieAjout
            // 
            this.ComposantSérieAjout.Name = "ComposantSérieAjout";
            this.ComposantSérieAjout.Size = new System.Drawing.Size(142, 22);
            this.ComposantSérieAjout.Text = "Ajout";
            // 
            // ComposantSérieModif
            // 
            this.ComposantSérieModif.Name = "ComposantSérieModif";
            this.ComposantSérieModif.Size = new System.Drawing.Size(142, 22);
            this.ComposantSérieModif.Text = "Modification";
            // 
            // ComposantSaison
            // 
            this.ComposantSaison.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComposantSaisonAjout,
            this.ComposantSaisonModif});
            this.ComposantSaison.Name = "ComposantSaison";
            this.ComposantSaison.Size = new System.Drawing.Size(180, 22);
            this.ComposantSaison.Text = "Saison";
            // 
            // ComposantSaisonAjout
            // 
            this.ComposantSaisonAjout.Name = "ComposantSaisonAjout";
            this.ComposantSaisonAjout.Size = new System.Drawing.Size(142, 22);
            this.ComposantSaisonAjout.Text = "Ajout";
            // 
            // ComposantSaisonModif
            // 
            this.ComposantSaisonModif.Name = "ComposantSaisonModif";
            this.ComposantSaisonModif.Size = new System.Drawing.Size(142, 22);
            this.ComposantSaisonModif.Text = "Modification";
            // 
            // ComposantClient
            // 
            this.ComposantClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComposantClientAjout,
            this.ComposantClientModif});
            this.ComposantClient.Name = "ComposantClient";
            this.ComposantClient.Size = new System.Drawing.Size(180, 22);
            this.ComposantClient.Text = "Client";
            // 
            // ComposantClientAjout
            // 
            this.ComposantClientAjout.Name = "ComposantClientAjout";
            this.ComposantClientAjout.Size = new System.Drawing.Size(180, 22);
            this.ComposantClientAjout.Text = "Ajout";
            this.ComposantClientAjout.Click += new System.EventHandler(this.ComposantClientAjout_Click);
            // 
            // ComposantClientModif
            // 
            this.ComposantClientModif.Name = "ComposantClientModif";
            this.ComposantClientModif.Size = new System.Drawing.Size(180, 22);
            this.ComposantClientModif.Text = "Modification";
            // 
            // RechercheGenre
            // 
            this.RechercheGenre.Name = "RechercheGenre";
            this.RechercheGenre.Size = new System.Drawing.Size(195, 22);
            this.RechercheGenre.Text = "Par Genre";
            // 
            // RechercheSupport
            // 
            this.RechercheSupport.Name = "RechercheSupport";
            this.RechercheSupport.Size = new System.Drawing.Size(195, 22);
            this.RechercheSupport.Text = "Par Support";
            // 
            // RechercheClient
            // 
            this.RechercheClient.Name = "RechercheClient";
            this.RechercheClient.Size = new System.Drawing.Size(195, 22);
            this.RechercheClient.Text = "Par Client ";
            // 
            // RechercheRéférenceEmprunt
            // 
            this.RechercheRéférenceEmprunt.Name = "RechercheRéférenceEmprunt";
            this.RechercheRéférenceEmprunt.Size = new System.Drawing.Size(195, 22);
            this.RechercheRéférenceEmprunt.Text = "Par Référence Emprunt";
            // 
            // RechercheDateAbonnement
            // 
            this.RechercheDateAbonnement.Name = "RechercheDateAbonnement";
            this.RechercheDateAbonnement.Size = new System.Drawing.Size(195, 22);
            this.RechercheDateAbonnement.Text = "Par Date Abonnement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Page d\'accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Fichier;
        private System.Windows.Forms.ToolStripMenuItem RechercheGenre;
        private System.Windows.Forms.ToolStripMenuItem RechercheSupport;
        private System.Windows.Forms.ToolStripMenuItem RechercheClient;
        private System.Windows.Forms.ToolStripMenuItem RechercheRéférenceEmprunt;
        private System.Windows.Forms.ToolStripMenuItem RechercheDateAbonnement;
        private System.Windows.Forms.ToolStripMenuItem Compte;
        private System.Windows.Forms.ToolStripMenuItem CompteValid;
        private System.Windows.Forms.ToolStripMenuItem CompteVérif;
        private System.Windows.Forms.ToolStripMenuItem CompteFerm;
        private System.Windows.Forms.ToolStripMenuItem CompteAjout;
        private System.Windows.Forms.ToolStripMenuItem Composant;
        private System.Windows.Forms.ToolStripMenuItem ComposantGenre;
        private System.Windows.Forms.ToolStripMenuItem ComposantGenreAjout;
        private System.Windows.Forms.ToolStripMenuItem ComposantGenreModif;
        private System.Windows.Forms.ToolStripMenuItem ComposantFilm;
        private System.Windows.Forms.ToolStripMenuItem ComposantFilmAjout;
        private System.Windows.Forms.ToolStripMenuItem ComposantFilmModif;
        private System.Windows.Forms.ToolStripMenuItem ComposantSérie;
        private System.Windows.Forms.ToolStripMenuItem ComposantSérieAjout;
        private System.Windows.Forms.ToolStripMenuItem ComposantSérieModif;
        private System.Windows.Forms.ToolStripMenuItem ComposantSaison;
        private System.Windows.Forms.ToolStripMenuItem ComposantSaisonAjout;
        private System.Windows.Forms.ToolStripMenuItem ComposantSaisonModif;
        private System.Windows.Forms.ToolStripMenuItem ComposantClient;
        private System.Windows.Forms.ToolStripMenuItem ComposantClientAjout;
        private System.Windows.Forms.ToolStripMenuItem ComposantClientModif;
        private System.Windows.Forms.ToolStripMenuItem FichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem Recherche;
        private System.Windows.Forms.ToolStripMenuItem RechercheGenre1;
        private System.Windows.Forms.ToolStripMenuItem RechercheSupport1;
        private System.Windows.Forms.ToolStripMenuItem RechercheClient1;
        private System.Windows.Forms.ToolStripMenuItem RechercheRefEmprunt;
        private System.Windows.Forms.ToolStripMenuItem RechercheDatAbonnement;
    }
}

