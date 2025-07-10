using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro
{
    public class ConexaoBD
    {
        private string conexaoBanco = "Server = localhost; pwd = '', Database = zaffy; Uid = root";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();
            return conexao;
        }
    }
}
