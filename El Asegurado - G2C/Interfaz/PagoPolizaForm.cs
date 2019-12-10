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
        private int nroPoliza;
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
            bool error = false;
            string mensaje = "";

            // Verifica que haya ingresado una poliza
            if (string.IsNullOrEmpty(txtPolizaNro.Text))
            {
                MessageBox.Show("Debe ingresar el Número de Póliza a pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                txtPolizaNro.Focus();
            }

            else
            {
                nroPoliza = Convert.ToInt32(txtPolizaNro.Text);

                MessageBox.Show(nroPoliza.ToString());


                tabControlPagoPoliza.SelectedTab = tabDetallesPoliza;
            }

        }

    }
}
