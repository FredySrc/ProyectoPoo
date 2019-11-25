namespace VotoElectronico
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenuCategoria = new System.Windows.Forms.Panel();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tbPresidente = new System.Windows.Forms.TabPage();
            this.chkPresidente = new System.Windows.Forms.CheckedListBox();
            this.tbSecretario = new System.Windows.Forms.TabPage();
            this.chkSecretario = new System.Windows.Forms.CheckedListBox();
            this.tbTesorero = new System.Windows.Forms.TabPage();
            this.chkTesorero = new System.Windows.Forms.CheckedListBox();
            this.tbVocales = new System.Windows.Forms.TabPage();
            this.chkVocal = new System.Windows.Forms.CheckedListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarcarVoto = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.txtValidar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            this.pnlMenuCategoria.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tbPresidente.SuspendLayout();
            this.tbSecretario.SuspendLayout();
            this.tbTesorero.SuspendLayout();
            this.tbVocales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.pnlMenuCategoria);
            this.pnlPrincipal.Controls.Add(this.btnVotar);
            this.pnlPrincipal.Controls.Add(this.txtValidar);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.btnAdministrador);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlPrincipal.Size = new System.Drawing.Size(800, 436);
            this.pnlPrincipal.TabIndex = 0;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint);
            // 
            // pnlMenuCategoria
            // 
            this.pnlMenuCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuCategoria.Controls.Add(this.tabPrincipal);
            this.pnlMenuCategoria.Controls.Add(this.label2);
            this.pnlMenuCategoria.Controls.Add(this.btnMarcarVoto);
            this.pnlMenuCategoria.Location = new System.Drawing.Point(0, -2);
            this.pnlMenuCategoria.Name = "pnlMenuCategoria";
            this.pnlMenuCategoria.Size = new System.Drawing.Size(799, 436);
            this.pnlMenuCategoria.TabIndex = 3;
            this.pnlMenuCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenuCategoria_Paint);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Controls.Add(this.tbPresidente);
            this.tabPrincipal.Controls.Add(this.tbSecretario);
            this.tabPrincipal.Controls.Add(this.tbTesorero);
            this.tabPrincipal.Controls.Add(this.tbVocales);
            this.tabPrincipal.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tabPrincipal.HotTrack = true;
            this.tabPrincipal.ImageList = this.imageList1;
            this.tabPrincipal.ItemSize = new System.Drawing.Size(10, 140);
            this.tabPrincipal.Location = new System.Drawing.Point(0, -4);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tabPrincipal.Multiline = true;
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Drawing.Point(0, 3);
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(797, 345);
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.TabStop = false;
            this.tabPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabPrincipal_SelectedIndexChanged);
            // 
            // tbPresidente
            // 
            this.tbPresidente.AccessibleName = "";
            this.tbPresidente.BackColor = System.Drawing.Color.Transparent;
            this.tbPresidente.Controls.Add(this.chkPresidente);
            this.tbPresidente.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tbPresidente.ImageIndex = 0;
            this.tbPresidente.Location = new System.Drawing.Point(4, 4);
            this.tbPresidente.Name = "tbPresidente";
            this.tbPresidente.Padding = new System.Windows.Forms.Padding(3);
            this.tbPresidente.Size = new System.Drawing.Size(649, 337);
            this.tbPresidente.TabIndex = 0;
            this.tbPresidente.Click += new System.EventHandler(this.tbPresidente_Click);
            // 
            // chkPresidente
            // 
            this.chkPresidente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPresidente.FormattingEnabled = true;
            this.chkPresidente.Location = new System.Drawing.Point(-12, 1);
            this.chkPresidente.Name = "chkPresidente";
            this.chkPresidente.Size = new System.Drawing.Size(661, 349);
            this.chkPresidente.TabIndex = 0;
            this.chkPresidente.SelectedIndexChanged += new System.EventHandler(this.chkPresidente_SelectedIndexChanged);
            // 
            // tbSecretario
            // 
            this.tbSecretario.Controls.Add(this.chkSecretario);
            this.tbSecretario.ImageIndex = 1;
            this.tbSecretario.Location = new System.Drawing.Point(4, 4);
            this.tbSecretario.Name = "tbSecretario";
            this.tbSecretario.Padding = new System.Windows.Forms.Padding(3);
            this.tbSecretario.Size = new System.Drawing.Size(650, 343);
            this.tbSecretario.TabIndex = 1;
            this.tbSecretario.UseVisualStyleBackColor = true;
            // 
            // chkSecretario
            // 
            this.chkSecretario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSecretario.FormattingEnabled = true;
            this.chkSecretario.Location = new System.Drawing.Point(-10, -2);
            this.chkSecretario.Name = "chkSecretario";
            this.chkSecretario.Size = new System.Drawing.Size(661, 364);
            this.chkSecretario.TabIndex = 0;
            this.chkSecretario.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tbTesorero
            // 
            this.tbTesorero.Controls.Add(this.chkTesorero);
            this.tbTesorero.ImageIndex = 2;
            this.tbTesorero.Location = new System.Drawing.Point(4, 4);
            this.tbTesorero.Name = "tbTesorero";
            this.tbTesorero.Size = new System.Drawing.Size(650, 343);
            this.tbTesorero.TabIndex = 2;
            this.tbTesorero.UseVisualStyleBackColor = true;
            // 
            // chkTesorero
            // 
            this.chkTesorero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTesorero.FormattingEnabled = true;
            this.chkTesorero.Location = new System.Drawing.Point(-2, -3);
            this.chkTesorero.Name = "chkTesorero";
            this.chkTesorero.Size = new System.Drawing.Size(654, 364);
            this.chkTesorero.TabIndex = 0;
            this.chkTesorero.SelectedIndexChanged += new System.EventHandler(this.chkTesorero_SelectedIndexChanged);
            // 
            // tbVocales
            // 
            this.tbVocales.Controls.Add(this.chkVocal);
            this.tbVocales.ImageIndex = 3;
            this.tbVocales.Location = new System.Drawing.Point(4, 4);
            this.tbVocales.Name = "tbVocales";
            this.tbVocales.Size = new System.Drawing.Size(650, 343);
            this.tbVocales.TabIndex = 3;
            this.tbVocales.UseVisualStyleBackColor = true;
            // 
            // chkVocal
            // 
            this.chkVocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVocal.FormattingEnabled = true;
            this.chkVocal.Location = new System.Drawing.Point(-7, -2);
            this.chkVocal.Name = "chkVocal";
            this.chkVocal.Size = new System.Drawing.Size(658, 364);
            this.chkVocal.TabIndex = 0;
            this.chkVocal.SelectedIndexChanged += new System.EventHandler(this.chkVocal_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Tag = "";
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Presidente.jpg");
            this.imageList1.Images.SetKeyName(1, "secretario.jpg");
            this.imageList1.Images.SetKeyName(2, "Tesorero.jpg");
            this.imageList1.Images.SetKeyName(3, "Vocal.jpg");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Haga click Aqui Cuando halla terminado de Marcar a sus Candidatos";
            // 
            // btnMarcarVoto
            // 
            this.btnMarcarVoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcarVoto.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarVoto.Location = new System.Drawing.Point(655, 351);
            this.btnMarcarVoto.Name = "btnMarcarVoto";
            this.btnMarcarVoto.Size = new System.Drawing.Size(90, 41);
            this.btnMarcarVoto.TabIndex = 2;
            this.btnMarcarVoto.Text = "Votar";
            this.btnMarcarVoto.UseVisualStyleBackColor = true;
            this.btnMarcarVoto.Click += new System.EventHandler(this.btnMarcarVoto_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVotar.Font = new System.Drawing.Font("Javanese Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.Location = new System.Drawing.Point(268, 261);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(193, 80);
            this.btnVotar.TabIndex = 2;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // txtValidar
            // 
            this.txtValidar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValidar.Location = new System.Drawing.Point(268, 197);
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(193, 20);
            this.txtValidar.TabIndex = 1;
            this.txtValidar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(-1, -1);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(75, 23);
            this.btnAdministrador.TabIndex = 6;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.pnlPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votar";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlMenuCategoria.ResumeLayout(false);
            this.pnlMenuCategoria.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.tbPresidente.ResumeLayout(false);
            this.tbSecretario.ResumeLayout(false);
            this.tbTesorero.ResumeLayout(false);
            this.tbVocales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.TextBox txtValidar;
        private System.Windows.Forms.Panel pnlMenuCategoria;
        private System.Windows.Forms.TabPage tbPresidente;
        private System.Windows.Forms.TabPage tbSecretario;
        private System.Windows.Forms.TabPage tbTesorero;
        private System.Windows.Forms.TabPage tbVocales;
        private System.Windows.Forms.Button btnMarcarVoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkPresidente;
        private System.Windows.Forms.CheckedListBox chkSecretario;
        private System.Windows.Forms.CheckedListBox chkTesorero;
        private System.Windows.Forms.CheckedListBox chkVocal;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAdministrador;
    }
}

