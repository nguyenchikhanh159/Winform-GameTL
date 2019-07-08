/*
 * Created by SharpDevelop.
 * User: yabeow
 * Date: 30/03/2018
 * Time: 2:02 CH
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Telnet
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public class ServerListen {
		public String host;
		public int port;
		public String username;
		public String password;
		public ServerListen(String host, int port, String username, String password) {
			this.host = host;
			this.port = port;
			this.username = username;
			this.password = password;
		}
	}
	public partial class MainForm : Form
	{
		private TcpListener Server = null;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.buttonListen.Click += new EventHandler(this.onListenClick);
			this.buttonStop.Click += new EventHandler(this.onDisconnectClick);
		}
		private void listenServer(object sv) {
			var server = (ServerListen)sv;
			IPAddress ipaddr = IPAddress.Parse(server.host);
			this.Server = new TcpListener(ipaddr, server.port);
			// Start listening for client requests.
			this.Server.Start();

			// Buffer for reading data
			var bytes = new Byte[1024];
			String data = null;
			try {
				while (true)
				{
					TcpClient client = this.Server.AcceptTcpClient();

					data = null;
					NetworkStream stream = client.GetStream();
					var reader = new StreamReader(stream);
					var writer = new StreamWriter(stream);
					writer.AutoFlush = true;
					const String WelcomeMessage = "Telnet Server [version 1.0.0]\nCopyright Yabeow. All rights reserved.";
					writer.WriteLine(WelcomeMessage);
					const String IntroMessage = "Login with command USER {username_here} and then PASS {password_here}";
					writer.WriteLine(IntroMessage);
					writer.WriteLine("END");
					int i;
					bool loggedIn = false;
					String usernameInput = "";
					while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
					{
						// Translate data bytes to a ASCII string.
						data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
						// Process the data sent by the client.
						data = data.ToUpper().Trim();
						if (loggedIn == false) {
							if (data.Length < 4) {
								writer.WriteLine(IntroMessage);
								writer.WriteLine("END");
							}
							else if (usernameInput == "") {
								if (data.Substring(0, 4) == "USER") {
									usernameInput = data.Substring(4, data.Length - 4).Trim();
									writer.WriteLine("Password for user " + usernameInput);
									writer.WriteLine("END");
								}
								else {
									writer.WriteLine(IntroMessage);
									writer.WriteLine("END");
								}
							}
							else {
								if (data.Substring(0, 4) == "PASS") {
									String passwordInput = data.Substring(4, data.Length - 4).Trim();
									if ((passwordInput == server.password) && (usernameInput == server.username)) {
										writer.WriteLine("Access granted as user " + inputUsername.Text);
										writer.WriteLine("END");
										loggedIn = true;
									}
									else {
										usernameInput = "";
										writer.WriteLine("Wrong username or password. Please try again.");
										writer.WriteLine("END");
									}
								}
								else {
									usernameInput = "";
									writer.WriteLine(IntroMessage);
									writer.WriteLine("END");
								}
							}
						}
						else {
							if (data == "LOGOUT") {
								loggedIn = false;
								usernameInput = "";
								writer.WriteLine("Logout successful!");
								writer.WriteLine("END");
							}
							else {
								var process = new System.Diagnostics.Process();
								var startInfo = new System.Diagnostics.ProcessStartInfo();
								startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
								startInfo.FileName = "cmd.exe";
								startInfo.Arguments = "/c " + data;
								startInfo.RedirectStandardOutput = true;
								startInfo.UseShellExecute = false;
								process.StartInfo = startInfo;
								process.Start();
								writer.WriteLine(process.StandardOutput.ReadToEnd());
								writer.WriteLine("END");
								process.Close();
							}
						}
					}
					// Shutdown and end connection
					client.Close();
				}
			}
			catch (SocketException error)
			{
				Console.WriteLine("SocketException: {0}", error);
			}
			finally
			{
				// Stop listening for new clients.
				this.Server.Stop();
			}
		}
		public void onListenClick(object sender, EventArgs e) {
			String host = this.inputAddress.Text;
			int port = Int32.Parse(this.inputPort.Text);
			String username = this.inputUsername.Text;
			String password = this.inputPassword.Text;
			this.inputAddress.ReadOnly = true;
			this.inputPort.ReadOnly = true;
			this.inputUsername.ReadOnly = true;
			this.inputPassword.ReadOnly = true;
			var listenThread = new Thread(this.listenServer);
			listenThread.Start(new ServerListen(host, port, username, password));
		}
		public void onDisconnectClick(object sender, EventArgs e) {
			if (this.Server != null) {
				Server.Stop();
				this.inputAddress.ReadOnly = false;
				this.inputPort.ReadOnly = false;
				this.inputUsername.ReadOnly = false;
				this.inputPassword.ReadOnly = false;
			}
		}
	}
}
