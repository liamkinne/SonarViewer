/*
 * Created by SharpDevelop.
 * User: shogwood
 * Date: 25/10/2017
 * Time: 12:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sonarLidar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnClosePort;
		private System.Windows.Forms.Button btnFindPorts;
		private System.Windows.Forms.Button btnOpenPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox lbBaudRate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox lbComPort;
		private System.Windows.Forms.RichTextBox txtFeedback;
		private System.Windows.Forms.Panel indConnect;
		private System.IO.Ports.SerialPort comPort;
		private System.Windows.Forms.PictureBox pbxDraw;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnClosePort = new System.Windows.Forms.Button();
			this.btnFindPorts = new System.Windows.Forms.Button();
			this.btnOpenPort = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lbBaudRate = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbComPort = new System.Windows.Forms.ComboBox();
			this.txtFeedback = new System.Windows.Forms.RichTextBox();
			this.indConnect = new System.Windows.Forms.Panel();
			this.comPort = new System.IO.Ports.SerialPort(this.components);
			this.pbxDraw = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxDraw)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClosePort
			// 
			this.btnClosePort.Location = new System.Drawing.Point(508, 573);
			this.btnClosePort.Name = "btnClosePort";
			this.btnClosePort.Size = new System.Drawing.Size(93, 23);
			this.btnClosePort.TabIndex = 35;
			this.btnClosePort.Text = "Close Port";
			this.btnClosePort.UseVisualStyleBackColor = true;
			this.btnClosePort.Click += new System.EventHandler(this.btnClosePortClick);
			// 
			// btnFindPorts
			// 
			this.btnFindPorts.Location = new System.Drawing.Point(508, 474);
			this.btnFindPorts.Name = "btnFindPorts";
			this.btnFindPorts.Size = new System.Drawing.Size(93, 23);
			this.btnFindPorts.TabIndex = 34;
			this.btnFindPorts.Text = "Scan Ports";
			this.btnFindPorts.UseVisualStyleBackColor = true;
			this.btnFindPorts.Click += new System.EventHandler(this.btnFindPortsClick);
			// 
			// btnOpenPort
			// 
			this.btnOpenPort.Location = new System.Drawing.Point(508, 544);
			this.btnOpenPort.Name = "btnOpenPort";
			this.btnOpenPort.Size = new System.Drawing.Size(93, 23);
			this.btnOpenPort.TabIndex = 33;
			this.btnOpenPort.Text = "Open Port";
			this.btnOpenPort.UseVisualStyleBackColor = true;
			this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPortClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(444, 506);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 18);
			this.label4.TabIndex = 32;
			this.label4.Text = "Baud Rate";
			// 
			// lbBaudRate
			// 
			this.lbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lbBaudRate.FormattingEnabled = true;
			this.lbBaudRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbBaudRate.Items.AddRange(new object[] {
			"9600",
			"19200",
			"38400",
			"57600"});
			this.lbBaudRate.Location = new System.Drawing.Point(508, 503);
			this.lbBaudRate.Name = "lbBaudRate";
			this.lbBaudRate.Size = new System.Drawing.Size(121, 21);
			this.lbBaudRate.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(444, 450);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 18);
			this.label3.TabIndex = 30;
			this.label3.Text = "Com Port";
			// 
			// lbComPort
			// 
			this.lbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lbComPort.FormattingEnabled = true;
			this.lbComPort.Location = new System.Drawing.Point(508, 447);
			this.lbComPort.Name = "lbComPort";
			this.lbComPort.Size = new System.Drawing.Size(121, 21);
			this.lbComPort.TabIndex = 29;
			// 
			// txtFeedback
			// 
			this.txtFeedback.Location = new System.Drawing.Point(12, 447);
			this.txtFeedback.Name = "txtFeedback";
			this.txtFeedback.ReadOnly = true;
			this.txtFeedback.Size = new System.Drawing.Size(412, 163);
			this.txtFeedback.TabIndex = 36;
			this.txtFeedback.Text = "";
			// 
			// indConnect
			// 
			this.indConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.indConnect.Enabled = false;
			this.indConnect.Location = new System.Drawing.Point(607, 561);
			this.indConnect.Name = "indConnect";
			this.indConnect.Size = new System.Drawing.Size(16, 16);
			this.indConnect.TabIndex = 37;
			// 
			// comPort
			// 
			this.comPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ComPortDataReceived);
			// 
			// pbxDraw
			// 
			this.pbxDraw.BackColor = System.Drawing.Color.Black;
			this.pbxDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxDraw.Location = new System.Drawing.Point(12, 12);
			this.pbxDraw.Name = "pbxDraw";
			this.pbxDraw.Size = new System.Drawing.Size(616, 429);
			this.pbxDraw.TabIndex = 38;
			this.pbxDraw.TabStop = false;
			this.pbxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PbxDrawPaint);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 622);
			this.Controls.Add(this.pbxDraw);
			this.Controls.Add(this.indConnect);
			this.Controls.Add(this.txtFeedback);
			this.Controls.Add(this.btnClosePort);
			this.Controls.Add(this.btnFindPorts);
			this.Controls.Add(this.btnOpenPort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbBaudRate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbComPort);
			this.Name = "MainForm";
			this.Text = "sonarLidar";
			((System.ComponentModel.ISupportInitialize)(this.pbxDraw)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
