namespace VideoAndCo
{
    partial class FormRechercheGenre
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
            this.DGRechercheGenre = new System.Windows.Forms.DataGridView();
            this.idGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSRechercheGenre = new System.Windows.Forms.BindingSource(this.components);
            this.ComboIdGenre = new System.Windows.Forms.ComboBox();
            this.BSIdGenre = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboLibelleGenre = new System.Windows.Forms.ComboBox();
            this.BSLibelleGenre = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BSNomImage = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGRechercheGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSRechercheGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSIdGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSLibelleGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSNomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DGRechercheGenre
            // 
            this.DGRechercheGenre.AllowDrop = true;
            this.DGRechercheGenre.AutoGenerateColumns = false;
            this.DGRechercheGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGRechercheGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGRechercheGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRechercheGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGenreDataGridViewTextBoxColumn,
            this.libelleGenreDataGridViewTextBoxColumn,
            this.nomImageDataGridViewTextBoxColumn,
            this.supportDataGridViewTextBoxColumn});
            this.DGRechercheGenre.DataSource = this.BSRechercheGenre;
            this.DGRechercheGenre.Location = new System.Drawing.Point(292, 64);
            this.DGRechercheGenre.Name = "DGRechercheGenre";
            this.DGRechercheGenre.Size = new System.Drawing.Size(346, 59);
            this.DGRechercheGenre.TabIndex = 0;
            // 
            // idGenreDataGridViewTextBoxColumn
            // 
            this.idGenreDataGridViewTextBoxColumn.DataPropertyName = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idGenreDataGridViewTextBoxColumn.Name = "idGenreDataGridViewTextBoxColumn";
            // 
            // libelleGenreDataGridViewTextBoxColumn
            // 
            this.libelleGenreDataGridViewTextBoxColumn.DataPropertyName = "libelleGenre";
            this.libelleGenreDataGridViewTextBoxColumn.HeaderText = "Libellé";
            this.libelleGenreDataGridViewTextBoxColumn.Name = "libelleGenreDataGridViewTextBoxColumn";
            // 
            // nomImageDataGridViewTextBoxColumn
            // 
            this.nomImageDataGridViewTextBoxColumn.DataPropertyName = "nomImage";
            this.nomImageDataGridViewTextBoxColumn.HeaderText = "Lien image";
            this.nomImageDataGridViewTextBoxColumn.Name = "nomImageDataGridViewTextBoxColumn";
            // 
            // supportDataGridViewTextBoxColumn
            // 
            this.supportDataGridViewTextBoxColumn.DataPropertyName = "support";
            this.supportDataGridViewTextBoxColumn.HeaderText = "support";
            this.supportDataGridViewTextBoxColumn.Name = "supportDataGridViewTextBoxColumn";
            this.supportDataGridViewTextBoxColumn.Visible = false;
            // 
            // BSRechercheGenre
            // 
            this.BSRechercheGenre.DataSource = typeof(VideoAndCo.genre);
            // 
            // ComboIdGenre
            // 
            this.ComboIdGenre.AllowDrop = true;
            this.ComboIdGenre.DataSource = this.BSRechercheGenre;
            this.ComboIdGenre.DisplayMember = "idGenre";
            this.ComboIdGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboIdGenre.FormattingEnabled = true;
            this.ComboIdGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboIdGenre.Location = new System.Drawing.Point(12, 25);
            this.ComboIdGenre.Name = "ComboIdGenre";
            this.ComboIdGenre.Size = new System.Drawing.Size(121, 21);
            this.ComboIdGenre.TabIndex = 1;
            this.ComboIdGenre.ValueMember = "idGenre";
            this.ComboIdGenre.SelectedIndexChanged += new System.EventHandler(this.ComboIdGenre_SelectedIndexChanged);
            // 
            // BSIdGenre
            // 
            this.BSIdGenre.DataSource = typeof(VideoAndCo.genre);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recherche par ID:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recherche par le libellé :";
            // 
            // ComboLibelleGenre
            // 
            this.ComboLibelleGenre.DataSource = this.BSRechercheGenre;
            this.ComboLibelleGenre.DisplayMember = "libelleGenre";
            this.ComboLibelleGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboLibelleGenre.FormattingEnabled = true;
            this.ComboLibelleGenre.ItemHeight = 13;
            this.ComboLibelleGenre.Location = new System.Drawing.Point(12, 102);
            this.ComboLibelleGenre.Name = "ComboLibelleGenre";
            this.ComboLibelleGenre.Size = new System.Drawing.Size(121, 21);
            this.ComboLibelleGenre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recherche par nom de l\'image : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.BSRechercheGenre;
            this.comboBox1.DisplayMember = "nomImage";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "nomImage";
            // 
            // BSNomImage
            // 
            this.BSNomImage.DataSource = this.BSRechercheGenre;
            // 
            // FormRechercheGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboLibelleGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboIdGenre);
            this.Controls.Add(this.DGRechercheGenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRechercheGenre";
            this.Text = "FormRechercheGenre";
            ((System.ComponentModel.ISupportInitialize)(this.DGRechercheGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSRechercheGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSIdGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSLibelleGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSNomImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGRechercheGenre;
        private System.Windows.Forms.BindingSource BSRechercheGenre;
        private System.Windows.Forms.BindingSource BSIdGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource BSLibelleGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource BSNomImage;
        private System.Windows.Forms.ComboBox ComboLibelleGenre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox ComboIdGenre;
    }
}