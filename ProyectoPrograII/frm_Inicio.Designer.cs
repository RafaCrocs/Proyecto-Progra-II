namespace ProyectoPrograII
{
    partial class frm_Inicio
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 54);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 15F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(96, 270);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(180, 56);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Agregar Gasto";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.HighlightText;
            iconButton2.Font = new Font("Segoe UI", 15F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(96, 165);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(180, 56);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Ver Gastos";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.Font = new Font("Segoe UI", 15F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(356, 165);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(194, 56);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Modificar Gasto";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.Font = new Font("Segoe UI", 15F);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(356, 270);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(185, 56);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "Categorias";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.Font = new Font("Segoe UI", 15F);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.PersonRunning;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(608, 393);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(160, 45);
            iconButton5.TabIndex = 5;
            iconButton5.Text = "Cerrar Sesion";
            iconButton5.TextAlign = ContentAlignment.MiddleRight;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(60, 120);
            label2.Name = "label2";
            label2.Size = new Size(508, 238);
            label2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption;
            dateTimePicker1.Location = new Point(588, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(60, 96);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 8;
            label3.Text = "Nombre Usuario";
            // 
            // frm_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "frm_Inicio";
            Text = "frm_Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}