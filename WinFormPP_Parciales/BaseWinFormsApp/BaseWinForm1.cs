using EntidadesDispositivoRepaso;

namespace BaseWinFormsApp
{
    public partial class BaseWinForm1 : Form
    {
        public BaseWinForm1()
        {
            InitializeComponent();
        }

        private void BaseWinForm1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void btnDispositivo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ver Apps y musica del dispositivo", "Apps y apps de musica", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                FrmDispositivo frmDispositivo = new FrmDispositivo();
                frmDispositivo.MdiParent = this;
                frmDispositivo.Show();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void btnLibreria_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Empezar a vender..?", "Accediendo a libreria", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                FrmLibreria frmLibreria = new FrmLibreria();
                frmLibreria.MdiParent = this;
                frmLibreria.Show();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void btnMrRobot_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vender Robots", "Accediendo a Robotic", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                FrmRobotic frmRobotic = new FrmRobotic();
                frmRobotic.MdiParent = this;
                frmRobotic.Show();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void btnPPPaciente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Empezar Consultas medicas", "Atencion a Paciantes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                FrmPacientePP frmPacientePP = new FrmPacientePP();
                frmPacientePP.MdiParent = this;
                frmPacientePP.Show();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void BaseWinForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("cerrar el Sesion?", "informacion", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnCerraSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

    }
}
