namespace Lab03
{
    partial class Persona
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dvgListado = new System.Windows.Forms.DataGridView();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_fecha_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(25, 33);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(80, 25);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(357, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 25);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(195, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // dvgListado
            // 
            this.dvgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario_id,
            this.usuario_nombre,
            this.usuario_password,
            this.usuario_fecha_registro});
            this.dvgListado.Location = new System.Drawing.Point(34, 99);
            this.dvgListado.Name = "dvgListado";
            this.dvgListado.Size = new System.Drawing.Size(398, 297);
            this.dvgListado.TabIndex = 3;
            this.dvgListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListado_CellContentClick);
            // 
            // usuario_id
            // 
            this.usuario_id.HeaderText = "ID";
            this.usuario_id.Name = "usuario_id";
            // 
            // usuario_nombre
            // 
            this.usuario_nombre.HeaderText = "Nombre";
            this.usuario_nombre.Name = "usuario_nombre";
            // 
            // usuario_password
            // 
            this.usuario_password.HeaderText = "Password";
            this.usuario_password.Name = "usuario_password";
            // 
            // usuario_fecha_registro
            // 
            this.usuario_fecha_registro.HeaderText = "FechaRegistro";
            this.usuario_fecha_registro.Name = "usuario_fecha_registro";
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 431);
            this.Controls.Add(this.dvgListado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListar);
            this.Name = "Persona";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dvgListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_fecha_registro;
    }
}