namespace Catalogodefilmes.View
{
    partial class TelaCadastroSerie
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeSerie = new System.Windows.Forms.Label();
            this.lblTemporadasSerie = new System.Windows.Forms.Label();
            this.lblGeneroSerie = new System.Windows.Forms.Label();
            this.lblEstreiaSerie = new System.Windows.Forms.Label();
            this.txtNomeSerie = new System.Windows.Forms.TextBox();
            this.txtTemporadasSerie = new System.Windows.Forms.TextBox();
            this.txtEstreiaSerie = new System.Windows.Forms.TextBox();
            this.comboboxGeneroSerie = new System.Windows.Forms.ComboBox();
            this.lblCanalStreaming = new System.Windows.Forms.Label();
            this.txtCanalStreaming = new System.Windows.Forms.TextBox();
            this.btnEnviarSerie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro da serie";
            // 
            // lblNomeSerie
            // 
            this.lblNomeSerie.AutoSize = true;
            this.lblNomeSerie.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeSerie.Location = new System.Drawing.Point(51, 92);
            this.lblNomeSerie.Name = "lblNomeSerie";
            this.lblNomeSerie.Size = new System.Drawing.Size(74, 23);
            this.lblNomeSerie.TabIndex = 1;
            this.lblNomeSerie.Text = "Serie:";
            // 
            // lblTemporadasSerie
            // 
            this.lblTemporadasSerie.AutoSize = true;
            this.lblTemporadasSerie.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTemporadasSerie.Location = new System.Drawing.Point(51, 180);
            this.lblTemporadasSerie.Name = "lblTemporadasSerie";
            this.lblTemporadasSerie.Size = new System.Drawing.Size(154, 23);
            this.lblTemporadasSerie.TabIndex = 2;
            this.lblTemporadasSerie.Text = "temporadas:";
            // 
            // lblGeneroSerie
            // 
            this.lblGeneroSerie.AutoSize = true;
            this.lblGeneroSerie.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGeneroSerie.Location = new System.Drawing.Point(292, 180);
            this.lblGeneroSerie.Name = "lblGeneroSerie";
            this.lblGeneroSerie.Size = new System.Drawing.Size(97, 23);
            this.lblGeneroSerie.TabIndex = 3;
            this.lblGeneroSerie.Text = "genero:";
            // 
            // lblEstreiaSerie
            // 
            this.lblEstreiaSerie.AutoSize = true;
            this.lblEstreiaSerie.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstreiaSerie.Location = new System.Drawing.Point(292, 92);
            this.lblEstreiaSerie.Name = "lblEstreiaSerie";
            this.lblEstreiaSerie.Size = new System.Drawing.Size(101, 23);
            this.lblEstreiaSerie.TabIndex = 4;
            this.lblEstreiaSerie.Text = "Estréia:";
            // 
            // txtNomeSerie
            // 
            this.txtNomeSerie.Location = new System.Drawing.Point(51, 131);
            this.txtNomeSerie.Name = "txtNomeSerie";
            this.txtNomeSerie.Size = new System.Drawing.Size(199, 23);
            this.txtNomeSerie.TabIndex = 5;
            this.txtNomeSerie.TextChanged += new System.EventHandler(this.txtNomeSerie_TextChanged);
            // 
            // txtTemporadasSerie
            // 
            this.txtTemporadasSerie.Location = new System.Drawing.Point(51, 223);
            this.txtTemporadasSerie.Name = "txtTemporadasSerie";
            this.txtTemporadasSerie.Size = new System.Drawing.Size(199, 23);
            this.txtTemporadasSerie.TabIndex = 6;
            // 
            // txtEstreiaSerie
            // 
            this.txtEstreiaSerie.Location = new System.Drawing.Point(292, 131);
            this.txtEstreiaSerie.Name = "txtEstreiaSerie";
            this.txtEstreiaSerie.Size = new System.Drawing.Size(183, 23);
            this.txtEstreiaSerie.TabIndex = 7;
            // 
            // comboboxGeneroSerie
            // 
            this.comboboxGeneroSerie.FormattingEnabled = true;
            this.comboboxGeneroSerie.Items.AddRange(new object[] {
            "Terror",
            "Drama",
            "Ficção",
            "Comédia",
            "Romance",
            "Ação",
            "Suspense",
            "Animação"});
            this.comboboxGeneroSerie.Location = new System.Drawing.Point(292, 223);
            this.comboboxGeneroSerie.Name = "comboboxGeneroSerie";
            this.comboboxGeneroSerie.Size = new System.Drawing.Size(183, 23);
            this.comboboxGeneroSerie.TabIndex = 8;
            // 
            // lblCanalStreaming
            // 
            this.lblCanalStreaming.AutoSize = true;
            this.lblCanalStreaming.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanalStreaming.Location = new System.Drawing.Point(51, 268);
            this.lblCanalStreaming.Name = "lblCanalStreaming";
            this.lblCanalStreaming.Size = new System.Drawing.Size(199, 23);
            this.lblCanalStreaming.TabIndex = 9;
            this.lblCanalStreaming.Text = "canal streaming:";
            // 
            // txtCanalStreaming
            // 
            this.txtCanalStreaming.Location = new System.Drawing.Point(51, 303);
            this.txtCanalStreaming.Name = "txtCanalStreaming";
            this.txtCanalStreaming.Size = new System.Drawing.Size(199, 23);
            this.txtCanalStreaming.TabIndex = 10;
            // 
            // btnEnviarSerie
            // 
            this.btnEnviarSerie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviarSerie.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarSerie.Location = new System.Drawing.Point(323, 283);
            this.btnEnviarSerie.Name = "btnEnviarSerie";
            this.btnEnviarSerie.Size = new System.Drawing.Size(120, 43);
            this.btnEnviarSerie.TabIndex = 11;
            this.btnEnviarSerie.Text = "enviar";
            this.btnEnviarSerie.UseVisualStyleBackColor = false;
            this.btnEnviarSerie.Click += new System.EventHandler(this.btnEnviarSerie_Click);
            // 
            // TelaCadastroSerie
            // 
            this.AcceptButton = this.btnEnviarSerie;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 441);
            this.Controls.Add(this.btnEnviarSerie);
            this.Controls.Add(this.txtCanalStreaming);
            this.Controls.Add(this.lblCanalStreaming);
            this.Controls.Add(this.comboboxGeneroSerie);
            this.Controls.Add(this.txtEstreiaSerie);
            this.Controls.Add(this.txtTemporadasSerie);
            this.Controls.Add(this.txtNomeSerie);
            this.Controls.Add(this.lblEstreiaSerie);
            this.Controls.Add(this.lblGeneroSerie);
            this.Controls.Add(this.lblTemporadasSerie);
            this.Controls.Add(this.lblNomeSerie);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroSerie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroSerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblNomeSerie;
        private Label lblTemporadasSerie;
        private Label lblGeneroSerie;
        private Label lblEstreiaSerie;
        private TextBox txtNomeSerie;
        private TextBox txtTemporadasSerie;
        private TextBox txtEstreiaSerie;
        private ComboBox comboboxGeneroSerie;
        private Label lblCanalStreaming;
        private TextBox txtCanalStreaming;
        private Button btnEnviarSerie;
    }
}