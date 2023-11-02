namespace ProIsa
{
    partial class FrmCliente
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
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.lvlTelefono = new System.Windows.Forms.Label();
            this.lvlDocumento = new System.Windows.Forms.Label();
            this.lvlApellido = new System.Windows.Forms.Label();
            this.lvlNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxBarrio = new System.Windows.Forms.ComboBox();
            this.gbxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.cbxBarrio);
            this.gbxCliente.Controls.Add(this.lvlTelefono);
            this.gbxCliente.Controls.Add(this.lvlDocumento);
            this.gbxCliente.Controls.Add(this.lvlApellido);
            this.gbxCliente.Controls.Add(this.lvlNombre);
            this.gbxCliente.Controls.Add(this.txtTelefono);
            this.gbxCliente.Controls.Add(this.txtDocumento);
            this.gbxCliente.Controls.Add(this.txtApellido);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.btnGuardar);
            this.gbxCliente.Controls.Add(this.btnCancelar);
            this.gbxCliente.Location = new System.Drawing.Point(35, 24);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(353, 305);
            this.gbxCliente.TabIndex = 0;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Datos Cliente";
            this.gbxCliente.Enter += new System.EventHandler(this.gbxCliente_Enter);
            // 
            // lvlTelefono
            // 
            this.lvlTelefono.AutoSize = true;
            this.lvlTelefono.Location = new System.Drawing.Point(35, 143);
            this.lvlTelefono.Name = "lvlTelefono";
            this.lvlTelefono.Size = new System.Drawing.Size(49, 13);
            this.lvlTelefono.TabIndex = 11;
            this.lvlTelefono.Text = "Telefono";
            // 
            // lvlDocumento
            // 
            this.lvlDocumento.AutoSize = true;
            this.lvlDocumento.Location = new System.Drawing.Point(35, 110);
            this.lvlDocumento.Name = "lvlDocumento";
            this.lvlDocumento.Size = new System.Drawing.Size(62, 13);
            this.lvlDocumento.TabIndex = 10;
            this.lvlDocumento.Text = "Documento";
            // 
            // lvlApellido
            // 
            this.lvlApellido.AutoSize = true;
            this.lvlApellido.Location = new System.Drawing.Point(35, 78);
            this.lvlApellido.Name = "lvlApellido";
            this.lvlApellido.Size = new System.Drawing.Size(54, 13);
            this.lvlApellido.TabIndex = 8;
            this.lvlApellido.Text = "Apellido/s";
            // 
            // lvlNombre
            // 
            this.lvlNombre.AutoSize = true;
            this.lvlNombre.Location = new System.Drawing.Point(35, 45);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(44, 13);
            this.lvlNombre.TabIndex = 7;
            this.lvlNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(164, 143);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(164, 110);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(171, 20);
            this.txtDocumento.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(164, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(164, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(50, 231);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(205, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 41);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxBarrio
            // 
            this.cbxBarrio.FormattingEnabled = true;
            this.cbxBarrio.Location = new System.Drawing.Point(164, 181);
            this.cbxBarrio.Name = "cbxBarrio";
            this.cbxBarrio.Size = new System.Drawing.Size(171, 21);
            this.cbxBarrio.TabIndex = 12;
            this.cbxBarrio.SelectedIndexChanged += new System.EventHandler(this.cbxBarrio_SelectedIndexChanged);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 341);
            this.Controls.Add(this.gbxCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load_1);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Label lvlDocumento;
        private System.Windows.Forms.Label lvlApellido;
        private System.Windows.Forms.Label lvlNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lvlTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cbxBarrio;
    }
}