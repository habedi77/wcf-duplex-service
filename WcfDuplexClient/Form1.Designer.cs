namespace WcfDuplexClient
{
	partial class Form1
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
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonSend = new System.Windows.Forms.Button();
			this.textBoxIn = new System.Windows.Forms.TextBox();
			this.textBoxOut = new System.Windows.Forms.TextBox();
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(438, 243);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Connect";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonSend
			// 
			this.buttonSend.Enabled = false;
			this.buttonSend.Location = new System.Drawing.Point(460, 197);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(53, 23);
			this.buttonSend.TabIndex = 1;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// textBoxIn
			// 
			this.textBoxIn.Location = new System.Drawing.Point(25, 47);
			this.textBoxIn.Multiline = true;
			this.textBoxIn.Name = "textBoxIn";
			this.textBoxIn.ReadOnly = true;
			this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxIn.Size = new System.Drawing.Size(235, 118);
			this.textBoxIn.TabIndex = 2;
			// 
			// textBoxOut
			// 
			this.textBoxOut.Location = new System.Drawing.Point(278, 47);
			this.textBoxOut.Multiline = true;
			this.textBoxOut.Name = "textBoxOut";
			this.textBoxOut.ReadOnly = true;
			this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxOut.Size = new System.Drawing.Size(235, 118);
			this.textBoxOut.TabIndex = 3;
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Location = new System.Drawing.Point(278, 197);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(176, 20);
			this.textBoxMessage.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(275, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Outgoing";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Incoming";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 290);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.textBoxOut);
			this.Controls.Add(this.textBoxIn);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.buttonStart);
			this.Name = "Form1";
			this.Text = "Start";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.TextBox textBoxIn;
		private System.Windows.Forms.TextBox textBoxOut;
		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

