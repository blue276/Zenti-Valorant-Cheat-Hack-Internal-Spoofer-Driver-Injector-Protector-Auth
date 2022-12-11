using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace SkyCheats
{
	// Token: 0x0200000E RID: 14
	internal static class DebuggerAcl
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00002D58 File Offset: 0x00001158
		internal static void SelfDeletea()
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

		// Token: 0x060000EE RID: 238 RVA: 0x00002DB0 File Offset: 0x000011B0
		internal static bool Run()
		{
			for (;;)
			{
				bool flag = false;
				bool flag2 = Debugger.IsAttached || Debugger.IsLogging();
				if (flag2)
				{
					Environment.Exit(0);
				}
				else
				{
					string[] array = new string[]
					{
						"codecracker",
						"x32dbg",
						"x64dbg",
						"ollydbg",
						"ida",
						"charles",
						"dnspy",
						"simpleassembly",
						"peek",
						"httpanalyzer",
						"httpdebug",
						"fiddler",
						"wireshark",
						"dbx",
						"mdbg",
						"gdb",
						"windbg",
						"dbgclr",
						"kdb",
						"kgdb",
						"mdb",
						"processhacker",
						"scylla_x86",
						"scylla_x64",
						"scylla",
						"idau64",
						"idau",
						"idaq",
						"idaq64",
						"idaw",
						"idaw64",
						"idag",
						"idag64",
						"ida64",
						"ida",
						"ImportREC",
						"IMMUNITYDEBUGGER",
						"MegaDumper",
						"CodeBrowser",
						"reshacker",
						"cheatengine-x86_64-SSE4-AVX2",
						"cheat engine"
					};
					foreach (Process process in Process.GetProcesses())
					{
						bool flag3 = process != Process.GetCurrentProcess();
						if (flag3)
						{
							for (int j = 0; j < array.Length; j++)
							{
								bool flag4 = process.ProcessName.ToLower().Contains(array[j]);
								if (flag4)
								{
									flag = true;
								}
								bool flag5 = process.MainWindowTitle.ToLower().Contains(array[j]);
								if (flag5)
								{
									flag = true;
								}
							}
						}
					}
				}
				bool flag6 = flag;
				if (flag6)
				{
					Environment.Exit(0);
				}
				Thread.Sleep(3000);
			}
		}
	}
}
