namespace WindowsFormsApp1
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTempC = new System.Windows.Forms.Label();
            this.lblTempF = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.disconect = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConectar = new System.Windows.Forms.Button();
            this.TxtDesconectar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(36, 42);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 0;
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(36, 88);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(100, 20);
            this.tbdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha ";
            // 
            // lblTempC
            // 
            this.lblTempC.AutoSize = true;
            this.lblTempC.Location = new System.Drawing.Point(36, 144);
            this.lblTempC.Name = "lblTempC";
            this.lblTempC.Size = new System.Drawing.Size(118, 13);
            this.lblTempC.TabIndex = 4;
            this.lblTempC.Text = "Temperatura en Celsius";
            // 
            // lblTempF
            // 
            this.lblTempF.AutoSize = true;
            this.lblTempF.Location = new System.Drawing.Point(36, 161);
            this.lblTempF.Name = "lblTempF";
            this.lblTempF.Size = new System.Drawing.Size(132, 13);
            this.lblTempF.TabIndex = 5;
            this.lblTempF.Text = "Temperatura en fahrenheit";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(36, 331);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 6;
            this.connect.Text = "Conectar";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconect
            // 
            this.disconect.Location = new System.Drawing.Point(137, 331);
            this.disconect.Name = "disconect";
            this.disconect.Size = new System.Drawing.Size(85, 23);
            this.disconect.TabIndex = 7;
            this.disconect.Text = "Desconectar";
            this.disconect.UseVisualStyleBackColor = true;
            this.disconect.Click += new System.EventHandler(this.disconect_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(96, 315);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Apagado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // TxtConectar
            // 
            this.TxtConectar.Location = new System.Drawing.Point(347, 194);
            this.TxtConectar.Name = "TxtConectar";
            this.TxtConectar.Size = new System.Drawing.Size(75, 23);
            this.TxtConectar.TabIndex = 11;
            this.TxtConectar.Text = "Conectar";
            this.TxtConectar.UseVisualStyleBackColor = true;
            this.TxtConectar.Click += new System.EventHandler(this.TxtConectar_Click);
            // 
            // TxtDesconectar
            // 
            this.TxtDesconectar.Location = new System.Drawing.Point(347, 237);
            this.TxtDesconectar.Name = "TxtDesconectar";
            this.TxtDesconectar.Size = new System.Drawing.Size(86, 23);
            this.TxtDesconectar.TabIndex = 12;
            this.TxtDesconectar.Text = "Desconectar";
            this.TxtDesconectar.UseVisualStyleBackColor = true;
            this.TxtDesconectar.Click += new System.EventHandler(this.TxtDesconectar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Conectar servo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Desconectar Servo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDesconectar);
            this.Controls.Add(this.TxtConectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.disconect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.lblTempF);
            this.Controls.Add(this.lblTempC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.tbname);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTempC;
        private System.Windows.Forms.Label lblTempF;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconect;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TxtConectar;
        private System.Windows.Forms.Button TxtDesconectar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

