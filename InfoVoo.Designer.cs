namespace Cadastro_Check_in
{
    partial class InfoVoo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            label6 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox4 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            lb_Bagagem = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 189);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 42;
            label7.Text = "Data de volta";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 116);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 41;
            label6.Text = "Data de ida";
            label6.Click += label6_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(470, 189);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 40;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(458, 113);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 39;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Ariquemes", "Cacoal", "Ji-Paraná", "Porto Velho", "Vilhena" });
            comboBox4.Location = new Point(152, 172);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 38;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 175);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 37;
            label5.Text = "Destino";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Ariquemes", "Cacoal", "Ji-Paraná", "Porto Velho", "Vilhena" });
            comboBox3.Location = new Point(152, 113);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 113);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 35;
            label4.Text = "Origem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 167);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 170);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0 ", "1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10 ", "11 ", "12 ", "13 ", "14 ", "15 ", "16 ", "17 ", "18 ", "19 ", "20 ", "21 ", "22 ", "23 " });
            comboBox2.Location = new Point(365, 310);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 32;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 313);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 31;
            label1.Text = "Qual é o peso da sua Bagagem?";
            label1.Visible = false;
            // 
            // lb_Bagagem
            // 
            lb_Bagagem.AutoSize = true;
            lb_Bagagem.Location = new Point(100, 245);
            lb_Bagagem.Name = "lb_Bagagem";
            lb_Bagagem.Size = new Size(203, 20);
            lb_Bagagem.TabIndex = 30;
            lb_Bagagem.Text = "Deseja Despachar Bagagem?";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sim", "Não" });
            comboBox1.Location = new Point(365, 237);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(592, 347);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 43;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InfoVoo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox4);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(lb_Bagagem);
            Controls.Add(comboBox1);
            Name = "InfoVoo";
            Text = "InfoVoo";
            Load += InfoVoo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox4;
        private Label label5;
        private ComboBox comboBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private Label lb_Bagagem;
        private ComboBox comboBox1;
        private Button button1;
    }
}