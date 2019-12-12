using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Negocio;
using System.Threading;

namespace Interfaz
{
    public partial class PagoPolizaForm : Form
    {
        
        dto_PagoPoliza DTO_PagoPoliza = new dto_PagoPoliza();


        public PagoPolizaForm()
        {
            InitializeComponent();
        }

        private void tabPageNuevoCliente_Click(object sender, EventArgs e)
        {

        }

        private void PagoPolizaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBusquedaCliente_Click(object sender, EventArgs e)
        {



            //cargamos dto con datos a buscar





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TituloPanelPoliza_Click(object sender, EventArgs e)
        {

        }

        private void tabNuevaPoliza_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarTabConsultaPoliza_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCuotasPendientesPago_Click(object sender, EventArgs e)
        {

        }

        private void btnBusquedaCliente_Click_1(object sender, EventArgs e)
        {
            ////////////////////////////////
            ///cargamos data table 
            ///
            GestorPago gestorPago = new GestorPago();
            DateTime hoy = DateTime.Today;
            
            try
            {
                // Verifica que haya ingresado una poliza
                if (string.IsNullOrEmpty(textPolizaNroBusquedaPoliza.Text))
                {
                    throw new Exception("Ingrese Nro. de Poliza a Pagar");
                    
                }
                else
                {
                    decimal NroPolizaSuc = 1;
                    decimal NroPoliza = Convert.ToDecimal(textPolizaNroBusquedaPoliza.Text);
                    decimal NroPolizaSec = 01;

                  //  MessageBox.Show(nroPoliza.ToString());
                    

                    DTO_PagoPoliza = gestorPago.cargarPolizaParaPagar(NroPolizaSuc, NroPoliza, NroPolizaSec);

                    if (!string.IsNullOrEmpty(DTO_PagoPoliza.ApellidoCliente))
                    {
                    try
                        {
                            textBoxPolizaNro.Text = NroPoliza.ToString();
                            textBoxClienteDNI.Text = DTO_PagoPoliza.NroCliente.ToString();
                            textBoxClienteNombre.Text = DTO_PagoPoliza.ApellidoCliente.Trim() + " " + DTO_PagoPoliza.NombreCliente.Trim();
                            textBoxNroCliente.Text = DTO_PagoPoliza.NroCliente.ToString();
                            textBoxRevDiaPago1.Text = DTO_PagoPoliza.UltimoPago.ToString();
                            textBoxDatosVehiculo.Text = DTO_PagoPoliza.DatosVehiculo;
                            textBoxEntrega.Text = "0";
                            textBoxVuelto.Text = "0";
                            try
                            {
                                dataGridViewCuotasPendientes.Visible = true;
                                dataGridViewCuotasPendientes.DataSource = DTO_PagoPoliza.CuotasPendientes; 
                                dataGridViewCuotasPendientes.Refresh();
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }


                        }
                        catch (Exception error)
                        {
                            throw new Exception(error.Message);
                        }
                    }
                    else
                        MessageBox.Show("No existe la Poliza ingresada ");

                    MessageBox.Show( DTO_PagoPoliza.DatosVehiculo.ToString());

                    

                    tabControlPagoPoliza.SelectedTab = tabDetallesPoliza;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPolizaNroBusquedaPoliza.Focus();
            }

            
        }

        private void btnVolverTabDetallePoliza_Click(object sender, EventArgs e)
        {
            tabControlPagoPoliza.SelectedTab = tabBusquedaPoliza;
            textPolizaNroBusquedaPoliza.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recibo de Pago Emitido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }
    }
}
