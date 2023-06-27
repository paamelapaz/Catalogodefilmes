using Catalogodefilmes.Controller;
using Catalogodefilmes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogodefilmes.View
{
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Filme.NomeFilme = txtFilme.Text;
            Filme.EstreiaFilme = txtEstreia.Text;
            Filme.DuracaoFilme = txtDuracao.Text;
            Filme.CategoriaFilme = comboBox1.Text;

            FilmeController filmeController = new FilmeController();
            filmeController.CadastrarFilme();

            txtFilme.Text =Filme.NomeFilme;
            txtEstreia.Text = Filme.EstreiaFilme;
            txtDuracao.Text = Filme.DuracaoFilme;
            comboBox1.Text = Filme.CategoriaFilme;

            if(Filme.RetornoFilme == "f")
            {
                this.Close();
            }

        }

        public void FecharTela()
        {
            this.Close();
        }

        private void txtFilme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
