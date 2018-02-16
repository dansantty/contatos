using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos
{
    public partial class Telefone : Form
    {
        public Telefone()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string resp = "";
            resp = NEGOCIO.ExcluirTel(Convert.ToInt32(textBox5.Text.Trim()), textBox1.Text.Trim(),textBox3.Text.Trim(),textBox2.Text.Trim(),textBox4.Text.Trim());
            MessageBox.Show("Telefone Excluido");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NEGOCIO.AlterarTel(Convert.ToInt32(textBox5.Text.Trim()), textBox1.Text.Trim(), textBox3.Text.Trim(), textBox2.Text.Trim(), textBox4.Text.Trim());
                MessageBox.Show("Telefone Alterado");

            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NEGOCIO.IncluirTel(Convert.ToInt32(textBox5.Text.Trim()), textBox1.Text.Trim(), textBox3.Text.Trim(), textBox2.Text.Trim(), textBox4.Text.Trim());
                MessageBox.Show("Telefone Incluido");

            }
            catch (Exception ex)
            {

            }
        }
    }
}
