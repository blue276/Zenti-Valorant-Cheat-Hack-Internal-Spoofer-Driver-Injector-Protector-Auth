using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Loader.Security.AntiDLLInject
{
	// Token: 0x02000037 RID: 55
	internal class AntiDLLInject
	{
		// Token: 0x06000339 RID: 825
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lib);

		// Token: 0x0600033A RID: 826
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr ModuleHandle, string Function);

		// Token: 0x0600033B RID: 827
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr ProcHandle, IntPtr BaseAddress, byte[] Buffer, uint size, int NumOfBytes);

		// Token: 0x0600033C RID: 828 RVA: 0x000251C4 File Offset: 0x000235C4
		public static string PatchLoadLibraryA()
		{
			IntPtr moduleHandle = AntiDLLInject.GetModuleHandle("kernelbase.dll");
			IntPtr procAddress = AntiDLLInject.GetProcAddress(moduleHandle, "LoadLibraryA");
			byte[] array = new byte[3];
			array[0] = 194;
			array[1] = 4;
			byte[] buffer = array;
			bool flag = AntiDLLInject.WriteProcessMemory(Process.GetCurrentProcess().Handle, procAddress, buffer, 3U, 0);
			bool flag2 = flag;
			string result;
			if (flag2)
			{
				result = "Success";
			}
			else
			{
				result = "Failed";
			}
			return result;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0002522C File Offset: 0x0002362C
		public static string PatchLoadLibraryW()
		{
			IntPtr moduleHandle = AntiDLLInject.GetModuleHandle("kernelbase.dll");
			IntPtr procAddress = AntiDLLInject.GetProcAddress(moduleHandle, "LoadLibraryW");
			byte[] array = new byte[3];
			array[0] = 194;
			array[1] = 4;
			byte[] buffer = array;
			bool flag = AntiDLLInject.WriteProcessMemory(Process.GetCurrentProcess().Handle, procAddress, buffer, 3U, 0);
			bool flag2 = flag;
			string result;
			if (flag2)
			{
				result = "Success";
			}
			else
			{
				result = "Failed";
			}
			return result;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00025294 File Offset: 0x00023694
		public static void InitializeDLLInject()
		{
			bool flag = AntiDLLInject.PatchLoadLibraryA() != "Success";
			if (flag)
			{
				Environment.FailFast(null);
			}
			bool flag2 = AntiDLLInject.PatchLoadLibraryW() != "Success";
			if (flag2)
			{
				Environment.FailFast(null);
			}
		}
	}
}
