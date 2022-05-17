namespace BarUI
{
    partial class FrmListaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaEmpleados));
            this.rtbListaEmpleados = new System.Windows.Forms.RichTextBox();
            this.btnCerrarFrmListaEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbListaEmpleados
            // 
            this.rtbListaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.rtbListaEmpleados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbListaEmpleados.ForeColor = System.Drawing.Color.White;
            this.rtbListaEmpleados.Location = new System.Drawing.Point(125, 10);
            this.rtbListaEmpleados.Name = "rtbListaEmpleados";
            this.rtbListaEmpleados.Size = new System.Drawing.Size(521, 578);
            this.rtbListaEmpleados.TabIndex = 0;
            this.rtbListaEmpleados.Text = "";
            // 
            // btnCerrarFrmListaEmpleados
            // 
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
            // FrmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(712, 600);
            this.Controls.Add(this.btnCerrarFrmListaEmpleados);
            this.Controls.Add(this.rtbListaEmpleados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaEmpleados";
            this.Text = "FrmListaEmpleados";
            this.Load += new System.EventHandler(this.FrmListaEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListaEmpleados;
        private System.Windows.Forms.Button btnCerrarFrmListaEmpleados;
    }
}