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
            this.btnCerrarCuenta = new System.Windows.Forms.Button();
            this.cxbConEstacionamiento = new System.Windows.Forms.CheckBox();
            this.btnCerrarMenu = new System.Windows.Forms.Button();
            this.cmbTipoDePago = new System.Windows.Forms.ComboBox();
            this.lblMetodoDePago = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(88, 318);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(190, 23);
            this.cmbProducto.TabIndex = 0;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarProductos.Location = new System.Drawing.Point(88, 436);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(190, 50);
            this.btnAgregarProductos.TabIndex = 2;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaldo.Location = new System.Drawing.Point(296, 223);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(60, 24);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroMesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumeroMesa.Location = new System.Drawing.Point(26, 21);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(38, 24);
            this.lblNumeroMesa.TabIndex = 4;
            this.lblNumeroMesa.Text = "N° ";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductos.Location = new System.Drawing.Point(88, 288);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(67, 17);
            this.lblProductos.TabIndex = 5;
            this.lblProductos.Text = "Producto";
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCuenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarCuenta.Location = new System.Drawing.Point(437, 436);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.Size = new System.Drawing.Size(146, 50);
            this.btnCerrarCuenta.TabIndex = 7;
            this.btnCerrarCuenta.Text = "Cerrar Cuenta";
            this.btnCerrarCuenta.UseVisualStyleBackColor = false;
            this.btnCerrarCuenta.Click += new System.EventHandler(this.btnCerrarCuenta_Click);
            // 
            // cxbConEstacionamiento
            // 
            this.cxbConEstacionamiento.AutoSize = true;
            this.cxbConEstacionamiento.BackColor = System.Drawing.Color.Transparent;
            this.cxbConEstacionamiento.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cxbConEstacionamiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cxbConEstacionamiento.Location = new System.Drawing.Point(88, 377);
            this.cxbConEstacionamiento.Name = "cxbConEstacionamiento";
            this.cxbConEstacionamiento.Size = new System.Drawing.Size(202, 21);
            this.cxbConEstacionamiento.TabIndex = 8;
            this.cxbConEstacionamiento.Text = "Ticket de Estacionamiento";
            this.cxbConEstacionamiento.UseVisualStyleBackColor = false;
            // 
            // btnCerrarMenu
            // 
            this.btnCerrarMenu.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrarMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarMenu.Location = new System.Drawing.Point(593, 31);
            this.btnCerrarMenu.Name = "btnCerrarMenu";
            this.btnCerrarMenu.Size = new System.Drawing.Size(48, 40);
            this.btnCerrarMenu.TabIndex = 9;
            this.btnCerrarMenu.Text = "X";
            this.btnCerrarMenu.UseVisualStyleBackColor = false;
            this.btnCerrarMenu.Click += new System.EventHandler(this.btnCerrarMenu_Click);
            // 
            // cmbTipoDePago
            // 
            this.cmbTipoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDePago.FormattingEnabled = true;
            this.cmbTipoDePago.Location = new System.Drawing.Point(437, 377);
            this.cmbTipoDePago.Name = "cmbTipoDePago";
            this.cmbTipoDePago.Size = new System.Drawing.Size(146, 23);
            this.cmbTipoDePago.TabIndex = 10;
            // 
            // lblMetodoDePago
            // 
            this.lblMetodoDePago.AutoSize = true;
            this.lblMetodoDePago.BackColor = System.Drawing.Color.Transparent;
            this.lblMetodoDePago.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetodoDePago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMetodoDePago.Location = new System.Drawing.Point(437, 357);
            this.lblMetodoDePago.Name = "lblMetodoDePago";
            this.lblMetodoDePago.Size = new System.Drawing.Size(115, 17);
            this.lblMetodoDePago.TabIndex = 11;
            this.lblMetodoDePago.Text = "Metodo de pago";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(437, 288);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 17);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(437, 318);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(146, 23);
            this.txbCantidad.TabIndex = 13;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.BackgroundImage = global::BarUI.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 554);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMetodoDePago);
            this.Controls.Add(this.cmbTipoDePago);
            this.Controls.Add(this.btnCerrarMenu);
            this.Controls.Add(this.cxbConEstacionamiento);
            this.Controls.Add(this.btnCerrarCuenta);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblNumeroMesa);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.cmbProducto);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnCerrarCuenta;
        private System.Windows.Forms.CheckBox cxbConEstacionamiento;
        private System.Windows.Forms.Button btnCerrarMenu;
        private System.Windows.Forms.ComboBox cmbTipoDePago;
        private System.Windows.Forms.Label lblMetodoDePago;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txbCantidad;
    }
}