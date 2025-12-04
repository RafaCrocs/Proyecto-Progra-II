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
            FontAwesome.Sharp.IconMenuItem iconMenuItem2;
            dateTimePicker1 = new DateTimePicker();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1 = new MenuStrip();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip2 = new MenuStrip();
            sistemaDeGestionDeGastosToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption;
            dateTimePicker1.Location = new Point(790, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem2, iconMenuItem3, iconMenuItem4 });
            menuStrip1.Location = new Point(0, 57);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1002, 50);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.Font = new Font("Segoe UI", 15F);
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Male;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.IconSize = 35;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(134, 46);
            iconMenuItem2.Text = "Usuarios";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.Font = new Font("Segoe UI", 15F);
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.IconSize = 35;
            iconMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(151, 46);
            iconMenuItem3.Text = "Ver Gastos";
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.Font = new Font("Segoe UI", 15F);
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.IconSize = 35;
            iconMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(152, 46);
            iconMenuItem4.Text = "Categorias";
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = SystemColors.GradientActiveCaption;
            menuStrip2.Items.AddRange(new ToolStripItem[] { sistemaDeGestionDeGastosToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1002, 57);
            menuStrip2.TabIndex = 10;
            menuStrip2.Text = "menuStrip2";
            // 
            // sistemaDeGestionDeGastosToolStripMenuItem1
            // 
            sistemaDeGestionDeGastosToolStripMenuItem1.Font = new Font("Segoe UI", 20F);
            sistemaDeGestionDeGastosToolStripMenuItem1.Name = "sistemaDeGestionDeGastosToolStripMenuItem1";
            sistemaDeGestionDeGastosToolStripMenuItem1.Size = new Size(380, 53);
            sistemaDeGestionDeGastosToolStripMenuItem1.Text = "Sistema de Gestion de Gastos";
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 401);
            panel1.TabIndex = 11;
            // 
            // frm_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1002, 508);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "frm_Inicio";
            Text = "frm_Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem sistemaDeGestionDeGastosToolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private Panel panel1;
    }
}