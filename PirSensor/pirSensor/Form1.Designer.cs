namespace sesnor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.baslat = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baslat
            // 
            this.baslat.Location = new System.Drawing.Point(46, 61);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(75, 23);
            this.baslat.TabIndex = 0;
            this.baslat.Text = "Start";
            this.baslat.UseVisualStyleBackColor = true;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // durdur
            // 
            this.durdur.Location = new System.Drawing.Point(46, 100);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(75, 23);
            this.durdur.TabIndex = 1;
            this.durdur.Text = "stop";
            this.durdur.UseVisualStyleBackColor = true;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // sifirla
            // 
            this.sifirla.Location = new System.Drawing.Point(46, 141);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(75, 23);
            this.sifirla.TabIndex = 2;
            this.sifirla.Text = "reset";
            this.sifirla.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(280, 191);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadBufferSize = 9600;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(43, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please first port select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.baslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
    }
}

