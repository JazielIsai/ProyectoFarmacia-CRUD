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
    public partial class Bajas : Form
    {
        Datos.clsSelectMostrarTables ObjShowTables = new Datos.clsSelectMostrarTables();
        Datos.clsBajas objBajas = new Datos.clsBajas();

        public Bajas()
        {
            InitializeComponent();
            cmbxBajasEmpleado.DataSource = ObjShowTables.MostrarTablaEmpleados();
            cmbxBajasEmpleado.DisplayMember = "nombre";
            cmbxBajasEmpleado.ValueMember = "id_Empleado";


            cmbxBajasVentas.DataSource = ObjShowTables.MostrarTablaVentas();
            cmbxBajasVentas.DisplayMember = "id_Ventas";
            cmbxBajasVentas.ValueMember = "id_Ventas";

        }

        Menu FromMenu = new Menu();
        private void BtnSalir_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FromMenu.Show();
            this.Close();
        }
        

        private void BtnDeBaja_Click(object sender, EventArgs e)
        {
            int id_Empleado = 0;
            string name = "";
            int cellphone = 0;
            string domicilio = "";
            //string valorCelda = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            
            id_Empleado = Convert.ToInt32(cmbxBajasEmpleado.SelectedValue);
            
            if((cmbxBajasEmpleado.SelectedIndex + 1) == id_Empleado)
            {
                //name = dataGridView1.Rows[0].Cells[1].Value.ToString();
                //cellphone = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString());
                //domicilio = dataGridView1.Rows[0].Cells[3].Value.ToString();
                objBajas.BajasUpdateEmpleados(id_Empleado);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bajas_Load(object sender, EventArgs e)
        {

        }

        private void cmbxBajasEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxBajasEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id_Empleado = 0;
            id_Empleado = Convert.ToInt32(cmbxBajasEmpleado.SelectedValue);
            dataGridView1.DataSource = ObjShowTables.ObtnerDatosPorIdEmpleado(id_Empleado);
        }

        private void btnBajasVentas_Click(object sender, EventArgs e)
        {
            
            int id_Ventas = 0;
            //string name = "";
            //int cellphone = 0;
            //string domicilio = "";
            //string valorCelda = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            id_Ventas = Convert.ToInt32(cmbxBajasVentas.SelectedValue);

            if ((cmbxBajasVentas.SelectedIndex + 1) == id_Ventas)
            {
                //name = dataGridView1.Rows[0].Cells[1].Value.ToString();
                //cellphone = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString());
                //domicilio = dataGridView1.Rows[0].Cells[3].Value.ToString();
                objBajas.BajasUpdateVentas(id_Ventas);
            }
            
        }
    }
}
