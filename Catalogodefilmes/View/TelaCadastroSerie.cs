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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Catalogodefilmes.View
{
    public partial class TelaCadastroSerie : Form
    {
        public TelaCadastroSerie()
        {
            InitializeComponent();
        }

        private void txtNomeSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviarSerie_Click(object sender, EventArgs e)
        {
            Serie.NomeSerie = txtNomeSerie.Text;
            Serie.Temporadas = txtTemporadasSerie.Text;
            Serie.GeneroSerie = comboboxGeneroSerie.Text;
            Serie.EstreiaSerie = txtEstreiaSerie.Text;
            Serie.CanalStreaming = txtCanalStreaming.Text;

            SerieController serieController = new SerieController();
            serieController.CadastrarSerie();

            txtNomeSerie.Text = Serie.NomeSerie;
            txtTemporadasSerie.Text = Serie.Temporadas;
            comboboxGeneroSerie.Text = Serie.GeneroSerie;
            txtEstreiaSerie.Text = Serie.EstreiaSerie;
            txtCanalStreaming.Text = Serie.CanalStreaming;

            if(Serie.RetornoSerie == "f")
            {
                this.Close();
            }
        }

        public void FecharTela()
        {
            this.Close();
        }
    }
}
