namespace Proyecto_Cassandra
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnConsultarMedicina = new System.Windows.Forms.Button();
            this.BrnConsultarVentas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultEmpleados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(765, 441);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(70, 35);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir ";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnConsultarMedicina
            // 
            this.BtnConsultarMedicina.Location = new System.Drawing.Point(745, 143);
            this.BtnConsultarMedicina.Name = "BtnConsultarMedicina";
            this.BtnConsultarMedicina.Size = new System.Drawing.Size(111, 59);
            this.BtnConsultarMedicina.TabIndex = 8;
            this.BtnConsultarMedicina.Text = "Consultar Medicamentos ";
            this.BtnConsultarMedicina.UseVisualStyleBackColor = true;
            this.BtnConsultarMedicina.Click += new System.EventHandler(this.BtnConsultarMedicina_Click);
            // 
            // BrnConsultarVentas
            // 
            this.BrnConsultarVentas.Location = new System.Drawing.Point(745, 241);
            this.BrnConsultarVentas.Name = "BrnConsultarVentas";
            this.BrnConsultarVentas.Size = new System.Drawing.Size(111, 59);
            this.BrnConsultarVentas.TabIndex = 10;
            this.BrnConsultarVentas.Text = "Consultar Ventas";
            this.BrnConsultarVentas.UseVisualStyleBackColor = true;
            this.BrnConsultarVentas.Click += new System.EventHandler(this.BrnConsultarVentas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 353);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnConsultEmpleados
            // 
            this.btnConsultEmpleados.Location = new System.Drawing.Point(745, 335);
            this.btnConsultEmpleados.Name = "btnConsultEmpleados";
            this.btnConsultEmpleados.Size = new System.Drawing.Size(111, 59);
            this.btnConsultEmpleados.TabIndex = 13;
            this.btnConsultEmpleados.Text = "Consultar Empleados";
            this.btnConsultEmpleados.UseVisualStyleBackColor = true;
            this.btnConsultEmpleados.Click += new System.EventHandler(this.btnConsultEmpleados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Proyecto_Cassandra.Properties.Resources._1613689538456;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(915, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 543);
            this.Controls.Add(this.btnConsultEmpleados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BrnConsultarVentas);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnConsultarMedicina);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnConsultarMedicina;
        private System.Windows.Forms.Button BrnConsultarVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultEmpleados;
    }
}