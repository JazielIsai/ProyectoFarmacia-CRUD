using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cassandra.Datos
{
    public class clsAltas
    {
        Conexión ObjCnx = new Conexión();
        public bool InsertarEmpleados(string name, int cellphone, string domicilio)
        {
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("insert into Empleados (nombre,telefono,domicilio) ");
            Query.AppendLine("values ('" + name + "'," + cellphone + ",'" + domicilio + "');");
            return ObjCnx.Conectado(Query.ToString());
        }

        public bool InsertarMedicine(string NameMedicine, int Quantity, float Precio)
        {
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("insert into Medicine (NameMedicine,Quantity,Precio) ");
            Query.AppendLine("values ('" + NameMedicine + "'," + Quantity + "," + Precio + ");");
            return ObjCnx.Conectado(Query.ToString());
        }

        public bool InsertarVentas(float ToPay_Client, string Recibo_Client, int id_Empleado, int id_Medicine)
        {
            StringBuilder Query = new StringBuilder();
            Query.AppendLine("insert into Ventas (ToPay_Client,Recibo_Client,id_Empleado,id_Medicine) ");
            Query.AppendLine("values (" + ToPay_Client + ",'" + Recibo_Client + "'," + id_Empleado + ", "+ id_Medicine + ");");
            return ObjCnx.Conectado(Query.ToString());
        }

    }
}
