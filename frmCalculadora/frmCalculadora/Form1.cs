using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToInt16(txtValor1.Text + txtValor2.Text).ToString();
            lblOperacao.Text = "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Convert.ToInt16(txtValor1.Text) - Convert.ToInt16(txtValor2.Text)).ToString();
            lblOperacao.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Convert.ToInt16(txtValor1.Text) * Convert.ToInt16(txtValor2.Text)).ToString();
            lblOperacao.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Convert.ToInt16(txtValor1.Text) / Convert.ToInt16(txtValor2.Text)).ToString();
            lblOperacao.Text = "/";
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            lblOperacao.Text = "";
            dtpData.Visible = false;
            dtpHora.Visible = false;
            chkData.Checked = false;
            chkHora.Checked = false;
            lstCores.Items.Add("vermelho");
            lstCores.Items.Add("azul");
            lstCores.Items.Add("verde");
            lstCores.Items.Add("amarelo");
            lstCores.Items.Add("laranja");
            lstCores.Items.Add("rosa");
            lstCores.Items.Add("marrom");
            lstCores.Items.Add("black");
        }

        private void lstCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NomeCor = Convert.ToString(lstCores.SelectedItem);
            if(NomeCor == "vermelho")
            {
               BackColor = System.Drawing.Color.FromName("red");
            }
            if (NomeCor == "azul")
            {
                BackColor = System.Drawing.Color.FromName("blue");
            }
            if (NomeCor == "verde")
            {
                BackColor = System.Drawing.Color.FromName("green");
            }
            if (NomeCor == "amarelo")
            {
                BackColor = System.Drawing.Color.FromName("yellow");
            }
            if (NomeCor == "laranja")
            {
                BackColor = System.Drawing.Color.FromName("orange");
            }
            if (NomeCor == "rosa")
            {
                BackColor = System.Drawing.Color.FromName("pink");
            }
            if (NomeCor == "marrom")
            {
                BackColor = System.Drawing.Color.FromName("brown");
            }
            if (NomeCor == "preto")
            {
                BackColor = System.Drawing.Color.FromName("black");
            }
            
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Voce deseja sair?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void chkData_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData.Checked == true)
            {
                dtpData.Visible = true;
            }
            else
            {
                dtpData.Visible = false;
            }
        }

        private void chkHora_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHora.Checked == true)
            {
                dtpHora.Visible = true;
            }
            else
            {
                dtpHora.Visible = false;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            wbrBrowser.Navigate(txtEndereco.Text);
        }
    }
}
