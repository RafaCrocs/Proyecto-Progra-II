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
            cmbCategoria = new ComboBox();
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
            grpDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // grpDetalles
            // 
            grpDetalles.Controls.Add(dtpFecha);
            grpDetalles.Controls.Add(cmbCategoria);
            grpDetalles.Controls.Add(txtDescripcion);
            grpDetalles.Controls.Add(txtMonto);
            grpDetalles.Controls.Add(lblFecha);
            grpDetalles.Controls.Add(lblCategoria);
            grpDetalles.Controls.Add(lblDescripcion);
            grpDetalles.Controls.Add(lblMonto);
            grpDetalles.Font = new Font("Microsoft Sans Serif", 12F);
            grpDetalles.Location = new Point(23, 145);
            grpDetalles.Margin = new Padding(5, 4, 5, 4);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Padding = new Padding(5, 4, 5, 4);
            grpDetalles.Size = new Size(480, 384);
            grpDetalles.TabIndex = 0;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Información del Gasto";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(144, 217);
            dtpFecha.Margin = new Padding(5, 4, 5, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(292, 30);
            dtpFecha.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(144, 160);
            cmbCategoria.Margin = new Padding(5, 4, 5, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(292, 33);
            cmbCategoria.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(144, 39);
            txtDescripcion.Margin = new Padding(5, 4, 5, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(292, 100);
            txtDescripcion.TabIndex = 4;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(144, 279);
            txtMonto.Margin = new Padding(5, 4, 5, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(292, 30);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(24, 221);
            lblFecha.Margin = new Padding(5, 0, 5, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(73, 25);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(24, 164);
            lblCategoria.Margin = new Padding(5, 0, 5, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(103, 25);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(24, 44);
            lblDescripcion.Margin = new Padding(5, 0, 5, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(120, 25);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(24, 283);
            lblMonto.Margin = new Padding(5, 0, 5, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(73, 25);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            btnGuardar.Location = new Point(270, 557);
            btnGuardar.Margin = new Padding(5, 4, 5, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 47);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Actualizar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Location = new Point(128, 557);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 47);
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
            label1.Size = new Size(594, 105);
            label1.TabIndex = 14;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(275, 59);
            label2.TabIndex = 15;
            label2.Text = "Editar Gastos";
            // 
            // frmModificarGasto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(594, 647);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDetalles);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "frmModificarGasto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMosificarGasto";
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
        public System.Windows.Forms.ComboBox cmbCategoria;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtMonto;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        private Label label1;
        private Label label2;
    }
}