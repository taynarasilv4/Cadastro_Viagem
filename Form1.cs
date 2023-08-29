using Microsoft.Win32;
using Newtonsoft.Json;
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

            pessoa.Telefone = maskedTextBox1.Text;
            pessoa.Nome = tx_Nome.Text;
            int idade = pessoa.CalculoIdade(Convert.ToInt32(dateTimePicker1.Value.Year), Convert.ToInt32(dateTimePicker1.Value.Month), Convert.ToInt32(dateTimePicker1.Value.Day));
            pessoa.Idade = idade;

            if (cpf == false)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "CPF é inválido";
                masktx_Cpf.Clear();
                Console.ResetColor();
            }
            else
            {

                label1.Visible = false;
                pessoa.CPF = masktx_Cpf.Text;
                Cadastro.Add(pessoa);


                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = Cadastro;
            }

            if (pessoa.JsonSerializar(pessoa, @"C:\Usuários\documentos\arquivo.json"))
            {
                MessageBox.Show("Salvo");
            }
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
            if (dataGridView1.Rows.Count > 0)
            {
                InfoVoo info = new InfoVoo();
                info.ShowDialog();
            }
            else
            {
                MessageBox.Show("A tabela está vazia. Preencha-a antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = Cadastro;
        }

        private void bt_desserilhar_Click(object sender, EventArgs e)
        {
            // var strJson = OpenFilePessoa.Se(pessoa);

            // if (strJson.Substring(0, 5)! = "Falhas")
            //  {
            //      return JsonConvert.DeserializeObject<string>(strJson);
            //  }



            //try
            //{
            //    var strJson = "";
            //    using (StreamReader sr = new StreamReader(@"C:\Users\2022102020009\Desktop\arquivo.json"))
            //    {
            //        strJson = sr.ReadToEnd();
            //    }
            //    var pessoa = Pessoa.JsonDesserializar(strJson);

            //    pessoa.Nome = tx_Nome.Text;
            //    pessoa.CPF = masktx_Cpf.Text;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Erros encontrados{ex}");
            //}
        }
    }
}