namespace ProIsa
{
    partial class FrmConsultaProducto
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
            this.gbxConsultar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lvlNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxConsultar
            // 
            this.gbxConsultar.BackColor = System.Drawing.Color.MistyRose;
            this.gbxConsultar.Controls.Add(this.label1);
            this.gbxConsultar.Controls.Add(this.btnEliminar);
            this.gbxConsultar.Controls.Add(this.btnModificar);
            this.gbxConsultar.Controls.Add(this.btnNuevo);
            this.gbxConsultar.Controls.Add(this.dgvGrilla);
            this.gbxConsultar.Controls.Add(this.btnBuscar);
            this.gbxConsultar.Controls.Add(this.txtBarras);
            this.gbxConsultar.Controls.Add(this.txtNombre);
            this.gbxConsultar.Controls.Add(this.lvlNombre);
            this.gbxConsultar.Location = new System.Drawing.Point(50, 31);
            this.gbxConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxConsultar.Name = "gbxConsultar";
            this.gbxConsultar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxConsultar.Size = new System.Drawing.Size(853, 495);
            this.gbxConsultar.TabIndex = 0;
            this.gbxConsultar.TabStop = false;
            this.gbxConsultar.Text = "Consultar Productos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(559, 430);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.Location = new System.Drawing.Point(353, 430);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(155, 41);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNuevo.Location = new System.Drawing.Point(157, 430);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(155, 41);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(33, 113);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(794, 288);
            this.dgvGrilla.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.Location = new System.Drawing.Point(637, 37);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBarras
            // 
            this.txtBarras.Location = new System.Drawing.Point(335, 66);
            this.txtBarras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(238, 25);
            this.txtBarras.TabIndex = 2;
            this.txtBarras.TextChanged += new System.EventHandler(this.txtBarras_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // lvlNombre
            // 
            this.lvlNombre.AutoSize = true;
            this.lvlNombre.Location = new System.Drawing.Point(69, 37);
            this.lvlNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(61, 17);
            this.lvlNombre.TabIndex = 0;
            this.lvlNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código de Barra";
            // 
            // FrmConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(941, 554);
            this.Controls.Add(this.gbxConsultar);
            this.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsultaProducto";
            this.Text = "FrmConsultaProducto";
            this.Load += new System.EventHandler(this.FrmConsultaProducto_Load);
            this.gbxConsultar.ResumeLayout(false);
            this.gbxConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConsultar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lvlNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
    }
}