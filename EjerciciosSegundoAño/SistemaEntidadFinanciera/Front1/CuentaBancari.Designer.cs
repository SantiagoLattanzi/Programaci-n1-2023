namespace Front1
{
    partial class CuentaBancari
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNumero = new TextBox();
            button1 = new Button();
            txtSaldos = new TextBox();
            txtTipos = new TextBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NumeroCuenta = new DataGridViewTextBoxColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            button2 = new Button();
            txtDepositar = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txtRetirar = new TextBox();
            button3 = new Button();
            label7 = new Label();
            txtTransfer = new TextBox();
            txtDestino = new TextBox();
            txtOrigen = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 125);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 25;
            label3.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 81);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 24;
            label2.Text = "Saldo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 23;
            label1.Text = "NumeroCuenta";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(26, 55);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 23);
            txtNumero.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(60, 172);
            button1.Name = "button1";
            button1.Size = new Size(116, 46);
            button1.TabIndex = 17;
            button1.Text = "Agregar CuentaBancaria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtSaldos
            // 
            txtSaldos.Location = new Point(26, 99);
            txtSaldos.Name = "txtSaldos";
            txtSaldos.Size = new Size(150, 23);
            txtSaldos.TabIndex = 26;
            txtSaldos.TextChanged += txtSaldos_TextChanged;
            // 
            // txtTipos
            // 
            txtTipos.Location = new Point(26, 143);
            txtTipos.Name = "txtTipos";
            txtTipos.Size = new Size(150, 23);
            txtTipos.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NumeroCuenta, Saldo, Tipo });
            dataGridView1.Location = new Point(203, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(526, 224);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            // 
            // NumeroCuenta
            // 
            NumeroCuenta.DataPropertyName = "NumeroCuenta";
            NumeroCuenta.HeaderText = "NumeroCuenta";
            NumeroCuenta.Name = "NumeroCuenta";
            // 
            // Saldo
            // 
            Saldo.DataPropertyName = "Saldo";
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // button2
            // 
            button2.Location = new Point(229, 286);
            button2.Name = "button2";
            button2.Size = new Size(82, 33);
            button2.TabIndex = 29;
            button2.Text = "Depositar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtDepositar
            // 
            txtDepositar.Location = new Point(192, 257);
            txtDepositar.Name = "txtDepositar";
            txtDepositar.Size = new Size(150, 23);
            txtDepositar.TabIndex = 30;
            txtDepositar.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 239);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 31;
            label4.Text = "Monto a depositar:";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 239);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 34;
            label6.Text = "Monto a retirar:";
            // 
            // txtRetirar
            // 
            txtRetirar.Location = new Point(361, 257);
            txtRetirar.Name = "txtRetirar";
            txtRetirar.Size = new Size(150, 23);
            txtRetirar.TabIndex = 33;
            // 
            // button3
            // 
            button3.Location = new Point(398, 286);
            button3.Name = "button3";
            button3.Size = new Size(82, 33);
            button3.TabIndex = 32;
            button3.Text = "Retirar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(608, 239);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 35;
            label7.Text = "Transferencia";
            // 
            // txtTransfer
            // 
            txtTransfer.Location = new Point(577, 286);
            txtTransfer.Name = "txtTransfer";
            txtTransfer.Size = new Size(150, 23);
            txtTransfer.TabIndex = 36;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(674, 331);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(76, 23);
            txtDestino.TabIndex = 37;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(557, 331);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(76, 23);
            txtOrigen.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(577, 268);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 39;
            label8.Text = "Monto a transferir:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(557, 313);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 40;
            label9.Text = "Id Origen";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(674, 313);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 41;
            label10.Text = "Id Destino";
            // 
            // button4
            // 
            button4.Location = new Point(608, 360);
            button4.Name = "button4";
            button4.Size = new Size(86, 33);
            button4.TabIndex = 42;
            button4.Text = "Transferir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CuentaBancari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(button4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtOrigen);
            Controls.Add(txtDestino);
            Controls.Add(txtTransfer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtRetirar);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(txtDepositar);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(txtTipos);
            Controls.Add(txtSaldos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(button1);
            Name = "CuentaBancari";
            Text = "CuentaBancaria";
            Load += CuentaBancari_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMonto;
        private TextBox txtEstado;
        private TextBox txtSaldo;

        private TextBox txtNumero;
        private Button button1;
        private TextBox txtSaldos;
        private TextBox txtTipos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NumeroCuenta;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewTextBoxColumn Tipo;
        private Button button2;
        private TextBox txtDepositar;
        private Label label6;
        private TextBox txtRetirar;
        private Button button3;
        private Label label7;
        private TextBox txtTransfer;
        private TextBox txtDestino;
        private TextBox txtOrigen;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button4;
    }
}