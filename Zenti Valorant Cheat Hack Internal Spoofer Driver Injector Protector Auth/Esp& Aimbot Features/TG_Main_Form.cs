using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SkyCheats.Properties;
using SkyCheats.UserControls;

namespace SkyCheats
{
	// Token: 0x02000013 RID: 19
	public partial class TG_Main_Form : Form
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00006BA0 File Offset: 0x00004FA0
		public TG_Main_Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006BB8 File Offset: 0x00004FB8
		private void TG_Main_Form_Load(object sender, EventArgs e)
		{
			this.userControl41.Hide();
			this.userControl51.Hide();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006BD3 File Offset: 0x00004FD3
		private void Button_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl41.Hide();
			this.userControl51.Hide();
			this.userControlTG1.Show();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006BFA File Offset: 0x00004FFA
		private void Button4_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl41.Show();
			this.userControl51.Hide();
			this.userControlTG1.Hide();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006C21 File Offset: 0x00005021
		private void Button5_Button_Panel_Click(object sender, EventArgs e)
		{
			this.userControl41.Hide();
			this.userControl51.Show();
			this.userControlTG1.Hide();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000030CE File Offset: 0x000014CE
		private void Button2_Top_Panel_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006C48 File Offset: 0x00005048
		private void Top_Panel_MouseDown(object sender, MouseEventArgs e)
		{
			this.Grip = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006C94 File Offset: 0x00005094
		private void Top_Panel_MouseMove(object sender, MouseEventArgs e)
		{
			bool grip = this.Grip;
			if (grip)
			{
				base.Left = Cursor.Position.X - this.MouseX;
				base.Top = Cursor.Position.Y - this.MouseY;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006CE4 File Offset: 0x000050E4
		private void Top_Panel_MouseUp(object sender, MouseEventArgs e)
		{
			this.Grip = false;
			this.MouseX = 0;
			this.MouseY = 0;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000030C4 File Offset: 0x000014C4
		private void Button_Top_Panel_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0400009D RID: 157
		private bool Grip;

		// Token: 0x0400009E RID: 158
		private int MouseX;

		// Token: 0x0400009F RID: 159
		private int MouseY;
	}
}
