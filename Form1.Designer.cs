namespace FormAppMusic
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
            this.GVMusic = new System.Windows.Forms.DataGridView();
            this.BTNMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // GVMusic
            // 
            this.GVMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVMusic.Location = new System.Drawing.Point(49, 48);
            this.GVMusic.Name = "GVMusic";
            this.GVMusic.RowHeadersWidth = 62;
            this.GVMusic.RowTemplate.Height = 28;
            this.GVMusic.Size = new System.Drawing.Size(240, 150);
            this.GVMusic.TabIndex = 0;
            this.GVMusic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTNMusic
            // 
            this.BTNMusic.Location = new System.Drawing.Point(59, 282);
            this.BTNMusic.Name = "BTNMusic";
            this.BTNMusic.Size = new System.Drawing.Size(75, 44);
            this.BTNMusic.TabIndex = 1;
            this.BTNMusic.Text = "Valider";
            this.BTNMusic.UseVisualStyleBackColor = true;
            this.BTNMusic.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 660);
            this.Controls.Add(this.BTNMusic);
            this.Controls.Add(this.GVMusic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GVMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVMusic;
        private System.Windows.Forms.Button BTNMusic;
    }
}

