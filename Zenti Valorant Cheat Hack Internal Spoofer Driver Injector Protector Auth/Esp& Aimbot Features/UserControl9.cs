using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SkyCheats.Properties;

namespace SkyCheats.UserControls
{
	// Token: 0x0200001E RID: 30
	public class UserControl9 : UserControl
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0001B786 File Offset: 0x00019B86
		public UserControl9()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000D008 File Offset: 0x0000B408
		private void button11_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001B7A0 File Offset: 0x00019BA0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001B7D8 File Offset: 0x00019BD8
		private void InitializeComponent()
		{
			this.label3 = new Label();
			this.label5 = new Label();
			this.panel1 = new Panel();
			this.button13 = new Button();
			this.button11 = new Button();
			this.button12 = new Button();
			this.button9 = new Button();
			this.button8 = new Button();
			this.button7 = new Button();
			this.button5 = new Button();
			this.button6 = new Button();
			this.button4 = new Button();
			this.button3 = new Button();
			this.button2 = new Button();
			this.button1 = new Button();
			this.panel4 = new Panel();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(10, 12);
			this.label3.Name = "label3";
			this.label3.Size = new Size(71, 26);
			this.label3.TabIndex = 12;
			this.label3.Text = "Language";
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.FromArgb(102, 102, 102);
			this.label5.Location = new Point(9, 37);
			this.label5.Name = "label5";
			this.label5.Size = new Size(338, 26);
			this.label5.TabIndex = 82;
			this.label5.Text = "* Select a language.";
			this.panel1.Controls.Add(this.button13);
			this.panel1.Controls.Add(this.button11);
			this.panel1.Controls.Add(this.button12);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Location = new Point(10, 66);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(330, 104);
			this.panel1.TabIndex = 83;
			this.button13.Enabled = false;
			this.button13.FlatAppearance.BorderSize = 0;
			this.button13.FlatStyle = FlatStyle.Flat;
			this.button13.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button13.ForeColor = Color.FromArgb(102, 102, 102);
			this.button13.Image = Resources.İsveççe;
			this.button13.ImageAlign = ContentAlignment.TopCenter;
			this.button13.Location = new Point(221, 55);
			this.button13.Name = "button13";
			this.button13.Size = new Size(47, 47);
			this.button13.TabIndex = 96;
			this.button13.Text = "SE";
			this.button13.TextAlign = ContentAlignment.BottomCenter;
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += this.button11_Click;
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button11.ForeColor = Color.FromArgb(102, 102, 102);
			this.button11.Image = Resources.İngilizce;
			this.button11.ImageAlign = ContentAlignment.TopCenter;
			this.button11.Location = new Point(9, 2);
			this.button11.Name = "button11";
			this.button11.Size = new Size(47, 47);
			this.button11.TabIndex = 95;
			this.button11.Text = "ENG";
			this.button11.TextAlign = ContentAlignment.BottomCenter;
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += this.button11_Click;
			this.button12.Enabled = false;
			this.button12.FlatAppearance.BorderSize = 0;
			this.button12.FlatStyle = FlatStyle.Flat;
			this.button12.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button12.ForeColor = Color.FromArgb(102, 102, 102);
			this.button12.Image = Resources.Türkçe1;
			this.button12.ImageAlign = ContentAlignment.TopCenter;
			this.button12.Location = new Point(274, 55);
			this.button12.Name = "button12";
			this.button12.Size = new Size(47, 47);
			this.button12.TabIndex = 94;
			this.button12.Text = "TR";
			this.button12.TextAlign = ContentAlignment.BottomCenter;
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += this.button11_Click;
			this.button9.Enabled = false;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button9.ForeColor = Color.FromArgb(102, 102, 102);
			this.button9.Image = Resources.Portekizce;
			this.button9.ImageAlign = ContentAlignment.TopCenter;
			this.button9.Location = new Point(115, 55);
			this.button9.Name = "button9";
			this.button9.Size = new Size(47, 47);
			this.button9.TabIndex = 93;
			this.button9.Text = "BR";
			this.button9.TextAlign = ContentAlignment.BottomCenter;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += this.button11_Click;
			this.button8.Enabled = false;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button8.ForeColor = Color.FromArgb(102, 102, 102);
			this.button8.Image = Resources.Japonca;
			this.button8.ImageAlign = ContentAlignment.TopCenter;
			this.button8.Location = new Point(9, 55);
			this.button8.Name = "button8";
			this.button8.Size = new Size(47, 47);
			this.button8.TabIndex = 91;
			this.button8.Text = "JP";
			this.button8.TextAlign = ContentAlignment.BottomCenter;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += this.button11_Click;
			this.button7.Enabled = false;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button7.ForeColor = Color.FromArgb(102, 102, 102);
			this.button7.Image = Resources.Lehçe;
			this.button7.ImageAlign = ContentAlignment.TopCenter;
			this.button7.Location = new Point(62, 55);
			this.button7.Name = "button7";
			this.button7.Size = new Size(47, 47);
			this.button7.TabIndex = 90;
			this.button7.Text = "PL";
			this.button7.TextAlign = ContentAlignment.BottomCenter;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += this.button11_Click;
			this.button5.Enabled = false;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button5.ForeColor = Color.FromArgb(102, 102, 102);
			this.button5.Image = Resources.İtalya;
			this.button5.ImageAlign = ContentAlignment.TopCenter;
			this.button5.Location = new Point(274, 2);
			this.button5.Name = "button5";
			this.button5.Size = new Size(47, 47);
			this.button5.TabIndex = 89;
			this.button5.Text = "IT";
			this.button5.TextAlign = ContentAlignment.BottomCenter;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += this.button11_Click;
			this.button6.Enabled = false;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button6.ForeColor = Color.FromArgb(102, 102, 102);
			this.button6.Image = Resources.Fransızca;
			this.button6.ImageAlign = ContentAlignment.TopCenter;
			this.button6.Location = new Point(221, 2);
			this.button6.Name = "button6";
			this.button6.Size = new Size(47, 47);
			this.button6.TabIndex = 88;
			this.button6.Text = "FR";
			this.button6.TextAlign = ContentAlignment.BottomCenter;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += this.button11_Click;
			this.button4.Enabled = false;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button4.ForeColor = Color.FromArgb(102, 102, 102);
			this.button4.Image = Resources.İspanyolca;
			this.button4.ImageAlign = ContentAlignment.TopCenter;
			this.button4.Location = new Point(168, 2);
			this.button4.Name = "button4";
			this.button4.Size = new Size(47, 47);
			this.button4.TabIndex = 87;
			this.button4.Text = "ES";
			this.button4.TextAlign = ContentAlignment.BottomCenter;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += this.button11_Click;
			this.button3.Enabled = false;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button3.ForeColor = Color.FromArgb(102, 102, 102);
			this.button3.Image = Resources.Yunanca;
			this.button3.ImageAlign = ContentAlignment.TopCenter;
			this.button3.Location = new Point(115, 2);
			this.button3.Name = "button3";
			this.button3.Size = new Size(47, 47);
			this.button3.TabIndex = 86;
			this.button3.Text = "GR";
			this.button3.TextAlign = ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += this.button11_Click;
			this.button2.Enabled = false;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button2.ForeColor = Color.FromArgb(102, 102, 102);
			this.button2.Image = Resources.Almanca1;
			this.button2.ImageAlign = ContentAlignment.TopCenter;
			this.button2.Location = new Point(62, 2);
			this.button2.Name = "button2";
			this.button2.Size = new Size(47, 47);
			this.button2.TabIndex = 85;
			this.button2.Text = "DE";
			this.button2.TextAlign = ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += this.button11_Click;
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button1.ForeColor = Color.FromArgb(102, 102, 102);
			this.button1.Image = Resources.Rusça;
			this.button1.ImageAlign = ContentAlignment.TopCenter;
			this.button1.Location = new Point(168, 55);
			this.button1.Name = "button1";
			this.button1.Size = new Size(47, 47);
			this.button1.TabIndex = 84;
			this.button1.Text = "RU";
			this.button1.TextAlign = ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button11_Click;
			this.panel4.Location = new Point(115, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(0, 0);
			this.panel4.TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(32, 33, 38);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label3);
			base.Name = "UserControl9";
			base.Size = new Size(350, 170);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040001EE RID: 494
		private IContainer components = null;

		// Token: 0x040001EF RID: 495
		private Label label3;

		// Token: 0x040001F0 RID: 496
		private Label label5;

		// Token: 0x040001F1 RID: 497
		private Panel panel1;

		// Token: 0x040001F2 RID: 498
		private Button button1;

		// Token: 0x040001F3 RID: 499
		private Panel panel4;

		// Token: 0x040001F4 RID: 500
		private Button button11;

		// Token: 0x040001F5 RID: 501
		private Button button12;

		// Token: 0x040001F6 RID: 502
		private Button button9;

		// Token: 0x040001F7 RID: 503
		private Button button8;

		// Token: 0x040001F8 RID: 504
		private Button button7;

		// Token: 0x040001F9 RID: 505
		private Button button5;

		// Token: 0x040001FA RID: 506
		private Button button6;

		// Token: 0x040001FB RID: 507
		private Button button4;

		// Token: 0x040001FC RID: 508
		private Button button3;

		// Token: 0x040001FD RID: 509
		private Button button2;

		// Token: 0x040001FE RID: 510
		private Button button13;
	}
}
