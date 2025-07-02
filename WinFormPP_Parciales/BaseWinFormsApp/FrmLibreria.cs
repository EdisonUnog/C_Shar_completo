using EntidadesLibreriaRepaso;
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
    public partial class FrmLibreria : Form
    {
        private Vendedor vendedor; 
        public FrmLibreria()
        {
            InitializeComponent();
            vendedor = new Vendedor("Edison Uñog");
        }

        private void FrmLibreria_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)"; // No debe poder vender, no tiene stock.
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5); // Debe poder venderse 
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion publicacion = lstStock.SelectedItem as Publicacion;

            if(publicacion is not null)
            {
                if(vendedor + publicacion)
                {
                    MessageBox.Show("Venta exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La venta no pudo realizarse por falta de stock.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnVerInformacion_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.ObtenerInformeDeVentas(vendedor);
        }

        private void FrmLibreria_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Salir de Form Libreria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
