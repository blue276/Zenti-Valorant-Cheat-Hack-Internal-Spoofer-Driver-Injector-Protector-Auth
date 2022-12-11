using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using SkyCheats.Properties;

namespace SkyCheats
{
	// Token: 0x02000014 RID: 20
	public class UserControl1 : UserControl
	{
		// Token: 0x0600014F RID: 335
		[DllImport("User32.dll")]
		public static extern short GetAsyncKeyState(int ArrowKeys);

		// Token: 0x06000150 RID: 336 RVA: 0x00007D9D File Offset: 0x0000619D
		public UserControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007DD0 File Offset: 0x000061D0
		private void UserControl1_Load(object sender, EventArgs e)
		{
			config.bodyx = -1;
			config.bodyy = -10;
			config.bone1_target = "BODY";
			config.bone2_target = "NECK";
			config.color = "Purple";
			this.metroComboBox2.Text = this.metroComboBox2.Items[1].ToString();
			this.buttonHead2.Hide();
			this.pictureBoxHead2.Hide();
			this.buttonBody2.Hide();
			this.pictureBoxBody2.Hide();
			this.buttonBody.Hide();
			this.pictureBoxBody.Hide();
			this.buttonNeck.Hide();
			this.pictureBoxNeck.Hide();
			this.timer1.Start();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00007E9C File Offset: 0x0000629C
		public void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = config.Havali && config.HavaliDegil == 1;
			if (flag)
			{
				this.label1.ForeColor = Color.FromArgb(255, 153, 51, 204);
				config.HavaliDegil = 0;
			}
			else
			{
				bool flag2 = !config.Havali && config.HavaliDegil == 1;
				if (flag2)
				{
					this.label1.ForeColor = Color.FromArgb(255, 0, 174, 219);
					config.HavaliDegil = 0;
				}
			}
			bool flag3 = UserControl1.GetAsyncKeyState(config.autofire_on_of_key) < 0;
			if (flag3)
			{
				this.metroCheckBox4.Checked = !this.metroCheckBox4.Checked;
				while (UserControl1.GetAsyncKeyState(config.autofire_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag4 = UserControl1.GetAsyncKeyState(config.aimonlyonx_on_of_key) < 0;
			if (flag4)
			{
				this.metroCheckBox3.Checked = !this.metroCheckBox3.Checked;
				while (UserControl1.GetAsyncKeyState(config.aimonlyonx_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag5 = UserControl1.GetAsyncKeyState(config.smooth_on_of_key) < 0;
			if (flag5)
			{
				this.metroCheckBox6.Checked = !this.metroCheckBox6.Checked;
				while (UserControl1.GetAsyncKeyState(config.smooth_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag6 = UserControl1.GetAsyncKeyState(config.ignoreskyskills_on_of_key) < 0;
			if (flag6)
			{
				this.metroCheckBox5.Checked = !this.metroCheckBox5.Checked;
				while (UserControl1.GetAsyncKeyState(config.ignoreskyskills_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag7 = UserControl1.GetAsyncKeyState(config.flick_on_of_key) < 0;
			if (flag7)
			{
				this.metroCheckBox11.Checked = !this.metroCheckBox11.Checked;
				while (UserControl1.GetAsyncKeyState(config.flick_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag8 = UserControl1.GetAsyncKeyState(config.silent_on_of_key) < 0;
			if (flag8)
			{
				this.metroCheckBox10.Checked = !this.metroCheckBox10.Checked;
				while (UserControl1.GetAsyncKeyState(config.silent_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag9 = UserControl1.GetAsyncKeyState(config.triggerbot_on_of_key) < 0;
			if (flag9)
			{
				this.metroCheckBox2.Checked = !this.metroCheckBox2.Checked;
				while (UserControl1.GetAsyncKeyState(config.triggerbot_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag10 = UserControl1.GetAsyncKeyState(config.aimbot_on_of_key) < 0;
			if (flag10)
			{
				this.metroCheckBox1.Checked = !this.metroCheckBox1.Checked;
				while (UserControl1.GetAsyncKeyState(config.aimbot_on_of_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag11 = UserControl1.GetAsyncKeyState(config.bone1_key) < 0;
			if (flag11)
			{
				this.metroCheckBox7.Checked = true;
				this.metroCheckBox8.Checked = false;
				while (UserControl1.GetAsyncKeyState(config.bone1_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag12 = UserControl1.GetAsyncKeyState(config.bone2_key) < 0;
			if (flag12)
			{
				this.metroCheckBox8.Checked = true;
				this.metroCheckBox7.Checked = false;
				while (UserControl1.GetAsyncKeyState(config.bone2_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00008238 File Offset: 0x00006638
		private void buttonNeck2_Click(object sender, EventArgs e)
		{
			config.bone1_target = "HEAD";
			config.uwux = config.headx;
			config.uwuy = config.heady;
			this.buttonNeck2.Hide();
			this.pictureBoxNeck2.Hide();
			this.buttonHead2.Show();
			this.pictureBoxHead2.Show();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00008298 File Offset: 0x00006698
		private void buttonHead2_Click(object sender, EventArgs e)
		{
			config.bone1_target = "BODY";
			config.uwux = config.bodyx;
			config.uwuy = config.bodyy;
			this.buttonHead2.Hide();
			this.pictureBoxHead2.Hide();
			this.buttonBody2.Show();
			this.pictureBoxBody2.Show();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000082F8 File Offset: 0x000066F8
		private void buttonBody2_Click(object sender, EventArgs e)
		{
			config.bone1_target = "NECK";
			config.uwux = -1;
			config.uwuy = -5;
			this.buttonBody2.Hide();
			this.pictureBoxBody2.Hide();
			this.buttonNeck2.Show();
			this.pictureBoxNeck2.Show();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00008350 File Offset: 0x00006750
		private void buttonHead_Click(object sender, EventArgs e)
		{
			config.bone2_target = "BODY";
			config.uwux = config.bodyx;
			config.uwuy = config.bodyy;
			this.buttonHead.Hide();
			this.pictureBoxHead.Hide();
			this.buttonBody.Show();
			this.pictureBoxBody.Show();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000083B0 File Offset: 0x000067B0
		private void buttonBody_Click(object sender, EventArgs e)
		{
			config.bone2_target = "NECK";
			config.uwux = -1;
			config.uwuy = -5;
			this.buttonBody.Hide();
			this.pictureBoxBody.Hide();
			this.buttonNeck.Show();
			this.pictureBoxNeck.Show();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008408 File Offset: 0x00006808
		private void buttonNeck_Click(object sender, EventArgs e)
		{
			config.bone2_target = "HEAD";
			config.uwux = config.headx;
			config.uwuy = config.heady;
			this.buttonNeck.Hide();
			this.pictureBoxNeck.Hide();
			this.buttonHead.Show();
			this.pictureBoxHead.Show();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00008468 File Offset: 0x00006868
		private void label3_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label3.Text = this.get_name_of_key(key);
			bool flag = key != 0;
			if (flag)
			{
				config.aimbot_on_of_key = key;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000084BC File Offset: 0x000068BC
		private int get_key()
		{
			for (int i = 0; i < 150; i++)
			{
				foreach (int num in this.list_characters)
				{
					bool flag = UserControl1.GetAsyncKeyState(num) < 0;
					if (flag)
					{
						return num;
					}
				}
				Thread.Sleep(10);
			}
			return 180;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00008528 File Offset: 0x00006928
		private string get_name_of_key(int key)
		{
			switch (key)
			{
			case 1:
				return "[ Left ]";
			case 2:
				return "[ Right ]";
			case 3:
				return "[ Middle ]";
			case 4:
			case 7:
			case 8:
				break;
			case 5:
				return "[ X1 ]";
			case 6:
				return "[ X2 ]";
			case 9:
				return "[ TAB ]";
			default:
				switch (key)
				{
				case 16:
					return "[ SHIFT ]";
				case 17:
					return "[ CTRL ]";
				case 18:
					return "[ ALT ]";
				default:
					switch (key)
					{
					case 65:
						return "[ A ]";
					case 66:
						return "[ B ]";
					case 67:
						return "[ C ]";
					case 68:
						return "[ D ]";
					case 69:
						return "[ E ]";
					case 70:
						return "[ F ]";
					case 71:
						return "[ G ]";
					case 72:
						return "[ H ]";
					case 73:
						return "[ I ]";
					case 74:
						return "[ J ]";
					case 75:
						return "[ K ]";
					case 76:
						return "[ L ]";
					case 77:
						return "[ M ]";
					case 78:
						return "[ N ]";
					case 79:
						return "[ O ]";
					case 80:
						return "[ P ]";
					case 81:
						return "[ Q ]";
					case 82:
						return "[ R ]";
					case 83:
						return "[ S ]";
					case 84:
						return "[ T ]";
					case 85:
						return "[ U ]";
					case 86:
						return "[ V ]";
					case 87:
						return "[ W ]";
					case 88:
						return "[ X ]";
					case 89:
						return "[ Y ]";
					case 90:
						return "[ Z ]";
					}
					break;
				}
				break;
			}
			return "[ - ]";
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000030D9 File Offset: 0x000014D9
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000030D9 File Offset: 0x000014D9
		private void Picture_UserControl1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000030D9 File Offset: 0x000014D9
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00008754 File Offset: 0x00006B54
		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox2.Checked;
			if (@checked)
			{
				config.triggerbot_state = true;
			}
			else
			{
				config.triggerbot_state = false;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00008788 File Offset: 0x00006B88
		private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox4.Checked;
			if (@checked)
			{
				config.auto_fire_state = true;
			}
			else
			{
				config.auto_fire_state = false;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000087BC File Offset: 0x00006BBC
		private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox3.Checked;
			if (@checked)
			{
				config.aim_only_on_x_state = true;
			}
			else
			{
				config.aim_only_on_x_state = false;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000087F0 File Offset: 0x00006BF0
		private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox6.Checked;
			if (@checked)
			{
				config.smooth_state = true;
			}
			else
			{
				config.smooth_state = false;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00008824 File Offset: 0x00006C24
		private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox5.Checked;
			if (@checked)
			{
				config.ignore_sky_skills = true;
			}
			else
			{
				config.ignore_sky_skills = false;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008858 File Offset: 0x00006C58
		private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox7.Checked;
			if (@checked)
			{
				config.bone1_state = true;
				bool flag = config.bone1_target == "HEAD";
				if (flag)
				{
					config.uwux = config.headx;
					config.uwuy = config.heady;
				}
				else
				{
					bool flag2 = config.bone1_target == "NECK";
					if (flag2)
					{
						config.uwux = -1;
						config.uwuy = -5;
					}
					else
					{
						bool flag3 = config.bone1_target == "BODY";
						if (flag3)
						{
							config.uwux = config.bodyx;
							config.uwuy = config.bodyy;
						}
					}
				}
			}
			else
			{
				config.bone1_state = false;
			}
			bool flag4 = config.bone1_state || config.bone2_state;
			if (flag4)
			{
				config.bodypartcheckboxselectiontruefalse = true;
			}
			else
			{
				config.bodypartcheckboxselectiontruefalse = false;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00008934 File Offset: 0x00006D34
		private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox8.Checked;
			if (@checked)
			{
				config.bone2_state = true;
				bool flag = config.bone2_target == "HEAD";
				if (flag)
				{
					config.uwux = config.headx;
					config.uwuy = config.heady;
				}
				else
				{
					bool flag2 = config.bone2_target == "NECK";
					if (flag2)
					{
						config.uwux = -1;
						config.uwuy = -5;
					}
					else
					{
						bool flag3 = config.bone2_target == "BODY";
						if (flag3)
						{
							config.uwux = config.bodyx;
							config.uwuy = config.bodyy;
						}
					}
				}
			}
			else
			{
				config.bone2_state = false;
			}
			bool flag4 = config.bone1_state || config.bone2_state;
			if (flag4)
			{
				config.bodypartcheckboxselectiontruefalse = true;
			}
			else
			{
				config.bodypartcheckboxselectiontruefalse = false;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00008A10 File Offset: 0x00006E10
		private void label4_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label4.Text = this.get_name_of_key(key);
			config.triggerbot_on_of_key = key;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00008A5C File Offset: 0x00006E5C
		private void label11_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label11.Text = this.get_name_of_key(key);
			config.aim_key = key;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008AA8 File Offset: 0x00006EA8
		private void label10_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label10.Text = this.get_name_of_key(key);
			config.trigger_key = key;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00008AF4 File Offset: 0x00006EF4
		private void label19_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label19.Text = this.get_name_of_key(key);
			config.bone1_key = key;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00008B40 File Offset: 0x00006F40
		private void label20_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label20.Text = this.get_name_of_key(key);
			config.bone2_key = key;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00008B8A File Offset: 0x00006F8A
		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			config.color = this.metroComboBox2.Text;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00008BA0 File Offset: 0x00006FA0
		private void metroCheckBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox1.Checked;
			if (@checked)
			{
				config.aimbot_state_checkbox = true;
			}
			else
			{
				config.aimbot_state_checkbox = false;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00008BD4 File Offset: 0x00006FD4
		private void label7_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label7.Text = this.get_name_of_key(key);
			config.silent_key = key;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008C20 File Offset: 0x00007020
		private void label21_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label21.Text = this.get_name_of_key(key);
			config.flick_key = key;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008C6C File Offset: 0x0000706C
		private void label1_MouseHover(object sender, EventArgs e)
		{
			this.label1.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label3.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008CC0 File Offset: 0x000070C0
		private void label1_MouseLeave(object sender, EventArgs e)
		{
			this.label1.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label3.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008D14 File Offset: 0x00007114
		private void label2_MouseHover(object sender, EventArgs e)
		{
			this.label2.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label4.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008D68 File Offset: 0x00007168
		private void label2_MouseLeave(object sender, EventArgs e)
		{
			this.label2.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label4.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008DBC File Offset: 0x000071BC
		private void label25_MouseHover(object sender, EventArgs e)
		{
			this.label25.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label23.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008E10 File Offset: 0x00007210
		private void label25_MouseLeave(object sender, EventArgs e)
		{
			this.label25.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label23.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008E64 File Offset: 0x00007264
		private void label24_MouseHover(object sender, EventArgs e)
		{
			this.label24.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label22.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008EB8 File Offset: 0x000072B8
		private void label24_MouseLeave(object sender, EventArgs e)
		{
			this.label24.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label22.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008F0C File Offset: 0x0000730C
		private void label15_MouseHover(object sender, EventArgs e)
		{
			this.label15.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label27.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008F60 File Offset: 0x00007360
		private void label15_MouseLeave(object sender, EventArgs e)
		{
			this.label15.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label27.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008FB4 File Offset: 0x000073B4
		private void label14_MouseHover(object sender, EventArgs e)
		{
			this.label14.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label26.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00009008 File Offset: 0x00007408
		private void label14_MouseLeave(object sender, EventArgs e)
		{
			this.label14.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label26.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000905C File Offset: 0x0000745C
		private void label17_MouseHover(object sender, EventArgs e)
		{
			this.label17.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label29.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000090B0 File Offset: 0x000074B0
		private void label17_MouseLeave(object sender, EventArgs e)
		{
			this.label17.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label29.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00009104 File Offset: 0x00007504
		private void label16_MouseHover(object sender, EventArgs e)
		{
			this.label16.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label28.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00009158 File Offset: 0x00007558
		private void label16_MouseLeave(object sender, EventArgs e)
		{
			this.label16.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label28.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000091AC File Offset: 0x000075AC
		private void label18_MouseHover(object sender, EventArgs e)
		{
			this.label18.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label20.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00009200 File Offset: 0x00007600
		private void label18_MouseLeave(object sender, EventArgs e)
		{
			this.label18.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label20.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009254 File Offset: 0x00007654
		private void label9_MouseHover(object sender, EventArgs e)
		{
			this.label9.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label19.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000092A8 File Offset: 0x000076A8
		private void label9_MouseLeave(object sender, EventArgs e)
		{
			this.label9.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label19.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000092FC File Offset: 0x000076FC
		private void label5_MouseHover(object sender, EventArgs e)
		{
			this.label5.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label11.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009350 File Offset: 0x00007750
		private void label5_MouseLeave(object sender, EventArgs e)
		{
			this.label5.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label11.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000093A4 File Offset: 0x000077A4
		private void label6_MouseHover(object sender, EventArgs e)
		{
			this.label6.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label7.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000093F8 File Offset: 0x000077F8
		private void label6_MouseLeave(object sender, EventArgs e)
		{
			this.label6.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label7.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000944C File Offset: 0x0000784C
		private void label12_MouseHover(object sender, EventArgs e)
		{
			this.label12.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label21.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000094A0 File Offset: 0x000078A0
		private void label12_MouseLeave(object sender, EventArgs e)
		{
			this.label12.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label21.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000094F4 File Offset: 0x000078F4
		private void label13_MouseHover(object sender, EventArgs e)
		{
			this.label13.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label10.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009548 File Offset: 0x00007948
		private void label13_MouseLeave(object sender, EventArgs e)
		{
			this.label13.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label10.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000959C File Offset: 0x0000799C
		private void metroCheckBox11_CheckedChanged(object sender, EventArgs e)
		{
			config.flick_state_checkbox = this.metroCheckBox11.Checked;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000095B0 File Offset: 0x000079B0
		private void metroCheckBox10_CheckedChanged(object sender, EventArgs e)
		{
			config.silent_state_checkbox = this.metroCheckBox10.Checked;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000095C4 File Offset: 0x000079C4
		private void label23_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label23.Text = this.get_name_of_key(key);
			config.flick_on_of_key = key;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009610 File Offset: 0x00007A10
		private void label22_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label22.Text = this.get_name_of_key(key);
			config.silent_on_of_key = key;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000965C File Offset: 0x00007A5C
		private void label27_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label27.Text = this.get_name_of_key(key);
			config.autofire_on_of_key = key;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000096A8 File Offset: 0x00007AA8
		private void label26_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label26.Text = this.get_name_of_key(key);
			config.aimonlyonx_on_of_key = key;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000096F4 File Offset: 0x00007AF4
		private void label29_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label29.Text = this.get_name_of_key(key);
			config.smooth_on_of_key = key;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00009740 File Offset: 0x00007B40
		private void label28_Click(object sender, EventArgs e)
		{
			while (UserControl1.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label28.Text = this.get_name_of_key(key);
			config.ignoreskyskills_on_of_key = key;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label14_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000978C File Offset: 0x00007B8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000097C4 File Offset: 0x00007BC4
		private void InitializeComponent()
		{
			this.components = new Container();
			this.panel1 = new Panel();
			this.label22 = new Label();
			this.label23 = new Label();
			this.label24 = new Label();
			this.label25 = new Label();
			this.metroCheckBox10 = new MetroCheckBox();
			this.metroCheckBox11 = new MetroCheckBox();
			this.pictureBox1 = new PictureBox();
			this.label8 = new Label();
			this.pictureBox4 = new PictureBox();
			this.metroComboBox2 = new MetroComboBox();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this.metroCheckBox2 = new MetroCheckBox();
			this.metroCheckBox1 = new MetroCheckBox();
			this.label13 = new Label();
			this.label21 = new Label();
			this.label7 = new Label();
			this.label12 = new Label();
			this.label10 = new Label();
			this.label11 = new Label();
			this.label6 = new Label();
			this.label5 = new Label();
			this.panel2 = new Panel();
			this.label28 = new Label();
			this.label29 = new Label();
			this.label26 = new Label();
			this.label27 = new Label();
			this.label16 = new Label();
			this.label17 = new Label();
			this.metroCheckBox5 = new MetroCheckBox();
			this.metroCheckBox6 = new MetroCheckBox();
			this.label14 = new Label();
			this.label15 = new Label();
			this.metroCheckBox3 = new MetroCheckBox();
			this.metroCheckBox4 = new MetroCheckBox();
			this.panel4 = new Panel();
			this.buttonNeck = new Button();
			this.pictureBoxNeck = new PictureBox();
			this.buttonBody = new Button();
			this.pictureBoxBody = new PictureBox();
			this.buttonHead = new Button();
			this.label18 = new Label();
			this.label20 = new Label();
			this.pictureBoxHead = new PictureBox();
			this.metroCheckBox8 = new MetroCheckBox();
			this.label19 = new Label();
			this.metroCheckBox7 = new MetroCheckBox();
			this.label9 = new Label();
			this.panel3 = new Panel();
			this.buttonBody2 = new Button();
			this.pictureBoxBody2 = new PictureBox();
			this.buttonHead2 = new Button();
			this.pictureBoxHead2 = new PictureBox();
			this.buttonNeck2 = new Button();
			this.pictureBoxNeck2 = new PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel5 = new Panel();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((ISupportInitialize)this.pictureBoxNeck).BeginInit();
			((ISupportInitialize)this.pictureBoxBody).BeginInit();
			((ISupportInitialize)this.pictureBoxHead).BeginInit();
			this.panel3.SuspendLayout();
			((ISupportInitialize)this.pictureBoxBody2).BeginInit();
			((ISupportInitialize)this.pictureBoxHead2).BeginInit();
			((ISupportInitialize)this.pictureBoxNeck2).BeginInit();
			this.panel5.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(32, 33, 38);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label23);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.label25);
			this.panel1.Controls.Add(this.metroCheckBox10);
			this.panel1.Controls.Add(this.metroCheckBox11);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.metroComboBox2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.metroCheckBox2);
			this.panel1.Controls.Add(this.metroCheckBox1);
			this.panel1.Location = new Point(10, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(350, 199);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += this.panel1_Paint;
			this.label22.AutoSize = true;
			this.label22.Font = new Font("Segoe UI", 12f);
			this.label22.ForeColor = Color.FromArgb(153, 153, 153);
			this.label22.Location = new Point(246, 155);
			this.label22.Name = "label22";
			this.label22.Size = new Size(34, 21);
			this.label22.TabIndex = 124;
			this.label22.Text = "[ - ]";
			this.label22.Click += this.label22_Click;
			this.label23.AutoSize = true;
			this.label23.Font = new Font("Segoe UI", 12f);
			this.label23.ForeColor = Color.FromArgb(153, 153, 153);
			this.label23.Location = new Point(246, 133);
			this.label23.Name = "label23";
			this.label23.Size = new Size(34, 21);
			this.label23.TabIndex = 123;
			this.label23.Text = "[ - ]";
			this.label23.Click += this.label23_Click;
			this.label23.MouseLeave += this.label25_MouseLeave;
			this.label23.MouseHover += this.label25_MouseHover;
			this.label24.AutoSize = true;
			this.label24.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label24.ForeColor = Color.FromArgb(0, 174, 219);
			this.label24.Location = new Point(50, 157);
			this.label24.Name = "label24";
			this.label24.Size = new Size(66, 17);
			this.label24.TabIndex = 122;
			this.label24.Text = "Silent Bot";
			this.label24.MouseLeave += this.label24_MouseLeave;
			this.label24.MouseHover += this.label24_MouseHover;
			this.label25.AutoSize = true;
			this.label25.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label25.ForeColor = Color.FromArgb(0, 174, 219);
			this.label25.Location = new Point(50, 135);
			this.label25.Name = "label25";
			this.label25.Size = new Size(59, 17);
			this.label25.TabIndex = 121;
			this.label25.Text = "Flick Bot";
			this.label25.MouseLeave += this.label25_MouseLeave;
			this.label25.MouseHover += this.label25_MouseHover;
			this.metroCheckBox10.AutoSize = true;
			this.metroCheckBox10.Checked = true;
			this.metroCheckBox10.CheckState = CheckState.Checked;
			this.metroCheckBox10.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox10.Location = new Point(30, 161);
			this.metroCheckBox10.Name = "metroCheckBox10";
			this.metroCheckBox10.Size = new Size(26, 15);
			this.metroCheckBox10.Style = 4;
			this.metroCheckBox10.TabIndex = 120;
			this.metroCheckBox10.Text = " ";
			this.metroCheckBox10.Theme = 2;
			this.metroCheckBox10.UseCustomBackColor = true;
			this.metroCheckBox10.UseSelectable = true;
			this.metroCheckBox10.CheckedChanged += this.metroCheckBox10_CheckedChanged;
			this.metroCheckBox11.AutoSize = true;
			this.metroCheckBox11.Checked = true;
			this.metroCheckBox11.CheckState = CheckState.Checked;
			this.metroCheckBox11.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox11.Location = new Point(30, 137);
			this.metroCheckBox11.Name = "metroCheckBox11";
			this.metroCheckBox11.Size = new Size(26, 15);
			this.metroCheckBox11.Style = 4;
			this.metroCheckBox11.TabIndex = 119;
			this.metroCheckBox11.Text = " ";
			this.metroCheckBox11.Theme = 1;
			this.metroCheckBox11.UseCustomBackColor = true;
			this.metroCheckBox11.UseSelectable = true;
			this.metroCheckBox11.CheckedChanged += this.metroCheckBox11_CheckedChanged;
			this.pictureBox1.BackColor = Color.FromArgb(0, 174, 219);
			this.pictureBox1.Location = new Point(7, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(336, 1);
			this.pictureBox1.TabIndex = 118;
			this.pictureBox1.TabStop = false;
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label8.ForeColor = Color.FromArgb(0, 174, 219);
			this.label8.Location = new Point(50, 87);
			this.label8.Name = "label8";
			this.label8.Size = new Size(68, 17);
			this.label8.TabIndex = 43;
			this.label8.Text = "Aim Color";
			this.pictureBox4.BackColor = Color.FromArgb(0, 174, 219);
			this.pictureBox4.Location = new Point(7, 74);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(336, 1);
			this.pictureBox4.TabIndex = 46;
			this.pictureBox4.TabStop = false;
			this.metroComboBox2.BackColor = Color.FromArgb(39, 41, 47);
			this.metroComboBox2.ForeColor = Color.FromArgb(153, 153, 153);
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.IntegralHeight = false;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Items.AddRange(new object[]
			{
				"Yellow",
				"Purple"
			});
			this.metroComboBox2.Location = new Point(250, 83);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.RightToLeft = RightToLeft.No;
			this.metroComboBox2.Size = new Size(76, 29);
			this.metroComboBox2.Style = 3;
			this.metroComboBox2.TabIndex = 44;
			this.metroComboBox2.Theme = 2;
			this.metroComboBox2.UseCustomBackColor = true;
			this.metroComboBox2.UseCustomForeColor = true;
			this.metroComboBox2.UseSelectable = true;
			this.metroComboBox2.UseStyleColors = true;
			this.metroComboBox2.SelectedIndexChanged += this.metroComboBox2_SelectedIndexChanged;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Segoe UI", 12f);
			this.label4.ForeColor = Color.FromArgb(153, 153, 153);
			this.label4.Location = new Point(246, 43);
			this.label4.Name = "label4";
			this.label4.Size = new Size(34, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "[ - ]";
			this.label4.Click += this.label4_Click;
			this.label4.MouseLeave += this.label2_MouseLeave;
			this.label4.MouseHover += this.label2_MouseHover;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI", 12f);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(246, 21);
			this.label3.Name = "label3";
			this.label3.Size = new Size(34, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "[ - ]";
			this.label3.Click += this.label3_Click;
			this.label3.MouseLeave += this.label1_MouseLeave;
			this.label3.MouseHover += this.label1_MouseHover;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.ForeColor = Color.FromArgb(0, 174, 219);
			this.label2.Location = new Point(50, 45);
			this.label2.Name = "label2";
			this.label2.Size = new Size(75, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Trigger Bot";
			this.label2.MouseLeave += this.label2_MouseLeave;
			this.label2.MouseHover += this.label2_MouseHover;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(0, 174, 219);
			this.label1.Location = new Point(50, 23);
			this.label1.Name = "label1";
			this.label1.Size = new Size(57, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Aim Bot";
			this.label1.Click += this.label1_Click;
			this.label1.MouseLeave += this.label1_MouseLeave;
			this.label1.MouseHover += this.label1_MouseHover;
			this.metroCheckBox2.AutoSize = true;
			this.metroCheckBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox2.Location = new Point(30, 49);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new Size(26, 15);
			this.metroCheckBox2.Style = 4;
			this.metroCheckBox2.TabIndex = 1;
			this.metroCheckBox2.Text = " ";
			this.metroCheckBox2.Theme = 2;
			this.metroCheckBox2.UseCustomBackColor = true;
			this.metroCheckBox2.UseSelectable = true;
			this.metroCheckBox2.CheckedChanged += this.metroCheckBox2_CheckedChanged;
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.Checked = true;
			this.metroCheckBox1.CheckState = CheckState.Checked;
			this.metroCheckBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox1.Location = new Point(30, 25);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new Size(26, 15);
			this.metroCheckBox1.Style = 4;
			this.metroCheckBox1.TabIndex = 0;
			this.metroCheckBox1.Text = " ";
			this.metroCheckBox1.Theme = 1;
			this.metroCheckBox1.UseCustomBackColor = true;
			this.metroCheckBox1.UseSelectable = true;
			this.metroCheckBox1.CheckedChanged += this.metroCheckBox1_CheckedChanged_1;
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label13.ForeColor = Color.FromArgb(0, 174, 219);
			this.label13.Location = new Point(30, 92);
			this.label13.Name = "label13";
			this.label13.Size = new Size(76, 17);
			this.label13.TabIndex = 112;
			this.label13.Text = "Trigger Key";
			this.label13.Click += this.label13_Click;
			this.label13.MouseLeave += this.label13_MouseLeave;
			this.label13.MouseHover += this.label13_MouseHover;
			this.label21.AutoSize = true;
			this.label21.Font = new Font("Segoe UI", 12f);
			this.label21.ForeColor = Color.FromArgb(153, 153, 153);
			this.label21.Location = new Point(229, 66);
			this.label21.Name = "label21";
			this.label21.Size = new Size(53, 21);
			this.label21.TabIndex = 111;
			this.label21.Text = "[ ALT ]";
			this.label21.Click += this.label21_Click;
			this.label21.MouseLeave += this.label12_MouseLeave;
			this.label21.MouseHover += this.label12_MouseHover;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI", 12f);
			this.label7.ForeColor = Color.FromArgb(153, 153, 153);
			this.label7.Location = new Point(229, 41);
			this.label7.Name = "label7";
			this.label7.Size = new Size(46, 21);
			this.label7.TabIndex = 48;
			this.label7.Text = "[ X1 ]";
			this.label7.Click += this.label7_Click;
			this.label7.MouseLeave += this.label6_MouseLeave;
			this.label7.MouseHover += this.label6_MouseHover;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label12.ForeColor = Color.FromArgb(0, 174, 219);
			this.label12.Location = new Point(30, 68);
			this.label12.Name = "label12";
			this.label12.Size = new Size(60, 17);
			this.label12.TabIndex = 47;
			this.label12.Text = "Flick Key";
			this.label12.MouseLeave += this.label12_MouseLeave;
			this.label12.MouseHover += this.label12_MouseHover;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Segoe UI", 12f);
			this.label10.ForeColor = Color.FromArgb(153, 153, 153);
			this.label10.Location = new Point(229, 90);
			this.label10.Name = "label10";
			this.label10.Size = new Size(34, 21);
			this.label10.TabIndex = 12;
			this.label10.Text = "[ - ]";
			this.label10.Click += this.label10_Click;
			this.label10.MouseLeave += this.label13_MouseLeave;
			this.label10.MouseHover += this.label13_MouseHover;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Segoe UI", 12f);
			this.label11.ForeColor = Color.FromArgb(153, 153, 153);
			this.label11.Location = new Point(229, 19);
			this.label11.Name = "label11";
			this.label11.Size = new Size(54, 21);
			this.label11.TabIndex = 110;
			this.label11.Text = "[ Left ]";
			this.label11.Click += this.label11_Click;
			this.label11.MouseLeave += this.label5_MouseLeave;
			this.label11.MouseHover += this.label5_MouseHover;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label6.ForeColor = Color.FromArgb(0, 174, 219);
			this.label6.Location = new Point(30, 44);
			this.label6.Name = "label6";
			this.label6.Size = new Size(67, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Silent Key";
			this.label6.MouseLeave += this.label6_MouseLeave;
			this.label6.MouseHover += this.label6_MouseHover;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label5.ForeColor = Color.FromArgb(0, 174, 219);
			this.label5.Location = new Point(30, 22);
			this.label5.Name = "label5";
			this.label5.Size = new Size(58, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Aim Key";
			this.label5.MouseLeave += this.label5_MouseLeave;
			this.label5.MouseHover += this.label5_MouseHover;
			this.panel2.BackColor = Color.FromArgb(32, 33, 38);
			this.panel2.Controls.Add(this.label28);
			this.panel2.Controls.Add(this.label29);
			this.panel2.Controls.Add(this.label26);
			this.panel2.Controls.Add(this.label27);
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.metroCheckBox5);
			this.panel2.Controls.Add(this.metroCheckBox6);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.metroCheckBox3);
			this.panel2.Controls.Add(this.metroCheckBox4);
			this.panel2.Location = new Point(10, 217);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(350, 136);
			this.panel2.TabIndex = 4;
			this.panel2.Paint += this.panel2_Paint;
			this.label28.AutoSize = true;
			this.label28.Font = new Font("Segoe UI", 12f);
			this.label28.ForeColor = Color.FromArgb(153, 153, 153);
			this.label28.Location = new Point(246, 89);
			this.label28.Name = "label28";
			this.label28.Size = new Size(34, 21);
			this.label28.TabIndex = 128;
			this.label28.Text = "[ - ]";
			this.label28.Click += this.label28_Click;
			this.label29.AutoSize = true;
			this.label29.Font = new Font("Segoe UI", 12f);
			this.label29.ForeColor = Color.FromArgb(153, 153, 153);
			this.label29.Location = new Point(246, 66);
			this.label29.Name = "label29";
			this.label29.Size = new Size(34, 21);
			this.label29.TabIndex = 127;
			this.label29.Text = "[ - ]";
			this.label29.Click += this.label29_Click;
			this.label29.MouseLeave += this.label17_MouseLeave;
			this.label29.MouseHover += this.label17_MouseHover;
			this.label26.AutoSize = true;
			this.label26.Font = new Font("Segoe UI", 12f);
			this.label26.ForeColor = Color.FromArgb(153, 153, 153);
			this.label26.Location = new Point(246, 42);
			this.label26.Name = "label26";
			this.label26.Size = new Size(34, 21);
			this.label26.TabIndex = 126;
			this.label26.Text = "[ - ]";
			this.label26.Click += this.label26_Click;
			this.label26.MouseLeave += this.label14_MouseLeave;
			this.label26.MouseHover += this.label14_MouseHover;
			this.label27.AutoSize = true;
			this.label27.Font = new Font("Segoe UI", 12f);
			this.label27.ForeColor = Color.FromArgb(153, 153, 153);
			this.label27.Location = new Point(246, 19);
			this.label27.Name = "label27";
			this.label27.Size = new Size(34, 21);
			this.label27.TabIndex = 125;
			this.label27.Text = "[ - ]";
			this.label27.Click += this.label27_Click;
			this.label27.MouseLeave += this.label15_MouseLeave;
			this.label27.MouseHover += this.label15_MouseHover;
			this.label16.AutoSize = true;
			this.label16.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label16.ForeColor = Color.FromArgb(0, 174, 219);
			this.label16.Location = new Point(50, 92);
			this.label16.Name = "label16";
			this.label16.Size = new Size(113, 17);
			this.label16.TabIndex = 22;
			this.label16.Text = "Ignore Skye Skills";
			this.label16.MouseLeave += this.label16_MouseLeave;
			this.label16.MouseHover += this.label16_MouseHover;
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label17.ForeColor = Color.FromArgb(0, 174, 219);
			this.label17.Location = new Point(50, 70);
			this.label17.Name = "label17";
			this.label17.Size = new Size(56, 17);
			this.label17.TabIndex = 21;
			this.label17.Text = "Smooth";
			this.label17.MouseLeave += this.label17_MouseLeave;
			this.label17.MouseHover += this.label17_MouseHover;
			this.metroCheckBox5.AutoSize = true;
			this.metroCheckBox5.Enabled = false;
			this.metroCheckBox5.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox5.Location = new Point(30, 96);
			this.metroCheckBox5.Name = "metroCheckBox5";
			this.metroCheckBox5.Size = new Size(26, 15);
			this.metroCheckBox5.Style = 4;
			this.metroCheckBox5.TabIndex = 20;
			this.metroCheckBox5.Text = " ";
			this.metroCheckBox5.Theme = 2;
			this.metroCheckBox5.UseCustomBackColor = true;
			this.metroCheckBox5.UseSelectable = true;
			this.metroCheckBox5.CheckedChanged += this.metroCheckBox5_CheckedChanged;
			this.metroCheckBox6.AutoSize = true;
			this.metroCheckBox6.Checked = true;
			this.metroCheckBox6.CheckState = CheckState.Checked;
			this.metroCheckBox6.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox6.Location = new Point(30, 72);
			this.metroCheckBox6.Name = "metroCheckBox6";
			this.metroCheckBox6.Size = new Size(26, 15);
			this.metroCheckBox6.Style = 4;
			this.metroCheckBox6.TabIndex = 19;
			this.metroCheckBox6.Text = " ";
			this.metroCheckBox6.Theme = 2;
			this.metroCheckBox6.UseCustomBackColor = true;
			this.metroCheckBox6.UseSelectable = true;
			this.metroCheckBox6.CheckedChanged += this.metroCheckBox6_CheckedChanged;
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label14.ForeColor = Color.FromArgb(0, 174, 219);
			this.label14.Location = new Point(50, 46);
			this.label14.Name = "label14";
			this.label14.Size = new Size(98, 17);
			this.label14.TabIndex = 18;
			this.label14.Text = "Aim Only On X";
			this.label14.Click += this.label14_Click;
			this.label14.MouseLeave += this.label14_MouseLeave;
			this.label14.MouseHover += this.label14_MouseHover;
			this.label15.AutoSize = true;
			this.label15.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label15.ForeColor = Color.FromArgb(0, 174, 219);
			this.label15.Location = new Point(50, 22);
			this.label15.Name = "label15";
			this.label15.Size = new Size(64, 17);
			this.label15.TabIndex = 17;
			this.label15.Text = "Auto Fire";
			this.label15.MouseLeave += this.label15_MouseLeave;
			this.label15.MouseHover += this.label15_MouseHover;
			this.metroCheckBox3.AutoSize = true;
			this.metroCheckBox3.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox3.Location = new Point(30, 48);
			this.metroCheckBox3.Name = "metroCheckBox3";
			this.metroCheckBox3.Size = new Size(26, 15);
			this.metroCheckBox3.Style = 4;
			this.metroCheckBox3.TabIndex = 16;
			this.metroCheckBox3.Text = " ";
			this.metroCheckBox3.Theme = 2;
			this.metroCheckBox3.UseCustomBackColor = true;
			this.metroCheckBox3.UseSelectable = true;
			this.metroCheckBox3.CheckedChanged += this.metroCheckBox3_CheckedChanged;
			this.metroCheckBox4.AutoSize = true;
			this.metroCheckBox4.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox4.Location = new Point(30, 24);
			this.metroCheckBox4.Name = "metroCheckBox4";
			this.metroCheckBox4.Size = new Size(26, 15);
			this.metroCheckBox4.Style = 4;
			this.metroCheckBox4.TabIndex = 15;
			this.metroCheckBox4.Text = " ";
			this.metroCheckBox4.Theme = 2;
			this.metroCheckBox4.UseCustomBackColor = true;
			this.metroCheckBox4.UseSelectable = true;
			this.metroCheckBox4.CheckedChanged += this.metroCheckBox4_CheckedChanged;
			this.panel4.BackColor = Color.FromArgb(32, 33, 38);
			this.panel4.Controls.Add(this.buttonNeck);
			this.panel4.Controls.Add(this.pictureBoxNeck);
			this.panel4.Controls.Add(this.buttonBody);
			this.panel4.Controls.Add(this.pictureBoxBody);
			this.panel4.Controls.Add(this.buttonHead);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.pictureBoxHead);
			this.panel4.Controls.Add(this.metroCheckBox8);
			this.panel4.Location = new Point(366, 12);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(155, 199);
			this.panel4.TabIndex = 38;
			this.buttonNeck.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonNeck.FlatAppearance.BorderSize = 0;
			this.buttonNeck.FlatStyle = FlatStyle.Flat;
			this.buttonNeck.Font = new Font("Segoe UI", 10f);
			this.buttonNeck.ForeColor = Color.FromArgb(153, 153, 153);
			this.buttonNeck.Location = new Point(23, 64);
			this.buttonNeck.Name = "buttonNeck";
			this.buttonNeck.Size = new Size(96, 25);
			this.buttonNeck.TabIndex = 41;
			this.buttonNeck.Text = "Neck";
			this.buttonNeck.UseVisualStyleBackColor = false;
			this.buttonNeck.Click += this.buttonNeck_Click;
			this.pictureBoxNeck.Image = Resources.Neck;
			this.pictureBoxNeck.Location = new Point(23, 95);
			this.pictureBoxNeck.Name = "pictureBoxNeck";
			this.pictureBoxNeck.Size = new Size(96, 79);
			this.pictureBoxNeck.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxNeck.TabIndex = 40;
			this.pictureBoxNeck.TabStop = false;
			this.buttonBody.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonBody.FlatAppearance.BorderSize = 0;
			this.buttonBody.FlatStyle = FlatStyle.Flat;
			this.buttonBody.Font = new Font("Segoe UI", 10f);
			this.buttonBody.ForeColor = Color.FromArgb(102, 102, 102);
			this.buttonBody.Location = new Point(23, 64);
			this.buttonBody.Name = "buttonBody";
			this.buttonBody.Size = new Size(96, 25);
			this.buttonBody.TabIndex = 39;
			this.buttonBody.Text = "Body";
			this.buttonBody.UseVisualStyleBackColor = false;
			this.buttonBody.Click += this.buttonBody_Click;
			this.pictureBoxBody.Image = Resources.Body;
			this.pictureBoxBody.Location = new Point(23, 96);
			this.pictureBoxBody.Name = "pictureBoxBody";
			this.pictureBoxBody.Size = new Size(96, 79);
			this.pictureBoxBody.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBody.TabIndex = 38;
			this.pictureBoxBody.TabStop = false;
			this.buttonHead.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonHead.FlatAppearance.BorderSize = 0;
			this.buttonHead.FlatStyle = FlatStyle.Flat;
			this.buttonHead.Font = new Font("Segoe UI", 10f);
			this.buttonHead.ForeColor = Color.FromArgb(102, 102, 102);
			this.buttonHead.Location = new Point(23, 64);
			this.buttonHead.Name = "buttonHead";
			this.buttonHead.Size = new Size(96, 25);
			this.buttonHead.TabIndex = 37;
			this.buttonHead.Text = "Head";
			this.buttonHead.UseVisualStyleBackColor = false;
			this.buttonHead.Click += this.buttonHead_Click;
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label18.ForeColor = Color.FromArgb(0, 174, 219);
			this.label18.Location = new Point(33, 12);
			this.label18.Name = "label18";
			this.label18.Size = new Size(55, 17);
			this.label18.TabIndex = 31;
			this.label18.Text = "2- Bone";
			this.label18.MouseLeave += this.label18_MouseLeave;
			this.label18.MouseHover += this.label18_MouseHover;
			this.label20.AutoSize = true;
			this.label20.Font = new Font("Segoe UI", 12f);
			this.label20.ForeColor = Color.FromArgb(153, 153, 153);
			this.label20.Location = new Point(107, 11);
			this.label20.Name = "label20";
			this.label20.Size = new Size(34, 21);
			this.label20.TabIndex = 15;
			this.label20.Text = "[ - ]";
			this.label20.Click += this.label20_Click;
			this.label20.MouseLeave += this.label18_MouseLeave;
			this.label20.MouseHover += this.label18_MouseHover;
			this.pictureBoxHead.Image = Resources.Head;
			this.pictureBoxHead.Location = new Point(23, 96);
			this.pictureBoxHead.Name = "pictureBoxHead";
			this.pictureBoxHead.Size = new Size(96, 79);
			this.pictureBoxHead.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxHead.TabIndex = 24;
			this.pictureBoxHead.TabStop = false;
			this.metroCheckBox8.AutoSize = true;
			this.metroCheckBox8.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox8.Location = new Point(13, 14);
			this.metroCheckBox8.Name = "metroCheckBox8";
			this.metroCheckBox8.Size = new Size(26, 15);
			this.metroCheckBox8.Style = 4;
			this.metroCheckBox8.TabIndex = 30;
			this.metroCheckBox8.Text = " ";
			this.metroCheckBox8.Theme = 2;
			this.metroCheckBox8.UseCustomBackColor = true;
			this.metroCheckBox8.UseSelectable = true;
			this.metroCheckBox8.CheckedChanged += this.metroCheckBox8_CheckedChanged;
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Segoe UI", 12f);
			this.label19.ForeColor = Color.FromArgb(153, 153, 153);
			this.label19.Location = new Point(107, 11);
			this.label19.Name = "label19";
			this.label19.Size = new Size(34, 21);
			this.label19.TabIndex = 15;
			this.label19.Text = "[ - ]";
			this.label19.Click += this.label19_Click;
			this.label19.MouseLeave += this.label9_MouseLeave;
			this.label19.MouseHover += this.label9_MouseHover;
			this.metroCheckBox7.AutoSize = true;
			this.metroCheckBox7.Checked = true;
			this.metroCheckBox7.CheckState = CheckState.Checked;
			this.metroCheckBox7.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox7.Location = new Point(13, 14);
			this.metroCheckBox7.Name = "metroCheckBox7";
			this.metroCheckBox7.Size = new Size(26, 15);
			this.metroCheckBox7.Style = 4;
			this.metroCheckBox7.TabIndex = 30;
			this.metroCheckBox7.Text = " ";
			this.metroCheckBox7.Theme = 2;
			this.metroCheckBox7.UseCustomBackColor = true;
			this.metroCheckBox7.UseSelectable = true;
			this.metroCheckBox7.CheckedChanged += this.metroCheckBox7_CheckedChanged;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label9.ForeColor = Color.FromArgb(0, 174, 219);
			this.label9.Location = new Point(33, 12);
			this.label9.Name = "label9";
			this.label9.Size = new Size(53, 17);
			this.label9.TabIndex = 31;
			this.label9.Text = "1- Bone";
			this.label9.MouseLeave += this.label9_MouseLeave;
			this.label9.MouseHover += this.label9_MouseHover;
			this.panel3.BackColor = Color.FromArgb(32, 33, 38);
			this.panel3.Controls.Add(this.buttonBody2);
			this.panel3.Controls.Add(this.pictureBoxBody2);
			this.panel3.Controls.Add(this.buttonHead2);
			this.panel3.Controls.Add(this.pictureBoxHead2);
			this.panel3.Controls.Add(this.buttonNeck2);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label19);
			this.panel3.Controls.Add(this.pictureBoxNeck2);
			this.panel3.Controls.Add(this.metroCheckBox7);
			this.panel3.Location = new Point(526, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(155, 199);
			this.panel3.TabIndex = 35;
			this.buttonBody2.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonBody2.FlatAppearance.BorderSize = 0;
			this.buttonBody2.FlatStyle = FlatStyle.Flat;
			this.buttonBody2.Font = new Font("Segoe UI", 10f);
			this.buttonBody2.ForeColor = Color.FromArgb(153, 153, 153);
			this.buttonBody2.Location = new Point(23, 64);
			this.buttonBody2.Name = "buttonBody2";
			this.buttonBody2.Size = new Size(96, 25);
			this.buttonBody2.TabIndex = 39;
			this.buttonBody2.Text = "Body";
			this.buttonBody2.UseVisualStyleBackColor = false;
			this.buttonBody2.Click += this.buttonBody2_Click;
			this.pictureBoxBody2.Image = Resources.Body;
			this.pictureBoxBody2.Location = new Point(23, 95);
			this.pictureBoxBody2.Name = "pictureBoxBody2";
			this.pictureBoxBody2.Size = new Size(96, 79);
			this.pictureBoxBody2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBody2.TabIndex = 38;
			this.pictureBoxBody2.TabStop = false;
			this.buttonHead2.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonHead2.FlatAppearance.BorderSize = 0;
			this.buttonHead2.FlatStyle = FlatStyle.Flat;
			this.buttonHead2.Font = new Font("Segoe UI", 10f);
			this.buttonHead2.ForeColor = Color.FromArgb(102, 102, 102);
			this.buttonHead2.Location = new Point(23, 64);
			this.buttonHead2.Name = "buttonHead2";
			this.buttonHead2.Size = new Size(96, 25);
			this.buttonHead2.TabIndex = 39;
			this.buttonHead2.Text = "Head";
			this.buttonHead2.UseVisualStyleBackColor = false;
			this.buttonHead2.Click += this.buttonHead2_Click;
			this.pictureBoxHead2.Image = Resources.Head;
			this.pictureBoxHead2.Location = new Point(23, 95);
			this.pictureBoxHead2.Name = "pictureBoxHead2";
			this.pictureBoxHead2.Size = new Size(96, 79);
			this.pictureBoxHead2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxHead2.TabIndex = 38;
			this.pictureBoxHead2.TabStop = false;
			this.buttonNeck2.BackColor = Color.FromArgb(39, 41, 47);
			this.buttonNeck2.FlatAppearance.BorderSize = 0;
			this.buttonNeck2.FlatStyle = FlatStyle.Flat;
			this.buttonNeck2.Font = new Font("Segoe UI", 10f);
			this.buttonNeck2.ForeColor = Color.FromArgb(102, 102, 102);
			this.buttonNeck2.Location = new Point(23, 64);
			this.buttonNeck2.Name = "buttonNeck2";
			this.buttonNeck2.Size = new Size(96, 25);
			this.buttonNeck2.TabIndex = 37;
			this.buttonNeck2.Text = "Neck";
			this.buttonNeck2.UseVisualStyleBackColor = false;
			this.buttonNeck2.Click += this.buttonNeck2_Click;
			this.pictureBoxNeck2.Image = Resources.Neck;
			this.pictureBoxNeck2.Location = new Point(23, 95);
			this.pictureBoxNeck2.Name = "pictureBoxNeck2";
			this.pictureBoxNeck2.Size = new Size(96, 79);
			this.pictureBoxNeck2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxNeck2.TabIndex = 24;
			this.pictureBoxNeck2.TabStop = false;
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += this.timer1_Tick;
			this.panel5.BackColor = Color.FromArgb(32, 33, 38);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.label13);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.label21);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Controls.Add(this.label12);
			this.panel5.Location = new Point(366, 217);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(315, 136);
			this.panel5.TabIndex = 39;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 41, 47);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Name = "UserControl1";
			base.Size = new Size(691, 366);
			base.Load += this.UserControl1_Load;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.pictureBox4).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((ISupportInitialize)this.pictureBoxNeck).EndInit();
			((ISupportInitialize)this.pictureBoxBody).EndInit();
			((ISupportInitialize)this.pictureBoxHead).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((ISupportInitialize)this.pictureBoxBody2).EndInit();
			((ISupportInitialize)this.pictureBoxHead2).EndInit();
			((ISupportInitialize)this.pictureBoxNeck2).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000B4 RID: 180
		private int[] list_characters = new int[]
		{
			1,
			2,
			3,
			5,
			6,
			9,
			16,
			17,
			18,
			65,
			66,
			67,
			68,
			69,
			70,
			71,
			72,
			73,
			74,
			75,
			76,
			77,
			78,
			79,
			80,
			81,
			82,
			83,
			84,
			85,
			86,
			87,
			88,
			89,
			90
		};

		// Token: 0x040000B5 RID: 181
		private IContainer components = null;

		// Token: 0x040000B6 RID: 182
		private Panel panel1;

		// Token: 0x040000B7 RID: 183
		private Label label4;

		// Token: 0x040000B8 RID: 184
		private Label label3;

		// Token: 0x040000B9 RID: 185
		private Label label2;

		// Token: 0x040000BA RID: 186
		private Label label1;

		// Token: 0x040000BB RID: 187
		private MetroCheckBox metroCheckBox2;

		// Token: 0x040000BC RID: 188
		private MetroCheckBox metroCheckBox1;

		// Token: 0x040000BD RID: 189
		private Panel panel2;

		// Token: 0x040000BE RID: 190
		private Label label10;

		// Token: 0x040000BF RID: 191
		private Label label11;

		// Token: 0x040000C0 RID: 192
		private Label label6;

		// Token: 0x040000C1 RID: 193
		private Label label5;

		// Token: 0x040000C2 RID: 194
		private Label label16;

		// Token: 0x040000C3 RID: 195
		private Label label17;

		// Token: 0x040000C4 RID: 196
		private MetroCheckBox metroCheckBox5;

		// Token: 0x040000C5 RID: 197
		private MetroCheckBox metroCheckBox6;

		// Token: 0x040000C6 RID: 198
		private Label label14;

		// Token: 0x040000C7 RID: 199
		private Label label15;

		// Token: 0x040000C8 RID: 200
		private MetroCheckBox metroCheckBox3;

		// Token: 0x040000C9 RID: 201
		private MetroCheckBox metroCheckBox4;

		// Token: 0x040000CA RID: 202
		private PictureBox pictureBoxNeck2;

		// Token: 0x040000CB RID: 203
		private Label label19;

		// Token: 0x040000CC RID: 204
		private Label label9;

		// Token: 0x040000CD RID: 205
		private MetroCheckBox metroCheckBox7;

		// Token: 0x040000CE RID: 206
		private Panel panel3;

		// Token: 0x040000CF RID: 207
		private Panel panel4;

		// Token: 0x040000D0 RID: 208
		private Button buttonHead;

		// Token: 0x040000D1 RID: 209
		private Label label18;

		// Token: 0x040000D2 RID: 210
		private Label label20;

		// Token: 0x040000D3 RID: 211
		private PictureBox pictureBoxHead;

		// Token: 0x040000D4 RID: 212
		private MetroCheckBox metroCheckBox8;

		// Token: 0x040000D5 RID: 213
		private Button buttonNeck2;

		// Token: 0x040000D6 RID: 214
		private MetroComboBox metroComboBox2;

		// Token: 0x040000D7 RID: 215
		private Label label8;

		// Token: 0x040000D8 RID: 216
		private PictureBox pictureBox4;

		// Token: 0x040000D9 RID: 217
		private Button buttonHead2;

		// Token: 0x040000DA RID: 218
		private PictureBox pictureBoxHead2;

		// Token: 0x040000DB RID: 219
		private Button buttonBody2;

		// Token: 0x040000DC RID: 220
		private PictureBox pictureBoxBody2;

		// Token: 0x040000DD RID: 221
		private Button buttonBody;

		// Token: 0x040000DE RID: 222
		private PictureBox pictureBoxBody;

		// Token: 0x040000DF RID: 223
		private Button buttonNeck;

		// Token: 0x040000E0 RID: 224
		private PictureBox pictureBoxNeck;

		// Token: 0x040000E1 RID: 225
		public System.Windows.Forms.Timer timer1;

		// Token: 0x040000E2 RID: 226
		private Label label7;

		// Token: 0x040000E3 RID: 227
		private Label label12;

		// Token: 0x040000E4 RID: 228
		private Label label13;

		// Token: 0x040000E5 RID: 229
		private Label label21;

		// Token: 0x040000E6 RID: 230
		private Panel panel5;

		// Token: 0x040000E7 RID: 231
		private Label label22;

		// Token: 0x040000E8 RID: 232
		private Label label23;

		// Token: 0x040000E9 RID: 233
		private Label label24;

		// Token: 0x040000EA RID: 234
		private Label label25;

		// Token: 0x040000EB RID: 235
		private MetroCheckBox metroCheckBox10;

		// Token: 0x040000EC RID: 236
		private MetroCheckBox metroCheckBox11;

		// Token: 0x040000ED RID: 237
		private PictureBox pictureBox1;

		// Token: 0x040000EE RID: 238
		private Label label28;

		// Token: 0x040000EF RID: 239
		private Label label29;

		// Token: 0x040000F0 RID: 240
		private Label label26;

		// Token: 0x040000F1 RID: 241
		private Label label27;
	}
}
