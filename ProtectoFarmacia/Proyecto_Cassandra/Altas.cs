using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cassandra
{
    public partial class Altas : Form
    {
        Datos.clsAltas ObjAltas = new Datos.clsAltas();

        public Altas()
        {
            InitializeComponent();
        }

        Menu FromMenu = new Menu();

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            FromMenu.Show();
            this.Close();
        }

        private void btnAltasMedicamento_Click(object sender, EventArgs e)
        {
            ObjAltas.InsertarMedicine(TxtNmedicina.Text, Convert.ToInt32(TxtCantidad.Text), float.Parse(TxtPrecio.Text));
        }

        private void btnAltasCliente_Click(object sender, EventArgs e)
        {
            ObjAltas.InsertarEmpleados(TxtCliente.Text, Convert.ToInt32(txtCellPhone.Text), txtDomicilio.Text);
        }
    }
}
