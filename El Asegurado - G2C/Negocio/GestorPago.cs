using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace Negocio
{
    public class GestorPago
    {
        public dto_PagoPoliza cargarPolizaParaPagar(int idPoliza)
        {
            dto_PagoPoliza dtoPagoPoliza = new dto_PagoPoliza();
            GestorPoliza gestorPoliza = new GestorPoliza();
            Poliza poliza = new Poliza();
            poliza = gestorPoliza.BuscarPoliza(idPoliza);

            return dtoPagoPoliza;

        }
    }
}
