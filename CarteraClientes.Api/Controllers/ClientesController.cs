using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarteraClientes.Api.Controllers
{
    public class ClientesController : ApiController
    {
        public Models.ModeloCartera conexion;
        public ClientesController()
        {
            conexion = new Models.ModeloCartera();
        }
        //GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [Route("api/Clientes/ObtenerClientes")]
        [HttpGet]
        public List<Models.Cliente> GetClientes()
        {
            var consulta = (from c in conexion.Clientes
                            select c).ToList();
            return consulta;
        }
        [Route("api/Clientes/ConsultarClientesNombre")]
        [HttpGet]
        public List<Models.Cliente>GetClientesFiltrados(string nombre)
        {
            var consulta = (from c in conexion.Clientes
                            where c.Nombre.Contains(nombre)
                            select c).ToList();
            return consulta;
        }
        [Route("api/Clientes/GuardarCliente")]
        [HttpPost]
        public bool PostCliente(Models.Cliente datos)
        {
            using(var cnx=new Models.ModeloCartera())
            {
                try
                {
                    datos.FechaCreacion = DateTime.Now;
                    cnx.Clientes.Add(datos);
                    cnx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
        }
        [Route("api/Clientes/ModificarCliente")]
        [HttpPut]
        public bool PutCliente(Models.Cliente datos)
        {
            try
            {
                var consulta = (from c in conexion.Clientes
                                where c.Id == datos.Id
                                select c).FirstOrDefault();
                if (consulta != null)
                {
                    consulta.Nombre = datos.Nombre;
                    consulta.Telefono = datos.Telefono;
                    conexion.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        [Route("api/Clientes/EliminarCliente")]
        [HttpDelete]
        public bool DeleteCliente(int id)
        {
            try
            {
                var consulta = (from c in conexion.Clientes
                                where c.Id == id
                                select c).FirstOrDefault();
                if (consulta != null)
                {
                    conexion.Clientes.Remove(consulta);
                    conexion.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
