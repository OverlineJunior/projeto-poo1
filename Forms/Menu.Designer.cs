namespace Test
{
    partial class Menu
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultasPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultasEstados = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultasCidades = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultasPaises,
            this.btnConsultasEstados,
            this.btnConsultasCidades});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Consultas";
            // 
            // btnConsultasPaises
            // 
            this.btnConsultasPaises.Name = "btnConsultasPaises";
            this.btnConsultasPaises.Size = new System.Drawing.Size(180, 22);
            this.btnConsultasPaises.Text = "Países";
            this.btnConsultasPaises.Click += new System.EventHandler(this.btnConsultasPaises_Click);
            // 
            // btnConsultasEstados
            // 
            this.btnConsultasEstados.Name = "btnConsultasEstados";
            this.btnConsultasEstados.Size = new System.Drawing.Size(180, 22);
            this.btnConsultasEstados.Text = "Estados";
            this.btnConsultasEstados.Click += new System.EventHandler(this.btnConsultasEstados_Click);
            // 
            // btnConsultasCidades
            // 
            this.btnConsultasCidades.Name = "btnConsultasCidades";
            this.btnConsultasCidades.Size = new System.Drawing.Size(180, 22);
            this.btnConsultasCidades.Text = "Cidades";
            this.btnConsultasCidades.Click += new System.EventHandler(this.btnConsultasCidades_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(722, 416);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(66, 22);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConsultasPaises;
        private System.Windows.Forms.ToolStripMenuItem btnConsultasEstados;
        private System.Windows.Forms.ToolStripMenuItem btnConsultasCidades;
        protected System.Windows.Forms.Button btnSair;
    }
}

