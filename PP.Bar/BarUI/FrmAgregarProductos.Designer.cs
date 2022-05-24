namespace BarUI
{
    partial class FrmAgregarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProductos));
            this.btnCerrarForm = new System.Windows.Forms.Button();
            this.btnAgregarComida = new System.Windows.Forms.Button();
            this.btnAgregarBebida = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.cmbCantidadMM = new System.Windows.Forms.ComboBox();
            this.cbxTieneAlcohol = new System.Windows.Forms.CheckBox();
            this.cmbIngredientes = new System.Windows.Forms.ComboBox();
            this.panelQueAgreagar = new System.Windows.Forms.Panel();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadMM = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.panelQueAgreagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrarForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarForm.Location = new System.Drawing.Point(27, 21);
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.Size = new System.Drawing.Size(61, 53);
            this.btnCerrarForm.TabIndex = 0;
            this.btnCerrarForm.Text = "X";
            this.btnCerrarForm.UseVisualStyleBackColor = false;
            this.btnCerrarForm.Click += new System.EventHandler(this.btnCerrarForm_Click);
            // 
            // btnAgregarComida
            // 
            this.btnAgregarComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarComida.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarComida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarComida.Location = new System.Drawing.Point(19, 56);
            this.btnAgregarComida.Name = "btnAgregarComida";
            this.btnAgregarComida.Size = new System.Drawing.Size(142, 65);
            this.btnAgregarComida.TabIndex = 1;
            this.btnAgregarComida.Text = "Agregar comida";
            this.btnAgregarComida.UseVisualStyleBackColor = true;
            this.btnAgregarComida.Click += new System.EventHandler(this.btnAgregarComida_Click);
            // 
            // btnAgregarBebida
            // 
            this.btnAgregarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarBebida.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarBebida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarBebida.Location = new System.Drawing.Point(213, 56);
            this.btnAgregarBebida.Name = "btnAgregarBebida";
            this.btnAgregarBebida.Size = new System.Drawing.Size(135, 65);
            this.btnAgregarBebida.TabIndex = 2;
            this.btnAgregarBebida.Text = "Agregar bebida";
            this.btnAgregarBebida.UseVisualStyleBackColor = true;
            this.btnAgregarBebida.Click += new System.EventHandler(this.btnAgregarBebida_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNombre.Location = new System.Drawing.Point(250, 29);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(110, 25);
            this.txbNombre.TabIndex = 3;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCantidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCantidad.Location = new System.Drawing.Point(247, 77);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(110, 25);
            this.txbCantidad.TabIndex = 4;
            // 
            // cmbCantidadMM
            // 
            this.cmbCantidadMM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCantidadMM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCantidadMM.FormattingEnabled = true;
            this.cmbCantidadMM.Location = new System.Drawing.Point(247, 152);
            this.cmbCantidadMM.Name = "cmbCantidadMM";
            this.cmbCantidadMM.Size = new System.Drawing.Size(110, 25);
            this.cmbCantidadMM.TabIndex = 5;
            // 
            // cbxTieneAlcohol
            // 
            this.cbxTieneAlcohol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxTieneAlcohol.AutoSize = true;
            this.cbxTieneAlcohol.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxTieneAlcohol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxTieneAlcohol.Location = new System.Drawing.Point(247, 108);
            this.cbxTieneAlcohol.Name = "cbxTieneAlcohol";
            this.cbxTieneAlcohol.Size = new System.Drawing.Size(124, 21);
            this.cbxTieneAlcohol.TabIndex = 6;
            this.cbxTieneAlcohol.Text = "Contiene alcohol";
            this.cbxTieneAlcohol.UseVisualStyleBackColor = true;
            // 
            // cmbIngredientes
            // 
            this.cmbIngredientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbIngredientes.FormattingEnabled = true;
            this.cmbIngredientes.Location = new System.Drawing.Point(247, 199);
            this.cmbIngredientes.Name = "cmbIngredientes";
            this.cmbIngredientes.Size = new System.Drawing.Size(110, 23);
            this.cmbIngredientes.TabIndex = 7;
            // 
            // panelQueAgreagar
            // 
            this.panelQueAgreagar.Controls.Add(this.btnAgregarBebida);
            this.panelQueAgreagar.Controls.Add(this.btnAgregarComida);
            this.panelQueAgreagar.Location = new System.Drawing.Point(126, 77);
            this.panelQueAgreagar.Name = "panelQueAgreagar";
            this.panelQueAgreagar.Size = new System.Drawing.Size(361, 158);
            this.panelQueAgreagar.TabIndex = 8;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarProductos.Location = new System.Drawing.Point(247, 228);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(113, 49);
            this.btnAgregarProductos.TabIndex = 9;
            this.btnAgregarProductos.Text = "Agregar Producto";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreProducto.Location = new System.Drawing.Point(247, 9);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(113, 17);
            this.lblNombreProducto.TabIndex = 10;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(247, 57);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(60, 17);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCantidadMM
            // 
            this.lblCantidadMM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidadMM.AutoSize = true;
            this.lblCantidadMM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadMM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidadMM.Location = new System.Drawing.Point(247, 132);
            this.lblCantidadMM.Name = "lblCantidadMM";
            this.lblCantidadMM.Size = new System.Drawing.Size(90, 17);
            this.lblCantidadMM.TabIndex = 12;
            this.lblCantidadMM.Text = "Cantidad MM";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIngredientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngredientes.Location = new System.Drawing.Point(247, 180);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(80, 17);
            this.lblIngredientes.TabIndex = 13;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // FrmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(681, 554);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblCantidadMM);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.panelQueAgreagar);
            this.Controls.Add(this.cmbIngredientes);
            this.Controls.Add(this.cbxTieneAlcohol);
            this.Controls.Add(this.cmbCantidadMM);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnCerrarForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(697, 593);
            this.Name = "FrmAgregarProductos";
            this.Text = "FrmAgregarProductos";
            this.Load += new System.EventHandler(this.FrmAgregarProductos_Load);
            this.panelQueAgreagar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarForm;
        private System.Windows.Forms.Button btnAgregarComida;
        private System.Windows.Forms.Button btnAgregarBebida;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.ComboBox cmbCantidadMM;
        private System.Windows.Forms.CheckBox cbxTieneAlcohol;
        private System.Windows.Forms.ComboBox cmbIngredientes;
        private System.Windows.Forms.Panel panelQueAgreagar;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadMM;
        private System.Windows.Forms.Label lblIngredientes;
    }
}