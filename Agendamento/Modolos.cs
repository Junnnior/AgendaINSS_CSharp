using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace Agendamento
{
    class Modolos
    {
        // caminho do banco de dados.
        string caminho = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\junio\\Desktop\\agendamento\\Agendamento\\bancoReab.mdb";
        // Select Quantidade de agendametos ------------------
        public int qtdData(string data)
        {
            //Configuração da conexão
            OleDbConnection conexao = new OleDbConnection();

            //configuração do caminho ao banco de dados
            conexao.ConnectionString = caminho;

            // abre conexão
            conexao.Open();

            //string comandoSQL = "SELECT " + coluna + " From tabelaReab";
            string comandoSQL = "SELECT * FROM tabelaReab WHERE data = '" + data + "'";
            OleDbCommand commando = new OleDbCommand(comandoSQL, conexao);

            //Executar o comando e ler os dados retornados
            OleDbDataReader dados = commando.ExecuteReader();

            int total = 0;
            // Pecorre todos os dados da coluna.
            while (dados.Read())

                total++; // concatena as datas que têm agendamento. 

            conexao.Close();

            return total;
        }

        // Insert ---------------------------
        public void insertBanco(string nome, string nb, string data, string fone)
        {
            OleDbConnection con = new OleDbConnection(caminho);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tabelaReab (nome, NB, data, telefone) values (@nome, @nb, @data, @tel);";
            
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@nb", nb);
            cmd.Parameters.AddWithValue("@data",data);
            cmd.Parameters.AddWithValue("@tel", fone);

            con.Open(); 
            cmd.ExecuteNonQuery();
            con.Close();
        }

       
    }
}
