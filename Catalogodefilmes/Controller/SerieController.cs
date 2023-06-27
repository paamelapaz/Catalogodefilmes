using Catalogodefilmes.Model;
using Catalogodefilmes.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogodefilmes.Controller
{
    internal class SerieController
    {

        public void CadastrarSerie()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("InserirSerieP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Serie.NomeSerie);
                cmd.Parameters.AddWithValue("@temporada", Serie.Temporadas);
                cmd.Parameters.AddWithValue("@genero", Serie.GeneroSerie);
                cmd.Parameters.AddWithValue("estreia", Serie.EstreiaSerie);
                cmd.Parameters.AddWithValue("canal", Serie.CanalStreaming);

                SqlParameter nv = cmd.Parameters.Add("@id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Serie cadastrada com sucesso, Deseja Cadastrar outra Serie?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    Serie.NomeSerie = string.Empty;
                    Serie.Temporadas = string.Empty;
                    Serie.GeneroSerie = string.Empty;
                    Serie.EstreiaSerie = string.Empty;
                    Serie.CanalStreaming = string.Empty;
                    Serie.RetornoSerie = string.Empty;
                }
                else
                {
                    Serie.RetornoSerie = "f";
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

