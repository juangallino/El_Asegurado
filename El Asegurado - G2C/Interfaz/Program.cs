using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace Interfaz
{
    static class Constants
    {
        public const double RECARGO = 0.025;
        public const double DESCUENTO = 0.03;
    }
    static class Program
    {
        public static decimal NRO_SUC = 1234;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GestorPago gp = new GestorPago();
            
            //dto_poliza d = new dto_poliza(true);
            //GestorPoliza gp = new GestorPoliza();
            try
            {
                //gp.generarPoliza(d);
                gp.cargarPolizaParaPagar(13);
            }
            catch(Exception e)
            {
                
                MessageBox.Show("Error: \nMensaje: " + e.Message +" \nTrace:"+e.StackTrace+" \nData: "+e.Data+" \nInnerException: "+e.InnerException);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
