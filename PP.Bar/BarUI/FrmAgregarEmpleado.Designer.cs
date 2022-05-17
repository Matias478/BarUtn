namespace BarUI
{
    partial class FrmAgregarEmpleado
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.cxbEsAdmin = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrarAgregarEmpleado = new System.Windows.Forms.Button();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbSueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNombre.Location = new System.Drawing.Point(121, 96);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PlaceholderText = "Nombre";
            this.txbNombre.Size = new System.Drawing.Size(350, 25);
            this.txbNombre.TabIndex = 0;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbPassWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassWord.Location = new System.Drawing.Point(121, 200);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PlaceholderText = "Ingrese su contraseña";
            this.txbPassWord.Size = new System.Drawing.Size(350, 25);
            this.txbPassWord.TabIndex = 1;
            // 
            // cxbEsAdmin
            // 
            this.cxbEsAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cxbEsAdmin.AutoSize = true;
            this.cxbEsAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cxbEsAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cxbEsAdmin.Location = new System.Drawing.Point(121, 231);
            this.cxbEsAdmin.Name = "cxbEsAdmin";
            this.cxbEsAdmin.Size = new System.Drawing.Size(85, 21);
            this.cxbEsAdmin.TabIndex = 2;
            this.cxbEsAdmin.Text = "Es Admin";
            this.cxbEsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(121, 275);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(350, 69);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrarAgregarEmpleado
            // 
            this.btnCerrarAgregarEmpleado.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrarAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarAgregarEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarAgregarEmpleado.Location = new System.Drawing.Point(23, 33);
            this.btnCerrarAgregarEmpleado.Name = "btnCerrarAgregarEmpleado";
            this.btnCerrarAgregarEmpleado.Size = new System.Drawing.Size(69, 59);
            this.btnCerrarAgregarEmpleado.TabIndex = 4;
            this.btnCerrarAgregarEmpleado.Text = "X";
            this.btnCerrarAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnCerrarAgregarEmpleado.Click += new System.EventHandler(this.btnCerrarAgregarEmpleado_Click);
            // 
            // txbApellido
            // 
            this.txbApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbApellido.Location = new System.Drawing.Point(121, 127);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.PlaceholderText = "Apellido";
            this.txbApellido.Size = new System.Drawing.Size(350, 25);
            this.txbApellido.TabIndex = 5;
            // 
            // txbSueldo
            // 
            this.txbSueldo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbSueldo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSueldo.Location = new System.Drawing.Point(121, 169);
            this.txbSueldo.Name = "txbSueldo";
            this.txbSueldo.PlaceholderText = "Sueldo";
            this.txbSueldo.Size = new System.Drawing.Size(350, 25);
            this.txbSueldo.TabIndex = 6;
            // 
            // FrmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(622, 505);
            this.Controls.Add(this.txbSueldo);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.btnCerrarAgregarEmpleado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cxbEsAdmin);
            this.Controls.Add(this.txbPassWord);
            this.Controls.Add(this.txbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmAgregarEmpleado";
            this.Text = "FrmAgregarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.CheckBox cxbEsAdmin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrarAgregarEmpleado;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbSueldo;
    }
}