/*
 * Created by SharpDevelop.
 * User: Fujitsu E752
 * Date: 11/7/2017
 * Time: 12:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prodavnica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Yellow;
			this.button1.Location = new System.Drawing.Point(108, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 56);
			this.button1.TabIndex = 0;
			this.button1.Text = "Stanje";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Klik1);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Yellow;
			this.button2.Location = new System.Drawing.Point(108, 171);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(153, 60);
			this.button2.TabIndex = 1;
			this.button2.Text = "Prodaja";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Klik2);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Yellow;
			this.button3.Location = new System.Drawing.Point(108, 284);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(153, 53);
			this.button3.TabIndex = 2;
			this.button3.Text = "Prijem i razduzivanje";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Klik3);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(383, 397);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prodavnica";
			this.ResumeLayout(false);

		}
	}
}
