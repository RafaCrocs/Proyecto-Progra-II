namespace ProyectoPrograII
{
    partial class frmModificarGasto
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
            dtpFecha = new DateTimePicker();
            cmbCategorias = new ComboBox();
            txtDescripcion = new TextBox();
            txtMonto = new TextBox();
            lblFecha = new Label();
            lblCategoria = new Label();
            lblDescripcion = new Label();
            lblMonto = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbUsuarios = new ComboBox();
            grpDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // grpDetalles
            // 
            grpDetalles.Controls.Add(cmbUsuarios);
            grpDetalles.Controls.Add(label3);
            grpDetalles.Controls.Add(dtpFecha);
            grpDetalles.Controls.Add(cmbCategorias);
            grpDetalles.Controls.Add(txtDescripcion);
            grpDetalles.Controls.Add(txtMonto);
            grpDetalles.Controls.Add(lblFecha);
            grpDetalles.Controls.Add(lblCategoria);
            grpDetalles.Controls.Add(lblDescripcion);
            grpDetalles.Controls.Add(lblMonto);
            grpDetalles.Font = new Font("Microsoft Sans Serif", 12F);
            grpDetalles.Location = new Point(20, 109);
            grpDetalles.Margin = new Padding(4, 3, 4, 3);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Padding = new Padding(4, 3, 4, 3);
            grpDetalles.Size = new Size(420, 288);
            grpDetalles.TabIndex = 0;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Información del Gasto";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(126, 195);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(256, 26);
            dtpFecha.TabIndex = 3;
            // 
            // cmbCategorias
            // 
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(126, 152);
            cmbCategorias.Margin = new Padding(4, 3, 4, 3);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(256, 28);
            cmbCategorias.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(126, 29);
            txtDescripcion.Margin = new Padding(4, 3, 4, 3);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(256, 76);
            txtDescripcion.TabIndex = 4;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(126, 241);
            txtMonto.Margin = new Padding(4, 3, 4, 3);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(256, 26);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(21, 198);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 20);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(21, 155);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(82, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(21, 33);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(21, 244);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(58, 20);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            btnGuardar.Location = new Point(236, 418);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 35);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Actualizar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Location = new Point(112, 418);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(520, 79);
            label1.TabIndex = 14;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(241, 44);
            label2.TabIndex = 15;
            label2.Text = "Editar Gastos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 116);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 5;
            label3.Text = "Usuario:";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(126, 118);
            cmbUsuarios.Margin = new Padding(4, 3, 4, 3);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(256, 28);
            cmbUsuarios.TabIndex = 6;
            // 
            // frmModificarGasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(520, 485);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDetalles);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmModificarGasto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMosificarGasto";
            Load += frmModificarGasto_Load;
            grpDetalles.ResumeLayout(false);
            grpDetalles.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMonto;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ComboBox cmbCategorias;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtMonto;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        private Label label1;
        private Label label2;
        public ComboBox cmbUsuarios;
        private Label label3;
    }
}