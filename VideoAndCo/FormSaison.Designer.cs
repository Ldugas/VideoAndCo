namespace VideoAndCo
{
    partial class FormSaison
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
            this.DGSaison = new System.Windows.Forms.DataGridView();
            this.BSSaison = new System.Windows.Forms.BindingSource(this.components);
            this.idSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSaisonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeSaisonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrEpisodesPrevusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGSaison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSSaison)).BeginInit();
            this.SuspendLayout();
            // 
            // DGSaison
            // 
            this.DGSaison.AutoGenerateColumns = false;
            this.DGSaison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSaison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSerieDataGridViewTextBoxColumn,
            this.numSaisonDataGridViewTextBoxColumn,
            this.anneeSaisonDataGridViewTextBoxColumn,
            this.nbrEpisodesPrevusDataGridViewTextBoxColumn,
            this.episodeDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn});
            this.DGSaison.DataSource = this.BSSaison;
            this.DGSaison.Location = new System.Drawing.Point(272, 136);
            this.DGSaison.Name = "DGSaison";
            this.DGSaison.Size = new System.Drawing.Size(240, 150);
            this.DGSaison.TabIndex = 0;
            // 
            // BSSaison
            // 
            this.BSSaison.DataSource = typeof(VideoAndCo.saison);
            // 
            // idSerieDataGridViewTextBoxColumn
            // 
            this.idSerieDataGridViewTextBoxColumn.DataPropertyName = "idSerie";
            this.idSerieDataGridViewTextBoxColumn.HeaderText = "idSerie";
            this.idSerieDataGridViewTextBoxColumn.Name = "idSerieDataGridViewTextBoxColumn";
            // 
            // numSaisonDataGridViewTextBoxColumn
            // 
            this.numSaisonDataGridViewTextBoxColumn.DataPropertyName = "numSaison";
            this.numSaisonDataGridViewTextBoxColumn.HeaderText = "numSaison";
            this.numSaisonDataGridViewTextBoxColumn.Name = "numSaisonDataGridViewTextBoxColumn";
            // 
            // anneeSaisonDataGridViewTextBoxColumn
            // 
            this.anneeSaisonDataGridViewTextBoxColumn.DataPropertyName = "anneeSaison";
            this.anneeSaisonDataGridViewTextBoxColumn.HeaderText = "anneeSaison";
            this.anneeSaisonDataGridViewTextBoxColumn.Name = "anneeSaisonDataGridViewTextBoxColumn";
            // 
            // nbrEpisodesPrevusDataGridViewTextBoxColumn
            // 
            this.nbrEpisodesPrevusDataGridViewTextBoxColumn.DataPropertyName = "nbrEpisodesPrevus";
            this.nbrEpisodesPrevusDataGridViewTextBoxColumn.HeaderText = "nbrEpisodesPrevus";
            this.nbrEpisodesPrevusDataGridViewTextBoxColumn.Name = "nbrEpisodesPrevusDataGridViewTextBoxColumn";
            // 
            // episodeDataGridViewTextBoxColumn
            // 
            this.episodeDataGridViewTextBoxColumn.DataPropertyName = "episode";
            this.episodeDataGridViewTextBoxColumn.HeaderText = "episode";
            this.episodeDataGridViewTextBoxColumn.Name = "episodeDataGridViewTextBoxColumn";
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            // 
            // FormSaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGSaison);
            this.Name = "FormSaison";
            this.Text = "FormSaison";
            ((System.ComponentModel.ISupportInitialize)(this.DGSaison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSSaison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGSaison;
        private System.Windows.Forms.BindingSource BSSaison;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSaisonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeSaisonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrEpisodesPrevusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
    }
}