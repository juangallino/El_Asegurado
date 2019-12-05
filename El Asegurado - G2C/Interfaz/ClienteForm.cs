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


namespace Interfaz
{
    public partial class ClienteForm : Form
    {
        List<dto_ListaClientesBuscados> ListaClientesBuscados = new List<dto_ListaClientesBuscados>();
        int RowPosition = -1;
        public ClienteForm()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBTP2019DataSet.Poliza' Puede moverla o quitarla según sea necesario.
            // this.polizaTableAdapter.Fill(this.dBTP2019DataSet.Poliza);
            GestorExtra gestorExtra = new GestorExtra();

           //CARGAR CBOX  TIPO Documento     
            comboBoxTipoDocumento.DataSource = gestorExtra.CargarTipoDocumento();
            comboBoxTipoDocumento.DisplayMember = "nombre";
            comboBoxTipoDocumento.ValueMember = "id";


        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            this.tabControlCliente.SelectedIndex = 0;
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            this.tabControlCliente.SelectedIndex = 1;
        }

        private void btnBuscarClienteCliente_Click(object sender, EventArgs e)
        {
            GestorCliente gestorCliente = new GestorCliente();
            DTO_busquedaCliente dtoBusquedaCliente = new DTO_busquedaCliente();


            //cargamos dto con datos a buscar
            if (!string.IsNullOrWhiteSpace(textBoxIdCliente.Text))

                dtoBusquedaCliente.IdCliente = textBoxIdCliente.Text == "" ? -1 : Convert.ToInt32(textBoxIdCliente.Text);
            if (!string.IsNullOrWhiteSpace(textBoxApellido.Text))

                dtoBusquedaCliente.Apellido = textBoxApellido.ToString();
            if (!string.IsNullOrWhiteSpace(textBoxNombre.Text))

                dtoBusquedaCliente.Nombre = textBoxNombre.ToString();
            if (!string.IsNullOrWhiteSpace(textBoxNroDocumento.Text))

                dtoBusquedaCliente.NroDocumento = textBoxNroDocumento.Text == "" ? -1 : Convert.ToInt32(textBoxNroDocumento.Text);
                
            ////////////////////////////////
            ///cargamos data table 
            ///
            try
            {
                dataGridBusquedaCliente.DataSource = gestorCliente.BuscarCliente(dtoBusquedaCliente);

                dataGridBusquedaCliente.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }






        }


        private void dataGridBusquedaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowPosition = e.RowIndex;
           
        }


       private void comboBoxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridBusquedaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelcliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
