namespace ComPortProxy.Ui {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPort1to2 = new System.Windows.Forms.Label();
            this.lblPort2to1 = new System.Windows.Forms.Label();
            this.cmbPort2Speed = new System.Windows.Forms.ComboBox();
            this.cmbPort2 = new System.Windows.Forms.ComboBox();
            this.cmbPort1Speed = new System.Windows.Forms.ComboBox();
            this.cmbPort1 = new System.Windows.Forms.ComboBox();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.rbHex1 = new System.Windows.Forms.RadioButton();
            this.rbAscii1 = new System.Windows.Forms.RadioButton();
            this.rbUtf81 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbAscii2 = new System.Windows.Forms.RadioButton();
            this.rbUtf82 = new System.Windows.Forms.RadioButton();
            this.rbHex2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(279, 99);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPort1Speed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPort1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPort2Speed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbPort2);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 79);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baud Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "COM Port";
            // 
            // lblPort1to2
            // 
            this.lblPort1to2.AutoSize = true;
            this.lblPort1to2.Location = new System.Drawing.Point(297, 34);
            this.lblPort1to2.Name = "lblPort1to2";
            this.lblPort1to2.Size = new System.Drawing.Size(38, 13);
            this.lblPort1to2.TabIndex = 4;
            this.lblPort1to2.Text = "0 kb/s";
            this.lblPort1to2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPort2to1
            // 
            this.lblPort2to1.AutoSize = true;
            this.lblPort2to1.Location = new System.Drawing.Point(297, 61);
            this.lblPort2to1.Name = "lblPort2to1";
            this.lblPort2to1.Size = new System.Drawing.Size(38, 13);
            this.lblPort2to1.TabIndex = 5;
            this.lblPort2to1.Text = "0 kb/s";
            this.lblPort2to1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPort2Speed
            // 
            this.cmbPort2Speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ComPortProxy.Ui.Properties.Settings.Default, "cmbPort2Speed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPort2Speed.FormattingEnabled = true;
            this.cmbPort2Speed.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbPort2Speed.Location = new System.Drawing.Point(119, 46);
            this.cmbPort2Speed.Name = "cmbPort2Speed";
            this.cmbPort2Speed.Size = new System.Drawing.Size(121, 21);
            this.cmbPort2Speed.TabIndex = 2;
            this.cmbPort2Speed.Text = global::ComPortProxy.Ui.Properties.Settings.Default.cmbPort2Speed;
            // 
            // cmbPort2
            // 
            this.cmbPort2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ComPortProxy.Ui.Properties.Settings.Default, "cmbPort2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPort2.FormattingEnabled = true;
            this.cmbPort2.Location = new System.Drawing.Point(119, 19);
            this.cmbPort2.Name = "cmbPort2";
            this.cmbPort2.Size = new System.Drawing.Size(121, 21);
            this.cmbPort2.TabIndex = 0;
            this.cmbPort2.Text = global::ComPortProxy.Ui.Properties.Settings.Default.cmbPort2;
            // 
            // cmbPort1Speed
            // 
            this.cmbPort1Speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ComPortProxy.Ui.Properties.Settings.Default, "cmbPort1Speed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPort1Speed.FormattingEnabled = true;
            this.cmbPort1Speed.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbPort1Speed.Location = new System.Drawing.Point(119, 46);
            this.cmbPort1Speed.Name = "cmbPort1Speed";
            this.cmbPort1Speed.Size = new System.Drawing.Size(121, 21);
            this.cmbPort1Speed.TabIndex = 2;
            this.cmbPort1Speed.Text = global::ComPortProxy.Ui.Properties.Settings.Default.cmbPort1Speed;
            // 
            // cmbPort1
            // 
            this.cmbPort1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ComPortProxy.Ui.Properties.Settings.Default, "cmbPort1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPort1.FormattingEnabled = true;
            this.cmbPort1.Location = new System.Drawing.Point(119, 19);
            this.cmbPort1.Name = "cmbPort1";
            this.cmbPort1.Size = new System.Drawing.Size(121, 21);
            this.cmbPort1.TabIndex = 0;
            this.cmbPort1.Text = global::ComPortProxy.Ui.Properties.Settings.Default.cmbPort1;
            // 
            // txtData1
            // 
            this.txtData1.Font = new System.Drawing.Font("Ubuntu Mono", 12F);
            this.txtData1.Location = new System.Drawing.Point(12, 131);
            this.txtData1.Multiline = true;
            this.txtData1.Name = "txtData1";
            this.txtData1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData1.Size = new System.Drawing.Size(246, 218);
            this.txtData1.TabIndex = 6;
            // 
            // txtData2
            // 
            this.txtData2.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2.Location = new System.Drawing.Point(374, 131);
            this.txtData2.Multiline = true;
            this.txtData2.Name = "txtData2";
            this.txtData2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData2.Size = new System.Drawing.Size(245, 212);
            this.txtData2.TabIndex = 7;
            // 
            // rbHex1
            // 
            this.rbHex1.AutoSize = true;
            this.rbHex1.Location = new System.Drawing.Point(129, 5);
            this.rbHex1.Name = "rbHex1";
            this.rbHex1.Size = new System.Drawing.Size(47, 17);
            this.rbHex1.TabIndex = 8;
            this.rbHex1.Text = "HEX";
            this.rbHex1.UseVisualStyleBackColor = true;
            // 
            // rbAscii1
            // 
            this.rbAscii1.AutoSize = true;
            this.rbAscii1.Checked = true;
            this.rbAscii1.Location = new System.Drawing.Point(10, 5);
            this.rbAscii1.Name = "rbAscii1";
            this.rbAscii1.Size = new System.Drawing.Size(52, 17);
            this.rbAscii1.TabIndex = 9;
            this.rbAscii1.TabStop = true;
            this.rbAscii1.Text = "ASCII";
            this.rbAscii1.UseVisualStyleBackColor = true;
            // 
            // rbUtf81
            // 
            this.rbUtf81.AutoSize = true;
            this.rbUtf81.Location = new System.Drawing.Point(68, 5);
            this.rbUtf81.Name = "rbUtf81";
            this.rbUtf81.Size = new System.Drawing.Size(55, 17);
            this.rbUtf81.TabIndex = 9;
            this.rbUtf81.Text = "UTF-8";
            this.rbUtf81.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAscii1);
            this.panel1.Controls.Add(this.rbUtf81);
            this.panel1.Controls.Add(this.rbHex1);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 28);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbAscii2);
            this.panel2.Controls.Add(this.rbUtf82);
            this.panel2.Controls.Add(this.rbHex2);
            this.panel2.Location = new System.Drawing.Point(374, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 28);
            this.panel2.TabIndex = 11;
            // 
            // rbAscii2
            // 
            this.rbAscii2.AutoSize = true;
            this.rbAscii2.Checked = true;
            this.rbAscii2.Location = new System.Drawing.Point(10, 5);
            this.rbAscii2.Name = "rbAscii2";
            this.rbAscii2.Size = new System.Drawing.Size(52, 17);
            this.rbAscii2.TabIndex = 9;
            this.rbAscii2.TabStop = true;
            this.rbAscii2.Text = "ASCII";
            this.rbAscii2.UseVisualStyleBackColor = true;
            // 
            // rbUtf82
            // 
            this.rbUtf82.AutoSize = true;
            this.rbUtf82.Location = new System.Drawing.Point(68, 5);
            this.rbUtf82.Name = "rbUtf82";
            this.rbUtf82.Size = new System.Drawing.Size(55, 17);
            this.rbUtf82.TabIndex = 9;
            this.rbUtf82.Text = "UTF-8";
            this.rbUtf82.UseVisualStyleBackColor = true;
            // 
            // rbHex2
            // 
            this.rbHex2.AutoSize = true;
            this.rbHex2.Location = new System.Drawing.Point(129, 5);
            this.rbHex2.Name = "rbHex2";
            this.rbHex2.Size = new System.Drawing.Size(47, 17);
            this.rbHex2.TabIndex = 8;
            this.rbHex2.Text = "HEX";
            this.rbHex2.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtData1);
            this.Controls.Add(this.lblPort2to1);
            this.Controls.Add(this.lblPort1to2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnect);
            this.Name = "FormMain";
            this.Text = "Com Port Proxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPort1Speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPort2Speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPort2;
        private System.Windows.Forms.Label lblPort1to2;
        private System.Windows.Forms.Label lblPort2to1;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.RadioButton rbHex1;
        private System.Windows.Forms.RadioButton rbAscii1;
        private System.Windows.Forms.RadioButton rbUtf81;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAscii2;
        private System.Windows.Forms.RadioButton rbUtf82;
        private System.Windows.Forms.RadioButton rbHex2;
    }
}

