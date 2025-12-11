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
            label2 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            DataGriedCategorias = new DataGridView();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DataGriedCategorias).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(31, 22);
            label2.Name = "label2";
            label2.Size = new Size(218, 54);
            label2.TabIndex = 7;
            label2.Text = "Categorias";
            // 
            // iconButton4
            // 
            iconButton4.Font = new Font("Segoe UI", 12F);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(795, 100);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(100, 32);
            iconButton4.TabIndex = 26;
            iconButton4.Text = "Agregar";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // DataGriedCategorias
            // 
            DataGriedCategorias.AllowDrop = true;
            DataGriedCategorias.AllowUserToOrderColumns = true;
            DataGriedCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGriedCategorias.BackgroundColor = Color.White;
            DataGriedCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGriedCategorias.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            DataGriedCategorias.Location = new Point(134, 138);
            DataGriedCategorias.Name = "DataGriedCategorias";
            DataGriedCategorias.RightToLeft = RightToLeft.Yes;
            DataGriedCategorias.RowHeadersWidth = 51;
            DataGriedCategorias.Size = new Size(761, 270);
            DataGriedCategorias.TabIndex = 27;
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
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 542);
            Controls.Add(DataGriedCategorias);
            Controls.Add(iconButton4);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)DataGriedCategorias).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private DataGridView DataGriedCategorias;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}