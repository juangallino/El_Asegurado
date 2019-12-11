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
            dto_PagoPoliza d = new dto_PagoPoliza();
            //dto_poliza d = new dto_poliza(true);
            //GestorPoliza gp = new GestorPoliza();
            try
            {
                //gp.generarPoliza(d);
                d = gp.cargarPolizaParaPagar(3);
                Console.WriteLine("DTO Pago Poliza\nCliente: " + d.NroCliente + " - " + d.ApellidoCliente.Trim() + " " + d.NombreCliente.Trim()
                                + "\nPoliza n°: " + d.NroPoliza + "\nVehículo: " + d.DatosVehiculo.Trim() + " - " + d.Patente
                                + "\n Cuotas Pendientes: "
                                + "\nCuota #" + d.CuotasPendientes.ElementAt(0).NroCuota + "-Venc.: " + d.CuotasPendientes.ElementAt(0).FechaVencimiento + "-Importe: " + d.CuotasPendientes.ElementAt(0).ImporteCuota + "-Dto: " + d.CuotasPendientes.ElementAt(0).ImporteDescuento + "-Recargo: " + d.CuotasPendientes.ElementAt(0).ImporteRecargo
                                + "\nCuota #" + d.CuotasPendientes.ElementAt(1).NroCuota + "-Venc.: " + d.CuotasPendientes.ElementAt(1).FechaVencimiento + "-Importe: " + d.CuotasPendientes.ElementAt(1).ImporteCuota + "-Dto: " + d.CuotasPendientes.ElementAt(1).ImporteDescuento + "-Recargo: " + d.CuotasPendientes.ElementAt(1).ImporteRecargo
                                + "\nCuota #" + d.CuotasPendientes.ElementAt(2).NroCuota + "-Venc.: " + d.CuotasPendientes.ElementAt(2).FechaVencimiento + "-Importe: " + d.CuotasPendientes.ElementAt(2).ImporteCuota + "-Dto: " + d.CuotasPendientes.ElementAt(2).ImporteDescuento + "-Recargo: " + d.CuotasPendientes.ElementAt(2).ImporteRecargo
                                + "\nCuota #" + d.CuotasPendientes.ElementAt(3).NroCuota + "-Venc.: " + d.CuotasPendientes.ElementAt(3).FechaVencimiento + "-Importe: " + d.CuotasPendientes.ElementAt(3).ImporteCuota + "-Dto: " + d.CuotasPendientes.ElementAt(3).ImporteDescuento + "-Recargo: " + d.CuotasPendientes.ElementAt(3).ImporteRecargo
                                + "\nCuota #" + d.CuotasPendientes.ElementAt(4).NroCuota + "-Venc.: " + d.CuotasPendientes.ElementAt(4).FechaVencimiento + "-Importe: " + d.CuotasPendientes.ElementAt(4).ImporteCuota + "-Dto: " + d.CuotasPendientes.ElementAt(4).ImporteDescuento + "-Recargo: " + d.CuotasPendientes.ElementAt(4).ImporteRecargo);
                                //+ "\nCuota #" + d.CuotasPendientes.ElementAt(5).NroCuota + "-Venc.: " + d.CuotasPendientes.ElementAt(5).FechaVencimiento + "-Importe: " + d.CuotasPendientes.ElementAt(5).ImporteCuota + "-Dto: " + d.CuotasPendientes.ElementAt(5).ImporteDescuento + "-Recargo: " + d.CuotasPendientes.ElementAt(5).ImporteRecargo);
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
