namespace Test
{
    partial class Consulta
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
            this.Lista = new System.Windows.Forms.ListView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(15, 51);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(773, 359);
            this.Lista.TabIndex = 3;
            this.Lista.UseCompatibleStateImageBehavior = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(650, 416);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(66, 22);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(578, 416);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(66, 22);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(506, 416);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(66, 22);
            this.BtnIncluir.TabIndex = 6;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(148, 25);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 20);
            this.BtnPesquisar.TabIndex = 7;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.Lista);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Controls.SetChildIndex(this.Lista, 0);
            this.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BtnExcluir, 0);
            this.Controls.SetChildIndex(this.BtnAlterar, 0);
            this.Controls.SetChildIndex(this.BtnIncluir, 0);
            this.Controls.SetChildIndex(this.BtnPesquisar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ListView Lista;
        protected System.Windows.Forms.Button BtnExcluir;
        protected System.Windows.Forms.Button BtnAlterar;
        protected System.Windows.Forms.Button BtnIncluir;
        protected System.Windows.Forms.Button BtnPesquisar;
    }
}