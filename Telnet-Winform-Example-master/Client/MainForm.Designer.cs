/*
 * Created by SharpDevelop.
 * User: yabeow
 * Date: 30/03/2018
 * Time: 2:02 CH
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Client
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupAction;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.GroupBox groupCommand;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.TextBox inputCommand;
		private System.Windows.Forms.TextBox commandResult;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupAction = new System.Windows.Forms.GroupBox();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.groupCommand = new System.Windows.Forms.GroupBox();
			this.commandResult = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.inputCommand = new System.Windows.Forms.TextBox();
			this.groupInput.SuspendLayout();
			this.groupAction.SuspendLayout();
			this.groupCommand.SuspendLayout();
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
			this.groupInput.Controls.Add(this.label2);
			this.groupInput.Controls.Add(this.label1);
			this.groupInput.Controls.Add(this.inputAddress);
			this.groupInput.Controls.Add(this.inputPort);
			this.groupInput.Location = new System.Drawing.Point(12, 12);
			this.groupInput.Name = "groupInput";
			this.groupInput.Size = new System.Drawing.Size(258, 95);
			this.groupInput.TabIndex = 2;
			this.groupInput.TabStop = false;
			this.groupInput.Text = "Connect Information";
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
			this.groupAction.Controls.Add(this.buttonConnect);
			this.groupAction.Location = new System.Drawing.Point(12, 113);
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
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(6, 33);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(114, 45);
			this.buttonConnect.TabIndex = 0;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			// 
			// groupCommand
			// 
			this.groupCommand.Controls.Add(this.commandResult);
			this.groupCommand.Controls.Add(this.buttonSend);
			this.groupCommand.Controls.Add(this.inputCommand);
			this.groupCommand.Location = new System.Drawing.Point(276, 12);
			this.groupCommand.Name = "groupCommand";
			this.groupCommand.Size = new System.Drawing.Size(436, 316);
			this.groupCommand.TabIndex = 4;
			this.groupCommand.TabStop = false;
			this.groupCommand.Text = "Command";
			// 
			// commandResult
			// 
			this.commandResult.Location = new System.Drawing.Point(6, 22);
			this.commandResult.Multiline = true;
			this.commandResult.Name = "commandResult";
			this.commandResult.ReadOnly = true;
			this.commandResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.commandResult.Size = new System.Drawing.Size(424, 243);
			this.commandResult.TabIndex = 2;
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(355, 271);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(75, 39);
			this.buttonSend.TabIndex = 1;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			// 
			// inputCommand
			// 
			this.inputCommand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.inputCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.inputCommand.Location = new System.Drawing.Point(6, 272);
			this.inputCommand.Name = "inputCommand";
			this.inputCommand.ReadOnly = true;
			this.inputCommand.Size = new System.Drawing.Size(343, 36);
			this.inputCommand.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 340);
			this.Controls.Add(this.groupCommand);
			this.Controls.Add(this.groupAction);
			this.Controls.Add(this.groupInput);
			this.Name = "MainForm";
			this.Text = "Telnet Client";
			this.groupInput.ResumeLayout(false);
			this.groupInput.PerformLayout();
			this.groupAction.ResumeLayout(false);
			this.groupCommand.ResumeLayout(false);
			this.groupCommand.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}