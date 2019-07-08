/*
 * Created by SharpDevelop.
 * User: yabeow
 * Date: 31/03/2018
 * Time: 3:02 CH
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Collections.Concurrent;

namespace Client
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public class ServerConnect {
		public String host;
		public int port;
		public ServerConnect(String host, int port) {
			this.host = host;
			this.port = port;
		}
	}
	public partial class MainForm : Form
	{
		private TcpClient Client = null;
		private readonly ConcurrentQueue<String> _queue = new ConcurrentQueue<String>();
		private readonly AutoResetEvent _signal = new AutoResetEvent(false);
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.buttonConnect.Click += new EventHandler(this.onConnectClick);
			this.buttonSend.Click += new EventHandler(this.onSendClick);
			this.buttonStop.Click += new EventHandler(this.onDisconnectClick);
		}
		delegate String GetMyTextDelegate(Control ctrl);
		delegate void ChangeMyTextDelegate(TextBox ctrl, string text);
		public static String GetMyText(Control ctrl) {
			if (ctrl.InvokeRequired)
			{
				var del = new GetMyTextDelegate(GetMyText);
				ctrl.Invoke(del, ctrl);
				return "";
			}
			else
			{
				return ctrl.Text;
			}
		}
		public static void ChangeMyText(TextBox ctrl, string text)
		{
			if (ctrl.InvokeRequired)
			{
				var del = new ChangeMyTextDelegate(ChangeMyText);
				ctrl.Invoke(del, ctrl, text);
			}
			else
			{
				ctrl.AppendText(text);
			}
		}
		
		private void connectServer(object sv) {
			try {
				var server = (ServerConnect)sv;
				this.Client = new TcpClient(server.host, server.port);
				NetworkStream stream = this.Client.GetStream();
				var reader = new StreamReader(stream);
				var writer = new StreamWriter(stream);
				writer.AutoFlush = true;
				var line = "";
				while((line = reader.ReadLine()) != "END") {
					line += "\r\n";
					ChangeMyText(this.commandResult, line);	
				}
				while (true)
				{
					_signal.WaitOne();
					String item = null;
			        while (_queue.TryDequeue(out item))
			        {
			        	line = item + "\r\n";
			        	ChangeMyText(this.commandResult, "You: " + line);
			        	writer.Write(item);
			        }
			        while((line = reader.ReadLine()) != "END") {
						line += "\r\n";
						ChangeMyText(this.commandResult, line);	
					}
				}
			}
			catch(Exception e) {
				MessageBox.Show(e.ToString());
			}
			finally {
				this.Client.Close();
			}
		}
		public void onConnectClick(object sender, EventArgs e) {
			String host = this.inputAddress.Text;
			int port = Int32.Parse(this.inputPort.Text);
			var connectThread = new Thread(this.connectServer);
			connectThread.Start(new ServerConnect(host, port));
			this.inputAddress.ReadOnly = true;
			this.inputPort.ReadOnly = true;
			this.inputCommand.ReadOnly = false;
		}
		public void onSendClick(object sender, EventArgs e) {
			String command = this.inputCommand.Text;
			this.inputCommand.Text = "";
			_queue.Enqueue(command);
        	_signal.Set();
		}
		public void onDisconnectClick(object sender, EventArgs e) {
			if (this.Client != null) {
				this.Client.Close();
				this.inputAddress.ReadOnly = false;
				this.inputPort.ReadOnly = false;
			}
		}
	}
}