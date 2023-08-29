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
            cb_Destino = new ComboBox();
            label5 = new Label();
            cb_Origem = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 106);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 42;
            label7.Text = "Data de volta";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 61);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 41;
            label6.Text = "Data de ida";
            label6.Click += label6_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(470, 101);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 40;
            dateTimePicker3.Value = new DateTime(2023, 8, 20, 0, 0, 0, 0);
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(470, 61);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 39;
            dateTimePicker2.Value = new DateTime(2023, 8, 20, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // cb_Destino
            // 
            cb_Destino.FormattingEnabled = true;
            cb_Destino.Items.AddRange(new object[] { "Ariquemes", "Cacoal", "Ji-Paraná", "Porto Velho", "Vilhena" });
            cb_Destino.Location = new Point(152, 98);
            cb_Destino.Name = "cb_Destino";
            cb_Destino.Size = new Size(151, 28);
            cb_Destino.TabIndex = 38;
            cb_Destino.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 98);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 37;
            label5.Text = "Destino";
            // 
            // cb_Origem
            // 
            cb_Origem.FormattingEnabled = true;
            cb_Origem.Items.AddRange(new object[] { "Ariquemes", "Cacoal", "Ji-Paraná", "Porto Velho", "Vilhena" });
            cb_Origem.Location = new Point(152, 53);
            cb_Origem.Name = "cb_Origem";
            cb_Origem.Size = new Size(151, 28);
            cb_Origem.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 53);
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
            comboBox2.Location = new Point(301, 187);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 32;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 190);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 31;
            label1.Text = "Qual é o peso da sua Bagagem?";
            label1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(670, 391);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 43;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 243);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 44;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 275);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 45;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 307);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 46;
            label10.Text = "label10";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 340);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 47;
            label11.Text = "label11";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(55, 374);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 48;
            label12.Text = "label12";
            label12.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(55, 152);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 24);
            checkBox1.TabIndex = 49;
            checkBox1.Text = "Adicionar bagagem";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(521, 395);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 50;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // InfoVoo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(cb_Destino);
            Controls.Add(label5);
            Controls.Add(cb_Origem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
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
        private ComboBox cb_Destino;
        private Label label5;
        private ComboBox cb_Origem;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private CheckBox checkBox1;
        private Label label13;
        private Button button2;
    }
}