using System.Windows.Forms;

namespace Cadastro_Check_in
{
    public partial class Form1 : Form
    {
        List<Pessoa> Cadastro = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = tx_Nome.Text;
            pessoa.CPF = masktx_Cpf.Text;
            int idade = pessoa.Idade(Convert.ToInt32(dateTimePicker1.Value.Year), Convert.ToInt32(dateTimePicker1.Value.Month), Convert.ToInt32(dateTimePicker1.Value.Day));
            pessoa.DataNascimento = idade;
            int valor = pessoa.Taxa(Convert.ToInt32(comboBox2.SelectedItem.ToString()));
            pessoa.Bagagem = valor;

            comboBox2.DataSource = Cadastro;


            Cadastro.Add(pessoa);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = Cadastro;


            /*Remover elemento da lista e atualizar datagrid
            int index = dataGridView1.CurrentCell.RowIndex;
            Cadastro.RemoveAt(index);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = Cadastro;*/


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
    }
}