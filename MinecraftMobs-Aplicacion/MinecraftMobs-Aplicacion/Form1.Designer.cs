namespace MinecraftMobs_Aplicacion
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
            lblTitulo = new Label();
            btnAgregar = new Button();
            btnModBorr = new Button();
            cmbMob = new ComboBox();
            lblNombre = new Label();
            picbImagen = new PictureBox();
            lblVidaE = new Label();
            lblVida = new Label();
            lblDrop = new Label();
            lblDropE = new Label();
            lblSpawnE = new Label();
            lblSpawn = new Label();
            grbHostil = new GroupBox();
            lblDanio = new Label();
            lblDanioE = new Label();
            lblAtaque = new Label();
            lblAtaqueE = new Label();
            grbControles = new GroupBox();
            lblTipoE = new Label();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)picbImagen).BeginInit();
            grbHostil.SuspendLayout();
            grbControles.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Minecrafter", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(804, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mobs de Minecraft";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(401, 38);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 46);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModBorr
            // 
            btnModBorr.Location = new Point(577, 38);
            btnModBorr.Name = "btnModBorr";
            btnModBorr.Size = new Size(236, 46);
            btnModBorr.TabIndex = 2;
            btnModBorr.Text = "Eliminar o modificar";
            btnModBorr.UseVisualStyleBackColor = true;
            // 
            // cmbMob
            // 
            cmbMob.FormattingEnabled = true;
            cmbMob.Location = new Point(16, 38);
            cmbMob.Name = "cmbMob";
            cmbMob.Size = new Size(349, 40);
            cmbMob.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Minecrafter", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(27, 107);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(437, 37);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre del mob";
            // 
            // picbImagen
            // 
            picbImagen.Location = new Point(20, 156);
            picbImagen.Name = "picbImagen";
            picbImagen.Size = new Size(448, 415);
            picbImagen.TabIndex = 5;
            picbImagen.TabStop = false;
            // 
            // lblVidaE
            // 
            lblVidaE.AutoSize = true;
            lblVidaE.Font = new Font("Jersey 10", 16.1249981F);
            lblVidaE.Location = new Point(20, 611);
            lblVidaE.Name = "lblVidaE";
            lblVidaE.Size = new Size(88, 47);
            lblVidaE.TabIndex = 6;
            lblVidaE.Text = "Vida:";
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVida.Location = new Point(114, 616);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(173, 37);
            lblVida.TabIndex = 7;
            lblVida.Text = "10 corazones";
            // 
            // lblDrop
            // 
            lblDrop.AutoSize = true;
            lblDrop.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDrop.Location = new Point(157, 739);
            lblDrop.Name = "lblDrop";
            lblDrop.Size = new Size(73, 37);
            lblDrop.TabIndex = 8;
            lblDrop.Text = "Lana";
            // 
            // lblDropE
            // 
            lblDropE.AutoSize = true;
            lblDropE.Font = new Font("Jersey 10", 16.1249981F);
            lblDropE.Location = new Point(20, 729);
            lblDropE.Name = "lblDropE";
            lblDropE.Size = new Size(97, 47);
            lblDropE.TabIndex = 9;
            lblDropE.Text = "Drop:";
            // 
            // lblSpawnE
            // 
            lblSpawnE.AutoSize = true;
            lblSpawnE.Font = new Font("Jersey 10", 16.1249981F);
            lblSpawnE.Location = new Point(27, 792);
            lblSpawnE.Name = "lblSpawnE";
            lblSpawnE.Size = new Size(124, 47);
            lblSpawnE.TabIndex = 10;
            lblSpawnE.Text = "Spawn:";
            // 
            // lblSpawn
            // 
            lblSpawn.AutoSize = true;
            lblSpawn.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpawn.Location = new Point(157, 802);
            lblSpawn.Name = "lblSpawn";
            lblSpawn.Size = new Size(202, 37);
            lblSpawn.TabIndex = 11;
            lblSpawn.Text = "Cualquier zona ";
            // 
            // grbHostil
            // 
            grbHostil.Controls.Add(lblDanio);
            grbHostil.Controls.Add(lblDanioE);
            grbHostil.Controls.Add(lblAtaque);
            grbHostil.Controls.Add(lblAtaqueE);
            grbHostil.Location = new Point(365, 586);
            grbHostil.Name = "grbHostil";
            grbHostil.Size = new Size(484, 229);
            grbHostil.TabIndex = 12;
            grbHostil.TabStop = false;
            // 
            // lblDanio
            // 
            lblDanio.AutoSize = true;
            lblDanio.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDanio.Location = new Point(135, 96);
            lblDanio.Name = "lblDanio";
            lblDanio.Size = new Size(158, 37);
            lblDanio.TabIndex = 10;
            lblDanio.Text = "2 corazones";
            // 
            // lblDanioE
            // 
            lblDanioE.AutoSize = true;
            lblDanioE.Font = new Font("Jersey 10", 16.1249981F);
            lblDanioE.Location = new Point(6, 96);
            lblDanioE.Name = "lblDanioE";
            lblDanioE.Size = new Size(99, 47);
            lblDanioE.TabIndex = 9;
            lblDanioE.Text = "Daño:";
            // 
            // lblAtaque
            // 
            lblAtaque.AutoSize = true;
            lblAtaque.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtaque.Location = new Point(143, 28);
            lblAtaque.Name = "lblAtaque";
            lblAtaque.Size = new Size(214, 37);
            lblAtaque.TabIndex = 8;
            lblAtaque.Text = "Cuerpo a cuerpo";
            // 
            // lblAtaqueE
            // 
            lblAtaqueE.AutoSize = true;
            lblAtaqueE.Font = new Font("Jersey 10", 16.1249981F);
            lblAtaqueE.Location = new Point(6, 23);
            lblAtaqueE.Name = "lblAtaqueE";
            lblAtaqueE.Size = new Size(131, 47);
            lblAtaqueE.TabIndex = 7;
            lblAtaqueE.Text = "Ataque:";
            // 
            // grbControles
            // 
            grbControles.Controls.Add(btnModBorr);
            grbControles.Controls.Add(btnAgregar);
            grbControles.Controls.Add(cmbMob);
            grbControles.Location = new Point(12, 924);
            grbControles.Name = "grbControles";
            grbControles.Size = new Size(834, 112);
            grbControles.TabIndex = 13;
            grbControles.TabStop = false;
            // 
            // lblTipoE
            // 
            lblTipoE.AutoSize = true;
            lblTipoE.Font = new Font("Jersey 10", 16.1249981F);
            lblTipoE.Location = new Point(20, 668);
            lblTipoE.Name = "lblTipoE";
            lblTipoE.Size = new Size(86, 47);
            lblTipoE.TabIndex = 14;
            lblTipoE.Text = "Tipo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(124, 673);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(107, 37);
            lblTipo.TabIndex = 15;
            lblTipo.Text = "Pacifico";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 1103);
            Controls.Add(lblTipo);
            Controls.Add(lblTipoE);
            Controls.Add(grbControles);
            Controls.Add(grbHostil);
            Controls.Add(lblSpawn);
            Controls.Add(lblSpawnE);
            Controls.Add(lblDropE);
            Controls.Add(lblDrop);
            Controls.Add(lblVida);
            Controls.Add(lblVidaE);
            Controls.Add(picbImagen);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmMain";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)picbImagen).EndInit();
            grbHostil.ResumeLayout(false);
            grbHostil.PerformLayout();
            grbControles.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAgregar;
        private Button btnModBorr;
        private ComboBox cmbMob;
        private Label lblNombre;
        private PictureBox picbImagen;
        private Label lblVidaE;
        private Label lblVida;
        private Label lblDrop;
        private Label lblDropE;
        private Label lblSpawnE;
        private Label lblSpawn;
        private GroupBox grbHostil;
        private Label lblAtaqueE;
        private Label lblDanio;
        private Label lblDanioE;
        private Label lblAtaque;
        private GroupBox grbControles;
        private Label lblTipoE;
        private Label lblTipo;
    }
}
