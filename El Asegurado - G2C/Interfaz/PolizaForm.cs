using System;
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
        readonly DeclaracionHijosForm declaracionHijosView = new DeclaracionHijosForm();
        readonly MedidasSeguridadForm medidaSeguridadView = new MedidasSeguridadForm();
        dto_poliza DTOPOLIZAAUX = new dto_poliza();

        bool checkCancel = true;


        public PolizaForm()
        {
            InitializeComponent();
            panelPoliza.Visible = true;
            textBoxSumaAsegurada.Visible = false;
            lblSumaAsegurada.Visible = true;

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
            GestorCalculos gestorCalculos = new GestorCalculos();
            try
            {
                //Creo un gestor poliza para poder calcular el premio y los descuentos
                
                dto_poliza dtoPoliza = new dto_poliza
                {
                    IdDomicilioRiesgo = Convert.ToInt32(comboBoxLocalidad.SelectedValue),
                    Suma_Asegurada = Convert.ToInt32(textBoxSumaAsegurada.Text),
                    IdVehiculo = Convert.ToInt32(comboBoxModelo.SelectedValue),
                    Marca = comboBoxMarca.Text,
                    Modelo = comboBoxModelo.Text,
                    AñoVehiculo = Convert.ToInt32(comboBoxAño.Text),
                    NroMotor = textBoxMotorNro.Text,
                    NroChasis = textboxChasis.Text,
                    KmPorAño = Convert.ToInt32(textBoxKmAño.Text),
                    Nro_Siniestros = comboBoxNroSiniestros.SelectedIndex,
                    Tipo_Cobertura = Convert.ToInt32(comboBoxTipoCobertura.SelectedValue),
                    NombreCobertura = comboBoxTipoCobertura.Text,
                    FechaInicioVigencia = (timepickerFechaInicio.Value),
                    Patente = nroPatenteMaskedTextBox.Text,
                    IdCliente = Convert.ToInt32(textBoxClienteNroPpal.Text)
                }; // Creamos el dto de poliza y lo cargamos con los datos obtenido de la interfaz

                //CREAMOS LAS LISTA DE CUOTAS
                dtoPoliza.Vto_Pago = gestorExtra.CargarListaCuotas(dtoPoliza.FechaInicioVigencia.AddDays(-1));

                //OBTENGO FORMA DE PAGO
                if (btnCheckMensual.Checked) dtoPoliza.FormaPago = 6;
                if (btnCheckSemestral.Checked) dtoPoliza.FormaPago = 1;

                //OBTENGO DATOS DE LOS OTROS FORMULARIOS
                dtoPoliza = declaracionHijosView.ObtenerDatos(dtoPoliza);
                dtoPoliza = medidaSeguridadView.ObtenerDatos(dtoPoliza);

                
                //CALCULO DERECHO EMISION, PREMIO Y DESCUENTOSF
                dtoPoliza.DerechoEmision = gestorCalculos.CalcularDerechoEmision();
                dtoPoliza.Premio = gestorCalculos.CalcularPrima() + dtoPoliza.DerechoEmision;
                dtoPoliza.ImporteDescuento = gestorCalculos.CalcularDescuento(dtoPoliza.FormaPago, dtoPoliza.IdCliente, dtoPoliza.Premio);
                dtoPoliza.Monto_Abonar =  dtoPoliza.DerechoEmision + dtoPoliza.Premio - dtoPoliza.ImporteDescuento;

                CargarRevisionPoliza(dtoPoliza);
                //Le asigno a la variable global DTOPOLIZACTE, el dto que voy a imprimir
                DTOPOLIZAAUX = dtoPoliza;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public void CargarRevisionPoliza(dto_poliza dtoPoliza)
        {
            textBoxTitularSeguro.Text = textBoxClienteNombre.Text;
            textBoxRevMarca.Text = dtoPoliza.Marca;
            textBoxRevModelo.Text = dtoPoliza.Modelo;
            textBoxRevChasis.Text = dtoPoliza.NroChasis;
            textBoxRevMotorNro.Text = dtoPoliza.NroMotor;
            textBoxRevPatante.Text = dtoPoliza.Patente;

            textBoxRevVigenciaFin.Text = dtoPoliza.FechaInicioVigencia.AddMonths(6).ToShortDateString();
            textBoxRevVigenciaInicio.Text = dtoPoliza.FechaInicioVigencia.ToShortDateString();

            textBoxRevSumaAsegurada.Text = dtoPoliza.Suma_Asegurada.ToString("0.00");
            textBoxRevPremio.Text = dtoPoliza.Premio.ToString("0.00");
            textBoxRevImpDescuentos.Text = dtoPoliza.ImporteDescuento.ToString("0.00");

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

        private void LimpiarCampos()
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

            btnCheckMensual.Checked = true;
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
            textBoxClienteNroPpal.Text = "";

            //cliente
            textBoxClienteDNI.Text = "";
            textBoxClienteDomicilio.Text = "";
            textBoxClienteNombre.Text = "";
            textBoxClienteDNI.Text = "";

        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            checkCancel = false;    //habilita la navegación entre pestañas
            try
            {
                switch (tabControlPoliza2.SelectedTab.Text)
                {
                    case "Datos Póliza":
                        var control = ValidarPestañaNuevo();
                        //Si no valida, no pasa a la siguiente pestaña, y muestra error
                        if (control == null)
                        {
                            tabControlPoliza2.SelectedIndex += 1;
                            //CARGAR CBOX  TIPO COBERTURA
                            GestorExtra gestorExtra = new GestorExtra();
                            comboBoxTipoCobertura.DataSource = gestorExtra.CargarTipoCobertura(Convert.ToInt32(comboBoxAño.SelectedItem));
                            comboBoxTipoCobertura.DisplayMember = "nombre";
                            comboBoxTipoCobertura.ValueMember = "id";
                        }
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
                    case "Tipo Cobertura":
                        tabControlPoliza2.SelectedIndex += 1;
                        ObtenerDatos();
                        btnSiguiente.Text = "Emitir Póliza";
                        break;
                    case "Revisión":
                        ConfirmarGenerarPoliza();
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"¡Atención!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Método que genera un cambio de color en el control que generó un error
        private async void Blink(Control control)
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                cts.CancelAfter(1000);
                Color colorOrig = control.BackColor;
                while (!cts.IsCancellationRequested)
                {
                    await Task.Delay(250);
                    control.BackColor = control.BackColor == Color.Red ? Color.PaleVioletRed : Color.Red;

                }
                control.BackColor = colorOrig;
            }
        }

        //Valida que los controles estén completos y correctos
        private System.Windows.Forms.Control ValidarPestañaNuevo()
        {
            //Recorremos los controles cuyo contenido puede contener algún error
            //Cliente
            if (textBoxClienteNroPpal.Text == "")
            {
                return textBoxClienteNroPpal;
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
        private void ConfirmarGenerarPoliza()
        {
            GestorPoliza gestorPoliza = new GestorPoliza();
            DialogResult Estaseguro = MessageBox.Show("¿Está seguro que desea dar de alta una Póliza nueva? ¡Esta acción no se puede deshacer!", "Generar Póliza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (Estaseguro)
            {
                case DialogResult.Yes:   // Yes button pressed
                    try
                    {
                        gestorPoliza.GenerarPoliza(DTOPOLIZAAUX);
                        DTOPOLIZAAUX = null;
                        declaracionHijosView.Limpiate();
                        medidaSeguridadView.limpiate();
                        LimpiarCampos();
                        tabControlPoliza2.SelectedIndex = 0;
                        cargarForm();
                        btnSiguiente.Text = "Siguiente";
                        MessageBox.Show("Póliza emitida con Exito", "Nueva Póliza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                     catch(Exception e) 
                    {
                        throw new Exception(e.Message);
                        
                    }
                    break;
                case DialogResult.No:    // No button pressed
                    MessageBox.Show("Creación de póliza cancelada.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;

                    // gestorPoliza.generarPoliza(DTOPOLIZACTE);
                    // DTOPOLIZACTE = null;
            }
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

        private void BtnMedidasdeSeguridad_Click(object sender, EventArgs e)
        {
            medidaSeguridadView.Show();
            medidaSeguridadView.BringToFront();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarKeypres(e, false, true, false, true);
        }

        void Mayusculas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void ComboBoxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxModelo.DataSource = null;
            GestorExtra gestorExtra = new GestorExtra();
            comboBoxModelo.DataSource = gestorExtra.BuscarModelo(Convert.ToInt32(comboBoxMarca.SelectedValue));
            comboBoxModelo.DisplayMember = "nombre";
            comboBoxModelo.ValueMember = "id";
        }

      private void ComboBoxAño_SelectedIndexChanged(object sender, EventArgs e)
        {

            GestorExtra gestorExtra = new GestorExtra();
            textBoxSumaAsegurada.Visible = true;
            lblSumaAsegurada.Visible = true;
            textBoxSumaAsegurada.Text = Convert.ToString(gestorExtra.GetSumaAsegurada(comboBoxModelo.SelectedIndex, comboBoxAño.SelectedIndex));
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

        private void BtnVolverTabDetallePoliza_Click(object sender, EventArgs e)
        {
            tabControlPoliza1.SelectedTab = tabBusquedaPoliza;
        }



        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GestorPoliza gestorPoliza = new GestorPoliza();
            int polizaId = Convert.ToInt32(dataGridBusquedaPoliza.Rows[e.RowIndex].Cells[0].Value);
      //      dto_Poliza = gestorPoliza.BuscarDetallePolizaID(polizaId);
      //      CargarPolizaDetalles(ResultBusquedaPolizaCliente.Item1, ResultBusquedaPolizaCliente.Item2);
      //      tabControlPoliza1.SelectedTab = tabDetallesPoliza;
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



        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            this.tabControlPoliza2.Enabled = false;
            GestorCliente gestorCliente = new GestorCliente();
            dto_cliente dtoCliente;
            ClienteForm ClienteFrm = new ClienteForm();
            ClienteFrm.tabControlCliente.Enabled = true;
            ClienteFrm.btnNuevoCliente.Enabled = false;
            ClienteFrm.btnConsultarCliente.Enabled = true;
            ClienteFrm.tabControlCliente.SelectedIndex = 1;

            ClienteFrm.ShowDialog();
            MessageBox.Show("ClienteSeleccionado" + ClienteFrm.TxtClienteSeleccionado);
            lblClienteSeleccionado.Text = ClienteFrm.TxtClienteSeleccionado;

            try
            {
                dtoCliente = gestorCliente.CargarDTOCliente(Convert.ToInt32(lblClienteSeleccionado.Text));
                textBoxClienteNroPpal.Text = (dtoCliente.IdCliente.ToString());
                textBoxClienteNombre.Text = (dtoCliente.Nombre.Trim() + ", " + dtoCliente.Apellido.Trim());
                textBoxClienteDomicilio.Text = (dtoCliente.Calle.ToString().Trim() + "  " + dtoCliente.NumeroDomicilio.ToString().Trim() + ",  " + dtoCliente.Localidad.ToString().Trim() + ", " + dtoCliente.Provincia.ToString().Trim() + ", " + dtoCliente.Pais.ToUpper().ToString().Trim());
                textBoxClienteDNI.Text = dtoCliente.TipoDoc.ToString().Trim() + " " + dtoCliente.NroDocumento.ToString().Trim();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            this.tabControlPoliza2.Enabled = true;
            tabControlPoliza2.SelectedIndex = 0;

        }

        private void BtnBusquedaCliente_Click(object sender, EventArgs e)
        {
            GestorCliente gestorCliente = new GestorCliente();
            dto_cliente dtoCliente;
            ClienteForm ClienteFrm = new ClienteForm();
            ClienteFrm.tabControlCliente.Enabled = true;
            ClienteFrm.btnNuevoCliente.Enabled = false;
            ClienteFrm.btnConsultarCliente.Enabled = true;
            ClienteFrm.tabControlCliente.SelectedIndex = 1;
            

            ClienteFrm.ShowDialog();
            if (!string.IsNullOrEmpty(ClienteFrm.TxtClienteSeleccionado))
            { 
                lblClienteSeleccionado.Text = ClienteFrm.TxtClienteSeleccionado;

            

                try
                {
                    dtoCliente = gestorCliente.CargarDTOCliente(Convert.ToInt32(lblClienteSeleccionado.Text));
                    textBoxClienteNroPpal.Text = (dtoCliente.IdCliente.ToString());
                    textBoxClienteNombre.Text = (dtoCliente.Nombre.Trim() + ", " + dtoCliente.Apellido.Trim());
                    textBoxClienteDomicilio.Text = (dtoCliente.Calle.ToString().Trim() + "  " + dtoCliente.NumeroDomicilio.ToString().Trim() + ",  " + dtoCliente.Localidad.ToString().Trim() + ", " + dtoCliente.Provincia.ToString().Trim() + ", " + dtoCliente.Pais.ToUpper().ToString().Trim());
                    textBoxClienteDNI.Text = dtoCliente.TipoDoc.ToString().Trim() + " " + dtoCliente.NroDocumento.ToString().Trim();
                }
                catch (Exception error)
                {
                    throw new Exception(error.Message);
                }
            }
            else
                MessageBox.Show("No se ha seleccionado un cliente");
            
            tabControlPoliza2.SelectedIndex = 0;
         
        }

        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            checkCancel = false;        //habilita la navegación entre pestañas
            if (tabControlPoliza2.SelectedIndex >= 1)
            {
                tabControlPoliza2.SelectedIndex = (tabControlPoliza2.SelectedIndex - 1);
                btnSiguiente.Text = "Siguiente";
            }
            else
            {
                btnNuevo.Focus();
            }
            btnSiguiente.Enabled = true;

        }

        private void BtnDeclaracionHijos_Click_1(object sender, EventArgs e)
        {
            declaracionHijosView.ShowDialog();
            declaracionHijosView.BringToFront();
        }

        private void BtnMedidasdeSeguridad_Click_1(object sender, EventArgs e)
        {
            medidaSeguridadView.ShowDialog();
            medidaSeguridadView.BringToFront();
        }

        private void ComboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModelo.DataSource = null;
            GestorExtra gestorExtra = new GestorExtra();
            comboBoxModelo.DataSource = gestorExtra.BuscarModelo(Convert.ToInt32(comboBoxMarca.SelectedValue));
            comboBoxModelo.DisplayMember = "nombre";
            comboBoxModelo.ValueMember = "id";
        }

        private void Btnconsultar_Click_1(object sender, EventArgs e)
        {
            this.tabControlPoliza1.SelectedIndex = 1;
        }

        private void PolizaForm_Load_1(object sender, EventArgs e)
        {
            cargarForm();
        }

        private void cargarForm()
        {
            // TODO: esta línea de código carga datos en la tabla 'dBTP2019DataSet.Poliza' Puede moverla o quitarla según sea necesario.
            // this.polizaTableAdapter.Fill(this.dBTP2019DataSet.Poliza);
            GestorExtra gestorExtra = new GestorExtra();

            //Seteo maximo inicio fechapoliza en un mes desde el dia de la fecha
            timepickerFechaInicio.MaxDate = DateTime.Today.AddMonths(1);


            //CARGAR PROVINCIA
            comboBoxProvincia.DataSource = gestorExtra.CargarProvincia();
            comboBoxProvincia.DisplayMember = "nombre";
            comboBoxProvincia.ValueMember = "id";

            //CARGAR MARCAS
            comboBoxMarca.DataSource = gestorExtra.CargaMarca();
            comboBoxMarca.DisplayMember = "nombre";
            comboBoxMarca.ValueMember = "id";
        }

        private void BtnBuscarTabConsultaPoliza_Click_1(object sender, EventArgs e)
        {
            GestorPoliza gestorPoliza = new GestorPoliza();
            dto_busquedaPoliza dtoBusquedaPoliza = new dto_busquedaPoliza
            {

                //cargamos dto con datos a buscar
             /*   idestado = Convert.ToInt32(cboxEstadoBusquedaPoliza.SelectedIndex),
                idmarca = Convert.ToInt32(cboxMarcaBusquedaPoliza.SelectedIndex),
                idmodelo = Convert.ToInt32(cboxModeloBusquedaPoliza.SelectedValue),
                nombreCliente = textBoxClienteNombreBusquedaPoliza.Text,
                fdesde = dtPickerDesdeBusquedaPoliza.Value,
                fhasta = dtPickerHastaBusquedaPoliza.Value
                */
            };


            ////////////////////////////////
            ///cargamos data table 
           // dataGridBusquedaPoliza.DataSource = gestorPoliza.BuscarPoliza(dtoBusquedaPoliza);

          //  dataGridBusquedaPoliza.Refresh();

        }

        private void ComboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLocalidad.DataSource = null;
            GestorExtra gestorExtra = new GestorExtra();
            comboBoxLocalidad.DataSource = gestorExtra.BuscarLocalidad(Convert.ToInt32(comboBoxProvincia.SelectedValue));
            comboBoxLocalidad.DisplayMember = "nombre";
            comboBoxLocalidad.ValueMember = "id";
        }
        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ToolTipTitle = "Entrada inválida";
            toolTip1.Show("Debés ingresar un caracter válido, de acuerdo al tipo de patente que has elegido.", nroPatenteMaskedTextBox, nroPatenteMaskedTextBox.Location, 3000);
        }

        private void NroPatenteMaskedTextBox_Leave(object sender, EventArgs e)
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
        private void TextBoxClienteNombre_TextChanged(object sender, EventArgs e)
        {
            GestorExtra gestorExtra = new GestorExtra();
            if (textBoxClienteNroPpal.Text == "")
                comboBoxNroSiniestros.SelectedItem = null;
            else
                comboBoxNroSiniestros.SelectedIndex = gestorExtra.GetNroSiniestros(Convert.ToInt32(textBoxClienteNroPpal.Text));
        }
       
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = checkCancel;
            checkCancel = true;
        }
    }

}
