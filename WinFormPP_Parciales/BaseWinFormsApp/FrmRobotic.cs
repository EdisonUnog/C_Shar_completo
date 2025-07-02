using EntidadesRobotPrueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseWinFormsApp
{
    public partial class FrmRobotic : Form
    {
        private TiendaRobot tiendaRobot;
        public FrmRobotic()
        {
            InitializeComponent();
            tiendaRobot = new TiendaRobot("Kuka Robotic");
        }

        private void FrmRobotic_Load(object sender, EventArgs e)
        {
            lstRobots.Items.Add((RobotAlquiler)Modelo.KRtitanPA);
            lstRobots.Items.Add(new RobotAlquiler(Marca.ABB, Modelo.PALETIZADO, 3, 534));
            lstRobots.Items.Add(new RobotAlquiler(Marca.KUKA, Modelo.KR40PA, 2, 3444));

            lstRobots.Items.Add("");
            lstRobots.Items.Add(new RobotVenta(Marca.ABB, Modelo.KRquantecPA, 1, 3444, true));
            lstRobots.Items.Add(new RobotVenta(Marca.KUKA, Modelo.PALETIZADO, 2, 1234, true));
        }

        private void btnNegociar_Click(object sender, EventArgs e)
        {
            Robot robot = lstRobots.SelectedItem as Robot;

            if (robot is not null)
            {
                if (tiendaRobot + robot)
                {
                    MessageBox.Show($"{robot.VentaAlquiler()} exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{robot.VentaAlquiler()} no pudo realizarse por falta de stock.", "Revisar Stock para la venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            rtnVentaAlquiler.Text = TiendaRobot.ObtenerInformacionDeVentas(tiendaRobot);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRobotic_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
