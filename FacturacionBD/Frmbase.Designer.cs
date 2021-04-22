namespace FacturacionBD
{
    partial class Frmbase
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.grpboxbotones = new System.Windows.Forms.GroupBox();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.grpboxbotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Black;
            this.lbltitulo.Font = new System.Drawing.Font("Swis721 BlkOul BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Red;
            this.lbltitulo.Location = new System.Drawing.Point(319, 24);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(109, 29);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "TITULO";
            // 
            // grpboxbotones
            // 
            this.grpboxbotones.BackColor = System.Drawing.Color.Orange;
            this.grpboxbotones.Controls.Add(this.btnnuevo);
            this.grpboxbotones.Controls.Add(this.btneliminar);
            this.grpboxbotones.Controls.Add(this.btnguardar);
            this.grpboxbotones.Controls.Add(this.btnconsultar);
            this.grpboxbotones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpboxbotones.Location = new System.Drawing.Point(542, 68);
            this.grpboxbotones.Name = "grpboxbotones";
            this.grpboxbotones.Size = new System.Drawing.Size(230, 282);
            this.grpboxbotones.TabIndex = 1;
            this.grpboxbotones.TabStop = false;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(84, 39);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 0;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(84, 84);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(84, 126);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(84, 173);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(499, 372);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Frmbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.grpboxbotones);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Frmbase";
            this.Text = "Frmbase";
            this.grpboxbotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lbltitulo;
        protected System.Windows.Forms.GroupBox grpboxbotones;
        protected System.Windows.Forms.Button btnnuevo;
        protected System.Windows.Forms.Button btneliminar;
        protected System.Windows.Forms.Button btnguardar;
        protected System.Windows.Forms.Button btnconsultar;
        protected System.Windows.Forms.Button btnsalir;
    }
}