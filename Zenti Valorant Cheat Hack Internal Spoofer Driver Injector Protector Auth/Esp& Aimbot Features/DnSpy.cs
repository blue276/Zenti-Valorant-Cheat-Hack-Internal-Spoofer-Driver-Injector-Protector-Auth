using System;
using System.IO;

namespace SkyCheats
{
	// Token: 0x0200000F RID: 15
	internal static class DnSpy
	{
		// Token: 0x060000EF RID: 239 RVA: 0x0000300C File Offset: 0x0000140C
		internal static bool ValueType()
		{
			bool flag = !File.Exists(Environment.ExpandEnvironmentVariables("%appdata%") + "\\dnSpy\\dnSpy.xml");
			return !flag;
		}
	}
}
