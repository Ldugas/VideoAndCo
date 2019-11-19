namespace VideoAndCo
{
    partial class FormModifFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifFilm));
            this.BNFilm = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PBImageFilm = new System.Windows.Forms.PictureBox();
            this.LabNomFilm = new System.Windows.Forms.Label();
            this.LabDuree = new System.Windows.Forms.Label();
            this.LabRealisateur = new System.Windows.Forms.Label();
            this.TBNomFilm = new System.Windows.Forms.TextBox();
            this.TBDuree = new System.Windows.Forms.TextBox();
            this.TBRealisateur = new System.Windows.Forms.TextBox();
            this.BSFilm = new System.Windows.Forms.BindingSource(this.components);
            this.BSUnFilm = new System.Windows.Forms.BindingSource(this.components);
            this.TBGenre = new System.Windows.Forms.TextBox();
            this.LabGenre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BNFilm)).BeginInit();
            this.BNFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSUnFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // BNFilm
            // 
            this.BNFilm.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BNFilm.BindingSource = this.BSFilm;
            this.BNFilm.CountItem = this.bindingNavigatorCountItem;
            this.BNFilm.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BNFilm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.BNFilm.Location = new System.Drawing.Point(0, 0);
            this.BNFilm.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BNFilm.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BNFilm.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BNFilm.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BNFilm.Name = "BNFilm";
            this.BNFilm.PositionItem = this.bindingNavigatorPositionItem;
            this.BNFilm.Size = new System.Drawing.Size(800, 25);
            this.BNFilm.TabIndex = 0;
            this.BNFilm.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PBImageFilm
            // 
            this.PBImageFilm.Location = new System.Drawing.Point(24, 75);
            this.PBImageFilm.Name = "PBImageFilm";
            this.PBImageFilm.Size = new System.Drawing.Size(365, 328);
            this.PBImageFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImageFilm.TabIndex = 1;
            this.PBImageFilm.TabStop = false;
            // 
            // LabNomFilm
            // 
            this.LabNomFilm.AutoSize = true;
            this.LabNomFilm.Location = new System.Drawing.Point(405, 84);
            this.LabNomFilm.Name = "LabNomFilm";
            this.LabNomFilm.Size = new System.Drawing.Size(34, 13);
            this.LabNomFilm.TabIndex = 2;
            this.LabNomFilm.Text = "Titre :";
            // 
            // LabDuree
            // 
            this.LabDuree.AutoSize = true;
            this.LabDuree.Location = new System.Drawing.Point(405, 160);
            this.LabDuree.Name = "LabDuree";
            this.LabDuree.Size = new System.Drawing.Size(45, 13);
            this.LabDuree.TabIndex = 3;
            this.LabDuree.Text = "Durée : ";
            // 
            // LabRealisateur
            // 
            this.LabRealisateur.AutoSize = true;
            this.LabRealisateur.Location = new System.Drawing.Point(405, 121);
            this.LabRealisateur.Name = "LabRealisateur";
            this.LabRealisateur.Size = new System.Drawing.Size(66, 13);
            this.LabRealisateur.TabIndex = 4;
            this.LabRealisateur.Text = "Réalisateur :";
            // 
            // TBNomFilm
            // 
            this.TBNomFilm.Location = new System.Drawing.Point(496, 84);
            this.TBNomFilm.Name = "TBNomFilm";
            this.TBNomFilm.Size = new System.Drawing.Size(264, 20);
            this.TBNomFilm.TabIndex = 5;
            // 
            // TBDuree
            // 
            this.TBDuree.Location = new System.Drawing.Point(496, 157);
            this.TBDuree.Name = "TBDuree";
            this.TBDuree.Size = new System.Drawing.Size(264, 20);
            this.TBDuree.TabIndex = 6;
            // 
            // TBRealisateur
            // 
            this.TBRealisateur.Location = new System.Drawing.Point(496, 118);
            this.TBRealisateur.Name = "TBRealisateur";
            this.TBRealisateur.Size = new System.Drawing.Size(264, 20);
            this.TBRealisateur.TabIndex = 7;
            // 
            // BSFilm
            // 
            this.BSFilm.DataSource = typeof(VideoAndCo.film);
            this.BSFilm.CurrentChanged += new System.EventHandler(this.BSFilm_CurrentChanged);
            // 
            // BSUnFilm
            // 
            this.BSUnFilm.DataSource = typeof(VideoAndCo.film);
            // 
            // TBGenre
            // 
            this.TBGenre.Location = new System.Drawing.Point(496, 201);
            this.TBGenre.Name = "TBGenre";
            this.TBGenre.Size = new System.Drawing.Size(264, 20);
            this.TBGenre.TabIndex = 9;
            // 
            // LabGenre
            // 
            this.LabGenre.AutoSize = true;
            this.LabGenre.Location = new System.Drawing.Point(405, 204);
            this.LabGenre.Name = "LabGenre";
            this.LabGenre.Size = new System.Drawing.Size(42, 13);
            this.LabGenre.TabIndex = 8;
            this.LabGenre.Text = "Genre :";
            // 
            // FormModifFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBGenre);
            this.Controls.Add(this.LabGenre);
            this.Controls.Add(this.TBRealisateur);
            this.Controls.Add(this.TBDuree);
            this.Controls.Add(this.TBNomFilm);
            this.Controls.Add(this.LabRealisateur);
            this.Controls.Add(this.LabDuree);
            this.Controls.Add(this.LabNomFilm);
            this.Controls.Add(this.PBImageFilm);
            this.Controls.Add(this.BNFilm);
            this.Name = "FormModifFilm";
            this.Text = "FormModifFilm";
            ((System.ComponentModel.ISupportInitialize)(this.BNFilm)).EndInit();
            this.BNFilm.ResumeLayout(false);
            this.BNFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSUnFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator BNFilm;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.PictureBox PBImageFilm;
        private System.Windows.Forms.BindingSource BSUnFilm;
        private System.Windows.Forms.Label LabNomFilm;
        private System.Windows.Forms.Label LabDuree;
        private System.Windows.Forms.Label LabRealisateur;
        private System.Windows.Forms.TextBox TBNomFilm;
        private System.Windows.Forms.TextBox TBDuree;
        private System.Windows.Forms.TextBox TBRealisateur;
        private System.Windows.Forms.BindingSource BSFilm;
        private System.Windows.Forms.TextBox TBGenre;
        private System.Windows.Forms.Label LabGenre;
    }
}