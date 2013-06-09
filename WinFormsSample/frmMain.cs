#region License
/**********************************************************************
 * LogiLCD.net - Copyright (C) 2013 by Daniel Drywa (daniel@drywa.me)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
 * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 ***********************************************************************
 * Logitech Gaming Lcd SDK
 * Copyright (C) 2013 Logitech Inc. All Rights Reserved
 * 
 * Logitech Gaming LCD SDK is either a registered trademark or trademark of Logitech in the United States and/or other countries. 
 * All other trademarks are the property of their respective owners.
 * 
 **********************************************************************/
#endregion

#region Using Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dd.logilcd;

#endregion

namespace WinFormsSample {
	public partial class frmMain : Form {
		private LogiLcd logilcd		= new LogiLcd();
		private Color	txtColor	= Color.White;

		public frmMain() {
			InitializeComponent();
		}

		private void frmMain_Load( object sender, EventArgs e ) {
			lblStatus.Text		= "[ NULL ]";
			btnShutdown.Enabled = false;
			btnInit.Enabled		= true;
			lblColor.BackColor	= txtColor;
		}

		private void timerUpdate_Tick( object sender, EventArgs e ) {
			if ( logilcd != null && !logilcd.IsDisposed ) {
				logilcd.Update();

				if ( logilcd.IsConnected( LCD_TYPE.MONO ) ) {
					chkMono.Checked = true;
					chkBtn0.Checked = logilcd.IsMonoButtonPressed( MONO_BUTTON.BUTTON_0 );
					chkBtn1.Checked = logilcd.IsMonoButtonPressed( MONO_BUTTON.BUTTON_1 );
					chkBtn2.Checked = logilcd.IsMonoButtonPressed( MONO_BUTTON.BUTTON_2 );
					chkBtn3.Checked = logilcd.IsMonoButtonPressed( MONO_BUTTON.BUTTON_3 );

				} else {
					chkMono.Checked = false;
				}

				if ( logilcd.IsConnected( LCD_TYPE.COLOR ) ) {
					chkColor.Checked		= true;
					chkBtnUp.Checked		= logilcd.IsColorButtonPressed( COLOR_BUTTON.BUTTON_UP );
					chkBtnDown.Checked		= logilcd.IsColorButtonPressed( COLOR_BUTTON.BUTTON_DOWN );
					chkBtnLeft.Checked		= logilcd.IsColorButtonPressed( COLOR_BUTTON.BUTTON_LEFT );
					chkBtnRight.Checked		= logilcd.IsColorButtonPressed( COLOR_BUTTON.BUTTON_RIGHT );
					chkBtnOk.Checked		= logilcd.IsColorButtonPressed( COLOR_BUTTON.BUTTON_OK );
					chkBtnCancel.Checked	= logilcd.IsColorButtonPressed( COLOR_BUTTON.BUTTON_CANCEL );
				} else {
					chkColor.Checked = false;
				}
			}
		}

		private void btnInit_Click( object sender, EventArgs e ) {
			if ( !logilcd.Initialize( "My Sample Applet", LCD_TYPE.MONO | LCD_TYPE.COLOR ) ) {
				MessageBox.Show( "Couldn't init Logi LCD :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				logilcd.Shutdown();
			} else {
				btnInit.Enabled		= false;
				btnShutdown.Enabled = true;
				lblStatus.Text		= "[ Initialized ]";
				timerUpdate.Start();
			}
		}

		private void btnShutdown_Click( object sender, EventArgs e ) {
			btnInit.Enabled		= true;
			btnShutdown.Enabled = false;

			timerUpdate.Stop();
			logilcd.Shutdown();
			lblStatus.Text = "[ NULL ]";
		}

		private void btnColor_Click( object sender, EventArgs e ) {
			dlgColor.Color = txtColor;
			if ( dlgColor.ShowDialog() == DialogResult.OK ) {
				txtColor = dlgColor.Color;
				lblColor.BackColor = txtColor;
			}
		}

		private void btnSetTitle_Click( object sender, EventArgs e ) {
			logilcd.SetColorTitle( txtText.Text, txtColor.R, txtColor.G, txtColor.B );
			txtText.Text = "";
		}

		private void btnSetText_Click( object sender, EventArgs e ) {
			int index = 0;
			foreach ( var chk in chkMonoLine.CheckedItems ) {
				index = chkMonoLine.Items.IndexOf( chk );
				logilcd.SetMonoText( ( MONO_TEXT_LINE )index, txtText.Text );
			}

			foreach ( var chk in chkColorLine.CheckedItems ) {
				index = chkColorLine.Items.IndexOf( chk );
				logilcd.SetColorText( ( COLOR_TEXT_LINE )index, txtText.Text, txtColor.R, txtColor.G, txtColor.B );
			}
			txtText.Text = "";
		}

		private void btnImageLoad_Click( object sender, EventArgs e ) {
			dlgFile.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.MyPictures );
			if ( dlgFile.ShowDialog() == DialogResult.OK ) {
				picImage.Load( dlgFile.FileName );
			}
		}

		private void btnImageSet_Click( object sender, EventArgs e ) {
			//if ( logilcd.IsConnected( LCD_TYPE.MONO ) ) {
			//	var bmp = new Bitmap( picImage.Image );
			//	logilcd.SetMonoBackground( bmp );
			//}

			if ( logilcd.IsConnected( LCD_TYPE.COLOR ) ) {
				var bmp = new Bitmap( picImage.Image );
				logilcd.SetColorBackground( bmp );
			}
		}
	}
}
