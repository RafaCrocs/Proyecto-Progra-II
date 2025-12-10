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
            FontAwesome.Sharp.IconMenuItem MenuUsuarios;
            dateTimePicker1 = new DateTimePicker();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1 = new MenuStrip();
            MenuVerGastos = new FontAwesome.Sharp.IconMenuItem();
            MenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            menuStrip2 = new MenuStrip();
            sistemaDeGestionDeGastosToolStripMenuItem1 = new ToolStripMenuItem();
            Contenedor = new Panel();
            MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            Contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.Font = new Font("Segoe UI", 15F);
            MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.Male;
            MenuUsuarios.IconColor = Color.Black;
            MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuarios.IconSize = 35;
            MenuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(134, 46);
            MenuUsuarios.Text = "Usuarios";
            MenuUsuarios.Click += MenuUsuarios_Click;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuUsuarios, MenuVerGastos, MenuCategorias });
            menuStrip1.Location = new Point(0, 57);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1002, 50);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuVerGastos
            // 
            MenuVerGastos.Font = new Font("Segoe UI", 15F);
            MenuVerGastos.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            MenuVerGastos.IconColor = Color.Black;
            MenuVerGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVerGastos.IconSize = 35;
            MenuVerGastos.ImageScaling = ToolStripItemImageScaling.None;
            MenuVerGastos.Name = "MenuVerGastos";
            MenuVerGastos.Size = new Size(151, 46);
            MenuVerGastos.Text = "Ver Gastos";
            MenuVerGastos.Click += MenuVerGastos_Click;
            // 
            // MenuCategorias
            // 
            MenuCategorias.Font = new Font("Segoe UI", 15F);
            MenuCategorias.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            MenuCategorias.IconColor = Color.Black;
            MenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCategorias.IconSize = 35;
            MenuCategorias.ImageScaling = ToolStripItemImageScaling.None;
            MenuCategorias.Name = "MenuCategorias";
            MenuCategorias.Size = new Size(152, 46);
            MenuCategorias.Text = "Categorias";
            MenuCategorias.Click += MenuCategorias_Click;
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
            // Contenedor
            // 
            Contenedor.Controls.Add(dateTimePicker1);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(0, 107);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1002, 401);
            Contenedor.TabIndex = 11;
            // 
            // frm_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1002, 508);
            Controls.Add(Contenedor);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "frm_Inicio";
            Text = "frm_Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            Contenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem sistemaDeGestionDeGastosToolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem MenuVerGastos;
        private FontAwesome.Sharp.IconMenuItem MenuCategorias;
        private Panel Contenedor;
    }
}