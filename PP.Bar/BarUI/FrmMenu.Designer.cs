namespace BarUI
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dupCantidad = new System.Windows.Forms.DomainUpDown();
            this.btnCerrarCuenta = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(34, 117);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(160, 23);
            this.cmbProducto.TabIndex = 0;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProductos.Location = new System.Drawing.Point(34, 268);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(163, 79);
            this.btnAgregarProductos.TabIndex = 2;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaldo.Location = new System.Drawing.Point(191, 49);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(51, 21);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroMesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumeroMesa.Location = new System.Drawing.Point(21, 9);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(31, 20);
            this.lblNumeroMesa.TabIndex = 4;
            this.lblNumeroMesa.Text = "N° ";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductos.Location = new System.Drawing.Point(34, 90);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(61, 17);
            this.lblProductos.TabIndex = 5;
            this.lblProductos.Text = "Producto";
            // 
            // dupCantidad
            // 
            this.dupCantidad.Items.Add("0");
            this.dupCantidad.Items.Add("1");
            this.dupCantidad.Items.Add("2");
            this.dupCantidad.Items.Add("3");
            this.dupCantidad.Items.Add("4");
            this.dupCantidad.Items.Add("5");
            this.dupCantidad.Items.Add("6");
            this.dupCantidad.Items.Add("7");
            this.dupCantidad.Items.Add("8");
            this.dupCantidad.Items.Add("9");
            this.dupCantidad.Items.Add("10");
            this.dupCantidad.Items.Add("11");
            this.dupCantidad.Items.Add("12");
            this.dupCantidad.Items.Add("13");
            this.dupCantidad.Items.Add("14");
            this.dupCantidad.Items.Add("15");
            this.dupCantidad.Items.Add("16");
            this.dupCantidad.Items.Add("17");
            this.dupCantidad.Items.Add("18");
            this.dupCantidad.Items.Add("19");
            this.dupCantidad.Items.Add("20");
            this.dupCantidad.Items.Add("21");
            this.dupCantidad.Items.Add("22");
            this.dupCantidad.Items.Add("23");
            this.dupCantidad.Items.Add("24");
            this.dupCantidad.Items.Add("25");
            this.dupCantidad.Items.Add("26");
            this.dupCantidad.Items.Add("27");
            this.dupCantidad.Items.Add("28");
            this.dupCantidad.Items.Add("29");
            this.dupCantidad.Items.Add("30");
            this.dupCantidad.Location = new System.Drawing.Point(290, 118);
            this.dupCantidad.Name = "dupCantidad";
            this.dupCantidad.Size = new System.Drawing.Size(120, 23);
            this.dupCantidad.TabIndex = 6;
            this.dupCantidad.Text = "0";
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarCuenta.Location = new System.Drawing.Point(290, 268);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.Size = new System.Drawing.Size(146, 79);
            this.btnCerrarCuenta.TabIndex = 7;
            this.btnCerrarCuenta.Text = "Cerrar Cuenta";
            this.btnCerrarCuenta.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(34, 185);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(185, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Ticket de Estacionamiento";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(402, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(475, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCerrarCuenta);
            this.Controls.Add(this.dupCantidad);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblNumeroMesa);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.cmbProducto);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DomainUpDown dupCantidad;
        private System.Windows.Forms.Button btnCerrarCuenta;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}