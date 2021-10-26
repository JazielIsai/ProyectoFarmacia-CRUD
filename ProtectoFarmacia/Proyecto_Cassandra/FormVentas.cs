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
    public partial class FormVentas : Form
    {
        Datos.clsAltas objAltas = new Datos.clsAltas();
        Datos.clsSelectMostrarTables objShowTables = new Datos.clsSelectMostrarTables();

        public FormVentas()
        {
            InitializeComponent();

            dataGridView1.DataSource = objShowTables.MostrarTablaVentas();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            cmbxMedicine.DataSource = objShowTables.MostrarTablaMedicine();
            cmbxMedicine.DisplayMember = "NameMedicine";
            cmbxMedicine.ValueMember = "id_Medicine";

            cmbxEmpleado.DataSource = objShowTables.MostrarTablaEmpleados();
            cmbxEmpleado.DisplayMember = "nombre";
            cmbxEmpleado.ValueMember = "id_Empleado";
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int id_Empleado = 0;
            int id_Medicine = 0;
            //int precioMedicamento = 0;
            //int TotalAPagar = 0;
            

            if(txtCantidad.Text!="" && txtCantidad.Text!=null && txtPagoCon.Text !=""&&txtPagoCon.Text!=null)
            {
                id_Empleado = Convert.ToInt32(cmbxEmpleado.SelectedValue); //Obtiene el Id de la tabla de la BD
                id_Medicine = Convert.ToInt32(cmbxMedicine.SelectedValue);

                //precioMedicamento = Convert.ToInt32(cmbxPrecio.SelectedValue);
                //TotalAPagar = precioMedicamento * Convert.ToInt32(txtCantidad.Text); //  precio * cantidad
                
                //txtTotalAPagar.Text = txtTotalAPagar.ToString();

                if (Convert.ToInt32(txtPagoCon.Text) >= Convert.ToInt32(txtTotalAPagar.Text))
                {
                    //txtLeSobra.Text = (Convert.ToInt32(txtPagoCon.Text) - Convert.ToInt32(txtTotalAPagar.Text)).ToString();
                    txtReciboCliente.Text = "El medicamento fue: ......   " + cmbxMedicine.Text + "  la cantidad es ..... " + txtCantidad.Text + "    Total a Pagar: " + txtTotalAPagar.Text + "";
                    objAltas.InsertarVentas(Convert.ToInt32(txtTotalAPagar.Text), txtReciboCliente.Text, id_Empleado, id_Medicine);
                    dataGridView1.DataSource = objShowTables.MostrarTablaVentas();
                }
                
            }
        }

        private void cmbxMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbxMedicine_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void cmbxMedicine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id_Medicine = 0;
            id_Medicine = Convert.ToInt32(cmbxMedicine.SelectedValue);
            cmbxPrecio.DataSource = objShowTables.MostrarTablaMedicine();// (id_Medicine); //Obtiene el precio
            cmbxPrecio.DisplayMember = "Precio";
            cmbxPrecio.ValueMember = "id_Medicine";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            int precioMedicamento = 0;
            int TotalAPagar = 0;
            int cantidad = int.Parse(txtCantidad.Text);

            precioMedicamento = Convert.ToInt32(cmbxPrecio.Text);
            TotalAPagar = precioMedicamento * cantidad; //  precio * cantidad

            txtTotalAPagar.Text = TotalAPagar.ToString();
        }

        private void txtPagoCon_KeyUp(object sender, KeyEventArgs e)
        {
            txtLeSobra.Text = (Convert.ToInt32(txtPagoCon.Text) - Convert.ToInt32(txtTotalAPagar.Text)).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu FromMenu = new Menu();
            FromMenu.Show();
            this.Close();
        }
    }
}
