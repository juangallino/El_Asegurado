using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_poliza
    {
        public dto_poliza()
        {

        }
        public dto_poliza(bool t)
        {
            //id = 123456;
            NroPolizaSuc = 4444;
            IdCliente = 3;
            IdDomicilioRiesgo = 1;
            IdVehiculo = 2;
            Marca = "Ford";
            Modelo = "Modelo 1";
            AñoVehiculo = 2019;
            Suma_Asegurada = 500000;
            NroMotor = "MSALK12940NC";
            NroChasis = "VVKKNJ213";
            Patente = "PPP999";
            KmPorAño = 50000;
            Medidas_Seguridad = new List<int>
            {
                3
            };
            Nro_Siniestros = 0;
            Hijo = new List<dto_hijo>();
            Tipo_Cobertura = 2;
            FechaInicioVigencia = DateTime.Today;
            Premio = 2000;
            ImporteDescuento = 5;
            Vto_Pago = new List<DateTime>
            {
                DateTime.Today.AddDays(30),
                DateTime.Today.AddDays(60),
                DateTime.Today.AddDays(90),
                DateTime.Today.AddDays(120),
                DateTime.Today.AddDays(180),
                DateTime.Today.AddDays(210)
            };
            FormaPago = 6;
            Monto_Abonar = 6000;

            dto_hijo hijo1 = new dto_hijo
            {
                IdEstadoCivil = 1,
                //Fecha_nac = DateTime.Parse("15/11/2001"),
                IdSexo = 1
            };
            Hijo.Add(hijo1);
        }

        public int id { get; set; }
        public decimal NroPolizaSuc { get; set; }
        public decimal NroPolizaSec { get; set; }
        public int IdCliente { get; set; }
        public int IdDomicilioRiesgo { get; set; }
        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal AñoVehiculo { get; set; }
        public decimal Suma_Asegurada { get; set; }
        public string NroMotor { get; set; }
        public string NroChasis { get; set; }
        public string Patente { get; set; }
        public decimal KmPorAño { get; set; }
        
        public List < int > Medidas_Seguridad   { get; set; }
        public decimal Nro_Siniestros { get; set; }

        public List < dto_hijo > Hijo { get; set; }
        public int Tipo_Cobertura { get; set; }
        public string NombreCobertura { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public decimal Premio { get; set; }
        public decimal ImporteDescuento { get; set; }
        public List<DateTime> Vto_Pago { get; set; }
        public int FormaPago { get; set; }
        public decimal Monto_Abonar { get; set; }
        public string Scoring_cobertura { get; set; }
        public string Scoring_estadistica_robo { get; set; }
        public string Scoring_domicilio_riesgo { get; set; }
        public string Scoring_medidas_seguriadad { get; set; }
        public string Scoring_km_anual { get; set; }
        public string Scoring_hijos { get; set; }
        public string Scoring_unidad_adicional { get; set; }
        public string Scoring_siniestros { get; set; }
        public string Estado { get; set; }
    }
}
