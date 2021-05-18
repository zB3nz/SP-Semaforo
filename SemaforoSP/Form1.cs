using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaforoSP
{
    public partial class Semaforo : Form
    {
        Timer timer;

        bool blnModoPreventivo; //0 = normal, 1 = preventivo
        bool blnTipoSemaforo;

        bool[] blnSemaforo;
        bool[] blnSemaforo1;
        bool[] blnSemaforo2;

        double segundos;


        string log;

        public Semaforo()
        {
            InitializeComponent();

        }

        /**
         * BOTONES
         **/
        private void btnComenzar_Click(object sender, EventArgs e) 
        {
            if (btnComenzar.Text != "Parar")
            {
                reiniciar();
                blnModoPreventivo = false;

                timer.Enabled = true;
                btnComenzar.Text = "Parar";
            }
            else
            {
                timer.Enabled = false;
                btnComenzar.Text = "Comenzar";
            }
        }

        private void btnPreventivo_Click(object sender, EventArgs e)
        {
            reiniciar();

            //arreglos de los colores
            blnSemaforo1[2] = false;
            blnSemaforo2[2] = false;

            blnModoPreventivo = true;

            btnComenzar.Text = "Parar";

            timer.Enabled = true;
        }

        /**
         * CONTROL DE TICKS SEGÚN EL MODO DEL SEMAFORO
         **/
        private void modo_normal(Object myObject, EventArgs myEventArgs)
        {
            if (blnModoPreventivo) return;

            //fases verde
            if (segundos < 17.5) blnSemaforo = new bool[] { true, false, false };
            else if (segundos < 21) blnSemaforo[0] = !blnSemaforo[0];
            //fases amarillas
            else if (segundos < 23.5) blnSemaforo = new bool[] { false, true, false };
            else if (segundos < 24) blnSemaforo[1] = !blnSemaforo[1];
            //fase roja
            else if (segundos < 25.5) blnSemaforo = new bool[] { false, false, true };
            //cuando termina el ciclo
            else
            {
                blnSemaforo = new bool[] { false, false, true };

                blnTipoSemaforo = !blnTipoSemaforo;

                log = "";
            }

            if (!blnTipoSemaforo) blnSemaforo1 = blnSemaforo; else blnSemaforo2 = blnSemaforo;

            actualizar_graficos();
            if (segundos >= 25.5) segundos = 1; else segundos += 0.5;
        }

        private void modo_preventivo(Object myObject, EventArgs myEventArgs)
        {
            if (!blnModoPreventivo) return;

            segundos = 0;

            blnSemaforo[1] = !blnSemaforo[1];
            blnSemaforo1[1] = blnSemaforo[1];
            blnSemaforo2[1] = blnSemaforo[1];

            actualizar_graficos();
        }

        /**
         * METODOS AUXILIARES
         **/

        private void actualizar_graficos()
        {
            int segs = (int) segundos;
            if (segs > 23) segs -= 23;
            else if (segs > 20) segs -= 20;
            else if (segs > 17) segs -= 17;

            lblTimer.Text = ((int)segs).ToString();

            if (blnSemaforo[0]) lblTimer.ForeColor = Color.Green;
            else if (blnSemaforo[1]) lblTimer.ForeColor = Color.Yellow;
            else if (blnSemaforo[2]) lblTimer.ForeColor = Color.Red;
            else lblTimer.ForeColor = Color.Black;

            //Semaforo Vertical 1
            lblST1_1_Verde.Visible = blnSemaforo1[0];
            lblST1_1_Amarillo.Visible = blnSemaforo1[1];
            lblST1_1_Rojo.Visible = blnSemaforo1[2];

            //Semaforo Vertical 2
            lblST1_2_Verde.Visible = blnSemaforo1[0];
            lblST1_2_Amarillo.Visible = blnSemaforo1[1];
            lblST1_2_Rojo.Visible = blnSemaforo1[2];

            //Semaforo Horizontal 1
            lblST2_1_Verde.Visible = blnSemaforo2[0];
            lblST2_1_Amarillo.Visible = blnSemaforo2[1];
            lblST2_1_Rojo.Visible = blnSemaforo2[2];

            //Semaforo Horizontal 2
            lblST2_2_Verde.Visible = blnSemaforo2[0];
            lblST2_2_Amarillo.Visible = blnSemaforo2[1];
            lblST2_2_Rojo.Visible = blnSemaforo2[2];

        }

        private void reiniciar()
        {
            if (timer != null) timer.Dispose();

            blnTipoSemaforo = false;

            blnSemaforo = new bool[] { false, false, false };
            blnSemaforo1 = new bool[] { false, false, true };
            blnSemaforo2 = new bool[] { false, false, true };

            segundos = 1;

            timer = new Timer{Interval = 500};
            timer.Tick += new EventHandler(modo_normal);
            timer.Tick += new EventHandler(modo_preventivo);
        }
    }
}
