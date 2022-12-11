using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace SkyCheats.UserControls
{
	// Token: 0x0200001C RID: 28
	public class UserControl7 : UserControl
	{
		// Token: 0x060001FB RID: 507 RVA: 0x0001A3F8 File Offset: 0x000187F8
		public UserControl7()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000D008 File Offset: 0x0000B408
		private void button4_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001A410 File Offset: 0x00018810
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001A448 File Offset: 0x00018848
		private void InitializeComponent()
		{
			this.label7 = new Label();
			this.label5 = new Label();
			this.label1 = new Label();
			this.metroTextBox1 = new MetroTextBox();
			this.metroTextBox2 = new MetroTextBox();
			this.label2 = new Label();
			this.metroTextBox3 = new MetroTextBox();
			this.label3 = new Label();
			this.button4 = new Button();
			base.SuspendLayout();
			this.label7.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label7.ForeColor = Color.FromArgb(153, 153, 153);
			this.label7.Location = new Point(10, 12);
			this.label7.Name = "label7";
			this.label7.Size = new Size(151, 29);
			this.label7.TabIndex = 64;
			this.label7.Text = "Change your password";
			this.label7.TextAlign = ContentAlignment.MiddleLeft;
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.FromArgb(102, 102, 102);
			this.label5.Location = new Point(9, 41);
			this.label5.Name = "label5";
			this.label5.Size = new Size(338, 43);
			this.label5.TabIndex = 72;
			this.label5.Text = "* Enter your current password and a new password.";
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(153, 153, 153);
			this.label1.Location = new Point(10, 126);
			this.label1.Name = "label1";
			this.label1.Size = new Size(151, 29);
			this.label1.TabIndex = 73;
			this.label1.Text = "Current Password";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.metroTextBox1.BackColor = Color.FromArgb(39, 41, 47);
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new Point(126, 2);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new Size(21, 21);
			this.metroTextBox1.CustomButton.Style = 4;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = 1;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.FontSize = 1;
			this.metroTextBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroTextBox1.Lines = new string[0];
			this.metroTextBox1.Location = new Point(10, 158);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.RightToLeft = RightToLeft.No;
			this.metroTextBox1.ScrollBars = ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new Size(150, 26);
			this.metroTextBox1.Style = 3;
			this.metroTextBox1.TabIndex = 74;
			this.metroTextBox1.Theme = 2;
			this.metroTextBox1.UseCustomBackColor = true;
			this.metroTextBox1.UseCustomForeColor = true;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.UseStyleColors = true;
			this.metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox1.WaterMarkFont = null;
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
			this.metroTextBox2.Location = new Point(10, 96);
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
			this.metroTextBox2.TabIndex = 76;
			this.metroTextBox2.Theme = 2;
			this.metroTextBox2.UseCustomBackColor = true;
			this.metroTextBox2.UseCustomForeColor = true;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.UseStyleColors = true;
			this.metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox2.WaterMarkFont = null;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.ForeColor = Color.FromArgb(153, 153, 153);
			this.label2.Location = new Point(10, 64);
			this.label2.Name = "label2";
			this.label2.Size = new Size(151, 29);
			this.label2.TabIndex = 75;
			this.label2.Text = "New Password";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
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
			this.metroTextBox3.Location = new Point(185, 96);
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
			this.metroTextBox3.TabIndex = 78;
			this.metroTextBox3.Theme = 2;
			this.metroTextBox3.UseCustomBackColor = true;
			this.metroTextBox3.UseCustomForeColor = true;
			this.metroTextBox3.UseSelectable = true;
			this.metroTextBox3.UseStyleColors = true;
			this.metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox3.WaterMarkFont = null;
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(185, 64);
			this.label3.Name = "label3";
			this.label3.Size = new Size(151, 29);
			this.label3.TabIndex = 77;
			this.label3.Text = "Confirm New Password";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			this.button4.BackColor = Color.FromArgb(80, 250, 241);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button4.ForeColor = Color.FromArgb(32, 33, 38);
			this.button4.Location = new Point(184, 158);
			this.button4.Name = "button4";
			this.button4.Size = new Size(150, 26);
			this.button4.TabIndex = 79;
			this.button4.Text = "Cancel";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(32, 33, 38);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.metroTextBox3);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.metroTextBox2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.metroTextBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label7);
			base.Name = "UserControl7";
			base.Size = new Size(350, 199);
			base.ResumeLayout(false);
		}

		// Token: 0x040001DC RID: 476
		private IContainer components = null;

		// Token: 0x040001DD RID: 477
		private Label label7;

		// Token: 0x040001DE RID: 478
		private Label label5;

		// Token: 0x040001DF RID: 479
		private Label label1;

		// Token: 0x040001E0 RID: 480
		private MetroTextBox metroTextBox1;

		// Token: 0x040001E1 RID: 481
		private MetroTextBox metroTextBox2;

		// Token: 0x040001E2 RID: 482
		private Label label2;

		// Token: 0x040001E3 RID: 483
		private MetroTextBox metroTextBox3;

		// Token: 0x040001E4 RID: 484
		private Label label3;

		// Token: 0x040001E5 RID: 485
		private Button button4;
	}
}
