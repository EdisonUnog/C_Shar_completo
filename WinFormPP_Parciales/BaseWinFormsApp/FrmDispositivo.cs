﻿using EntidadesDispositivoRepaso;
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
    public partial class FrmDispositivo : Form
    {
        public FrmDispositivo()
        {
            InitializeComponent();
        }

        private void FrmDispositivo_Load(object sender, EventArgs e)
        {
            List<Aplicacion> listaApps = new List<Aplicacion>()
            {
              new AppJuegos("Super Mario Bros", SistemaOperativo.ANDROID, 20), // Lo debe agregar
              new AppJuegos("Super Mario Bros", SistemaOperativo.ANDROID, 20), // No lo debe agregar, está repetido
              new AppJuegos("Angry Birds", SistemaOperativo.ANDROID, 100), // Lo debe agregar
              new AppJuegos("League of Legends", SistemaOperativo.IOS, 500), // No lo debe agregar, sistema operativo distinto
              new AppMusical("Spotify", SistemaOperativo.ANDROID, 50, // Lo agrega con las canciones. 
                            new List<string>()
                            {
                                "Bohemian Rhapsody - Queen",
                                "Billie Jean – Michael Jackson",
                                "Another Brick In The Wall – Pink Floyd",
                                "Romeo And Juliet – Dire Straits",
                                "Where The Streets Have No Name -U2",
                                "Let It Be – The Beatles",
                                "Could You Be Loved – Bob Marley",
                                "Every Breath You Take – The Police",
                                "November Rain – Guns n Roses",
                                "Crazy Train – Ozzy Osbourne",
                                "Volver – Carlos Gardel",
                                "En La Ciudad De La Furia – Soda Stereo",
                                "Gualicho – Patricio Rey",
                                "Paint It Black – Rolling Stones"
                            }),
              new AppMusical("Spotify", SistemaOperativo.ANDROID, 50), // No lo debe agregar, repetido.
              new AppMusical("YouTube Music", SistemaOperativo.ANDROID, 30) // Lo debe agregar.
            };

            foreach (Aplicacion app in listaApps)
            {
                // Intenta instalar apps.
                if (!Dispositivos.InstalarApp(app))
                {
                    // Agrega apps no instaladas al RichTextBox de no-instaladas.
                    rtbAppNoInstaladas.Text += string.Concat(app.ToString(), "\n");
                }

                // Obtiene la información del dispositivo y sus apps instaladas.
                // Lo asigna al RichTextBox de apps instaladas.
                this.rtbAppInstaladas.Text = Dispositivos.ObtenerInformacionDispositivo();
            }
        }

        private void FrmDispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Cerrar dispositivo?", "informacion", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
