using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemCFA
{
    public partial class ledControl : Form
    {
        public ledControl()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ledControl_Load(object sender, EventArgs e)
        {
            try {
                turnOff.Enabled = false; //Esto basicamente desactiva este boton OFF al iniciar el programa
                                         //Establecer que puerto COM usaremos
                serialPort1.PortName = "COM3";
                //Habilitar el puerto COM
                serialPort1.Open();

            } 
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

        private void turnOn_Click(object sender, EventArgs e)
        {
            //Enviar codigo al arduino

            /*Alternativa para mandar informacion*/
            //serial.println("$On");

            try
            {
                //Enviar la cadena On al puerto serie del arduino


                //Esta secccion cambia el fondo de la etiqueta statusLed
                serialPort1.WriteLine("$On");
                statusLed.BackColor = Color.Lime;   //Usando Color.Lime, establece un verde
                statusLed.Text = "ON";
                turnOff.Enabled = true;
                
            }

            catch (Exception error)
            {
                //Si crashea manda una alerta al usuario
                MessageBox.Show(error.Message);
            }
        }

        private void turnOff_Click(object sender, EventArgs e)
        {
            try
            {
                //Enviar la cadena On al puerto serie del arduino


                //Esta secccion cambia el fondo de la etiqueta statusLed
                serialPort1.WriteLine("$Off");
                statusLed.BackColor = Color.Red;   //Usando Color.Lime, establece un verde
                statusLed.Text = "OFF";

                turnOff.Enabled = false;
                turnOff.Enabled = true;
                

            }

            catch (Exception error)
            {
                //Si crashea manda una alerta al usuario
                MessageBox.Show(error.Message);
            }
        }

        /*Esta funcion actua bajo el evento de que yo cierre el programa
         desactivando el puerto serial que halla habilitado previamente*/
        private void ledControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
                try 
                { 
                 serialPort1.Close(); 
                } 
                catch(Exception error) 
                {
                    MessageBox.Show(error.Message);
                }

        }
    }
}
