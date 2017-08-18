using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DYNAMICS.BS
{
    public class mantenimientoCliente
    {
        public Boolean  Agregar(BE.Cliente mantenimiento) {
            DS.mantenimientoCliente dsMantenimiento;
            dsMantenimiento = new DS.mantenimientoCliente();
            return dsMantenimiento.Agregar(mantenimiento);
        }

        public List<BE.Cliente> Listar()
        {
            DS.mantenimientoCliente dsMantenimiento;
            dsMantenimiento = new DS.mantenimientoCliente();
            return dsMantenimiento.Listar();
        }

        public BE.Cliente ObtenerCliente(int IdCliente)
        {
            DS.mantenimientoCliente dsMantenimiento;
            dsMantenimiento = new DS.mantenimientoCliente();
            return dsMantenimiento.ObtenerCliente(IdCliente);
        }

        public Boolean Editar(BE.Cliente mantenimiento){
            DS.mantenimientoCliente dsMantenimiento;
            dsMantenimiento = new DS.mantenimientoCliente();
            return dsMantenimiento.Editar(mantenimiento);
        }

    }
}
