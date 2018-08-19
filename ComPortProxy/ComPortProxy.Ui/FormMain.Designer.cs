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
            this.btnClear1 = new System.Windows.Forms.Button();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDisabled1 = new System.Windows.Forms.RadioButton();
            this.rbAscii1 = new System.Windows.Forms.RadioButton();
            this.rbHex1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPort1Speed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPort1 = new System.Windows.Forms.ComboBox();
            this.lblPort1to2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbDisabled2 = new System.Windows.Forms.RadioButton();
            this.rbAscii2 = new System.Windows.Forms.RadioButton();
            this.rbHex2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPort2Speed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPort2 = new System.Windows.Forms.ComboBox();
            this.lblPort2to1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(614, 401);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClear1);
            this.groupBox1.Controls.Add(this.txtData1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbPort1Speed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPort1);
            this.groupBox1.Controls.Add(this.lblPort1to2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port 1";
            // 
            // btnClear1
            // 
            this.btnClear1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear1.Location = new System.Drawing.Point(273, 346);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(54, 23);
            this.btnClear1.TabIndex = 14;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // txtData1
            // 
            this.txtData1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData1.Font = new System.Drawing.Font("Ubuntu Mono", 12F);
            this.txtData1.Location = new System.Drawing.Point(6, 107);
            this.txtData1.Multiline = true;
            this.txtData1.Name = "txtData1";
            this.txtData1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData1.Size = new System.Drawing.Size(319, 233);
            this.txtData1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbDisabled1);
            this.panel1.Controls.Add(this.rbAscii1);
            this.panel1.Controls.Add(this.rbHex1);
            this.panel1.Location = new System.Drawing.Point(9, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 23);
            this.panel1.TabIndex = 13;
            // 
            // rbDisabled1
            // 
            this.rbDisabled1.AutoSize = true;
            this.rbDisabled1.Location = new System.Drawing.Point(0, 2);
            this.rbDisabled1.Name = "rbDisabled1";
            this.rbDisabled1.Size = new System.Drawing.Size(66, 17);
            this.rbDisabled1.TabIndex = 10;
            this.rbDisabled1.Text = "Disabled";
            this.rbDisabled1.UseVisualStyleBackColor = true;
            this.rbDisabled1.CheckedChanged += new System.EventHandler(this.rbDisabled1_CheckedChanged);
            // 
            // rbAscii1
            // 
            this.rbAscii1.AutoSize = true;
            this.rbAscii1.Checked = true;
            this.rbAscii1.Location = new System.Drawing.Point(72, 2);
            this.rbAscii1.Name = "rbAscii1";
            this.rbAscii1.Size = new System.Drawing.Size(52, 17);
            this.rbAscii1.TabIndex = 9;
            this.rbAscii1.TabStop = true;
            this.rbAscii1.Text = "ASCII";
            this.rbAscii1.UseVisualStyleBackColor = true;
            this.rbAscii1.CheckedChanged += new System.EventHandler(this.rbAscii1_CheckedChanged);
            // 
            // rbHex1
            // 
            this.rbHex1.AutoSize = true;
            this.rbHex1.Location = new System.Drawing.Point(130, 2);
            this.rbHex1.Name = "rbHex1";
            this.rbHex1.Size = new System.Drawing.Size(47, 17);
            this.rbHex1.TabIndex = 8;
            this.rbHex1.Text = "HEX";
            this.rbHex1.UseVisualStyleBackColor = true;
            this.rbHex1.CheckedChanged += new System.EventHandler(this.rbHex1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Throughput";
            // 
            // cmbPort1Speed
            // 
            this.cmbPort1Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cmbPort1Speed.Location = new System.Drawing.Point(204, 46);
            this.cmbPort1Speed.Name = "cmbPort1Speed";
            this.cmbPort1Speed.Size = new System.Drawing.Size(121, 21);
            this.cmbPort1Speed.TabIndex = 2;
            this.cmbPort1Speed.Text = global::ComPortProxy.Ui.Properties.Settings.Default.cmbPort1Speed;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // cmbPort1
            // 
            this.cmbPort1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPort1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ComPortProxy.Ui.Properties.Settings.Default, "cmbPort1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPort1.FormattingEnabled = true;
            this.cmbPort1.Location = new System.Drawing.Point(204, 19);
            this.cmbPort1.Name = "cmbPort1";
            this.cmbPort1.Size = new System.Drawing.Size(121, 21);
            this.cmbPort1.TabIndex = 0;
            this.cmbPort1.Text = global::ComPortProxy.Ui.Properties.Settings.Default.cmbPort1;
            // 
            // lblPort1to2
            // 
            this.lblPort1to2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort1to2.Location = new System.Drawing.Point(204, 75);
            this.lblPort1to2.Name = "lblPort1to2";
            this.lblPort1to2.Size = new System.Drawing.Size(121, 13);
            this.lblPort1to2.TabIndex = 4;
            this.lblPort1to2.Text = "0 bytes/s";
            this.lblPort1to2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnClear2);
            this.groupBox2.Controls.Add(this.txtData2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbPort2Speed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbPort2);
            this.groupBox2.Controls.Add(this.lblPort2to1);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 375);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port 2";
            // 
            // btnClear2
            // 
            this.btnClear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear2.Location = new System.Drawing.Point(274, 345);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(54, 23);
            this.btnClear2.TabIndex = 15;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtData2
            // 
            this.txtData2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData2.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2.Location = new System.Drawing.Point(6, 107);
            this.txtData2.Multiline = true;
            this.txtData2.Name = "txtData2";
            this.txtData2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData2.Size = new System.Drawing.Size(322, 232);
            this.txtData2.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rbDisabled2);
            this.panel2.Controls.Add(this.rbAscii2);
            this.panel2.Controls.Add(this.rbHex2);
            this.panel2.Location = new System.Drawing.Point(9, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 23);
            this.panel2.TabIndex = 13;
            // 
            // rbDisabled2
            // 
            this.rbDisabled2.AutoSize = true;
            this.rbDisabled2.Location = new System.Drawing.Point(0, 2);
            this.rbDisabled2.Name = "rbDisabled2";
            this.rbDisabled2.Size = new System.Drawing.Size(66, 17);
            this.rbDisabled2.TabIndex = 11;
            this.rbDisabled2.Text = "Disabled";
            this.rbDisabled2.UseVisualStyleBackColor = true;
            this.rbDisabled2.CheckedChanged += new System.EventHandler(this.rbDisabled2_CheckedChanged);
            // 
            // rbAscii2
            // 
            this.rbAscii2.AutoSize = true;
            this.rbAscii2.Checked = true;
            this.rbAscii2.Location = new System.Drawing.Point(72, 2);
            this.rbAscii2.Name = "rbAscii2";
            this.rbAscii2.Size = new System.Drawing.Size(52, 17);
            this.rbAscii2.TabIndex = 9;
            this.rbAscii2.TabStop = true;
            this.rbAscii2.Text = "ASCII";
            this.rbAscii2.UseVisualStyleBackColor = true;
            this.rbAscii2.CheckedChanged += new System.EventHandler(this.rbAscii2_CheckedChanged);
            // 
            // rbHex2
            // 
            this.rbHex2.AutoSize = true;
            this.rbHex2.Location = new System.Drawing.Point(130, 2);
            this.rbHex2.Name = "rbHex2";
            this.rbHex2.Size = new System.Drawing.Size(47, 17);
            this.rbHex2.TabIndex = 8;
            this.rbHex2.Text = "HEX";
            this.rbHex2.UseVisualStyleBackColor = true;
            this.rbHex2.CheckedChanged += new System.EventHandler(this.rbHex2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Throughput";
            // 
            // cmbPort2Speed
            // 
            this.cmbPort2Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cmbPort2Speed.Location = new System.Drawing.Point(207, 46);
            this.cmbPort2Speed.Name = "cmbPort2Speed";
            this.cmbPort2Speed.Size = new System.Drawing.Size(121, 21);
            this.cmbPort2Speed.TabIndex = 2;
            this.cmbPort2Speed.Text = global::ComPortProxy.Ui.Properties.Settings.Default.cmbPort2Speed;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
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
            // cmbPort2
            // 
            this.cmbPort2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPort2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ComPortProxy.Ui.Properties.Settings.Default, "cmbPort2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPort2.FormattingEnabled = true;
            this.cmbPort2.Location = new System.Drawing.Point(207, 19);
            this.cmbPort2.Name = "cmbPort2";
            this.cmbPort2.Size = new System.Drawing.Size(121, 21);
            this.cmbPort2.TabIndex = 0;
            this.cmbPort2.Text = global::ComPortProxy.Ui.Properties.Settings.Default.cmbPort2;
            // 
            // lblPort2to1
            // 
            this.lblPort2to1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort2to1.Location = new System.Drawing.Point(207, 75);
            this.lblPort2to1.Name = "lblPort2to1";
            this.lblPort2to1.Size = new System.Drawing.Size(121, 13);
            this.lblPort2to1.TabIndex = 5;
            this.lblPort2to1.Text = "0 bytes/s";
            this.lblPort2to1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(528, 401);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(80, 23);
            this.btnDisconnect.TabIndex = 12;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(685, 381);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 431);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "FormMain";
            this.Text = "Com Port Proxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAscii1;
        private System.Windows.Forms.RadioButton rbHex1;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAscii2;
        private System.Windows.Forms.RadioButton rbHex2;
        private System.Windows.Forms.RadioButton rbDisabled1;
        private System.Windows.Forms.RadioButton rbDisabled2;
    }
}

