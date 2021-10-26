namespace Proyecto_Cassandra
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAltas = new System.Windows.Forms.Button();
            this.BtnBajas = new System.Windows.Forms.Button();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(394, 416);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(77, 34);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir ";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAltas
            // 
            this.BtnAltas.FlatAppearance.BorderSize = 0;
            this.BtnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltas.Image = global::Proyecto_Cassandra.Properties.Resources.ALTAS;
            this.BtnAltas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAltas.Location = new System.Drawing.Point(302, 85);
            this.BtnAltas.Name = "BtnAltas";
            this.BtnAltas.Size = new System.Drawing.Size(174, 69);
            this.BtnAltas.TabIndex = 2;
            this.BtnAltas.UseVisualStyleBackColor = true;
            this.BtnAltas.Click += new System.EventHandler(this.BtnAltas_Click);
            // 
            // BtnBajas
            // 
            this.BtnBajas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBajas.FlatAppearance.BorderSize = 0;
            this.BtnBajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBajas.Image = global::Proyecto_Cassandra.Properties.Resources.BAJAS;
            this.BtnBajas.Location = new System.Drawing.Point(285, 206);
            this.BtnBajas.Name = "BtnBajas";
            this.BtnBajas.Size = new System.Drawing.Size(186, 65);
            this.BtnBajas.TabIndex = 1;
            this.BtnBajas.UseVisualStyleBackColor = true;
            this.BtnBajas.Click += new System.EventHandler(this.BtnBajas_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultas.BackgroundImage = global::Proyecto_Cassandra.Properties.Resources._16136895384671;
            this.BtnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnConsultas.FlatAppearance.BorderSize = 0;
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultas.Location = new System.Drawing.Point(218, 310);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(258, 71);
            this.BtnConsultas.TabIndex = 0;
            this.BtnConsultas.UseVisualStyleBackColor = false;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Proyecto_Cassandra.Properties.Resources._1613689538467;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblVentas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblVentas.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(354, 25);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(100, 37);
            this.lblVentas.TabIndex = 6;
            this.lblVentas.Text = "Ventas";
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 462);
            this.ControlBox = false;
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAltas);
            this.Controls.Add(this.BtnBajas);
            this.Controls.Add(this.BtnConsultas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Button BtnBajas;
        private System.Windows.Forms.Button BtnAltas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVentas;
    }
}

