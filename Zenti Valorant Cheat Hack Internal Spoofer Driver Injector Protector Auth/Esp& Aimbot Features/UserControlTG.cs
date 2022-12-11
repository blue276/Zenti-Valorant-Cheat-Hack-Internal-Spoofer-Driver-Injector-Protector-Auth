using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using SkyCheats.Properties;

namespace SkyCheats.UserControls
{
	// Token: 0x02000016 RID: 22
	public class UserControlTG : UserControl
	{
		// Token: 0x0600019E RID: 414 RVA: 0x0000DA7D File Offset: 0x0000BE7D
		public UserControlTG()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000DA98 File Offset: 0x0000BE98
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000DAD0 File Offset: 0x0000BED0
		private void InitializeComponent()
		{
			this.panel1 = new Panel();
			this.pictureBox4 = new PictureBox();
			this.label8 = new Label();
			this.metroComboBox2 = new MetroComboBox();
			this.label11 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this.metroCheckBox2 = new MetroCheckBox();
			this.metroCheckBox1 = new MetroCheckBox();
			this.panel2 = new Panel();
			this.label6 = new Label();
			this.label7 = new Label();
			this.metroTrackBar1 = new MetroTrackBar();
			this.pictureBox1 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.label20 = new Label();
			this.label19 = new Label();
			this.metroTrackBar10 = new MetroTrackBar();
			this.label13 = new Label();
			this.label14 = new Label();
			this.metroTrackBar7 = new MetroTrackBar();
			this.label12 = new Label();
			this.label21 = new Label();
			this.metroTrackBar6 = new MetroTrackBar();
			this.pictureBox2 = new PictureBox();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(32, 33, 38);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.metroComboBox2);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.metroCheckBox2);
			this.panel1.Controls.Add(this.metroCheckBox1);
			this.panel1.Location = new Point(10, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(350, 200);
			this.panel1.TabIndex = 4;
			this.pictureBox4.Image = Resources.Picture2_UserControl1;
			this.pictureBox4.Location = new Point(7, 57);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(336, 1);
			this.pictureBox4.TabIndex = 46;
			this.pictureBox4.TabStop = false;
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label8.ForeColor = Color.FromArgb(153, 153, 153);
			this.label8.Location = new Point(50, 69);
			this.label8.Name = "label8";
			this.label8.Size = new Size(86, 17);
			this.label8.TabIndex = 43;
			this.label8.Text = "Trigger Color";
			this.metroComboBox2.BackColor = Color.FromArgb(39, 41, 47);
			this.metroComboBox2.ForeColor = Color.FromArgb(153, 153, 153);
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.IntegralHeight = false;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Items.AddRange(new object[]
			{
				"Yellow",
				"Purple",
				"Red"
			});
			this.metroComboBox2.Location = new Point(250, 65);
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
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Segoe UI", 12f);
			this.label11.ForeColor = Color.FromArgb(102, 102, 102);
			this.label11.Location = new Point(246, 99);
			this.label11.Name = "label11";
			this.label11.Size = new Size(34, 21);
			this.label11.TabIndex = 11;
			this.label11.Text = "[ - ]";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.FromArgb(102, 102, 102);
			this.label5.Location = new Point(50, 101);
			this.label5.Name = "label5";
			this.label5.Size = new Size(77, 19);
			this.label5.TabIndex = 7;
			this.label5.Text = "Trigger Key";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Segoe UI", 12f);
			this.label4.ForeColor = Color.FromArgb(102, 102, 102);
			this.label4.Location = new Point(246, 30);
			this.label4.Name = "label4";
			this.label4.Size = new Size(34, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "[ - ]";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI", 12f);
			this.label3.ForeColor = Color.FromArgb(102, 102, 102);
			this.label3.Location = new Point(246, 8);
			this.label3.Name = "label3";
			this.label3.Size = new Size(34, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "[ - ]";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.ForeColor = Color.FromArgb(153, 153, 153);
			this.label2.Location = new Point(50, 32);
			this.label2.Name = "label2";
			this.label2.Size = new Size(108, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Trigger Force HS";
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(153, 153, 153);
			this.label1.Location = new Point(50, 10);
			this.label1.Name = "label1";
			this.label1.Size = new Size(75, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Trigger Bot";
			this.metroCheckBox2.AutoSize = true;
			this.metroCheckBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox2.Location = new Point(30, 36);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new Size(26, 15);
			this.metroCheckBox2.Style = 3;
			this.metroCheckBox2.TabIndex = 1;
			this.metroCheckBox2.Text = " ";
			this.metroCheckBox2.Theme = 2;
			this.metroCheckBox2.UseCustomBackColor = true;
			this.metroCheckBox2.UseSelectable = true;
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroCheckBox1.Location = new Point(30, 12);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new Size(26, 15);
			this.metroCheckBox1.Style = 3;
			this.metroCheckBox1.TabIndex = 0;
			this.metroCheckBox1.Text = " ";
			this.metroCheckBox1.Theme = 2;
			this.metroCheckBox1.UseCustomBackColor = true;
			this.metroCheckBox1.UseSelectable = true;
			this.panel2.BackColor = Color.FromArgb(32, 33, 38);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.metroTrackBar1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.label20);
			this.panel2.Controls.Add(this.label19);
			this.panel2.Controls.Add(this.metroTrackBar10);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.metroTrackBar7);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label21);
			this.panel2.Controls.Add(this.metroTrackBar6);
			this.panel2.Location = new Point(10, 220);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(350, 231);
			this.panel2.TabIndex = 12;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Segoe UI", 10f);
			this.label6.ForeColor = Color.FromArgb(102, 102, 102);
			this.label6.Location = new Point(303, 190);
			this.label6.Name = "label6";
			this.label6.Size = new Size(17, 19);
			this.label6.TabIndex = 36;
			this.label6.Text = "2";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label7.ForeColor = Color.FromArgb(153, 153, 153);
			this.label7.Location = new Point(15, 170);
			this.label7.Name = "label7";
			this.label7.Size = new Size(30, 17);
			this.label7.TabIndex = 34;
			this.label7.Text = "Fov";
			this.metroTrackBar1.BackColor = Color.Transparent;
			this.metroTrackBar1.Location = new Point(18, 190);
			this.metroTrackBar1.Name = "metroTrackBar1";
			this.metroTrackBar1.Size = new Size(270, 22);
			this.metroTrackBar1.Style = 3;
			this.metroTrackBar1.TabIndex = 35;
			this.metroTrackBar1.Text = "metroTrackBar1";
			this.metroTrackBar1.Theme = 2;
			this.metroTrackBar1.UseCustomBackColor = true;
			this.metroTrackBar1.Value = 100;
			this.pictureBox1.Image = Resources.Picture2_UserControl1;
			this.pictureBox1.Location = new Point(7, 157);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(336, 1);
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			this.pictureBox3.Image = Resources.Picture2_UserControl1;
			this.pictureBox3.Location = new Point(7, 70);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(336, 1);
			this.pictureBox3.TabIndex = 29;
			this.pictureBox3.TabStop = false;
			this.label20.AutoSize = true;
			this.label20.Font = new Font("Segoe UI", 10f);
			this.label20.ForeColor = Color.FromArgb(102, 102, 102);
			this.label20.Location = new Point(306, 29);
			this.label20.Name = "label20";
			this.label20.Size = new Size(17, 19);
			this.label20.TabIndex = 32;
			this.label20.Text = "2";
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label19.ForeColor = Color.FromArgb(153, 153, 153);
			this.label19.Location = new Point(18, 9);
			this.label19.Name = "label19";
			this.label19.Size = new Size(103, 17);
			this.label19.TabIndex = 30;
			this.label19.Text = "First Shot Delay";
			this.metroTrackBar10.BackColor = Color.Transparent;
			this.metroTrackBar10.Location = new Point(21, 29);
			this.metroTrackBar10.Name = "metroTrackBar10";
			this.metroTrackBar10.Size = new Size(270, 22);
			this.metroTrackBar10.Style = 3;
			this.metroTrackBar10.TabIndex = 31;
			this.metroTrackBar10.Text = "metroTrackBar10";
			this.metroTrackBar10.Theme = 2;
			this.metroTrackBar10.UseCustomBackColor = true;
			this.metroTrackBar10.Value = 100;
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Segoe UI", 10f);
			this.label13.ForeColor = Color.FromArgb(102, 102, 102);
			this.label13.Location = new Point(314, 91);
			this.label13.Name = "label13";
			this.label13.Size = new Size(23, 19);
			this.label13.TabIndex = 13;
			this.label13.Text = "-1";
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label14.ForeColor = Color.FromArgb(153, 153, 153);
			this.label14.Location = new Point(188, 91);
			this.label14.Name = "label14";
			this.label14.Size = new Size(78, 17);
			this.label14.TabIndex = 11;
			this.label14.Text = "Spray Sleep";
			this.metroTrackBar7.BackColor = Color.Transparent;
			this.metroTrackBar7.Location = new Point(188, 113);
			this.metroTrackBar7.Maximum = 50;
			this.metroTrackBar7.Name = "metroTrackBar7";
			this.metroTrackBar7.Size = new Size(152, 22);
			this.metroTrackBar7.Style = 3;
			this.metroTrackBar7.TabIndex = 12;
			this.metroTrackBar7.Text = "metroTrackBar7";
			this.metroTrackBar7.Theme = 2;
			this.metroTrackBar7.UseCustomBackColor = true;
			this.metroTrackBar7.Value = 24;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Segoe UI", 10f);
			this.label12.ForeColor = Color.FromArgb(102, 102, 102);
			this.label12.Location = new Point(144, 91);
			this.label12.Name = "label12";
			this.label12.Size = new Size(23, 19);
			this.label12.TabIndex = 2;
			this.label12.Text = "-1";
			this.label21.AutoSize = true;
			this.label21.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label21.ForeColor = Color.FromArgb(153, 153, 153);
			this.label21.Location = new Point(18, 91);
			this.label21.Name = "label21";
			this.label21.Size = new Size(71, 17);
			this.label21.TabIndex = 0;
			this.label21.Text = "Fire Speed";
			this.metroTrackBar6.BackColor = Color.Transparent;
			this.metroTrackBar6.Location = new Point(18, 113);
			this.metroTrackBar6.Maximum = 50;
			this.metroTrackBar6.Name = "metroTrackBar6";
			this.metroTrackBar6.Size = new Size(152, 22);
			this.metroTrackBar6.Style = 3;
			this.metroTrackBar6.TabIndex = 1;
			this.metroTrackBar6.Text = "metroTrackBar6";
			this.metroTrackBar6.Theme = 2;
			this.metroTrackBar6.UseCustomBackColor = true;
			this.metroTrackBar6.Value = 24;
			this.pictureBox2.Dock = DockStyle.Fill;
			this.pictureBox2.Image = Resources.Picture_UserControl;
			this.pictureBox2.Location = new Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(370, 515);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 41, 47);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox2);
			base.Name = "UserControlTG";
			base.Size = new Size(370, 515);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox4).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000FB RID: 251
		private IContainer components = null;

		// Token: 0x040000FC RID: 252
		private Panel panel1;

		// Token: 0x040000FD RID: 253
		private PictureBox pictureBox4;

		// Token: 0x040000FE RID: 254
		private Label label8;

		// Token: 0x040000FF RID: 255
		private MetroComboBox metroComboBox2;

		// Token: 0x04000100 RID: 256
		private Label label11;

		// Token: 0x04000101 RID: 257
		private Label label5;

		// Token: 0x04000102 RID: 258
		private Label label3;

		// Token: 0x04000103 RID: 259
		private Label label1;

		// Token: 0x04000104 RID: 260
		private MetroCheckBox metroCheckBox1;

		// Token: 0x04000105 RID: 261
		private Label label4;

		// Token: 0x04000106 RID: 262
		private Label label2;

		// Token: 0x04000107 RID: 263
		private MetroCheckBox metroCheckBox2;

		// Token: 0x04000108 RID: 264
		private Panel panel2;

		// Token: 0x04000109 RID: 265
		private PictureBox pictureBox3;

		// Token: 0x0400010A RID: 266
		private Label label20;

		// Token: 0x0400010B RID: 267
		private Label label19;

		// Token: 0x0400010C RID: 268
		private MetroTrackBar metroTrackBar10;

		// Token: 0x0400010D RID: 269
		private Label label13;

		// Token: 0x0400010E RID: 270
		private Label label14;

		// Token: 0x0400010F RID: 271
		private MetroTrackBar metroTrackBar7;

		// Token: 0x04000110 RID: 272
		private Label label12;

		// Token: 0x04000111 RID: 273
		private Label label21;

		// Token: 0x04000112 RID: 274
		private MetroTrackBar metroTrackBar6;

		// Token: 0x04000113 RID: 275
		private Label label6;

		// Token: 0x04000114 RID: 276
		private Label label7;

		// Token: 0x04000115 RID: 277
		private MetroTrackBar metroTrackBar1;

		// Token: 0x04000116 RID: 278
		private PictureBox pictureBox1;

		// Token: 0x04000117 RID: 279
		private PictureBox pictureBox2;
	}
}
