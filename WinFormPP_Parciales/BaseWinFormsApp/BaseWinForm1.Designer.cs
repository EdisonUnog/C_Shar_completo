namespace BaseWinFormsApp
{
    partial class BaseWinForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDispositivo = new Button();
            btnLibreria = new Button();
            btnPPPaciente = new Button();
            btnCerraSesion = new Button();
            btnMrRobot = new Button();
            SuspendLayout();
            // 
            // btnDispositivo
            // 
            btnDispositivo.BackColor = Color.FromArgb(192, 255, 255);
            btnDispositivo.FlatStyle = FlatStyle.Flat;
            btnDispositivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDispositivo.Location = new Point(21, 21);
            btnDispositivo.Name = "btnDispositivo";
            btnDispositivo.Size = new Size(163, 71);
            btnDispositivo.TabIndex = 0;
            btnDispositivo.Text = "Dispositivo";
            btnDispositivo.UseVisualStyleBackColor = false;
            btnDispositivo.Click += btnDispositivo_Click;
            // 
            // btnLibreria
            // 
            btnLibreria.BackColor = Color.FromArgb(192, 255, 255);
            btnLibreria.FlatStyle = FlatStyle.Flat;
            btnLibreria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibreria.Location = new Point(21, 98);
            btnLibreria.Name = "btnLibreria";
            btnLibreria.Size = new Size(163, 71);
            btnLibreria.TabIndex = 1;
            btnLibreria.Text = "Tienda Libreria";
            btnLibreria.UseVisualStyleBackColor = false;
            btnLibreria.Click += btnLibreria_Click;
            // 
            // btnPPPaciente
            // 
            btnPPPaciente.BackColor = Color.FromArgb(192, 255, 255);
            btnPPPaciente.FlatStyle = FlatStyle.Flat;
            btnPPPaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPPPaciente.Location = new Point(21, 252);
            btnPPPaciente.Name = "btnPPPaciente";
            btnPPPaciente.Size = new Size(163, 71);
            btnPPPaciente.TabIndex = 3;
            btnPPPaciente.Text = "PP Paciente";
            btnPPPaciente.UseVisualStyleBackColor = false;
            btnPPPaciente.Click += btnPPPaciente_Click;
            // 
            // btnCerraSesion
            // 
            btnCerraSesion.BackColor = Color.FromArgb(255, 128, 128);
            btnCerraSesion.FlatStyle = FlatStyle.Flat;
            btnCerraSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerraSesion.Location = new Point(972, 794);
            btnCerraSesion.Name = "btnCerraSesion";
            btnCerraSesion.Size = new Size(134, 49);
            btnCerraSesion.TabIndex = 4;
            btnCerraSesion.Text = "Cerra Sesion";
            btnCerraSesion.UseVisualStyleBackColor = false;
            btnCerraSesion.Click += btnCerraSesion_Click;
            // 
            // btnMrRobot
            // 
            btnMrRobot.BackColor = Color.FromArgb(192, 255, 255);
            btnMrRobot.FlatStyle = FlatStyle.Flat;
            btnMrRobot.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMrRobot.Location = new Point(21, 175);
            btnMrRobot.Name = "btnMrRobot";
            btnMrRobot.Size = new Size(163, 71);
            btnMrRobot.TabIndex = 5;
            btnMrRobot.Text = "Tienda MR. Robot";
            btnMrRobot.UseVisualStyleBackColor = false;
            btnMrRobot.Click += btnMrRobot_Click;
            // 
            // BaseWinForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.kukaRobotic;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1118, 855);
            Controls.Add(btnMrRobot);
            Controls.Add(btnCerraSesion);
            Controls.Add(btnPPPaciente);
            Controls.Add(btnLibreria);
            Controls.Add(btnDispositivo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseWinForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseWinForm1";
            FormClosing += BaseWinForm1_FormClosing;
            Load += BaseWinForm1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDispositivo;
        private Button btnLibreria;
        private Button btnPPPaciente;
        private Button btnCerraSesion;
        private Button btnMrRobot;
    }
}
