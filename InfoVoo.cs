using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                if (cb_Origem.SelectedItem == null && cb_Destino.SelectedItem == null)
                {
                    MessageBox.Show("Erro, Você não selecionou a origem nem o destino");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            try
            {
                if (cb_Origem.SelectedItem == cb_Destino.SelectedItem)
                {
                    MessageBox.Show("Erro, A origem e o destino são iguais");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }

            try
            {
                if (cb_Origem.SelectedItem == null)
                {
                    MessageBox.Show("Erro, Origem não foi selecionada!");
                }
                else if (cb_Destino.SelectedItem == null)
                {
                    MessageBox.Show("Erro, Destino não foi selecionado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            /*Ta certo mas tem que Arrumar a parte de quando coloca dois comboBox vazio 
             * ele apresenta a mensagem de que "Você não selecionou a origem nem o destino" certo né, 
             * mas depois quando eu aperto no OK ele aparece a seguinte mensagem " A origem e o destino são iguais",
             * e também depois quando eu aperto no OK de novo aparece a seguinte mensagem "Origem não foi selecionada",
             * e depois se eu apertar no OK de novo aparece a seguinte mensagem "Destino não foi selecionado".
             * ou seja, ele anda o codigo todo só nesse exemplo que eu falei acima, tem que arrumar só essa parte!
             */
            //oi
            string Dados = ($"\n Sua Escolha foi: {cb_Origem.Text} Data de Voo: {dateTimePicker2.Text}\n Seu Destino será: {cb_Destino.Text}  \nData de Volta: {dateTimePicker3.Text}\n O valor que você deverá pagar será:  \n{comboBox2}\n");

            label8.Text = Dados;

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
            if (cb_Destino.SelectedItem != null)
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
    }//Pessoa p = new Pessoa();
    //int taxa = p.Taxa(Convert.ToInt32(comboBox2.Text) * 5);
}
