using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public class AccesoDatos
    {
        public void GuardarPersona(Persona persona)
        {
            // Lógica para guardar los datos de una persona en la base de datos
        }

        public void GuardarVehiculo(Vehiculo vehiculo)
        {
            // Lógica para guardar los datos de un vehículo en la base de datos
        }

        public Persona BuscarPersonaPorId(int id)
        {
            // Lógica para buscar una persona en la base de datos por su id
        }

        public Vehiculo BuscarVehiculoPorNumeroPlaca(string numeroPlaca)
        {
            // Lógica para buscar un vehículo en la base de datos por su número de placa
        }

        public void GuardarRegistroIngreso(double ingreso, DateTime fecha)
        {
            // Lógica para guardar un registro de ingreso en la base de datos
        }

        public List<double> ObtenerIngresosDiarios(DateTime fecha)
        {
            // Lógica para obtener los ingresos diarios de una fecha específica
        }

        public List<double> ObtenerIngresosMensuales(DateTime fecha)
        {
            // Lógica para obtener los ingresos mensuales de una fecha específica
        }
    }

}
