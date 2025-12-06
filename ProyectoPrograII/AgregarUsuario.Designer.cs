namespace ProyectoPrograII
{
    partial class AgregarUsuario
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
            grpDetalles = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtMonto = new TextBox();
            lblCategoria = new Label();
            lblDescripcion = new Label();
            lblMonto = new Label();
            grpDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // grpDetalles
            // 
            grpDetalles.BackColor = SystemColors.GradientActiveCaption;
            grpDetalles.Controls.Add(textBox2);
            grpDetalles.Controls.Add(textBox1);
            grpDetalles.Controls.Add(btnCancelar);
            grpDetalles.Controls.Add(btnGuardar);
            grpDetalles.Controls.Add(txtMonto);
            grpDetalles.Controls.Add(lblCategoria);
            grpDetalles.Controls.Add(lblDescripcion);
            grpDetalles.Controls.Add(lblMonto);
            grpDetalles.Font = new Font("Microsoft Sans Serif", 12F);
            grpDetalles.Location = new Point(14, 42);
            grpDetalles.Margin = new Padding(5, 4, 5, 4);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Padding = new Padding(5, 4, 5, 4);
            grpDetalles.Size = new Size(464, 384);
            grpDetalles.TabIndex = 2;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Información del Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 175);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 30);
            textBox2.TabIndex = 9;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 111);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 30);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Location = new Point(95, 252);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 47);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            btnGuardar.Location = new Point(228, 252);
            btnGuardar.Margin = new Padding(5, 4, 5, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 47);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(146, 47);
            txtMonto.Margin = new Padding(5, 4, 5, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(292, 30);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(29, 120);
            lblCategoria.Margin = new Padding(5, 0, 5, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 25);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Apellido:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(17, 184);
            lblDescripcion.Margin = new Padding(5, 0, 5, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(131, 25);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Identificacion:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(29, 52);
            lblMonto.Margin = new Padding(5, 0, 5, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(87, 25);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Nombre:";
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(526, 450);
            Controls.Add(grpDetalles);
            Name = "AgregarUsuario";
            Text = "AgregarUsuario";
            grpDetalles.ResumeLayout(false);
            grpDetalles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDetalles;
        public TextBox textBox2;
        public TextBox textBox1;
        public Button btnCancelar;
        public Button btnGuardar;
        public TextBox txtMonto;
        private Label lblCategoria;
        private Label lblDescripcion;
        private Label lblMonto;
    }
}