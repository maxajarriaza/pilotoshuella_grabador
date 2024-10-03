
namespace MEDHumanoCafe
{
    partial class CambioPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioPassword));
            this.pnlcambio = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtboxconfirma = new System.Windows.Forms.TextBox();
            this.txtboxnueva = new System.Windows.Forms.TextBox();
            this.lblconfirma = new System.Windows.Forms.Label();
            this.lblnueva = new System.Windows.Forms.Label();
            this.lblape = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblidentificador = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlcambio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlcambio
            // 
            this.pnlcambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcambio.BackColor = System.Drawing.Color.Beige;
            this.pnlcambio.Controls.Add(this.btnCancelar);
            this.pnlcambio.Controls.Add(this.btnEnter);
            this.pnlcambio.Controls.Add(this.txtboxconfirma);
            this.pnlcambio.Controls.Add(this.txtboxnueva);
            this.pnlcambio.Controls.Add(this.lblconfirma);
            this.pnlcambio.Controls.Add(this.lblnueva);
            this.pnlcambio.Controls.Add(this.lblape);
            this.pnlcambio.Controls.Add(this.lblnom);
            this.pnlcambio.Controls.Add(this.lblusuario);
            this.pnlcambio.Controls.Add(this.lblapellidos);
            this.pnlcambio.Controls.Add(this.lblnombres);
            this.pnlcambio.Controls.Add(this.lblidentificador);
            this.pnlcambio.Controls.Add(this.lblcambio);
            this.pnlcambio.Controls.Add(this.lbltitulo);
            this.pnlcambio.Controls.Add(this.pictureBox1);
            this.pnlcambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlcambio.Location = new System.Drawing.Point(105, 60);
            this.pnlcambio.Name = "pnlcambio";
            this.pnlcambio.Size = new System.Drawing.Size(950, 590);
            this.pnlcambio.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(597, 474);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 56);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.Location = new System.Drawing.Point(420, 474);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(171, 56);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Cambiar contraseña";
            this.btnEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtboxconfirma
            // 
            this.txtboxconfirma.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxconfirma.Location = new System.Drawing.Point(419, 411);
            this.txtboxconfirma.Name = "txtboxconfirma";
            this.txtboxconfirma.PasswordChar = '*';
            this.txtboxconfirma.Size = new System.Drawing.Size(259, 32);
            this.txtboxconfirma.TabIndex = 12;
            this.txtboxconfirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxconfirma_KeyPress);
            // 
            // txtboxnueva
            // 
            this.txtboxnueva.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxnueva.Location = new System.Drawing.Point(419, 341);
            this.txtboxnueva.Name = "txtboxnueva";
            this.txtboxnueva.PasswordChar = '*';
            this.txtboxnueva.Size = new System.Drawing.Size(259, 32);
            this.txtboxnueva.TabIndex = 11;
            this.txtboxnueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxnueva_KeyPress);
            // 
            // lblconfirma
            // 
            this.lblconfirma.AutoSize = true;
            this.lblconfirma.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirma.Location = new System.Drawing.Point(411, 388);
            this.lblconfirma.Name = "lblconfirma";
            this.lblconfirma.Size = new System.Drawing.Size(201, 20);
            this.lblconfirma.TabIndex = 10;
            this.lblconfirma.Text = "Confirmar contraseña";
            // 
            // lblnueva
            // 
            this.lblnueva.AutoSize = true;
            this.lblnueva.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnueva.Location = new System.Drawing.Point(411, 318);
            this.lblnueva.Name = "lblnueva";
            this.lblnueva.Size = new System.Drawing.Size(166, 20);
            this.lblnueva.TabIndex = 9;
            this.lblnueva.Text = "Nueva contraseña";
            // 
            // lblape
            // 
            this.lblape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblape.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblape.ForeColor = System.Drawing.Color.Navy;
            this.lblape.Location = new System.Drawing.Point(537, 180);
            this.lblape.Name = "lblape";
            this.lblape.Size = new System.Drawing.Size(300, 30);
            this.lblape.TabIndex = 8;
            this.lblape.Text = "Apellidos";
            // 
            // lblnom
            // 
            this.lblnom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnom.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.Navy;
            this.lblnom.Location = new System.Drawing.Point(537, 149);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(300, 30);
            this.lblnom.TabIndex = 7;
            this.lblnom.Text = "Nombres";
            // 
            // lblusuario
            // 
            this.lblusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblusuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Navy;
            this.lblusuario.Location = new System.Drawing.Point(537, 119);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(300, 30);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "Usuario";
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidos.Location = new System.Drawing.Point(411, 181);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(98, 20);
            this.lblapellidos.TabIndex = 5;
            this.lblapellidos.Text = "Apellidos:";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.Location = new System.Drawing.Point(415, 150);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(94, 20);
            this.lblnombres.TabIndex = 4;
            this.lblnombres.Text = "Nombres:";
            // 
            // lblidentificador
            // 
            this.lblidentificador.AutoSize = true;
            this.lblidentificador.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentificador.Location = new System.Drawing.Point(380, 120);
            this.lblidentificador.Name = "lblidentificador";
            this.lblidentificador.Size = new System.Drawing.Size(129, 20);
            this.lblidentificador.TabIndex = 3;
            this.lblidentificador.Text = "Identificador:";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.Location = new System.Drawing.Point(379, 258);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(272, 28);
            this.lblcambio.TabIndex = 2;
            this.lblcambio.Text = "Cambio de contraseña";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(379, 70);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(233, 28);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Usuario de sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CambioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 757);
            this.Controls.Add(this.pnlcambio);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "CambioPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de contraseña";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CambioPassword_FormClosed);
            this.pnlcambio.ResumeLayout(false);
            this.pnlcambio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlcambio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtboxconfirma;
        private System.Windows.Forms.TextBox txtboxnueva;
        private System.Windows.Forms.Label lblconfirma;
        private System.Windows.Forms.Label lblnueva;
        private System.Windows.Forms.Label lblape;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblidentificador;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}