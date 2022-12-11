using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SkyCheats.LUserControls;
using SkyCheats.Properties;
using SkyCheats.UserControls;

namespace SkyCheats
{
	// Token: 0x02000011 RID: 17
	public partial class Main_Form : Form
	{
		// Token: 0x060000FB RID: 251
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

		// Token: 0x060000FC RID: 252
		[DllImport("user32.dll")]
		private static extern ushort GetAsyncKeyState(int vKey);

		// Token: 0x060000FD RID: 253
		[DllImport("USER32.dll")]
		private static extern short GetKeyState(int nVirtKey);

		// Token: 0x060000FE RID: 254
		[DllImport("gdi32.dll")]
		private static extern bool BitBlt(IntPtr hdcDest, int nxDest, int nyDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

		// Token: 0x060000FF RID: 255
		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int width, int nHeight);

		// Token: 0x06000100 RID: 256
		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		// Token: 0x06000101 RID: 257
		[DllImport("gdi32.dll")]
		private static extern IntPtr DeleteDC(IntPtr hdc);

		// Token: 0x06000102 RID: 258
		[DllImport("gdi32.dll")]
		private static extern IntPtr DeleteObject(IntPtr hObject);

		// Token: 0x06000103 RID: 259
		[DllImport("user32.dll")]
		private static extern IntPtr GetDesktopWindow();

		// Token: 0x06000104 RID: 260
		[DllImport("user32.dll")]
		private static extern IntPtr GetWindowDC(IntPtr hWnd);

		// Token: 0x06000105 RID: 261
		[DllImport("user32.dll")]
		private static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);

		// Token: 0x06000106 RID: 262
		[DllImport("gdi32.dll")]
		private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);

		// Token: 0x06000107 RID: 263 RVA: 0x000039A8 File Offset: 0x00001DA8
		public static void DoMouseClick()
		{
			Main_Form.mouse_event(6U, 0U, 0U, 0U, 0U);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000039B6 File Offset: 0x00001DB6
		public Main_Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000039D0 File Offset: 0x00001DD0
		private static void LoadDllFile()
		{
			int num = Main_Form.dd.Load("C:/ugubuga.dll");
			bool flag = num != 1;
			if (flag)
			{
				MessageBox.Show("Load Error");
				Environment.Exit(0);
			}
			num = Main_Form.dd.btn(0);
			bool flag2 = num != 1;
			if (flag2)
			{
				MessageBox.Show("Initialize Error");
				Environment.Exit(0);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00003A40 File Offset: 0x00001E40
		private static bool is_colora(Color ada)
		{
			bool flag = config.color == "Purple";
			bool result;
			if (flag)
			{
				bool flag2 = ada.G >= 170;
				if (flag2)
				{
					result = false;
				}
				else
				{
					bool flag3 = ada.G >= 120;
					if (flag3)
					{
						result = (ada.R - ada.B <= 8 && ada.R - ada.G >= 60 && ada.B - ada.G >= 60 && ada.R >= 90 && ada.B >= 170);
					}
					else
					{
						result = (ada.R - ada.B <= 11 && ada.R - ada.G >= 75 && ada.B - ada.G >= 75 && ada.R >= 90 && ada.B >= 170);
					}
				}
			}
			else
			{
				bool flag4 = config.color == "Red";
				if (flag4)
				{
					Color color = Color.FromArgb(160, 0, 0);
					Color color2 = Color.FromArgb(255, 70, 70);
					result = (color.R <= ada.R && ada.R <= color2.R && color.G <= ada.G && ada.G <= color2.G && color.B <= ada.B && ada.B <= color2.B);
				}
				else
				{
					bool flag5 = ada.R < 200;
					result = (!flag5 && (ada.G > 200 && ada.G < byte.MaxValue && ada.B > 0) && ada.B < 100);
				}
			}
			return result;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003C48 File Offset: 0x00002048
		private static bool is_coloraa(byte r, byte g, byte b)
		{
			bool flag = config.color == "Purple";
			bool result;
			if (flag)
			{
				bool flag2 = g >= 190;
				result = (!flag2 && (r - b <= 25 && r - g >= 60 && b - g >= 60 && r >= 110) && b >= 100);
			}
			else
			{
				bool flag3 = r < 200;
				result = (!flag3 && (g > 200 && g < byte.MaxValue && b > 0) && b < 100);
			}
			return result;
		}

		// Token: 0x0600010C RID: 268
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600010D RID: 269
		[DllImport("user32.dll")]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		// Token: 0x0600010E RID: 270 RVA: 0x00003CD8 File Offset: 0x000020D8
		private static string GetActiveWindowTitle()
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			IntPtr foregroundWindow = Main_Form.GetForegroundWindow();
			bool flag = Main_Form.GetWindowText(foregroundWindow, stringBuilder, 256) > 0;
			string result;
			if (flag)
			{
				result = stringBuilder.ToString();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00003D1C File Offset: 0x0000211C
		private static void pixelsearchaim()
		{
			bool flag = config.subscription == "AimbotDriver";
			if (!flag)
			{
				return;
			}
			for (;;)
			{
				Thread.Sleep(1);
				bool flag2 = Main_Form.GetAsyncKeyState(config.aim_key) > 1;
				if (flag2)
				{
					bool flag3 = config.aimbot_state && config.bodypartcheckboxselectiontruefalse;
					if (flag3)
					{
						Main_Form.adsadaDAim();
					}
				}
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003D7C File Offset: 0x0000217C
		private static void pixelsearchFlick()
		{
			bool flag = config.subscription == "AimbotDriver";
			if (!flag)
			{
				return;
			}
			for (;;)
			{
				Thread.Sleep(1);
				bool flag2 = Main_Form.GetAsyncKeyState(config.flick_key) > 1;
				if (flag2)
				{
					bool flag3 = config.flick_active && config.flick_state && config.bodypartcheckboxselectiontruefalse;
					if (flag3)
					{
						Main_Form.adsadaDFlick();
					}
				}
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00003DE4 File Offset: 0x000021E4
		private static void pixelsearchSilent()
		{
			bool flag = config.subscription == "AimbotDriver";
			if (!flag)
			{
				return;
			}
			for (;;)
			{
				Thread.Sleep(1);
				bool flag2 = Main_Form.GetAsyncKeyState(config.silent_key) > 1;
				if (flag2)
				{
					bool flag3 = config.silent_state && config.silent_active && config.bodypartcheckboxselectiontruefalse;
					if (flag3)
					{
						Main_Form.adsadaDSilent();
					}
				}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003E4C File Offset: 0x0000224C
		private static void asdasdsadasda()
		{
			for (;;)
			{
				Thread.Sleep(10);
				bool flag = Main_Form.GetAsyncKeyState(config.silent_key) > 1 && !config.silent_active;
				if (flag)
				{
					config.silent_active = true;
				}
				else
				{
					bool flag2 = Main_Form.GetAsyncKeyState(config.silent_key) <= 1 && config.silent_active;
					if (flag2)
					{
						config.silent_active = false;
					}
				}
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00003EB4 File Offset: 0x000022B4
		private static void vsavsavavsa()
		{
			for (;;)
			{
				Thread.Sleep(10);
				bool flag = Main_Form.GetAsyncKeyState(config.flick_key) > 1 && !config.flick_active;
				if (flag)
				{
					config.flick_active = true;
				}
				else
				{
					bool flag2 = Main_Form.GetAsyncKeyState(config.flick_key) <= 1 && config.flick_active;
					if (flag2)
					{
						config.flick_active = false;
					}
				}
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003F1C File Offset: 0x0000231C
		private static void asdasdsad()
		{
			for (;;)
			{
				Thread.Sleep(1);
				bool checkautofire = config.checkautofire;
				if (checkautofire)
				{
					config.checkautofire = false;
					Main_Form.mouse_event(6U, 0U, 0U, 0U, 0U);
					Thread.Sleep(config.shot_speed * 3);
				}
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003F64 File Offset: 0x00002364
		private static void adsadaDAim()
		{
			try
			{
				int fov_x = config.fov_x;
				int fov_y = config.fov_y;
				Bitmap bitmap = Main_Form.screen_shot(new Rectangle(config.screenWidth / 2 - fov_x / 2 + config.uwux, config.screenHeight / 2 - fov_y / 2 - config.extras + config.uwuy, fov_x, fov_y));
				for (int i = 1; i < fov_y; i++)
				{
					for (int j = 1; j < fov_x; j++)
					{
						bool flag = Main_Form.is_colora(bitmap.GetPixel(j, i));
						if (flag)
						{
							j = Main_Form.adsada(j, i, bitmap);
							bool smooth_state = config.smooth_state;
							double num;
							if (smooth_state)
							{
								num = config.smooth;
							}
							else
							{
								num = 0.4;
							}
							bool auto_fire_state = config.auto_fire_state;
							if (auto_fire_state)
							{
								double num2 = Math.Sqrt(Math.Pow((double)(config.screenWidth / 2 - (config.screenWidth / 2 - fov_x / 2 + j)), 2.0) + Math.Pow((double)(config.screenHeight / 2 - (config.screenHeight / 2 - fov_y / 2 + i)), 2.0));
								bool flag2 = num2 < 5.0;
								if (flag2)
								{
									config.checkautofire = true;
								}
							}
							bool aim_only_on_x_state = config.aim_only_on_x_state;
							if (aim_only_on_x_state)
							{
								Main_Form.dd.movR((int)Convert.ToInt16((double)(j - fov_x / 2) * config.sensitivity_x * num), 0);
							}
							else
							{
								Main_Form.dd.movR((int)Convert.ToInt16((double)(j - fov_x / 2) * config.sensitivity_x * num), (int)Convert.ToInt16((double)(i - fov_y / 2) * config.sensitivity_y * num));
							}
							return;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004144 File Offset: 0x00002544
		private static void adsadaDFlick()
		{
			int flick_fovx = config.flick_fovx;
			int flick_fovy = config.flick_fovy;
			Bitmap bitmap = Main_Form.screen_shot(new Rectangle(config.screenWidth / 2 - flick_fovx / 2 + config.uwux, config.screenHeight / 2 - flick_fovy / 2 - config.extras + config.uwuy, flick_fovx, flick_fovy));
			for (int i = 1; i < flick_fovy; i++)
			{
				for (int j = 1; j < flick_fovx; j++)
				{
					bool flag = Main_Form.is_colora(bitmap.GetPixel(j, i));
					if (flag)
					{
						Main_Form.dd.movR((int)Convert.ToInt16((double)(j - flick_fovx / 2) * config.sensitivity_x), (int)Convert.ToInt16((double)(i - flick_fovy / 2) * config.sensitivity_y));
						Main_Form.DoMouseClick();
						config.flick_active = false;
						Thread.Sleep(config.flick_delay);
						return;
					}
				}
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004228 File Offset: 0x00002628
		private static void adsadaDSilent()
		{
			try
			{
				int silent_fovx = config.silent_fovx;
				int silent_fovy = config.silent_fovy;
				Bitmap bitmap = Main_Form.screen_shot(new Rectangle(config.screenWidth / 2 - silent_fovx / 2 + config.uwux, config.screenHeight / 2 - silent_fovy / 2 - config.extras + config.uwuy, silent_fovx, silent_fovy));
				for (int i = 1; i < silent_fovy; i++)
				{
					for (int j = 1; j < silent_fovx; j++)
					{
						bool flag = Main_Form.is_colora(bitmap.GetPixel(j, i));
						if (flag)
						{
							Main_Form.dd.movR((int)Convert.ToInt16((double)(j - silent_fovx / 2) * config.sensitivity_x), (int)Convert.ToInt16((double)(i - silent_fovy / 2) * config.sensitivity_y));
							Main_Form.DoMouseClick();
							Main_Form.dd.movR((int)(Convert.ToInt16((double)(j - silent_fovx / 2) * config.sensitivity_x) * -1), (int)(Convert.ToInt16((double)(i - silent_fovy / 2) * config.sensitivity_y) * -1));
							config.silent_active = false;
							Thread.Sleep(config.silent_delay);
							return;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004370 File Offset: 0x00002770
		private static bool check_variant(Color ada, Color uwu, int variant)
		{
			return (int)ada.R + variant > (int)uwu.R && (int)ada.R - variant < (int)uwu.R && (int)ada.G + variant > (int)uwu.G && (int)ada.G - variant < (int)uwu.G && (int)ada.B + variant > (int)uwu.B && (int)ada.B - variant < (int)uwu.B;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000043F4 File Offset: 0x000027F4
		private static int adsada(int x, int y, Bitmap objec)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 25;
			int num4 = x - 10;
			int num5 = y - 3;
			for (int i = 0; i < 5; i++)
			{
				num4 = x - 10;
				for (int j = 0; j < 15; j++)
				{
					try
					{
						bool flag = Main_Form.is_colora(objec.GetPixel(num4 + j, num5 + i));
						if (flag)
						{
							num += num4 + j;
							num2++;
							bool flag2 = num2 >= num3;
							if (flag2)
							{
								return num / num2;
							}
						}
					}
					catch (Exception)
					{
						break;
					}
				}
			}
			bool flag3 = num2 != 0;
			if (flag3)
			{
				return num / num2;
			}
			return x;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000044B8 File Offset: 0x000028B8
		private static void trig()
		{
			for (;;)
			{
				bool flag = config.triggerbot_state && Main_Form.GetAsyncKeyState(config.trigger_key) > 0;
				if (flag)
				{
					bool trigger_force_hs_state = config.trigger_force_hs_state;
					if (trigger_force_hs_state)
					{
						Main_Form.aaaaa();
					}
					else
					{
						Main_Form.aaaa();
					}
				}
				Thread.Sleep(3);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000450C File Offset: 0x0000290C
		private static void aaaaa()
		{
			int num = 50;
			int num2 = 50;
			try
			{
				Bitmap bitmap = Main_Form.screen_shot(new Rectangle(config.screenWidth / 2 - num / 2 + config.uwux, config.screenHeight / 2 - num2 / 2 - config.extras + config.uwuy, num, num2));
				for (int i = 1; i < num2; i++)
				{
					for (int j = 1; j < num; j++)
					{
						bool flag = Main_Form.is_colora(bitmap.GetPixel(j, i));
						if (flag)
						{
							j = Main_Form.adsada(j, i, bitmap);
							double num3 = Math.Sqrt(Math.Pow((double)(config.screenWidth / 2 - (config.screenWidth / 2 - num / 2 + j)), 2.0) + Math.Pow((double)(config.screenHeight / 2 - (config.screenHeight / 2 - num2 / 2 + i)), 2.0));
							bool flag2 = num3 < 5.0;
							if (flag2)
							{
								Main_Form.mouse_event(6U, 0U, 0U, 0U, 0U);
								Thread.Sleep(config.trigger_speed * 3);
								return;
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004658 File Offset: 0x00002A58
		private static void aaaa()
		{
			int num = 8;
			int num2 = 8;
			try
			{
				Bitmap bitmap = Main_Form.screen_shot(new Rectangle(config.screenWidth / 2 - num2 / 2, config.screenHeight / 2 - num / 2, num2, num));
				for (int i = 1; i < num; i++)
				{
					for (int j = 1; j < num2; j++)
					{
						bool flag = Main_Form.is_colora(bitmap.GetPixel(j, i));
						if (flag)
						{
							Main_Form.mouse_event(6U, 0U, 0U, 0U, 0U);
							Thread.Sleep(config.trigger_speed * 3);
							return;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004704 File Offset: 0x00002B04
		private static void ada()
		{
			bool flag = false;
			bool flag2 = false;
			DateTime now = DateTime.Now;
			config.max_recoil = 45;
			config.recoilspeed = 1.5;
			for (;;)
			{
				Thread.Sleep(1);
				bool flag3 = config.bodypartcheckboxselectiontruefalse && config.recoil_system_state && Main_Form.GetAsyncKeyState(1) > 0 && !flag && !flag2;
				if (flag3)
				{
					flag = true;
					now = DateTime.Now;
				}
				else
				{
					bool flag4 = config.bodypartcheckboxselectiontruefalse && config.recoil_system_state && Main_Form.GetAsyncKeyState(1) > 0 && ((flag && !flag2) || (!flag && flag2));
					if (flag4)
					{
						double totalMilliseconds = (DateTime.Now - now).TotalMilliseconds;
						config.extras = (int)Convert.ToInt16((double)config.max_recoil * ((double)config.screenHeight / 1080.0) * (totalMilliseconds / 1080.0) * config.recoilspeed);
						bool flag5 = config.extras > config.max_recoil;
						if (flag5)
						{
							config.extras = config.max_recoil;
						}
						flag = false;
						flag2 = true;
					}
					else
					{
						flag = false;
						flag2 = false;
						config.extras = 0;
					}
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000482C File Offset: 0x00002C2C
		private void getscreensiz()
		{
			for (;;)
			{
				config.screenWidth = Screen.PrimaryScreen.Bounds.Width;
				config.screenHeight = Screen.PrimaryScreen.Bounds.Height;
				config.sensitivity_x = 1.0 / config.sens / ((double)config.screenWidth / 1920.0) * 1.05;
				config.sensitivity_y = 1.0 / config.sens / ((double)config.screenHeight / 1080.0) * 1.05;
				Thread.Sleep(1000);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000048E4 File Offset: 0x00002CE4
		private static void checkactivewindow()
		{
			for (;;)
			{
				bool aimbot_state_checkbox = config.aimbot_state_checkbox;
				if (aimbot_state_checkbox)
				{
					bool flag = Main_Form.GetActiveWindowTitle() == "VALORANT  ";
					if (flag)
					{
						config.aimbot_state = true;
					}
					else
					{
						config.aimbot_state = false;
					}
				}
				bool silent_state_checkbox = config.silent_state_checkbox;
				if (silent_state_checkbox)
				{
					bool flag2 = Main_Form.GetActiveWindowTitle() == "VALORANT  ";
					if (flag2)
					{
						config.silent_state = true;
					}
					else
					{
						config.silent_state = false;
					}
				}
				bool flick_state_checkbox = config.flick_state_checkbox;
				if (flick_state_checkbox)
				{
					bool flag3 = Main_Form.GetActiveWindowTitle() == "VALORANT  ";
					if (flag3)
					{
						config.flick_state = true;
					}
					else
					{
						config.flick_state = false;
					}
				}
				Thread.Sleep(50);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000049A4 File Offset: 0x00002DA4
		public static Bitmap screen_shot(Rectangle region)
		{
			IntPtr desktopWindow = Main_Form.GetDesktopWindow();
			IntPtr windowDC = Main_Form.GetWindowDC(desktopWindow);
			IntPtr intPtr = Main_Form.CreateCompatibleDC(windowDC);
			IntPtr intPtr2 = Main_Form.CreateCompatibleBitmap(windowDC, region.Width, region.Height);
			IntPtr hObject = Main_Form.SelectObject(intPtr, intPtr2);
			bool flag = Main_Form.BitBlt(intPtr, 0, 0, region.Width, region.Height, windowDC, region.Left, region.Top, 1087111200);
			Bitmap result;
			try
			{
				bool flag2 = !flag;
				if (flag2)
				{
					throw new Win32Exception();
				}
				result = Image.FromHbitmap(intPtr2);
			}
			finally
			{
				Main_Form.SelectObject(intPtr, hObject);
				Main_Form.DeleteObject(intPtr2);
				Main_Form.DeleteDC(intPtr);
				Main_Form.ReleaseDC(desktopWindow, windowDC);
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004A68 File Offset: 0x00002E68
		private void Main_Form_Load(object sender, EventArgs e)
		{
			bool flag = config.user_data.username == "";
			if (flag)
			{
				Environment.Exit(0);
			}
			config.headx = -1;
			config.heady = -3;
			config.fov_x = 144;
			config.fov_y = 50;
			config.screenWidth = Screen.PrimaryScreen.Bounds.Width;
			config.screenHeight = Screen.PrimaryScreen.Bounds.Height;
			config.shot_speed = 50;
			config.trigger_speed = 50;
			config.smooth = 0.125;
			config.silent_active = true;
			config.flick_active = true;
			config.aimbot_state_checkbox = true;
			config.flick_state_checkbox = true;
			config.silent_state_checkbox = true;
			config.flick_fovx = 350;
			config.silent_fovx = 350;
			config.flick_fovy = 50;
			config.silent_fovy = 50;
			config.flick_delay = 25;
			config.silent_delay = 25;
			config.aim_key = 1;
			config.flick_key = 18;
			config.silent_key = 5;
			config.smooth_state = true;
			config.bone1_state = true;
			config.bodypartcheckboxselectiontruefalse = true;
			config.uwux = -1;
			config.uwuy = -5;
			config.smooth = Convert.ToDouble(50) / 100.0 / 2.0;
			config.sens = Convert.ToDouble(30) / 100.0 * 2.0;
			Main_Form.myList.Add(Color.FromArgb(255, 117, 56, 140));
			Main_Form.myList.Add(Color.FromArgb(255, 143, 77, 146));
			Main_Form.myList.Add(Color.FromArgb(255, 111, 46, 107));
			Main_Form.myList.Add(Color.FromArgb(255, 163, 82, 142));
			Main_Form.myList.Add(Color.FromArgb(255, 123, 62, 160));
			Main_Form.myList.Add(Color.FromArgb(255, 144, 78, 169));
			Main_Form.myList.Add(Color.FromArgb(255, 164, 92, 162));
			Main_Form.myList.Add(Color.FromArgb(255, 186, 106, 169));
			Main_Form.myList.Add(Color.FromArgb(255, 110, 36, 142));
			Main_Form.myList.Add(Color.FromArgb(255, 140, 72, 196));
			Main_Form.myList.Add(Color.FromArgb(255, 114, 0, 157));
			Main_Form.myList.Add(Color.FromArgb(255, 124, 39, 163));
			Main_Form.myList.Add(Color.FromArgb(255, 179, 107, 20));
			Main_Form.myList.Add(Color.FromArgb(255, 147, 76, 216));
			Main_Form.myList.Add(Color.FromArgb(255, 132, 57, 120));
			Main_Form.myList.Add(Color.FromArgb(255, 110, 7, 133));
			Main_Form.myList.Add(Color.FromArgb(255, 130, 35, 137));
			Main_Form.myList.Add(Color.FromArgb(255, 155, 50, 134));
			Main_Form.myList.Add(Color.FromArgb(255, 161, 88, 196));
			Main_Form.myList.Add(Color.FromArgb(255, 112, 50, 192));
			Main_Form.myList.Add(Color.FromArgb(255, 119, 54, 213));
			Main_Form.myList.Add(Color.FromArgb(255, 146, 51, 157));
			Main_Form.myList.Add(Color.FromArgb(255, 166, 61, 162));
			Main_Form.myList.Add(Color.FromArgb(255, 110, 26, 104));
			Main_Form.myList.Add(Color.FromArgb(255, 146, 26, 159));
			Main_Form.myList.Add(Color.FromArgb(255, 136, 37, 114));
			Main_Form.myList.Add(Color.FromArgb(255, 186, 65, 163));
			Main_Form.myList.Add(Color.FromArgb(255, 166, 38, 159));
			Main_Form.myList.Add(Color.FromArgb(255, 157, 0, 162));
			Main_Form.myList.Add(Color.FromArgb(255, 178, 56, 190));
			Main_Form.myList.Add(Color.FromArgb(255, 114, 29, 185));
			Main_Form.myList.Add(Color.FromArgb(255, 146, 51, 177));
			Main_Form.myList.Add(Color.FromArgb(255, 139, 45, 197));
			Main_Form.myList.Add(Color.FromArgb(255, 199, 74, 194));
			Main_Form.myList.Add(Color.FromArgb(255, 137, 22, 185));
			Main_Form.myList.Add(Color.FromArgb(255, 207, 94, 182));
			Main_Form.myList.Add(Color.FromArgb(255, 196, 56, 233));
			Main_Form.myList.Add(Color.FromArgb(255, 127, 2, 187));
			Main_Form.myList.Add(Color.FromArgb(255, 145, 7, 211));
			Main_Form.myList.Add(Color.FromArgb(255, 50, 45, 122));
			Main_Form.myListdefault.Add(Color.FromArgb(255, 254, 172, 244));
			Main_Form.myListdefault.Add(Color.FromArgb(255, 255, 168, 233));
			Main_Form.myListdefault.Add(Color.FromArgb(255, 175, 106, 23));
			Main_Form.myListdefault.Add(Color.FromArgb(255, 255, 185, 251));
			bool flag2 = config.subscription == "AimbotDriver";
			if (flag2)
			{
				Main_Form.dd = new CDD();
				Main_Form.LoadDllFile();
			}
			Thread thread = new Thread(new ThreadStart(Main_Form.pixelsearchaim));
			Thread thread2 = new Thread(new ThreadStart(Main_Form.pixelsearchFlick));
			Thread thread3 = new Thread(new ThreadStart(Main_Form.pixelsearchSilent));
			Thread thread4 = new Thread(new ThreadStart(Main_Form.asdasdsad));
			Thread thread5 = new Thread(new ThreadStart(Main_Form.ada));
			Thread thread6 = new Thread(new ThreadStart(this.getscreensiz));
			Thread thread7 = new Thread(new ThreadStart(Main_Form.checkactivewindow));
			Thread thread8 = new Thread(new ThreadStart(Main_Form.trig));
			Thread thread9 = new Thread(new ThreadStart(Main_Form.asdasdsadasda));
			Thread thread10 = new Thread(new ThreadStart(Main_Form.vsavsavavsa));
			Thread thread11 = new Thread(new ThreadStart(Main_Form.sadasda));
			thread11.Start();
			thread6.Start();
			thread10.Start();
			thread9.Start();
			thread8.Start();
			thread7.Start();
			thread5.Start();
			thread4.Start();
			thread.Start();
			thread2.Start();
			thread3.Start();
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Show();
			this.userControl11.BringToFront();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000052D0 File Offset: 0x000036D0
		public static void sadasda()
		{
			Main_Form.KeyAuthApp.init();
			for (;;)
			{
				try
				{
					Main_Form.KeyAuthApp.login(config.usernamee, config.passwordd);
					bool success = Main_Form.KeyAuthApp.response.success;
					if (!success)
					{
						Environment.Exit(0);
					}
				}
				catch (Exception)
				{
				}
				Thread.Sleep(5000);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000534C File Offset: 0x0000374C
		private void Button_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Show();
			this.userControl11.BringToFront();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000537F File Offset: 0x0000377F
		private void Button2_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl11.Hide();
			this.userControl31.Hide();
			this.userControl21.Show();
			this.userControl21.BringToFront();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000053B2 File Offset: 0x000037B2
		private void Button3_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl11.Hide();
			this.userControl31.Show();
			this.userControl31.BringToFront();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000053E8 File Offset: 0x000037E8
		private void Top_Panel_MouseMove(object sender, MouseEventArgs e)
		{
			bool grip = this.Grip;
			if (grip)
			{
				base.Left = Cursor.Position.X - this.MouseX;
				base.Top = Cursor.Position.Y - this.MouseY;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005438 File Offset: 0x00003838
		private void Top_Panel_MouseUp(object sender, MouseEventArgs e)
		{
			this.Grip = false;
			this.MouseX = 0;
			this.MouseY = 0;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000030C4 File Offset: 0x000014C4
		private void Button_Top_Panel_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000030CE File Offset: 0x000014CE
		private void Button2_Top_Panel_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000030D9 File Offset: 0x000014D9
		private void Top_Panel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000030D9 File Offset: 0x000014D9
		private void Icon_User_Panel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000030D9 File Offset: 0x000014D9
		private void Button_Button_Panel_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000030D9 File Offset: 0x000014D9
		private void Button_Button_Panel_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000030D9 File Offset: 0x000014D9
		private void userControl41_Load_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00005450 File Offset: 0x00003850
		private void label1_Click(object sender, EventArgs e)
		{
			this.userControl21.Hide();
			this.userControl31.Hide();
			this.userControl11.Hide();
			this.userControl41.Show();
			this.userControl41.BringToFront();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00005490 File Offset: 0x00003890
		private void Top_Panel_MouseDown(object sender, MouseEventArgs e)
		{
			this.Grip = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x04000074 RID: 116
		private static SerialPort serial;

		// Token: 0x04000075 RID: 117
		private const int MOUSEEVENTF_LEFTDOWN = 2;

		// Token: 0x04000076 RID: 118
		private const int MOUSEEVENTF_LEFTUP = 4;

		// Token: 0x04000077 RID: 119
		public static api KeyAuthApp = new api("BlastProduction", "p0ej3FMYJt", "8940a68775345ea0a69c88f2d55c7d7c325b3005238b6948290a7720d38b92c9", "2.1");

		// Token: 0x04000078 RID: 120
		private const int SRCCOPY = 13369376;

		// Token: 0x04000079 RID: 121
		private const int CAPTUREBLT = 1073741824;

		// Token: 0x0400007A RID: 122
		public static List<Color> myList = new List<Color>();

		// Token: 0x0400007B RID: 123
		private static List<Color> myListdefault = new List<Color>();

		// Token: 0x0400007C RID: 124
		private static CDD dd;

		// Token: 0x0400007D RID: 125
		private static double sens = 0.4;

		// Token: 0x0400007E RID: 126
		private static double sensitivity_x = 1.0 / Main_Form.sens / ((double)config.screenWidth / 1920.0) * 1.08;

		// Token: 0x0400007F RID: 127
		private static double sensitivity_y = 1.0 / Main_Form.sens / ((double)config.screenHeight / 1080.0) * 1.08;

		// Token: 0x04000080 RID: 128
		private static DateTime asda = DateTime.Now;

		// Token: 0x04000081 RID: 129
		private const double size = 60.0;

		// Token: 0x04000082 RID: 130
		private const int maxCount = 5;

		// Token: 0x04000083 RID: 131
		private bool Grip;

		// Token: 0x04000084 RID: 132
		private int MouseX;

		// Token: 0x04000085 RID: 133
		private int MouseY;
	}
}
