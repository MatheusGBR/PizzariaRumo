using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados
{
    public class Cadastros
    { 
        private string sqlConn()
        {
            return System.Configuration.ConfigurationManager.AppSettings["sqlConn"];

        }

        public DataTable Pedidos()
        {

            
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {

                
                string queryString = "select * from Pedidos";
                SqlCommand command = new SqlCommand( queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;


            }
        }
    }
}

