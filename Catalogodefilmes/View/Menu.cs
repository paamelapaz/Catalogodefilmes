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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastrarFilme_Click(object sender, EventArgs e)
        {
            TelaCadastroFilme filme = new TelaCadastroFilme();
            filme.Show();
        }

        private void btnCadastrarSerie_Click(object sender, EventArgs e)
        {
            TelaCadastroSerie serie = new TelaCadastroSerie();
            serie.Show();
        }
    }
}
