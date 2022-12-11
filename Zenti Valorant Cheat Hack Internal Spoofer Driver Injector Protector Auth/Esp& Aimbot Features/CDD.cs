using System;
using System.Runtime.InteropServices;

namespace SkyCheats
{
	// Token: 0x02000004 RID: 4
	internal class CDD
	{
		// Token: 0x0600000C RID: 12
		[DllImport("Kernel32")]
		private static extern IntPtr LoadLibrary(string dllfile);

		// Token: 0x0600000D RID: 13
		[DllImport("Kernel32")]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x0600000E RID: 14
		[DllImport("kernel32.dll")]
		public static extern bool FreeLibrary(IntPtr hModule);

		// Token: 0x0600000F RID: 15 RVA: 0x0000259C File Offset: 0x0000099C
		public int Load(string dllfile)
		{
			this.m_hinst = CDD.LoadLibrary(dllfile);
			bool flag = this.m_hinst.Equals(IntPtr.Zero);
			int result;
			if (flag)
			{
				result = -2;
			}
			else
			{
				result = this.GetDDfunAddress(this.m_hinst);
			}
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000025E8 File Offset: 0x000009E8
		private int GetDDfunAddress(IntPtr hinst)
		{
			IntPtr procAddress = CDD.GetProcAddress(hinst, "DD_btn");
			bool flag = procAddress.Equals(IntPtr.Zero);
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				this.btn = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_btn)) as CDD.pDD_btn);
				bool flag2 = procAddress.Equals(IntPtr.Zero);
				if (flag2)
				{
					result = -1;
				}
				else
				{
					procAddress = CDD.GetProcAddress(hinst, "DD_whl");
					this.whl = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_whl)) as CDD.pDD_whl);
					bool flag3 = procAddress.Equals(IntPtr.Zero);
					if (flag3)
					{
						result = -1;
					}
					else
					{
						procAddress = CDD.GetProcAddress(hinst, "DD_mov");
						this.mov = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_mov)) as CDD.pDD_mov);
						bool flag4 = procAddress.Equals(IntPtr.Zero);
						if (flag4)
						{
							result = -1;
						}
						else
						{
							procAddress = CDD.GetProcAddress(hinst, "DD_key");
							this.key = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_key)) as CDD.pDD_key);
							bool flag5 = procAddress.Equals(IntPtr.Zero);
							if (flag5)
							{
								result = -1;
							}
							else
							{
								procAddress = CDD.GetProcAddress(hinst, "DD_movR");
								this.movR = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_movR)) as CDD.pDD_movR);
								bool flag6 = procAddress.Equals(IntPtr.Zero);
								if (flag6)
								{
									result = -1;
								}
								else
								{
									procAddress = CDD.GetProcAddress(hinst, "DD_str");
									this.str = (Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CDD.pDD_str)) as CDD.pDD_str);
									bool flag7 = procAddress.Equals(IntPtr.Zero);
									if (flag7)
									{
										result = -1;
									}
									else
									{
										procAddress = CDD.GetProcAddress(hinst, "DD_todc");
										result = 1;
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public CDD.pDD_btn btn;

		// Token: 0x04000002 RID: 2
		public CDD.pDD_whl whl;

		// Token: 0x04000003 RID: 3
		public CDD.pDD_mov mov;

		// Token: 0x04000004 RID: 4
		public CDD.pDD_movR movR;

		// Token: 0x04000005 RID: 5
		public CDD.pDD_key key;

		// Token: 0x04000006 RID: 6
		public CDD.pDD_str str;

		// Token: 0x04000007 RID: 7
		private IntPtr m_hinst;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000013 RID: 19
		public delegate int pDD_btn(int btn);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000017 RID: 23
		public delegate int pDD_whl(int whl);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600001B RID: 27
		public delegate int pDD_key(int ddcode, int flag);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001F RID: 31
		public delegate int pDD_mov(int x, int y);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000023 RID: 35
		public delegate int pDD_movR(int dx, int dy);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000027 RID: 39
		public delegate int pDD_str(string str);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600002B RID: 43
		public delegate int pDD_todc(int vkcode);
	}
}
