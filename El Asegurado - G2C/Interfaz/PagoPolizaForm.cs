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
        private double importeAPagar = 0;
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
            this.Close();
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
                    decimal NroPolizaSuc = Convert.ToDecimal(textBoxNroPolizaSuc.Text);
                    decimal NroPoliza = Convert.ToDecimal(textPolizaNroBusquedaPoliza.Text);
                    decimal NroPolizaSec = Convert.ToDecimal(textBoxNroPolizaSec.Text);




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
                            textBoxFechaInicio.Text = DTO_PagoPoliza.FechaInicio.ToString();
                            textBoxFechaFin.Text = DTO_PagoPoliza.FechaFin.ToString();

                            textBoxEntrega.Text = "0";
                            textBoxVuelto.Text = "0";
                            try
                            {
                                /*  DataGridViewTextBoxColumn colImporteCuota = new DataGridViewTextBoxColumn();
                                  colImporteCuota.HeaderText = "Importe a Pagar";
                                  colImporteCuota.Name = "ImporteTotalCuota";
                                  colImporteCuota.Visible = true;
                                  */
                                dataGridViewCuotasPendientes.Visible = true;
                                dataGridViewCuotasPendientes.DataSource = DTO_PagoPoliza.CuotasPendientes;
                                //   dataGridViewCuotasPendientes.Columns.Add(colImporteCuota);


                                dataGridViewCuotasPendientes.Columns["IdCuota"].Visible = false;
                                dataGridViewCuotasPendientes.Columns["FechaPago"].Visible = false;
                                dataGridViewCuotasPendientes.Columns["ImporteRecargo"].Visible = false;
                                dataGridViewCuotasPendientes.Columns["ImporteDescuento"].Visible = false;



                                importeAPagar = 0;
                                foreach (DataGridViewRow fila in dataGridViewCuotasPendientes.Rows)
                                {
                                    DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridViewCuotasPendientes.Rows[fila.Index].Cells[0];
                                    check.Value = check.FalseValue;


                                }

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
            List<dto_Cuota> dtoCuota = new List<dto_Cuota>();
            GestorPago gestorPago = new GestorPago();
            try
            {

                foreach (DataGridViewRow fila in dataGridViewCuotasPendientes.Rows)
                {
                    DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridViewCuotasPendientes.Rows[fila.Index].Cells[0];

                    if (check.Value == check.TrueValue)
                    {
                        dto_Cuota dtoCuotaAux = new dto_Cuota();
                        dtoCuotaAux = DTO_PagoPoliza.CuotasPendientes.ElementAt(fila.Index);
                        dtoCuota.Add(dtoCuotaAux);
                    }


                }

                gestorPago.RegistrarPago(dtoCuota, DTO_PagoPoliza.idPoliza);
                MessageBox.Show("Recibo de Pago Emitido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabBusquedaPoliza_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            tabControlPagoPoliza.SelectedTab = tabBusquedaPoliza;
            textBoxNroPolizaSuc.Focus();
        }

        private void dataGridViewCuotasPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridViewCuotasPendientes.Rows[e.RowIndex].Cells[0];
            DataGridViewTextBoxCell importeAPagarTextBox = (DataGridViewTextBoxCell)dataGridViewCuotasPendientes.Rows[e.RowIndex].Cells["ImporteTotalCuota"];

            if (check.Value == check.TrueValue)
            {
                check.Value = check.FalseValue;


                importeAPagar = importeAPagar - Convert.ToDouble(importeAPagarTextBox.Value);

            }
            else
            {
                check.Value = check.TrueValue;
                importeAPagar = importeAPagar + Convert.ToDouble(dataGridViewCuotasPendientes.Rows[e.RowIndex].Cells["ImporteTotalCuota"].Value);

            }

            textBoxAPagar.Text = Convert.ToString(importeAPagar);
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewCuotasPendientes.IsCurrentCellDirty)
            {
                dataGridViewCuotasPendientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxEntrega_TextChanged(object sender, EventArgs e)
        {
            double vuelto = 0;
            double entrega = 0;

            entrega = Convert.ToDouble(textBoxEntrega.Text);
            vuelto = entrega - Convert.ToDouble(textBoxAPagar.Text);
            btnEmitirReciboPago.Focus();


        }
    }
}

