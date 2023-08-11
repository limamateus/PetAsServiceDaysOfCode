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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTexto = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFavoritar = new System.Windows.Forms.Button();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFavoriteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PetAsServiceDaysOfCode.Properties.Resources.cat;
            this.pictureBox1.Location = new System.Drawing.Point(552, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbTexto);
            this.groupBox1.Controls.Add(this.lbTitulo);
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbTexto
            // 
            this.lbTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTexto.AutoSize = true;
            this.lbTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTexto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTexto.Location = new System.Drawing.Point(6, 52);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(337, 21);
            this.lbTexto.TabIndex = 2;
            this.lbTexto.Text = "Aqui voce encontra a lista de gatinhos favoritos";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(305, 19);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(144, 28);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Meus Favoritos";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clNome,
            this.clOrigem,
            this.clImageId,
            this.clFavoriteId});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV.Location = new System.Drawing.Point(3, 19);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowTemplate.Height = 25;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(492, 263);
            this.DGV.TabIndex = 3;
            this.DGV.Click += new System.EventHandler(this.DGV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV);
            this.groupBox2.Location = new System.Drawing.Point(9, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 285);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnFavoritar
            // 
            this.btnFavoritar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFavoritar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFavoritar.Location = new System.Drawing.Point(599, 366);
            this.btnFavoritar.Name = "btnFavoritar";
            this.btnFavoritar.Size = new System.Drawing.Size(85, 31);
            this.btnFavoritar.TabIndex = 19;
            this.btnFavoritar.Text = "Excluir";
            this.btnFavoritar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFavoritar.UseVisualStyleBackColor = true;
            this.btnFavoritar.Click += new System.EventHandler(this.btnFavoritar_Click);
            // 
            // clId
            // 
            this.clId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clId.HeaderText = "ID";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clNome
            // 
            this.clNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNome.HeaderText = "Nome da Raça";
            this.clNome.Name = "clNome";
            this.clNome.ReadOnly = true;
            // 
            // clOrigem
            // 
            this.clOrigem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clOrigem.HeaderText = "Origem";
            this.clOrigem.Name = "clOrigem";
            this.clOrigem.ReadOnly = true;
            // 
            // clImageId
            // 
            this.clImageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clImageId.HeaderText = "Imagem Id";
            this.clImageId.Name = "clImageId";
            this.clImageId.ReadOnly = true;
            // 
            // clFavoriteId
            // 
            this.clFavoriteId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clFavoriteId.HeaderText = "Favorito Id";
            this.clFavoriteId.Name = "clFavoriteId";
            this.clFavoriteId.ReadOnly = true;
            // 
            // ListaDeFavoritosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFavoritar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListaDeFavoritosUC";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.ListaDeFavoritosUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label lbTitulo;
        private Label lbTexto;
        private DataGridView DGV;
        private GroupBox groupBox2;
        private Button btnFavoritar;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clNome;
        private DataGridViewTextBoxColumn clOrigem;
        private DataGridViewTextBoxColumn clImageId;
        private DataGridViewTextBoxColumn clFavoriteId;
    }
}
