namespace BaseWinFormsApp
{
    partial class FrmPacientePP
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
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtnMedicoPaciente = new RichTextBox();
            btnAtender = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 0;
            label1.Text = "Personal Medico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(242, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            lstMedicos.BackColor = Color.FromArgb(224, 224, 224);
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 29);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(224, 289);
            lstMedicos.TabIndex = 2;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.BackColor = Color.FromArgb(224, 224, 224);
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(242, 29);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(220, 289);
            lstPacientes.TabIndex = 3;
            // 
            // rtnMedicoPaciente
            // 
            rtnMedicoPaciente.BackColor = Color.FromArgb(224, 224, 224);
            rtnMedicoPaciente.Location = new Point(12, 324);
            rtnMedicoPaciente.Name = "rtnMedicoPaciente";
            rtnMedicoPaciente.Size = new Size(450, 190);
            rtnMedicoPaciente.TabIndex = 4;
            rtnMedicoPaciente.Text = "";
            // 
            // btnAtender
            // 
            btnAtender.BackColor = Color.FromArgb(192, 255, 255);
            btnAtender.FlatStyle = FlatStyle.Flat;
            btnAtender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtender.Location = new Point(468, 29);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(136, 71);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = false;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(468, 443);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 71);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmPacientePP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(617, 526);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(rtnMedicoPaciente);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPacientePP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPacientePP";
            FormClosing += FrmPacientePP_FormClosing;
            Load += FrmPacientePP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtnMedicoPaciente;
        private Button btnAtender;
        private Button btnSalir;
    }
}