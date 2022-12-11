using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SkyCheats.UserControls
{
	// Token: 0x0200001D RID: 29
	public class UserControl8 : UserControl
	{
		// Token: 0x060001FF RID: 511 RVA: 0x0001B08F File Offset: 0x0001948F
		public UserControl8()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000030D9 File Offset: 0x000014D9
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000030D9 File Offset: 0x000014D9
		private void UserControl8_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000030D9 File Offset: 0x000014D9
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000030D9 File Offset: 0x000014D9
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000030D9 File Offset: 0x000014D9
		private void userControl101_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000030D9 File Offset: 0x000014D9
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0001B0A8 File Offset: 0x000194A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0001B0E0 File Offset: 0x000194E0
		private void InitializeComponent()
		{
			this.label6 = new Label();
			this.button2 = new Button();
			this.label5 = new Label();
			this.button1 = new Button();
			this.button4 = new Button();
			this.label3 = new Label();
			this.panel2 = new Panel();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.label6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label6.ForeColor = Color.FromArgb(0, 174, 219);
			this.label6.Location = new Point(10, 72);
			this.label6.Name = "label6";
			this.label6.Size = new Size(69, 26);
			this.label6.TabIndex = 14;
			this.label6.Text = "Nickname";
			this.button2.BackColor = Color.FromArgb(39, 41, 47);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Segoe UI", 10f);
			this.button2.ForeColor = Color.FromArgb(153, 153, 153);
			this.button2.Location = new Point(13, 37);
			this.button2.Name = "button2";
			this.button2.Size = new Size(150, 26);
			this.button2.TabIndex = 38;
			this.button2.Text = "English";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.label5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label5.ForeColor = Color.FromArgb(0, 174, 219);
			this.label5.Location = new Point(10, 129);
			this.label5.Name = "label5";
			this.label5.Size = new Size(102, 26);
			this.label5.TabIndex = 13;
			this.label5.Text = "Expiration Date";
			this.button1.BackColor = Color.FromArgb(39, 41, 47);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 10f);
			this.button1.ForeColor = Color.FromArgb(153, 153, 153);
			this.button1.Location = new Point(13, 95);
			this.button1.Name = "button1";
			this.button1.Size = new Size(150, 26);
			this.button1.TabIndex = 39;
			this.button1.Text = config.usernamee;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.button4.BackColor = Color.FromArgb(39, 41, 47);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Segoe UI", 10f);
			this.button4.ForeColor = Color.FromArgb(153, 153, 153);
			this.button4.Location = new Point(13, 154);
			this.button4.Name = "button4";
			this.button4.Size = new Size(150, 26);
			this.button4.TabIndex = 41;
			this.button4.Text = config.expirylefttime;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label3.ForeColor = Color.FromArgb(0, 174, 219);
			this.label3.Location = new Point(10, 12);
			this.label3.Name = "label3";
			this.label3.Size = new Size(71, 26);
			this.label3.TabIndex = 11;
			this.label3.Text = "Language";
			this.panel2.BackColor = Color.FromArgb(32, 33, 38);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(175, 200);
			this.panel2.TabIndex = 2;
			this.panel2.Paint += this.panel2_Paint;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(32, 33, 38);
			base.Controls.Add(this.panel2);
			base.Name = "UserControl8";
			base.Size = new Size(175, 200);
			base.Load += this.UserControl8_Load;
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040001E6 RID: 486
		private IContainer components = null;

		// Token: 0x040001E7 RID: 487
		private Label label6;

		// Token: 0x040001E8 RID: 488
		private Button button2;

		// Token: 0x040001E9 RID: 489
		private Label label5;

		// Token: 0x040001EA RID: 490
		private Button button1;

		// Token: 0x040001EB RID: 491
		private Button button4;

		// Token: 0x040001EC RID: 492
		private Label label3;

		// Token: 0x040001ED RID: 493
		private Panel panel2;
	}
}
