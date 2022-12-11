namespace SkyCheats
{
	// Token: 0x02000013 RID: 19
	public partial class TG_Main_Form : global::System.Windows.Forms.Form
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00006CFC File Offset: 0x000050FC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00006D34 File Offset: 0x00005134
		private void InitializeComponent()
		{
			this.Button_Panel = new global::System.Windows.Forms.Panel();
			this.Button5_Button_Panel = new global::System.Windows.Forms.Button();
			this.Button4_Button_Panel = new global::System.Windows.Forms.Button();
			this.Button_Button_Panel = new global::System.Windows.Forms.Button();
			this.Picture_Button_Panel = new global::System.Windows.Forms.PictureBox();
			this.User_Panel = new global::System.Windows.Forms.Panel();
			this.Label2_Top_Panel = new global::System.Windows.Forms.Label();
			this.Label_User_Panel = new global::System.Windows.Forms.Label();
			this.Icon_User_Panel = new global::System.Windows.Forms.PictureBox();
			this.Top_Panel = new global::System.Windows.Forms.Panel();
			this.Picture_Top_Panel = new global::System.Windows.Forms.PictureBox();
			this.Icon2_Top_Panel = new global::System.Windows.Forms.PictureBox();
			this.Button2_Top_Panel = new global::System.Windows.Forms.Button();
			this.Button_Top_Panel = new global::System.Windows.Forms.Button();
			this.Icon_Top_Panel = new global::System.Windows.Forms.PictureBox();
			this.Label_Top_Panel = new global::System.Windows.Forms.Label();
			this.userControlTG1 = new global::SkyCheats.UserControls.UserControlTG();
			this.userControl41 = new global::SkyCheats.UserControls.UserControl4();
			this.userControl51 = new global::SkyCheats.UserControls.UserControl5();
			this.Button_Panel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Picture_Button_Panel).BeginInit();
			this.User_Panel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Icon_User_Panel).BeginInit();
			this.Top_Panel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Picture_Top_Panel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Icon2_Top_Panel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Icon_Top_Panel).BeginInit();
			base.SuspendLayout();
			this.Button_Panel.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 34);
			this.Button_Panel.Controls.Add(this.Button5_Button_Panel);
			this.Button_Panel.Controls.Add(this.Button4_Button_Panel);
			this.Button_Panel.Controls.Add(this.Button_Button_Panel);
			this.Button_Panel.Controls.Add(this.Picture_Button_Panel);
			this.Button_Panel.Controls.Add(this.User_Panel);
			this.Button_Panel.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Button_Panel.Location = new global::System.Drawing.Point(0, 0);
			this.Button_Panel.Name = "Button_Panel";
			this.Button_Panel.Size = new global::System.Drawing.Size(186, 540);
			this.Button_Panel.TabIndex = 1;
			this.Button5_Button_Panel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Button5_Button_Panel.FlatAppearance.BorderSize = 0;
			this.Button5_Button_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button5_Button_Panel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Button5_Button_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Button5_Button_Panel.Image = global::SkyCheats.Properties.Resources.Button5_Button_Panel;
			this.Button5_Button_Panel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Button5_Button_Panel.Location = new global::System.Drawing.Point(0, 490);
			this.Button5_Button_Panel.Name = "Button5_Button_Panel";
			this.Button5_Button_Panel.Size = new global::System.Drawing.Size(186, 50);
			this.Button5_Button_Panel.TabIndex = 6;
			this.Button5_Button_Panel.Text = "SETTINGS";
			this.Button5_Button_Panel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Button5_Button_Panel.UseVisualStyleBackColor = true;
			this.Button5_Button_Panel.Click += new global::System.EventHandler(this.Button5_Button_Panel_Click);
			this.Button4_Button_Panel.FlatAppearance.BorderSize = 0;
			this.Button4_Button_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button4_Button_Panel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Button4_Button_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Button4_Button_Panel.Image = global::SkyCheats.Properties.Resources.Button4_Button_Panel;
			this.Button4_Button_Panel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Button4_Button_Panel.Location = new global::System.Drawing.Point(0, 440);
			this.Button4_Button_Panel.Name = "Button4_Button_Panel";
			this.Button4_Button_Panel.Size = new global::System.Drawing.Size(186, 50);
			this.Button4_Button_Panel.TabIndex = 5;
			this.Button4_Button_Panel.Text = " INFO";
			this.Button4_Button_Panel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Button4_Button_Panel.UseVisualStyleBackColor = true;
			this.Button4_Button_Panel.Click += new global::System.EventHandler(this.Button4_Button_Panel_Click);
			this.Button_Button_Panel.FlatAppearance.BorderSize = 0;
			this.Button_Button_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button_Button_Panel.Font = new global::System.Drawing.Font("Nirmala UI", 12f, global::System.Drawing.FontStyle.Bold);
			this.Button_Button_Panel.ForeColor = global::System.Drawing.Color.FromArgb(80, 250, 241);
			this.Button_Button_Panel.Image = global::SkyCheats.Properties.Resources.Button_Button_Panel;
			this.Button_Button_Panel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Button_Button_Panel.Location = new global::System.Drawing.Point(0, 140);
			this.Button_Button_Panel.Name = "Button_Button_Panel";
			this.Button_Button_Panel.Size = new global::System.Drawing.Size(186, 61);
			this.Button_Button_Panel.TabIndex = 2;
			this.Button_Button_Panel.Text = "Trigger Bot          ";
			this.Button_Button_Panel.UseVisualStyleBackColor = true;
			this.Button_Button_Panel.Click += new global::System.EventHandler(this.Button_Button_Panel_Click);
			this.Picture_Button_Panel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Picture_Button_Panel.Image = global::SkyCheats.Properties.Resources.Picture_Button_Panel;
			this.Picture_Button_Panel.Location = new global::System.Drawing.Point(0, 134);
			this.Picture_Button_Panel.Name = "Picture_Button_Panel";
			this.Picture_Button_Panel.Size = new global::System.Drawing.Size(186, 5);
			this.Picture_Button_Panel.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Picture_Button_Panel.TabIndex = 2;
			this.Picture_Button_Panel.TabStop = false;
			this.User_Panel.Controls.Add(this.Label2_Top_Panel);
			this.User_Panel.Controls.Add(this.Label_User_Panel);
			this.User_Panel.Controls.Add(this.Icon_User_Panel);
			this.User_Panel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.User_Panel.Location = new global::System.Drawing.Point(0, 0);
			this.User_Panel.Name = "User_Panel";
			this.User_Panel.Size = new global::System.Drawing.Size(186, 134);
			this.User_Panel.TabIndex = 2;
			this.Label2_Top_Panel.Font = new global::System.Drawing.Font("Segoe UI", 6.75f, global::System.Drawing.FontStyle.Bold);
			this.Label2_Top_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Label2_Top_Panel.Location = new global::System.Drawing.Point(0, 112);
			this.Label2_Top_Panel.Name = "Label2_Top_Panel";
			this.Label2_Top_Panel.Size = new global::System.Drawing.Size(186, 12);
			this.Label2_Top_Panel.TabIndex = 2;
			this.Label2_Top_Panel.Text = "Expiration Date";
			this.Label2_Top_Panel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Label_User_Panel.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.Label_User_Panel.ForeColor = global::System.Drawing.Color.FromArgb(80, 250, 241);
			this.Label_User_Panel.Location = new global::System.Drawing.Point(0, 91);
			this.Label_User_Panel.Name = "Label_User_Panel";
			this.Label_User_Panel.Size = new global::System.Drawing.Size(186, 17);
			this.Label_User_Panel.TabIndex = 2;
			this.Label_User_Panel.Text = "Nickname";
			this.Label_User_Panel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Icon_User_Panel.Image = global::SkyCheats.Properties.Resources.Icon_User_Panel;
			this.Icon_User_Panel.Location = new global::System.Drawing.Point(52, 8);
			this.Icon_User_Panel.Name = "Icon_User_Panel";
			this.Icon_User_Panel.Size = new global::System.Drawing.Size(80, 80);
			this.Icon_User_Panel.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Icon_User_Panel.TabIndex = 2;
			this.Icon_User_Panel.TabStop = false;
			this.Top_Panel.BackColor = global::System.Drawing.Color.FromArgb(28, 29, 34);
			this.Top_Panel.Controls.Add(this.Picture_Top_Panel);
			this.Top_Panel.Controls.Add(this.Icon2_Top_Panel);
			this.Top_Panel.Controls.Add(this.Button2_Top_Panel);
			this.Top_Panel.Controls.Add(this.Button_Top_Panel);
			this.Top_Panel.Controls.Add(this.Icon_Top_Panel);
			this.Top_Panel.Controls.Add(this.Label_Top_Panel);
			this.Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Top_Panel.Location = new global::System.Drawing.Point(186, 0);
			this.Top_Panel.Name = "Top_Panel";
			this.Top_Panel.Size = new global::System.Drawing.Size(370, 25);
			this.Top_Panel.TabIndex = 2;
			this.Top_Panel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseDown);
			this.Top_Panel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseMove);
			this.Top_Panel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseUp);
			this.Picture_Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Picture_Top_Panel.Image = global::SkyCheats.Properties.Resources.Picture_Top_Panel;
			this.Picture_Top_Panel.Location = new global::System.Drawing.Point(0, 0);
			this.Picture_Top_Panel.Name = "Picture_Top_Panel";
			this.Picture_Top_Panel.Size = new global::System.Drawing.Size(5, 25);
			this.Picture_Top_Panel.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Picture_Top_Panel.TabIndex = 2;
			this.Picture_Top_Panel.TabStop = false;
			this.Icon2_Top_Panel.Image = global::SkyCheats.Properties.Resources.icon;
			this.Icon2_Top_Panel.Location = new global::System.Drawing.Point(6, 0);
			this.Icon2_Top_Panel.Name = "Icon2_Top_Panel";
			this.Icon2_Top_Panel.Size = new global::System.Drawing.Size(25, 25);
			this.Icon2_Top_Panel.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Icon2_Top_Panel.TabIndex = 2;
			this.Icon2_Top_Panel.TabStop = false;
			this.Icon2_Top_Panel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseDown);
			this.Icon2_Top_Panel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseMove);
			this.Icon2_Top_Panel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseUp);
			this.Button2_Top_Panel.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button2_Top_Panel.FlatAppearance.BorderSize = 0;
			this.Button2_Top_Panel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2_Top_Panel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Button2_Top_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Button2_Top_Panel.Location = new global::System.Drawing.Point(320, 0);
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
			this.Button_Top_Panel.Location = new global::System.Drawing.Point(345, 0);
			this.Button_Top_Panel.Name = "Button_Top_Panel";
			this.Button_Top_Panel.Size = new global::System.Drawing.Size(25, 25);
			this.Button_Top_Panel.TabIndex = 2;
			this.Button_Top_Panel.Text = "X";
			this.Button_Top_Panel.UseVisualStyleBackColor = true;
			this.Button_Top_Panel.Click += new global::System.EventHandler(this.Button_Top_Panel_Click);
			this.Icon_Top_Panel.Image = global::SkyCheats.Properties.Resources.Icon_Top_Panel;
			this.Icon_Top_Panel.Location = new global::System.Drawing.Point(33, 7);
			this.Icon_Top_Panel.Name = "Icon_Top_Panel";
			this.Icon_Top_Panel.Size = new global::System.Drawing.Size(72, 12);
			this.Icon_Top_Panel.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Icon_Top_Panel.TabIndex = 0;
			this.Icon_Top_Panel.TabStop = false;
			this.Icon_Top_Panel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseDown);
			this.Icon_Top_Panel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseMove);
			this.Icon_Top_Panel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseUp);
			this.Label_Top_Panel.AutoSize = true;
			this.Label_Top_Panel.Font = new global::System.Drawing.Font("Segoe UI", 6.75f, global::System.Drawing.FontStyle.Bold);
			this.Label_Top_Panel.ForeColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.Label_Top_Panel.Location = new global::System.Drawing.Point(104, 7);
			this.Label_Top_Panel.Name = "Label_Top_Panel";
			this.Label_Top_Panel.Size = new global::System.Drawing.Size(40, 12);
			this.Label_Top_Panel.TabIndex = 2;
			this.Label_Top_Panel.Text = "BETA 1.6";
			this.Label_Top_Panel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseDown);
			this.Label_Top_Panel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseMove);
			this.Label_Top_Panel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseUp);
			this.userControlTG1.BackColor = global::System.Drawing.Color.FromArgb(39, 41, 47);
			this.userControlTG1.Location = new global::System.Drawing.Point(186, 25);
			this.userControlTG1.Name = "userControlTG1";
			this.userControlTG1.Size = new global::System.Drawing.Size(370, 515);
			this.userControlTG1.TabIndex = 3;
			this.userControl41.BackColor = global::System.Drawing.Color.FromArgb(39, 41, 47);
			this.userControl41.Location = new global::System.Drawing.Point(186, 25);
			this.userControl41.Name = "userControl41";
			this.userControl41.Size = new global::System.Drawing.Size(370, 515);
			this.userControl41.TabIndex = 4;
			this.userControl51.BackColor = global::System.Drawing.Color.FromArgb(39, 41, 47);
			this.userControl51.Location = new global::System.Drawing.Point(186, 25);
			this.userControl51.Name = "userControl51";
			this.userControl51.Size = new global::System.Drawing.Size(370, 515);
			this.userControl51.TabIndex = 5;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(39, 41, 47);
			base.ClientSize = new global::System.Drawing.Size(556, 540);
			base.Controls.Add(this.userControl51);
			base.Controls.Add(this.userControl41);
			base.Controls.Add(this.userControlTG1);
			base.Controls.Add(this.Top_Panel);
			base.Controls.Add(this.Button_Panel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "TG_Main_Form";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TG_Main_Form";
			base.Load += new global::System.EventHandler(this.TG_Main_Form_Load);
			this.Button_Panel.ResumeLayout(false);
			this.Button_Panel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Picture_Button_Panel).EndInit();
			this.User_Panel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.Icon_User_Panel).EndInit();
			this.Top_Panel.ResumeLayout(false);
			this.Top_Panel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Picture_Top_Panel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Icon2_Top_Panel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Icon_Top_Panel).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000A0 RID: 160
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Panel Button_Panel;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Button Button5_Button_Panel;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Button Button4_Button_Panel;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.Button Button_Button_Panel;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.PictureBox Picture_Button_Panel;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Panel User_Panel;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Label Label2_Top_Panel;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Label Label_User_Panel;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.PictureBox Icon_User_Panel;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Panel Top_Panel;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.PictureBox Picture_Top_Panel;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.PictureBox Icon2_Top_Panel;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.Button Button2_Top_Panel;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Button Button_Top_Panel;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.PictureBox Icon_Top_Panel;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Label Label_Top_Panel;

		// Token: 0x040000B1 RID: 177
		private global::SkyCheats.UserControls.UserControlTG userControlTG1;

		// Token: 0x040000B2 RID: 178
		private global::SkyCheats.UserControls.UserControl4 userControl41;

		// Token: 0x040000B3 RID: 179
		private global::SkyCheats.UserControls.UserControl5 userControl51;
	}
}
