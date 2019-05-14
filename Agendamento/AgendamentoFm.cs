using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using DateTime.Now.DayOfWeek;

using System.Data.OleDb;

namespace Agendamento
{
    public partial class AgendamentoFm : Form
    {
        public AgendamentoFm()
        {
            InitializeComponent();
            
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Modolos funcao = new Modolos();
            string nome = txtNome.Text;
            string nb = txtNb.Text;
            string data = txtData.Text;
            string tel = txtFone.Text;

            
            if(nome == "") {
                MessageBox.Show("Preencha os campos nome e data!", "AVISO");
            
            } else {
                DialogResult confirm = MessageBox.Show("Salvar " + nome + " pro dia " + data, "Agendar Reabilitação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES") {
                    MessageBox.Show("Agendado com Sucesso!", "AVISO");
                    funcao.insertBanco(nome, nb, data, tel);
                    txtNome.Text = "";
                    txtNb.Text = "";
                    txtData.Text = "";
                    txtFone.Text = "";
                    txtDiaSemana.Text = "";
                }
            }

            

                
        }
        // Load Projet
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio In = new Inicio();
            In.ShowDialog();
            this.Hide(); 
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            acharDia();

        }

        // Função que encontra o dia disponível 
        void acharDia(){

            //int dia = DateTime.Now.Day;

            /*  Ingês       ->  Portugês
            *
            *   Monday      ->  Segunda      
            *   Tuesday     ->  Terça
            *   Wednesday   ->  Quarta
            *   Thursday    ->  Quinta
            *   Friday      ->  Sexta
            *   Saturday    ->  Sábado
            *   Sunday      ->  Domingo
            */
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            int qtdAgendados = 0;
           
            while (true){
                try{
                    // captura o dia atual (HOJE).
                    DateTime diaSemana = new DateTime(ano, mes, dia);

                    // converte Int to str 
                    string diaS = dia.ToString();
                    string mesS = mes.ToString();
                    diaS = diaS.PadLeft(2, '0');
                    mesS = mesS.PadLeft(2, '0');

                    // formata padrão data dd/mm/aaaa
                    string dataD = diaS.ToString() + "/" + mesS.ToString() + "/" + ano.ToString();

                    /* Se o checkbox Terça estiver marcado
                      ele busca por terças disponíveis */
                    if (cbxTerca.Checked){
                        // valida se o dia é igual ao dia disponivel.
                        if (diaSemana.DayOfWeek.ToString() == "Tuesday"){
                            Modulos SQL = new Modulos();
                            qtdAgendados = SQL.qtdData(dataD);
                            // 6 -> limite máximo de agendados por dia.
                            if (qtdAgendados < 6){
                                txtData.Text = dataD;
                                txtDiaSemana.Text = "Terça: " + (6 - qtdAgendados).ToString() + " vagas";
                                break;
                            }
                        }
                   }

                    /* Se o checkbox Quinta estiver marcado
                       ele busca por quintas disponíveis */
                    if (cbxQuinta.Checked){
                        if (diaSemana.DayOfWeek.ToString() == "Thursday"){
                            Modulos SQL = new Modulos();
                            qtdAgendados = SQL.qtdData(dataD);
                            if (qtdAgendados < 6){
                                txtData.Text = dataD;
                                txtDiaSemana.Text = "Quinta: " + (6-qtdAgendados).ToString() + " vagas";
                                break;
                            }
                        }
                    }
                    // Caso nenhum esteja maracdo.
                    if (cbxQuinta.Checked == false && cbxTerca.Checked == false){
                        MessageBox.Show("Marque Terça ou Quinta.");
                        break;
                    }
                }

                // inicia a busca no dia primeiro do próximo mês.
                catch{
                    dia = 0;
                    mes++;

                    /* caso chegue no último dia do ano, inicia-se a busca 
                       do primeiro dia do próximo ano. */
                    if (mes > 12){
                        dia = 0;
                        mes = 1;
                        ano++;
                    }
                }

                dia++; // passa pro dia seguinte
            }
            //DateTime data = new DateTime(2018, 07, 27); //05/10/2008
            //Console.Write(data.DayOfWeek);
            
            
            //txtDiaSemana.Text = data;
        }
        
    }
}
