namespace PetAsServiceDaysOfCode
{
    partial class BuscaRacas
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
            this.gBTexto = new System.Windows.Forms.GroupBox();
            this.lbTexto = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBOrigem = new System.Windows.Forms.GroupBox();
            this.gBDescricao = new System.Windows.Forms.GroupBox();
            this.gBTemperament = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CB = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnFavoritar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTemperament = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gBTexto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBOrigem.SuspendLayout();
            this.gBDescricao.SuspendLayout();
            this.gBTemperament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBTexto
            // 
            this.gBTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBTexto.Controls.Add(this.lbTexto);
            this.gBTexto.Controls.Add(this.lbTitulo);
            this.gBTexto.Location = new System.Drawing.Point(3, 3);
            this.gBTexto.Name = "gBTexto";
            this.gBTexto.Size = new System.Drawing.Size(794, 118);
            this.gBTexto.TabIndex = 1;
            this.gBTexto.TabStop = false;
            // 
            // lbTexto
            // 
            this.lbTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTexto.AutoSize = true;
            this.lbTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTexto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTexto.Location = new System.Drawing.Point(78, 61);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(52, 21);
            this.lbTexto.TabIndex = 1;
            this.lbTexto.Text = "label2";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(286, 19);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(236, 28);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Encontra sua raça favorita";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gBOrigem);
            this.groupBox1.Controls.Add(this.gBDescricao);
            this.groupBox1.Controls.Add(this.gBTemperament);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.CB);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Location = new System.Drawing.Point(3, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gBOrigem
            // 
            this.gBOrigem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gBOrigem.Controls.Add(this.txtOrigem);
            this.gBOrigem.Location = new System.Drawing.Point(31, 124);
            this.gBOrigem.Name = "gBOrigem";
            this.gBOrigem.Size = new System.Drawing.Size(491, 56);
            this.gBOrigem.TabIndex = 14;
            this.gBOrigem.TabStop = false;
            this.gBOrigem.Text = "Origem";
            // 
            // gBDescricao
            // 
            this.gBDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gBDescricao.Controls.Add(this.txtDescricao);
            this.gBDescricao.Location = new System.Drawing.Point(31, 186);
            this.gBDescricao.Name = "gBDescricao";
            this.gBDescricao.Size = new System.Drawing.Size(491, 58);
            this.gBDescricao.TabIndex = 13;
            this.gBDescricao.TabStop = false;
            this.gBDescricao.Text = "Descrição";
            // 
            // gBTemperament
            // 
            this.gBTemperament.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gBTemperament.Controls.Add(this.txtTemperament);
            this.gBTemperament.Location = new System.Drawing.Point(31, 60);
            this.gBTemperament.Name = "gBTemperament";
            this.gBTemperament.Size = new System.Drawing.Size(491, 58);
            this.gBTemperament.TabIndex = 12;
            this.gBTemperament.TabStop = false;
            this.gBTemperament.Text = "Temperament";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(564, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // CB
            // 
            this.CB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(151, 15);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(200, 23);
            this.CB.TabIndex = 3;
            this.CB.SelectedValueChanged += new System.EventHandler(this.CB_SelectedValueChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(31, 19);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(91, 19);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Raça do Gato";
            // 
            // btnFavoritar
            // 
            this.btnFavoritar.Location = new System.Drawing.Point(636, 388);
            this.btnFavoritar.Name = "btnFavoritar";
            this.btnFavoritar.Size = new System.Drawing.Size(103, 23);
            this.btnFavoritar.TabIndex = 18;
            this.btnFavoritar.Text = "btnFavoritar";
            this.btnFavoritar.UseVisualStyleBackColor = true;
            this.btnFavoritar.Click += new System.EventHandler(this.btnFavoritar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 388);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTemperament
            // 
            this.txtTemperament.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemperament.Location = new System.Drawing.Point(17, 22);
            this.txtTemperament.Multiline = true;
            this.txtTemperament.Name = "txtTemperament";
            this.txtTemperament.Size = new System.Drawing.Size(456, 23);
            this.txtTemperament.TabIndex = 0;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigem.Location = new System.Drawing.Point(17, 17);
            this.txtOrigem.Multiline = true;
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(456, 23);
            this.txtOrigem.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(17, 18);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(456, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // BuscaRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFavoritar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBTexto);
            this.Name = "BuscaRacas";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.BuscaRacas_Load);
            this.gBTexto.ResumeLayout(false);
            this.gBTexto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBOrigem.ResumeLayout(false);
            this.gBOrigem.PerformLayout();
            this.gBDescricao.ResumeLayout(false);
            this.gBDescricao.PerformLayout();
            this.gBTemperament.ResumeLayout(false);
            this.gBTemperament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gBTexto;
        private Label lbTexto;
        private Label lbTitulo;
        private GroupBox groupBox1;
        private ComboBox CB;
        private Label lb1;
        private PictureBox pictureBox1;
        private Button btnFavoritar;
        private Button btnBuscar;
        private GroupBox gBTemperament;
        private GroupBox gBOrigem;
        private GroupBox gBDescricao;
        private TextBox txtOrigem;
        private TextBox txtDescricao;
        private TextBox txtTemperament;
    }
}
