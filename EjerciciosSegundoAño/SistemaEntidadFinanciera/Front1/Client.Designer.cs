namespace Front1
{
    partial class Registro
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
            btnAceptar = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            listBoxCliente = new ListBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(211, 175);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 87);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(162, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(124, 23);
            txtNombre.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 48);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 127);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 20;
            label4.Text = "DNI";
            // 
            // listBoxCliente
            // 
            listBoxCliente.FormattingEnabled = true;
            listBoxCliente.ItemHeight = 15;
            listBoxCliente.Location = new Point(381, 45);
            listBoxCliente.Name = "listBoxCliente";
            listBoxCliente.Size = new Size(266, 154);
            listBoxCliente.TabIndex = 22;
            listBoxCliente.SelectedIndexChanged += listBoxCliente_SelectedIndexChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(162, 87);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(124, 23);
            txtApellido.TabIndex = 23;
            txtApellido.TextChanged += textBox1_TextChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(162, 124);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(124, 23);
            txtDni.TabIndex = 24;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 272);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(listBoxCliente);
            Controls.Add(label4);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtConfirmarContrasenia;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox listBoxCliente;
        private TextBox txtApellido;
        private TextBox txtDni;
    }
}