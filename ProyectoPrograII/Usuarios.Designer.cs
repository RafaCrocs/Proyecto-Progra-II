namespace ProyectoPrograII
{
    partial class Usuarios
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
            label1 = new Label();
            grpDetalles = new GroupBox();
            txtMonto = new TextBox();
            lblCategoria = new Label();
            lblDescripcion = new Label();
            lblMonto = new Label();
            dataGridView1 = new DataGridView();
            btnCancelar = new Button();
            btnGuardar = new Button();
            Descripcion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(452, 460);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
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
            grpDetalles.Location = new Point(32, 101);
            grpDetalles.Margin = new Padding(4, 3, 4, 3);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Padding = new Padding(4, 3, 4, 3);
            grpDetalles.Size = new Size(406, 288);
            grpDetalles.TabIndex = 1;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Información del Usuario";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(128, 35);
            txtMonto.Margin = new Padding(4, 3, 4, 3);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(256, 26);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(24, 89);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(69, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Apellido:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(13, 137);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(107, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Identificacion:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(24, 38);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(69, 20);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Descripcion, Categoria, Fecha, Monto, Editar });
            dataGridView1.Location = new Point(485, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(730, 351);
            dataGridView1.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Location = new Point(72, 197);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            btnGuardar.Location = new Point(188, 197);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.FillWeight = 12.82051F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.FillWeight = 12.82051F;
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Fecha
            // 
            Fecha.FillWeight = 274.358978F;
            Fecha.HeaderText = "Fecha de Registro";
            Fecha.Name = "Fecha";
            Fecha.Width = 150;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.Width = 80;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.Name = "Editar";
            Editar.Width = 35;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 83);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 26);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 131);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 26);
            textBox2.TabIndex = 9;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1230, 460);
            Controls.Add(dataGridView1);
            Controls.Add(grpDetalles);
            Controls.Add(label1);
            Name = "Usuarios";
            Text = "Usuarios";
            grpDetalles.ResumeLayout(false);
            grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grpDetalles;
        public TextBox txtMonto;
        private Label lblCategoria;
        private Label lblDescripcion;
        private Label lblMonto;
        private DataGridView dataGridView1;
        public Button btnCancelar;
        public Button btnGuardar;
        public TextBox textBox2;
        public TextBox textBox1;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewButtonColumn Editar;
    }
}