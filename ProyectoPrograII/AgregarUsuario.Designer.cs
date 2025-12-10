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
            txtId = new TextBox();
            txtApellido = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            lblDescripcion = new Label();
            lblMonto = new Label();
            grpDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // grpDetalles
            // 
            grpDetalles.BackColor = SystemColors.GradientActiveCaption;
            grpDetalles.Controls.Add(txtId);
            grpDetalles.Controls.Add(txtApellido);
            grpDetalles.Controls.Add(btnCancelar);
            grpDetalles.Controls.Add(btnGuardar);
            grpDetalles.Controls.Add(txtNombre);
            grpDetalles.Controls.Add(lblCategoria);
            grpDetalles.Controls.Add(lblDescripcion);
            grpDetalles.Controls.Add(lblMonto);
            grpDetalles.Font = new Font("Microsoft Sans Serif", 12F);
            grpDetalles.Location = new Point(12, 32);
            grpDetalles.Margin = new Padding(4, 3, 4, 3);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Padding = new Padding(4, 3, 4, 3);
            grpDetalles.Size = new Size(406, 288);
            grpDetalles.TabIndex = 2;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Información del Usuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 131);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(256, 26);
            txtId.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(128, 83);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(256, 26);
            txtApellido.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Location = new Point(83, 189);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            btnGuardar.Location = new Point(200, 189);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 35);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 26);
            txtNombre.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(25, 90);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(69, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Apellido:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(15, 138);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(107, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Identificacion:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(25, 39);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(69, 20);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Nombre:";
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(460, 338);
            Controls.Add(grpDetalles);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarUsuario";
            Load += AgregarUsuario_Load;
            grpDetalles.ResumeLayout(false);
            grpDetalles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDetalles;
        public TextBox txtId;
        public TextBox txtApellido;
        public Button btnCancelar;
        public Button btnGuardar;
        public TextBox txtNombre;
        private Label lblCategoria;
        private Label lblDescripcion;
        private Label lblMonto;
    }
}