using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DTO;

using Negocio;


namespace Interfaz
{
    public partial class DeclaracionHijosForm : Form
    {
        List <dto_hijo> ListaHijos= new List<dto_hijo>();
        int RowPosition = -1;
        public DeclaracionHijosForm()
        {
            InitializeComponent();
        }
         public void Limpiate()
        {
            ListaHijos = null;
            HijosGridView.Rows.Clear();
            HijosGridView.Refresh();
          
        }
        private void DeclaracionHijosForm_Load(object sender, EventArgs e)
        {
            GestorExtra gestorExtra = new GestorExtra();


            dateTimePickerDeclaH.MaxDate = DateTime.Today.AddYears(-18);
       
            //CARGAR CBOX  Estado Civil     
            comboBoxEstadoCivilDeclaH.DataSource = gestorExtra.CargarEstadoCivil();
            comboBoxEstadoCivilDeclaH.DisplayMember = "nombre";
            comboBoxEstadoCivilDeclaH.ValueMember = "id";

            //CARGAR CBOX  SEXO     
            comboBoxSexoDeclaH.DataSource = gestorExtra.CargarSexo();
            comboBoxSexoDeclaH.DisplayMember = "nombre";
            comboBoxSexoDeclaH.ValueMember = "id";




        }


        private void BtnAceptar_declaracionH_Click(object sender, EventArgs e)
        {
            //al aceptar se deberan crear los hijos en la bd y guardarlos
            Hide();
            //////////////////////////////////////////////////
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxEstadoCivilDeclaH.SelectedItem != null && comboBoxSexoDeclaH.SelectedItem != null && dateTimePickerDeclaH != null) {
                dto_hijo dtoHijo = new dto_hijo();
                dtoHijo.IdEstadoCivil = Convert.ToInt32(comboBoxEstadoCivilDeclaH.SelectedValue);            //Convert.ToInt32(comboBoxEstadoCivilDeclaH.SelectedValue);
                dtoHijo.Fecha_nac = Convert.ToDateTime(dateTimePickerDeclaH.Value);
                                                                                                        // MessageBox.Show("fecha " + dtoHijo.Fecha_nac + " ");
                dtoHijo.IdSexo = Convert.ToInt32(comboBoxSexoDeclaH.SelectedValue);
                                                   
                // Lo ag4regamos a la lista
                int n = HijosGridView.Rows.Add();
                HijosGridView.Rows[n].Cells[0].Value = dateTimePickerDeclaH.Value.ToShortDateString();
                HijosGridView.Rows[n].Cells[1].Value = comboBoxSexoDeclaH.Text;
                HijosGridView.Rows[n].Cells[2].Value = comboBoxEstadoCivilDeclaH.Text;
                HijosGridView.Rows[n].Cells[3].Value = dtoHijo.Id;
                ListaHijos.Add(dtoHijo);
                


            }
        }

        private void DateTimePickerDeclaH_ValueChanged(object sender, EventArgs e)
        {        }

        private void HijosGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowPosition = e.RowIndex;
        }
                 

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (RowPosition != -1 && RowPosition != HijosGridView.NewRowIndex)
            {
                BorrarHijo(RowPosition);
                HijosGridView.Rows.RemoveAt(RowPosition);
                RowPosition = -1;
                
            }
        }
       
        public dto_poliza ObtenerDatos(dto_poliza dtopoliza)
        {
            dtopoliza.Hijo = ListaHijos;
            return dtopoliza;

        }

        public void BorrarHijo(int RowPosition)
        {
          int IdRow = Convert.ToInt32(HijosGridView.Rows[RowPosition].Cells[3].Value);     
          
            foreach (dto_hijo hijo in ListaHijos)         
            {   
                int IdHijo = Convert.ToInt32(hijo.Id);                
                if (IdHijo == IdRow){                  
                    ListaHijos.Remove(hijo);                   
                    break;
                }                
            }
        }

        private void HijosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
        
     
   

