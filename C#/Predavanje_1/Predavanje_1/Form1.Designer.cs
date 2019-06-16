/*
 * Created by SharpDevelop.
 * User: Nikola
 * Date: 30.10.2018
 * Time: 19:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Predavanje_1
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.Button Dugme1;
		private System.Windows.Forms.Label label1;
		
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
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Dugme1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(85, 118);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(100, 20);
			this.TextBox1.TabIndex = 0;
			// 
			// Dugme1
			// 
			this.Dugme1.Location = new System.Drawing.Point(157, 226);
			this.Dugme1.Name = "Dugme1";
			this.Dugme1.Size = new System.Drawing.Size(94, 24);
			this.Dugme1.TabIndex = 1;
			this.Dugme1.Text = "Izlaz iz forme";
			this.Dugme1.UseVisualStyleBackColor = true;
			this.Dugme1.Click += new System.EventHandler(this.Dugme1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(97, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Forma 2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Dugme1);
			this.Controls.Add(this.TextBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
