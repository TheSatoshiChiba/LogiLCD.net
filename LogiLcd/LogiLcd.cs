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
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
#endregion

namespace dd.logilcd {
	[Flags]
	public enum LCD_TYPE : int {
		MONO	= 0x00000001,
		COLOR	= 0x00000002
	}

	[Flags]
	public enum MONO_BUTTON : int {
		BUTTON_0 = 0x00000001,
		BUTTON_1 = 0x00000002,
		BUTTON_2 = 0x00000004,
		BUTTON_3 = 0x00000008
	}

	[Flags]
	public enum COLOR_BUTTON : int {
		BUTTON_LEFT		= 0x00000100,
		BUTTON_RIGHT	= 0x00000200,
		BUTTON_OK		= 0x00000400,
		BUTTON_CANCEL	= 0x00000800,
		BUTTON_UP		= 0x00001000,
		BUTTON_DOWN		= 0x00002000,
		BUTTON_MENU		= 0x00004000
	}

	public class LogiLcd : IDisposable {
		public const int	MonoWidth	= 160;
		public const int	MonoHeight	= 43;
		public const int	ColorWidth	= 320;
		public const int	ColorHeight	= 240;

		private bool		isDisposed	= false;
		private string		name		= string.Empty;

		public LogiLcd() {
		}

		~LogiLcd() {
			Dispose( false );
		}

		public bool IsDisposed {
			get {
				return isDisposed;
			}
		}

		public bool Init( string friendlyName, LCD_TYPE lcdType ) {
			if ( isDisposed ) {
				throw new ObjectDisposedException( "LogiLcd" );
			}

			name = friendlyName;
			int type = ( int )lcdType;
			return NativeMethods.LogiLcdInit( name, type );
		}
		
		public bool IsConnected( LCD_TYPE lcdType ) {
			if ( isDisposed ) {
				throw new ObjectDisposedException( "LogiLcd" );
			}

			int type = ( int )lcdType;
			return NativeMethods.LogiLcdIsConnected( type );
		}

		public bool IsMonoButtonPressed( MONO_BUTTON button ) {
			if ( isDisposed ) {
				throw new ObjectDisposedException( "LogiLcd" );
			}

			int btn = ( int )button;
			return NativeMethods.LogiLcdIsButtonPressed( btn );
		}

		public bool IsColorButtonPressed( COLOR_BUTTON button ) {
			if ( isDisposed ) {
				throw new ObjectDisposedException( "LogiLcd" );
			}

			int btn = ( int )button;
			return NativeMethods.LogiLcdIsButtonPressed( btn );
		}

		public void Update() {
			if ( isDisposed ) {
				throw new ObjectDisposedException( "LogiLcd" );
			}

			NativeMethods.LogiLcdUpdate();
		}

		public void Shutdown() {
			NativeMethods.LogiLcdShutdown();
		}

		public void Dispose() {
			Dispose( true );
			GC.SuppressFinalize( this );
		}

		protected virtual void Dispose( bool disposing ) {
			if ( !isDisposed ) {
				if ( disposing ) {
					// Clean managed resources
				}

				// Clean unmanaged resources
				Shutdown();
				isDisposed = true;
			}
		}
	}
}
