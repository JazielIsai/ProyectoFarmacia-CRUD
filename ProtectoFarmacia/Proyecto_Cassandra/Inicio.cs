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
    public partial class Inicio : Form
    {        
        public int contador;
        
        Menu FromMenu = new Menu();
        
        public Inicio()
        {
            InitializeComponent();
        }


        private void Inicio_Load(object sender, EventArgs e)
        {    
            contador = 0; 
            TimerPBR.Enabled = true;
        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
           
        }

        private void TimerPBR_Tick(object sender, EventArgs e)
        {
           contador = contador + 2;
           PBRInicio.Value++;

            if (PBRInicio.Value == 50 )
            {
                TimerPBR.Stop();
                PBRInicio.Value = 0;
                FromMenu.Show();
                this.Hide();
            }

        }

        private void PBRInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
