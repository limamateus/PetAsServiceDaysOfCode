namespace PetAsServiceDaysOfCode
{
    partial class ListaDeFavoritosUC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LV = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LV.Location = new System.Drawing.Point(42, 13);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(176, 391);
            this.LV.TabIndex = 0;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.View = System.Windows.Forms.View.List;
            this.LV.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LV_ColumnClick);
            this.LV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LV_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PetAsServiceDaysOfCode.Properties.Resources.cat;
            this.pictureBox1.Location = new System.Drawing.Point(471, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ListaDeFavoritosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LV);
            this.Name = "ListaDeFavoritosUC";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.ListaDeFavoritosUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView LV;
        private PictureBox pictureBox1;
    }
}
