namespace Proyecto_Cassandra
{
    partial class Bajas
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
            this.BtnDeBaja = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxBajasEmpleado = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbxBajasVentas = new System.Windows.Forms.ComboBox();
            this.btnBajasVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDeBaja
            // 
            this.BtnDeBaja.BackColor = System.Drawing.Color.White;
            this.BtnDeBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeBaja.Location = new System.Drawing.Point(324, 159);
            this.BtnDeBaja.Name = "BtnDeBaja";
            this.BtnDeBaja.Size = new System.Drawing.Size(228, 31);
            this.BtnDeBaja.TabIndex = 6;
            this.BtnDeBaja.Text = "Dar de Baja Empleado";
            this.BtnDeBaja.UseVisualStyleBackColor = false;
            this.BtnDeBaja.Click += new System.EventHandler(this.BtnDeBaja_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 293);
            this.dataGridView1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Proyecto_Cassandra.Properties.Resources._1613689538462;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1072, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbxBajasEmpleado
            // 
            this.cmbxBajasEmpleado.FormattingEnabled = true;
            this.cmbxBajasEmpleado.Location = new System.Drawing.Point(133, 166);
            this.cmbxBajasEmpleado.Name = "cmbxBajasEmpleado";
            this.cmbxBajasEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbxBajasEmpleado.TabIndex = 11;
            this.cmbxBajasEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbxBajasEmpleado_SelectedIndexChanged);
            this.cmbxBajasEmpleado.SelectionChangeCommitted += new System.EventHandler(this.cmbxBajasEmpleado_SelectionChangeCommitted);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(613, 202);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(480, 293);
            this.dataGridView2.TabIndex = 12;
            // 
            // cmbxBajasVentas
            // 
            this.cmbxBajasVentas.FormattingEnabled = true;
            this.cmbxBajasVentas.Location = new System.Drawing.Point(686, 166);
            this.cmbxBajasVentas.Name = "cmbxBajasVentas";
            this.cmbxBajasVentas.Size = new System.Drawing.Size(121, 21);
            this.cmbxBajasVentas.TabIndex = 14;
            // 
            // btnBajasVentas
            // 
            this.btnBajasVentas.BackColor = System.Drawing.Color.White;
            this.btnBajasVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBajasVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajasVentas.Location = new System.Drawing.Point(856, 159);
            this.btnBajasVentas.Name = "btnBajasVentas";
            this.btnBajasVentas.Size = new System.Drawing.Size(204, 31);
            this.btnBajasVentas.TabIndex = 13;
            this.btnBajasVentas.Text = "Dar de Baja Venta";
            this.btnBajasVentas.UseVisualStyleBackColor = false;
            this.btnBajasVentas.Click += new System.EventHandler(this.btnBajasVentas_Click);
            // 
            // Bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 563);
            this.ControlBox = false;
            this.Controls.Add(this.cmbxBajasVentas);
            this.Controls.Add(this.btnBajasVentas);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmbxBajasEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDeBaja);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Bajas";
            this.Text = "Bajas";
            this.Load += new System.EventHandler(this.Bajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDeBaja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxBajasEmpleado;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbxBajasVentas;
        private System.Windows.Forms.Button btnBajasVentas;
    }
}