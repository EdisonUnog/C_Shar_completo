namespace BaseWinFormsApp
{
    partial class FrmRobotic
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
            lstRobots = new ListBox();
            rtnVentaAlquiler = new RichTextBox();
            btnVendeAlquila = new Button();
            lblRobots = new Label();
            lblVendidos = new Label();
            btnSalir = new Button();
            btnInformacion = new Button();
            SuspendLayout();
            // 
            // lstRobots
            // 
            lstRobots.FormattingEnabled = true;
            lstRobots.ItemHeight = 15;
            lstRobots.Location = new Point(12, 38);
            lstRobots.Name = "lstRobots";
            lstRobots.Size = new Size(274, 349);
            lstRobots.TabIndex = 0;
            // 
            // rtnVentaAlquiler
            // 
            rtnVentaAlquiler.Location = new Point(292, 38);
            rtnVentaAlquiler.Name = "rtnVentaAlquiler";
            rtnVentaAlquiler.Size = new Size(262, 508);
            rtnVentaAlquiler.TabIndex = 1;
            rtnVentaAlquiler.Text = "";
            // 
            // btnVendeAlquila
            // 
            btnVendeAlquila.BackColor = Color.FromArgb(128, 255, 255);
            btnVendeAlquila.FlatStyle = FlatStyle.Flat;
            btnVendeAlquila.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendeAlquila.Location = new Point(12, 393);
            btnVendeAlquila.Name = "btnVendeAlquila";
            btnVendeAlquila.Size = new Size(274, 47);
            btnVendeAlquila.TabIndex = 2;
            btnVendeAlquila.Text = "Negociar";
            btnVendeAlquila.UseVisualStyleBackColor = false;
            btnVendeAlquila.Click += btnNegociar_Click;
            // 
            // lblRobots
            // 
            lblRobots.AutoSize = true;
            lblRobots.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRobots.ForeColor = Color.White;
            lblRobots.Location = new Point(12, 9);
            lblRobots.Name = "lblRobots";
            lblRobots.Size = new Size(161, 17);
            lblRobots.TabIndex = 3;
            lblRobots.Text = "Lista Robots Disponibles";
            // 
            // lblVendidos
            // 
            lblVendidos.AutoSize = true;
            lblVendidos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVendidos.ForeColor = Color.White;
            lblVendidos.Location = new Point(292, 9);
            lblVendidos.Name = "lblVendidos";
            lblVendidos.Size = new Size(106, 17);
            lblVendidos.TabIndex = 5;
            lblVendidos.Text = "Venta / Alquiler";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(12, 499);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(274, 47);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.BackColor = Color.FromArgb(128, 255, 255);
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformacion.Location = new Point(12, 446);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(274, 47);
            btnInformacion.TabIndex = 9;
            btnInformacion.Text = "Ver Informacion";
            btnInformacion.UseVisualStyleBackColor = false;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // FrmRobotic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(568, 559);
            Controls.Add(btnInformacion);
            Controls.Add(btnSalir);
            Controls.Add(lblVendidos);
            Controls.Add(lblRobots);
            Controls.Add(btnVendeAlquila);
            Controls.Add(rtnVentaAlquiler);
            Controls.Add(lstRobots);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRobotic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRobotic";
            FormClosing += FrmRobotic_FormClosing;
            Load += FrmRobotic_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstRobots;
        private RichTextBox rtnVentaAlquiler;
        private Button btnVendeAlquila;
        private Label lblRobots;
        private Label lblVendidos;
        private Button btnSalir;
        private Button btnInformacion;
    }
}