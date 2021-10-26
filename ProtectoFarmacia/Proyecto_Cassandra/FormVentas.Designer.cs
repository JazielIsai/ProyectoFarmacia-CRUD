
namespace Proyecto_Cassandra
{
    partial class FormVentas
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbxMedicine = new System.Windows.Forms.ComboBox();
            this.txtReciboCliente = new System.Windows.Forms.TextBox();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPagoCon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbxPrecio = new System.Windows.Forms.ComboBox();
            this.txtLeSobra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Location = new System.Drawing.Point(418, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 57);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnVender
            // 
            this.btnVender.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVender.Location = new System.Drawing.Point(0, 0);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(355, 57);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Realizar Venta";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 573);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(583, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 573);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total a pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recibo del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "id_Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "id_Medicine";
            // 
            // cmbxEmpleado
            // 
            this.cmbxEmpleado.FormattingEnabled = true;
            this.cmbxEmpleado.Location = new System.Drawing.Point(208, 148);
            this.cmbxEmpleado.Name = "cmbxEmpleado";
            this.cmbxEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbxEmpleado.TabIndex = 9;
            // 
            // cmbxMedicine
            // 
            this.cmbxMedicine.FormattingEnabled = true;
            this.cmbxMedicine.Location = new System.Drawing.Point(208, 208);
            this.cmbxMedicine.Name = "cmbxMedicine";
            this.cmbxMedicine.Size = new System.Drawing.Size(121, 21);
            this.cmbxMedicine.TabIndex = 10;
            this.cmbxMedicine.SelectionChangeCommitted += new System.EventHandler(this.cmbxMedicine_SelectionChangeCommitted);
            this.cmbxMedicine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxMedicine_KeyPress);
            this.cmbxMedicine.MouseEnter += new System.EventHandler(this.cmbxMedicine_MouseEnter);
            // 
            // txtReciboCliente
            // 
            this.txtReciboCliente.Enabled = false;
            this.txtReciboCliente.Location = new System.Drawing.Point(208, 432);
            this.txtReciboCliente.Name = "txtReciboCliente";
            this.txtReciboCliente.Size = new System.Drawing.Size(121, 20);
            this.txtReciboCliente.TabIndex = 11;
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Enabled = false;
            this.txtTotalAPagar.Location = new System.Drawing.Point(208, 322);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(121, 20);
            this.txtTotalAPagar.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnVender);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 57);
            this.panel2.TabIndex = 13;
            // 
            // txtPagoCon
            // 
            this.txtPagoCon.Location = new System.Drawing.Point(208, 375);
            this.txtPagoCon.Name = "txtPagoCon";
            this.txtPagoCon.Size = new System.Drawing.Size(121, 20);
            this.txtPagoCon.TabIndex = 15;
            this.txtPagoCon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPagoCon_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Efectivo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(210, 267);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 17;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cantidad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Cassandra.Properties.Resources.WhatsApp_Image_2021_02_19_at_1_32_03_AM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 573);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cmbxPrecio
            // 
            this.cmbxPrecio.Enabled = false;
            this.cmbxPrecio.FormattingEnabled = true;
            this.cmbxPrecio.Location = new System.Drawing.Point(428, 208);
            this.cmbxPrecio.Name = "cmbxPrecio";
            this.cmbxPrecio.Size = new System.Drawing.Size(131, 21);
            this.cmbxPrecio.TabIndex = 19;
            // 
            // txtLeSobra
            // 
            this.txtLeSobra.Enabled = false;
            this.txtLeSobra.Location = new System.Drawing.Point(438, 375);
            this.txtLeSobra.Name = "txtLeSobra";
            this.txtLeSobra.Size = new System.Drawing.Size(121, 20);
            this.txtLeSobra.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cambio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cuesta:";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLeSobra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPagoCon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.txtReciboCliente);
            this.Controls.Add(this.cmbxMedicine);
            this.Controls.Add(this.cmbxEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxEmpleado;
        private System.Windows.Forms.ComboBox cmbxMedicine;
        private System.Windows.Forms.TextBox txtReciboCliente;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPagoCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbxPrecio;
        private System.Windows.Forms.TextBox txtLeSobra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}