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
            txtSuma = new TextBox();
            textBox2 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            comboBox4 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label7 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            DataGriedGastos = new DataGridView();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DataGriedGastos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(131, 44);
            label1.TabIndex = 0;
            label1.Text = "Gastos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 121);
            label2.Name = "label2";
            label2.Size = new Size(245, 23);
            label2.TabIndex = 1;
            label2.Text = "Buscar Gasto por Detalle";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(286, 439);
            label3.Name = "label3";
            label3.Size = new Size(356, 34);
            label3.TabIndex = 2;
            label3.Text = "Total de gastos del mes:                        =";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(51, 343);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 3;
            label4.Text = "al";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(15, 209);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 4;
            label5.Text = "Buscar por Fecha";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 288);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 5;
            label6.Text = "Filtrar del dia: ";
            // 
            // txtSuma
            // 
            txtSuma.Font = new Font("Segoe UI", 12F);
            txtSuma.Location = new Point(637, 441);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 29);
            txtSuma.TabIndex = 6;
            txtSuma.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(15, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 29);
            textBox2.TabIndex = 7;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(189, 155);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(31, 23);
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
            iconButton2.Location = new Point(142, 241);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(31, 23);
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
            iconButton3.Location = new Point(142, 343);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(31, 23);
            iconButton3.TabIndex = 16;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 12F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(506, 441);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(104, 29);
            comboBox4.TabIndex = 17;
            comboBox4.Text = "Diciembre";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 314);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 26);
            dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(12, 366);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(108, 26);
            dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(15, 237);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(121, 26);
            dateTimePicker3.TabIndex = 20;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(260, 497);
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
            iconButton4.Location = new Point(829, 66);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(100, 32);
            iconButton4.TabIndex = 24;
            iconButton4.Text = "Agregar";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // DataGriedGastos
            // 
            DataGriedGastos.AllowDrop = true;
            DataGriedGastos.AllowUserToOrderColumns = true;
            DataGriedGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGriedGastos.BackgroundColor = Color.White;
            DataGriedGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGriedGastos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewButtonColumn1, Eliminar });
            DataGriedGastos.Location = new Point(289, 104);
            DataGriedGastos.Name = "DataGriedGastos";
            DataGriedGastos.RightToLeft = RightToLeft.Yes;
            DataGriedGastos.RowHeadersWidth = 51;
            DataGriedGastos.Size = new Size(640, 317);
            DataGriedGastos.TabIndex = 28;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewButtonColumn1.FillWeight = 164.467041F;
            dataGridViewButtonColumn1.HeaderText = "";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Width = 35;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Eliminar.FillWeight = 35.5329933F;
            Eliminar.HeaderText = "";
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 35;
            // 
            // frmVerGastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1209, 497);
            Controls.Add(DataGriedGastos);
            Controls.Add(iconButton4);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(textBox2);
            Controls.Add(txtSuma);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "frmVerGastos";
            Text = "Ver_Gastos";
            Load += frmVerGastos_Load;
            ((System.ComponentModel.ISupportInitialize)DataGriedGastos).EndInit();
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
        private TextBox txtSuma;
        private TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton4;
        private DataGridView DataGriedGastos;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn Eliminar;
    }
}