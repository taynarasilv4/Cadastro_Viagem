namespace Cadastro_Check_in
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tx_Nome = new TextBox();
            lb_Nome = new Label();
            lb_CPF = new Label();
            lb_DataNascimento = new Label();
            comboBox1 = new ComboBox();
            lb_Bagagem = new Label();
            dateTimePicker1 = new DateTimePicker();
            masktx_Cpf = new MaskedTextBox();
            br_Cancelar = new Button();
            br_Salvar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tx_Nome
            // 
            tx_Nome.Location = new Point(208, 36);
            tx_Nome.Name = "tx_Nome";
            tx_Nome.Size = new Size(125, 27);
            tx_Nome.TabIndex = 0;
            tx_Nome.TextChanged += textBox1_TextChanged;
            // 
            // lb_Nome
            // 
            lb_Nome.AutoSize = true;
            lb_Nome.Location = new Point(31, 39);
            lb_Nome.Name = "lb_Nome";
            lb_Nome.Size = new Size(50, 20);
            lb_Nome.TabIndex = 3;
            lb_Nome.Text = "Nome";
            // 
            // lb_CPF
            // 
            lb_CPF.AutoSize = true;
            lb_CPF.Location = new Point(31, 97);
            lb_CPF.Name = "lb_CPF";
            lb_CPF.Size = new Size(33, 20);
            lb_CPF.TabIndex = 4;
            lb_CPF.Text = "CPF";
            // 
            // lb_DataNascimento
            // 
            lb_DataNascimento.AutoSize = true;
            lb_DataNascimento.Location = new Point(31, 153);
            lb_DataNascimento.Name = "lb_DataNascimento";
            lb_DataNascimento.Size = new Size(145, 20);
            lb_DataNascimento.TabIndex = 5;
            lb_DataNascimento.Text = "Data de Nascimento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sim", "Não" });
            comboBox1.Location = new Point(221, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // lb_Bagagem
            // 
            lb_Bagagem.AutoSize = true;
            lb_Bagagem.Location = new Point(12, 216);
            lb_Bagagem.Name = "lb_Bagagem";
            lb_Bagagem.Size = new Size(203, 20);
            lb_Bagagem.TabIndex = 7;
            lb_Bagagem.Text = "Deseja Despachar Bagagem?";
            lb_Bagagem.Click += lb_Bagagem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(208, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // masktx_Cpf
            // 
            masktx_Cpf.Location = new Point(208, 90);
            masktx_Cpf.Mask = "000,000,000-00";
            masktx_Cpf.Name = "masktx_Cpf";
            masktx_Cpf.Size = new Size(125, 27);
            masktx_Cpf.TabIndex = 9;
            masktx_Cpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // br_Cancelar
            // 
            br_Cancelar.Location = new Point(538, 279);
            br_Cancelar.Name = "br_Cancelar";
            br_Cancelar.Size = new Size(94, 29);
            br_Cancelar.TabIndex = 10;
            br_Cancelar.Text = "Cancelar";
            br_Cancelar.UseVisualStyleBackColor = true;
            // 
            // br_Salvar
            // 
            br_Salvar.Location = new Point(668, 279);
            br_Salvar.Name = "br_Salvar";
            br_Salvar.Size = new Size(94, 29);
            br_Salvar.TabIndex = 11;
            br_Salvar.Text = "Salvar";
            br_Salvar.UseVisualStyleBackColor = true;
            br_Salvar.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 323);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 115);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 263);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 13;
            label1.Text = "Qual é o peso da sua Bagagem?";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0 ", "1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10 ", "11 ", "12 ", "13 ", "14 ", "15 ", "16 ", "17 ", "18 ", "19 ", "20 ", "21 ", "22 ", "23 " });
            comboBox2.Location = new Point(241, 255);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 100);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 97);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(br_Salvar);
            Controls.Add(br_Cancelar);
            Controls.Add(masktx_Cpf);
            Controls.Add(dateTimePicker1);
            Controls.Add(lb_Bagagem);
            Controls.Add(comboBox1);
            Controls.Add(lb_DataNascimento);
            Controls.Add(lb_CPF);
            Controls.Add(lb_Nome);
            Controls.Add(tx_Nome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_Nome;
        private Label lb_Nome;
        private Label lb_CPF;
        private Label lb_DataNascimento;
        private ComboBox comboBox1;
        private Label lb_Bagagem;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox masktx_Cpf;
        private Button br_Cancelar;
        private Button br_Salvar;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
    }
}