namespace WindowsFormsApp2
{
    partial class Arduino2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_turnOFF = new System.Windows.Forms.Button();
            this.button_turnON = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.animatedLED1 = new WindowsFormsApp2.AnimatedLED();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.comboBox_baudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_comPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTING";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(157, 222);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(98, 52);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(20, 222);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(98, 52);
            this.button_open.TabIndex = 5;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(134, 95);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(143, 32);
            this.comboBox_baudRate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD RATE :";
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(134, 42);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(143, 32);
            this.comboBox_comPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 297);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button_turnOFF);
            this.groupBox2.Controls.Add(this.button_turnON);
            this.groupBox2.Controls.Add(this.animatedLED1);
            this.groupBox2.Location = new System.Drawing.Point(320, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED CONTROL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.DarkRed;
            this.pictureBox1.Location = new System.Drawing.Point(247, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_turnOFF
            // 
            this.button_turnOFF.Location = new System.Drawing.Point(228, 193);
            this.button_turnOFF.Name = "button_turnOFF";
            this.button_turnOFF.Size = new System.Drawing.Size(144, 52);
            this.button_turnOFF.TabIndex = 2;
            this.button_turnOFF.Text = "TURN OFF";
            this.button_turnOFF.UseVisualStyleBackColor = true;
            this.button_turnOFF.Click += new System.EventHandler(this.button_turnOFF_Click);
            // 
            // button_turnON
            // 
            this.button_turnON.Location = new System.Drawing.Point(55, 194);
            this.button_turnON.Name = "button_turnON";
            this.button_turnON.Size = new System.Drawing.Size(144, 52);
            this.button_turnON.TabIndex = 1;
            this.button_turnON.Text = "TURN ON";
            this.button_turnON.UseVisualStyleBackColor = true;
            this.button_turnON.Click += new System.EventHandler(this.button_turnON_Click);
            // 
            // animatedLED1
            // 
            this.animatedLED1.BackColor = System.Drawing.Color.DarkRed;
            this.animatedLED1.Location = new System.Drawing.Point(80, 45);
            this.animatedLED1.Name = "animatedLED1";
            this.animatedLED1.Size = new System.Drawing.Size(99, 99);
            this.animatedLED1.TabIndex = 0;
            this.animatedLED1.Text = "animatedLED1";
            this.animatedLED1.UseVisualStyleBackColor = false;
            // 
            // Arduino2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Arduino2";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "C# and Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Arduino2_FormClosing);
            this.Load += new System.EventHandler(this.Arduino2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_turnOFF;
        private System.Windows.Forms.Button button_turnON;
        private AnimatedLED animatedLED1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

