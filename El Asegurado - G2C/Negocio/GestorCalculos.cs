using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GestorCalculos
    {
        public int CalcularDerechoEmision()
        {
            int derechoEmision = 150;
            return derechoEmision;
        }

        public int CalcularPrima()
        {
            int prima = new Random().Next(8000,60000);
            return prima;
        }

        public int CalcularDescuento(int formaPago, int idCliente, decimal premio)
        {
            int descuento = 0;
            if(formaPago == 1)
            {
                descuento = Convert.ToInt32(premio / 20);    //simula un 5% de descuento, si paga en forma semestral
            }
            return descuento;
        }
    }
}
