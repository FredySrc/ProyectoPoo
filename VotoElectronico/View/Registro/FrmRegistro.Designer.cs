namespace VotoElectronico.View
{
    partial class FrmRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtContasena = new System.Windows.Forms.Label();
            this.txtUsuarioAdministrador = new System.Windows.Forms.TextBox();
            this.txtUsuarioContrasena = new System.Windows.Forms.TextBox();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(365, 149);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(70, 36);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // txtContasena
            // 
            this.txtContasena.AutoSize = true;
            this.txtContasena.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContasena.Location = new System.Drawing.Point(344, 253);
            this.txtContasena.Name = "txtContasena";
            this.txtContasena.Size = new System.Drawing.Size(113, 43);
            this.txtContasena.TabIndex = 2;
            this.txtContasena.Text = "Contraseña";
            this.txtContasena.Click += new System.EventHandler(this.txtContasena_Click);
            // 
            // txtUsuarioAdministrador
            // 
            this.txtUsuarioAdministrador.Location = new System.Drawing.Point(348, 209);
            this.txtUsuarioAdministrador.Name = "txtUsuarioAdministrador";
            this.txtUsuarioAdministrador.Size = new System.Drawing.Size(105, 20);
            this.txtUsuarioAdministrador.TabIndex = 3;
            this.txtUsuarioAdministrador.TextChanged += new System.EventHandler(this.txtUsuarioAdministrador_TextChanged);
            // 
            // txtUsuarioContrasena
            // 
            this.txtUsuarioContrasena.Location = new System.Drawing.Point(348, 320);
            this.txtUsuarioContrasena.Name = "txtUsuarioContrasena";
            this.txtUsuarioContrasena.Size = new System.Drawing.Size(105, 20);
            this.txtUsuarioContrasena.TabIndex = 4;
            this.txtUsuarioContrasena.TextChanged += new System.EventHandler(this.txtUsuarioContrasena_TextChanged);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(363, 364);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(75, 23);
            this.btnAdministrador.TabIndex = 5;
            this.btnAdministrador.Text = "Autenticar ";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.txtUsuarioContrasena);
            this.Controls.Add(this.txtUsuarioAdministrador);
            this.Controls.Add(this.txtContasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistro";
            this.Text = "Registra Estudiante";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtContasena;
        private System.Windows.Forms.TextBox txtUsuarioAdministrador;
        private System.Windows.Forms.TextBox txtUsuarioContrasena;
        private System.Windows.Forms.Button btnAdministrador;
    }
}