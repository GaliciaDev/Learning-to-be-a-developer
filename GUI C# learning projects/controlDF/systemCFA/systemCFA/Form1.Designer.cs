namespace systemCFA
{
    partial class ledControl
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
            this.statusLed = new System.Windows.Forms.Label();
            this.turnOn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.turnOff = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLed
            // 
            this.statusLed.AutoSize = true;
            this.statusLed.BackColor = System.Drawing.Color.OrangeRed;
            this.statusLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLed.Location = new System.Drawing.Point(114, 34);
            this.statusLed.Name = "statusLed";
            this.statusLed.Size = new System.Drawing.Size(52, 24);
            this.statusLed.TabIndex = 0;
            this.statusLed.Text = "OFF";
            // 
            // turnOn
            // 
            this.turnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnOn.Location = new System.Drawing.Point(29, 81);
            this.turnOn.Name = "turnOn";
            this.turnOn.Size = new System.Drawing.Size(101, 33);
            this.turnOn.TabIndex = 1;
            this.turnOn.Text = "Encendido";
            this.turnOn.UseVisualStyleBackColor = true;
            this.turnOn.Click += new System.EventHandler(this.turnOn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.turnOff);
            this.groupBox1.Controls.Add(this.statusLed);
            this.groupBox1.Controls.Add(this.turnOn);
            this.groupBox1.Location = new System.Drawing.Point(76, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control S";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // turnOff
            // 
            this.turnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnOff.Location = new System.Drawing.Point(152, 81);
            this.turnOff.Name = "turnOff";
            this.turnOff.Size = new System.Drawing.Size(101, 33);
            this.turnOff.TabIndex = 2;
            this.turnOff.Text = "Apagado";
            this.turnOff.UseVisualStyleBackColor = true;
            this.turnOff.Click += new System.EventHandler(this.turnOff_Click);
            // 
            // ledControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(426, 358);
            this.Controls.Add(this.groupBox1);
            this.Name = "ledControl";
            this.Text = "Comunicacion con arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ledControl_FormClosing);
            this.Load += new System.EventHandler(this.ledControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label statusLed;
        private System.Windows.Forms.Button turnOn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button turnOff;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

