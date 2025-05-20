namespace MinecraftMobs_Aplicacion
{
    partial class Agregar
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
            lblTitulo = new Label();
            btnAgregar = new Button();
            grbTipo = new GroupBox();
            rdbHostil = new RadioButton();
            rdbNeutral = new RadioButton();
            rdbPasivo = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grbPasivo = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nudVida = new NumericUpDown();
            txtSpawn = new TextBox();
            txtDrop = new TextBox();
            txtNombre = new TextBox();
            lblSpawn = new Label();
            lblDrop = new Label();
            lblVida = new Label();
            lblNombre = new Label();
            grbHostil = new GroupBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            grbTipo.SuspendLayout();
            grbPasivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVida).BeginInit();
            grbHostil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Minecrafter", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(252, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(690, 60);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Agregar un mob";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(505, 1057);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 46);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // grbTipo
            // 
            grbTipo.Controls.Add(rdbHostil);
            grbTipo.Controls.Add(rdbNeutral);
            grbTipo.Controls.Add(rdbPasivo);
            grbTipo.Location = new Point(252, 113);
            grbTipo.Name = "grbTipo";
            grbTipo.Size = new Size(705, 81);
            grbTipo.TabIndex = 3;
            grbTipo.TabStop = false;
            // 
            // rdbHostil
            // 
            rdbHostil.AutoSize = true;
            rdbHostil.Location = new Point(535, 38);
            rdbHostil.Name = "rdbHostil";
            rdbHostil.Size = new Size(106, 36);
            rdbHostil.TabIndex = 6;
            rdbHostil.Text = "Hostil";
            rdbHostil.UseVisualStyleBackColor = true;
            rdbHostil.Click += rdbHostil_Click;
            // 
            // rdbNeutral
            // 
            rdbNeutral.AutoSize = true;
            rdbNeutral.Location = new Point(279, 37);
            rdbNeutral.Name = "rdbNeutral";
            rdbNeutral.Size = new Size(124, 36);
            rdbNeutral.TabIndex = 5;
            rdbNeutral.Text = "Neutral";
            rdbNeutral.UseVisualStyleBackColor = true;
            rdbNeutral.Click += rdbNeutral_Click;
            // 
            // rdbPasivo
            // 
            rdbPasivo.AutoSize = true;
            rdbPasivo.Checked = true;
            rdbPasivo.Location = new Point(19, 37);
            rdbPasivo.Name = "rdbPasivo";
            rdbPasivo.Size = new Size(111, 36);
            rdbPasivo.TabIndex = 4;
            rdbPasivo.TabStop = true;
            rdbPasivo.Text = "Pasivo";
            rdbPasivo.UseVisualStyleBackColor = true;
            rdbPasivo.Click += rdbPasivo_Click;
            // 
            // grbPasivo
            // 
            grbPasivo.Controls.Add(pictureBox1);
            grbPasivo.Controls.Add(label1);
            grbPasivo.Controls.Add(nudVida);
            grbPasivo.Controls.Add(txtSpawn);
            grbPasivo.Controls.Add(txtDrop);
            grbPasivo.Controls.Add(txtNombre);
            grbPasivo.Controls.Add(lblSpawn);
            grbPasivo.Controls.Add(lblDrop);
            grbPasivo.Controls.Add(lblVida);
            grbPasivo.Controls.Add(lblNombre);
            grbPasivo.Location = new Point(22, 225);
            grbPasivo.Name = "grbPasivo";
            grbPasivo.Size = new Size(551, 746);
            grbPasivo.TabIndex = 4;
            grbPasivo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 459);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 254);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 424);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 8;
            label1.Text = "Imagen";
            // 
            // nudVida
            // 
            nudVida.Location = new Point(17, 168);
            nudVida.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudVida.Name = "nudVida";
            nudVida.Size = new Size(516, 39);
            nudVida.TabIndex = 7;
            nudVida.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtSpawn
            // 
            txtSpawn.Location = new Point(17, 356);
            txtSpawn.Name = "txtSpawn";
            txtSpawn.Size = new Size(516, 39);
            txtSpawn.TabIndex = 6;
            // 
            // txtDrop
            // 
            txtDrop.Location = new Point(17, 268);
            txtDrop.Name = "txtDrop";
            txtDrop.Size = new Size(516, 39);
            txtDrop.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(516, 39);
            txtNombre.TabIndex = 4;
            // 
            // lblSpawn
            // 
            lblSpawn.AutoSize = true;
            lblSpawn.Location = new Point(17, 321);
            lblSpawn.Name = "lblSpawn";
            lblSpawn.Size = new Size(84, 32);
            lblSpawn.TabIndex = 3;
            lblSpawn.Text = "Spawn";
            // 
            // lblDrop
            // 
            lblDrop.AutoSize = true;
            lblDrop.Location = new Point(17, 221);
            lblDrop.Name = "lblDrop";
            lblDrop.Size = new Size(67, 32);
            lblDrop.TabIndex = 2;
            lblDrop.Text = "Drop";
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.Location = new Point(17, 133);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(61, 32);
            lblVida.TabIndex = 1;
            lblVida.Text = "Vida";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // grbHostil
            // 
            grbHostil.Controls.Add(pictureBox2);
            grbHostil.Controls.Add(label2);
            grbHostil.Controls.Add(numericUpDown1);
            grbHostil.Controls.Add(textBox1);
            grbHostil.Controls.Add(textBox2);
            grbHostil.Controls.Add(textBox3);
            grbHostil.Controls.Add(label3);
            grbHostil.Controls.Add(label4);
            grbHostil.Controls.Add(label5);
            grbHostil.Controls.Add(label6);
            grbHostil.Location = new Point(611, 225);
            grbHostil.Name = "grbHostil";
            grbHostil.Size = new Size(551, 746);
            grbHostil.TabIndex = 10;
            grbHostil.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(17, 459);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(288, 254);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 424);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 8;
            label2.Text = "Imagen";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(17, 168);
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(516, 39);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 356);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 39);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(516, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(516, 39);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 321);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 3;
            label3.Text = "Spawn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 221);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 2;
            label4.Text = "Drop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 133);
            label5.Name = "label5";
            label5.Size = new Size(61, 32);
            label5.TabIndex = 1;
            label5.Text = "Vida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 35);
            label6.Name = "label6";
            label6.Size = new Size(102, 32);
            label6.TabIndex = 0;
            label6.Text = "Nombre";
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 1129);
            Controls.Add(grbHostil);
            Controls.Add(grbPasivo);
            Controls.Add(grbTipo);
            Controls.Add(btnAgregar);
            Controls.Add(lblTitulo);
            Name = "Agregar";
            Text = "Agregar";
            grbTipo.ResumeLayout(false);
            grbTipo.PerformLayout();
            grbPasivo.ResumeLayout(false);
            grbPasivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVida).EndInit();
            grbHostil.ResumeLayout(false);
            grbHostil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAgregar;
        private GroupBox grbTipo;
        private RadioButton rdbHostil;
        private RadioButton rdbNeutral;
        private RadioButton rdbPasivo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbPasivo;
        private GroupBox grbHostil;
        private PictureBox pictureBox2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label1;
        private NumericUpDown nudVida;
        private TextBox txtSpawn;
        private TextBox txtDrop;
        private TextBox txtNombre;
        private Label lblSpawn;
        private Label lblDrop;
        private Label lblVida;
        private Label lblNombre;
    }
}