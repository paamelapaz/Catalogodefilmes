using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogodefilmes.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pamela.tgpaz\source\repos\Catalogodefilmes\Catalogodefilmes\Model\filmesbd.mdf;Integrated Security=True";
        }
    }
}
