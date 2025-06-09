using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaDS
{
    public partial class Menu_Geren : Form
    {
        private bool confirmacaoRealizada = false;

        public Menu_Geren()
        {
            InitializeComponent();
        }

        private void Menu_Geren_Load(object sender, EventArgs e)
        {
            timerHora.Start();
        }

        private void Menu_Geren_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmacaoRealizada)
                return;

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja encerrar o programa?",
                "Confirmar Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                confirmacaoRealizada = true;
            }
        }

        private void Menu_Geren_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnAeronaves_Click(object sender, EventArgs e)
        {
            var aeronavesForm = new Aeronaves_gen();
            aeronavesForm.Show();
            aeronavesForm.BringToFront();
        }

        private void btnPilotos_Click(object sender, EventArgs e)
        {
            var aeronavesForm = new Pilotos_gen();
            aeronavesForm.Show();
            aeronavesForm.BringToFront();
        }
    }
}