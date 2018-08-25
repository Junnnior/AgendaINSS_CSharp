using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agendamento
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            AgendamentoFm Agenda = new AgendamentoFm();
            Agenda.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista_Agendados Lista_Agendados = new Lista_Agendados();
            Lista_Agendados.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
