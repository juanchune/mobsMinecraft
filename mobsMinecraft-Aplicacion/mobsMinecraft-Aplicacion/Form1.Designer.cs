namespace mobsMinecraft_Aplicacion
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAgregar = new Button();
            grpTipo = new GroupBox();
            lblTipoMob = new Label();
            rdbPasivo = new RadioButton();
            rdbHostil = new RadioButton();
            grpPasivo = new GroupBox();
            nudVida = new NumericUpDown();
            lblVida = new Label();
            txtNombrePasivo = new TextBox();
            lblImagen = new Label();
            lblSpawn = new Label();
            imageList1 = new ImageList(components);
            txtSpawn = new TextBox();
            textBox1 = new TextBox();
            lblDroop = new Label();
            nudDanio = new NumericUpDown();
            lblDanio = new Label();
            cmbAtaque = new ComboBox();
            lblAtaque = new Label();
            lblImg = new Label();
            pictureBox1 = new PictureBox();
            grpTipo.SuspendLayout();
            grpPasivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDanio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(706, 576);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 46);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // grpTipo
            // 
            grpTipo.Controls.Add(lblTipoMob);
            grpTipo.Controls.Add(rdbPasivo);
            grpTipo.Controls.Add(rdbHostil);
            grpTipo.Location = new Point(53, 98);
            grpTipo.Name = "grpTipo";
            grpTipo.Size = new Size(297, 140);
            grpTipo.TabIndex = 1;
            grpTipo.TabStop = false;
            // 
            // lblTipoMob
            // 
            lblTipoMob.AutoSize = true;
            lblTipoMob.Location = new Point(16, 35);
            lblTipoMob.Name = "lblTipoMob";
            lblTipoMob.Size = new Size(151, 32);
            lblTipoMob.TabIndex = 2;
            lblTipoMob.Text = "Tipo de mob";
            // 
            // rdbPasivo
            // 
            rdbPasivo.AutoSize = true;
            rdbPasivo.Checked = true;
            rdbPasivo.Location = new Point(16, 77);
            rdbPasivo.Name = "rdbPasivo";
            rdbPasivo.Size = new Size(111, 36);
            rdbPasivo.TabIndex = 1;
            rdbPasivo.TabStop = true;
            rdbPasivo.Text = "Pasivo";
            rdbPasivo.UseVisualStyleBackColor = true;
            // 
            // rdbHostil
            // 
            rdbHostil.AutoSize = true;
            rdbHostil.Location = new Point(168, 77);
            rdbHostil.Name = "rdbHostil";
            rdbHostil.Size = new Size(106, 36);
            rdbHostil.TabIndex = 0;
            rdbHostil.Text = "Hostil";
            rdbHostil.UseVisualStyleBackColor = true;
            // 
            // grpPasivo
            // 
            grpPasivo.Controls.Add(pictureBox1);
            grpPasivo.Controls.Add(lblImg);
            grpPasivo.Controls.Add(lblAtaque);
            grpPasivo.Controls.Add(cmbAtaque);
            grpPasivo.Controls.Add(nudDanio);
            grpPasivo.Controls.Add(lblDanio);
            grpPasivo.Controls.Add(textBox1);
            grpPasivo.Controls.Add(lblDroop);
            grpPasivo.Controls.Add(txtSpawn);
            grpPasivo.Controls.Add(lblSpawn);
            grpPasivo.Controls.Add(nudVida);
            grpPasivo.Controls.Add(lblVida);
            grpPasivo.Controls.Add(txtNombrePasivo);
            grpPasivo.Controls.Add(lblImagen);
            grpPasivo.Location = new Point(906, 36);
            grpPasivo.Name = "grpPasivo";
            grpPasivo.Size = new Size(550, 853);
            grpPasivo.TabIndex = 2;
            grpPasivo.TabStop = false;
            // 
            // nudVida
            // 
            nudVida.Location = new Point(29, 176);
            nudVida.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudVida.Name = "nudVida";
            nudVida.Size = new Size(240, 39);
            nudVida.TabIndex = 3;
            nudVida.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.Location = new Point(29, 134);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(61, 32);
            lblVida.TabIndex = 2;
            lblVida.Text = "Vida";
            // 
            // txtNombrePasivo
            // 
            txtNombrePasivo.Location = new Point(29, 77);
            txtNombrePasivo.Name = "txtNombrePasivo";
            txtNombrePasivo.Size = new Size(515, 39);
            txtNombrePasivo.TabIndex = 1;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(29, 35);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(102, 32);
            lblImagen.TabIndex = 0;
            lblImagen.Text = "Nombre";
            // 
            // lblSpawn
            // 
            lblSpawn.AutoSize = true;
            lblSpawn.Location = new Point(29, 231);
            lblSpawn.Name = "lblSpawn";
            lblSpawn.Size = new Size(84, 32);
            lblSpawn.TabIndex = 4;
            lblSpawn.Text = "Spawn";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // txtSpawn
            // 
            txtSpawn.Location = new Point(18, 270);
            txtSpawn.Name = "txtSpawn";
            txtSpawn.Size = new Size(515, 39);
            txtSpawn.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(515, 39);
            textBox1.TabIndex = 7;
            // 
            // lblDroop
            // 
            lblDroop.AutoSize = true;
            lblDroop.Location = new Point(29, 326);
            lblDroop.Name = "lblDroop";
            lblDroop.Size = new Size(67, 32);
            lblDroop.TabIndex = 6;
            lblDroop.Text = "Drop";
            // 
            // nudDanio
            // 
            nudDanio.Location = new Point(29, 469);
            nudDanio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDanio.Name = "nudDanio";
            nudDanio.Size = new Size(240, 39);
            nudDanio.TabIndex = 9;
            nudDanio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDanio
            // 
            lblDanio.AutoSize = true;
            lblDanio.Location = new Point(18, 420);
            lblDanio.Name = "lblDanio";
            lblDanio.Size = new Size(77, 32);
            lblDanio.TabIndex = 8;
            lblDanio.Text = "Danio";
            // 
            // cmbAtaque
            // 
            cmbAtaque.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAtaque.FormattingEnabled = true;
            cmbAtaque.Items.AddRange(new object[] { "Ninguno", "Cuerpo a cuerpo", "A distancia/proyectil", "Ambas" });
            cmbAtaque.Location = new Point(29, 573);
            cmbAtaque.Name = "cmbAtaque";
            cmbAtaque.Size = new Size(242, 40);
            cmbAtaque.TabIndex = 10;
            // 
            // lblAtaque
            // 
            lblAtaque.AutoSize = true;
            lblAtaque.Location = new Point(29, 527);
            lblAtaque.Name = "lblAtaque";
            lblAtaque.Size = new Size(90, 32);
            lblAtaque.TabIndex = 11;
            lblAtaque.Text = "Ataque";
            // 
            // lblImg
            // 
            lblImg.AutoSize = true;
            lblImg.Location = new Point(23, 642);
            lblImg.Name = "lblImg";
            lblImg.Size = new Size(94, 32);
            lblImg.TabIndex = 12;
            lblImg.Text = "Imagen";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 710);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1735, 1103);
            Controls.Add(grpPasivo);
            Controls.Add(grpTipo);
            Controls.Add(btnAgregar);
            Name = "frmMain";
            Text = "Form1";
            grpTipo.ResumeLayout(false);
            grpTipo.PerformLayout();
            grpPasivo.ResumeLayout(false);
            grpPasivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudVida).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDanio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private GroupBox grpTipo;
        private RadioButton rdbHostil;
        private Label lblTipoMob;
        private RadioButton rdbPasivo;
        private GroupBox grpPasivo;
        private TextBox txtNombrePasivo;
        private Label lblImagen;
        private NumericUpDown nudVida;
        private Label lblVida;
        private Label lblSpawn;
        private ImageList imageList1;
        private TextBox txtSpawn;
        private NumericUpDown nudDanio;
        private Label lblDanio;
        private TextBox textBox1;
        private Label lblDroop;
        private Label lblImg;
        private Label lblAtaque;
        private ComboBox cmbAtaque;
        private PictureBox pictureBox1;
    }
}
