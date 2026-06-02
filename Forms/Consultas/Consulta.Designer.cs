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
            this.Excluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Incluir = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
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
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(650, 416);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(66, 22);
            this.Excluir.TabIndex = 4;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(578, 416);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(66, 22);
            this.Alterar.TabIndex = 5;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            // 
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(506, 416);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(66, 22);
            this.Incluir.TabIndex = 6;
            this.Incluir.Text = "Incluir";
            this.Incluir.UseVisualStyleBackColor = true;
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(148, 25);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 20);
            this.Pesquisar.TabIndex = 7;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Lista);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Controls.SetChildIndex(this.Lista, 0);
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Excluir, 0);
            this.Controls.SetChildIndex(this.Alterar, 0);
            this.Controls.SetChildIndex(this.Incluir, 0);
            this.Controls.SetChildIndex(this.Pesquisar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ListView Lista;
        protected System.Windows.Forms.Button Excluir;
        protected System.Windows.Forms.Button Alterar;
        protected System.Windows.Forms.Button Incluir;
        protected System.Windows.Forms.Button Pesquisar;
    }
}