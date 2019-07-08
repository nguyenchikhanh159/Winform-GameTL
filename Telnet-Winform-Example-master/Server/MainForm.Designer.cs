/*
 * Created by SharpDevelop.
 * User: yabeow
 * Date: 30/03/2018
 * Time: 2:02 CH
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Telnet
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox inputPort;
		private System.Windows.Forms.TextBox inputAddress;
		private System.Windows.Forms.GroupBox groupInput;
		private System.Windows.Forms.TextBox inputPassword;
		private System.Windows.Forms.TextBox inputUsername;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupAction;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonListen;
		
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
			this.inputPort = new System.Windows.Forms.TextBox();
			this.inputAddress = new System.Windows.Forms.TextBox();
			this.groupInput = new System.Windows.Forms.GroupBox();
			this.inputPassword = new System.Windows.Forms.TextBox();
			this.inputUsername = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupAction = new System.Windows.Forms.GroupBox();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonListen = new System.Windows.Forms.Button();
			this.groupInput.SuspendLayout();
			this.groupAction.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputPort
			// 
			this.inputPort.Location = new System.Drawing.Point(126, 61);
			this.inputPort.Name = "inputPort";
			this.inputPort.Size = new System.Drawing.Size(111, 22);
			this.inputPort.TabIndex = 0;
			this.inputPort.Text = "1337";
			// 
			// inputAddress
			// 
			this.inputAddress.Location = new System.Drawing.Point(126, 21);
			this.inputAddress.Name = "inputAddress";
			this.inputAddress.Size = new System.Drawing.Size(111, 22);
			this.inputAddress.TabIndex = 1;
			this.inputAddress.Text = "127.0.0.1";
			// 
			// groupInput
			// 
			this.groupInput.Controls.Add(this.inputPassword);
			this.groupInput.Controls.Add(this.inputUsername);
			this.groupInput.Controls.Add(this.label4);
			this.groupInput.Controls.Add(this.label3);
			this.groupInput.Controls.Add(this.label2);
			this.groupInput.Controls.Add(this.label1);
			this.groupInput.Controls.Add(this.inputAddress);
			this.groupInput.Controls.Add(this.inputPort);
			this.groupInput.Location = new System.Drawing.Point(12, 12);
			this.groupInput.Name = "groupInput";
			this.groupInput.Size = new System.Drawing.Size(258, 190);
			this.groupInput.TabIndex = 2;
			this.groupInput.TabStop = false;
			this.groupInput.Text = "Server Information";
			// 
			// inputPassword
			// 
			this.inputPassword.Location = new System.Drawing.Point(126, 150);
			this.inputPassword.Name = "inputPassword";
			this.inputPassword.Size = new System.Drawing.Size(111, 22);
			this.inputPassword.TabIndex = 7;
			this.inputPassword.Text = "ADMIN";
			// 
			// inputUsername
			// 
			this.inputUsername.Location = new System.Drawing.Point(126, 106);
			this.inputUsername.Name = "inputUsername";
			this.inputUsername.Size = new System.Drawing.Size(111, 22);
			this.inputUsername.TabIndex = 6;
			this.inputUsername.Text = "ADMIN";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(20, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Username";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Port";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Address";
			// 
			// groupAction
			// 
			this.groupAction.Controls.Add(this.buttonStop);
			this.groupAction.Controls.Add(this.buttonListen);
			this.groupAction.Location = new System.Drawing.Point(12, 228);
			this.groupAction.Name = "groupAction";
			this.groupAction.Size = new System.Drawing.Size(258, 100);
			this.groupAction.TabIndex = 3;
			this.groupAction.TabStop = false;
			this.groupAction.Text = "Action";
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(137, 33);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(115, 45);
			this.buttonStop.TabIndex = 1;
			this.buttonStop.Text = "Disconnect";
			this.buttonStop.UseVisualStyleBackColor = true;
			// 
			// buttonListen
			// 
			this.buttonListen.Location = new System.Drawing.Point(6, 33);
			this.buttonListen.Name = "buttonListen";
			this.buttonListen.Size = new System.Drawing.Size(114, 45);
			this.buttonListen.TabIndex = 0;
			this.buttonListen.Text = "Listen";
			this.buttonListen.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 340);
			this.Controls.Add(this.groupAction);
			this.Controls.Add(this.groupInput);
			this.Name = "MainForm";
			this.Text = "Telnet Server";
			this.groupInput.ResumeLayout(false);
			this.groupInput.PerformLayout();
			this.groupAction.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
