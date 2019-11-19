namespace VideoAndCo
{
    partial class FormAfficheFilm
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
            this.DGFilm = new System.Windows.Forms.DataGridView();
            this.idFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSFilm = new System.Windows.Forms.BindingSource(this.components);
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGFilm
            // 
            this.DGFilm.AutoGenerateColumns = false;
            this.DGFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFilmDataGridViewTextBoxColumn,
            this.dureeDataGridViewTextBoxColumn,
            this.idSupportDataGridViewTextBoxColumn,
            this.supportDataGridViewTextBoxColumn});
            this.DGFilm.DataSource = this.BSFilm;
            this.DGFilm.Location = new System.Drawing.Point(-4, 0);
            this.DGFilm.Name = "DGFilm";
            this.DGFilm.Size = new System.Drawing.Size(443, 447);
            this.DGFilm.TabIndex = 0;
            // 
            // idFilmDataGridViewTextBoxColumn
            // 
            this.idFilmDataGridViewTextBoxColumn.DataPropertyName = "idFilm";
            this.idFilmDataGridViewTextBoxColumn.HeaderText = "idFilm";
            this.idFilmDataGridViewTextBoxColumn.Name = "idFilmDataGridViewTextBoxColumn";
            // 
            // dureeDataGridViewTextBoxColumn
            // 
            this.dureeDataGridViewTextBoxColumn.DataPropertyName = "duree";
            this.dureeDataGridViewTextBoxColumn.HeaderText = "duree";
            this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
            // 
            // idSupportDataGridViewTextBoxColumn
            // 
            this.idSupportDataGridViewTextBoxColumn.DataPropertyName = "idSupport";
            this.idSupportDataGridViewTextBoxColumn.HeaderText = "idSupport";
            this.idSupportDataGridViewTextBoxColumn.Name = "idSupportDataGridViewTextBoxColumn";
            // 
            // supportDataGridViewTextBoxColumn
            // 
            this.supportDataGridViewTextBoxColumn.DataPropertyName = "support";
            this.supportDataGridViewTextBoxColumn.HeaderText = "support";
            this.supportDataGridViewTextBoxColumn.Name = "supportDataGridViewTextBoxColumn";
            // 
            // BSFilm
            // 
            this.BSFilm.DataSource = this.filmBindingSource;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataSource = typeof(VideoAndCo.film);
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 448);
            this.Controls.Add(this.DGFilm);
            this.Name = "FormFilm";
            this.Text = "FormFilm";
            ((System.ComponentModel.ISupportInitialize)(this.DGFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGFilm;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BSFilm;
    }
}