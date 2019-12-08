using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;
using DAO;


namespace Negocio
{
    /// <summary>
    /// 
    /// </summary>
    public class GestorCliente
    {
        //comentario
        public Cliente ValidarCliente(int idCliente)
        {
            try
            {
                Cliente cliente = new Cliente();
                DAOCliente dAOCliente = new DAOCliente();
                cliente = dAOCliente.Get(idCliente);
                return cliente;
            }
            catch
            {
                throw new Exception("Cliente no válido");
            }
            
        }

        public void CambiarEstadoCliente(int idcliente, decimal nroSiniestros)
        {

            EstadoCliente estadoCliente = new EstadoCliente();
            DAOCliente dAOCliente = new DAOCliente();

            int cuotasImpagas = getCuotasImpagas(idcliente);

            bool esClienteActivo = ClienteActivo(idcliente);

            if (esClienteActivo && nroSiniestros == 0 && cuotasImpagas == 0)
            {
                estadoCliente = dAOCliente.GetEstadoCliente(2);// "Plata");

            }
            else
            {
                estadoCliente = dAOCliente.GetEstadoCliente(1);// "Normal");
                
            }
            dAOCliente.SetEstadoCliente(idcliente, estadoCliente.id);
        }

        public bool ClienteActivo (int idcliente)
        {
            return true; //Desarrollar
        }

        //Método para cargar los datos desde la Base de Datos en el DTOCliente
        public dto_cliente CargarDTOCliente(int idcliente)
        {
            DAOCliente dAOCliente = new DAOCliente();
            
            dto_cliente dto_Cliente = new dto_cliente();

            Cliente cliente = dAOCliente.Get(idcliente);
            Persona persona = dAOCliente.GetPersona(cliente.idPersona);
            Domicilio domicilio = dAOCliente.GetDomicilio(persona.idDomicilio.GetValueOrDefault());
            Localidad localidad = dAOCliente.GetLocalidad(domicilio.idLocalidad.GetValueOrDefault());
            SituacionIVA situacionIVA = dAOCliente.GetSituacionIVA(cliente.idSituacionIVA);
            TipoDocumento tipoDocumento = dAOCliente.GetTipoDocumento(persona.idTipoDocumento);
            EstadoCivil estadoCivil = dAOCliente.GetEstadoCivil(persona.idEstadoCivil);
            Provincia provincia = dAOCliente.GetProvincia(localidad.idProvincia);
            Pai pais = dAOCliente.GetPais(provincia.idPais);
            Profesion profesion = dAOCliente.GetProfesion(cliente.idProfesion);
            Sexo sexo = dAOCliente.GetSexo(persona.idSexo);

            dto_Cliente.Apellido = persona.apellido;
            dto_Cliente.AñoRegistro = cliente.AñoRegistro;
            dto_Cliente.Calle = domicilio.calle;
            dto_Cliente.CodPostal = localidad.codpostal;
            dto_Cliente.Departamento = domicilio.departamento;
            dto_Cliente.Email = cliente.CorreoElectronico;
            dto_Cliente.EstadoCivil = estadoCivil.nombre;
            dto_Cliente.Fecha_nac = persona.fechaNacimiento;
            dto_Cliente.IdCliente = cliente.id;
            dto_Cliente.Localidad = localidad.nombre;
            dto_Cliente.Nombre = persona.nombre;
            dto_Cliente.NumeroDomicilio = domicilio.numero;
            dto_Cliente.NroCuil = persona.nroCuil;
            dto_Cliente.NroDocumento = persona.nroDocumento;
            dto_Cliente.Pais = pais.nombre;
            dto_Cliente.Piso = domicilio.piso;
            dto_Cliente.Profesion = profesion.nombre;
            dto_Cliente.Provincia = provincia.nombre;
            dto_Cliente.Sexo = sexo.nombre;
            dto_Cliente.SituacionIVA = situacionIVA.nombre;
            dto_Cliente.TipoDoc = tipoDocumento.nombre;
            
            return dto_Cliente;
        }

        public int getCuotasImpagas(int idCliente)
        {
            int cuotasImpagas = 0;

            return cuotasImpagas;
        }
        /// <summary>
        
         public List<dto_ListaClientesBuscados> BuscarCliente(DTO_busquedaCliente dto_BusquedaCliente)
        {
            DAOCliente dAOCliente = new DAOCliente();
           
            List<dto_ListaClientesBuscados> listaAux = new List<dto_ListaClientesBuscados>();
            try
            {

            foreach (var v_Cliente in dAOCliente.ConsultaBuscarClientes(dto_BusquedaCliente))
            {

                dto_ListaClientesBuscados dto_Lista = new dto_ListaClientesBuscados();
                dto_Lista.Id = v_Cliente.id;
                dto_Lista.AñoRegistro = v_Cliente.AñoRegistro;
                dto_Lista.Apellido = v_Cliente.apellido;
                dto_Lista.Nombre = v_Cliente.nombre;
                dto_Lista.IdCliente = v_Cliente.NroCliente;
                dto_Lista.NroDocumento = v_Cliente.nroDocumento;    



                listaAux.Add(dto_Lista);
            }
            return listaAux;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }
        

    }
}
