namespace conversion_de_grados
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kelvin = new System.Windows.Forms.TextBox();
            this.centigrados = new System.Windows.Forms.TextBox();
            this.farenheit = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.ComboBox();
            this.convertir = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.rankine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kelvin
            // 
            this.kelvin.Location = new System.Drawing.Point(12, 99);
            this.kelvin.Name = "kelvin";
            this.kelvin.Size = new System.Drawing.Size(100, 20);
            this.kelvin.TabIndex = 0;
            this.kelvin.TextChanged += new System.EventHandler(this.kelvin_TextChanged);
            this.kelvin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kelvin_KeyPress);
            // 
            // centigrados
            // 
            this.centigrados.Location = new System.Drawing.Point(156, 99);
            this.centigrados.Name = "centigrados";
            this.centigrados.Size = new System.Drawing.Size(100, 20);
            this.centigrados.TabIndex = 1;
            this.centigrados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kelvin_KeyPress);
            // 
            // farenheit
            // 
            this.farenheit.Location = new System.Drawing.Point(311, 99);
            this.farenheit.Name = "farenheit";
            this.farenheit.Size = new System.Drawing.Size(100, 20);
            this.farenheit.TabIndex = 2;
            this.farenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kelvin_KeyPress);
            // 
            // menu
            // 
            this.menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.menu.FormattingEnabled = true;
            this.menu.Items.AddRange(new object[] {
            "Farenheit",
            "Kelvin",
            "Centigrados",
            "Rankine"});
            this.menu.Location = new System.Drawing.Point(12, 149);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(121, 21);
            this.menu.TabIndex = 3;
            this.toolTip1.SetToolTip(this.menu, "Menu de opciones");
            this.menu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // convertir
            // 
            this.convertir.Location = new System.Drawing.Point(12, 202);
            this.convertir.Name = "convertir";
            this.convertir.Size = new System.Drawing.Size(75, 23);
            this.convertir.TabIndex = 4;
            this.convertir.Text = "Convertir";
            this.convertir.UseVisualStyleBackColor = true;
            this.convertir.Click += new System.EventHandler(this.convertir_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(93, 202);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 5;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(174, 202);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // rankine
            // 
            this.rankine.Location = new System.Drawing.Point(156, 149);
            this.rankine.Name = "rankine";
            this.rankine.Size = new System.Drawing.Size(100, 20);
            this.rankine.TabIndex = 7;
            this.rankine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kelvin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kelvin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Centigrados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Farenheit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rankine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unidad de temperatura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(511, 47);
            this.label6.TabIndex = 13;
            this.label6.Text = "Convertidor de unidades de temperatura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::conversion_de_grados.Properties.Resources.termometro;
            this.pictureBox1.Location = new System.Drawing.Point(314, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 242);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rankine);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.convertir);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.farenheit);
            this.Controls.Add(this.centigrados);
            this.Controls.Add(this.kelvin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Conversiones";
            this.Load += new System.EventHandler(this.Conversiones);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kelvin;
        private System.Windows.Forms.TextBox centigrados;
        private System.Windows.Forms.TextBox farenheit;
        private System.Windows.Forms.ComboBox menu;
        private System.Windows.Forms.Button convertir;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox rankine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

