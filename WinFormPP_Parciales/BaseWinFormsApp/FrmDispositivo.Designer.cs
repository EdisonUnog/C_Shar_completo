namespace BaseWinFormsApp
{
    partial class FrmDispositivo
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
            rtbAppInstaladas = new RichTextBox();
            rtbAppNoInstaladas = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // rtbAppInstaladas
            // 
            rtbAppInstaladas.BackColor = Color.FromArgb(224, 224, 224);
            rtbAppInstaladas.Location = new Point(23, 29);
            rtbAppInstaladas.Name = "rtbAppInstaladas";
            rtbAppInstaladas.Size = new Size(299, 579);
            rtbAppInstaladas.TabIndex = 0;
            rtbAppInstaladas.Text = "";
            // 
            // rtbAppNoInstaladas
            // 
            rtbAppNoInstaladas.BackColor = Color.FromArgb(224, 224, 224);
            rtbAppNoInstaladas.Location = new Point(341, 29);
            rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            rtbAppNoInstaladas.Size = new Size(290, 579);
            rtbAppNoInstaladas.TabIndex = 1;
            rtbAppNoInstaladas.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 2;
            label1.Text = "Instaladas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(341, 9);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 3;
            label2.Text = "No Instaladas";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 128, 128);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.Location = new Point(219, 614);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(226, 46);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmDispositivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(654, 672);
            Controls.Add(btnCerrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbAppNoInstaladas);
            Controls.Add(rtbAppInstaladas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDispositivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDispositivo";
            FormClosing += FrmDispositivo_FormClosing;
            Load += FrmDispositivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbAppInstaladas;
        private RichTextBox rtbAppNoInstaladas;
        private Label label1;
        private Label label2;
        private Button btnCerrar;
    }
}