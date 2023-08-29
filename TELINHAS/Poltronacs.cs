using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_Check_in.CLASSES;


namespace Cadastro_Check_in
{
    public partial class Poltronacs : Form
    {

        public List<Pessoa> DadosCheckin;

        private bool buttonClicked = false;
        private Random random = new Random();

        public Poltronacs(List<Pessoa> dadosCheckin)
        {
            InitializeComponent();     
            

            dataGridView2.AutoGenerateColumns = true;
            DadosCheckin = Pessoa.JsonDesserializarLista(@"C:\Users\tayna_97l6kwx\OneDrive\Área de Trabalho\arquivo.json");
            dataGridView2.DataSource = DadosCheckin;
        }

        private void Poltronacs_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            Random random = new Random();
            string[] Aviao = { "Azul", "VASP", "Avianca" }; // Chute de aviões

            foreach (var pessoa in DadosCheckin) // "var" por que existe int e string ao mesmo tempo
            {
                pessoa.NumeroPoltrona = random.Next(1, 101); // Gera um número de poltrona aleatório entre 1 e 100
                pessoa.Aviao = Aviao[random.Next(Aviao.Length)]; // Seleciona um avião aleatório da lista
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DadosCheckin;
            MessageBox.Show($"Poltrona e avião Reservado. Boa viagem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!buttonClicked) //Se não foi clicado, a ação foi falta (!)
            {
                buttonClicked = true; // caso clicado (True)
                button1.Enabled = false; // Desabilita o botão
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
