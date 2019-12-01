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

namespace Interfaz
{
    public partial class MedidasSeguridadForm : Form
    {
        public MedidasSeguridadForm()
        {
            InitializeComponent();
        }

        private void BtnAceptar_gestMedSEg_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void MedidasSeguridadForm_Load(object sender, EventArgs e)
        {

        }
        public dto_poliza ObtenerDatos(dto_poliza dtoPoliza)
        {
            List<int> dtoAux = new List<int>();
            if (btncheckGarage.Checked) dtoAux.Add(1);
            if (btncheckAlarma.Checked) dtoAux.Add(2);
            if (btncheckRastreo.Checked) dtoAux.Add(3);
            if (btncheckTuercas.Checked) dtoAux.Add(4);

            dtoPoliza.Medidas_Seguridad = dtoAux;

            return dtoPoliza;
        }
        public void limpiate()
        {
            btncheckGarage.Checked = false;
            btncheckAlarma.Checked = false;
            btncheckRastreo.Checked= false;
            btncheckTuercas.Checked = false;
        }
    }
}
