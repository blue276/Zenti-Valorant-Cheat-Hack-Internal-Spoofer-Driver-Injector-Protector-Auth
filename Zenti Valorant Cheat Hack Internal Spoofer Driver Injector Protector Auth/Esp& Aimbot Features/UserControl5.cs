using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using SkyCheats.Properties;

namespace SkyCheats.UserControls
{
	// Token: 0x0200001A RID: 26
	public class UserControl5 : UserControl
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00017F01 File Offset: 0x00016301
		public UserControl5()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000030D9 File Offset: 0x000014D9
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00017F1C File Offset: 0x0001631C
		private void button7_Click(object sender, EventArgs e)
		{
			this.userControl61.Show();
			this.userControl81.Show();
			this.userControl61.BringToFront();
			this.userControl81.BringToFront();
			this.button9.Show();
			this.button10.Show();
			this.button9.BringToFront();
			this.button10.BringToFront();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00017F8A File Offset: 0x0001638A
		private void UserControl5_Load(object sender, EventArgs e)
		{
			this.userControl61.Hide();
			this.button9.Hide();
			this.button10.Hide();
			this.userControl81.Hide();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00017FBD File Offset: 0x000163BD
		private void button9_Click(object sender, EventArgs e)
		{
			this.userControl61.Hide();
			this.userControl81.Hide();
			this.button9.Hide();
			this.button10.Hide();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox1_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00017FF0 File Offset: 0x000163F0
		private void userControl81_Load(object sender, EventArgs e)
		{
			this.button8.Text = config.user_data.username;
			this.button1.Text = config.user_data.username;
			this.button3.Text = "Unknown";
			this.button4.Text = config.expirylefttime;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0001804C File Offset: 0x0001644C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00018084 File Offset: 0x00016484
		private void InitializeComponent()
		{
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.button2 = new Button();
			this.button1 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button5 = new Button();
			this.panel2 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.label1 = new Label();
			this.label7 = new Label();
			this.pictureBox3 = new PictureBox();
			this.label8 = new Label();
			this.metroComboBox1 = new MetroComboBox();
			this.metroComboBox2 = new MetroComboBox();
			this.pictureBox4 = new PictureBox();
			this.button6 = new Button();
			this.button7 = new Button();
			this.button10 = new Button();
			this.button9 = new Button();
			this.panel1 = new Panel();
			this.button8 = new Button();
			this.label9 = new Label();
			this.userControl81 = new UserControl8();
			this.userControl61 = new UserControl6();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.ForeColor = Color.FromArgb(153, 153, 153);
			this.label2.Location = new Point(10, 132);
			this.label2.Name = "label2";
			this.label2.Size = new Size(69, 26);
			this.label2.TabIndex = 10;
			this.label2.Text = "Signature";
			this.label2.Click += this.label2_Click;
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(10, 12);
			this.label3.Name = "label3";
			this.label3.Size = new Size(71, 26);
			this.label3.TabIndex = 11;
			this.label3.Text = "Language";
			this.label4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label4.ForeColor = Color.FromArgb(153, 153, 153);
			this.label4.Location = new Point(10, 72);
			this.label4.Name = "label4";
			this.label4.Size = new Size(31, 26);
			this.label4.TabIndex = 12;
			this.label4.Text = "Key";
			this.label4.Click += this.label4_Click;
			this.label5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label5.ForeColor = Color.FromArgb(153, 153, 153);
			this.label5.Location = new Point(10, 102);
			this.label5.Name = "label5";
			this.label5.Size = new Size(102, 26);
			this.label5.TabIndex = 13;
			this.label5.Text = "Expiration Date";
			this.label5.Click += this.label5_Click;
			this.label6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label6.ForeColor = Color.FromArgb(153, 153, 153);
			this.label6.Location = new Point(10, 42);
			this.label6.Name = "label6";
			this.label6.Size = new Size(69, 26);
			this.label6.TabIndex = 14;
			this.label6.Text = "Nickname";
			this.button2.BackColor = Color.FromArgb(39, 41, 47);
			this.button2.Enabled = false;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Segoe UI", 10f);
			this.button2.ForeColor = Color.FromArgb(102, 102, 102);
			this.button2.Location = new Point(114, 12);
			this.button2.Name = "button2";
			this.button2.Size = new Size(220, 26);
			this.button2.TabIndex = 38;
			this.button2.Text = "English";
			this.button2.UseVisualStyleBackColor = false;
			this.button1.BackColor = Color.FromArgb(39, 41, 47);
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 10f);
			this.button1.ForeColor = Color.FromArgb(102, 102, 102);
			this.button1.Location = new Point(114, 42);
			this.button1.Name = "button1";
			this.button1.Size = new Size(220, 26);
			this.button1.TabIndex = 39;
			this.button1.Text = "Willie";
			this.button1.UseVisualStyleBackColor = false;
			this.button3.BackColor = Color.FromArgb(39, 41, 47);
			this.button3.Enabled = false;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Segoe UI", 10f);
			this.button3.ForeColor = Color.FromArgb(102, 102, 102);
			this.button3.Location = new Point(114, 72);
			this.button3.Name = "button3";
			this.button3.Size = new Size(220, 26);
			this.button3.TabIndex = 40;
			this.button3.Text = "AAL-S5IH-DMUW-ICWW-ZCRH";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button4.BackColor = Color.FromArgb(39, 41, 47);
			this.button4.Enabled = false;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Segoe UI", 10f);
			this.button4.ForeColor = Color.FromArgb(102, 102, 102);
			this.button4.Location = new Point(114, 102);
			this.button4.Name = "button4";
			this.button4.Size = new Size(220, 26);
			this.button4.TabIndex = 41;
			this.button4.Text = "29 Days";
			this.button4.UseVisualStyleBackColor = false;
			this.button5.BackColor = Color.FromArgb(39, 41, 47);
			this.button5.Enabled = false;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Segoe UI", 10f);
			this.button5.ForeColor = Color.FromArgb(102, 102, 102);
			this.button5.ImageAlign = ContentAlignment.MiddleRight;
			this.button5.Location = new Point(114, 132);
			this.button5.Name = "button5";
			this.button5.Size = new Size(220, 26);
			this.button5.TabIndex = 42;
			this.button5.Text = "Baka";
			this.button5.UseVisualStyleBackColor = false;
			this.panel2.BackColor = Color.FromArgb(32, 33, 38);
			this.panel2.Controls.Add(this.userControl81);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new Point(10, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(350, 170);
			this.panel2.TabIndex = 1;
			this.pictureBox1.Dock = DockStyle.Fill;
			this.pictureBox1.Image = Resources.Picture_UserControl;
			this.pictureBox1.Location = new Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(370, 515);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += this.pictureBox1_Click_2;
			this.label1.Enabled = false;
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(153, 153, 153);
			this.label1.Location = new Point(10, 12);
			this.label1.Name = "label1";
			this.label1.Size = new Size(98, 29);
			this.label1.TabIndex = 43;
			this.label1.Text = "Thema Color";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.label7.Enabled = false;
			this.label7.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label7.ForeColor = Color.FromArgb(153, 153, 153);
			this.label7.Location = new Point(12, 80);
			this.label7.Name = "label7";
			this.label7.Size = new Size(69, 29);
			this.label7.TabIndex = 43;
			this.label7.Text = "Preview";
			this.label7.TextAlign = ContentAlignment.MiddleLeft;
			this.pictureBox3.Enabled = false;
			this.pictureBox3.Image = Resources.Menu2Cyan;
			this.pictureBox3.Location = new Point(114, 80);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(220, 112);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 46;
			this.pictureBox3.TabStop = false;
			this.label8.Enabled = false;
			this.label8.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label8.ForeColor = Color.FromArgb(153, 153, 153);
			this.label8.Location = new Point(10, 46);
			this.label8.Name = "label8";
			this.label8.Size = new Size(98, 29);
			this.label8.TabIndex = 47;
			this.label8.Text = "Thema";
			this.label8.TextAlign = ContentAlignment.MiddleLeft;
			this.metroComboBox1.BackColor = Color.FromArgb(39, 41, 47);
			this.metroComboBox1.Enabled = false;
			this.metroComboBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.IntegralHeight = false;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Items.AddRange(new object[]
			{
				"Cyan",
				"Red",
				"Green",
				"Brown"
			});
			this.metroComboBox1.Location = new Point(114, 12);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.RightToLeft = RightToLeft.No;
			this.metroComboBox1.Size = new Size(220, 29);
			this.metroComboBox1.Style = 3;
			this.metroComboBox1.TabIndex = 49;
			this.metroComboBox1.Theme = 2;
			this.metroComboBox1.UseCustomBackColor = true;
			this.metroComboBox1.UseCustomForeColor = true;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.UseStyleColors = true;
			this.metroComboBox2.BackColor = Color.FromArgb(39, 41, 47);
			this.metroComboBox2.Enabled = false;
			this.metroComboBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.IntegralHeight = false;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Items.AddRange(new object[]
			{
				"Minimalist",
				"Maximalist"
			});
			this.metroComboBox2.Location = new Point(114, 46);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.RightToLeft = RightToLeft.No;
			this.metroComboBox2.Size = new Size(220, 29);
			this.metroComboBox2.Style = 3;
			this.metroComboBox2.TabIndex = 50;
			this.metroComboBox2.Theme = 2;
			this.metroComboBox2.UseCustomBackColor = true;
			this.metroComboBox2.UseCustomForeColor = true;
			this.metroComboBox2.UseSelectable = true;
			this.metroComboBox2.UseStyleColors = true;
			this.pictureBox4.Image = Resources.Picture2_UserControl1;
			this.pictureBox4.Location = new Point(7, 202);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(336, 1);
			this.pictureBox4.TabIndex = 51;
			this.pictureBox4.TabStop = false;
			this.button6.BackColor = Color.FromArgb(32, 33, 38);
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button6.ForeColor = Color.FromArgb(80, 250, 241);
			this.button6.Image = Resources.SessionExit2;
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(184, 260);
			this.button6.Name = "button6";
			this.button6.Size = new Size(150, 40);
			this.button6.TabIndex = 43;
			this.button6.Text = "Log Out";
			this.button6.UseVisualStyleBackColor = false;
			this.button7.BackColor = Color.FromArgb(80, 250, 241);
			this.button7.Enabled = false;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button7.ForeColor = Color.FromArgb(32, 33, 38);
			this.button7.Image = Resources.SessionEdit;
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(13, 260);
			this.button7.Name = "button7";
			this.button7.Size = new Size(150, 40);
			this.button7.TabIndex = 53;
			this.button7.Text = "Edit Account";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.button10.BackColor = Color.FromArgb(32, 33, 38);
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button10.ForeColor = Color.FromArgb(80, 250, 241);
			this.button10.Image = Resources.SessionExit2;
			this.button10.ImageAlign = ContentAlignment.MiddleLeft;
			this.button10.Location = new Point(184, 260);
			this.button10.Name = "button10";
			this.button10.Size = new Size(150, 40);
			this.button10.TabIndex = 69;
			this.button10.Text = "Save";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += this.button9_Click;
			this.button9.BackColor = Color.FromArgb(80, 250, 241);
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button9.ForeColor = Color.FromArgb(32, 33, 38);
			this.button9.Image = Resources.SessionEdit;
			this.button9.ImageAlign = ContentAlignment.MiddleLeft;
			this.button9.Location = new Point(13, 260);
			this.button9.Name = "button9";
			this.button9.Size = new Size(150, 40);
			this.button9.TabIndex = 70;
			this.button9.Text = "Back";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += this.button9_Click;
			this.panel1.BackColor = Color.FromArgb(32, 33, 38);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.userControl61);
			this.panel1.Controls.Add(this.button10);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.metroComboBox2);
			this.panel1.Controls.Add(this.metroComboBox1);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(10, 192);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(350, 308);
			this.panel1.TabIndex = 0;
			this.button8.BackColor = Color.FromArgb(32, 33, 38);
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Segoe UI", 10f);
			this.button8.ForeColor = Color.FromArgb(102, 102, 102);
			this.button8.Location = new Point(114, 213);
			this.button8.Name = "button8";
			this.button8.Size = new Size(220, 29);
			this.button8.TabIndex = 71;
			this.button8.Text = "AAL-S5IH-DMUW-ICWW-ZCRH";
			this.button8.UseVisualStyleBackColor = false;
			this.label9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label9.ForeColor = Color.FromArgb(153, 153, 153);
			this.label9.Location = new Point(10, 213);
			this.label9.Name = "label9";
			this.label9.Size = new Size(98, 29);
			this.label9.TabIndex = 72;
			this.label9.Text = "Account";
			this.label9.TextAlign = ContentAlignment.MiddleLeft;
			this.userControl81.BackColor = Color.FromArgb(32, 33, 38);
			this.userControl81.Dock = DockStyle.Fill;
			this.userControl81.Location = new Point(0, 0);
			this.userControl81.Name = "userControl81";
			this.userControl81.Size = new Size(350, 170);
			this.userControl81.TabIndex = 43;
			this.userControl81.Load += this.userControl81_Load;
			this.userControl61.BackColor = Color.FromArgb(32, 33, 38);
			this.userControl61.Location = new Point(0, 0);
			this.userControl61.Name = "userControl61";
			this.userControl61.Size = new Size(350, 258);
			this.userControl61.TabIndex = 54;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 41, 47);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox1);
			base.Name = "UserControl5";
			base.Size = new Size(370, 515);
			base.Load += this.UserControl5_Load;
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox4).EndInit();
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040001B4 RID: 436
		private IContainer components = null;

		// Token: 0x040001B5 RID: 437
		private Label label5;

		// Token: 0x040001B6 RID: 438
		private Label label4;

		// Token: 0x040001B7 RID: 439
		private Label label3;

		// Token: 0x040001B8 RID: 440
		private Label label2;

		// Token: 0x040001B9 RID: 441
		private Label label6;

		// Token: 0x040001BA RID: 442
		private Button button2;

		// Token: 0x040001BB RID: 443
		private Button button5;

		// Token: 0x040001BC RID: 444
		private Button button4;

		// Token: 0x040001BD RID: 445
		private Button button3;

		// Token: 0x040001BE RID: 446
		private Button button1;

		// Token: 0x040001BF RID: 447
		private Panel panel2;

		// Token: 0x040001C0 RID: 448
		private PictureBox pictureBox1;

		// Token: 0x040001C1 RID: 449
		private UserControl8 userControl81;

		// Token: 0x040001C2 RID: 450
		private Label label1;

		// Token: 0x040001C3 RID: 451
		private Label label7;

		// Token: 0x040001C4 RID: 452
		private PictureBox pictureBox3;

		// Token: 0x040001C5 RID: 453
		private Label label8;

		// Token: 0x040001C6 RID: 454
		private MetroComboBox metroComboBox1;

		// Token: 0x040001C7 RID: 455
		private MetroComboBox metroComboBox2;

		// Token: 0x040001C8 RID: 456
		private PictureBox pictureBox4;

		// Token: 0x040001C9 RID: 457
		private Button button6;

		// Token: 0x040001CA RID: 458
		private Button button7;

		// Token: 0x040001CB RID: 459
		private Button button10;

		// Token: 0x040001CC RID: 460
		private Button button9;

		// Token: 0x040001CD RID: 461
		private Panel panel1;

		// Token: 0x040001CE RID: 462
		private UserControl6 userControl61;

		// Token: 0x040001CF RID: 463
		private Button button8;

		// Token: 0x040001D0 RID: 464
		private Label label9;
	}
}
