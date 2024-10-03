
namespace MEDHumanoCafe
{
    partial class nuevousuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevousuario));
            this.pnlnuevo = new System.Windows.Forms.Panel();
            this.picboxuser = new System.Windows.Forms.PictureBox();
            this.grpboxinfo = new System.Windows.Forms.GroupBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblnivel = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxNombres = new System.Windows.Forms.TextBox();
            this.txtBoxApellidos = new System.Windows.Forms.TextBox();
            this.cmbboxnivel = new System.Windows.Forms.ComboBox();
            this.grpboxpassword = new System.Windows.Forms.GroupBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblconfirmapas = new System.Windows.Forms.Label();
            this.txtboxpassword = new System.Windows.Forms.TextBox();
            this.txtboxconfirmapas = new System.Windows.Forms.TextBox();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pnlnuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).BeginInit();
            this.grpboxinfo.SuspendLayout();
            this.grpboxpassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlnuevo
            // 
            this.pnlnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlnuevo.BackColor = System.Drawing.Color.Ivory;
            this.pnlnuevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlnuevo.Controls.Add(this.btncancelar);
            this.pnlnuevo.Controls.Add(this.btngrabar);
            this.pnlnuevo.Controls.Add(this.grpboxpassword);
            this.pnlnuevo.Controls.Add(this.grpboxinfo);
            this.pnlnuevo.Controls.Add(this.picboxuser);
            this.pnlnuevo.Location = new System.Drawing.Point(99, 62);
            this.pnlnuevo.Name = "pnlnuevo";
            this.pnlnuevo.Size = new System.Drawing.Size(1044, 529);
            this.pnlnuevo.TabIndex = 0;
            // 
            // picboxuser
            // 
            this.picboxuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxuser.Image = ((System.Drawing.Image)(resources.GetObject("picboxuser.Image")));
            this.picboxuser.Location = new System.Drawing.Point(45, 52);
            this.picboxuser.Name = "picboxuser";
            this.picboxuser.Size = new System.Drawing.Size(212, 351);
            this.picboxuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxuser.TabIndex = 0;
            this.picboxuser.TabStop = false;
            // 
            // grpboxinfo
            // 
            this.grpboxinfo.Controls.Add(this.cmbboxnivel);
            this.grpboxinfo.Controls.Add(this.txtBoxApellidos);
            this.grpboxinfo.Controls.Add(this.txtBoxNombres);
            this.grpboxinfo.Controls.Add(this.txtBoxUsuario);
            this.grpboxinfo.Controls.Add(this.lblnivel);
            this.grpboxinfo.Controls.Add(this.lblApellidos);
            this.grpboxinfo.Controls.Add(this.lblNombres);
            this.grpboxinfo.Controls.Add(this.lblusuario);
            this.grpboxinfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpboxinfo.Location = new System.Drawing.Point(283, 52);
            this.grpboxinfo.Name = "grpboxinfo";
            this.grpboxinfo.Size = new System.Drawing.Size(671, 206);
            this.grpboxinfo.TabIndex = 1;
            this.grpboxinfo.TabStop = false;
            this.grpboxinfo.Text = "Información de usuario";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Navy;
            this.lblusuario.Location = new System.Drawing.Point(61, 38);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(184, 20);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "Usuario de sistema:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.Navy;
            this.lblNombres.Location = new System.Drawing.Point(51, 76);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(194, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres de usuario:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.Navy;
            this.lblApellidos.Location = new System.Drawing.Point(47, 115);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(198, 20);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos de usuario:";
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnivel.ForeColor = System.Drawing.Color.Navy;
            this.lblnivel.Location = new System.Drawing.Point(85, 154);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(160, 20);
            this.lblnivel.TabIndex = 3;
            this.lblnivel.Text = "Nivel de usuario:";
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuario.Location = new System.Drawing.Point(283, 35);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(321, 32);
            this.txtBoxUsuario.TabIndex = 4;
            this.txtBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxUsuario_KeyPress);
            // 
            // txtBoxNombres
            // 
            this.txtBoxNombres.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombres.Location = new System.Drawing.Point(283, 73);
            this.txtBoxNombres.Name = "txtBoxNombres";
            this.txtBoxNombres.Size = new System.Drawing.Size(321, 32);
            this.txtBoxNombres.TabIndex = 5;
            this.txtBoxNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNombres_KeyPress);
            // 
            // txtBoxApellidos
            // 
            this.txtBoxApellidos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellidos.Location = new System.Drawing.Point(283, 112);
            this.txtBoxApellidos.Name = "txtBoxApellidos";
            this.txtBoxApellidos.Size = new System.Drawing.Size(321, 32);
            this.txtBoxApellidos.TabIndex = 6;
            this.txtBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxApellidos_KeyPress);
            // 
            // cmbboxnivel
            // 
            this.cmbboxnivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbboxnivel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxnivel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbboxnivel.FormattingEnabled = true;
            this.cmbboxnivel.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.cmbboxnivel.Location = new System.Drawing.Point(283, 151);
            this.cmbboxnivel.Name = "cmbboxnivel";
            this.cmbboxnivel.Size = new System.Drawing.Size(321, 28);
            this.cmbboxnivel.TabIndex = 7;
            // 
            // grpboxpassword
            // 
            this.grpboxpassword.Controls.Add(this.txtboxconfirmapas);
            this.grpboxpassword.Controls.Add(this.txtboxpassword);
            this.grpboxpassword.Controls.Add(this.lblconfirmapas);
            this.grpboxpassword.Controls.Add(this.lblpassword);
            this.grpboxpassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpboxpassword.Location = new System.Drawing.Point(283, 274);
            this.grpboxpassword.Name = "grpboxpassword";
            this.grpboxpassword.Size = new System.Drawing.Size(671, 129);
            this.grpboxpassword.TabIndex = 2;
            this.grpboxpassword.TabStop = false;
            this.grpboxpassword.Text = "Contraseña";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Navy;
            this.lblpassword.Location = new System.Drawing.Point(130, 37);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(115, 20);
            this.lblpassword.TabIndex = 0;
            this.lblpassword.Text = "Contraseña:";
            // 
            // lblconfirmapas
            // 
            this.lblconfirmapas.AutoSize = true;
            this.lblconfirmapas.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmapas.ForeColor = System.Drawing.Color.Navy;
            this.lblconfirmapas.Location = new System.Drawing.Point(38, 75);
            this.lblconfirmapas.Name = "lblconfirmapas";
            this.lblconfirmapas.Size = new System.Drawing.Size(207, 20);
            this.lblconfirmapas.TabIndex = 1;
            this.lblconfirmapas.Text = "Confirmar contraseña:";
            // 
            // txtboxpassword
            // 
            this.txtboxpassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxpassword.Location = new System.Drawing.Point(283, 34);
            this.txtboxpassword.Name = "txtboxpassword";
            this.txtboxpassword.PasswordChar = '*';
            this.txtboxpassword.Size = new System.Drawing.Size(209, 32);
            this.txtboxpassword.TabIndex = 2;
            this.txtboxpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxpassword_KeyPress);
            // 
            // txtboxconfirmapas
            // 
            this.txtboxconfirmapas.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxconfirmapas.Location = new System.Drawing.Point(283, 72);
            this.txtboxconfirmapas.Name = "txtboxconfirmapas";
            this.txtboxconfirmapas.PasswordChar = '*';
            this.txtboxconfirmapas.Size = new System.Drawing.Size(209, 32);
            this.txtboxconfirmapas.TabIndex = 3;
            // 
            // btngrabar
            // 
            this.btngrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btngrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngrabar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrabar.ForeColor = System.Drawing.Color.White;
            this.btngrabar.Image = ((System.Drawing.Image)(resources.GetObject("btngrabar.Image")));
            this.btngrabar.Location = new System.Drawing.Point(402, 427);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(194, 55);
            this.btngrabar.TabIndex = 3;
            this.btngrabar.Text = "Grabar usuario";
            this.btngrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrabar.UseVisualStyleBackColor = false;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(614, 427);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(194, 55);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // nuevousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 678);
            this.Controls.Add(this.pnlnuevo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "nuevousuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario de sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nuevousuario_FormClosed);
            this.pnlnuevo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).EndInit();
            this.grpboxinfo.ResumeLayout(false);
            this.grpboxinfo.PerformLayout();
            this.grpboxpassword.ResumeLayout(false);
            this.grpboxpassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlnuevo;
        private System.Windows.Forms.GroupBox grpboxpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.GroupBox grpboxinfo;
        private System.Windows.Forms.ComboBox cmbboxnivel;
        private System.Windows.Forms.TextBox txtBoxApellidos;
        private System.Windows.Forms.TextBox txtBoxNombres;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.PictureBox picboxuser;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.TextBox txtboxconfirmapas;
        private System.Windows.Forms.TextBox txtboxpassword;
        private System.Windows.Forms.Label lblconfirmapas;
        private System.Windows.Forms.Button btncancelar;
    }
}