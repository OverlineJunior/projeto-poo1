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
            this.BtnCadastrosPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCadastrosEstados = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCadastrosCidades = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCadastrosSair = new System.Windows.Forms.ToolStripMenuItem();
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
            this.BtnCadastrosPaises,
            this.BtnCadastrosEstados,
            this.BtnCadastrosCidades,
            this.toolStripSeparator1,
            this.BtnCadastrosSair});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // BtnCadastrosPaises
            // 
            this.BtnCadastrosPaises.Name = "BtnCadastrosPaises";
            this.BtnCadastrosPaises.Size = new System.Drawing.Size(180, 22);
            this.BtnCadastrosPaises.Text = "Países";
            // 
            // BtnCadastrosEstados
            // 
            this.BtnCadastrosEstados.Name = "BtnCadastrosEstados";
            this.BtnCadastrosEstados.Size = new System.Drawing.Size(180, 22);
            this.BtnCadastrosEstados.Text = "Estados";
            // 
            // BtnCadastrosCidades
            // 
            this.BtnCadastrosCidades.Name = "BtnCadastrosCidades";
            this.BtnCadastrosCidades.Size = new System.Drawing.Size(180, 22);
            this.BtnCadastrosCidades.Text = "Cidades";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // BtnCadastrosSair
            // 
            this.BtnCadastrosSair.Name = "BtnCadastrosSair";
            this.BtnCadastrosSair.Size = new System.Drawing.Size(180, 22);
            this.BtnCadastrosSair.Text = "Sair";
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
        private System.Windows.Forms.ToolStripMenuItem BtnCadastrosPaises;
        private System.Windows.Forms.ToolStripMenuItem BtnCadastrosEstados;
        private System.Windows.Forms.ToolStripMenuItem BtnCadastrosCidades;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BtnCadastrosSair;
    }
}

