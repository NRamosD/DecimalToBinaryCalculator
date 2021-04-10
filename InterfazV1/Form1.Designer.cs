namespace InterfazV1
{
    partial class FormPrincipal
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
            this.barraTitu = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panelVentanas = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnSM = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.barraTitu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panelVentanas.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitu
            // 
            this.barraTitu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.barraTitu.Controls.Add(this.Titulo);
            this.barraTitu.Controls.Add(this.minimizar);
            this.barraTitu.Controls.Add(this.cerrar);
            this.barraTitu.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitu.Location = new System.Drawing.Point(0, 0);
            this.barraTitu.Name = "barraTitu";
            this.barraTitu.Size = new System.Drawing.Size(700, 30);
            this.barraTitu.TabIndex = 0;
            this.barraTitu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitu_MouseDown);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(3, 3);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(61, 24);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "CalQ";
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.minimizar.BackgroundImage = global::InterfazV1.Properties.Resources.Mesa_de_trabajo_3_8;
            this.minimizar.Image = global::InterfazV1.Properties.Resources.Mesa_de_trabajo_3_8;
            this.minimizar.Location = new System.Drawing.Point(640, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 0;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Red;
            this.cerrar.BackgroundImage = global::InterfazV1.Properties.Resources.Mesa_de_trabajo_2_8;
            this.cerrar.Image = global::InterfazV1.Properties.Resources.Mesa_de_trabajo_2_8;
            this.cerrar.Location = new System.Drawing.Point(670, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(30, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // panelVentanas
            // 
            this.panelVentanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(149)))), ((int)(((byte)(11)))));
            this.panelVentanas.Controls.Add(this.btnAyuda);
            this.panelVentanas.Controls.Add(this.btnSM);
            this.panelVentanas.Controls.Add(this.btnOperar);
            this.panelVentanas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentanas.Location = new System.Drawing.Point(0, 30);
            this.panelVentanas.Name = "panelVentanas";
            this.panelVentanas.Size = new System.Drawing.Size(700, 33);
            this.panelVentanas.TabIndex = 1;
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(185, 8);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 25);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnSM
            // 
            this.btnSM.FlatAppearance.BorderSize = 0;
            this.btnSM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.btnSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSM.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSM.ForeColor = System.Drawing.Color.White;
            this.btnSM.Location = new System.Drawing.Point(89, 8);
            this.btnSM.Name = "btnSM";
            this.btnSM.Size = new System.Drawing.Size(95, 25);
            this.btnSM.TabIndex = 3;
            this.btnSM.Text = "SM, C1 y C2";
            this.btnSM.UseVisualStyleBackColor = true;
            this.btnSM.Click += new System.EventHandler(this.btnSM_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.FlatAppearance.BorderSize = 0;
            this.btnOperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperar.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.Color.White;
            this.btnOperar.Location = new System.Drawing.Point(0, 8);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(90, 25);
            this.btnOperar.TabIndex = 2;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 63);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(700, 437);
            this.panelContenido.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelVentanas);
            this.Controls.Add(this.barraTitu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalQ";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.barraTitu.ResumeLayout(false);
            this.barraTitu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panelVentanas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitu;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Panel panelVentanas;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnSM;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label Titulo;
    }
}

