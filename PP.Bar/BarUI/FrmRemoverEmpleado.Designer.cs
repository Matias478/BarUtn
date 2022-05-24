namespace BarUI
{
    partial class FrmRemoverEmpleado
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
            this.LtbListaEmpleados = new System.Windows.Forms.ListBox();
            this.btnCerrarRemoverEmpleado = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LtbListaEmpleados
            // 
            this.LtbListaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LtbListaEmpleados.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LtbListaEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LtbListaEmpleados.FormattingEnabled = true;
            this.LtbListaEmpleados.ItemHeight = 15;
            this.LtbListaEmpleados.Location = new System.Drawing.Point(296, 25);
            this.LtbListaEmpleados.Name = "LtbListaEmpleados";
            this.LtbListaEmpleados.Size = new System.Drawing.Size(354, 424);
            this.LtbListaEmpleados.TabIndex = 0;
            // 
            // btnCerrarRemoverEmpleado
            // 
            this.btnCerrarRemoverEmpleado.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrarRemoverEmpleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarRemoverEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarRemoverEmpleado.Location = new System.Drawing.Point(36, 25);
            this.btnCerrarRemoverEmpleado.Name = "btnCerrarRemoverEmpleado";
            this.btnCerrarRemoverEmpleado.Size = new System.Drawing.Size(48, 40);
            this.btnCerrarRemoverEmpleado.TabIndex = 1;
            this.btnCerrarRemoverEmpleado.Text = "X";
            this.btnCerrarRemoverEmpleado.UseVisualStyleBackColor = false;
            this.btnCerrarRemoverEmpleado.Click += new System.EventHandler(this.btnCerrarRemoverEmpleado_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemover.Location = new System.Drawing.Point(64, 295);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(147, 78);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // FrmRemoverEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(662, 470);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCerrarRemoverEmpleado);
            this.Controls.Add(this.LtbListaEmpleados);
            this.Name = "FrmRemoverEmpleado";
            this.Text = "FrmRemoverEmpleado";
            this.Load += new System.EventHandler(this.FrmRemoverEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LtbListaEmpleados;
        private System.Windows.Forms.Button btnCerrarRemoverEmpleado;
        private System.Windows.Forms.Button btnRemover;
    }
}