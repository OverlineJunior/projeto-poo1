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
            this.btnCadastrosPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrosEstados = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrosCidades = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCadastrosSair = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnCadastrosPaises,
            this.btnCadastrosEstados,
            this.btnCadastrosCidades,
            this.toolStripSeparator1,
            this.btnCadastrosSair});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // btnCadastrosPaises
            // 
            this.btnCadastrosPaises.Name = "btnCadastrosPaises";
            this.btnCadastrosPaises.Size = new System.Drawing.Size(180, 22);
            this.btnCadastrosPaises.Text = "Países";
            this.btnCadastrosPaises.Click += new System.EventHandler(this.btnCadastrosPaises_Click);
            // 
            // btnCadastrosEstados
            // 
            this.btnCadastrosEstados.Name = "btnCadastrosEstados";
            this.btnCadastrosEstados.Size = new System.Drawing.Size(180, 22);
            this.btnCadastrosEstados.Text = "Estados";
            this.btnCadastrosEstados.Click += new System.EventHandler(this.btnCadastrosEstados_Click);
            // 
            // btnCadastrosCidades
            // 
            this.btnCadastrosCidades.Name = "btnCadastrosCidades";
            this.btnCadastrosCidades.Size = new System.Drawing.Size(180, 22);
            this.btnCadastrosCidades.Text = "Cidades";
            this.btnCadastrosCidades.Click += new System.EventHandler(this.btnCadastrosCidades_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnCadastrosSair
            // 
            this.btnCadastrosSair.Name = "btnCadastrosSair";
            this.btnCadastrosSair.Size = new System.Drawing.Size(180, 22);
            this.btnCadastrosSair.Text = "Sair";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem btnCadastrosPaises;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrosEstados;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrosCidades;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrosSair;
    }
}

