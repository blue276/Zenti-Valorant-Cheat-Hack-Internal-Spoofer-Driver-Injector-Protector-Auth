using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using SkyCheats.Properties;

namespace SkyCheats.UserControls
{
	// Token: 0x02000018 RID: 24
	public class UserControl3 : UserControl
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00012255 File Offset: 0x00010655
		public UserControl3()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00012288 File Offset: 0x00010688
		private void UserControl3_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
			this.metroComboBox1.Text = this.metroComboBox1.Items[0].ToString();
			this.metroComboBox2.Text = this.metroComboBox2.Items[1].ToString();
			this.metroComboBox3.Text = this.metroComboBox3.Items[2].ToString();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00012308 File Offset: 0x00010708
		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox2.Checked;
			if (@checked)
			{
				config.hip_fire_state = true;
			}
			else
			{
				config.hip_fire_state = false;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001233C File Offset: 0x0001073C
		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox1.Checked;
			if (@checked)
			{
				config.recoil_system_state = true;
			}
			else
			{
				config.recoil_system_state = false;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00012370 File Offset: 0x00010770
		private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
		{
			config.rcs_smooth = (double)(this.metroTrackBar2.Value / 100 * 2);
			this.label3.Text = this.metroTrackBar2.Value.ToString();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000123B4 File Offset: 0x000107B4
		private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox7.Checked;
			if (@checked)
			{
				config.weapon2_state = true;
				switch (this.metroComboBox2.SelectedIndex)
				{
				case 0:
					config.max_recoil = 80;
					config.recoilspeed = 0.75;
					break;
				case 1:
					config.max_recoil = 35;
					config.recoilspeed = 1.2;
					break;
				case 2:
					config.max_recoil = 30;
					config.recoilspeed = 1.5;
					break;
				case 3:
					config.max_recoil = 90;
					config.recoilspeed = 0.75;
					break;
				case 4:
					config.max_recoil = 38;
					config.recoilspeed = 1.5;
					break;
				case 5:
					config.max_recoil = 35;
					config.recoilspeed = 1.5;
					break;
				case 6:
					config.max_recoil = 46;
					config.recoilspeed = 1.5;
					break;
				case 7:
					config.max_recoil = 43;
					config.recoilspeed = 1.5;
					break;
				}
			}
			else
			{
				config.weapon2_state = false;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000124F0 File Offset: 0x000108F0
		private void metroCheckBox3_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox3.Checked;
			if (@checked)
			{
				config.weapon1_state = true;
				switch (this.metroComboBox1.SelectedIndex)
				{
				case 0:
					config.max_recoil = 80;
					config.recoilspeed = 0.75;
					break;
				case 1:
					config.max_recoil = 35;
					config.recoilspeed = 1.2;
					break;
				case 2:
					config.max_recoil = 30;
					config.recoilspeed = 1.5;
					break;
				case 3:
					config.max_recoil = 90;
					config.recoilspeed = 0.75;
					break;
				case 4:
					config.max_recoil = 38;
					config.recoilspeed = 1.5;
					break;
				case 5:
					config.max_recoil = 35;
					config.recoilspeed = 1.5;
					break;
				case 6:
					config.max_recoil = 46;
					config.recoilspeed = 1.5;
					break;
				case 7:
					config.max_recoil = 43;
					config.recoilspeed = 1.5;
					break;
				}
			}
			else
			{
				config.weapon1_state = false;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001262C File Offset: 0x00010A2C
		private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.metroCheckBox4.Checked;
			if (@checked)
			{
				config.weapon3_state = true;
				switch (this.metroComboBox3.SelectedIndex)
				{
				case 0:
					config.max_recoil = 80;
					config.recoilspeed = 0.75;
					break;
				case 1:
					config.max_recoil = 35;
					config.recoilspeed = 1.2;
					break;
				case 2:
					config.max_recoil = 30;
					config.recoilspeed = 1.5;
					break;
				case 3:
					config.max_recoil = 90;
					config.recoilspeed = 0.75;
					break;
				case 4:
					config.max_recoil = 38;
					config.recoilspeed = 1.5;
					break;
				case 5:
					config.max_recoil = 35;
					config.recoilspeed = 1.5;
					break;
				case 6:
					config.max_recoil = 46;
					config.recoilspeed = 1.5;
					break;
				case 7:
					config.max_recoil = 43;
					config.recoilspeed = 1.5;
					break;
				}
			}
			else
			{
				config.weapon3_state = false;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00012768 File Offset: 0x00010B68
		private void allhide1()
		{
			this.pictureBoxARES1.Hide();
			this.pictureBoxBULLDOG1.Hide();
			this.pictureBoxFRENZY1.Hide();
			this.pictureBoxODIN1.Hide();
			this.pictureBoxPHANTOM1.Hide();
			this.pictureBoxSPECTRE1.Hide();
			this.pictureBoxSTINGER1.Hide();
			this.pictureBoxVANDAL1.Hide();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000127D8 File Offset: 0x00010BD8
		private void allhide2()
		{
			this.pictureBoxARES2.Hide();
			this.pictureBoxBULLDOG2.Hide();
			this.pictureBoxFRENZY2.Hide();
			this.pictureBoxODIN2.Hide();
			this.pictureBoxPHANTOM2.Hide();
			this.pictureBoxSPECTRE2.Hide();
			this.pictureBoxSTINGER2.Hide();
			this.pictureBoxVANDAL2.Hide();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00012848 File Offset: 0x00010C48
		private void allhide3()
		{
			this.pictureBoxARES3.Hide();
			this.pictureBoxBULLDOG3.Hide();
			this.pictureBoxFRENZY3.Hide();
			this.pictureBoxODIN3.Hide();
			this.pictureBoxPHANTOM3.Hide();
			this.pictureBoxSPECTRE3.Hide();
			this.pictureBoxSTINGER3.Hide();
			this.pictureBoxVANDAL3.Hide();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000128B8 File Offset: 0x00010CB8
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.allhide1();
			switch (this.metroComboBox1.SelectedIndex)
			{
			case 0:
				this.pictureBoxARES1.Show();
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				break;
			case 1:
				this.pictureBoxBULLDOG1.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				break;
			case 2:
				this.pictureBoxFRENZY1.Show();
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				break;
			case 3:
				this.pictureBoxODIN1.Show();
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				break;
			case 4:
				this.pictureBoxPHANTOM1.Show();
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				break;
			case 5:
				this.pictureBoxSPECTRE1.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				break;
			case 6:
				this.pictureBoxSTINGER1.Show();
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				break;
			case 7:
				this.pictureBoxVANDAL1.Show();
				config.max_recoil = 45;
				config.recoilspeed = 1.5;
				break;
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00012A3C File Offset: 0x00010E3C
		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.allhide2();
			switch (this.metroComboBox2.SelectedIndex)
			{
			case 0:
				this.pictureBoxARES2.Show();
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				break;
			case 1:
				this.pictureBoxBULLDOG2.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				break;
			case 2:
				this.pictureBoxFRENZY2.Show();
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				break;
			case 3:
				this.pictureBoxODIN2.Show();
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				break;
			case 4:
				this.pictureBoxPHANTOM2.Show();
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				break;
			case 5:
				this.pictureBoxSPECTRE2.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				break;
			case 6:
				this.pictureBoxSTINGER2.Show();
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				break;
			case 7:
				this.pictureBoxVANDAL2.Show();
				config.max_recoil = 45;
				config.recoilspeed = 1.5;
				break;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00012BC0 File Offset: 0x00010FC0
		private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.allhide3();
			switch (this.metroComboBox3.SelectedIndex)
			{
			case 0:
				this.pictureBoxARES3.Show();
				config.max_recoil = 80;
				config.recoilspeed = 0.75;
				break;
			case 1:
				this.pictureBoxBULLDOG3.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.2;
				break;
			case 2:
				this.pictureBoxFRENZY3.Show();
				config.max_recoil = 30;
				config.recoilspeed = 1.5;
				break;
			case 3:
				this.pictureBoxODIN3.Show();
				config.max_recoil = 90;
				config.recoilspeed = 0.75;
				break;
			case 4:
				this.pictureBoxPHANTOM3.Show();
				config.max_recoil = 38;
				config.recoilspeed = 1.5;
				break;
			case 5:
				this.pictureBoxSPECTRE3.Show();
				config.max_recoil = 35;
				config.recoilspeed = 1.5;
				break;
			case 6:
				this.pictureBoxSTINGER3.Show();
				config.max_recoil = 46;
				config.recoilspeed = 1.5;
				break;
			case 7:
				this.pictureBoxVANDAL3.Show();
				config.max_recoil = 45;
				config.recoilspeed = 1.5;
				break;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00012D44 File Offset: 0x00011144
		private void label10_Click(object sender, EventArgs e)
		{
			while (UserControl3.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label10.Text = this.get_name_of_key(key);
			bool flag = key != 0;
			if (flag)
			{
				config.weapon1_key = key;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00012D98 File Offset: 0x00011198
		private void label7_Click(object sender, EventArgs e)
		{
			while (UserControl3.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label7.Text = this.get_name_of_key(key);
			bool flag = key != 0;
			if (flag)
			{
				config.weapon2_key = key;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00012DEC File Offset: 0x000111EC
		private void label12_Click(object sender, EventArgs e)
		{
			while (UserControl3.GetAsyncKeyState(1) < 0)
			{
				Thread.Sleep(30);
			}
			int key = this.get_key();
			this.label12.Text = this.get_name_of_key(key);
			bool flag = key != 0;
			if (flag)
			{
				config.weapon3_key = key;
			}
		}

		// Token: 0x060001CD RID: 461
		[DllImport("User32.dll")]
		public static extern short GetAsyncKeyState(int ArrowKeys);

		// Token: 0x060001CE RID: 462 RVA: 0x000030D9 File Offset: 0x000014D9
		private void panel5_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00012E40 File Offset: 0x00011240
		private int get_key()
		{
			for (int i = 0; i < 500; i++)
			{
				foreach (int num in this.list_characters)
				{
					bool flag = UserControl3.GetAsyncKeyState(num) < 0;
					if (flag)
					{
						return num;
					}
				}
				Thread.Sleep(10);
			}
			return 0;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00012EA8 File Offset: 0x000112A8
		private string get_name_of_key(int key)
		{
			switch (key)
			{
			case 1:
				return "[ Left ]";
			case 2:
				return "[ Right]";
			case 3:
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

		// Token: 0x060001D1 RID: 465 RVA: 0x000130C8 File Offset: 0x000114C8
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = UserControl3.GetAsyncKeyState(config.weapon1_key) < 0;
			if (flag)
			{
				this.metroCheckBox3.Checked = true;
				this.metroCheckBox7.Checked = false;
				this.metroCheckBox4.Checked = false;
				while (UserControl3.GetAsyncKeyState(config.weapon1_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag2 = UserControl3.GetAsyncKeyState(config.weapon2_key) < 0;
			if (flag2)
			{
				this.metroCheckBox3.Checked = false;
				this.metroCheckBox7.Checked = true;
				this.metroCheckBox4.Checked = false;
				while (UserControl3.GetAsyncKeyState(config.weapon2_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
			bool flag3 = UserControl3.GetAsyncKeyState(config.weapon3_key) < 0;
			if (flag3)
			{
				this.metroCheckBox3.Checked = false;
				this.metroCheckBox7.Checked = false;
				this.metroCheckBox4.Checked = true;
				while (UserControl3.GetAsyncKeyState(config.weapon3_key) < 0)
				{
					Thread.Sleep(30);
				}
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000030D9 File Offset: 0x000014D9
		private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000131E0 File Offset: 0x000115E0
		private void label8_MouseHover(object sender, EventArgs e)
		{
			this.label8.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label10.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00013234 File Offset: 0x00011634
		private void label8_MouseLeave(object sender, EventArgs e)
		{
			this.label8.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label10.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00013288 File Offset: 0x00011688
		private void label9_MouseHover(object sender, EventArgs e)
		{
			this.label9.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label7.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000132DC File Offset: 0x000116DC
		private void label9_MouseLeave(object sender, EventArgs e)
		{
			this.label9.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label7.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00013330 File Offset: 0x00011730
		private void label11_MouseHover(object sender, EventArgs e)
		{
			this.label11.ForeColor = Color.FromArgb(255, 153, 51, 204);
			this.label12.ForeColor = Color.FromArgb(255, 153, 51, 204);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00013384 File Offset: 0x00011784
		private void label11_MouseLeave(object sender, EventArgs e)
		{
			this.label11.ForeColor = Color.FromArgb(255, 0, 174, 219);
			this.label12.ForeColor = Color.FromArgb(255, 153, 153, 153);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000030D9 File Offset: 0x000014D9
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000133D8 File Offset: 0x000117D8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00013410 File Offset: 0x00011810
		private void InitializeComponent()
		{
			this.components = new Container();
			this.panel1 = new Panel();
			this.label3 = new Label();
			this.label4 = new Label();
			this.metroTrackBar2 = new MetroTrackBar();
			this.Picture2_UserControl1 = new PictureBox();
			this.label2 = new Label();
			this.label1 = new Label();
			this.metroCheckBox2 = new MetroCheckBox();
			this.metroCheckBox1 = new MetroCheckBox();
			this.pictureBoxPHANTOM1 = new PictureBox();
			this.pictureBoxODIN1 = new PictureBox();
			this.pictureBoxFRENZY1 = new PictureBox();
			this.pictureBoxBULLDOG1 = new PictureBox();
			this.panel2 = new Panel();
			this.pictureBox2 = new PictureBox();
			this.pictureBox1 = new PictureBox();
			this.panel5 = new Panel();
			this.pictureBoxVANDAL1 = new PictureBox();
			this.pictureBoxSTINGER1 = new PictureBox();
			this.pictureBoxSPECTRE1 = new PictureBox();
			this.metroComboBox1 = new MetroComboBox();
			this.label8 = new Label();
			this.metroCheckBox3 = new MetroCheckBox();
			this.pictureBoxARES1 = new PictureBox();
			this.label10 = new Label();
			this.panel3 = new Panel();
			this.pictureBoxVANDAL3 = new PictureBox();
			this.pictureBoxSTINGER3 = new PictureBox();
			this.pictureBoxSPECTRE3 = new PictureBox();
			this.pictureBoxPHANTOM3 = new PictureBox();
			this.pictureBoxODIN3 = new PictureBox();
			this.pictureBoxFRENZY3 = new PictureBox();
			this.pictureBoxBULLDOG3 = new PictureBox();
			this.pictureBoxARES3 = new PictureBox();
			this.metroComboBox3 = new MetroComboBox();
			this.label11 = new Label();
			this.metroCheckBox4 = new MetroCheckBox();
			this.label12 = new Label();
			this.panel4 = new Panel();
			this.pictureBoxVANDAL2 = new PictureBox();
			this.pictureBoxSTINGER2 = new PictureBox();
			this.pictureBoxSPECTRE2 = new PictureBox();
			this.pictureBoxPHANTOM2 = new PictureBox();
			this.pictureBoxODIN2 = new PictureBox();
			this.pictureBoxFRENZY2 = new PictureBox();
			this.pictureBoxBULLDOG2 = new PictureBox();
			this.pictureBoxARES2 = new PictureBox();
			this.metroComboBox2 = new MetroComboBox();
			this.label9 = new Label();
			this.metroCheckBox7 = new MetroCheckBox();
			this.label7 = new Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.Picture2_UserControl1).BeginInit();
			((ISupportInitialize)this.pictureBoxPHANTOM1).BeginInit();
			((ISupportInitialize)this.pictureBoxODIN1).BeginInit();
			((ISupportInitialize)this.pictureBoxFRENZY1).BeginInit();
			((ISupportInitialize)this.pictureBoxBULLDOG1).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel5.SuspendLayout();
			((ISupportInitialize)this.pictureBoxVANDAL1).BeginInit();
			((ISupportInitialize)this.pictureBoxSTINGER1).BeginInit();
			((ISupportInitialize)this.pictureBoxSPECTRE1).BeginInit();
			((ISupportInitialize)this.pictureBoxARES1).BeginInit();
			this.panel3.SuspendLayout();
			((ISupportInitialize)this.pictureBoxVANDAL3).BeginInit();
			((ISupportInitialize)this.pictureBoxSTINGER3).BeginInit();
			((ISupportInitialize)this.pictureBoxSPECTRE3).BeginInit();
			((ISupportInitialize)this.pictureBoxPHANTOM3).BeginInit();
			((ISupportInitialize)this.pictureBoxODIN3).BeginInit();
			((ISupportInitialize)this.pictureBoxFRENZY3).BeginInit();
			((ISupportInitialize)this.pictureBoxBULLDOG3).BeginInit();
			((ISupportInitialize)this.pictureBoxARES3).BeginInit();
			this.panel4.SuspendLayout();
			((ISupportInitialize)this.pictureBoxVANDAL2).BeginInit();
			((ISupportInitialize)this.pictureBoxSTINGER2).BeginInit();
			((ISupportInitialize)this.pictureBoxSPECTRE2).BeginInit();
			((ISupportInitialize)this.pictureBoxPHANTOM2).BeginInit();
			((ISupportInitialize)this.pictureBoxODIN2).BeginInit();
			((ISupportInitialize)this.pictureBoxFRENZY2).BeginInit();
			((ISupportInitialize)this.pictureBoxBULLDOG2).BeginInit();
			((ISupportInitialize)this.pictureBoxARES2).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(32, 33, 38);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.metroTrackBar2);
			this.panel1.Controls.Add(this.Picture2_UserControl1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.metroCheckBox2);
			this.panel1.Controls.Add(this.metroCheckBox1);
			this.panel1.Location = new Point(10, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(339, 337);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += this.panel1_Paint;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI", 10f);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(295, 141);
			this.label3.Name = "label3";
			this.label3.Size = new Size(33, 19);
			this.label3.TabIndex = 14;
			this.label3.Text = "100";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label4.ForeColor = Color.FromArgb(0, 174, 219);
			this.label4.Location = new Point(15, 121);
			this.label4.Name = "label4";
			this.label4.Size = new Size(77, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Smoothnes";
			this.metroTrackBar2.BackColor = Color.Transparent;
			this.metroTrackBar2.Location = new Point(18, 141);
			this.metroTrackBar2.Name = "metroTrackBar2";
			this.metroTrackBar2.Size = new Size(260, 22);
			this.metroTrackBar2.Style = 3;
			this.metroTrackBar2.TabIndex = 13;
			this.metroTrackBar2.Text = "metroTrackBar2";
			this.metroTrackBar2.Theme = 2;
			this.metroTrackBar2.UseCustomBackColor = true;
			this.metroTrackBar2.Value = 100;
			this.metroTrackBar2.Scroll += this.metroTrackBar2_Scroll;
			this.Picture2_UserControl1.BackColor = Color.FromArgb(0, 174, 219);
			this.Picture2_UserControl1.Location = new Point(7, 103);
			this.Picture2_UserControl1.Name = "Picture2_UserControl1";
			this.Picture2_UserControl1.Size = new Size(325, 1);
			this.Picture2_UserControl1.TabIndex = 11;
			this.Picture2_UserControl1.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label2.ForeColor = Color.FromArgb(0, 174, 219);
			this.label2.Location = new Point(50, 52);
			this.label2.Name = "label2";
			this.label2.Size = new Size(99, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Enable Hip Fire";
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label1.ForeColor = Color.FromArgb(0, 174, 219);
			this.label1.Location = new Point(50, 22);
			this.label1.Name = "label1";
			this.label1.Size = new Size(135, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Enable Recoil System";
			this.label1.Click += this.label1_Click;
			this.metroCheckBox2.AutoSize = true;
			this.metroCheckBox2.Enabled = false;
			this.metroCheckBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox2.Location = new Point(30, 56);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new Size(26, 15);
			this.metroCheckBox2.Style = 4;
			this.metroCheckBox2.TabIndex = 8;
			this.metroCheckBox2.Text = " ";
			this.metroCheckBox2.Theme = 1;
			this.metroCheckBox2.UseCustomBackColor = true;
			this.metroCheckBox2.UseSelectable = true;
			this.metroCheckBox2.CheckedChanged += this.metroCheckBox2_CheckedChanged;
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox1.Location = new Point(30, 24);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new Size(26, 15);
			this.metroCheckBox1.Style = 4;
			this.metroCheckBox1.TabIndex = 7;
			this.metroCheckBox1.Text = " ";
			this.metroCheckBox1.Theme = 1;
			this.metroCheckBox1.UseCustomBackColor = true;
			this.metroCheckBox1.UseSelectable = true;
			this.metroCheckBox1.CheckedChanged += this.metroCheckBox1_CheckedChanged;
			this.pictureBoxPHANTOM1.Image = Resources.Phantom1;
			this.pictureBoxPHANTOM1.Location = new Point(212, 52);
			this.pictureBoxPHANTOM1.Name = "pictureBoxPHANTOM1";
			this.pictureBoxPHANTOM1.Size = new Size(100, 30);
			this.pictureBoxPHANTOM1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxPHANTOM1.TabIndex = 43;
			this.pictureBoxPHANTOM1.TabStop = false;
			this.pictureBoxODIN1.Image = Resources.Odin;
			this.pictureBoxODIN1.Location = new Point(212, 52);
			this.pictureBoxODIN1.Name = "pictureBoxODIN1";
			this.pictureBoxODIN1.Size = new Size(100, 30);
			this.pictureBoxODIN1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxODIN1.TabIndex = 42;
			this.pictureBoxODIN1.TabStop = false;
			this.pictureBoxFRENZY1.Image = Resources.Frenzy1;
			this.pictureBoxFRENZY1.Location = new Point(212, 52);
			this.pictureBoxFRENZY1.Name = "pictureBoxFRENZY1";
			this.pictureBoxFRENZY1.Size = new Size(100, 30);
			this.pictureBoxFRENZY1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxFRENZY1.TabIndex = 41;
			this.pictureBoxFRENZY1.TabStop = false;
			this.pictureBoxBULLDOG1.Image = Resources.Bulldog;
			this.pictureBoxBULLDOG1.Location = new Point(212, 52);
			this.pictureBoxBULLDOG1.Name = "pictureBoxBULLDOG1";
			this.pictureBoxBULLDOG1.Size = new Size(100, 30);
			this.pictureBoxBULLDOG1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBULLDOG1.TabIndex = 40;
			this.pictureBoxBULLDOG1.TabStop = false;
			this.panel2.BackColor = Color.FromArgb(32, 33, 38);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Location = new Point(355, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(323, 337);
			this.panel2.TabIndex = 1;
			this.pictureBox2.BackColor = Color.FromArgb(0, 174, 219);
			this.pictureBox2.Location = new Point(4, 217);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(314, 1);
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.BackColor = Color.FromArgb(0, 174, 219);
			this.pictureBox1.Location = new Point(4, 103);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(314, 1);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			this.panel5.BackColor = Color.FromArgb(32, 33, 38);
			this.panel5.Controls.Add(this.pictureBoxVANDAL1);
			this.panel5.Controls.Add(this.pictureBoxSTINGER1);
			this.panel5.Controls.Add(this.pictureBoxSPECTRE1);
			this.panel5.Controls.Add(this.pictureBoxPHANTOM1);
			this.panel5.Controls.Add(this.pictureBoxODIN1);
			this.panel5.Controls.Add(this.pictureBoxFRENZY1);
			this.panel5.Controls.Add(this.metroComboBox1);
			this.panel5.Controls.Add(this.pictureBoxBULLDOG1);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.metroCheckBox3);
			this.panel5.Controls.Add(this.pictureBoxARES1);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Location = new Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(350, 95);
			this.panel5.TabIndex = 41;
			this.panel5.Paint += this.panel5_Paint;
			this.pictureBoxVANDAL1.Image = Resources.Vandal;
			this.pictureBoxVANDAL1.Location = new Point(212, 52);
			this.pictureBoxVANDAL1.Name = "pictureBoxVANDAL1";
			this.pictureBoxVANDAL1.Size = new Size(100, 30);
			this.pictureBoxVANDAL1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxVANDAL1.TabIndex = 46;
			this.pictureBoxVANDAL1.TabStop = false;
			this.pictureBoxSTINGER1.Image = Resources.Stinger;
			this.pictureBoxSTINGER1.Location = new Point(212, 52);
			this.pictureBoxSTINGER1.Name = "pictureBoxSTINGER1";
			this.pictureBoxSTINGER1.Size = new Size(100, 30);
			this.pictureBoxSTINGER1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSTINGER1.TabIndex = 45;
			this.pictureBoxSTINGER1.TabStop = false;
			this.pictureBoxSPECTRE1.Image = Resources.Spectre;
			this.pictureBoxSPECTRE1.Location = new Point(212, 52);
			this.pictureBoxSPECTRE1.Name = "pictureBoxSPECTRE1";
			this.pictureBoxSPECTRE1.Size = new Size(100, 30);
			this.pictureBoxSPECTRE1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSPECTRE1.TabIndex = 44;
			this.pictureBoxSPECTRE1.TabStop = false;
			this.metroComboBox1.BackColor = Color.FromArgb(39, 41, 47);
			this.metroComboBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.IntegralHeight = false;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Items.AddRange(new object[]
			{
				"Ares",
				"Bulldog",
				"Frenzy",
				"Odin",
				"Phantom",
				"Spectre",
				"Stinger",
				"Vandal"
			});
			this.metroComboBox1.Location = new Point(18, 54);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.PromptText = "Select";
			this.metroComboBox1.RightToLeft = RightToLeft.No;
			this.metroComboBox1.Size = new Size(96, 29);
			this.metroComboBox1.Style = 3;
			this.metroComboBox1.TabIndex = 39;
			this.metroComboBox1.Theme = 2;
			this.metroComboBox1.UseCustomBackColor = true;
			this.metroComboBox1.UseCustomForeColor = true;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.UseStyleColors = true;
			this.metroComboBox1.SelectedIndexChanged += this.metroComboBox1_SelectedIndexChanged;
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label8.ForeColor = Color.FromArgb(0, 174, 219);
			this.label8.Location = new Point(50, 12);
			this.label8.Name = "label8";
			this.label8.Size = new Size(73, 17);
			this.label8.TabIndex = 31;
			this.label8.Text = "1- Weapon";
			this.label8.MouseLeave += this.label8_MouseLeave;
			this.label8.MouseHover += this.label8_MouseHover;
			this.metroCheckBox3.AutoSize = true;
			this.metroCheckBox3.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox3.Location = new Point(30, 14);
			this.metroCheckBox3.Name = "metroCheckBox3";
			this.metroCheckBox3.Size = new Size(26, 15);
			this.metroCheckBox3.Style = 4;
			this.metroCheckBox3.TabIndex = 30;
			this.metroCheckBox3.Text = " ";
			this.metroCheckBox3.Theme = 1;
			this.metroCheckBox3.UseCustomBackColor = true;
			this.metroCheckBox3.UseSelectable = true;
			this.metroCheckBox3.CheckedChanged += this.metroCheckBox3_CheckedChanged_1;
			this.pictureBoxARES1.Image = Resources.Ares;
			this.pictureBoxARES1.Location = new Point(212, 52);
			this.pictureBoxARES1.Name = "pictureBoxARES1";
			this.pictureBoxARES1.Size = new Size(100, 30);
			this.pictureBoxARES1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxARES1.TabIndex = 38;
			this.pictureBoxARES1.TabStop = false;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Segoe UI", 12f);
			this.label10.ForeColor = Color.FromArgb(153, 153, 153);
			this.label10.Location = new Point(234, 10);
			this.label10.Name = "label10";
			this.label10.Size = new Size(34, 21);
			this.label10.TabIndex = 36;
			this.label10.Text = "[ - ]";
			this.label10.Click += this.label10_Click;
			this.label10.MouseLeave += this.label8_MouseLeave;
			this.label10.MouseHover += this.label8_MouseHover;
			this.panel3.Controls.Add(this.pictureBoxVANDAL3);
			this.panel3.Controls.Add(this.pictureBoxSTINGER3);
			this.panel3.Controls.Add(this.pictureBoxSPECTRE3);
			this.panel3.Controls.Add(this.pictureBoxPHANTOM3);
			this.panel3.Controls.Add(this.pictureBoxODIN3);
			this.panel3.Controls.Add(this.pictureBoxFRENZY3);
			this.panel3.Controls.Add(this.pictureBoxBULLDOG3);
			this.panel3.Controls.Add(this.pictureBoxARES3);
			this.panel3.Controls.Add(this.metroComboBox3);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.metroCheckBox4);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Location = new Point(0, 224);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(350, 95);
			this.panel3.TabIndex = 41;
			this.pictureBoxVANDAL3.Image = Resources.Vandal;
			this.pictureBoxVANDAL3.Location = new Point(212, 52);
			this.pictureBoxVANDAL3.Name = "pictureBoxVANDAL3";
			this.pictureBoxVANDAL3.Size = new Size(100, 30);
			this.pictureBoxVANDAL3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxVANDAL3.TabIndex = 48;
			this.pictureBoxVANDAL3.TabStop = false;
			this.pictureBoxSTINGER3.Image = Resources.Stinger;
			this.pictureBoxSTINGER3.Location = new Point(212, 52);
			this.pictureBoxSTINGER3.Name = "pictureBoxSTINGER3";
			this.pictureBoxSTINGER3.Size = new Size(100, 30);
			this.pictureBoxSTINGER3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSTINGER3.TabIndex = 47;
			this.pictureBoxSTINGER3.TabStop = false;
			this.pictureBoxSPECTRE3.Image = Resources.Spectre;
			this.pictureBoxSPECTRE3.Location = new Point(212, 52);
			this.pictureBoxSPECTRE3.Name = "pictureBoxSPECTRE3";
			this.pictureBoxSPECTRE3.Size = new Size(100, 30);
			this.pictureBoxSPECTRE3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSPECTRE3.TabIndex = 47;
			this.pictureBoxSPECTRE3.TabStop = false;
			this.pictureBoxPHANTOM3.Image = Resources.Phantom1;
			this.pictureBoxPHANTOM3.Location = new Point(212, 52);
			this.pictureBoxPHANTOM3.Name = "pictureBoxPHANTOM3";
			this.pictureBoxPHANTOM3.Size = new Size(100, 30);
			this.pictureBoxPHANTOM3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxPHANTOM3.TabIndex = 47;
			this.pictureBoxPHANTOM3.TabStop = false;
			this.pictureBoxODIN3.Image = Resources.Odin;
			this.pictureBoxODIN3.Location = new Point(212, 52);
			this.pictureBoxODIN3.Name = "pictureBoxODIN3";
			this.pictureBoxODIN3.Size = new Size(100, 30);
			this.pictureBoxODIN3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxODIN3.TabIndex = 47;
			this.pictureBoxODIN3.TabStop = false;
			this.pictureBoxFRENZY3.Image = Resources.Frenzy1;
			this.pictureBoxFRENZY3.Location = new Point(212, 52);
			this.pictureBoxFRENZY3.Name = "pictureBoxFRENZY3";
			this.pictureBoxFRENZY3.Size = new Size(100, 30);
			this.pictureBoxFRENZY3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxFRENZY3.TabIndex = 47;
			this.pictureBoxFRENZY3.TabStop = false;
			this.pictureBoxBULLDOG3.Image = Resources.Bulldog;
			this.pictureBoxBULLDOG3.Location = new Point(212, 52);
			this.pictureBoxBULLDOG3.Name = "pictureBoxBULLDOG3";
			this.pictureBoxBULLDOG3.Size = new Size(100, 30);
			this.pictureBoxBULLDOG3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBULLDOG3.TabIndex = 47;
			this.pictureBoxBULLDOG3.TabStop = false;
			this.pictureBoxARES3.Image = Resources.Ares;
			this.pictureBoxARES3.Location = new Point(212, 52);
			this.pictureBoxARES3.Name = "pictureBoxARES3";
			this.pictureBoxARES3.Size = new Size(100, 30);
			this.pictureBoxARES3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxARES3.TabIndex = 47;
			this.pictureBoxARES3.TabStop = false;
			this.metroComboBox3.BackColor = Color.FromArgb(39, 41, 47);
			this.metroComboBox3.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroComboBox3.FormattingEnabled = true;
			this.metroComboBox3.IntegralHeight = false;
			this.metroComboBox3.ItemHeight = 23;
			this.metroComboBox3.Items.AddRange(new object[]
			{
				"Ares",
				"Bulldog",
				"Frenzy",
				"Odin",
				"Phantom",
				"Spectre",
				"Stinger",
				"Vandal"
			});
			this.metroComboBox3.Location = new Point(18, 54);
			this.metroComboBox3.Name = "metroComboBox3";
			this.metroComboBox3.PromptText = "Select";
			this.metroComboBox3.RightToLeft = RightToLeft.No;
			this.metroComboBox3.Size = new Size(96, 29);
			this.metroComboBox3.Style = 3;
			this.metroComboBox3.TabIndex = 41;
			this.metroComboBox3.Theme = 2;
			this.metroComboBox3.UseCustomBackColor = true;
			this.metroComboBox3.UseCustomForeColor = true;
			this.metroComboBox3.UseSelectable = true;
			this.metroComboBox3.UseStyleColors = true;
			this.metroComboBox3.SelectedIndexChanged += this.metroComboBox3_SelectedIndexChanged;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label11.ForeColor = Color.FromArgb(0, 174, 219);
			this.label11.Location = new Point(50, 12);
			this.label11.Name = "label11";
			this.label11.Size = new Size(75, 17);
			this.label11.TabIndex = 31;
			this.label11.Text = "3- Weapon";
			this.label11.MouseLeave += this.label11_MouseLeave;
			this.label11.MouseHover += this.label11_MouseHover;
			this.metroCheckBox4.AutoSize = true;
			this.metroCheckBox4.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox4.Location = new Point(30, 14);
			this.metroCheckBox4.Name = "metroCheckBox4";
			this.metroCheckBox4.Size = new Size(26, 15);
			this.metroCheckBox4.Style = 4;
			this.metroCheckBox4.TabIndex = 30;
			this.metroCheckBox4.Text = " ";
			this.metroCheckBox4.Theme = 1;
			this.metroCheckBox4.UseCustomBackColor = true;
			this.metroCheckBox4.UseSelectable = true;
			this.metroCheckBox4.CheckedChanged += this.metroCheckBox4_CheckedChanged;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Segoe UI", 12f);
			this.label12.ForeColor = Color.FromArgb(153, 153, 153);
			this.label12.Location = new Point(234, 10);
			this.label12.Name = "label12";
			this.label12.Size = new Size(34, 21);
			this.label12.TabIndex = 36;
			this.label12.Text = "[ - ]";
			this.label12.Click += this.label12_Click;
			this.label12.MouseLeave += this.label11_MouseLeave;
			this.label12.MouseHover += this.label11_MouseHover;
			this.panel4.Controls.Add(this.pictureBoxVANDAL2);
			this.panel4.Controls.Add(this.pictureBoxSTINGER2);
			this.panel4.Controls.Add(this.pictureBoxSPECTRE2);
			this.panel4.Controls.Add(this.pictureBoxPHANTOM2);
			this.panel4.Controls.Add(this.pictureBoxODIN2);
			this.panel4.Controls.Add(this.pictureBoxFRENZY2);
			this.panel4.Controls.Add(this.pictureBoxBULLDOG2);
			this.panel4.Controls.Add(this.pictureBoxARES2);
			this.panel4.Controls.Add(this.metroComboBox2);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.metroCheckBox7);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Location = new Point(0, 112);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(350, 95);
			this.panel4.TabIndex = 40;
			this.pictureBoxVANDAL2.Image = Resources.Vandal;
			this.pictureBoxVANDAL2.Location = new Point(212, 52);
			this.pictureBoxVANDAL2.Name = "pictureBoxVANDAL2";
			this.pictureBoxVANDAL2.Size = new Size(100, 30);
			this.pictureBoxVANDAL2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxVANDAL2.TabIndex = 47;
			this.pictureBoxVANDAL2.TabStop = false;
			this.pictureBoxSTINGER2.Image = Resources.Stinger;
			this.pictureBoxSTINGER2.Location = new Point(212, 52);
			this.pictureBoxSTINGER2.Name = "pictureBoxSTINGER2";
			this.pictureBoxSTINGER2.Size = new Size(100, 30);
			this.pictureBoxSTINGER2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSTINGER2.TabIndex = 46;
			this.pictureBoxSTINGER2.TabStop = false;
			this.pictureBoxSPECTRE2.Image = Resources.Spectre;
			this.pictureBoxSPECTRE2.Location = new Point(212, 52);
			this.pictureBoxSPECTRE2.Name = "pictureBoxSPECTRE2";
			this.pictureBoxSPECTRE2.Size = new Size(100, 30);
			this.pictureBoxSPECTRE2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxSPECTRE2.TabIndex = 46;
			this.pictureBoxSPECTRE2.TabStop = false;
			this.pictureBoxPHANTOM2.Image = Resources.Phantom1;
			this.pictureBoxPHANTOM2.Location = new Point(212, 52);
			this.pictureBoxPHANTOM2.Name = "pictureBoxPHANTOM2";
			this.pictureBoxPHANTOM2.Size = new Size(100, 30);
			this.pictureBoxPHANTOM2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxPHANTOM2.TabIndex = 46;
			this.pictureBoxPHANTOM2.TabStop = false;
			this.pictureBoxODIN2.Image = Resources.Odin;
			this.pictureBoxODIN2.Location = new Point(212, 52);
			this.pictureBoxODIN2.Name = "pictureBoxODIN2";
			this.pictureBoxODIN2.Size = new Size(100, 30);
			this.pictureBoxODIN2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxODIN2.TabIndex = 46;
			this.pictureBoxODIN2.TabStop = false;
			this.pictureBoxFRENZY2.Image = Resources.Frenzy1;
			this.pictureBoxFRENZY2.Location = new Point(212, 52);
			this.pictureBoxFRENZY2.Name = "pictureBoxFRENZY2";
			this.pictureBoxFRENZY2.Size = new Size(100, 30);
			this.pictureBoxFRENZY2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxFRENZY2.TabIndex = 46;
			this.pictureBoxFRENZY2.TabStop = false;
			this.pictureBoxBULLDOG2.Image = Resources.Bulldog;
			this.pictureBoxBULLDOG2.Location = new Point(212, 52);
			this.pictureBoxBULLDOG2.Name = "pictureBoxBULLDOG2";
			this.pictureBoxBULLDOG2.Size = new Size(100, 30);
			this.pictureBoxBULLDOG2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxBULLDOG2.TabIndex = 46;
			this.pictureBoxBULLDOG2.TabStop = false;
			this.pictureBoxARES2.Image = Resources.Ares;
			this.pictureBoxARES2.Location = new Point(212, 52);
			this.pictureBoxARES2.Name = "pictureBoxARES2";
			this.pictureBoxARES2.Size = new Size(100, 30);
			this.pictureBoxARES2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBoxARES2.TabIndex = 46;
			this.pictureBoxARES2.TabStop = false;
			this.metroComboBox2.BackColor = Color.FromArgb(39, 41, 47);
			this.metroComboBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.IntegralHeight = false;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Items.AddRange(new object[]
			{
				"Ares",
				"Bulldog",
				"Frenzy",
				"Odin",
				"Phantom",
				"Spectre",
				"Stinger",
				"Vandal"
			});
			this.metroComboBox2.Location = new Point(18, 54);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.PromptText = "Select";
			this.metroComboBox2.RightToLeft = RightToLeft.No;
			this.metroComboBox2.Size = new Size(96, 29);
			this.metroComboBox2.Style = 3;
			this.metroComboBox2.TabIndex = 40;
			this.metroComboBox2.Theme = 2;
			this.metroComboBox2.UseCustomBackColor = true;
			this.metroComboBox2.UseCustomForeColor = true;
			this.metroComboBox2.UseSelectable = true;
			this.metroComboBox2.UseStyleColors = true;
			this.metroComboBox2.SelectedIndexChanged += this.metroComboBox2_SelectedIndexChanged;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label9.ForeColor = Color.FromArgb(0, 174, 219);
			this.label9.Location = new Point(50, 12);
			this.label9.Name = "label9";
			this.label9.Size = new Size(75, 17);
			this.label9.TabIndex = 31;
			this.label9.Text = "2- Weapon";
			this.label9.MouseLeave += this.label9_MouseLeave;
			this.label9.MouseHover += this.label9_MouseHover;
			this.metroCheckBox7.AutoSize = true;
			this.metroCheckBox7.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox7.Location = new Point(30, 14);
			this.metroCheckBox7.Name = "metroCheckBox7";
			this.metroCheckBox7.Size = new Size(26, 15);
			this.metroCheckBox7.Style = 4;
			this.metroCheckBox7.TabIndex = 30;
			this.metroCheckBox7.Text = " ";
			this.metroCheckBox7.Theme = 1;
			this.metroCheckBox7.UseCustomBackColor = true;
			this.metroCheckBox7.UseSelectable = true;
			this.metroCheckBox7.CheckedChanged += this.metroCheckBox7_CheckedChanged;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI", 12f);
			this.label7.ForeColor = Color.FromArgb(153, 153, 153);
			this.label7.Location = new Point(234, 10);
			this.label7.Name = "label7";
			this.label7.Size = new Size(34, 21);
			this.label7.TabIndex = 36;
			this.label7.Text = "[ - ]";
			this.label7.Click += this.label7_Click;
			this.label7.MouseHover += this.label9_MouseHover;
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += this.timer1_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 41, 47);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Name = "UserControl3";
			base.Size = new Size(691, 366);
			base.Load += this.UserControl3_Load;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.Picture2_UserControl1).EndInit();
			((ISupportInitialize)this.pictureBoxPHANTOM1).EndInit();
			((ISupportInitialize)this.pictureBoxODIN1).EndInit();
			((ISupportInitialize)this.pictureBoxFRENZY1).EndInit();
			((ISupportInitialize)this.pictureBoxBULLDOG1).EndInit();
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((ISupportInitialize)this.pictureBoxVANDAL1).EndInit();
			((ISupportInitialize)this.pictureBoxSTINGER1).EndInit();
			((ISupportInitialize)this.pictureBoxSPECTRE1).EndInit();
			((ISupportInitialize)this.pictureBoxARES1).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((ISupportInitialize)this.pictureBoxVANDAL3).EndInit();
			((ISupportInitialize)this.pictureBoxSTINGER3).EndInit();
			((ISupportInitialize)this.pictureBoxSPECTRE3).EndInit();
			((ISupportInitialize)this.pictureBoxPHANTOM3).EndInit();
			((ISupportInitialize)this.pictureBoxODIN3).EndInit();
			((ISupportInitialize)this.pictureBoxFRENZY3).EndInit();
			((ISupportInitialize)this.pictureBoxBULLDOG3).EndInit();
			((ISupportInitialize)this.pictureBoxARES3).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((ISupportInitialize)this.pictureBoxVANDAL2).EndInit();
			((ISupportInitialize)this.pictureBoxSTINGER2).EndInit();
			((ISupportInitialize)this.pictureBoxSPECTRE2).EndInit();
			((ISupportInitialize)this.pictureBoxPHANTOM2).EndInit();
			((ISupportInitialize)this.pictureBoxODIN2).EndInit();
			((ISupportInitialize)this.pictureBoxFRENZY2).EndInit();
			((ISupportInitialize)this.pictureBoxBULLDOG2).EndInit();
			((ISupportInitialize)this.pictureBoxARES2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000150 RID: 336
		private int[] list_characters = new int[]
		{
			1,
			2,
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

		// Token: 0x04000151 RID: 337
		private IContainer components = null;

		// Token: 0x04000152 RID: 338
		private Panel panel1;

		// Token: 0x04000153 RID: 339
		private PictureBox Picture2_UserControl1;

		// Token: 0x04000154 RID: 340
		private Label label2;

		// Token: 0x04000155 RID: 341
		private Label label1;

		// Token: 0x04000156 RID: 342
		private MetroCheckBox metroCheckBox2;

		// Token: 0x04000157 RID: 343
		private MetroCheckBox metroCheckBox1;

		// Token: 0x04000158 RID: 344
		private Label label3;

		// Token: 0x04000159 RID: 345
		private Label label4;

		// Token: 0x0400015A RID: 346
		private MetroTrackBar metroTrackBar2;

		// Token: 0x0400015B RID: 347
		private Panel panel2;

		// Token: 0x0400015C RID: 348
		private Panel panel3;

		// Token: 0x0400015D RID: 349
		private Label label11;

		// Token: 0x0400015E RID: 350
		private MetroCheckBox metroCheckBox4;

		// Token: 0x0400015F RID: 351
		private Label label12;

		// Token: 0x04000160 RID: 352
		private Panel panel5;

		// Token: 0x04000161 RID: 353
		private Label label8;

		// Token: 0x04000162 RID: 354
		private MetroCheckBox metroCheckBox3;

		// Token: 0x04000163 RID: 355
		private PictureBox pictureBoxARES1;

		// Token: 0x04000164 RID: 356
		private Label label10;

		// Token: 0x04000165 RID: 357
		private MetroComboBox metroComboBox1;

		// Token: 0x04000166 RID: 358
		private MetroComboBox metroComboBox3;

		// Token: 0x04000167 RID: 359
		private Panel panel4;

		// Token: 0x04000168 RID: 360
		private MetroComboBox metroComboBox2;

		// Token: 0x04000169 RID: 361
		private Label label9;

		// Token: 0x0400016A RID: 362
		private MetroCheckBox metroCheckBox7;

		// Token: 0x0400016B RID: 363
		private Label label7;

		// Token: 0x0400016C RID: 364
		private PictureBox pictureBoxBULLDOG1;

		// Token: 0x0400016D RID: 365
		private PictureBox pictureBoxFRENZY1;

		// Token: 0x0400016E RID: 366
		private PictureBox pictureBoxODIN1;

		// Token: 0x0400016F RID: 367
		private PictureBox pictureBoxPHANTOM1;

		// Token: 0x04000170 RID: 368
		private PictureBox pictureBoxSPECTRE1;

		// Token: 0x04000171 RID: 369
		private PictureBox pictureBoxSTINGER1;

		// Token: 0x04000172 RID: 370
		private PictureBox pictureBoxVANDAL1;

		// Token: 0x04000173 RID: 371
		private PictureBox pictureBoxPHANTOM3;

		// Token: 0x04000174 RID: 372
		private PictureBox pictureBoxODIN3;

		// Token: 0x04000175 RID: 373
		private PictureBox pictureBoxFRENZY3;

		// Token: 0x04000176 RID: 374
		private PictureBox pictureBoxBULLDOG3;

		// Token: 0x04000177 RID: 375
		private PictureBox pictureBoxARES3;

		// Token: 0x04000178 RID: 376
		private PictureBox pictureBoxPHANTOM2;

		// Token: 0x04000179 RID: 377
		private PictureBox pictureBoxODIN2;

		// Token: 0x0400017A RID: 378
		private PictureBox pictureBoxFRENZY2;

		// Token: 0x0400017B RID: 379
		private PictureBox pictureBoxBULLDOG2;

		// Token: 0x0400017C RID: 380
		private PictureBox pictureBoxARES2;

		// Token: 0x0400017D RID: 381
		private PictureBox pictureBoxVANDAL3;

		// Token: 0x0400017E RID: 382
		private PictureBox pictureBoxSTINGER3;

		// Token: 0x0400017F RID: 383
		private PictureBox pictureBoxSPECTRE3;

		// Token: 0x04000180 RID: 384
		private PictureBox pictureBoxVANDAL2;

		// Token: 0x04000181 RID: 385
		private PictureBox pictureBoxSTINGER2;

		// Token: 0x04000182 RID: 386
		private PictureBox pictureBoxSPECTRE2;

		// Token: 0x04000183 RID: 387
		private System.Windows.Forms.Timer timer1;

		// Token: 0x04000184 RID: 388
		private PictureBox pictureBox2;

		// Token: 0x04000185 RID: 389
		private PictureBox pictureBox1;
	}
}
