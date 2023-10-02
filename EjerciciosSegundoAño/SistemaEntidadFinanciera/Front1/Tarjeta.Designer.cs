namespace Front1
{
    partial class Tarjeta
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NumeroTarjeta = new DataGridViewTextBoxColumn();
            LimiteCredito = new DataGridViewTextBoxColumn();
            SaldoDisponible = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            MontoDeuda = new DataGridViewTextBoxColumn();
            button1 = new Button();
            txtNumero = new TextBox();
            txtLimite = new TextBox();
            txtSaldo = new TextBox();
            txtMonto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            txtPagar = new TextBox();
            label6 = new Label();
            button4 = new Button();
            txtEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NumeroTarjeta, LimiteCredito, SaldoDisponible, Estado, MontoDeuda });
            dataGridView1.Location = new Point(224, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(648, 221);
            dataGridView1.TabIndex = 0;
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
            // NumeroTarjeta
            // 
            NumeroTarjeta.DataPropertyName = "NumeroTarjeta";
            NumeroTarjeta.HeaderText = "NumeroTarjeta";
            NumeroTarjeta.Name = "NumeroTarjeta";
            // 
            // LimiteCredito
            // 
            LimiteCredito.DataPropertyName = "LimiteCredito";
            LimiteCredito.HeaderText = "LimiteCredito";
            LimiteCredito.Name = "LimiteCredito";
            // 
            // SaldoDisponible
            // 
            SaldoDisponible.DataPropertyName = "SaldoDisponible";
            SaldoDisponible.HeaderText = "SaldoDisponible";
            SaldoDisponible.Name = "SaldoDisponible";
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // MontoDeuda
            // 
            MontoDeuda.DataPropertyName = "MontoDeuda";
            MontoDeuda.HeaderText = "MontoDeuda";
            MontoDeuda.Name = "MontoDeuda";
            // 
            // button1
            // 
            button1.Location = new Point(81, 238);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 1;
            button1.Text = "AgregarTarjeta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(25, 33);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 23);
            txtNumero.TabIndex = 6;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(25, 77);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(150, 23);
            txtLimite.TabIndex = 7;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(25, 121);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(150, 23);
            txtSaldo.TabIndex = 8;
            txtSaldo.TextChanged += txtSaldo_TextChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(25, 209);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 23);
            txtMonto.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 11;
            label1.Text = "NumeroTarjeta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 12;
            label2.Text = "LimiteCredito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 13;
            label3.Text = "SaldoDisponible";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 147);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 14;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 191);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 15;
            label5.Text = "MontoDeuda";
            // 
            // button3
            // 
            button3.Location = new Point(271, 282);
            button3.Name = "button3";
            button3.Size = new Size(150, 78);
            button3.TabIndex = 35;
            button3.Text = "Pausar Tarjeta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(466, 314);
            button2.Name = "button2";
            button2.Size = new Size(111, 46);
            button2.TabIndex = 36;
            button2.Text = "Pagar Tarjeta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtPagar
            // 
            txtPagar.Location = new Point(445, 282);
            txtPagar.Name = "txtPagar";
            txtPagar.Size = new Size(150, 23);
            txtPagar.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 264);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 38;
            label6.Text = "Monto a Pagar";
            // 
            // button4
            // 
            button4.Location = new Point(621, 282);
            button4.Name = "button4";
            button4.Size = new Size(150, 78);
            button4.TabIndex = 39;
            button4.Text = "Resumen Tarjeta";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtEstado
            // 
            txtEstado.FormattingEnabled = true;
            txtEstado.Items.AddRange(new object[] { "Activa", "Pausada" });
            txtEstado.Location = new Point(25, 165);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(150, 23);
            txtEstado.TabIndex = 40;
            txtEstado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Tarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 613);
            Controls.Add(txtEstado);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(txtPagar);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(txtSaldo);
            Controls.Add(txtLimite);
            Controls.Add(txtNumero);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Tarjeta";
            Text = "v";
            Load += Tarjeta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtNumero;
        private TextBox txtLimite;
        private TextBox txtSaldo;
        private TextBox txtMonto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NumeroTarjeta;
        private DataGridViewTextBoxColumn LimiteCredito;
        private DataGridViewTextBoxColumn SaldoDisponible;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn MontoDeuda;
        private Button button3;
        private Button button2;
        private TextBox txtPagar;
        private Label label6;
        private Button button4;
        private ComboBox txtEstado;
    }
}