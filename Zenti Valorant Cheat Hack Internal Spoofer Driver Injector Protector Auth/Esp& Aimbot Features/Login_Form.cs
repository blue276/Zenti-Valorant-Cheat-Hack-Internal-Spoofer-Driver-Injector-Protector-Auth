using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SkyCheats.LUserControls;
using SkyCheats.Properties;

namespace SkyCheats
{
	// Token: 0x02000010 RID: 16
	public partial class Login_Form : Form
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00003043 File Offset: 0x00001443
		public Login_Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000305C File Offset: 0x0000145C
		private void Top_Panel_MouseMove(object sender, MouseEventArgs e)
		{
			bool grip = this.Grip;
			if (grip)
			{
				base.Left = Cursor.Position.X - this.MouseX;
				base.Top = Cursor.Position.Y - this.MouseY;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000030AC File Offset: 0x000014AC
		private void Top_Panel_MouseUp(object sender, MouseEventArgs e)
		{
			this.Grip = false;
			this.MouseX = 0;
			this.MouseY = 0;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000030C4 File Offset: 0x000014C4
		private void Button_Top_Panel_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000030CE File Offset: 0x000014CE
		private void Button2_Top_Panel_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000030D9 File Offset: 0x000014D9
		private void Login_Form_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000030D9 File Offset: 0x000014D9
		private void lUserControl41_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000030DC File Offset: 0x000014DC
		private void Top_Panel_MouseDown(object sender, MouseEventArgs e)
		{
			this.Grip = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x04000067 RID: 103
		private bool Grip;

		// Token: 0x04000068 RID: 104
		private int MouseX;

		// Token: 0x04000069 RID: 105
		private int MouseY;
	}
}
