using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cassandra.Datos
{
    public class clsBajas
    {
        Conexión ObjCnx = new Conexión();


        public bool BajasEmpleados(string name, int telefono, string domicilio)
        {
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("Delete from Empleados ");
            Query.AppendLine("where nombre = '" + name + "'and telefono = " + telefono + "and domicilio = '" + domicilio + "'");
            return ObjCnx.Conectado(Query.ToString());
        }

        public bool BajasUpdateEmpleados(int id_Empleados)
        {
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("Update Empleados ");
            Query.AppendLine("set nombre = 'null', telefono = 0,  domicilio = 'null'");
            Query.AppendLine("where id_Empleado = "+id_Empleados+";");
            return ObjCnx.Conectado(Query.ToString());
        }


        public bool BajasVentas(int topay, string reciboCliente, int idEmpleado, int idMedecine)
        {
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("Delete from Medicine ");
            Query.AppendLine("where ToPay_Client = " + topay + ", Recibo_Client = '" + reciboCliente + "', id_Empleado = " + idEmpleado + ", idMedicine = "+idMedecine+"");
            return ObjCnx.Conectado(Query.ToString());
        }

        public bool BajasUpdateVentas(int id_Empleados)
        {
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("Update Ventas");
            Query.AppendLine("set ToPay_Client = 0, Recibo_Client = 'null'");
            Query.AppendLine("where id_Empleado = " + id_Empleados + ";");
            return ObjCnx.Conectado(Query.ToString());
        }

    }
}
