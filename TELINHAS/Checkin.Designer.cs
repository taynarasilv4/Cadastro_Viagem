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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tx_Nome = new TextBox();
            lb_DataNascimento = new Label();
            dateTimePicker1 = new DateTimePicker();
            masktx_Cpf = new MaskedTextBox();
            br_Cancelar = new Button();
            br_Salvar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            lb_Nome = new Label();
            lb_CPF = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tx_Nome
            // 
            tx_Nome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tx_Nome.Location = new Point(120, 68);
            tx_Nome.Name = "tx_Nome";
            tx_Nome.Size = new Size(508, 32);
            tx_Nome.TabIndex = 0;
            tx_Nome.TextChanged += textBox1_TextChanged;
            // 
            // lb_DataNascimento
            // 
            lb_DataNascimento.AutoSize = true;
            lb_DataNascimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_DataNascimento.Location = new Point(418, 144);
            lb_DataNascimento.Name = "lb_DataNascimento";
            lb_DataNascimento.Size = new Size(172, 23);
            lb_DataNascimento.TabIndex = 5;
            lb_DataNascimento.Text = "Data de Nascimento";
            lb_DataNascimento.Click += lb_DataNascimento_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(590, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 32);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // masktx_Cpf
            // 
            masktx_Cpf.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            masktx_Cpf.Location = new Point(120, 137);
            masktx_Cpf.Mask = "000,000,000-00";
            masktx_Cpf.Name = "masktx_Cpf";
            masktx_Cpf.Size = new Size(129, 32);
            masktx_Cpf.TabIndex = 9;
            masktx_Cpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // br_Cancelar
            // 
            br_Cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            br_Cancelar.Image = (Image)resources.GetObject("br_Cancelar.Image");
            br_Cancelar.Location = new Point(597, 321);
            br_Cancelar.Name = "br_Cancelar";
            br_Cancelar.RightToLeft = RightToLeft.No;
            br_Cancelar.Size = new Size(125, 61);
            br_Cancelar.TabIndex = 10;
            br_Cancelar.Text = "Apagar";
            br_Cancelar.UseVisualStyleBackColor = true;
            br_Cancelar.Click += br_Cancelar_Click;
            // 
            // br_Salvar
            // 
            br_Salvar.BackColor = Color.FromArgb(128, 255, 128);
            br_Salvar.BackgroundImageLayout = ImageLayout.None;
            br_Salvar.FlatStyle = FlatStyle.Flat;
            br_Salvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            br_Salvar.Image = (Image)resources.GetObject("br_Salvar.Image");
            br_Salvar.ImageAlign = ContentAlignment.MiddleLeft;
            br_Salvar.Location = new Point(418, 225);
            br_Salvar.Name = "br_Salvar";
            br_Salvar.Size = new Size(125, 71);
            br_Salvar.TabIndex = 11;
            br_Salvar.Text = "Salvar";
            br_Salvar.UseVisualStyleBackColor = false;
            br_Salvar.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(49, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(521, 107);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(560, 229);
            button1.Name = "button1";
            button1.Size = new Size(130, 65);
            button1.TabIndex = 19;
            button1.Text = "Concluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(120, 179);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 31;
            label1.Text = "label1";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(123, 219);
            maskedTextBox1.Mask = "(00) 00000-9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(141, 32);
            maskedTextBox1.TabIndex = 34;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(719, 229);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(134, 61);
            button2.TabIndex = 35;
            button2.Text = "Restaurar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FloralWhite;
            label3.Location = new Point(715, 3);
            label3.Name = "label3";
            label3.Size = new Size(164, 41);
            label3.TabIndex = 36;
            label3.Text = "Check - IN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-21, 12);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 49);
            panel1.TabIndex = 37;
            // 
            // lb_Nome
            // 
            lb_Nome.AutoSize = true;
            lb_Nome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Nome.Location = new Point(49, 75);
            lb_Nome.Name = "lb_Nome";
            lb_Nome.Size = new Size(58, 23);
            lb_Nome.TabIndex = 3;
            lb_Nome.Text = "Nome";
            lb_Nome.Click += lb_Nome_Click;
            // 
            // lb_CPF
            // 
            lb_CPF.AutoSize = true;
            lb_CPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_CPF.Location = new Point(61, 144);
            lb_CPF.Name = "lb_CPF";
            lb_CPF.Size = new Size(40, 23);
            lb_CPF.TabIndex = 4;
            lb_CPF.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.Location = new Point(1, 223);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 32;
            label2.Text = "Telefone";
            label2.Click += label2_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(87, 212);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(32, 47);
            panel2.TabIndex = 38;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(728, 321);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(125, 61);
            button3.TabIndex = 39;
            button3.Text = "Limpar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(866, 552);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(br_Salvar);
            Controls.Add(br_Cancelar);
            Controls.Add(masktx_Cpf);
            Controls.Add(dateTimePicker1);
            Controls.Add(lb_DataNascimento);
            Controls.Add(lb_CPF);
            Controls.Add(lb_Nome);
            Controls.Add(tx_Nome);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_Nome;
        private Label lb_DataNascimento;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox masktx_Cpf;
        private Button br_Cancelar;
        private Button br_Salvar;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private Label label3;
        private Panel panel1;
        private Label lb_Nome;
        private Label lb_CPF;
        private Label label2;
        private Panel panel2;
        private Button button3;
    }
}