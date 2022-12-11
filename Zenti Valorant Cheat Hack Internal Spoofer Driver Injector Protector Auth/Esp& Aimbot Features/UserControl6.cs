using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SkyCheats.Properties;

namespace SkyCheats.UserControls
{
	// Token: 0x0200001B RID: 27
	public class UserControl6 : UserControl
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00019A78 File Offset: 0x00017E78
		public UserControl6()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00019A90 File Offset: 0x00017E90
		private void UserControl6_Load(object sender, EventArgs e)
		{
			this.button8.Text = config.user_data.username;
			this.userControl71.Hide();
			this.button8.Text = config.user_data.username;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000030D9 File Offset: 0x000014D9
		private void button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00019ACB File Offset: 0x00017ECB
		private void button2_Click(object sender, EventArgs e)
		{
			this.userControl71.Show();
			this.userControl71.BringToFront();
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00019AE8 File Offset: 0x00017EE8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00019B20 File Offset: 0x00017F20
		private void InitializeComponent()
		{
			this.button8 = new Button();
			this.label9 = new Label();
			this.label7 = new Label();
			this.button2 = new Button();
			this.label1 = new Label();
			this.label5 = new Label();
			this.button1 = new Button();
			this.button3 = new Button();
			this.pictureBox4 = new PictureBox();
			this.userControl71 = new UserControl7();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			base.SuspendLayout();
			this.button8.BackColor = Color.FromArgb(32, 33, 38);
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Segoe UI", 10f);
			this.button8.ForeColor = Color.FromArgb(102, 102, 102);
			this.button8.Location = new Point(114, 213);
			this.button8.Name = "button8";
			this.button8.Size = new Size(220, 29);
			this.button8.TabIndex = 56;
			this.button8.Text = "AAL-S5IH-DMUW-ICWW-ZCRH";
			this.button8.UseVisualStyleBackColor = false;
			this.label9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label9.ForeColor = Color.FromArgb(153, 153, 153);
			this.label9.Location = new Point(10, 213);
			this.label9.Name = "label9";
			this.label9.Size = new Size(98, 29);
			this.label9.TabIndex = 57;
			this.label9.Text = "Account";
			this.label9.TextAlign = ContentAlignment.MiddleLeft;
			this.label7.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label7.ForeColor = Color.FromArgb(153, 153, 153);
			this.label7.Location = new Point(10, 7);
			this.label7.Name = "label7";
			this.label7.Size = new Size(151, 29);
			this.label7.TabIndex = 63;
			this.label7.Text = "Password";
			this.label7.TextAlign = ContentAlignment.MiddleLeft;
			this.button2.BackColor = Color.FromArgb(80, 250, 241);
			this.button2.Enabled = false;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button2.ForeColor = Color.FromArgb(32, 33, 38);
			this.button2.Location = new Point(13, 39);
			this.button2.Name = "button2";
			this.button2.Size = new Size(130, 26);
			this.button2.TabIndex = 69;
			this.button2.Text = "Change Password";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(153, 153, 153);
			this.label1.Location = new Point(10, 77);
			this.label1.Name = "label1";
			this.label1.Size = new Size(151, 29);
			this.label1.TabIndex = 70;
			this.label1.Text = "Account Removal";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.FromArgb(102, 102, 102);
			this.label5.Location = new Point(12, 106);
			this.label5.Name = "label5";
			this.label5.Size = new Size(322, 43);
			this.label5.TabIndex = 71;
			this.label5.Text = "* Disabling your account means you can recover it at any time after taking this action.\r\n";
			this.button1.BackColor = Color.FromArgb(80, 250, 241);
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button1.ForeColor = Color.FromArgb(32, 33, 38);
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(13, 158);
			this.button1.Name = "button1";
			this.button1.Size = new Size(150, 26);
			this.button1.TabIndex = 73;
			this.button1.Text = "Disable Account";
			this.button1.UseVisualStyleBackColor = false;
			this.button3.BackColor = Color.FromArgb(32, 33, 38);
			this.button3.Enabled = false;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button3.ForeColor = Color.FromArgb(80, 250, 241);
			this.button3.ImageAlign = ContentAlignment.MiddleLeft;
			this.button3.Location = new Point(184, 158);
			this.button3.Name = "button3";
			this.button3.Size = new Size(150, 26);
			this.button3.TabIndex = 72;
			this.button3.Text = "Delete Account";
			this.button3.UseVisualStyleBackColor = false;
			this.pictureBox4.Image = Resources.Picture2_UserControl1;
			this.pictureBox4.Location = new Point(7, 202);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(336, 1);
			this.pictureBox4.TabIndex = 58;
			this.pictureBox4.TabStop = false;
			this.userControl71.BackColor = Color.FromArgb(32, 33, 38);
			this.userControl71.Location = new Point(0, 0);
			this.userControl71.Name = "userControl71";
			this.userControl71.Size = new Size(350, 199);
			this.userControl71.TabIndex = 74;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(32, 33, 38);
			base.Controls.Add(this.userControl71);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.label9);
			base.Name = "UserControl6";
			base.Size = new Size(350, 308);
			base.Load += this.UserControl6_Load;
			((ISupportInitialize)this.pictureBox4).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001D1 RID: 465
		private IContainer components = null;

		// Token: 0x040001D2 RID: 466
		private Button button8;

		// Token: 0x040001D3 RID: 467
		private Label label9;

		// Token: 0x040001D4 RID: 468
		private PictureBox pictureBox4;

		// Token: 0x040001D5 RID: 469
		private Label label7;

		// Token: 0x040001D6 RID: 470
		private Button button2;

		// Token: 0x040001D7 RID: 471
		private Label label1;

		// Token: 0x040001D8 RID: 472
		private Label label5;

		// Token: 0x040001D9 RID: 473
		private Button button1;

		// Token: 0x040001DA RID: 474
		private Button button3;

		// Token: 0x040001DB RID: 475
		private UserControl7 userControl71;
	}
}
