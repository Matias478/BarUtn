namespace BarUI
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lbLogin = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.btnLogueate = new System.Windows.Forms.Button();
            this.cbEsAdmin = new System.Windows.Forms.CheckBox();
            this.btnCompletarEmpleado = new System.Windows.Forms.Button();
            this.btnCompletarAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(213, 44);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(65, 29);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNombre.Location = new System.Drawing.Point(147, 121);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PlaceholderText = "Nombre de usuario";
            this.txbNombre.Size = new System.Drawing.Size(204, 25);
            this.txbNombre.TabIndex = 1;
            // 
            // txbPass
            // 
            this.txbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPass.Location = new System.Drawing.Point(147, 181);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.PlaceholderText = "Contraseña";
            this.txbPass.Size = new System.Drawing.Size(204, 25);
            this.txbPass.TabIndex = 2;
            // 
            // btnLogueate
            // 
            this.btnLogueate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogueate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogueate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogueate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogueate.Location = new System.Drawing.Point(97, 296);
            this.btnLogueate.Name = "btnLogueate";
            this.btnLogueate.Size = new System.Drawing.Size(146, 55);
            this.btnLogueate.TabIndex = 3;
            this.btnLogueate.Text = "Logueate";
            this.btnLogueate.UseVisualStyleBackColor = true;
            this.btnLogueate.Click += new System.EventHandler(this.btnLogueate_Click);
            // 
            // cbEsAdmin
            // 
            this.cbEsAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEsAdmin.AutoSize = true;
            this.cbEsAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbEsAdmin.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbEsAdmin.Location = new System.Drawing.Point(147, 236);
            this.cbEsAdmin.Name = "cbEsAdmin";
            this.cbEsAdmin.Size = new System.Drawing.Size(68, 21);
            this.cbEsAdmin.TabIndex = 6;
            this.cbEsAdmin.Text = "Admin";
            this.cbEsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCompletarEmpleado
            // 
            this.btnCompletarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompletarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarEmpleado.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompletarEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompletarEmpleado.Location = new System.Drawing.Point(345, 332);
            this.btnCompletarEmpleado.Name = "btnCompletarEmpleado";
            this.btnCompletarEmpleado.Size = new System.Drawing.Size(154, 36);
            this.btnCompletarEmpleado.TabIndex = 7;
            this.btnCompletarEmpleado.Text = "Completar Empleado";
            this.btnCompletarEmpleado.UseVisualStyleBackColor = true;
            this.btnCompletarEmpleado.Click += new System.EventHandler(this.btnCompletarEmpleado_Click);
            // 
            // btnCompletarAdmin
            // 
            this.btnCompletarAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompletarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarAdmin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompletarAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompletarAdmin.Location = new System.Drawing.Point(345, 278);
            this.btnCompletarAdmin.Name = "btnCompletarAdmin";
            this.btnCompletarAdmin.Size = new System.Drawing.Size(154, 35);
            this.btnCompletarAdmin.TabIndex = 8;
            this.btnCompletarAdmin.Text = "Completar Administrador";
            this.btnCompletarAdmin.UseVisualStyleBackColor = true;
            this.btnCompletarAdmin.Click += new System.EventHandler(this.btnCompletarAdmin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(519, 419);
            this.Controls.Add(this.btnCompletarAdmin);
            this.Controls.Add(this.btnCompletarEmpleado);
            this.Controls.Add(this.cbEsAdmin);
            this.Controls.Add(this.btnLogueate);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lbLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Button btnLogueate;
        private System.Windows.Forms.CheckBox cbEsAdmin;
        private System.Windows.Forms.Button btnCompletarEmpleado;
        private System.Windows.Forms.Button btnCompletarAdmin;
    }
}
