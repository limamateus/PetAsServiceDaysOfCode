namespace PetAsServiceDaysOfCode
{
    partial class BemVindo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BemVindo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarRaçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusFavoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOriginal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarRaçasToolStripMenuItem,
            this.meusFavoritosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarRaçasToolStripMenuItem
            // 
            this.buscarRaçasToolStripMenuItem.Name = "buscarRaçasToolStripMenuItem";
            this.buscarRaçasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.buscarRaçasToolStripMenuItem.Text = "Buscar Raças";
            this.buscarRaçasToolStripMenuItem.Click += new System.EventHandler(this.buscarRaçasToolStripMenuItem_Click);
            // 
            // meusFavoritosToolStripMenuItem
            // 
            this.meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            this.meusFavoritosToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            this.meusFavoritosToolStripMenuItem.Click += new System.EventHandler(this.meusFavoritosToolStripMenuItem_Click);
            // 
            // pOriginal
            // 
            this.pOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pOriginal.AutoScroll = true;
            this.pOriginal.AutoSize = true;
            this.pOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOriginal.Location = new System.Drawing.Point(0, 24);
            this.pOriginal.Name = "pOriginal";
            this.pOriginal.Size = new System.Drawing.Size(800, 426);
            this.pOriginal.TabIndex = 1;
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pOriginal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "BemVindo";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo ao Cat As Serices";
            this.Load += new System.EventHandler(this.BemVindo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private ToolStripMenuItem meusFavoritosToolStripMenuItem;
        public Panel pOriginal;
    }
}