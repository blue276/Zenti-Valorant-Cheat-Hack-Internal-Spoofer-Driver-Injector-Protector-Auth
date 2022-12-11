using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Loader.Security.AntiDump
{
	// Token: 0x02000035 RID: 53
	internal class AntiDumpHandler
	{
		// Token: 0x06000334 RID: 820 RVA: 0x000030D9 File Offset: 0x000014D9
		public unsafe static void CopyBlock(void* destination, void* source, uint byteCount)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000030D9 File Offset: 0x000014D9
		public unsafe static void InitBlock(void* startAddress, byte value, uint byteCount)
		{
		}

		// Token: 0x06000336 RID: 822
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, [MarshalAs(UnmanagedType.U4)] AntiDumpHandler.MemoryProtection flNewProtect, [MarshalAs(UnmanagedType.U4)] out AntiDumpHandler.MemoryProtection lpflOldProtect);

		// Token: 0x06000337 RID: 823 RVA: 0x00024AB8 File Offset: 0x00022EB8
		public unsafe static void InitializeDump()
		{
			Module module = typeof(AntiDumpHandler).Module;
			byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(module));
			byte* ptr2 = ptr + 60;
			ptr2 = ptr + *(uint*)ptr2;
			ptr2 += 6;
			ushort num = *(ushort*)ptr2;
			ptr2 += 14;
			ushort num2 = *(ushort*)ptr2;
			ptr2 = ptr2 + 4 + num2;
			byte* ptr3 = stackalloc byte[(UIntPtr)11];
			bool flag = module.FullyQualifiedName[0] != '<';
			if (flag)
			{
				byte* ptr4 = ptr + *(uint*)(ptr2 - 16);
				bool flag2 = *(uint*)(ptr2 - 120) > 0U;
				AntiDumpHandler.MemoryProtection memoryProtection;
				if (flag2)
				{
					byte* ptr5 = ptr + *(uint*)(ptr2 - 120);
					byte* ptr6 = ptr + *(uint*)ptr5;
					byte* ptr7 = ptr + *(uint*)(ptr5 + 12);
					byte* ptr8 = ptr + *(uint*)ptr6 + 2;
					AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr7), 11U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
					*(int*)ptr3 = 1818522734;
					*(int*)(ptr3 + 4) = 1818504812;
					*(short*)(ptr3 + (IntPtr)4 * 2) = 108;
					ptr3[10] = 0;
					AntiDumpHandler.CopyBlock((void*)ptr7, (void*)ptr3, 11U);
					AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr8), 11U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
					*(int*)ptr3 = 1866691662;
					*(int*)(ptr3 + 4) = 1852404846;
					*(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
					ptr3[10] = 0;
					AntiDumpHandler.CopyBlock((void*)ptr8, (void*)ptr3, 11U);
				}
				for (int i = 0; i < (int)num; i++)
				{
					AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr2), 8U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
					AntiDumpHandler.InitBlock((void*)ptr2, 0, 8U);
					ptr2 += 40;
				}
				AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr4), 72U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
				byte* ptr9 = ptr + *(uint*)(ptr4 + 8);
				AntiDumpHandler.InitBlock((void*)ptr4, 0, 16U);
				AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr9), 4U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
				*(int*)ptr9 = 0;
				ptr9 += 12;
				ptr9 += *(uint*)ptr9;
				ptr9 = (ptr9 + 7L & -4L);
				ptr9 += 2;
				ushort num3 = (ushort)(*ptr9);
				ptr9 += 2;
				for (int j = 0; j < (int)num3; j++)
				{
					AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr9), 8U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
					ptr9 += 4;
					ptr9 += 4;
					for (int k = 0; k < 8; k++)
					{
						AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr9), 4U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
						*ptr9 = 0;
						ptr9++;
						bool flag3 = *ptr9 == 0;
						if (flag3)
						{
							ptr9 += 3;
							break;
						}
						*ptr9 = 0;
						ptr9++;
						bool flag4 = *ptr9 == 0;
						if (flag4)
						{
							ptr9 += 2;
							break;
						}
						*ptr9 = 0;
						ptr9++;
						bool flag5 = *ptr9 == 0;
						if (flag5)
						{
							ptr9++;
							break;
						}
						*ptr9 = 0;
						ptr9++;
					}
				}
			}
			else
			{
				uint num4 = *(uint*)(ptr2 - 16);
				uint num5 = *(uint*)(ptr2 - 120);
				uint[] array = new uint[(int)num];
				uint[] array2 = new uint[(int)num];
				uint[] array3 = new uint[(int)num];
				AntiDumpHandler.MemoryProtection memoryProtection;
				for (int l = 0; l < (int)num; l++)
				{
					AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr2), 8U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
					Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
					array[l] = *(uint*)(ptr2 + 12);
					array2[l] = *(uint*)(ptr2 + 8);
					array3[l] = *(uint*)(ptr2 + 20);
					ptr2 += 40;
				}
				bool flag6 = num5 > 0U;
				if (flag6)
				{
					for (int m = 0; m < (int)num; m++)
					{
						bool flag7 = array[m] <= num5 && num5 < array[m] + array2[m];
						if (flag7)
						{
							num5 = num5 - array[m] + array3[m];
							break;
						}
					}
					byte* ptr10 = ptr + num5;
					uint num6 = *(uint*)ptr10;
					for (int n = 0; n < (int)num; n++)
					{
						bool flag8 = array[n] <= num6 && num6 < array[n] + array2[n];
						if (flag8)
						{
							num6 = num6 - array[n] + array3[n];
							break;
						}
					}
					byte* ptr11 = ptr + num6;
					uint num7 = *(uint*)(ptr10 + 12);
					for (int num8 = 0; num8 < (int)num; num8++)
					{
						bool flag9 = array[num8] <= num7 && num7 < array[num8] + array2[num8];
						if (flag9)
						{
							num7 = num7 - array[num8] + array3[num8];
							break;
						}
					}
					uint num9 = *(uint*)ptr11 + 2U;
					for (int num10 = 0; num10 < (int)num; num10++)
					{
						bool flag10 = array[num10] <= num9 && num9 < array[num10] + array2[num10];
						if (flag10)
						{
							num9 = num9 - array[num10] + array3[num10];
							break;
						}
					}
					AntiDumpHandler.VirtualProtect(new IntPtr((void*)(ptr + num7)), 11U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
					*(int*)ptr3 = 1818522734;
					*(int*)(ptr3 + 4) = 1818504812;
					*(short*)(ptr3 + (IntPtr)4 * 2) = 108;
					ptr3[10] = 0;
					AntiDumpHandler.CopyBlock((void*)(ptr + num7), (void*)ptr3, 11U);
					AntiDumpHandler.VirtualProtect(new IntPtr((void*)(ptr + num9)), 11U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
					*(int*)ptr3 = 1866691662;
					*(int*)(ptr3 + 4) = 1852404846;
					*(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
					ptr3[10] = 0;
					AntiDumpHandler.CopyBlock((void*)(ptr + num9), (void*)ptr3, 11U);
				}
				for (int num11 = 0; num11 < (int)num; num11++)
				{
					bool flag11 = array[num11] <= num4 && num4 < array[num11] + array2[num11];
					if (flag11)
					{
						num4 = num4 - array[num11] + array3[num11];
						break;
					}
				}
				byte* ptr12 = ptr + num4;
				AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr12), 72U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
				uint num12 = *(uint*)(ptr12 + 8);
				for (int num13 = 0; num13 < (int)num; num13++)
				{
					bool flag12 = array[num13] <= num12 && num12 < array[num13] + array2[num13];
					if (flag12)
					{
						num12 = num12 - array[num13] + array3[num13];
						break;
					}
				}
				AntiDumpHandler.InitBlock((void*)ptr12, 0, 16U);
				byte* ptr13 = ptr + num12;
				AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr13), 4U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
				*(int*)ptr13 = 0;
				ptr13 += 12;
				ptr13 += *(uint*)ptr13;
				ptr13 = (ptr13 + 7L & -4L);
				ptr13 += 2;
				ushort num14 = (ushort)(*ptr13);
				ptr13 += 2;
				for (int num15 = 0; num15 < (int)num14; num15++)
				{
					AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr13), 8U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
					ptr13 += 4;
					ptr13 += 4;
					for (int num16 = 0; num16 < 8; num16++)
					{
						AntiDumpHandler.VirtualProtect(new IntPtr((void*)ptr13), 4U, AntiDumpHandler.MemoryProtection.ExecuteReadWrite, out memoryProtection);
						*ptr13 = 0;
						ptr13++;
						bool flag13 = *ptr13 == 0;
						if (flag13)
						{
							ptr13 += 3;
							break;
						}
						*ptr13 = 0;
						ptr13++;
						bool flag14 = *ptr13 == 0;
						if (flag14)
						{
							ptr13 += 2;
							break;
						}
						*ptr13 = 0;
						ptr13++;
						bool flag15 = *ptr13 == 0;
						if (flag15)
						{
							ptr13++;
							break;
						}
						*ptr13 = 0;
						ptr13++;
					}
				}
			}
		}

		// Token: 0x02000036 RID: 54
		internal enum MemoryProtection
		{
			// Token: 0x04000293 RID: 659
			ExecuteReadWrite = 64
		}
	}
}
