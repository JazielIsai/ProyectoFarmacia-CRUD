using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proyecto_Cassandra.Datos
{
    public class clsSelectMostrarTables
    {
        Conexión ObjCnx = new Conexión();

        public DataTable MostrarTablaEmpleados()
        {
            StringBuilder ObjQuery = new StringBuilder();
            ObjQuery.AppendLine("Select * from Empleados;");
            return ObjCnx.RegresaValores(ObjQuery.ToString());
        }

        public DataTable MostrarTablaMedicine()
        {
            StringBuilder ObjQuery = new StringBuilder();
            ObjQuery.AppendLine("Select * from Medicine;");
            return ObjCnx.RegresaValores(ObjQuery.ToString());
        }

        public DataTable MostrarTablaVentas()
        {
            StringBuilder ObjQuery = new StringBuilder();
            ObjQuery.AppendLine("Select * from Ventas;");
            return ObjCnx.RegresaValores(ObjQuery.ToString());
        }


        //Consultar precio de los medicamentos

        public DataTable ObtnerPrecioMedicamento(int id_Medicine)
        {
            StringBuilder ObjQuery = new StringBuilder();
            ObjQuery.AppendLine("select Precio from Medicine ");
            ObjQuery.AppendLine("where id_Medicine = "+id_Medicine+";");
            return ObjCnx.RegresaValores(ObjQuery.ToString());
        }

        public DataTable ObtnerDatosPorIdEmpleado(int id_Empleado)
        {
            StringBuilder ObjQuery = new StringBuilder();
            ObjQuery.AppendLine("select * from Empleados ");
            ObjQuery.AppendLine("where id_Empleado = " + id_Empleado + ";");
            return ObjCnx.RegresaValores(ObjQuery.ToString());
        }

    }
}
