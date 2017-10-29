/*
 * Created By: Simon Hogwood
 * Date: 25/10/2017
 * Time: 12:27 PM
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace sonarLidar {
public partial class MainForm : Form {
	bool numsReset = false;
	int[] nums;

	public MainForm() {
		//
		// The InitializeComponent() call is required for Windows Forms designer support.
		//
		InitializeComponent();
			
		//
		// TODO: Add constructor code after the InitializeComponent() call.
		//
			
		btnFindPortsClick(this, null);
		lbBaudRate.SelectedIndex = 0;			

		RichTextBox.CheckForIllegalCrossThreadCalls = false;
	}
	
	
	// =======================================================================
	// Main Form Functions
	// =======================================================================

	void MainFormFormClosing(object sender, FormClosingEventArgs e) {
		if (comPort.IsOpen)
			comPort.Close();
	}
		
	
	// =======================================================================
	// Utility Functions
	// =======================================================================

	void writeFeedback(string text) {
		txtFeedback.SelectionStart = 0;
		txtFeedback.SelectedText = text + '\n';
	}
		
		
	bool comPortOpen() {
		if (comPort.IsOpen)
			return true;
		writeFeedback("Com Port Closed...");
		return false;
	}

	// =======================================================================
	// Com Port Functions
	// =======================================================================
		
	void btnFindPortsClick(object sender, EventArgs e) {
		string[] ports = SerialPort.GetPortNames();
		if (ports.Length == 0) {
			writeFeedback("No Valid Comm Ports");
			return;
		}
		// load available com ports into list
		lbComPort.Items.Clear();
		foreach (string port in ports) {
			lbComPort.Items.Add(port);
		}
		// set list display to the first port
		lbComPort.SelectedIndex = 0;
	}

		
	void btnOpenPortClick(object sender, EventArgs e) {
		// set com port
		comPort.PortName = lbComPort.SelectedItem.ToString();
		// set baud rate
		int baud = 0;
		if (Int32.TryParse(lbBaudRate.SelectedItem.ToString(), out baud)) {
			// conversion successful
			comPort.BaudRate = baud;
		}
		// open port and change the indicator
		comPort.Open();
		indConnect.BackColor = Color.FromArgb(0, 192, 0); // green
		writeFeedback("Opened: " + comPort.PortName + " at " + comPort.BaudRate + " buad.");
	}
		
		
	void btnClosePortClick(object sender, EventArgs e) {
		// close port and change the indicator
		comPort.Close();
		indConnect.BackColor = Color.FromArgb(192, 0, 0); // red
		writeFeedback("Closed: " + comPort.PortName);
	}
	
		
	void ComPortDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
		// cast the sender back to a serial port object
		var sp = (SerialPort)sender;

		// read a line (until crlf)
		string textData = sp.ReadLine();
			
		// look for our data control bytes
		if (textData[0] != '!') return;

			
		// SubString
		int endIdx = textData.LastIndexOf('\r');   
		if(endIdx >= 0) {
			string tmp = textData.Substring(2, endIdx - 1); // ignore control byte
			writeFeedback(tmp);

			// convert to numbers
			try {
				nums = Array.ConvertAll(tmp.Split(','), int.Parse);
		
				numsReset = true;
				pbxDraw.Invalidate();
			}
		
			catch(FormatException fe) { numsReset = false; }
		}
		else numsReset = false;
			
		//string[] numStrs = tmp.Split(',');
			
			
		/*
		Int32[] cmd = new Int32[255];
		string cmdData = "";
		int count = sp.BytesToRead;

		for(int i=0; i<count; ++i)
			{
			cmd[i] = sp.ReadByte();
			// write byte to feedback textbox
			cmdData += Convert.ToByte(cmd[i]) + ", ";
			}
		txtFeedBack.AppendText(cmdData + "\n");
		*/
	 
	}
	
	
	// =======================================================================
	// Draw to the picturebox
	// =======================================================================

	readonly Pen greenPen = new Pen(Color.Green, 2);    
	readonly Pen yellowPen = new Pen(Color.Yellow, 2);    
	readonly Pen redPen = new Pen(Color.Red, 2);    
	
	void PbxDrawPaint(object sender, PaintEventArgs e) {
		// draw rest of the stuff
		if(numsReset) {
			for (int i = 0; i < nums.Length; i += 2) {
				e.Graphics.DrawEllipse (yellowPen, nums [i] + pbxDraw.Width / 2, -nums [i + 1] + pbxDraw.Height / 2, 5, 5);
			}
		}
		// draw center dot     
		e.Graphics.DrawEllipse(greenPen, pbxDraw.Width/2, pbxDraw.Height/2, 10, 10);
	}
}
}

