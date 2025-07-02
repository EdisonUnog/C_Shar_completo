using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class Cuartel2 : Form
    {
        private List<Bombero> bomberos;
        private List<PictureBox> fuegos;
        CancellationTokenSource cancellationTokenSource; // cancela el hilo
        public Cuartel2()
        {
            InitializeComponent();

            fuegos = new List<PictureBox>();

            fuegos.Add(fuego1);
            fuegos.Add(fuego2);
            fuegos.Add(fuego3);
            fuegos.Add(fuego4);
            cancellationTokenSource = new CancellationTokenSource();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            bomberos = new List<Bombero>();

            Bombero b1 = new Bombero("M. Palermo");
            b1.MarcarFin += OcultarBombero; // este metodo contiene el if (InvokeRequired)
            bomberos.Add(b1);
            Bombero b2 = new Bombero("G. Schelotto");
            b2.MarcarFin += OcultarBombero;
            bomberos.Add(b2);
            Bombero b3 = new Bombero("C. Tevez");
            b3.MarcarFin += OcultarBombero;
            bomberos.Add(b3);
            Bombero b4 = new Bombero("F. Gago");
            b4.MarcarFin += OcultarBombero;
            bomberos.Add(b4);
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(0);
            }
            catch (Exception)
            {
                MostraMensajeSalidaNoConcretada(0);
            }
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(1);
            }
            catch (Exception)
            {
                MostraMensajeSalidaNoConcretada(1);
            }
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(2);
            }
            catch (Exception)
            {
                MostraMensajeSalidaNoConcretada(2);
            }
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(3);
            }
            catch (Exception)
            {
                MostraMensajeSalidaNoConcretada(3);
            }
        }

        private void VerificarSiBomberoEstaEnSalida(int index)
        {
            foreach (var item in bomberos[index].Salidas)
            {
                if(item.FechaFin == default) // avlor por defecto que toma uina clase por estructura
                {
                    throw new BomberoOcupadoException(); // clase
                }
            }
            // si el bombero aun no finalizo, aun se encuentra en el thead.Sleep();
            // en el metood de AtenderSalida
        }

        private void DespacharServicio(int index)
        {
            fuegos[index].Visible = true;
            VerificarSiBomberoEstaEnSalida(index);
            Bombero bombero = bomberos[index];
            Task hilo = Task.Run(() => bombero.AtenderSalida(index), cancellationTokenSource.Token);
        }

        private void MostraMensajeSalidaNoConcretada(int index)
        {
            MessageBox.Show($"Salida de bombero [ {index} ] no concretada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OcultarBombero(int bomberoIndex)
        {
            if (InvokeRequired)// true si estoy en un hilo distinto al principal
            {
                Action<int> ocultarBombero = OcultarBombero; // lo asocio a mi mismo metodo
                Invoke(ocultarBombero, bomberoIndex); // relanza el evento en el hilo principal
            }
            else //y se oculta el fueguito y el hilo termina y libera espacio
            {
                fuegos[bomberoIndex].Visible = false; // me apaga el fueguito
            }
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            bomberos[0].Guardar(bomberos[0]);
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            bomberos[1].Guardar(bomberos[1]);
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            bomberos[2].Guardar(bomberos[2]);
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            bomberos[3].Guardar(bomberos[3]);
        }

        private void Cuartel2_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
