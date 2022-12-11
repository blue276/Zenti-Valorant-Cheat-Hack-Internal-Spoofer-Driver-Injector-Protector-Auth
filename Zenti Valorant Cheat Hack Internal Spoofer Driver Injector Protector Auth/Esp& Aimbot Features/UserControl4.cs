using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SkyCheats.Properties;

namespace SkyCheats.UserControls
{
	// Token: 0x02000019 RID: 25
	public class UserControl4 : UserControl
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00015E4A File Offset: 0x0001424A
		public UserControl4()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox17_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00015E62 File Offset: 0x00014262
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("http://discord.gg/blastx");
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00015E70 File Offset: 0x00014270
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=J2mEW5jyD4s");
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00015E7E File Offset: 0x0001427E
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.blastcheat.com");
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00015E7E File Offset: 0x0001427E
		private void pictureBox9_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.blastcheat.com");
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00015E8C File Offset: 0x0001428C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00015EC4 File Offset: 0x000142C4
		private void InitializeComponent()
		{
			this.panel1 = new Panel();
			this.panel7 = new Panel();
			this.label9 = new Label();
			this.pictureBox5 = new PictureBox();
			this.panel6 = new Panel();
			this.label10 = new Label();
			this.pictureBox6 = new PictureBox();
			this.panel4 = new Panel();
			this.label11 = new Label();
			this.pictureBox7 = new PictureBox();
			this.panel9 = new Panel();
			this.label6 = new Label();
			this.pictureBox2 = new PictureBox();
			this.panel5 = new Panel();
			this.label12 = new Label();
			this.pictureBox8 = new PictureBox();
			this.panel10 = new Panel();
			this.pictureBox9 = new PictureBox();
			this.label7 = new Label();
			this.pictureBox3 = new PictureBox();
			this.panel2 = new Panel();
			this.label14 = new Label();
			this.pictureBox10 = new PictureBox();
			this.label2 = new Label();
			this.panel11 = new Panel();
			this.label5 = new Label();
			this.pictureBox1 = new PictureBox();
			this.label1 = new Label();
			this.panel12 = new Panel();
			this.panel14 = new Panel();
			this.label16 = new Label();
			this.label4 = new Label();
			this.label17 = new Label();
			this.pictureBox11 = new PictureBox();
			this.label15 = new Label();
			this.pictureBox14 = new PictureBox();
			this.label18 = new Label();
			this.pictureBox13 = new PictureBox();
			this.panel3 = new Panel();
			this.panel8 = new Panel();
			this.userControl81 = new UserControl8();
			this.label21 = new Label();
			this.label22 = new Label();
			this.pictureBox4 = new PictureBox();
			this.pictureBox18 = new PictureBox();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			this.panel6.SuspendLayout();
			((ISupportInitialize)this.pictureBox6).BeginInit();
			this.panel4.SuspendLayout();
			((ISupportInitialize)this.pictureBox7).BeginInit();
			this.panel9.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			this.panel5.SuspendLayout();
			((ISupportInitialize)this.pictureBox8).BeginInit();
			this.panel10.SuspendLayout();
			((ISupportInitialize)this.pictureBox9).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox10).BeginInit();
			this.panel11.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel12.SuspendLayout();
			this.panel14.SuspendLayout();
			((ISupportInitialize)this.pictureBox11).BeginInit();
			((ISupportInitialize)this.pictureBox14).BeginInit();
			((ISupportInitialize)this.pictureBox13).BeginInit();
			this.panel3.SuspendLayout();
			this.panel8.SuspendLayout();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox18).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(32, 33, 38);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel10);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.panel11);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(10, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(285, 200);
			this.panel1.TabIndex = 1;
			this.panel7.Controls.Add(this.label9);
			this.panel7.Controls.Add(this.pictureBox5);
			this.panel7.Location = new Point(211, 32);
			this.panel7.Name = "panel7";
			this.panel7.Size = new Size(60, 60);
			this.panel7.TabIndex = 51;
			this.label9.Dock = DockStyle.Fill;
			this.label9.Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold);
			this.label9.ForeColor = Color.FromArgb(153, 153, 153);
			this.label9.Location = new Point(0, 32);
			this.label9.Name = "label9";
			this.label9.Size = new Size(60, 28);
			this.label9.TabIndex = 47;
			this.label9.Text = "Telegram";
			this.label9.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox5.Dock = DockStyle.Top;
			this.pictureBox5.Image = Resources.Telegram;
			this.pictureBox5.Location = new Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new Size(60, 32);
			this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox5.TabIndex = 34;
			this.pictureBox5.TabStop = false;
			this.panel6.Controls.Add(this.label10);
			this.panel6.Controls.Add(this.pictureBox6);
			this.panel6.Location = new Point(211, 127);
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size(60, 60);
			this.panel6.TabIndex = 45;
			this.label10.Dock = DockStyle.Fill;
			this.label10.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label10.ForeColor = Color.FromArgb(153, 153, 153);
			this.label10.Location = new Point(0, 32);
			this.label10.Name = "label10";
			this.label10.Size = new Size(60, 28);
			this.label10.TabIndex = 47;
			this.label10.Text = "BTC";
			this.label10.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox6.Dock = DockStyle.Top;
			this.pictureBox6.Image = Resources.BTC;
			this.pictureBox6.Location = new Point(0, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new Size(60, 32);
			this.pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox6.TabIndex = 36;
			this.pictureBox6.TabStop = false;
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.pictureBox7);
			this.panel4.Location = new Point(145, 127);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(60, 60);
			this.panel4.TabIndex = 44;
			this.label11.Dock = DockStyle.Fill;
			this.label11.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label11.ForeColor = Color.FromArgb(153, 153, 153);
			this.label11.Location = new Point(0, 32);
			this.label11.Name = "label11";
			this.label11.Size = new Size(60, 28);
			this.label11.TabIndex = 47;
			this.label11.Text = "ETH";
			this.label11.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox7.Dock = DockStyle.Top;
			this.pictureBox7.Image = Resources.ETH;
			this.pictureBox7.Location = new Point(0, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new Size(60, 32);
			this.pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox7.TabIndex = 37;
			this.pictureBox7.TabStop = false;
			this.panel9.Controls.Add(this.label6);
			this.panel9.Controls.Add(this.pictureBox2);
			this.panel9.Location = new Point(79, 32);
			this.panel9.Name = "panel9";
			this.panel9.Size = new Size(60, 60);
			this.panel9.TabIndex = 48;
			this.label6.Dock = DockStyle.Fill;
			this.label6.Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold);
			this.label6.ForeColor = Color.FromArgb(153, 153, 153);
			this.label6.Location = new Point(0, 32);
			this.label6.Name = "label6";
			this.label6.Size = new Size(60, 28);
			this.label6.TabIndex = 47;
			this.label6.Text = "Youtube";
			this.label6.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox2.Dock = DockStyle.Top;
			this.pictureBox2.Image = Resources.Youtube2;
			this.pictureBox2.Location = new Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(60, 32);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 33;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += this.pictureBox2_Click;
			this.panel5.Controls.Add(this.label12);
			this.panel5.Controls.Add(this.pictureBox8);
			this.panel5.Location = new Point(79, 127);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(60, 60);
			this.panel5.TabIndex = 43;
			this.label12.Dock = DockStyle.Fill;
			this.label12.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label12.ForeColor = Color.FromArgb(153, 153, 153);
			this.label12.Location = new Point(0, 32);
			this.label12.Name = "label12";
			this.label12.Size = new Size(60, 28);
			this.label12.TabIndex = 47;
			this.label12.Text = "DOGE";
			this.label12.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox8.Dock = DockStyle.Top;
			this.pictureBox8.Image = Resources.dogecoin_export;
			this.pictureBox8.Location = new Point(0, 0);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new Size(60, 32);
			this.pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox8.TabIndex = 38;
			this.pictureBox8.TabStop = false;
			this.panel10.Controls.Add(this.pictureBox9);
			this.panel10.Controls.Add(this.label7);
			this.panel10.Controls.Add(this.pictureBox3);
			this.panel10.Location = new Point(145, 32);
			this.panel10.Name = "panel10";
			this.panel10.Size = new Size(60, 60);
			this.panel10.TabIndex = 49;
			this.pictureBox9.Image = Resources.SLOGOSS2;
			this.pictureBox9.Location = new Point(0, 0);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new Size(60, 33);
			this.pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 64;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Click += this.pictureBox9_Click_1;
			this.label7.Dock = DockStyle.Fill;
			this.label7.Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold);
			this.label7.ForeColor = Color.FromArgb(153, 153, 153);
			this.label7.Location = new Point(0, 32);
			this.label7.Name = "label7";
			this.label7.Size = new Size(60, 28);
			this.label7.TabIndex = 47;
			this.label7.Text = "WebSite";
			this.label7.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox3.Dock = DockStyle.Top;
			this.pictureBox3.Location = new Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(60, 32);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 14;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += this.pictureBox3_Click;
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Location = new Point(13, 127);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(60, 60);
			this.panel2.TabIndex = 41;
			this.label14.Dock = DockStyle.Fill;
			this.label14.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label14.ForeColor = Color.FromArgb(153, 153, 153);
			this.label14.Location = new Point(0, 32);
			this.label14.Name = "label14";
			this.label14.Size = new Size(60, 28);
			this.label14.TabIndex = 47;
			this.label14.Text = "BNB";
			this.label14.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox10.Dock = DockStyle.Top;
			this.pictureBox10.Image = Resources.BNB;
			this.pictureBox10.Location = new Point(0, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new Size(60, 32);
			this.pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox10.TabIndex = 40;
			this.pictureBox10.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.ForeColor = Color.FromArgb(0, 174, 219);
			this.label2.Location = new Point(23, 101);
			this.label2.Name = "label2";
			this.label2.Size = new Size(114, 17);
			this.label2.TabIndex = 35;
			this.label2.Text = "Payment Options";
			this.panel11.Controls.Add(this.label5);
			this.panel11.Controls.Add(this.pictureBox1);
			this.panel11.Location = new Point(13, 32);
			this.panel11.Name = "panel11";
			this.panel11.Size = new Size(60, 60);
			this.panel11.TabIndex = 47;
			this.label5.Dock = DockStyle.Fill;
			this.label5.Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold);
			this.label5.ForeColor = Color.FromArgb(153, 153, 153);
			this.label5.Location = new Point(0, 32);
			this.label5.Name = "label5";
			this.label5.Size = new Size(60, 28);
			this.label5.TabIndex = 46;
			this.label5.Text = "Discord";
			this.label5.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox1.Dock = DockStyle.Top;
			this.pictureBox1.Image = Resources.Discord1;
			this.pictureBox1.Location = new Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(60, 32);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += this.pictureBox1_Click;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(0, 174, 219);
			this.label1.Location = new Point(23, 6);
			this.label1.Name = "label1";
			this.label1.Size = new Size(61, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Contacts";
			this.panel12.BackColor = Color.FromArgb(0, 174, 219);
			this.panel12.Controls.Add(this.panel14);
			this.panel12.Location = new Point(303, 12);
			this.panel12.Name = "panel12";
			this.panel12.Size = new Size(184, 200);
			this.panel12.TabIndex = 52;
			this.panel14.BackColor = Color.FromArgb(32, 33, 38);
			this.panel14.Controls.Add(this.label16);
			this.panel14.Controls.Add(this.label4);
			this.panel14.Controls.Add(this.label17);
			this.panel14.Controls.Add(this.pictureBox11);
			this.panel14.Controls.Add(this.label15);
			this.panel14.Controls.Add(this.pictureBox14);
			this.panel14.Controls.Add(this.label18);
			this.panel14.Controls.Add(this.pictureBox13);
			this.panel14.Dock = DockStyle.Right;
			this.panel14.Location = new Point(9, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new Size(175, 200);
			this.panel14.TabIndex = 58;
			this.label16.Font = new Font("Segoe UI", 12f);
			this.label16.ForeColor = Color.FromArgb(153, 153, 153);
			this.label16.Location = new Point(66, 38);
			this.label16.Name = "label16";
			this.label16.Size = new Size(74, 32);
			this.label16.TabIndex = 55;
			this.label16.Text = "Blast";
			this.label16.TextAlign = ContentAlignment.MiddleLeft;
			this.label4.Font = new Font("Segoe UI", 12f);
			this.label4.ForeColor = Color.FromArgb(153, 153, 153);
			this.label4.Location = new Point(65, 155);
			this.label4.Name = "label4";
			this.label4.Size = new Size(74, 32);
			this.label4.TabIndex = 57;
			this.label4.Text = "FenZy";
			this.label4.TextAlign = ContentAlignment.MiddleLeft;
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label17.ForeColor = Color.FromArgb(0, 174, 219);
			this.label17.Location = new Point(24, 9);
			this.label17.Name = "label17";
			this.label17.Size = new Size(48, 17);
			this.label17.TabIndex = 53;
			this.label17.Text = "Owner";
			this.pictureBox11.Image = Resources.Anonim;
			this.pictureBox11.Location = new Point(27, 155);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new Size(32, 32);
			this.pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox11.TabIndex = 56;
			this.pictureBox11.TabStop = false;
			this.label15.Font = new Font("Segoe UI", 12f);
			this.label15.ForeColor = Color.FromArgb(153, 153, 153);
			this.label15.Location = new Point(65, 117);
			this.label15.Name = "label15";
			this.label15.Size = new Size(74, 32);
			this.label15.TabIndex = 55;
			this.label15.Text = "Vacvain";
			this.label15.TextAlign = ContentAlignment.MiddleLeft;
			this.pictureBox14.Image = Resources.Anonim;
			this.pictureBox14.Location = new Point(28, 38);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new Size(32, 32);
			this.pictureBox14.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox14.TabIndex = 54;
			this.pictureBox14.TabStop = false;
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label18.ForeColor = Color.FromArgb(0, 174, 219);
			this.label18.Location = new Point(23, 88);
			this.label18.Name = "label18";
			this.label18.Size = new Size(57, 17);
			this.label18.TabIndex = 53;
			this.label18.Text = "Support";
			this.pictureBox13.Image = Resources.Anonim;
			this.pictureBox13.Location = new Point(27, 117);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new Size(32, 32);
			this.pictureBox13.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox13.TabIndex = 54;
			this.pictureBox13.TabStop = false;
			this.panel3.BackColor = Color.FromArgb(0, 174, 219);
			this.panel3.Controls.Add(this.panel8);
			this.panel3.Location = new Point(496, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(184, 200);
			this.panel3.TabIndex = 59;
			this.panel8.BackColor = Color.FromArgb(32, 33, 38);
			this.panel8.Controls.Add(this.userControl81);
			this.panel8.Dock = DockStyle.Right;
			this.panel8.Location = new Point(9, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new Size(175, 200);
			this.panel8.TabIndex = 58;
			this.userControl81.BackColor = Color.FromArgb(32, 33, 38);
			this.userControl81.Location = new Point(0, 0);
			this.userControl81.Name = "userControl81";
			this.userControl81.Size = new Size(175, 200);
			this.userControl81.TabIndex = 0;
			this.label21.AutoSize = true;
			this.label21.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.label21.ForeColor = Color.FromArgb(73, 74, 78);
			this.label21.Location = new Point(46, 337);
			this.label21.Name = "label21";
			this.label21.Size = new Size(124, 17);
			this.label21.TabIndex = 61;
			this.label21.Text = "SIKAYRUM CHEATS";
			this.label22.AutoSize = true;
			this.label22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label22.ForeColor = Color.FromArgb(0, 174, 219);
			this.label22.Location = new Point(46, 322);
			this.label22.Name = "label22";
			this.label22.Size = new Size(74, 13);
			this.label22.TabIndex = 62;
			this.label22.Text = "Powered By";
			this.pictureBox4.Image = Resources.SLOGOSS2;
			this.pictureBox4.Location = new Point(246, 28);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(529, 443);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 63;
			this.pictureBox4.TabStop = false;
			this.pictureBox18.Image = Resources.Sky;
			this.pictureBox18.Location = new Point(10, 320);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new Size(32, 34);
			this.pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox18.TabIndex = 60;
			this.pictureBox18.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 41, 47);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel12);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.label22);
			base.Controls.Add(this.label21);
			base.Controls.Add(this.pictureBox18);
			base.Name = "UserControl4";
			base.Size = new Size(691, 366);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel7.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox5).EndInit();
			this.panel6.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox6).EndInit();
			this.panel4.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox7).EndInit();
			this.panel9.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox2).EndInit();
			this.panel5.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox8).EndInit();
			this.panel10.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox9).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox10).EndInit();
			this.panel11.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel12.ResumeLayout(false);
			this.panel14.ResumeLayout(false);
			this.panel14.PerformLayout();
			((ISupportInitialize)this.pictureBox11).EndInit();
			((ISupportInitialize)this.pictureBox14).EndInit();
			((ISupportInitialize)this.pictureBox13).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox18).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000186 RID: 390
		private IContainer components = null;

		// Token: 0x04000187 RID: 391
		private Panel panel1;

		// Token: 0x04000188 RID: 392
		private PictureBox pictureBox3;

		// Token: 0x04000189 RID: 393
		private PictureBox pictureBox2;

		// Token: 0x0400018A RID: 394
		private Label label1;

		// Token: 0x0400018B RID: 395
		private Label label2;

		// Token: 0x0400018C RID: 396
		private PictureBox pictureBox6;

		// Token: 0x0400018D RID: 397
		private PictureBox pictureBox7;

		// Token: 0x0400018E RID: 398
		private PictureBox pictureBox10;

		// Token: 0x0400018F RID: 399
		private Panel panel6;

		// Token: 0x04000190 RID: 400
		private Panel panel4;

		// Token: 0x04000191 RID: 401
		private Panel panel2;

		// Token: 0x04000192 RID: 402
		private Panel panel9;

		// Token: 0x04000193 RID: 403
		private Panel panel10;

		// Token: 0x04000194 RID: 404
		private Label label10;

		// Token: 0x04000195 RID: 405
		private Label label11;

		// Token: 0x04000196 RID: 406
		private Label label6;

		// Token: 0x04000197 RID: 407
		private Label label7;

		// Token: 0x04000198 RID: 408
		private Label label14;

		// Token: 0x04000199 RID: 409
		private Panel panel12;

		// Token: 0x0400019A RID: 410
		private Panel panel14;

		// Token: 0x0400019B RID: 411
		private Label label4;

		// Token: 0x0400019C RID: 412
		private PictureBox pictureBox11;

		// Token: 0x0400019D RID: 413
		private Label label15;

		// Token: 0x0400019E RID: 414
		private Label label18;

		// Token: 0x0400019F RID: 415
		private PictureBox pictureBox13;

		// Token: 0x040001A0 RID: 416
		private Panel panel11;

		// Token: 0x040001A1 RID: 417
		private Label label5;

		// Token: 0x040001A2 RID: 418
		private PictureBox pictureBox1;

		// Token: 0x040001A3 RID: 419
		private Panel panel7;

		// Token: 0x040001A4 RID: 420
		private Label label9;

		// Token: 0x040001A5 RID: 421
		private PictureBox pictureBox5;

		// Token: 0x040001A6 RID: 422
		private Panel panel5;

		// Token: 0x040001A7 RID: 423
		private Label label12;

		// Token: 0x040001A8 RID: 424
		private PictureBox pictureBox8;

		// Token: 0x040001A9 RID: 425
		private Panel panel3;

		// Token: 0x040001AA RID: 426
		private Label label16;

		// Token: 0x040001AB RID: 427
		private Label label17;

		// Token: 0x040001AC RID: 428
		private PictureBox pictureBox14;

		// Token: 0x040001AD RID: 429
		private PictureBox pictureBox18;

		// Token: 0x040001AE RID: 430
		private Label label21;

		// Token: 0x040001AF RID: 431
		private Label label22;

		// Token: 0x040001B0 RID: 432
		private UserControl8 userControl81;

		// Token: 0x040001B1 RID: 433
		private PictureBox pictureBox4;

		// Token: 0x040001B2 RID: 434
		private Panel panel8;

		// Token: 0x040001B3 RID: 435
		private PictureBox pictureBox9;
	}
}
