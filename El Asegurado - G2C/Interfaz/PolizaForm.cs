﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using Negocio;
using System.Threading;

namespace Interfaz
{
    public partial class PolizaForm : Form
    {

        DeclaracionHijosForm declaracionHijosView = new DeclaracionHijosForm();
        MedidasSeguridadForm medidaSeguridadView = new MedidasSeguridadForm();
        dto_poliza DTOPOLIZAAUX = new dto_poliza();
        public PolizaForm()
        {
            InitializeComponent();
            //panelcliente.Visible = false;
            panelPoliza.Visible = true;
            textBoxSumaAsegurada.Visible = false;
        }
        private void tab1Button1_Click(object sender, System.EventArgs e)
        {
            // Inserts the code that should run when the button is clicked.
        }
        public void LimitarKeypres(KeyPressEventArgs e, bool numero, bool letra, bool control, bool separador)

        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = numero;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = letra;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = control;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = separador;
            }
            else
            {
                e.Handled = true;
            }


        }
        //Titulo PANEL POLIZA
        private void TabDetallesPoliza_Enter(object sender, EventArgs e)
        {
            TituloPanelPoliza.Text = "Detalle Póliza";
        }

        private void TabNuevaPoliza_Enter(object sender, EventArgs e)
        {
            TituloPanelPoliza.Text = "Nueva Póliza";
        }


        /// <Obtener //datos>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////
        public void ObtenerDatos()
        {
            //Creo un gestor poliza para poder calcular el premio y los descuentos
            GestorPoliza gestorPoliza = new GestorPoliza();
            GestorExtra gestorExtra = new GestorExtra();
            try
            {
                //Creo un gestor poliza para poder calcular el premio y los descuentos

                dto_poliza dtoPoliza = new dto_poliza(true); // Creamos el dto de poliza y lo cargamos con los datos obtenido de la interfaz
                dtoPoliza.IdDomicilioRiesgo = Convert.ToInt32(comboBoxLocalidad.SelectedValue);
                dtoPoliza.Suma_Asegurada = Convert.ToInt32(textBoxSumaAsegurada.Text);
                dtoPoliza.IdVehiculo = Convert.ToInt32(comboBoxModelo.SelectedValue);
                dtoPoliza.Marca = comboBoxMarca.Text;
                dtoPoliza.Modelo = comboBoxModelo.Text;
                dtoPoliza.AñoVehiculo = Convert.ToInt32(comboBoxAño.Text);
                dtoPoliza.NroMotor = textBoxMotorNro.Text;
                dtoPoliza.NroChasis = textboxChasis.Text;
                dtoPoliza.KmPorAño = Convert.ToInt32(textBoxKmAño.Text);
                dtoPoliza.Nro_Siniestros = Convert.ToInt32(comboBoxNroSiniestros.SelectedValue);
                dtoPoliza.Tipo_Cobertura = Convert.ToInt32(comboBoxTipoCobertura.SelectedValue);
                dtoPoliza.NombreCobertura = comboBoxTipoCobertura.Text;
                dtoPoliza.FechaInicioVigencia = (timepickerFechaInicio.Value);
                dtoPoliza.Patente = nroPatenteMaskedTextBox.Text;
                dtoPoliza.IdCliente = Convert.ToInt32(textBoxClienteNro.Text);

                //CREAMOS LAS LISTA DE CUOTAS
                dtoPoliza.Vto_Pago = gestorExtra.CargarListaCuotas(dtoPoliza.FechaInicioVigencia.AddDays(-1));

                //OBTENGO FORMA DE PAGO
                if (btnCheckMensual.Checked) dtoPoliza.FormaPago = 6;
                if (btnCheckSemestral.Checked) dtoPoliza.FormaPago = 1;

                //OBTENGO DATOS DE LOS OTROS FORMULARIOS
                dtoPoliza = declaracionHijosView.ObtenerDatos(dtoPoliza);
                dtoPoliza = medidaSeguridadView.ObtenerDatos(dtoPoliza);

                /////////////////////////////////   PRUEBA/////////////////////////
                ///


                /* MessageBox.Show(dtoPoliza.IdVehiculo + "-- " + dtoPoliza.Suma_Asegurada + "-- " + dtoPoliza.AñoVehiculo + "-- " +
                       dtoPoliza.NroChasis + "-- " + dtoPoliza.NroMotor + "-- " + dtoPoliza.Tipo_Cobertura + "-- " +
                       dtoPoliza.FechaInicioVigencia.ToShortDateString() + "-- " + dtoPoliza.FormaPago + "-- " + dtoPoliza.KmPorAño + "-- " + dtoPoliza.Nro_Siniestros + "-- " + dtoPoliza.Patente);
                 MessageBox.Show(" nombre de la cobertura " + dtoPoliza.NombreCobertura);
                 foreach (var hijo in dtoPoliza.Hijo)
                 {MessageBox.Show("id hijo: " + hijo.Id + hijo.Fecha_nac);                 }
                 foreach (var med in dtoPoliza.Medidas_Seguridad){
                     MessageBox.Show("medidas nro : ..." + med);}*/
                /////////////////////////////////   PRUEBA/////////////////////////


                //SUPER DUPER HARDCODEADO
                //Falta metodo para calcular prima y descuentos
                dtoPoliza.ImporteDescuento = gestorPoliza.CalcularDescuento();
                dtoPoliza.Premio = gestorPoliza.CalcularPremio();
                dtoPoliza.Monto_Abonar = 45000 + dtoPoliza.ImporteDescuento + dtoPoliza.Premio;
                CargarRevisionPoliza(dtoPoliza);
                //Le asigno a la variable global DTOPOLIZACTE, el dto que voy a imprimir
                DTOPOLIZAAUX = dtoPoliza;
            }

            catch (Exception error)
            {
                MessageBox.Show("ERROR " + error.Message);
            }
        }


        public void CargarRevisionPoliza(dto_poliza dtoPoliza)
        {
            textBoxTitularSeguro.Text = "nombre del cliente";
            textBoxRevMarca.Text = dtoPoliza.Marca;
            textBoxRevModelo.Text = dtoPoliza.Modelo;
            textBoxRevChasis.Text = dtoPoliza.NroChasis;
            textBoxRevMotorNro.Text = dtoPoliza.NroMotor;
            textBoxRevPatante.Text = dtoPoliza.Patente;

            textBoxRevVigenciaFin.Text = dtoPoliza.FechaInicioVigencia.AddMonths(6).ToShortDateString();
            textBoxRevVigenciaInicio.Text = dtoPoliza.FechaInicioVigencia.ToShortDateString();

            textBoxRevSumaAsegurada.Text = dtoPoliza.Suma_Asegurada.ToString();
            textBoxRevPremio.Text = dtoPoliza.Premio.ToString();
            textBoxRevImpDescuentos.Text = dtoPoliza.ImporteDescuento.ToString();

            if (dtoPoliza.FormaPago == 6)
            {

                textBoxRevMontoPago1.Text = (dtoPoliza.Monto_Abonar / 6).ToString();
                textBoxRevMontoPago2.Text = (dtoPoliza.Monto_Abonar / 6).ToString();
                textBoxRevMontoPago3.Text = (dtoPoliza.Monto_Abonar / 6).ToString();
                textBoxRevMontoPago4.Text = (dtoPoliza.Monto_Abonar / 6).ToString();
                textBoxRevMontoPago5.Text = (dtoPoliza.Monto_Abonar / 6).ToString();
                textBoxRevMontoPago6.Text = (dtoPoliza.Monto_Abonar / 6).ToString();
                //// muestro campo pago


                textBoxRevMontoPago1.Show();
                textBoxRevMontoPago2.Show();
                textBoxRevMontoPago3.Show();
                textBoxRevMontoPago4.Show();
                textBoxRevMontoPago5.Show();
                textBoxRevMontoPago6.Show();

                //////////////////////////////////////////////////////////////////////////
                textBoxRevDiaPago1.Text = dtoPoliza.Vto_Pago[0].ToShortDateString();
                textBoxRevDiaPago2.Text = dtoPoliza.Vto_Pago[1].ToShortDateString();
                textBoxRevDiaPago3.Text = dtoPoliza.Vto_Pago[2].ToShortDateString();
                textBoxRevDiaPago4.Text = dtoPoliza.Vto_Pago[3].ToShortDateString();
                textBoxRevDiaPago5.Text = dtoPoliza.Vto_Pago[4].ToShortDateString();
                textBoxRevDiaPago6.Text = dtoPoliza.Vto_Pago[5].ToShortDateString();

                textBoxRevDiaPago1.Show();
                textBoxRevDiaPago2.Show();
                textBoxRevDiaPago3.Show();
                textBoxRevDiaPago4.Show();
                textBoxRevDiaPago5.Show();
                textBoxRevDiaPago6.Show();

                // textBoxRevDiaPago1.Text = dtoPoliza.FechaInicioVigencia.ToString();
                // textBoxRevDiaPago2.Text = dtoPoliza.FechaInicioVigencia.AddMonths(1).ToShortDateString();
                // textBoxRevDiaPago3.Text = dtoPoliza.FechaInicioVigencia.AddMonths(2).ToShortDateString();
                // textBoxRevDiaPago4.Text = dtoPoliza.FechaInicioVigencia.AddMonths(3).ToShortDateString();
                // textBoxRevDiaPago5.Text = dtoPoliza.FechaInicioVigencia.AddMonths(4).ToShortDateString();
                // textBoxRevDiaPago6.Text = dtoPoliza.FechaInicioVigencia.AddMonths(5).ToShortDateString();
            }
            else
            {

                textBoxRevMontoPago1.Text = (dtoPoliza.Monto_Abonar).ToString();
                textBoxRevMontoPago2.Hide();
                textBoxRevMontoPago3.Hide();
                textBoxRevMontoPago4.Hide();
                textBoxRevMontoPago5.Hide();
                textBoxRevMontoPago6.Hide();
                //  textBoxRevDiaPago1.Text = dtoPoliza.Vto_Pago[1].ToString();
                //textBoxRevDiaPago2.Text = "";
                //textBoxRevDiaPago3.Text = "";
                //textBoxRevDiaPago4.Text = "";
                //textBoxRevDiaPago5.Text = "";
                //textBoxRevDiaPago6.Text = "";
                textBoxRevDiaPago1.Text = dtoPoliza.FechaInicioVigencia.AddDays(-1).ToShortDateString();
                textBoxRevDiaPago2.Hide();
                textBoxRevDiaPago3.Hide();
                textBoxRevDiaPago4.Hide();
                textBoxRevDiaPago5.Hide();
                textBoxRevDiaPago6.Hide();
            }
            textBoxRevTipoCobertura.Text = dtoPoliza.NombreCobertura.Trim();



        }


        private void limpiarCampos()
        {  //tabRevision
            textBoxRevDiaPago1.Text = "";
            textBoxRevDiaPago2.Text = "";
            textBoxRevDiaPago3.Text = "";
            textBoxRevDiaPago4.Text = "";
            textBoxRevDiaPago5.Text = "";
            textBoxRevDiaPago6.Text = "";
            textBoxRevMontoPago1.Text = "";
            textBoxRevMontoPago2.Text = "";
            textBoxRevMontoPago3.Text = "";
            textBoxRevMontoPago4.Text = "";
            textBoxRevMontoPago5.Text = "";
            textBoxRevMontoPago6.Text = "";
            textBoxRevTipoCobertura.Text = "";
            textBoxTitularSeguro.Text = "";
            textBoxRevMarca.Text = "";
            textBoxRevModelo.Text = "";
            textBoxRevChasis.Text = "";
            textBoxRevMotorNro.Text = "";
            textBoxRevPatante.Text = "";
            textBoxRevVigenciaFin.Text = ""; ;
            textBoxRevVigenciaInicio.Text = "";
            //tab 2

            btnCheckMensual.Checked = false;
            btnCheckSemestral.Checked = false;
            comboBoxTipoCobertura.SelectedItem = null;

            //tab1
            textBoxRevSumaAsegurada.Text = "";
            textBoxRevPremio.Text = "";
            textBoxRevImpDescuentos.Text = "";
            comboBoxLocalidad.SelectedItem = null;
            textBoxSumaAsegurada.Text = "";
            comboBoxModelo.SelectedItem = null;
            comboBoxMarca.SelectedItem = null;
            comboBoxProvincia.SelectedItem = null;
            textBoxKmAño.Text = "";
            textboxChasis.Text = "";
            comboBoxAño.SelectedItem = null;
            comboBoxNroSiniestros.SelectedItem = null;
            textBoxMotorNro.Text = "";
            textBoxSumaAsegurada.Text = "";
            comboBoxPatente.SelectedItem = null;
            nroPatenteMaskedTextBox.Text = "";
            textBoxClienteNro.Text = "";

            //cliente
            textBoxClienteDNI.Text = "";
            textBoxClienteDomicilio.Text = "";
            textBoxClienteNombre.Text = "";
            textBoxClienteDNI.Text = "";

        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControlPoliza2.SelectedTab.Text)
                {
                    case "Datos Póliza":
                        var control = ValidarPestañaNuevo();
                        //Si no valida, no pasa a la siguiente pestaña, y muestra error
                        if (control == null)
                            tabControlPoliza2.SelectedIndex = (tabControlPoliza2.SelectedIndex + 1);
                        else
                        {
                            MessageBox.Show("Por favor, completa los datos para continuar", "Atención: Datos con Error o Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            control.Focus();
                            //Si es combo box lo despliega, sino llama al metodo Blink
                            if (control.GetType().Name == "ComboBox")
                            {
                                ComboBox ctrl = control as ComboBox;
                                ctrl.DroppedDown = true;
                            }
                            else
                            {
                                Blink(control);
                            }

                        }

                        break;
                    case "Revisión":
                        ObtenerDatos();
                        break;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }
        //Método que genera un cambio de color en el control que generó un error
        private async void Blink(Control control)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            cts.CancelAfter(1000);
            Color colorOrig = control.BackColor;
            while (!cts.IsCancellationRequested)
            {
                await Task.Delay(250);
                control.BackColor = control.BackColor == Color.Red ? Color.PaleVioletRed : Color.Red;

            }
            control.BackColor = colorOrig;
        }


        //Valida que los controles estén completos y correctos
        private System.Windows.Forms.Control ValidarPestañaNuevo()
        {
            //Recorremos los controles cuyo contenido puede contener algún error
            //Cliente
            if (textBoxClienteNro.Text == "")
            {
                return textBoxClienteNro;
            }
            //Domicilio de Riesgo ////// Si no se seleccionó Localidad es porque no se abrió el combobox de provincia
            if (Convert.ToString(comboBoxLocalidad.SelectedValue) == "")
            {
                return comboBoxProvincia;
            }
            //Modelo ////// Si no se seleccionó Modelo es porque no se abrió el combobox de Marca
            if (Convert.ToString(comboBoxModelo.SelectedValue) == "")
            {
                return comboBoxMarca;
            }
            //Año vehículo
            if (comboBoxAño.Text == "")
            {
                return comboBoxAño;
            }
            //Número de motor
            if (textBoxMotorNro.Text == "")
            {
                return textBoxMotorNro;
            }
            //Número de chasis
            if (textboxChasis.Text == "")
            {
                return textboxChasis;
            }
            //Tipo patente

            if (Convert.ToString(comboBoxPatente.Text) == "")
            {
                return comboBoxPatente;
            }
            //Patente //// Si la patente no está completa ocurre un error
            if (nroPatenteMaskedTextBox.Text.Trim().Length < nroPatenteMaskedTextBox.Mask.Length)
            {
                return nroPatenteMaskedTextBox;
            }
            //Kilómetros por año
            if (textBoxKmAño.Text == "")
            {
                return textBoxKmAño;
            }
            //Si todos los campos obligatorios están completos, retorna null
            return null;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            tabControlPoliza1.Visible = true;
            tabControlPoliza1.SelectedTab = tabNuevaPoliza;


        }

        private void Btnconsultar_Click(object sender, EventArgs e)
        {
            tabControlPoliza1.Visible = true;
            tabControlPoliza1.SelectedTab = tabBusquedaPoliza;
        }
        private void PolizaForm_Load(object sender, EventArgs e)

        {

            
        }

        private void BtnDeclaracionHijos_Click(object sender, EventArgs e)
        {

           
        }

        private void BtnMedidasdeSeguridad_Click(object sender, EventArgs e)
        {
            medidaSeguridadView.Show();
            medidaSeguridadView.BringToFront();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarKeypres(e, false, true, false, true);
        }



        private void TextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarKeypres(e, false, false, false, true);
        }

        private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarKeypres(e, false, true, false, true);
        }






        private void ComboBoxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
   
        }



        private void ComboBoxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxModelo.DataSource = null;
            GestorExtra gestorExtra = new GestorExtra();
            comboBoxModelo.DataSource = gestorExtra.BuscarModelo(Convert.ToInt32(comboBoxMarca.SelectedValue));
            comboBoxModelo.DisplayMember = "nombre";
            comboBoxModelo.ValueMember = "id";
        }






        private void comboBoxAño_SelectedIndexChanged(object sender, EventArgs e)
        {

            GestorExtra gestorExtra = new GestorExtra();
            textBoxSumaAsegurada.Visible = true;
            textBoxSumaAsegurada.Text = Convert.ToString(gestorExtra.GetSumaAsegurada(comboBoxModelo.SelectedIndex, comboBoxAño.SelectedIndex));
        }

        private void textBoxRevTipoCobertura_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEmitirPoliza_Click(object sender, EventArgs e)
        {
            GestorPoliza gestorPoliza = new GestorPoliza();
            DialogResult Estaseguro = MessageBox.Show("Seguro que desea dar de alta una Poliza nueva? Esta accion no se puede deshacer!", "Generar Poliza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (Estaseguro)
            {
                case DialogResult.Yes:   // Yes button pressed
                                         // try
                                         // {
                    gestorPoliza.generarPoliza(DTOPOLIZAAUX);
                    DTOPOLIZAAUX = null;
                    declaracionHijosView.Limpiate();
                    medidaSeguridadView.limpiate();
                    limpiarCampos();

                    // }
                    // catch(Exception e) { MessageBox.Show("Error: \nMensaje: " + e.Message +" \nTrace:"+e.StackTrace+" \nData: "+e.Data+" \nInnerException: "+e.InnerException); }

                    break;
                case DialogResult.No:    // No button pressed
                    MessageBox.Show("cancelamos la creacion de la poliza");
                    break;



                    // gestorPoliza.generarPoliza(DTOPOLIZACTE);
                    // DTOPOLIZACTE = null;

            }


            /////////////////////////// funcion limitar boton siguiente a que esten todos los campos completos
            MessageBox.Show("Póliza emitida con Exito", "Nueva Poliza", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
       /* public bool ValidarPatente()
        {
            Regex patenteVieja = new Regex("^[A - Za - z]{3}[0-9]{3}$");
            Regex patenteNueva = new Regex("^[A-Za-z]{2}[0-9]{3}[A-Z]{2}$");



            if (comboBoxPatente.SelectedIndex == 0)
            {

                if (patenteVieja.IsMatch(textBoxPatente.Text))
                {
                    MessageBox.Show("valor " + comboBoxPatente.SelectedIndex + " -----   " + comboBoxPatente.Text + " ENTRO FALSO  ");
                    return false;


                }
                MessageBox.Show("valor " + comboBoxPatente.SelectedIndex + " -----   " + comboBoxPatente.Text + " ENTRO VERDADERO  ");
            }
            if (comboBoxPatente.SelectedIndex == 1)
            {
                if (patenteNueva.IsMatch(textBoxPatente.Text))
                {
                    MessageBox.Show("valor " + comboBoxPatente.SelectedIndex + " -----   " + comboBoxPatente.Text + " ENTRO FALSO  ");
                    return false;
                }
                MessageBox.Show("valor " + comboBoxPatente.SelectedIndex + " -----   " + comboBoxPatente.Text + " ENTRO VERDADERO  ");

            }

            return true;
        }*/
        private void TextBoxPatente_Enter(object sender, EventArgs e)
        {
            /* while (!ValidarPatente())
             {
                 textBoxPatente.ForeColor = Color.Red;
                 textBoxPatente.BackColor = Color.Beige;
             }

             textBoxPatente.ForeColor = Color.Green;*/
        }

        private void ComboBoxPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatente.SelectedIndex == 0)
            {
                nroPatenteMaskedTextBox.Mask = "LLL000";
            }
            else
            {
                nroPatenteMaskedTextBox.Mask = "LL000LL";
            }
        }

        

        private void CargarPolizaDetalles(dto_poliza dtoPoliza, dto_cliente dtoCliente)
        {
            GestorPoliza gestorPoliza = new GestorPoliza();
            tbAñoDetalle.Text = Convert.ToInt32(dtoPoliza.AñoVehiculo).ToString();
            textBox2tbEstadoDetalle.Text = dtoPoliza.Estado;
            tbClienteDetalle.Text = (dtoCliente.Nombre.Trim() + ", " + dtoCliente.Apellido.Trim());
            tbDomicilioRiesgoDetalle.Text = (dtoCliente.Calle.ToString().Trim() + "  " + dtoCliente.NumeroDomicilio.ToString().Trim() + ",  " + dtoCliente.Localidad.ToString().Trim() + ", " + dtoCliente.Provincia.ToString().Trim() + ", " + dtoCliente.Pais.ToUpper().ToString().Trim());
            tbFechaFinDetalle.Text = dtoPoliza.FechaInicioVigencia.AddMonths(6).ToShortDateString();
            tbFechaInicioDetalle.Text = dtoPoliza.FechaInicioVigencia.ToShortDateString();
            tbKMAñoDetalle.Text = dtoPoliza.KmPorAño.ToString();
            tbMarcaDetalle.Text = dtoPoliza.Marca;
            tbModeloDetalle.Text = dtoPoliza.Modelo;
            tbPatenteDetalle.Text = dtoPoliza.Patente;
            tbPolizaNumDetalle.Text = dtoPoliza.NroPolizaSuc.ToString().Trim() + dtoPoliza.NroPolizaSec.ToString();
            tbSumaAseguradaDetalle.Text = dtoPoliza.Suma_Asegurada.ToString();
            tbMotorNroDetalle.Text = dtoPoliza.NroMotor.ToString();
            tbChasisNroDetalle.Text = dtoPoliza.NroChasis.ToString();
            //Cargar HIJOS 
            dgHijosDetallePoliza.Rows.Clear();
            foreach (var hijo in dtoPoliza.Hijo)
            {
                int n = dgHijosDetallePoliza.Rows.Add();
                dgHijosDetallePoliza.Rows[n].Cells[0].Value = hijo.Fecha_nac.ToShortDateString();
                dgHijosDetallePoliza.Rows[n].Cells[1].Value = hijo.Sexo;
                dgHijosDetallePoliza.Rows[n].Cells[2].Value = hijo.EstadoCivil;
            }
            //Cargar Medidas  
            listviewMedidasDetallePoliza.Items.Clear();
            foreach (var medida in dtoPoliza.Medidas_Seguridad)
            {
                ListViewItem item = new ListViewItem();
                item = listviewMedidasDetallePoliza.Items.Add(gestorPoliza.BuscarNombreMedida(medida)); ; //gestorPoliza.BuscarNombreMedida(medida)
            }

        }



        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.tabControlPoliza1.SelectedIndex = 0;
        }

        private void btnBusquedaCliente_Click(object sender, EventArgs e)
        {
            
            ClienteForm ClienteFrm = new ClienteForm();
            ClienteFrm.tabControlCliente.Enabled = true;
            ClienteFrm.btnNuevoCliente.Enabled = false;
            ClienteFrm.btnConsultarCliente.Enabled = true;
            ClienteFrm.tabControlCliente.SelectedIndex = 1;
            
            ClienteFrm.Show();

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            if (tabControlPoliza2.SelectedIndex >= 1) tabControlPoliza2.SelectedIndex = (tabControlPoliza2.SelectedIndex - 1);
            btnSiguiente.Enabled = true;
        }

        private void btnDeclaracionHijos_Click_1(object sender, EventArgs e)
        {
            declaracionHijosView.Show();
            declaracionHijosView.BringToFront();
        }

        private void btnMedidasdeSeguridad_Click_1(object sender, EventArgs e)
        {
            medidaSeguridadView.Show();
            medidaSeguridadView.BringToFront();
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModelo.DataSource = null;
            GestorExtra gestorExtra = new GestorExtra();
            comboBoxModelo.DataSource = gestorExtra.BuscarModelo(Convert.ToInt32(comboBoxMarca.SelectedValue));
            comboBoxModelo.DisplayMember = "nombre";
            comboBoxModelo.ValueMember = "id";
        }

        private void btnconsultar_Click_1(object sender, EventArgs e)
        {
            this.tabControlPoliza1.SelectedIndex = 1;
        }

        private void PolizaForm_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBTP2019DataSet.Poliza' Puede moverla o quitarla según sea necesario.
            // this.polizaTableAdapter.Fill(this.dBTP2019DataSet.Poliza);
            GestorExtra gestorExtra = new GestorExtra();

            //Seteo maximo inicio fechapoliza en un mes desde el dia de la fecha
            timepickerFechaInicio.MaxDate = DateTime.Today.AddMonths(1);


            //CARGAR CBOX  TIPO COB     
            comboBoxTipoCobertura.DataSource = gestorExtra.CargarTipoCobertura();
            comboBoxTipoCobertura.DisplayMember = "nombre";
            comboBoxTipoCobertura.ValueMember = "id";

            //CARGAR PROVINCIA
            comboBoxProvincia.DataSource = gestorExtra.CargarProvincia();
            comboBoxProvincia.DisplayMember = "nombre";
            comboBoxProvincia.ValueMember = "id";

            //CARGAR MARCAS

            comboBoxMarca.DataSource = gestorExtra.CargaMarca();
            comboBoxMarca.DisplayMember = "nombre";
            comboBoxMarca.ValueMember = "id";


        }

        private void TabBusquedaPoliza_Enter(object sender, EventArgs e)
        {

            TituloPanelPoliza.Text = "Búsqueda Póliza";
            GestorExtra gestorExtra = new GestorExtra();
            foreach (var marca in gestorExtra.CargaMarca())
            {
                cboxMarcaBusquedaPoliza.Items.Add(marca);
            }
            //cboxMarcaBusquedaPoliza.DataSource = gestorExtra.CargaMarca();
            cboxMarcaBusquedaPoliza.DisplayMember = "nombre";
            cboxMarcaBusquedaPoliza.ValueMember = "id";
            cboxMarcaBusquedaPoliza.Items.Insert(0, "Todos");
            cboxMarcaBusquedaPoliza.SelectedIndex = 0;

            //opcion 2
            foreach (var estado in gestorExtra.CargarEstadosPoliza())
            {
                cboxEstadoBusquedaPoliza.Items.Add(estado);

            }
            //opcion 1 original
            //cboxEstadoBusquedaPoliza.DataSource = gestorExtra.CargarEstadosPoliza();
            cboxEstadoBusquedaPoliza.DisplayMember = "nombre";
            cboxEstadoBusquedaPoliza.ValueMember = "id";
            cboxEstadoBusquedaPoliza.Items.Insert(0, "Todos");
            cboxEstadoBusquedaPoliza.SelectedIndex = 0;


        }

        private void CboxMarcaBusquedaPoliza_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboxModeloBusquedaPoliza.Items.Clear();
            GestorExtra gestorExtra = new GestorExtra();
            // cboxModeloBusquedaPoliza.DataSource = gestorExtra.BuscarModelo(Convert.ToInt32(cboxMarcaBusquedaPoliza.SelectedIndex));
            foreach (var modelo in gestorExtra.BuscarModelo(Convert.ToInt32(cboxMarcaBusquedaPoliza.SelectedIndex)))
            {
                cboxModeloBusquedaPoliza.Items.Add(modelo);
            }
            cboxModeloBusquedaPoliza.DisplayMember = "nombre";
            cboxModeloBusquedaPoliza.ValueMember = "id";
            cboxModeloBusquedaPoliza.Items.Insert(0, "Todos");
            cboxModeloBusquedaPoliza.SelectedIndex = 0;
        }

        private void BtnBuscarTabConsultaPoliza_Click(object sender, EventArgs e)
        {
            //super consulta

        }

        private void BtnVolverTabDetallePoliza_Click(object sender, EventArgs e)
        {
            tabControlPoliza1.SelectedTab = tabBusquedaPoliza;
        }



        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GestorPoliza gestorPoliza = new GestorPoliza();
            int polizaId = Convert.ToInt32(dataGridBusquedaPoliza.Rows[e.RowIndex].Cells[0].Value);
            var ResultBusquedaPolizaCliente = gestorPoliza.BuscarDetallePolizaID(polizaId);
            CargarPolizaDetalles(ResultBusquedaPolizaCliente.Item1, ResultBusquedaPolizaCliente.Item2);
            tabControlPoliza1.SelectedTab = tabDetallesPoliza;
        }
        private void btnBuscarTabConsultaPoliza_Click_1(object sender, EventArgs e)
        {
            GestorPoliza gestorPoliza = new GestorPoliza();
            dto_busquedaPoliza dtoBusquedaPoliza = new dto_busquedaPoliza();




            //cargamos dto con datos a buscar
            dtoBusquedaPoliza.idestado = Convert.ToInt32(cboxEstadoBusquedaPoliza.SelectedIndex);
            dtoBusquedaPoliza.idmarca = Convert.ToInt32(cboxMarcaBusquedaPoliza.SelectedIndex);
            dtoBusquedaPoliza.idmodelo = Convert.ToInt32(cboxModeloBusquedaPoliza.SelectedValue);
            dtoBusquedaPoliza.nombreCliente = textBoxClienteNombreBusquedaPoliza.Text;
            dtoBusquedaPoliza.fdesde = dtPickerDesdeBusquedaPoliza.Value;
            dtoBusquedaPoliza.fhasta = dtPickerHastaBusquedaPoliza.Value;


            ////////////////////////////////
            ///cargamos data table 
            dataGridBusquedaPoliza.DataSource = gestorPoliza.BuscarPoliza(dtoBusquedaPoliza);

            dataGridBusquedaPoliza.Refresh();

        }

        private void comboBoxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLocalidad.DataSource = null;
            GestorExtra gestorExtra = new GestorExtra();
            comboBoxLocalidad.DataSource = gestorExtra.BuscarLocalidad(Convert.ToInt32(comboBoxProvincia.SelectedValue));
            comboBoxLocalidad.DisplayMember = "nombre";
            comboBoxLocalidad.ValueMember = "id";
        }

        private void comboBoxAño_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ToolTipTitle = "Entrada inválida";
            toolTip1.Show("Debés ingresar un caracter válido, de acuerdo al tipo de patente que has elegido.", nroPatenteMaskedTextBox, nroPatenteMaskedTextBox.Location, 3000);
        }

        private void nroPatenteMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (nroPatenteMaskedTextBox.Text.Length == nroPatenteMaskedTextBox.Mask.Length)
            {
                nroPatenteMaskedTextBox.ForeColor = Color.Green;
            }
            else
            {
                nroPatenteMaskedTextBox.ForeColor = Color.Red;
            }
        }
        private void textBoxClienteNombre_TextChanged(object sender, EventArgs e)
        {
            GestorExtra gestorExtra = new GestorExtra();
            comboBoxNroSiniestros.SelectedIndex = gestorExtra.GetNroSiniestros(Convert.ToInt32(textBoxClienteNro.Text));
        }
    }

}
