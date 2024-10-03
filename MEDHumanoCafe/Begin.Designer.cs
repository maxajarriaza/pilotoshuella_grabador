namespace MEDHumanoCafe
{
    partial class Begin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Begin));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFch = new System.Windows.Forms.Label();
            this.lblME = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblDH = new System.Windows.Forms.Label();
            this.lblEmplCod = new System.Windows.Forms.Label();
            this.lblEmplApeNom = new System.Windows.Forms.Label();
            this.txtBoxPilLicencia = new System.Windows.Forms.TextBox();
            this.txtBoxPilNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dtGridViewEmpl = new System.Windows.Forms.DataGridView();
            this.btnnuevousr = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.lblFch);
            this.pnlHeader.Controls.Add(this.lblME);
            this.pnlHeader.Controls.Add(this.lblMod);
            this.pnlHeader.Controls.Add(this.lblDH);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1264, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFch
            // 
            this.lblFch.AutoSize = true;
            this.lblFch.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFch.ForeColor = System.Drawing.Color.White;
            this.lblFch.Location = new System.Drawing.Point(871, 56);
            this.lblFch.Name = "lblFch";
            this.lblFch.Size = new System.Drawing.Size(325, 20);
            this.lblFch.TabIndex = 3;
            this.lblFch.Text = "GUATEMALA, SEPTIEMBRE XX DEL X,XXX.";
            // 
            // lblME
            // 
            this.lblME.AutoSize = true;
            this.lblME.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblME.ForeColor = System.Drawing.Color.White;
            this.lblME.Location = new System.Drawing.Point(869, 11);
            this.lblME.Name = "lblME";
            this.lblME.Size = new System.Drawing.Size(381, 34);
            this.lblME.TabIndex = 2;
            this.lblME.Text = "MAQUINAS EXACTAS, S.A.";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.ForeColor = System.Drawing.Color.White;
            this.lblMod.Location = new System.Drawing.Point(5, 50);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(238, 28);
            this.lblMod.TabIndex = 1;
            this.lblMod.Text = "Listado de pilotos";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDH.ForeColor = System.Drawing.Color.White;
            this.lblDH.Location = new System.Drawing.Point(4, 11);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(245, 34);
            this.lblDH.TabIndex = 0;
            this.lblDH.Text = "HUELLA DIGITAL";
            // 
            // lblEmplCod
            // 
            this.lblEmplCod.AutoSize = true;
            this.lblEmplCod.Location = new System.Drawing.Point(67, 122);
            this.lblEmplCod.Name = "lblEmplCod";
            this.lblEmplCod.Size = new System.Drawing.Size(133, 16);
            this.lblEmplCod.TabIndex = 1;
            this.lblEmplCod.Text = "Numero de licencia:";
            // 
            // lblEmplApeNom
            // 
            this.lblEmplApeNom.AutoSize = true;
            this.lblEmplApeNom.Location = new System.Drawing.Point(66, 152);
            this.lblEmplApeNom.Name = "lblEmplApeNom";
            this.lblEmplApeNom.Size = new System.Drawing.Size(134, 16);
            this.lblEmplApeNom.TabIndex = 2;
            this.lblEmplApeNom.Text = "Nombres, apellidos:";
            // 
            // txtBoxPilLicencia
            // 
            this.txtBoxPilLicencia.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPilLicencia.Location = new System.Drawing.Point(223, 120);
            this.txtBoxPilLicencia.Name = "txtBoxPilLicencia";
            this.txtBoxPilLicencia.Size = new System.Drawing.Size(502, 24);
            this.txtBoxPilLicencia.TabIndex = 4;
            this.txtBoxPilLicencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPilLicencia_KeyPress);
            // 
            // txtBoxPilNombre
            // 
            this.txtBoxPilNombre.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPilNombre.Location = new System.Drawing.Point(223, 150);
            this.txtBoxPilNombre.Name = "txtBoxPilNombre";
            this.txtBoxPilNombre.Size = new System.Drawing.Size(502, 24);
            this.txtBoxPilNombre.TabIndex = 5;
            this.txtBoxPilNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(785, 136);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 39);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(927, 136);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(126, 37);
            this.btnRefrescar.TabIndex = 8;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.Location = new System.Drawing.Point(969, 226);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(208, 83);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Cerrar";
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dtGridViewEmpl
            // 
            this.dtGridViewEmpl.AllowUserToAddRows = false;
            this.dtGridViewEmpl.AllowUserToDeleteRows = false;
            this.dtGridViewEmpl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridViewEmpl.BackgroundColor = System.Drawing.Color.White;
            this.dtGridViewEmpl.ColumnHeadersHeight = 29;
            this.dtGridViewEmpl.Location = new System.Drawing.Point(71, 226);
            this.dtGridViewEmpl.Name = "dtGridViewEmpl";
            this.dtGridViewEmpl.RowHeadersVisible = false;
            this.dtGridViewEmpl.RowHeadersWidth = 51;
            this.dtGridViewEmpl.Size = new System.Drawing.Size(840, 444);
            this.dtGridViewEmpl.TabIndex = 10;
            this.dtGridViewEmpl.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewEmpl_CellContentDoubleClick);
            // 
            // btnnuevousr
            // 
            this.btnnuevousr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevousr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevousr.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevousr.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevousr.Image")));
            this.btnnuevousr.Location = new System.Drawing.Point(969, 315);
            this.btnnuevousr.Name = "btnnuevousr";
            this.btnnuevousr.Size = new System.Drawing.Size(208, 78);
            this.btnnuevousr.TabIndex = 11;
            this.btnnuevousr.Text = "Crear usuario";
            this.btnnuevousr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevousr.UseVisualStyleBackColor = true;
            this.btnnuevousr.Click += new System.EventHandler(this.btnnuevousr_Click);
            // 
            // Begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.btnnuevousr);
            this.Controls.Add(this.dtGridViewEmpl);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxPilNombre);
            this.Controls.Add(this.txtBoxPilLicencia);
            this.Controls.Add(this.lblEmplApeNom);
            this.Controls.Add(this.lblEmplCod);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Begin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de Huella Digital";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Begin_FormClosed);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFch;
        private System.Windows.Forms.Label lblME;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblDH;
        private System.Windows.Forms.Label lblEmplCod;
        private System.Windows.Forms.Label lblEmplApeNom;
        private System.Windows.Forms.TextBox txtBoxPilLicencia;
        private System.Windows.Forms.TextBox txtBoxPilNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dtGridViewEmpl;
        private System.Windows.Forms.Button btnnuevousr;
    }
}

