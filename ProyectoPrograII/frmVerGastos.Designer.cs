namespace ProyectoPrograII
{
    partial class frmVerGastos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            comboBox4 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label7 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(17, 57);
            label1.Name = "label1";
            label1.Size = new Size(150, 59);
            label1.TabIndex = 0;
            label1.Text = "Gastos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 211);
            label2.Name = "label2";
            label2.Size = new Size(280, 31);
            label2.TabIndex = 1;
            label2.Text = "Buscar Gasto por Detalle";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(507, 591);
            label3.Name = "label3";
            label3.Size = new Size(407, 45);
            label3.TabIndex = 2;
            label3.Text = "Total de gastos del mes:                        =";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(279, 347);
            label4.Name = "label4";
            label4.Size = new Size(30, 27);
            label4.TabIndex = 3;
            label4.Text = "al";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(17, 279);
            label5.Name = "label5";
            label5.Size = new Size(157, 33);
            label5.TabIndex = 4;
            label5.Text = "Buscar por Fecha";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(17, 343);
            label6.Name = "label6";
            label6.Size = new Size(125, 31);
            label6.TabIndex = 5;
            label6.Text = "Filtrar del dia: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(909, 593);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 34);
            textBox1.TabIndex = 6;
            textBox1.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(247, 209);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 34);
            textBox2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Descripcion, Categoria, Fecha, Monto, Editar, Borrar });
            dataGridView1.Location = new Point(591, 87);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 496);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.FillWeight = 12.82051F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.FillWeight = 12.82051F;
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            // 
            // Fecha
            // 
            Fecha.FillWeight = 274.358978F;
            Fecha.HeaderText = "Fecha de Registro";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 150;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 80;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Width = 35;
            // 
            // Borrar
            // 
            Borrar.HeaderText = "";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            Borrar.Width = 35;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(444, 212);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(35, 31);
            iconButton1.TabIndex = 14;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Font = new Font("Microsoft Sans Serif", 12F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 15;
            iconButton2.Location = new Point(326, 281);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(35, 31);
            iconButton2.TabIndex = 15;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Font = new Font("Segoe UI", 12F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 15;
            iconButton3.Location = new Point(446, 348);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(35, 31);
            iconButton3.TabIndex = 16;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 12F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(759, 593);
            comboBox4.Margin = new Padding(3, 4, 3, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(118, 36);
            comboBox4.TabIndex = 17;
            comboBox4.Text = "Noviembre";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(147, 343);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 30);
            dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(315, 344);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(123, 30);
            dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(181, 279);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(138, 30);
            dateTimePicker3.TabIndex = 20;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(501, 663);
            label7.TabIndex = 23;
            // 
            // iconButton4
            // 
            iconButton4.Font = new Font("Segoe UI", 12F);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(1210, 36);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(114, 43);
            iconButton4.TabIndex = 24;
            iconButton4.Text = "Agregar";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // frmVerGastos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1382, 663);
            Controls.Add(iconButton4);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVerGastos";
            Text = "Ver_Gastos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}