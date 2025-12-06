namespace ProyectoPrograII
{
    partial class AgregarCategoria
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Location = new Point(213, 320);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 47);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            btnGuardar.Location = new Point(345, 320);
            btnGuardar.Margin = new Padding(5, 4, 5, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 47);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 12F);
            txtDescripcion.Location = new Point(213, 208);
            txtDescripcion.Margin = new Padding(5, 4, 5, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(266, 75);
            txtDescripcion.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 12F);
            lblDescripcion.Location = new Point(94, 212);
            lblDescripcion.Margin = new Padding(5, 0, 5, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(120, 25);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F);
            txtNombre.Location = new Point(213, 154);
            txtNombre.Margin = new Padding(5, 4, 5, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 30);
            txtNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F);
            lblNombre.Location = new Point(16, 158);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(204, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre de Categoría:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(381, 66);
            label1.TabIndex = 12;
            label1.Text = "Agregar Categoria";
            // 
            // AgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(522, 450);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "AgregarCategoria";
            Text = "AgregarCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnCancelar;
        public Button btnGuardar;
        public TextBox txtDescripcion;
        public Label lblDescripcion;
        public TextBox txtNombre;
        public Label lblNombre;
        private Label label1;
    }
}