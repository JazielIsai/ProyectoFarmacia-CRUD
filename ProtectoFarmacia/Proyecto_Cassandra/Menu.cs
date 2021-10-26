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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();


        }

        private void BtnAltas_Click(object sender, EventArgs e)
        {   
            Altas FromAltas = new Altas();        
            this.Hide();
            FromAltas.Show();
        }

        private void BtnBajas_Click(object sender, EventArgs e)
        {
            Bajas FromBajas = new Bajas();
            this.Hide();
            FromBajas.Show();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            Consultas FromConsultas = new Consultas();
            this.Hide();
            FromConsultas.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Inicio FromInicio = new Inicio();

            DialogResult DiaRes= MessageBox.Show("Deceas Salir del Programa","Salir", 
                MessageBoxButtons.YesNo);
            
            if(DiaRes == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            FormVentas FormVent = new FormVentas();
            Hide();
            FormVent.Show();
        }
    }
}
