using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Loader.Security.AntiProcess
{
	// Token: 0x02000034 RID: 52
	internal class AntiProcessHandler
	{
		// Token: 0x0600032C RID: 812 RVA: 0x000244A4 File Offset: 0x000228A4
		public static void ScanAndKill()
		{
			bool flag = AntiProcessHandler.Scan(true) != 0;
			if (flag)
			{
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000244C4 File Offset: 0x000228C4
		private static int Scan(bool KillProcess)
		{
			int result = 0;
			bool flag = AntiProcessHandler.BadProcessnameList.Count == 0 && AntiProcessHandler.BadWindowTextList.Count == 0;
			if (flag)
			{
				AntiProcessHandler.Init();
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag2 = AntiProcessHandler.BadProcessnameList.Contains(process.ProcessName) || AntiProcessHandler.BadWindowTextList.Contains(process.MainWindowTitle);
				if (flag2)
				{
					result = 1;
					if (KillProcess)
					{
						try
						{
							process.Kill();
						}
						catch
						{
						}
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00024584 File Offset: 0x00022984
		private static int Init()
		{
			bool flag = AntiProcessHandler.BadProcessnameList.Count > 0 && AntiProcessHandler.BadWindowTextList.Count > 0;
			int result;
			if (flag)
			{
				result = 1;
			}
			else
			{
				AntiProcessHandler.BadProcessnameList.Add("ollydbg");
				AntiProcessHandler.BadProcessnameList.Add("cmd");
				AntiProcessHandler.BadProcessnameList.Add("ida64");
				AntiProcessHandler.BadProcessnameList.Add("idag");
				AntiProcessHandler.BadProcessnameList.Add("idag64");
				AntiProcessHandler.BadProcessnameList.Add("idaw");
				AntiProcessHandler.BadProcessnameList.Add("idaw64");
				AntiProcessHandler.BadProcessnameList.Add("idaq");
				AntiProcessHandler.BadProcessnameList.Add("idaq64");
				AntiProcessHandler.BadProcessnameList.Add("idau");
				AntiProcessHandler.BadProcessnameList.Add("idau64");
				AntiProcessHandler.BadProcessnameList.Add("scylla");
				AntiProcessHandler.BadProcessnameList.Add("scylla_x64");
				AntiProcessHandler.BadProcessnameList.Add("scylla_x86");
				AntiProcessHandler.BadProcessnameList.Add("protection_id");
				AntiProcessHandler.BadProcessnameList.Add("x64dbg");
				AntiProcessHandler.BadProcessnameList.Add("x32dbg");
				AntiProcessHandler.BadProcessnameList.Add("windbg");
				AntiProcessHandler.BadProcessnameList.Add("reshacker");
				AntiProcessHandler.BadProcessnameList.Add("ImportREC");
				AntiProcessHandler.BadProcessnameList.Add("IMMUNITYDEBUGGER");
				AntiProcessHandler.BadProcessnameList.Add("MegaDumper");
				AntiProcessHandler.BadWindowTextList.Add("HTTPDebuggerUI");
				AntiProcessHandler.BadWindowTextList.Add("HTTPDebuggerSvc");
				AntiProcessHandler.BadWindowTextList.Add("HTTP Debugger");
				AntiProcessHandler.BadWindowTextList.Add("HTTP Debugger (32 bit)");
				AntiProcessHandler.BadWindowTextList.Add("HTTP Debugger (64 bit)");
				AntiProcessHandler.BadWindowTextList.Add("OLLYDBG");
				AntiProcessHandler.BadWindowTextList.Add("ida");
				AntiProcessHandler.BadWindowTextList.Add("disassembly");
				AntiProcessHandler.BadWindowTextList.Add("scylla");
				AntiProcessHandler.BadWindowTextList.Add("Debug");
				AntiProcessHandler.BadWindowTextList.Add("[CPU");
				AntiProcessHandler.BadWindowTextList.Add("Immunity");
				AntiProcessHandler.BadWindowTextList.Add("WinDbg");
				AntiProcessHandler.BadWindowTextList.Add("x32dbg");
				AntiProcessHandler.BadWindowTextList.Add("x64dbg");
				AntiProcessHandler.BadWindowTextList.Add("Import reconstructor");
				AntiProcessHandler.BadWindowTextList.Add("MegaDumper");
				AntiProcessHandler.BadWindowTextList.Add("MegaDumper 1.0 by CodeCracker / SnD");
				AntiProcessHandler.BadWindowTextList.Add("cmd");
				result = 0;
			}
			return result;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00024850 File Offset: 0x00022C50
		public static void KillProcess()
		{
			string[] array = new string[]
			{
				"dnspy",
				"codecracker",
				"x32dbg",
				"x64dbg",
				"ollydbg",
				"ida",
				"charles",
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
				"cheat engine"
			};
			foreach (Process process in Process.GetProcesses())
			{
				bool flag = process != Process.GetCurrentProcess();
				if (flag)
				{
					for (int j = 0; j < array.Length; j++)
					{
						bool flag2 = process.ProcessName.ToLower().Contains(array[j]);
						if (flag2)
						{
							Environment.Exit(123);
						}
						bool flag3 = process.MainWindowTitle.ToLower().Contains(array[j]);
						if (flag3)
						{
							Environment.Exit(0);
						}
					}
				}
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00024A59 File Offset: 0x00022E59
		public static void Checker()
		{
			AntiProcessHandler.KillProcess();
			AntiProcessHandler.Scan(true);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00024A6C File Offset: 0x00022E6C
		private static void InitializeProcess()
		{
			Task task = Task.Factory.StartNew(new Action(AntiProcessHandler.Checker), default(CancellationToken), TaskCreationOptions.RunContinuationsAsynchronously, TaskScheduler.Current);
		}

		// Token: 0x04000290 RID: 656
		private static HashSet<string> BadProcessnameList = new HashSet<string>();

		// Token: 0x04000291 RID: 657
		private static HashSet<string> BadWindowTextList = new HashSet<string>();
	}
}
