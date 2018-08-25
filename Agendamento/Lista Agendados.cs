using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Agendamento
{
    public partial class Lista_Agendados : Form
    {
        public Lista_Agendados()
        {
            InitializeComponent();
        }

        string caminho = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\junio\\Desktop\\agendamento\\Agendamento\\bancoReab.mdb";
        private void Lista_Agendados_Load(object sender, EventArgs e)
        {

            //Configuração da conexão
            OleDbConnection conexao = new OleDbConnection();

            //configuração do caminho ao banco de dados
            conexao.ConnectionString = caminho;

            // abre conexão
            conexao.Open();

            string comandoSQL = "SELECT * From tabelaReab order by data";
            OleDbCommand commando = new OleDbCommand(comandoSQL, conexao);

            commando.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(commando);
            DataTable scores = new DataTable();
            da.Fill(scores);
            dataGridView1.DataSource = scores;

            // Pecorre o Grid View -------------------------------------
            foreach (DataGridViewColumn column in dataGridView1.Columns){
                if (column.DataPropertyName == "NB"){
                    column.Width = 190; //tamanho fixo
                    dataGridView1.Columns["NB"].HeaderText = "N° Beneficio"; // Renomea Coluna
                }

                if (column.DataPropertyName == "nome"){
                    column.Width = 350; //tamanho fixo 
                    dataGridView1.Columns["nome"].HeaderText = "Nome do Segurado"; // Renomea Coluna
                }

                if (column.DataPropertyName == "data"){
                    column.Width = 150; //tamanho fixo 
                    dataGridView1.Columns["data"].HeaderText = "Data"; // Renomea Coluna
                }


                if (column.DataPropertyName == "telefone"){
                    column.Width = 150; //tamanho fixo 
                    dataGridView1.Columns["telefone"].HeaderText = "Fone"; // Renomea Coluna
                }
                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.RowHeadersVisible = false; // apaga primeira coluna
            //dataGridView1.Rows[0].DefaultCellStyle.Padding = new Padding(0,0, 0, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Inicio In = new Inicio();
            In.ShowDialog();
            this.Hide();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            string buscar = lblBuscar.Text;
            //Configuração da conexão
            OleDbConnection conexao = new OleDbConnection();

            //configuração do caminho ao banco de dados
            conexao.ConnectionString = caminho;

            // abre conexão
            conexao.Open();

            string comandoSQL = "SELECT * From tabelaReab Where nome LIKE '" + buscar + "%' OR data LIKE '" + buscar + "%' order by data";
            OleDbCommand commando = new OleDbCommand(comandoSQL, conexao);

            commando.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(commando);
            DataTable scores = new DataTable();
            da.Fill(scores);
            dataGridView1.DataSource = scores;
        }
    }

}
