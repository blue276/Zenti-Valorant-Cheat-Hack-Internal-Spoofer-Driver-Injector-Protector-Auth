using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace SkyCheats.UserControls
{
	// Token: 0x02000015 RID: 21
	public class UserControl10 : UserControl
	{
		// Token: 0x06000198 RID: 408 RVA: 0x0000CFF0 File Offset: 0x0000B3F0
		public UserControl10()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000D008 File Offset: 0x0000B408
		private void button1_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000D008 File Offset: 0x0000B408
		private void button4_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000030D9 File Offset: 0x000014D9
		private void UserControl10_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000D014 File Offset: 0x0000B414
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000D04C File Offset: 0x0000B44C
		private void InitializeComponent()
		{
			this.button4 = new Button();
			this.metroTextBox3 = new MetroTextBox();
			this.label3 = new Label();
			this.metroTextBox2 = new MetroTextBox();
			this.label2 = new Label();
			this.label5 = new Label();
			this.button1 = new Button();
			this.label1 = new Label();
			base.SuspendLayout();
			this.button4.BackColor = Color.FromArgb(32, 33, 38);
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button4.ForeColor = Color.FromArgb(80, 250, 241);
			this.button4.Location = new Point(185, 134);
			this.button4.Name = "button4";
			this.button4.Size = new Size(150, 26);
			this.button4.TabIndex = 86;
			this.button4.Text = "Save";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.metroTextBox3.BackColor = Color.FromArgb(39, 41, 47);
			this.metroTextBox3.CustomButton.Image = null;
			this.metroTextBox3.CustomButton.Location = new Point(126, 2);
			this.metroTextBox3.CustomButton.Name = "";
			this.metroTextBox3.CustomButton.Size = new Size(21, 21);
			this.metroTextBox3.CustomButton.Style = 4;
			this.metroTextBox3.CustomButton.TabIndex = 1;
			this.metroTextBox3.CustomButton.Theme = 1;
			this.metroTextBox3.CustomButton.UseSelectable = true;
			this.metroTextBox3.CustomButton.Visible = false;
			this.metroTextBox3.FontSize = 1;
			this.metroTextBox3.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroTextBox3.Lines = new string[0];
			this.metroTextBox3.Location = new Point(185, 94);
			this.metroTextBox3.MaxLength = 32767;
			this.metroTextBox3.Name = "metroTextBox3";
			this.metroTextBox3.PasswordChar = '\0';
			this.metroTextBox3.RightToLeft = RightToLeft.No;
			this.metroTextBox3.ScrollBars = ScrollBars.None;
			this.metroTextBox3.SelectedText = "";
			this.metroTextBox3.SelectionLength = 0;
			this.metroTextBox3.SelectionStart = 0;
			this.metroTextBox3.ShortcutsEnabled = true;
			this.metroTextBox3.Size = new Size(150, 26);
			this.metroTextBox3.Style = 3;
			this.metroTextBox3.TabIndex = 85;
			this.metroTextBox3.Theme = 2;
			this.metroTextBox3.UseCustomBackColor = true;
			this.metroTextBox3.UseCustomForeColor = true;
			this.metroTextBox3.UseSelectable = true;
			this.metroTextBox3.UseStyleColors = true;
			this.metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox3.WaterMarkFont = null;
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(185, 62);
			this.label3.Name = "label3";
			this.label3.Size = new Size(151, 29);
			this.label3.TabIndex = 84;
			this.label3.Text = "Current Password";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			this.metroTextBox2.BackColor = Color.FromArgb(39, 41, 47);
			this.metroTextBox2.CustomButton.Image = null;
			this.metroTextBox2.CustomButton.Location = new Point(126, 2);
			this.metroTextBox2.CustomButton.Name = "";
			this.metroTextBox2.CustomButton.Size = new Size(21, 21);
			this.metroTextBox2.CustomButton.Style = 4;
			this.metroTextBox2.CustomButton.TabIndex = 1;
			this.metroTextBox2.CustomButton.Theme = 1;
			this.metroTextBox2.CustomButton.UseSelectable = true;
			this.metroTextBox2.CustomButton.Visible = false;
			this.metroTextBox2.FontSize = 1;
			this.metroTextBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroTextBox2.Lines = new string[0];
			this.metroTextBox2.Location = new Point(10, 94);
			this.metroTextBox2.MaxLength = 32767;
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.PasswordChar = '\0';
			this.metroTextBox2.RightToLeft = RightToLeft.No;
			this.metroTextBox2.ScrollBars = ScrollBars.None;
			this.metroTextBox2.SelectedText = "";
			this.metroTextBox2.SelectionLength = 0;
			this.metroTextBox2.SelectionStart = 0;
			this.metroTextBox2.ShortcutsEnabled = true;
			this.metroTextBox2.Size = new Size(150, 26);
			this.metroTextBox2.Style = 3;
			this.metroTextBox2.TabIndex = 83;
			this.metroTextBox2.Theme = 2;
			this.metroTextBox2.UseCustomBackColor = true;
			this.metroTextBox2.UseCustomForeColor = true;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.UseStyleColors = true;
			this.metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox2.WaterMarkFont = null;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.ForeColor = Color.FromArgb(153, 153, 153);
			this.label2.Location = new Point(10, 62);
			this.label2.Name = "label2";
			this.label2.Size = new Size(151, 29);
			this.label2.TabIndex = 82;
			this.label2.Text = "Nickname";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.FromArgb(102, 102, 102);
			this.label5.Location = new Point(9, 37);
			this.label5.Name = "label5";
			this.label5.Size = new Size(338, 43);
			this.label5.TabIndex = 81;
			this.label5.Text = "* Enter a new username and your existing password.\r\n";
			this.button1.BackColor = Color.FromArgb(80, 250, 241);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button1.ForeColor = Color.FromArgb(32, 33, 38);
			this.button1.Location = new Point(10, 134);
			this.button1.Name = "button1";
			this.button1.Size = new Size(150, 26);
			this.button1.TabIndex = 87;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(153, 153, 153);
			this.label1.Location = new Point(10, 12);
			this.label1.Name = "label1";
			this.label1.Size = new Size(159, 26);
			this.label1.TabIndex = 88;
			this.label1.Text = "Change your nickname";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(32, 33, 38);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.metroTextBox3);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.metroTextBox2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label5);
			base.Name = "UserControl10";
			base.Size = new Size(350, 170);
			base.Load += this.UserControl10_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x040000F2 RID: 242
		private IContainer components = null;

		// Token: 0x040000F3 RID: 243
		private Button button4;

		// Token: 0x040000F4 RID: 244
		private MetroTextBox metroTextBox3;

		// Token: 0x040000F5 RID: 245
		private Label label3;

		// Token: 0x040000F6 RID: 246
		private MetroTextBox metroTextBox2;

		// Token: 0x040000F7 RID: 247
		private Label label2;

		// Token: 0x040000F8 RID: 248
		private Label label5;

		// Token: 0x040000F9 RID: 249
		private Button button1;

		// Token: 0x040000FA RID: 250
		private Label label1;
	}
}
