namespace Catalogodefilmes.View
{
    partial class Menu
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
            this.btnCadastrarFilme = new System.Windows.Forms.Button();
            this.btnCadastrarSerie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarFilme
            // 
            this.btnCadastrarFilme.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarFilme.Location = new System.Drawing.Point(130, 47);
            this.btnCadastrarFilme.Name = "btnCadastrarFilme";
            this.btnCadastrarFilme.Size = new System.Drawing.Size(356, 111);
            this.btnCadastrarFilme.TabIndex = 0;
            this.btnCadastrarFilme.Text = "cadastrar filme";
            this.btnCadastrarFilme.UseVisualStyleBackColor = true;
            this.btnCadastrarFilme.Click += new System.EventHandler(this.btnCadastrarFilme_Click);
            // 
            // btnCadastrarSerie
            // 
            this.btnCadastrarSerie.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarSerie.Location = new System.Drawing.Point(130, 224);
            this.btnCadastrarSerie.Name = "btnCadastrarSerie";
            this.btnCadastrarSerie.Size = new System.Drawing.Size(356, 114);
            this.btnCadastrarSerie.TabIndex = 1;
            this.btnCadastrarSerie.Text = "cadastrar série";
            this.btnCadastrarSerie.UseVisualStyleBackColor = true;
            this.btnCadastrarSerie.Click += new System.EventHandler(this.btnCadastrarSerie_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarSerie);
            this.Controls.Add(this.btnCadastrarFilme);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCadastrarFilme;
        private Button btnCadastrarSerie;
    }
}