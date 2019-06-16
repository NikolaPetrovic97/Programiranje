/*
 * Created by SharpDevelop.
 * User: gpc2
 * Date: 30.10.2018
 * Time: 14:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PjPXO
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button b1;
		private System.Windows.Forms.Button b2;
		private System.Windows.Forms.Button b3;
		private System.Windows.Forms.Button b6;
		private System.Windows.Forms.Button b5;
		private System.Windows.Forms.Button b4;
		private System.Windows.Forms.Button b9;
		private System.Windows.Forms.Button b8;
		private System.Windows.Forms.Button b7;
		private System.Windows.Forms.Label nick1;
		private System.Windows.Forms.Label nick2;
		private System.Windows.Forms.TextBox xRezultat;
		private System.Windows.Forms.TextBox oRezultat;
		private System.Windows.Forms.Label label3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.b1 = new System.Windows.Forms.Button();
			this.b2 = new System.Windows.Forms.Button();
			this.b3 = new System.Windows.Forms.Button();
			this.b6 = new System.Windows.Forms.Button();
			this.b5 = new System.Windows.Forms.Button();
			this.b4 = new System.Windows.Forms.Button();
			this.b9 = new System.Windows.Forms.Button();
			this.b8 = new System.Windows.Forms.Button();
			this.b7 = new System.Windows.Forms.Button();
			this.nick1 = new System.Windows.Forms.Label();
			this.nick2 = new System.Windows.Forms.Label();
			this.xRezultat = new System.Windows.Forms.TextBox();
			this.oRezultat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// b1
			// 
			this.b1.Location = new System.Drawing.Point(13, 13);
			this.b1.Name = "b1";
			this.b1.Size = new System.Drawing.Size(75, 75);
			this.b1.TabIndex = 0;
			this.b1.UseVisualStyleBackColor = true;
			this.b1.Click += new System.EventHandler(this.Click);
			// 
			// b2
			// 
			this.b2.Location = new System.Drawing.Point(94, 12);
			this.b2.Name = "b2";
			this.b2.Size = new System.Drawing.Size(75, 75);
			this.b2.TabIndex = 1;
			this.b2.UseVisualStyleBackColor = true;
			this.b2.Click += new System.EventHandler(this.Click);
			// 
			// b3
			// 
			this.b3.Location = new System.Drawing.Point(175, 12);
			this.b3.Name = "b3";
			this.b3.Size = new System.Drawing.Size(75, 75);
			this.b3.TabIndex = 2;
			this.b3.UseVisualStyleBackColor = true;
			this.b3.Click += new System.EventHandler(this.Click);
			// 
			// b6
			// 
			this.b6.Location = new System.Drawing.Point(175, 93);
			this.b6.Name = "b6";
			this.b6.Size = new System.Drawing.Size(75, 75);
			this.b6.TabIndex = 5;
			this.b6.UseVisualStyleBackColor = true;
			this.b6.Click += new System.EventHandler(this.Click);
			// 
			// b5
			// 
			this.b5.Location = new System.Drawing.Point(94, 93);
			this.b5.Name = "b5";
			this.b5.Size = new System.Drawing.Size(75, 75);
			this.b5.TabIndex = 4;
			this.b5.UseVisualStyleBackColor = true;
			this.b5.Click += new System.EventHandler(this.Click);
			// 
			// b4
			// 
			this.b4.Location = new System.Drawing.Point(13, 94);
			this.b4.Name = "b4";
			this.b4.Size = new System.Drawing.Size(75, 75);
			this.b4.TabIndex = 3;
			this.b4.UseVisualStyleBackColor = true;
			this.b4.Click += new System.EventHandler(this.Click);
			// 
			// b9
			// 
			this.b9.Location = new System.Drawing.Point(175, 175);
			this.b9.Name = "b9";
			this.b9.Size = new System.Drawing.Size(75, 75);
			this.b9.TabIndex = 8;
			this.b9.UseVisualStyleBackColor = true;
			this.b9.Click += new System.EventHandler(this.Click);
			// 
			// b8
			// 
			this.b8.Location = new System.Drawing.Point(94, 175);
			this.b8.Name = "b8";
			this.b8.Size = new System.Drawing.Size(75, 75);
			this.b8.TabIndex = 7;
			this.b8.UseVisualStyleBackColor = true;
			this.b8.Click += new System.EventHandler(this.Click);
			// 
			// b7
			// 
			this.b7.Location = new System.Drawing.Point(13, 176);
			this.b7.Name = "b7";
			this.b7.Size = new System.Drawing.Size(75, 75);
			this.b7.TabIndex = 6;
			this.b7.UseVisualStyleBackColor = true;
			this.b7.Click += new System.EventHandler(this.Click);
			// 
			// nick1
			// 
			this.nick1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nick1.Location = new System.Drawing.Point(0, 272);
			this.nick1.Name = "nick1";
			this.nick1.Size = new System.Drawing.Size(88, 36);
			this.nick1.TabIndex = 9;
			this.nick1.Text = "X";
			// 
			// nick2
			// 
			this.nick2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nick2.Location = new System.Drawing.Point(186, 273);
			this.nick2.Name = "nick2";
			this.nick2.Size = new System.Drawing.Size(100, 36);
			this.nick2.TabIndex = 10;
			this.nick2.Text = "O";
			// 
			// xRezultat
			// 
			this.xRezultat.Enabled = false;
			this.xRezultat.Location = new System.Drawing.Point(78, 274);
			this.xRezultat.Name = "xRezultat";
			this.xRezultat.Size = new System.Drawing.Size(40, 20);
			this.xRezultat.TabIndex = 11;
			// 
			// oRezultat
			// 
			this.oRezultat.Enabled = false;
			this.oRezultat.Location = new System.Drawing.Point(146, 275);
			this.oRezultat.Name = "oRezultat";
			this.oRezultat.Size = new System.Drawing.Size(40, 20);
			this.oRezultat.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(120, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 36);
			this.label3.TabIndex = 13;
			this.label3.Text = ":";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 333);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.oRezultat);
			this.Controls.Add(this.xRezultat);
			this.Controls.Add(this.nick2);
			this.Controls.Add(this.nick1);
			this.Controls.Add(this.b9);
			this.Controls.Add(this.b8);
			this.Controls.Add(this.b7);
			this.Controls.Add(this.b6);
			this.Controls.Add(this.b5);
			this.Controls.Add(this.b4);
			this.Controls.Add(this.b3);
			this.Controls.Add(this.b2);
			this.Controls.Add(this.b1);
			this.Name = "MainForm";
			this.Text = "PjPXO";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
