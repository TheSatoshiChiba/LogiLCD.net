namespace WinFormsSample {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.timerUpdate = new System.Windows.Forms.Timer(this.components);
			this.btnInit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnShutdown = new System.Windows.Forms.Button();
			this.chkMono = new System.Windows.Forms.CheckBox();
			this.chkColor = new System.Windows.Forms.CheckBox();
			this.chkBtn1 = new System.Windows.Forms.CheckBox();
			this.chkBtn0 = new System.Windows.Forms.CheckBox();
			this.chkBtn3 = new System.Windows.Forms.CheckBox();
			this.chkBtn2 = new System.Windows.Forms.CheckBox();
			this.chkBtnLeft = new System.Windows.Forms.CheckBox();
			this.chkBtnRight = new System.Windows.Forms.CheckBox();
			this.chkBtnUp = new System.Windows.Forms.CheckBox();
			this.chkBtnDown = new System.Windows.Forms.CheckBox();
			this.chkBtnOk = new System.Windows.Forms.CheckBox();
			this.chkBtnCancel = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// timerUpdate
			// 
			this.timerUpdate.Interval = 10;
			this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
			// 
			// btnInit
			// 
			this.btnInit.Location = new System.Drawing.Point(12, 33);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new System.Drawing.Size(103, 23);
			this.btnInit.TabIndex = 0;
			this.btnInit.Text = "Initialize";
			this.btnInit.UseVisualStyleBackColor = true;
			this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Status:";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(58, 17);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(35, 13);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.Text = "label2";
			// 
			// btnShutdown
			// 
			this.btnShutdown.Location = new System.Drawing.Point(121, 33);
			this.btnShutdown.Name = "btnShutdown";
			this.btnShutdown.Size = new System.Drawing.Size(103, 23);
			this.btnShutdown.TabIndex = 3;
			this.btnShutdown.Text = "Shutdown";
			this.btnShutdown.UseVisualStyleBackColor = true;
			this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
			// 
			// chkMono
			// 
			this.chkMono.AutoCheck = false;
			this.chkMono.AutoSize = true;
			this.chkMono.Location = new System.Drawing.Point(15, 63);
			this.chkMono.Name = "chkMono";
			this.chkMono.Size = new System.Drawing.Size(108, 17);
			this.chkMono.TabIndex = 4;
			this.chkMono.Text = "Mono Connected";
			this.chkMono.UseVisualStyleBackColor = true;
			// 
			// chkColor
			// 
			this.chkColor.AutoCheck = false;
			this.chkColor.AutoSize = true;
			this.chkColor.Location = new System.Drawing.Point(15, 86);
			this.chkColor.Name = "chkColor";
			this.chkColor.Size = new System.Drawing.Size(105, 17);
			this.chkColor.TabIndex = 5;
			this.chkColor.Text = "Color Connected";
			this.chkColor.UseVisualStyleBackColor = true;
			// 
			// chkBtn1
			// 
			this.chkBtn1.AutoCheck = false;
			this.chkBtn1.AutoSize = true;
			this.chkBtn1.Location = new System.Drawing.Point(12, 160);
			this.chkBtn1.Name = "chkBtn1";
			this.chkBtn1.Size = new System.Drawing.Size(96, 17);
			this.chkBtn1.TabIndex = 6;
			this.chkBtn1.Text = "Mono Button 1";
			this.chkBtn1.UseVisualStyleBackColor = true;
			// 
			// chkBtn0
			// 
			this.chkBtn0.AutoCheck = false;
			this.chkBtn0.AutoSize = true;
			this.chkBtn0.Location = new System.Drawing.Point(12, 140);
			this.chkBtn0.Name = "chkBtn0";
			this.chkBtn0.Size = new System.Drawing.Size(96, 17);
			this.chkBtn0.TabIndex = 7;
			this.chkBtn0.Text = "Mono Button 0";
			this.chkBtn0.UseVisualStyleBackColor = true;
			// 
			// chkBtn3
			// 
			this.chkBtn3.AutoCheck = false;
			this.chkBtn3.AutoSize = true;
			this.chkBtn3.Location = new System.Drawing.Point(12, 206);
			this.chkBtn3.Name = "chkBtn3";
			this.chkBtn3.Size = new System.Drawing.Size(96, 17);
			this.chkBtn3.TabIndex = 8;
			this.chkBtn3.Text = "Mono Button 3";
			this.chkBtn3.UseVisualStyleBackColor = true;
			// 
			// chkBtn2
			// 
			this.chkBtn2.AutoCheck = false;
			this.chkBtn2.AutoSize = true;
			this.chkBtn2.Location = new System.Drawing.Point(12, 183);
			this.chkBtn2.Name = "chkBtn2";
			this.chkBtn2.Size = new System.Drawing.Size(96, 17);
			this.chkBtn2.TabIndex = 9;
			this.chkBtn2.Text = "Mono Button 2";
			this.chkBtn2.UseVisualStyleBackColor = true;
			// 
			// chkBtnLeft
			// 
			this.chkBtnLeft.AutoCheck = false;
			this.chkBtnLeft.AutoSize = true;
			this.chkBtnLeft.Location = new System.Drawing.Point(159, 126);
			this.chkBtnLeft.Name = "chkBtnLeft";
			this.chkBtnLeft.Size = new System.Drawing.Size(105, 17);
			this.chkBtnLeft.TabIndex = 10;
			this.chkBtnLeft.Text = "Color Button Left";
			this.chkBtnLeft.UseVisualStyleBackColor = true;
			// 
			// chkBtnRight
			// 
			this.chkBtnRight.AutoCheck = false;
			this.chkBtnRight.AutoSize = true;
			this.chkBtnRight.Location = new System.Drawing.Point(348, 126);
			this.chkBtnRight.Name = "chkBtnRight";
			this.chkBtnRight.Size = new System.Drawing.Size(112, 17);
			this.chkBtnRight.TabIndex = 11;
			this.chkBtnRight.Text = "Color Button Right";
			this.chkBtnRight.UseVisualStyleBackColor = true;
			// 
			// chkBtnUp
			// 
			this.chkBtnUp.AutoCheck = false;
			this.chkBtnUp.AutoSize = true;
			this.chkBtnUp.Location = new System.Drawing.Point(244, 86);
			this.chkBtnUp.Name = "chkBtnUp";
			this.chkBtnUp.Size = new System.Drawing.Size(101, 17);
			this.chkBtnUp.TabIndex = 12;
			this.chkBtnUp.Text = "Color Button Up";
			this.chkBtnUp.UseVisualStyleBackColor = true;
			// 
			// chkBtnDown
			// 
			this.chkBtnDown.AutoCheck = false;
			this.chkBtnDown.AutoSize = true;
			this.chkBtnDown.Location = new System.Drawing.Point(244, 160);
			this.chkBtnDown.Name = "chkBtnDown";
			this.chkBtnDown.Size = new System.Drawing.Size(115, 17);
			this.chkBtnDown.TabIndex = 13;
			this.chkBtnDown.Text = "Color Button Down";
			this.chkBtnDown.UseVisualStyleBackColor = true;
			// 
			// chkBtnOk
			// 
			this.chkBtnOk.AutoCheck = false;
			this.chkBtnOk.AutoSize = true;
			this.chkBtnOk.Location = new System.Drawing.Point(159, 206);
			this.chkBtnOk.Name = "chkBtnOk";
			this.chkBtnOk.Size = new System.Drawing.Size(102, 17);
			this.chkBtnOk.TabIndex = 14;
			this.chkBtnOk.Text = "Color Button OK";
			this.chkBtnOk.UseVisualStyleBackColor = true;
			// 
			// chkBtnCancel
			// 
			this.chkBtnCancel.AutoCheck = false;
			this.chkBtnCancel.AutoSize = true;
			this.chkBtnCancel.Location = new System.Drawing.Point(348, 206);
			this.chkBtnCancel.Name = "chkBtnCancel";
			this.chkBtnCancel.Size = new System.Drawing.Size(120, 17);
			this.chkBtnCancel.TabIndex = 15;
			this.chkBtnCancel.Text = "Color Button Cancel";
			this.chkBtnCancel.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 260);
			this.Controls.Add(this.chkBtnCancel);
			this.Controls.Add(this.chkBtnOk);
			this.Controls.Add(this.chkBtnDown);
			this.Controls.Add(this.chkBtnUp);
			this.Controls.Add(this.chkBtnRight);
			this.Controls.Add(this.chkBtnLeft);
			this.Controls.Add(this.chkBtn2);
			this.Controls.Add(this.chkBtn3);
			this.Controls.Add(this.chkBtn0);
			this.Controls.Add(this.chkBtn1);
			this.Controls.Add(this.chkColor);
			this.Controls.Add(this.chkMono);
			this.Controls.Add(this.btnShutdown);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnInit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "LogiLCD.net Sample";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timerUpdate;
		private System.Windows.Forms.Button btnInit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnShutdown;
		private System.Windows.Forms.CheckBox chkMono;
		private System.Windows.Forms.CheckBox chkColor;
		private System.Windows.Forms.CheckBox chkBtn1;
		private System.Windows.Forms.CheckBox chkBtn0;
		private System.Windows.Forms.CheckBox chkBtn3;
		private System.Windows.Forms.CheckBox chkBtn2;
		private System.Windows.Forms.CheckBox chkBtnLeft;
		private System.Windows.Forms.CheckBox chkBtnRight;
		private System.Windows.Forms.CheckBox chkBtnUp;
		private System.Windows.Forms.CheckBox chkBtnDown;
		private System.Windows.Forms.CheckBox chkBtnOk;
		private System.Windows.Forms.CheckBox chkBtnCancel;
	}
}

