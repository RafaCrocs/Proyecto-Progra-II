namespace ProyectoPrograII
{
    partial class frmUsuarios
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
            DataGriedUsuarios = new DataGridView();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            label1 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DataGriedUsuarios).BeginInit();
            SuspendLayout();
            // 
            // DataGriedUsuarios
            // 
            DataGriedUsuarios.AllowDrop = true;
            DataGriedUsuarios.AllowUserToOrderColumns = true;
            DataGriedUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGriedUsuarios.BackgroundColor = Color.White;
            DataGriedUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGriedUsuarios.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            DataGriedUsuarios.Location = new Point(78, 118);
            DataGriedUsuarios.Name = "DataGriedUsuarios";
            DataGriedUsuarios.RightToLeft = RightToLeft.Yes;
            DataGriedUsuarios.RowHeadersWidth = 51;
            DataGriedUsuarios.Size = new Size(761, 270);
            DataGriedUsuarios.TabIndex = 13;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.FillWeight = 164.467041F;
            Editar.HeaderText = "";
            Editar.Name = "Editar";
            Editar.Width = 35;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Eliminar.FillWeight = 35.5329933F;
            Eliminar.HeaderText = "";
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 35;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(43, 23);
            label1.Name = "label1";
            label1.Size = new Size(186, 48);
            label1.TabIndex = 14;
            label1.Text = "Usuarios";
            // 
            // iconButton4
            // 
            iconButton4.Font = new Font("Segoe UI", 12F);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(771, 53);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(100, 32);
            iconButton4.TabIndex = 25;
            iconButton4.Text = "Agregar";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(947, 460);
            Controls.Add(iconButton4);
            Controls.Add(label1);
            Controls.Add(DataGriedUsuarios);
            Name = "frmUsuarios";
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)DataGriedUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DataGriedUsuarios;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}