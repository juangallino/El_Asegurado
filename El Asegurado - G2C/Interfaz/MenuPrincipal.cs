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


namespace Interfaz
{
    

    public partial class MenuPrincipal : Form
    {
        //funcion que limita la introduccion por teclado de tipo de entrada no deseada, los booleanos numeero, letra , control y seperador, 
        //deben posear el valor TRUE CUANDO SE DESEA QUE NO SE PUEDAN PRESIONAR


        private ClienteForm ClienteFrm;
        private PolizaForm PolizaFrm;

        public MenuPrincipal()
        {
            InitializeComponent();
           

        }

        
        
    






        private void MenuPrincipal_Load(object sender, EventArgs e)

        {

            

        }





        

       

       

       
    


        /////////////////////////////////////////////////////////////////////////TAB BUSQUEDA/////////////////////////////////////////////////////////
       
        private void panelcliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panelcliente.Visible = false;
            //panelPoliza.Visible = true;
            if (PolizaFrm == null)
            {
                PolizaFrm = new PolizaForm();
                PolizaFrm.MdiParent = this;
                PolizaFrm.Show();
            }
            else
            {
                PolizaFrm.Activate();
                PolizaFrm.Show();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ClienteFrm == null)
            {
                ClienteFrm = new ClienteForm();
                ClienteFrm.MdiParent = this;
                ClienteFrm.Show();
            }
            else
            {
                ClienteFrm.Activate();
                ClienteFrm.Show();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


