using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro_Check_in
{
    public partial class Form1 : Form
    {
        List<Pessoa> Cadastro = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            ValidarCpf validarCpf = new ValidarCpf();
            bool cpf = validarCpf.ValidaCPF(masktx_Cpf.Text);

            if (cpf == false)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "CPF é inválido";

            }
            else
            {
                pessoa.CPF = masktx_Cpf.Text;
            }

            pessoa.Telefone = maskedTextBox1.Text;
            pessoa.Nome = tx_Nome.Text;
            int idade = pessoa.CalculoIdade(Convert.ToInt32(dateTimePicker1.Value.Year), Convert.ToInt32(dateTimePicker1.Value.Month), Convert.ToInt32(dateTimePicker1.Value.Day));
            pessoa.Idade = idade;

            Cadastro.Add(pessoa);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = Cadastro;


        }

        private void lb_Bagagem_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoVoo info = new InfoVoo();
            info.ShowDialog();
            //Bilhete bilhete = new Bilhete();
            //bilhete.Show();
        }

        private void lb_DataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void br_Cancelar_Click(object sender, EventArgs e)
        {

            tx_Nome.Clear();
            masktx_Cpf.Clear();
            maskedTextBox1.Clear();
            int index = dataGridView1.CurrentCell.RowIndex;
            Cadastro.RemoveAt(index);

            dataGridView1.DataSource = null;//zerar ou seja deixar sem nenhum elemento
            dataGridView1.Refresh();//atualizar toda tabela
            dataGridView1.DataSource = Cadastro;
        }
    }
}