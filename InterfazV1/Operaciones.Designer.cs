namespace InterfazV1
{
    partial class Operaciones
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
            this.gBoxEntradas = new System.Windows.Forms.GroupBox();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbOctal = new System.Windows.Forms.RadioButton();
            this.rbBin = new System.Windows.Forms.RadioButton();
            this.rbDeci = new System.Windows.Forms.RadioButton();
            this.panelResul = new System.Windows.Forms.Panel();
            this.fondoResul = new System.Windows.Forms.Panel();
            this.memoria = new System.Windows.Forms.Label();
            this.numerosIngresados = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.trece = new System.Windows.Forms.Button();
            this.catorce = new System.Windows.Forms.Button();
            this.quince = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.diez = new System.Windows.Forms.Button();
            this.once = new System.Windows.Forms.Button();
            this.doce = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.por = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.resulDecimal = new System.Windows.Forms.Label();
            this.gBoxResultados = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resulBinario = new System.Windows.Forms.Label();
            this.resulOctal = new System.Windows.Forms.Label();
            this.resulHexa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPasarSm = new System.Windows.Forms.Button();
            this.rBinarioSM = new System.Windows.Forms.Label();
            this.rBinarioC1 = new System.Windows.Forms.Label();
            this.rBinarioC2 = new System.Windows.Forms.Label();
            this.unSM = new System.Windows.Forms.Label();
            this.unC1 = new System.Windows.Forms.Label();
            this.unC2 = new System.Windows.Forms.Label();
            this.gBoxEntradas.SuspendLayout();
            this.panelResul.SuspendLayout();
            this.fondoResul.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxEntradas
            // 
            this.gBoxEntradas.BackColor = System.Drawing.Color.Transparent;
            this.gBoxEntradas.Controls.Add(this.rbHex);
            this.gBoxEntradas.Controls.Add(this.rbOctal);
            this.gBoxEntradas.Controls.Add(this.rbBin);
            this.gBoxEntradas.Controls.Add(this.rbDeci);
            this.gBoxEntradas.Location = new System.Drawing.Point(352, 23);
            this.gBoxEntradas.Name = "gBoxEntradas";
            this.gBoxEntradas.Size = new System.Drawing.Size(116, 121);
            this.gBoxEntradas.TabIndex = 0;
            this.gBoxEntradas.TabStop = false;
            // 
            // rbHex
            // 
            this.rbHex.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbHex.AutoSize = true;
            this.rbHex.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.rbHex.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.rbHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbHex.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHex.ForeColor = System.Drawing.Color.White;
            this.rbHex.Location = new System.Drawing.Point(5, 92);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(107, 25);
            this.rbHex.TabIndex = 3;
            this.rbHex.Text = "Héxadecimal";
            this.rbHex.UseVisualStyleBackColor = true;
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // rbOctal
            // 
            this.rbOctal.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOctal.AutoSize = true;
            this.rbOctal.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.rbOctal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.rbOctal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOctal.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOctal.ForeColor = System.Drawing.Color.White;
            this.rbOctal.Location = new System.Drawing.Point(5, 10);
            this.rbOctal.Name = "rbOctal";
            this.rbOctal.Size = new System.Drawing.Size(60, 25);
            this.rbOctal.TabIndex = 2;
            this.rbOctal.Text = "Octal";
            this.rbOctal.UseVisualStyleBackColor = true;
            this.rbOctal.CheckedChanged += new System.EventHandler(this.rbOctal_CheckedChanged);
            // 
            // rbBin
            // 
            this.rbBin.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBin.AutoSize = true;
            this.rbBin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.rbBin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(149)))), ((int)(((byte)(11)))));
            this.rbBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBin.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBin.ForeColor = System.Drawing.Color.White;
            this.rbBin.Location = new System.Drawing.Point(5, 65);
            this.rbBin.Name = "rbBin";
            this.rbBin.Size = new System.Drawing.Size(72, 25);
            this.rbBin.TabIndex = 1;
            this.rbBin.Text = "Binario";
            this.rbBin.UseVisualStyleBackColor = true;
            this.rbBin.CheckedChanged += new System.EventHandler(this.rbBin_CheckedChanged);
            // 
            // rbDeci
            // 
            this.rbDeci.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDeci.AutoSize = true;
            this.rbDeci.BackColor = System.Drawing.Color.Transparent;
            this.rbDeci.Checked = true;
            this.rbDeci.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.rbDeci.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.rbDeci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDeci.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeci.ForeColor = System.Drawing.Color.White;
            this.rbDeci.Location = new System.Drawing.Point(5, 38);
            this.rbDeci.Name = "rbDeci";
            this.rbDeci.Size = new System.Drawing.Size(73, 25);
            this.rbDeci.TabIndex = 0;
            this.rbDeci.TabStop = true;
            this.rbDeci.Text = "Decimal";
            this.rbDeci.UseVisualStyleBackColor = false;
            this.rbDeci.CheckedChanged += new System.EventHandler(this.rbDeci_CheckedChanged);
            // 
            // panelResul
            // 
            this.panelResul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.panelResul.Controls.Add(this.fondoResul);
            this.panelResul.Location = new System.Drawing.Point(26, 23);
            this.panelResul.Name = "panelResul";
            this.panelResul.Size = new System.Drawing.Size(302, 55);
            this.panelResul.TabIndex = 1;
            // 
            // fondoResul
            // 
            this.fondoResul.BackColor = System.Drawing.Color.Black;
            this.fondoResul.Controls.Add(this.memoria);
            this.fondoResul.Controls.Add(this.numerosIngresados);
            this.fondoResul.Location = new System.Drawing.Point(4, 6);
            this.fondoResul.Name = "fondoResul";
            this.fondoResul.Size = new System.Drawing.Size(295, 45);
            this.fondoResul.TabIndex = 0;
            // 
            // memoria
            // 
            this.memoria.AutoSize = true;
            this.memoria.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoria.ForeColor = System.Drawing.Color.White;
            this.memoria.Location = new System.Drawing.Point(3, 2);
            this.memoria.Name = "memoria";
            this.memoria.Size = new System.Drawing.Size(0, 21);
            this.memoria.TabIndex = 4;
            this.memoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.memoria.TextChanged += new System.EventHandler(this.memoria_TextChanged);
            // 
            // numerosIngresados
            // 
            this.numerosIngresados.AutoSize = true;
            this.numerosIngresados.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerosIngresados.ForeColor = System.Drawing.Color.White;
            this.numerosIngresados.Location = new System.Drawing.Point(3, 23);
            this.numerosIngresados.Name = "numerosIngresados";
            this.numerosIngresados.Size = new System.Drawing.Size(18, 21);
            this.numerosIngresados.TabIndex = 3;
            this.numerosIngresados.Text = "0";
            this.numerosIngresados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.numerosIngresados.TextChanged += new System.EventHandler(this.numerosIngresados_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.trece);
            this.flowLayoutPanel1.Controls.Add(this.catorce);
            this.flowLayoutPanel1.Controls.Add(this.quince);
            this.flowLayoutPanel1.Controls.Add(this.borrar);
            this.flowLayoutPanel1.Controls.Add(this.diez);
            this.flowLayoutPanel1.Controls.Add(this.once);
            this.flowLayoutPanel1.Controls.Add(this.doce);
            this.flowLayoutPanel1.Controls.Add(this.division);
            this.flowLayoutPanel1.Controls.Add(this.siete);
            this.flowLayoutPanel1.Controls.Add(this.ocho);
            this.flowLayoutPanel1.Controls.Add(this.nueve);
            this.flowLayoutPanel1.Controls.Add(this.por);
            this.flowLayoutPanel1.Controls.Add(this.cuatro);
            this.flowLayoutPanel1.Controls.Add(this.cinco);
            this.flowLayoutPanel1.Controls.Add(this.seis);
            this.flowLayoutPanel1.Controls.Add(this.menos);
            this.flowLayoutPanel1.Controls.Add(this.uno);
            this.flowLayoutPanel1.Controls.Add(this.dos);
            this.flowLayoutPanel1.Controls.Add(this.tres);
            this.flowLayoutPanel1.Controls.Add(this.mas);
            this.flowLayoutPanel1.Controls.Add(this.cero);
            this.flowLayoutPanel1.Controls.Add(this.coma);
            this.flowLayoutPanel1.Controls.Add(this.limpiar);
            this.flowLayoutPanel1.Controls.Add(this.igual);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(304, 339);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // trece
            // 
            this.trece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.trece.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.trece.FlatAppearance.BorderSize = 3;
            this.trece.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.trece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trece.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trece.Location = new System.Drawing.Point(3, 3);
            this.trece.Name = "trece";
            this.trece.Size = new System.Drawing.Size(70, 50);
            this.trece.TabIndex = 0;
            this.trece.Text = "D";
            this.trece.UseVisualStyleBackColor = false;
            this.trece.Click += new System.EventHandler(this.trece_Click);
            // 
            // catorce
            // 
            this.catorce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.catorce.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.catorce.FlatAppearance.BorderSize = 3;
            this.catorce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.catorce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catorce.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catorce.Location = new System.Drawing.Point(79, 3);
            this.catorce.Name = "catorce";
            this.catorce.Size = new System.Drawing.Size(70, 50);
            this.catorce.TabIndex = 1;
            this.catorce.Text = "E";
            this.catorce.UseVisualStyleBackColor = false;
            this.catorce.Click += new System.EventHandler(this.catorce_Click);
            // 
            // quince
            // 
            this.quince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.quince.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quince.FlatAppearance.BorderSize = 3;
            this.quince.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.quince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quince.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quince.Location = new System.Drawing.Point(155, 3);
            this.quince.Name = "quince";
            this.quince.Size = new System.Drawing.Size(70, 50);
            this.quince.TabIndex = 2;
            this.quince.Text = "F";
            this.quince.UseVisualStyleBackColor = false;
            this.quince.Click += new System.EventHandler(this.quince_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.borrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.borrar.FlatAppearance.BorderSize = 3;
            this.borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(231, 3);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(70, 50);
            this.borrar.TabIndex = 3;
            this.borrar.Text = "◄";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // diez
            // 
            this.diez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.diez.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.diez.FlatAppearance.BorderSize = 3;
            this.diez.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.diez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diez.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diez.Location = new System.Drawing.Point(3, 59);
            this.diez.Name = "diez";
            this.diez.Size = new System.Drawing.Size(70, 50);
            this.diez.TabIndex = 4;
            this.diez.Text = "A";
            this.diez.UseVisualStyleBackColor = false;
            this.diez.Click += new System.EventHandler(this.diez_Click);
            // 
            // once
            // 
            this.once.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.once.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.once.FlatAppearance.BorderSize = 3;
            this.once.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.once.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.once.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.once.Location = new System.Drawing.Point(79, 59);
            this.once.Name = "once";
            this.once.Size = new System.Drawing.Size(70, 50);
            this.once.TabIndex = 5;
            this.once.Text = "B";
            this.once.UseVisualStyleBackColor = false;
            this.once.Click += new System.EventHandler(this.once_Click);
            // 
            // doce
            // 
            this.doce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.doce.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.doce.FlatAppearance.BorderSize = 3;
            this.doce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.doce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doce.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doce.Location = new System.Drawing.Point(155, 59);
            this.doce.Name = "doce";
            this.doce.Size = new System.Drawing.Size(70, 50);
            this.doce.TabIndex = 6;
            this.doce.Text = "C";
            this.doce.UseVisualStyleBackColor = false;
            this.doce.Click += new System.EventHandler(this.doce_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.division.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.division.FlatAppearance.BorderSize = 3;
            this.division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(231, 59);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(70, 50);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.siete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.siete.FlatAppearance.BorderSize = 3;
            this.siete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siete.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(3, 115);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(70, 50);
            this.siete.TabIndex = 8;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.ocho.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ocho.FlatAppearance.BorderSize = 3;
            this.ocho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocho.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(79, 115);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(70, 50);
            this.ocho.TabIndex = 9;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // nueve
            // 
            this.nueve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.nueve.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nueve.FlatAppearance.BorderSize = 3;
            this.nueve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.nueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nueve.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.nueve.Location = new System.Drawing.Point(155, 115);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(70, 50);
            this.nueve.TabIndex = 10;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = false;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // por
            // 
            this.por.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.por.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.por.FlatAppearance.BorderSize = 3;
            this.por.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.por.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.por.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.por.Location = new System.Drawing.Point(231, 115);
            this.por.Name = "por";
            this.por.Size = new System.Drawing.Size(70, 50);
            this.por.TabIndex = 11;
            this.por.Text = "*";
            this.por.UseVisualStyleBackColor = false;
            this.por.Click += new System.EventHandler(this.por_Click);
            // 
            // cuatro
            // 
            this.cuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.cuatro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cuatro.FlatAppearance.BorderSize = 3;
            this.cuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuatro.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.cuatro.Location = new System.Drawing.Point(3, 171);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(70, 50);
            this.cuatro.TabIndex = 12;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = false;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.cinco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cinco.FlatAppearance.BorderSize = 3;
            this.cinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinco.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.cinco.Location = new System.Drawing.Point(79, 171);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(70, 50);
            this.cinco.TabIndex = 13;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.seis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seis.FlatAppearance.BorderSize = 3;
            this.seis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seis.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.seis.Location = new System.Drawing.Point(155, 171);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(70, 50);
            this.seis.TabIndex = 14;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // menos
            // 
            this.menos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.menos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menos.FlatAppearance.BorderSize = 3;
            this.menos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menos.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.Location = new System.Drawing.Point(231, 171);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(70, 50);
            this.menos.TabIndex = 15;
            this.menos.Text = "─";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // uno
            // 
            this.uno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.uno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uno.FlatAppearance.BorderSize = 3;
            this.uno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uno.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.uno.Location = new System.Drawing.Point(3, 227);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(70, 50);
            this.uno.TabIndex = 16;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.dos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dos.FlatAppearance.BorderSize = 3;
            this.dos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dos.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.dos.Location = new System.Drawing.Point(79, 227);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(70, 50);
            this.dos.TabIndex = 17;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.tres.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tres.FlatAppearance.BorderSize = 3;
            this.tres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tres.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.tres.Location = new System.Drawing.Point(155, 227);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(70, 50);
            this.tres.TabIndex = 18;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // mas
            // 
            this.mas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.mas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mas.FlatAppearance.BorderSize = 3;
            this.mas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mas.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.mas.Location = new System.Drawing.Point(231, 227);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(70, 50);
            this.mas.TabIndex = 19;
            this.mas.Text = "+";
            this.mas.UseVisualStyleBackColor = false;
            this.mas.Click += new System.EventHandler(this.mas_Click);
            // 
            // cero
            // 
            this.cero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.cero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cero.FlatAppearance.BorderSize = 3;
            this.cero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cero.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.cero.Location = new System.Drawing.Point(3, 283);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(70, 50);
            this.cero.TabIndex = 20;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // coma
            // 
            this.coma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.coma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.coma.FlatAppearance.BorderSize = 3;
            this.coma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.coma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coma.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.coma.Location = new System.Drawing.Point(79, 283);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(70, 50);
            this.coma.TabIndex = 21;
            this.coma.Text = ",";
            this.coma.UseVisualStyleBackColor = false;
            this.coma.Click += new System.EventHandler(this.coma_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.limpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.limpiar.FlatAppearance.BorderSize = 3;
            this.limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(155, 283);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(70, 50);
            this.limpiar.TabIndex = 22;
            this.limpiar.Text = "Clear";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.igual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.igual.FlatAppearance.BorderSize = 3;
            this.igual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igual.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.igual.Location = new System.Drawing.Point(231, 283);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(70, 50);
            this.igual.TabIndex = 23;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // resulDecimal
            // 
            this.resulDecimal.AutoSize = true;
            this.resulDecimal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulDecimal.ForeColor = System.Drawing.Color.White;
            this.resulDecimal.Location = new System.Drawing.Point(16, 16);
            this.resulDecimal.Name = "resulDecimal";
            this.resulDecimal.Size = new System.Drawing.Size(18, 21);
            this.resulDecimal.TabIndex = 5;
            this.resulDecimal.Text = "0";
            this.resulDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gBoxResultados
            // 
            this.gBoxResultados.BackColor = System.Drawing.Color.Transparent;
            this.gBoxResultados.Controls.Add(this.label8);
            this.gBoxResultados.Controls.Add(this.label7);
            this.gBoxResultados.Controls.Add(this.label6);
            this.gBoxResultados.Controls.Add(this.resulBinario);
            this.gBoxResultados.Controls.Add(this.resulOctal);
            this.gBoxResultados.Controls.Add(this.resulHexa);
            this.gBoxResultados.Controls.Add(this.resulDecimal);
            this.gBoxResultados.Controls.Add(this.label1);
            this.gBoxResultados.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxResultados.ForeColor = System.Drawing.Color.White;
            this.gBoxResultados.Location = new System.Drawing.Point(352, 150);
            this.gBoxResultados.Name = "gBoxResultados";
            this.gBoxResultados.Size = new System.Drawing.Size(326, 130);
            this.gBoxResultados.TabIndex = 6;
            this.gBoxResultados.TabStop = false;
            this.gBoxResultados.Text = "Resultados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(-3, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "O";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-2, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "H";
            // 
            // resulBinario
            // 
            this.resulBinario.AutoSize = true;
            this.resulBinario.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulBinario.ForeColor = System.Drawing.Color.White;
            this.resulBinario.Location = new System.Drawing.Point(16, 101);
            this.resulBinario.Name = "resulBinario";
            this.resulBinario.Size = new System.Drawing.Size(18, 21);
            this.resulBinario.TabIndex = 8;
            this.resulBinario.Text = "0";
            this.resulBinario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resulOctal
            // 
            this.resulOctal.AutoSize = true;
            this.resulOctal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulOctal.ForeColor = System.Drawing.Color.White;
            this.resulOctal.Location = new System.Drawing.Point(16, 44);
            this.resulOctal.Name = "resulOctal";
            this.resulOctal.Size = new System.Drawing.Size(18, 21);
            this.resulOctal.TabIndex = 7;
            this.resulOctal.Text = "0";
            this.resulOctal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resulHexa
            // 
            this.resulHexa.AutoSize = true;
            this.resulHexa.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulHexa.ForeColor = System.Drawing.Color.White;
            this.resulHexa.Location = new System.Drawing.Point(16, 73);
            this.resulHexa.Name = "resulHexa";
            this.resulHexa.Size = new System.Drawing.Size(18, 21);
            this.resulHexa.TabIndex = 6;
            this.resulHexa.Text = "0";
            this.resulHexa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "BI";
            // 
            // btnPasarSm
            // 
            this.btnPasarSm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.btnPasarSm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPasarSm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasarSm.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarSm.Location = new System.Drawing.Point(357, 286);
            this.btnPasarSm.Name = "btnPasarSm";
            this.btnPasarSm.Size = new System.Drawing.Size(84, 23);
            this.btnPasarSm.TabIndex = 7;
            this.btnPasarSm.Text = "SM, C1, C2";
            this.btnPasarSm.UseVisualStyleBackColor = false;
            this.btnPasarSm.Click += new System.EventHandler(this.btnPasarSm_Click);
            // 
            // rBinarioSM
            // 
            this.rBinarioSM.AutoSize = true;
            this.rBinarioSM.BackColor = System.Drawing.Color.Transparent;
            this.rBinarioSM.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinarioSM.ForeColor = System.Drawing.Color.White;
            this.rBinarioSM.Location = new System.Drawing.Point(359, 312);
            this.rBinarioSM.Name = "rBinarioSM";
            this.rBinarioSM.Size = new System.Drawing.Size(0, 21);
            this.rBinarioSM.TabIndex = 9;
            this.rBinarioSM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBinarioSM.Visible = false;
            // 
            // rBinarioC1
            // 
            this.rBinarioC1.AutoSize = true;
            this.rBinarioC1.BackColor = System.Drawing.Color.Transparent;
            this.rBinarioC1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinarioC1.ForeColor = System.Drawing.Color.White;
            this.rBinarioC1.Location = new System.Drawing.Point(359, 337);
            this.rBinarioC1.Name = "rBinarioC1";
            this.rBinarioC1.Size = new System.Drawing.Size(0, 21);
            this.rBinarioC1.TabIndex = 10;
            this.rBinarioC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBinarioC1.Visible = false;
            // 
            // rBinarioC2
            // 
            this.rBinarioC2.AutoSize = true;
            this.rBinarioC2.BackColor = System.Drawing.Color.Transparent;
            this.rBinarioC2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinarioC2.ForeColor = System.Drawing.Color.White;
            this.rBinarioC2.Location = new System.Drawing.Point(359, 364);
            this.rBinarioC2.Name = "rBinarioC2";
            this.rBinarioC2.Size = new System.Drawing.Size(0, 21);
            this.rBinarioC2.TabIndex = 11;
            this.rBinarioC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBinarioC2.Visible = false;
            // 
            // unSM
            // 
            this.unSM.AutoSize = true;
            this.unSM.BackColor = System.Drawing.Color.Black;
            this.unSM.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unSM.ForeColor = System.Drawing.Color.White;
            this.unSM.Location = new System.Drawing.Point(336, 315);
            this.unSM.Name = "unSM";
            this.unSM.Size = new System.Drawing.Size(24, 15);
            this.unSM.TabIndex = 17;
            this.unSM.Text = "SM";
            this.unSM.Visible = false;
            // 
            // unC1
            // 
            this.unC1.AutoSize = true;
            this.unC1.BackColor = System.Drawing.Color.Black;
            this.unC1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unC1.ForeColor = System.Drawing.Color.White;
            this.unC1.Location = new System.Drawing.Point(335, 341);
            this.unC1.Name = "unC1";
            this.unC1.Size = new System.Drawing.Size(20, 15);
            this.unC1.TabIndex = 18;
            this.unC1.Text = "C1";
            this.unC1.Visible = false;
            // 
            // unC2
            // 
            this.unC2.AutoSize = true;
            this.unC2.BackColor = System.Drawing.Color.Black;
            this.unC2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unC2.ForeColor = System.Drawing.Color.White;
            this.unC2.Location = new System.Drawing.Point(335, 368);
            this.unC2.Name = "unC2";
            this.unC2.Size = new System.Drawing.Size(23, 15);
            this.unC2.TabIndex = 19;
            this.unC2.Text = "C2";
            this.unC2.Visible = false;
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazV1.Properties.Resources._261;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.unC2);
            this.Controls.Add(this.unC1);
            this.Controls.Add(this.unSM);
            this.Controls.Add(this.rBinarioC2);
            this.Controls.Add(this.rBinarioC1);
            this.Controls.Add(this.rBinarioSM);
            this.Controls.Add(this.btnPasarSm);
            this.Controls.Add(this.gBoxResultados);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelResul);
            this.Controls.Add(this.gBoxEntradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Operaciones_Load);
            this.Shown += new System.EventHandler(this.Operaciones_Shown);
            this.gBoxEntradas.ResumeLayout(false);
            this.gBoxEntradas.PerformLayout();
            this.panelResul.ResumeLayout(false);
            this.fondoResul.ResumeLayout(false);
            this.fondoResul.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gBoxResultados.ResumeLayout(false);
            this.gBoxResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxEntradas;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RadioButton rbOctal;
        private System.Windows.Forms.RadioButton rbBin;
        private System.Windows.Forms.RadioButton rbDeci;
        private System.Windows.Forms.Panel panelResul;
        private System.Windows.Forms.Label numerosIngresados;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button trece;
        private System.Windows.Forms.Button catorce;
        private System.Windows.Forms.Button quince;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button diez;
        private System.Windows.Forms.Button once;
        private System.Windows.Forms.Button doce;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button por;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button mas;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Panel fondoResul;
        private System.Windows.Forms.Label memoria;
        private System.Windows.Forms.Label resulDecimal;
        private System.Windows.Forms.GroupBox gBoxResultados;
        private System.Windows.Forms.Label resulBinario;
        private System.Windows.Forms.Label resulOctal;
        private System.Windows.Forms.Label resulHexa;
        private System.Windows.Forms.Button btnPasarSm;
        private System.Windows.Forms.Label rBinarioSM;
        private System.Windows.Forms.Label rBinarioC1;
        private System.Windows.Forms.Label rBinarioC2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label unSM;
        private System.Windows.Forms.Label unC1;
        private System.Windows.Forms.Label unC2;
    }
}