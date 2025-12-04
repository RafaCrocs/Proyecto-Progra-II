namespace ProyectoPrograII
{
    partial class frmCategorias
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Categorias = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            asd = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F);
            lblNombre.Location = new Point(9, 166);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(164, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre de Categoría:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F);
            txtNombre.Location = new Point(181, 163);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 26);
            txtNombre.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 12F);
            lblDescripcion.Location = new Point(77, 206);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 12F);
            txtDescripcion.Location = new Point(181, 203);
            txtDescripcion.Margin = new Padding(4, 3, 4, 3);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(233, 57);
            txtDescripcion.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            btnGuardar.Location = new Point(297, 287);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 35);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Location = new Point(181, 287);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(984, 76);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(218, 54);
            label2.TabIndex = 7;
            label2.Text = "Categorias";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Categorias, Descripcion, asd });
            dataGridView1.Location = new Point(478, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(455, 275);
            dataGridView1.TabIndex = 8;
            // 
            // Categorias
            // 
            Categorias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categorias.HeaderText = "Categorias";
            Categorias.Name = "Categorias";
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // asd
            // 
            asd.HeaderText = "";
            asd.Name = "asd";
            asd.Width = 30;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(984, 433);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Categorias;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewButtonColumn asd;
    }
}