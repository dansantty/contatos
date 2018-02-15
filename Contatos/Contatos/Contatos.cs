using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contatos;
using System.Data;


namespace Contatos
{
    public partial class Contatos : Form
    {
        public Contatos()
        {
            InitializeComponent();
        }

        private void llTodos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.ListarContatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NEGOCIO.InserirContato(this.txtNome.Text.Trim(), Convert.ToDateTime(txtNasc.Text.Trim()), this.txtCel.Text.Trim(),
                    this.txtRes.Text.Trim(), this.txtCom.Text.Trim(), this.txtFax.Text.Trim(), this.txtPes.Text.Trim(), this.txtProf.Text.Trim());

                MessageBox.Show("Contato Inserido Com Sucesso");

            }
            catch (Exception ex)
            {
                
            }
        }

        private void Contatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NEGOCIO.AlterarDados(Convert.ToInt32(txtID.Text.Trim()), this.txtNome.Text.Trim(), Convert.ToDateTime(txtNasc.Text.Trim()));

                MessageBox.Show("Contato Alterado Com Sucesso");

            }
            catch (Exception ex)
            {

            }
        }

        private void llD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("d");
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato(this.txtBusca.Text.Trim());
        }

        private void llA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("a");
        }

        private void llB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("b");
        }

        private void llC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("c");
        }

        private void llE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("e");
        }

        private void llF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("f");
        }

        private void llG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("g");
        }

        private void llH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("h");
        }

        private void llI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("i");
        }

        private void llJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("j");
        }

        private void llK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("k");
        }

        private void llL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("l");
        }

        private void llM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("m");
        }

        private void llN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("n");
        }

        private void llO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("o");
        }

        private void llP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("p");
        }

        private void llQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("q");
        }

        private void llR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("r");
        }

        private void llS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("s");
        }

        private void llT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("t");
        }

        private void llU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("u");
        }

        private void llV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("v");
        }

        private void llX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("x");
        }

        private void llY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("y");
        }

        private void llW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = NEGOCIO.BuscarContato("w");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resp = "";
            resp = NEGOCIO.ExcluirContato(Convert.ToInt32(txtID.Text));
            MessageBox.Show("Morador Excluido");
        }
    }
}
