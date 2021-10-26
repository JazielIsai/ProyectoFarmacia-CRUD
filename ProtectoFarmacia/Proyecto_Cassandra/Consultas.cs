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
    public partial class Consultas : Form
    {
        Datos.clsSelectMostrarTables ObjShowTable = new Datos.clsSelectMostrarTables();
        public Consultas()
        {
            InitializeComponent();
        }

        Menu FromMenu = new Menu();
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FromMenu.Show();
            this.Close();
        }

        private void BtnConsultarMedicina_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ObjShowTable.MostrarTablaMedicine();
        }

        private void BrnConsultarVentas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ObjShowTable.MostrarTablaVentas();

        }

        private void btnConsultEmpleados_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ObjShowTable.MostrarTablaEmpleados();
        }
    }
}
