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
            dateTimePicker1 = new DateTimePicker();
            masktx_Cpf = new MaskedTextBox();
            br_Cancelar = new Button();
            br_Salvar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
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
            lb_CPF.Location = new Point(31, 112);
            lb_CPF.Name = "lb_CPF";
            lb_CPF.Size = new Size(33, 20);
            lb_CPF.TabIndex = 4;
            lb_CPF.Text = "CPF";
            // 
            // lb_DataNascimento
            // 
            lb_DataNascimento.AutoSize = true;
            lb_DataNascimento.Location = new Point(31, 247);
            lb_DataNascimento.Name = "lb_DataNascimento";
            lb_DataNascimento.Size = new Size(145, 20);
            lb_DataNascimento.TabIndex = 5;
            lb_DataNascimento.Text = "Data de Nascimento";
            lb_DataNascimento.Click += lb_DataNascimento_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 247);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // masktx_Cpf
            // 
            masktx_Cpf.Location = new Point(208, 112);
            masktx_Cpf.Mask = "000,000,000-00";
            masktx_Cpf.Name = "masktx_Cpf";
            masktx_Cpf.Size = new Size(125, 27);
            masktx_Cpf.TabIndex = 9;
            masktx_Cpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // br_Cancelar
            // 
            br_Cancelar.Location = new Point(283, 309);
            br_Cancelar.Name = "br_Cancelar";
            br_Cancelar.Size = new Size(94, 29);
            br_Cancelar.TabIndex = 10;
            br_Cancelar.Text = "Cancelar";
            br_Cancelar.UseVisualStyleBackColor = true;
            br_Cancelar.Click += br_Cancelar_Click;
            // 
            // br_Salvar
            // 
            br_Salvar.Location = new Point(150, 309);
            br_Salvar.Name = "br_Salvar";
            br_Salvar.Size = new Size(94, 29);
            br_Salvar.TabIndex = 11;
            br_Salvar.Text = "Salvar";
            br_Salvar.UseVisualStyleBackColor = true;
            br_Salvar.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(436, 150);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(31, 309);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Concluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 142);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 31;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 184);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 32;
            label2.Text = "Telefone";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(208, 184);
            maskedTextBox1.Mask = "(00) 00000-9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 34;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 520);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(br_Salvar);
            Controls.Add(br_Cancelar);
            Controls.Add(masktx_Cpf);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox masktx_Cpf;
        private Button br_Cancelar;
        private Button br_Salvar;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
    }
}