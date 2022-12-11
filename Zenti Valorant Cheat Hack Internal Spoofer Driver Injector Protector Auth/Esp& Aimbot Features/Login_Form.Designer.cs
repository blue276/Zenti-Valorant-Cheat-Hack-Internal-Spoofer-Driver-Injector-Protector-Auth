namespace SkyCheats
{
	// Token: 0x02000010 RID: 16
	public partial class Login_Form : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00003128 File Offset: 0x00001528
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003160 File Offset: 0x00001560
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SkyCheats.Login_Form));
			this.Button_Panel = new global::System.Windows.Forms.Panel();
			this.Top_Panel = new global::System.Windows.Forms.Panel();
			this.Label_Top_Panel = new global::System.Windows.Forms.Label();
			this.Button2_Top_Panel = new global::System.Windows.Forms.Button();
			this.Button_Top_Panel = new global::System.Windows.Forms.Button();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.lUserControl41 = new global::SkyCheats.LUserControls.LUserControl4();
			this.Button_Panel.SuspendLayout();
			this.Top_Panel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			base.SuspendLayout();
			this.Button_Panel.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 34);
			this.Button_Panel.Controls.Add(this.lUserControl41);
			this.Button_Panel.Location = new global::System.Drawing.Point(438, 25);
			this.Button_Panel.Name = "Button_Panel";
			this.Button_Panel.Size = new global::System.Drawing.Size(186, 515);
			this.Button_Panel.TabIndex = 1;
			this.Top_Panel.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 34);
			this.Top_Panel.Controls.Add(this.Label_Top_Panel);
			this.Top_Panel.Controls.Add(this.Button2_Top_Panel);
			this.Top_Panel.Controls.Add(this.Button_Top_Panel);
			this.Top_Panel.Location = new global::System.Drawing.Point(0, 0);
			this.Top_Panel.Name = "Top_Panel";
			this.Top_Panel.Size = new global::System.Drawing.Size(691, 25);
			this.Top_Panel.TabIndex = 7;
			this.Top_Panel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseDown);
			this.Top_Panel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseMove);
			this.Top_Panel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseUp);
			this.Label_Top_Panel.AutoSize = true;
			this.Label_Top_Panel.Font = new global::System.Drawing.Font("Segoe UI", 6.75f, global::System.Drawing.FontStyle.Bold);
			this.Label_Top_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Label_Top_Panel.Location = new global::System.Drawing.Point(4, 6);
			this.Label_Top_Panel.Name = "Label_Top_Panel";
			this.Label_Top_Panel.Size = new global::System.Drawing.Size(168, 12);
			this.Label_Top_Panel.TabIndex = 4;
			this.Label_Top_Panel.Text = "Blast Production Color Aim Bot [V2.0]";
			this.Label_Top_Panel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseDown);
			this.Label_Top_Panel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseMove);
			this.Label_Top_Panel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseUp);
			this.Button2_Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button2_Top_Panel.FlatAppearance.BorderSize = 0;
			this.Button2_Top_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2_Top_Panel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Button2_Top_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Button2_Top_Panel.Location = new global::System.Drawing.Point(641, 0);
			this.Button2_Top_Panel.Name = "Button2_Top_Panel";
			this.Button2_Top_Panel.Size = new global::System.Drawing.Size(25, 25);
			this.Button2_Top_Panel.TabIndex = 3;
			this.Button2_Top_Panel.Text = "_";
			this.Button2_Top_Panel.UseVisualStyleBackColor = true;
			this.Button2_Top_Panel.Click += new global::System.EventHandler(this.Button2_Top_Panel_Click);
			this.Button_Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button_Top_Panel.FlatAppearance.BorderSize = 0;
			this.Button_Top_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button_Top_Panel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Button_Top_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Button_Top_Panel.Location = new global::System.Drawing.Point(666, 0);
			this.Button_Top_Panel.Name = "Button_Top_Panel";
			this.Button_Top_Panel.Size = new global::System.Drawing.Size(25, 25);
			this.Button_Top_Panel.TabIndex = 2;
			this.Button_Top_Panel.Text = "X";
			this.Button_Top_Panel.UseVisualStyleBackColor = true;
			this.Button_Top_Panel.Click += new global::System.EventHandler(this.Button_Top_Panel_Click);
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(32, 33, 38);
			this.pictureBox2.Image = global::SkyCheats.Properties.Resources._31;
			this.pictureBox2.Location = new global::System.Drawing.Point(-2, 28);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(439, 439);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			this.pictureBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox4.Image = global::SkyCheats.Properties.Resources.panelsiz2;
			this.pictureBox4.Location = new global::System.Drawing.Point(-260, 25);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(700, 800);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 10;
			this.pictureBox4.TabStop = false;
			this.pictureBox3.BackColor = global::System.Drawing.Color.FromArgb(32, 33, 38);
			this.pictureBox3.Image = global::SkyCheats.Properties.Resources.panelsiz;
			this.pictureBox3.Location = new global::System.Drawing.Point(624, 25);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(700, 800);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			this.lUserControl41.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 34);
			this.lUserControl41.Location = new global::System.Drawing.Point(0, 5);
			this.lUserControl41.Name = "lUserControl41";
			this.lUserControl41.Size = new global::System.Drawing.Size(186, 510);
			this.lUserControl41.TabIndex = 9;
			this.lUserControl41.Load += new global::System.EventHandler(this.lUserControl41_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(39, 41, 47);
			base.ClientSize = new global::System.Drawing.Size(691, 455);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.Top_Panel);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.Button_Panel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login_Form";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Blast Cheats";
			base.Load += new global::System.EventHandler(this.Login_Form_Load);
			this.Button_Panel.ResumeLayout(false);
			this.Top_Panel.ResumeLayout(false);
			this.Top_Panel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400006A RID: 106
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Panel Button_Panel;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Panel Top_Panel;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Button Button2_Top_Panel;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Button Button_Top_Panel;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label Label_Top_Panel;

		// Token: 0x04000070 RID: 112
		private global::SkyCheats.LUserControls.LUserControl4 lUserControl41;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
