namespace ArduinoSerialGUI
{
    partial class ArduinoSerialGUI
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.data1_trkbar = new System.Windows.Forms.TrackBar();
            this.data1_txtbox = new System.Windows.Forms.TextBox();
            this.data2_txtbox = new System.Windows.Forms.TextBox();
            this.mode_cbbox = new System.Windows.Forms.ComboBox();
            this.data3_txtbox = new System.Windows.Forms.TextBox();
            this.code_txtbox = new System.Windows.Forms.TextBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.receive_txtbox = new System.Windows.Forms.TextBox();
            this.com_cbbox = new System.Windows.Forms.ComboBox();
            this.speed_cbbox = new System.Windows.Forms.ComboBox();
            this.com_lbl = new System.Windows.Forms.Label();
            this.speed_lbl = new System.Windows.Forms.Label();
            this.mode_lbl = new System.Windows.Forms.Label();
            this.data1_lbl = new System.Windows.Forms.Label();
            this.data2_lbl = new System.Windows.Forms.Label();
            this.data3_lbl = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.code_lbl = new System.Windows.Forms.Label();
            this.data2_trkbar = new System.Windows.Forms.TrackBar();
            this.data3_trkbar = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data1_trkbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2_trkbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data3_trkbar)).BeginInit();
            this.SuspendLayout();
            // 
            // data1_trkbar
            // 
            this.data1_trkbar.LargeChange = 1;
            this.data1_trkbar.Location = new System.Drawing.Point(120, 148);
            this.data1_trkbar.Margin = new System.Windows.Forms.Padding(2);
            this.data1_trkbar.Maximum = 2000;
            this.data1_trkbar.Minimum = -2000;
            this.data1_trkbar.Name = "data1_trkbar";
            this.data1_trkbar.Size = new System.Drawing.Size(170, 45);
            this.data1_trkbar.TabIndex = 0;
            this.data1_trkbar.Scroll += new System.EventHandler(this.data1_trkbar_Scroll);
            // 
            // data1_txtbox
            // 
            this.data1_txtbox.Location = new System.Drawing.Point(29, 148);
            this.data1_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.data1_txtbox.Name = "data1_txtbox";
            this.data1_txtbox.Size = new System.Drawing.Size(62, 19);
            this.data1_txtbox.TabIndex = 1;
            // 
            // data2_txtbox
            // 
            this.data2_txtbox.Location = new System.Drawing.Point(29, 192);
            this.data2_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.data2_txtbox.Name = "data2_txtbox";
            this.data2_txtbox.Size = new System.Drawing.Size(62, 19);
            this.data2_txtbox.TabIndex = 3;
            // 
            // mode_cbbox
            // 
            this.mode_cbbox.FormattingEnabled = true;
            this.mode_cbbox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.mode_cbbox.Location = new System.Drawing.Point(29, 98);
            this.mode_cbbox.Margin = new System.Windows.Forms.Padding(2);
            this.mode_cbbox.Name = "mode_cbbox";
            this.mode_cbbox.Size = new System.Drawing.Size(62, 20);
            this.mode_cbbox.TabIndex = 4;
            this.mode_cbbox.Text = "1";
            this.mode_cbbox.SelectedIndexChanged += new System.EventHandler(this.mode_cbbox_SelectedIndexChanged);
            // 
            // data3_txtbox
            // 
            this.data3_txtbox.Location = new System.Drawing.Point(29, 239);
            this.data3_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.data3_txtbox.Name = "data3_txtbox";
            this.data3_txtbox.Size = new System.Drawing.Size(62, 19);
            this.data3_txtbox.TabIndex = 6;
            // 
            // code_txtbox
            // 
            this.code_txtbox.Location = new System.Drawing.Point(29, 292);
            this.code_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.code_txtbox.Name = "code_txtbox";
            this.code_txtbox.Size = new System.Drawing.Size(125, 19);
            this.code_txtbox.TabIndex = 7;
            this.code_txtbox.Text = "1000000000000000";
            this.code_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Red;
            this.stop_btn.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stop_btn.Location = new System.Drawing.Point(183, 332);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(2);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(145, 75);
            this.stop_btn.TabIndex = 8;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // receive_txtbox
            // 
            this.receive_txtbox.BackColor = System.Drawing.Color.Black;
            this.receive_txtbox.ForeColor = System.Drawing.Color.Lime;
            this.receive_txtbox.Location = new System.Drawing.Point(354, 20);
            this.receive_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.receive_txtbox.Multiline = true;
            this.receive_txtbox.Name = "receive_txtbox";
            this.receive_txtbox.ReadOnly = true;
            this.receive_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.receive_txtbox.Size = new System.Drawing.Size(236, 395);
            this.receive_txtbox.TabIndex = 9;
            // 
            // com_cbbox
            // 
            this.com_cbbox.FormattingEnabled = true;
            this.com_cbbox.Location = new System.Drawing.Point(29, 36);
            this.com_cbbox.Margin = new System.Windows.Forms.Padding(2);
            this.com_cbbox.Name = "com_cbbox";
            this.com_cbbox.Size = new System.Drawing.Size(74, 20);
            this.com_cbbox.TabIndex = 10;
            this.com_cbbox.Text = "4";
            // 
            // speed_cbbox
            // 
            this.speed_cbbox.FormattingEnabled = true;
            this.speed_cbbox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.speed_cbbox.Location = new System.Drawing.Point(120, 36);
            this.speed_cbbox.Margin = new System.Windows.Forms.Padding(2);
            this.speed_cbbox.Name = "speed_cbbox";
            this.speed_cbbox.Size = new System.Drawing.Size(74, 20);
            this.speed_cbbox.TabIndex = 11;
            this.speed_cbbox.Text = "9600";
            // 
            // com_lbl
            // 
            this.com_lbl.AutoSize = true;
            this.com_lbl.Location = new System.Drawing.Point(29, 20);
            this.com_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.com_lbl.Name = "com_lbl";
            this.com_lbl.Size = new System.Drawing.Size(30, 12);
            this.com_lbl.TabIndex = 12;
            this.com_lbl.Text = "COM";
            // 
            // speed_lbl
            // 
            this.speed_lbl.AutoSize = true;
            this.speed_lbl.Location = new System.Drawing.Point(118, 20);
            this.speed_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_lbl.Name = "speed_lbl";
            this.speed_lbl.Size = new System.Drawing.Size(36, 12);
            this.speed_lbl.TabIndex = 13;
            this.speed_lbl.Text = "Speed";
            // 
            // mode_lbl
            // 
            this.mode_lbl.AutoSize = true;
            this.mode_lbl.Location = new System.Drawing.Point(29, 84);
            this.mode_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mode_lbl.Name = "mode_lbl";
            this.mode_lbl.Size = new System.Drawing.Size(32, 12);
            this.mode_lbl.TabIndex = 14;
            this.mode_lbl.Text = "mode";
            // 
            // data1_lbl
            // 
            this.data1_lbl.AutoSize = true;
            this.data1_lbl.Location = new System.Drawing.Point(29, 134);
            this.data1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data1_lbl.Name = "data1_lbl";
            this.data1_lbl.Size = new System.Drawing.Size(33, 12);
            this.data1_lbl.TabIndex = 15;
            this.data1_lbl.Text = "data1";
            // 
            // data2_lbl
            // 
            this.data2_lbl.AutoSize = true;
            this.data2_lbl.Location = new System.Drawing.Point(29, 178);
            this.data2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data2_lbl.Name = "data2_lbl";
            this.data2_lbl.Size = new System.Drawing.Size(33, 12);
            this.data2_lbl.TabIndex = 16;
            this.data2_lbl.Text = "data2";
            // 
            // data3_lbl
            // 
            this.data3_lbl.AutoSize = true;
            this.data3_lbl.Location = new System.Drawing.Point(29, 226);
            this.data3_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data3_lbl.Name = "data3_lbl";
            this.data3_lbl.Size = new System.Drawing.Size(33, 12);
            this.data3_lbl.TabIndex = 17;
            this.data3_lbl.Text = "data3";
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(28, 332);
            this.send_btn.Margin = new System.Windows.Forms.Padding(2);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(143, 75);
            this.send_btn.TabIndex = 18;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(223, 29);
            this.connect_btn.Margin = new System.Windows.Forms.Padding(2);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(93, 29);
            this.connect_btn.TabIndex = 19;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // code_lbl
            // 
            this.code_lbl.AutoSize = true;
            this.code_lbl.Location = new System.Drawing.Point(29, 278);
            this.code_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.code_lbl.Name = "code_lbl";
            this.code_lbl.Size = new System.Drawing.Size(29, 12);
            this.code_lbl.TabIndex = 20;
            this.code_lbl.Text = "code";
            // 
            // data2_trkbar
            // 
            this.data2_trkbar.LargeChange = 1;
            this.data2_trkbar.Location = new System.Drawing.Point(120, 192);
            this.data2_trkbar.Margin = new System.Windows.Forms.Padding(2);
            this.data2_trkbar.Maximum = 2000;
            this.data2_trkbar.Minimum = -2000;
            this.data2_trkbar.Name = "data2_trkbar";
            this.data2_trkbar.Size = new System.Drawing.Size(170, 45);
            this.data2_trkbar.TabIndex = 21;
            this.data2_trkbar.Scroll += new System.EventHandler(this.data2_trkbar_Scroll);
            // 
            // data3_trkbar
            // 
            this.data3_trkbar.LargeChange = 1;
            this.data3_trkbar.Location = new System.Drawing.Point(120, 239);
            this.data3_trkbar.Margin = new System.Windows.Forms.Padding(2);
            this.data3_trkbar.Maximum = 9999;
            this.data3_trkbar.Name = "data3_trkbar";
            this.data3_trkbar.Size = new System.Drawing.Size(170, 45);
            this.data3_trkbar.TabIndex = 22;
            this.data3_trkbar.Scroll += new System.EventHandler(this.data3_trkbar_Scroll);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ArduinoSerialGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 422);
            this.Controls.Add(this.data3_trkbar);
            this.Controls.Add(this.data2_trkbar);
            this.Controls.Add(this.code_lbl);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.data3_lbl);
            this.Controls.Add(this.data2_lbl);
            this.Controls.Add(this.data1_lbl);
            this.Controls.Add(this.mode_lbl);
            this.Controls.Add(this.speed_lbl);
            this.Controls.Add(this.com_lbl);
            this.Controls.Add(this.speed_cbbox);
            this.Controls.Add(this.com_cbbox);
            this.Controls.Add(this.receive_txtbox);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.code_txtbox);
            this.Controls.Add(this.data3_txtbox);
            this.Controls.Add(this.mode_cbbox);
            this.Controls.Add(this.data2_txtbox);
            this.Controls.Add(this.data1_txtbox);
            this.Controls.Add(this.data1_trkbar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArduinoSerialGUI";
            this.Text = "Arduino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArduinoSerialGUI_FormClosed);
            this.Load += new System.EventHandler(this.ArduinoSerialGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1_trkbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2_trkbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data3_trkbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar data1_trkbar;
        private System.Windows.Forms.TextBox data1_txtbox;
        private System.Windows.Forms.TextBox data2_txtbox;
        private System.Windows.Forms.ComboBox mode_cbbox;
        private System.Windows.Forms.TextBox data3_txtbox;
        private System.Windows.Forms.TextBox code_txtbox;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.TextBox receive_txtbox;
        private System.Windows.Forms.ComboBox com_cbbox;
        private System.Windows.Forms.ComboBox speed_cbbox;
        private System.Windows.Forms.Label com_lbl;
        private System.Windows.Forms.Label speed_lbl;
        private System.Windows.Forms.Label mode_lbl;
        private System.Windows.Forms.Label data1_lbl;
        private System.Windows.Forms.Label data2_lbl;
        private System.Windows.Forms.Label data3_lbl;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label code_lbl;
        private System.Windows.Forms.TrackBar data2_trkbar;
        private System.Windows.Forms.TrackBar data3_trkbar;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

