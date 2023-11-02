namespace ProIsa
{
    partial class FrmProducto
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxProducto = new System.Windows.Forms.GroupBox();
            this.lvlPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lvlNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.lvlCodBarra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(138, 308);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 44);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbxProducto
            // 
            this.gbxProducto.BackColor = System.Drawing.Color.Bisque;
            this.gbxProducto.Controls.Add(this.comboBox1);
            this.gbxProducto.Controls.Add(this.label1);
            this.gbxProducto.Controls.Add(this.textBox2);
            this.gbxProducto.Controls.Add(this.textBox1);
            this.gbxProducto.Controls.Add(this.label2);
            this.gbxProducto.Controls.Add(this.lvlCodBarra);
            this.gbxProducto.Controls.Add(this.lvlPrecio);
            this.gbxProducto.Controls.Add(this.txtPrecio);
            this.gbxProducto.Controls.Add(this.lvlNombre);
            this.gbxProducto.Controls.Add(this.TxtNombre);
            this.gbxProducto.Controls.Add(this.txtCancelar);
            this.gbxProducto.Controls.Add(this.btnGuardar);
            this.gbxProducto.Location = new System.Drawing.Point(63, 47);
            this.gbxProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxProducto.Name = "gbxProducto";
            this.gbxProducto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxProducto.Size = new System.Drawing.Size(592, 389);
            this.gbxProducto.TabIndex = 1;
            this.gbxProducto.TabStop = false;
            this.gbxProducto.Text = "Informacion del Producto";
            this.gbxProducto.Enter += new System.EventHandler(this.gbxProducto_Enter);
            // 
            // lvlPrecio
            // 
            this.lvlPrecio.AutoSize = true;
            this.lvlPrecio.Location = new System.Drawing.Point(40, 123);
            this.lvlPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlPrecio.Name = "lvlPrecio";
            this.lvlPrecio.Size = new System.Drawing.Size(48, 17);
            this.lvlPrecio.TabIndex = 4;
            this.lvlPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(43, 153);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(270, 25);
            this.txtPrecio.TabIndex = 5;
            // 
            // lvlNombre
            // 
            this.lvlNombre.AutoSize = true;
            this.lvlNombre.Location = new System.Drawing.Point(40, 55);
            this.lvlNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(61, 17);
            this.lvlNombre.TabIndex = 2;
            this.lvlNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(43, 84);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(270, 25);
            this.TxtNombre.TabIndex = 3;
            // 
            // txtCancelar
            // 
            this.txtCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtCancelar.Location = new System.Drawing.Point(333, 308);
            this.txtCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(144, 44);
            this.txtCancelar.TabIndex = 1;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = false;
            this.txtCancelar.Click += new System.EventHandler(this.txtCancelar_Click);
            // 
            // lvlCodBarra
            // 
            this.lvlCodBarra.AutoSize = true;
            this.lvlCodBarra.Location = new System.Drawing.Point(37, 198);
            this.lvlCodBarra.Name = "lvlCodBarra";
            this.lvlCodBarra.Size = new System.Drawing.Size(117, 17);
            this.lvlCodBarra.TabIndex = 6;
            this.lvlCodBarra.Text = "Codigo de Barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stock";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 25);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 25);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(357, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 25);
            this.comboBox1.TabIndex = 11;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(770, 513);
            this.Controls.Add(this.gbxProducto);
            this.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.gbxProducto.ResumeLayout(false);
            this.gbxProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbxProducto;
        private System.Windows.Forms.Label lvlPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lvlNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button txtCancelar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lvlCodBarra;
    }
}