namespace ProIsa
{
    partial class FrmBarrio
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
            this.gbxBarrio = new System.Windows.Forms.GroupBox();
            this.lvlNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxBarrio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBarrio
            // 
            this.gbxBarrio.Controls.Add(this.btnGuardar);
            this.gbxBarrio.Controls.Add(this.txtNombre);
            this.gbxBarrio.Controls.Add(this.lvlNombre);
            this.gbxBarrio.Location = new System.Drawing.Point(45, 39);
            this.gbxBarrio.Name = "gbxBarrio";
            this.gbxBarrio.Size = new System.Drawing.Size(328, 236);
            this.gbxBarrio.TabIndex = 0;
            this.gbxBarrio.TabStop = false;
            this.gbxBarrio.Text = "Datos de Barrios";
            // 
            // lvlNombre
            // 
            this.lvlNombre.AutoSize = true;
            this.lvlNombre.Location = new System.Drawing.Point(54, 63);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(44, 13);
            this.lvlNombre.TabIndex = 0;
            this.lvlNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(100, 157);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 33);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 322);
            this.Controls.Add(this.gbxBarrio);
            this.Name = "FrmBarrio";
            this.Text = "FrmBarrio";
            this.Load += new System.EventHandler(this.FrmBarrio_Load);
            this.gbxBarrio.ResumeLayout(false);
            this.gbxBarrio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBarrio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lvlNombre;
    }
}