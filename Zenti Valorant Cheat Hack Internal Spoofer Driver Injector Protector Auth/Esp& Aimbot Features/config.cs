using System;

namespace SkyCheats
{
	// Token: 0x0200000C RID: 12
	public class config
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000027C0 File Offset: 0x00000BC0
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000027C7 File Offset: 0x00000BC7
		public static string subscription { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000027CF File Offset: 0x00000BCF
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000027D6 File Offset: 0x00000BD6
		public static string expiry { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000027DE File Offset: 0x00000BDE
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000027E5 File Offset: 0x00000BE5
		public static string timeleft { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000027ED File Offset: 0x00000BED
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000027F4 File Offset: 0x00000BF4
		public static string port { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000027FC File Offset: 0x00000BFC
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002803 File Offset: 0x00000C03
		public static bool aimbot_state { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000280B File Offset: 0x00000C0B
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002812 File Offset: 0x00000C12
		public static bool flick_state { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000281A File Offset: 0x00000C1A
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002821 File Offset: 0x00000C21
		public static bool silent_state { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002829 File Offset: 0x00000C29
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002830 File Offset: 0x00000C30
		public static bool aimbot_state_checkbox { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002838 File Offset: 0x00000C38
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000283F File Offset: 0x00000C3F
		public static bool flick_state_checkbox { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002847 File Offset: 0x00000C47
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000284E File Offset: 0x00000C4E
		public static bool silent_state_checkbox { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002856 File Offset: 0x00000C56
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000285D File Offset: 0x00000C5D
		public static double smooth { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002865 File Offset: 0x00000C65
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000286C File Offset: 0x00000C6C
		public static double rcs_smooth { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002874 File Offset: 0x00000C74
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000287B File Offset: 0x00000C7B
		public static bool aim_color_state { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002883 File Offset: 0x00000C83
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0000288A File Offset: 0x00000C8A
		public static bool triggerbot_state { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002892 File Offset: 0x00000C92
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002899 File Offset: 0x00000C99
		public static bool auto_fire_state { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000028A1 File Offset: 0x00000CA1
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000028A8 File Offset: 0x00000CA8
		public static bool aim_only_on_x_state { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000028B0 File Offset: 0x00000CB0
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000028B7 File Offset: 0x00000CB7
		public static bool smooth_state { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000028BF File Offset: 0x00000CBF
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000028C6 File Offset: 0x00000CC6
		public static bool trigger_force_hs_state { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000028CE File Offset: 0x00000CCE
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000028D5 File Offset: 0x00000CD5
		public static bool Havali { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000028DD File Offset: 0x00000CDD
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000028E4 File Offset: 0x00000CE4
		public static int HavaliDegil { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000028EC File Offset: 0x00000CEC
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000028F3 File Offset: 0x00000CF3
		public static bool ignore_sky_skills { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000028FB File Offset: 0x00000CFB
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002902 File Offset: 0x00000D02
		public static bool bone1_state { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000290A File Offset: 0x00000D0A
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002911 File Offset: 0x00000D11
		public static bool bone2_state { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002919 File Offset: 0x00000D19
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002920 File Offset: 0x00000D20
		public static bool recoil_system_state { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002928 File Offset: 0x00000D28
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000292F File Offset: 0x00000D2F
		public static bool hip_fire_state { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002937 File Offset: 0x00000D37
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000293E File Offset: 0x00000D3E
		public static int aimbot_on_of_key { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002946 File Offset: 0x00000D46
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000294D File Offset: 0x00000D4D
		public static int triggerbot_on_of_key { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002955 File Offset: 0x00000D55
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000295C File Offset: 0x00000D5C
		public static int autofire_on_of_key { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002964 File Offset: 0x00000D64
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000296B File Offset: 0x00000D6B
		public static int aimonlyonx_on_of_key { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002973 File Offset: 0x00000D73
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000297A File Offset: 0x00000D7A
		public static int smooth_on_of_key { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002982 File Offset: 0x00000D82
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002989 File Offset: 0x00000D89
		public static int ignoreskyskills_on_of_key { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002991 File Offset: 0x00000D91
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002998 File Offset: 0x00000D98
		public static int flick_on_of_key { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000029A0 File Offset: 0x00000DA0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000029A7 File Offset: 0x00000DA7
		public static int silent_on_of_key { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000029AF File Offset: 0x00000DAF
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000029B6 File Offset: 0x00000DB6
		public static int aim_key { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000029BE File Offset: 0x00000DBE
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000029C5 File Offset: 0x00000DC5
		public static int trigger_key { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000029CD File Offset: 0x00000DCD
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000029D4 File Offset: 0x00000DD4
		public static int bone1_key { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000029DC File Offset: 0x00000DDC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000029E3 File Offset: 0x00000DE3
		public static int bone2_key { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000029EB File Offset: 0x00000DEB
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000029F2 File Offset: 0x00000DF2
		public static string bone1_target { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000029FA File Offset: 0x00000DFA
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002A01 File Offset: 0x00000E01
		public static string bone2_target { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002A09 File Offset: 0x00000E09
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002A10 File Offset: 0x00000E10
		public static string color { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002A18 File Offset: 0x00000E18
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002A1F File Offset: 0x00000E1F
		public static int mov_x { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002A27 File Offset: 0x00000E27
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002A2E File Offset: 0x00000E2E
		public static int mov_y { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002A36 File Offset: 0x00000E36
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002A3D File Offset: 0x00000E3D
		public static int fov_x { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002A45 File Offset: 0x00000E45
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002A4C File Offset: 0x00000E4C
		public static int fov_y { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002A54 File Offset: 0x00000E54
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002A5B File Offset: 0x00000E5B
		public static int shot_speed { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002A63 File Offset: 0x00000E63
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002A6A File Offset: 0x00000E6A
		public static int trigger_speed { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002A72 File Offset: 0x00000E72
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002A79 File Offset: 0x00000E79
		public static int screenWidth { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002A81 File Offset: 0x00000E81
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002A88 File Offset: 0x00000E88
		public static int screenHeight { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002A90 File Offset: 0x00000E90
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002A97 File Offset: 0x00000E97
		public static int extras { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002A9F File Offset: 0x00000E9F
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002AA6 File Offset: 0x00000EA6
		public static int max_recoil { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002AAE File Offset: 0x00000EAE
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002AB5 File Offset: 0x00000EB5
		public static double recoilspeed { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002ABD File Offset: 0x00000EBD
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002AC4 File Offset: 0x00000EC4
		public static int headx { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002ACC File Offset: 0x00000ECC
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002AD3 File Offset: 0x00000ED3
		public static int heady { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002ADB File Offset: 0x00000EDB
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002AE2 File Offset: 0x00000EE2
		public static int bodyx { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002AEA File Offset: 0x00000EEA
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002AF1 File Offset: 0x00000EF1
		public static int bodyy { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002AF9 File Offset: 0x00000EF9
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002B00 File Offset: 0x00000F00
		public static int uwux { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002B08 File Offset: 0x00000F08
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002B0F File Offset: 0x00000F0F
		public static int uwuy { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002B17 File Offset: 0x00000F17
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002B1E File Offset: 0x00000F1E
		public static bool bodypartcheckboxselectiontruefalse { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002B26 File Offset: 0x00000F26
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002B2D File Offset: 0x00000F2D
		public static string typeoflog { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002B35 File Offset: 0x00000F35
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002B3C File Offset: 0x00000F3C
		public static bool checkautofire { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002B44 File Offset: 0x00000F44
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002B4B File Offset: 0x00000F4B
		public static string expirylefttime { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002B53 File Offset: 0x00000F53
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002B5A File Offset: 0x00000F5A
		public static int weapon1_key { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002B62 File Offset: 0x00000F62
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002B69 File Offset: 0x00000F69
		public static int weapon2_key { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002B71 File Offset: 0x00000F71
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002B78 File Offset: 0x00000F78
		public static int weapon3_key { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002B80 File Offset: 0x00000F80
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002B87 File Offset: 0x00000F87
		public static bool weapon1_state { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002B8F File Offset: 0x00000F8F
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002B96 File Offset: 0x00000F96
		public static bool weapon2_state { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002B9E File Offset: 0x00000F9E
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002BA5 File Offset: 0x00000FA5
		public static bool weapon3_state { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002BAD File Offset: 0x00000FAD
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002BB4 File Offset: 0x00000FB4
		public static int weapon1_value { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002BBC File Offset: 0x00000FBC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002BC3 File Offset: 0x00000FC3
		public static int weapon2_value { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002BCB File Offset: 0x00000FCB
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002BD2 File Offset: 0x00000FD2
		public static int weapon3_value { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002BDA File Offset: 0x00000FDA
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002BE1 File Offset: 0x00000FE1
		public static int flick_fovx { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002BE9 File Offset: 0x00000FE9
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002BF0 File Offset: 0x00000FF0
		public static int flick_fovy { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002BF8 File Offset: 0x00000FF8
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002BFF File Offset: 0x00000FFF
		public static int silent_fovx { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002C07 File Offset: 0x00001007
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002C0E File Offset: 0x0000100E
		public static int silent_fovy { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002C16 File Offset: 0x00001016
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002C1D File Offset: 0x0000101D
		public static int flick_delay { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002C25 File Offset: 0x00001025
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002C2C File Offset: 0x0000102C
		public static int silent_delay { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002C34 File Offset: 0x00001034
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002C3B File Offset: 0x0000103B
		public static double weapon1_speed { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002C43 File Offset: 0x00001043
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002C4A File Offset: 0x0000104A
		public static double weapon2_speed { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002C52 File Offset: 0x00001052
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002C59 File Offset: 0x00001059
		public static double weapon3_speed { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002C61 File Offset: 0x00001061
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002C68 File Offset: 0x00001068
		public static double sens { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002C70 File Offset: 0x00001070
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002C77 File Offset: 0x00001077
		public static double sensitivity_x { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002C7F File Offset: 0x0000107F
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002C86 File Offset: 0x00001086
		public static double sensitivity_y { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002C8E File Offset: 0x0000108E
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002C95 File Offset: 0x00001095
		public static int color_int { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002C9D File Offset: 0x0000109D
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002CA4 File Offset: 0x000010A4
		public static int silent_key { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002CAC File Offset: 0x000010AC
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002CB3 File Offset: 0x000010B3
		public static int flick_key { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002CBB File Offset: 0x000010BB
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002CC2 File Offset: 0x000010C2
		public static bool flick_active { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00002CCA File Offset: 0x000010CA
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002CD1 File Offset: 0x000010D1
		public static bool silent_active { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002CD9 File Offset: 0x000010D9
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002CE0 File Offset: 0x000010E0
		public static string usernamee { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002CE8 File Offset: 0x000010E8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002CEF File Offset: 0x000010EF
		public static string passwordd { get; set; }

		// Token: 0x0400000B RID: 11
		public static config.user_data_class user_data = new config.user_data_class();

		// Token: 0x0200000D RID: 13
		public class user_data_class
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002D03 File Offset: 0x00001103
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002D0B File Offset: 0x0000110B
			public string username { get; set; }

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002D14 File Offset: 0x00001114
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002D1C File Offset: 0x0000111C
			public string ip { get; set; }

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002D25 File Offset: 0x00001125
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002D2D File Offset: 0x0000112D
			public string hwid { get; set; }

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002D36 File Offset: 0x00001136
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002D3E File Offset: 0x0000113E
			public string createdate { get; set; }

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060000EA RID: 234 RVA: 0x00002D47 File Offset: 0x00001147
			// (set) Token: 0x060000EB RID: 235 RVA: 0x00002D4F File Offset: 0x0000114F
			public string lastlogin { get; set; }
		}
	}
}
