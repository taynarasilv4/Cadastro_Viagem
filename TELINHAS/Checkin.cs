using Cadastro_Check_in.CLASSES;
using Newtonsoft.Json;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro_Check_in
{
    public partial class Form1 : Form
    {
        private bool butaosalva = false;
        List<Pessoa> Cadastro = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)// botão salvar
        {

            try
            {
                if (string.IsNullOrWhiteSpace(tx_Nome.Text))
                {
                    MessageBox.Show("O campo Nome está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Pessoa pessoa = new Pessoa();

                    ValidarCpf validarCpf = new ValidarCpf();
                    bool cpfValido = validarCpf.ValidaCPF(masktx_Cpf.Text);
                    string cpf = masktx_Cpf.Text.Replace(".", "").Replace("-", "");


                    if (!cpfValido || CaracteresRepetidos(cpf))
                    {
                        label1.Visible = true;
                        label1.Text = "CPF é inválido";
                        label1.ForeColor = Color.Red;
                        masktx_Cpf.Clear();
                        return;
                    }
                    else
                    {
                        label1.Visible = false;

                        pessoa.Telefone = maskedTextBox1.Text;
                        pessoa.Nome = tx_Nome.Text;
                        int idade = pessoa.CalculoIdade(Convert.ToInt32(dateTimePicker1.Value.Year), Convert.ToInt32(dateTimePicker1.Value.Month), Convert.ToInt32(dateTimePicker1.Value.Day));
                        pessoa.Idade = idade;

                        pessoa.CPF = masktx_Cpf.Text;
                        Cadastro.Add(pessoa);

                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                        dataGridView1.DataSource = Cadastro;
                        masktx_Cpf.Focus();

                        if (!butaosalva) //Se não foi clicado, a ação foi falta (!)
                        {
                            butaosalva = true; // caso clicado (True)
                            br_Salvar.Enabled = false; // Desabilita o botão
                        }

                        if (pessoa.JsonSerializarLista(Cadastro, @"C:\Users\tayna_97l6kwx\OneDrive\Área de Trabalho\arquivo.json"))
                        {
                            MessageBox.Show("Salvo");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erros na sintaxe, confira se preencheu certo. ");
            }

        }
        public int Taxa(int peso)
        {
            return peso * 5;
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
        private void button1_Click(object sender, EventArgs e) // botão restaurar
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
            try                     //  verifica se o resgistro é maior que zero presente no DataGridView,
                                    // o Rows DataGridView representa a coleção de linhas na
                                    // Count retorna o número total de elementos da coleção.
            {
                butaosalva = false;
                br_Salvar.Enabled = true;
                if (dataGridView1.Rows.Count > 0)
                {


                    int index = dataGridView1.CurrentCell.RowIndex;
                    Cadastro.RemoveAt(index);

                    dataGridView1.DataSource = null;    //zerar ou seja deixar sem nenhum elemento
                    dataGridView1.Refresh();            //atualizar toda tabela
                    dataGridView1.DataSource = Cadastro;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos antes de cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            butaosalva = true;
            br_Salvar.Enabled = false;

            Cadastro = Pessoa.JsonDesserializarLista(@"C:\Users\tayna_97l6kwx\OneDrive\Área de Trabalho\arquivo.json");
            dataGridView1.DataSource = Cadastro;
            MessageBox.Show($"Sucesso de importação!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(@"C:\Users\tayna_97l6kwx\OneDrive\Área de Trabalho\arquivo.json"))
                {
                    strJson = sr.ReadToEnd();
                }
                var pessoa = Pessoa.JsonDesserializarLista(strJson);

            }
            catch (Exception ex)
            {

            }
        }
        private void lb_Nome_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tx_Nome.Clear();
            masktx_Cpf.Clear();
            maskedTextBox1.Clear();
        }
        private bool CaracteresRepetidos(string numeroscpf)
        {
            char numerosiguais = numeroscpf[0]; // numeroscpf verifica se todos os caracteres nessa string são iguais
                                                //comparando cada caractere na string com o primeiro caractere.
                                                // ou melhor, tudo será igual a primeira casa.
            foreach (char verificar in numeroscpf)
            {
                if (verificar != numerosiguais) // variavel "numerosiguais" seria os numeros iguais ex: (11111 ou 2222).
                {
                    return false; // Os números não são todos dígitos iguais!
                }
            }
            label1.Visible = true;
            label1.Text = "CPF é inválido";
            label1.ForeColor = Color.Red;
            masktx_Cpf.Clear();
            return true; // todos são iguais!

        }


    }
}
