namespace BarUI
{
    partial class FrmLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLista));
            this.rtbLista = new System.Windows.Forms.RichTextBox();
            this.btnCerrarFrmListaEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLista
            // 
            this.rtbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.rtbLista.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbLista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbLista.Location = new System.Drawing.Point(125, 10);
            this.rtbLista.Name = "rtbLista";
            this.rtbLista.ReadOnly = true;
            this.rtbLista.Size = new System.Drawing.Size(530, 528);
            this.rtbLista.TabIndex = 0;
            this.rtbLista.Text = "";
            // 
            // btnCerrarFrmListaEmpleados
            // 
            this.btnCerrarFrmListaEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarFrmListaEmpleados.AutoSize = true;
            this.btnCerrarFrmListaEmpleados.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrarFrmListaEmpleados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarFrmListaEmpleados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarFrmListaEmpleados.Location = new System.Drawing.Point(14, 18);
            this.btnCerrarFrmListaEmpleados.Name = "btnCerrarFrmListaEmpleados";
            this.btnCerrarFrmListaEmpleados.Size = new System.Drawing.Size(39, 33);
            this.btnCerrarFrmListaEmpleados.TabIndex = 1;
            this.btnCerrarFrmListaEmpleados.Text = "X";
            this.btnCerrarFrmListaEmpleados.UseVisualStyleBackColor = false;
            this.btnCerrarFrmListaEmpleados.Click += new System.EventHandler(this.btnCerrarFrmListaEmpleados_Click);
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(681, 554);
            this.Controls.Add(this.btnCerrarFrmListaEmpleados);
            this.Controls.Add(this.rtbLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLista";
            this.Text = "FrmLista";
            this.Load += new System.EventHandler(this.FrmListaEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLista;
        private System.Windows.Forms.Button btnCerrarFrmListaEmpleados;
    }
}