using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Check_in
{
    public partial class InfoVoo : Form
    {
        public InfoVoo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedText != comboBox4.SelectedText)
                {
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                }
                else if (comboBox4.SelectedText == null)
                {
                    comboBox4.Text = "";
                    MessageBox.Show("Erro, destino não preenchido!");
                }
                else if (comboBox3.Text == null)
                {
                    comboBox3.Text = "";
                    MessageBox.Show("Erro, origem não preenchido! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, a origem e o destino são iguais.");
            }
            Pessoa p = new Pessoa();
            int taxa = p.Taxa(Convert.ToInt32(comboBox2.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Sim")
            {
                comboBox2.Visible = true;
                label1.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                label1.Visible = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                dateTimePicker2.Visible = true;
                label6.Visible = true;
                dateTimePicker3.Visible = true;
                label7.Visible = true;

            }
            else
            {
                dateTimePicker2.Visible = false;
                label6.Visible = false;
                dateTimePicker3.Visible = false;
                label7.Visible = false;

            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now.AddMonths(1);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.MinDate = DateTime.Now;
            dateTimePicker3.MaxDate = DateTime.Now.AddMonths(1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InfoVoo_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}
