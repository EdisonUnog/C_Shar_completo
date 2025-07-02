namespace BaseWinFormsApp
{
    partial class FrmLibreria
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
            rtbInforme = new RichTextBox();
            lstStock = new ListBox();
            btnVender = new Button();
            btnVerInformacion = new Button();
            btnSalir = new Button();
            lblListaStock = new Label();
            lblVentas = new Label();
            SuspendLayout();
            // 
            // rtbInforme
            // 
            rtbInforme.BackColor = Color.FromArgb(224, 224, 224);
            rtbInforme.Location = new Point(294, 50);
            rtbInforme.Name = "rtbInforme";
            rtbInforme.Size = new Size(266, 505);
            rtbInforme.TabIndex = 0;
            rtbInforme.Text = "";
            // 
            // lstStock
            // 
            lstStock.BackColor = Color.FromArgb(224, 224, 224);
            lstStock.FormattingEnabled = true;
            lstStock.ItemHeight = 15;
            lstStock.Location = new Point(22, 50);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(266, 334);
            lstStock.TabIndex = 1;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(128, 255, 255);
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVender.Location = new Point(22, 399);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(266, 48);
            btnVender.TabIndex = 2;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnVerInformacion
            // 
            btnVerInformacion.BackColor = Color.FromArgb(128, 255, 255);
            btnVerInformacion.FlatStyle = FlatStyle.Flat;
            btnVerInformacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerInformacion.Location = new Point(22, 453);
            btnVerInformacion.Name = "btnVerInformacion";
            btnVerInformacion.Size = new Size(266, 48);
            btnVerInformacion.TabIndex = 3;
            btnVerInformacion.Text = "Ver Informacion";
            btnVerInformacion.UseVisualStyleBackColor = false;
            btnVerInformacion.Click += btnVerInformacion_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(22, 507);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(266, 48);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblListaStock
            // 
            lblListaStock.AutoSize = true;
            lblListaStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaStock.ForeColor = Color.White;
            lblListaStock.Location = new Point(22, 20);
            lblListaStock.Name = "lblListaStock";
            lblListaStock.Size = new Size(74, 17);
            lblListaStock.TabIndex = 5;
            lblListaStock.Text = "Lista Stock";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVentas.ForeColor = Color.White;
            lblVentas.Location = new Point(294, 20);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(49, 17);
            lblVentas.TabIndex = 6;
            lblVentas.Text = "Ventas";
            // 
            // FrmLibreria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(575, 574);
            Controls.Add(lblVentas);
            Controls.Add(lblListaStock);
            Controls.Add(btnSalir);
            Controls.Add(btnVerInformacion);
            Controls.Add(btnVender);
            Controls.Add(lstStock);
            Controls.Add(rtbInforme);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLibreria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibreria";
            FormClosing += FrmLibreria_FormClosing;
            Load += FrmLibreria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbInforme;
        private ListBox lstStock;
        private Button btnVender;
        private Button btnVerInformacion;
        private Button btnSalir;
        private Label lblListaStock;
        private Label lblVentas;
    }
}