namespace HungryDrone
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cantidadPasta = new System.Windows.Forms.NumericUpDown();
            this.cantidadPizza = new System.Windows.Forms.NumericUpDown();
            this.cantidadSushi = new System.Windows.Forms.NumericUpDown();
            this.cantidadHotDog = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSushi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadHotDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnPagar.Location = new System.Drawing.Point(250, 597);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(81, 28);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInicio.Location = new System.Drawing.Point(90, 597);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(81, 28);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hot Dog Gourmet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.cantidadPasta);
            this.groupBox1.Controls.Add(this.cantidadPizza);
            this.groupBox1.Controls.Add(this.cantidadSushi);
            this.groupBox1.Controls.Add(this.cantidadHotDog);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("SuperFrench", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 579);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(369, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 567);
            this.vScrollBar1.TabIndex = 13;
            // 
            // cantidadPasta
            // 
            this.cantidadPasta.BackColor = System.Drawing.Color.Black;
            this.cantidadPasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidadPasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cantidadPasta.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadPasta.ForeColor = System.Drawing.Color.DarkRed;
            this.cantidadPasta.Location = new System.Drawing.Point(321, 528);
            this.cantidadPasta.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cantidadPasta.Name = "cantidadPasta";
            this.cantidadPasta.Size = new System.Drawing.Size(36, 24);
            this.cantidadPasta.TabIndex = 36;
            this.cantidadPasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantidadPasta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cantidadPasta_MouseDown);
            // 
            // cantidadPizza
            // 
            this.cantidadPizza.BackColor = System.Drawing.Color.Black;
            this.cantidadPizza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidadPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cantidadPizza.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadPizza.ForeColor = System.Drawing.Color.DarkRed;
            this.cantidadPizza.Location = new System.Drawing.Point(321, 392);
            this.cantidadPizza.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cantidadPizza.Name = "cantidadPizza";
            this.cantidadPizza.Size = new System.Drawing.Size(36, 24);
            this.cantidadPizza.TabIndex = 35;
            this.cantidadPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantidadPizza.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cantidadPizza_MouseDown);
            // 
            // cantidadSushi
            // 
            this.cantidadSushi.BackColor = System.Drawing.Color.Black;
            this.cantidadSushi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidadSushi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cantidadSushi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadSushi.ForeColor = System.Drawing.Color.DarkRed;
            this.cantidadSushi.Location = new System.Drawing.Point(321, 256);
            this.cantidadSushi.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cantidadSushi.Name = "cantidadSushi";
            this.cantidadSushi.Size = new System.Drawing.Size(36, 24);
            this.cantidadSushi.TabIndex = 34;
            this.cantidadSushi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantidadSushi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cantidadSushi_MouseDown);
            // 
            // cantidadHotDog
            // 
            this.cantidadHotDog.BackColor = System.Drawing.Color.Black;
            this.cantidadHotDog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidadHotDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cantidadHotDog.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadHotDog.ForeColor = System.Drawing.Color.DarkRed;
            this.cantidadHotDog.Location = new System.Drawing.Point(321, 120);
            this.cantidadHotDog.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cantidadHotDog.Name = "cantidadHotDog";
            this.cantidadHotDog.Size = new System.Drawing.Size(36, 24);
            this.cantidadHotDog.TabIndex = 33;
            this.cantidadHotDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantidadHotDog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cantidadHotDog_MouseDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "MXN220.00";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(18, 516);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "Pasta fresca con salmon ahumado y tomate secado al sol con un toque de queso parm" +
    "esano.\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(18, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Pasta con salmon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "MXN250.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(18, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Pizza Capricciosa";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(18, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "En masa artesanal, con queso mozzarella, aceitunas negras, pimiento verde y la tr" +
    "adicional salsa de tomate.\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "MXN130.00";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(18, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Con hongos japoneses, rebozado con masa tempura y con tiras de cebolla de verdeo " +
    "y huevos de pescado.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(18, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sushi con huevos de pescado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "MXN30.00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(18, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "En pan campesino, con salchicha de tosino, pimiento morron,  queso manchego, y ce" +
    "bollín.\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 637);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("SuperFrench", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HUNGRY DRONE";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSushi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadHotDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown cantidadHotDog;
        private System.Windows.Forms.NumericUpDown cantidadPasta;
        private System.Windows.Forms.NumericUpDown cantidadPizza;
        private System.Windows.Forms.NumericUpDown cantidadSushi;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

