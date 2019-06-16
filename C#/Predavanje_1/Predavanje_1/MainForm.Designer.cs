/*
 * Created by SharpDevelop.
 * User: student
 * Date: 09.10.2018.
 * Time: 13:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Predavanje_1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Dugme1;
		private System.Windows.Forms.Button Dugme2;
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.TextBox TextBox2;
		private System.Windows.Forms.RadioButton radio1;
		private System.Windows.Forms.RadioButton radio2;
		private System.Windows.Forms.RadioButton radio3;
		private System.Windows.Forms.RadioButton radio4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Dugme3;
		private System.Windows.Forms.TextBox TextBox3;
		private System.Windows.Forms.Button Dugme4;
		
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
			this.Dugme1 = new System.Windows.Forms.Button();
			this.Dugme2 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.radio1 = new System.Windows.Forms.RadioButton();
			this.radio2 = new System.Windows.Forms.RadioButton();
			this.radio3 = new System.Windows.Forms.RadioButton();
			this.radio4 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.Dugme3 = new System.Windows.Forms.Button();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Dugme4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Dugme1
			// 
			this.Dugme1.Location = new System.Drawing.Point(739, 292);
			this.Dugme1.Name = "Dugme1";
			this.Dugme1.Size = new System.Drawing.Size(75, 20);
			this.Dugme1.TabIndex = 0;
			this.Dugme1.Text = "Izlaz";
			this.Dugme1.UseVisualStyleBackColor = true;
			this.Dugme1.Click += new System.EventHandler(this.Dugme1Click);
			// 
			// Dugme2
			// 
			this.Dugme2.Location = new System.Drawing.Point(111, 241);
			this.Dugme2.Name = "Dugme2";
			this.Dugme2.Size = new System.Drawing.Size(75, 23);
			this.Dugme2.TabIndex = 1;
			this.Dugme2.Text = "Izracunaj";
			this.Dugme2.UseVisualStyleBackColor = true;
			this.Dugme2.Click += new System.EventHandler(this.Poruka);
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(2, 105);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(100, 20);
			this.TextBox1.TabIndex = 2;
			// 
			// TextBox2
			// 
			this.TextBox2.Location = new System.Drawing.Point(227, 101);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(100, 20);
			this.TextBox2.TabIndex = 3;
			// 
			// radio1
			// 
			this.radio1.Location = new System.Drawing.Point(147, 61);
			this.radio1.Name = "radio1";
			this.radio1.Size = new System.Drawing.Size(39, 24);
			this.radio1.TabIndex = 4;
			this.radio1.TabStop = true;
			this.radio1.Text = "+";
			this.radio1.UseVisualStyleBackColor = true;
			// 
			// radio2
			// 
			this.radio2.Location = new System.Drawing.Point(147, 91);
			this.radio2.Name = "radio2";
			this.radio2.Size = new System.Drawing.Size(39, 24);
			this.radio2.TabIndex = 5;
			this.radio2.TabStop = true;
			this.radio2.Text = "-";
			this.radio2.UseVisualStyleBackColor = true;
			// 
			// radio3
			// 
			this.radio3.Location = new System.Drawing.Point(147, 122);
			this.radio3.Name = "radio3";
			this.radio3.Size = new System.Drawing.Size(39, 24);
			this.radio3.TabIndex = 6;
			this.radio3.TabStop = true;
			this.radio3.Text = "*";
			this.radio3.UseVisualStyleBackColor = true;
			// 
			// radio4
			// 
			this.radio4.Location = new System.Drawing.Point(147, 152);
			this.radio4.Name = "radio4";
			this.radio4.Size = new System.Drawing.Size(39, 24);
			this.radio4.TabIndex = 7;
			this.radio4.TabStop = true;
			this.radio4.Text = "/";
			this.radio4.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(352, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "=";
			// 
			// Dugme3
			// 
			this.Dugme3.Location = new System.Drawing.Point(590, 40);
			this.Dugme3.Name = "Dugme3";
			this.Dugme3.Size = new System.Drawing.Size(75, 23);
			this.Dugme3.TabIndex = 10;
			this.Dugme3.Text = "Resetuj";
			this.Dugme3.UseVisualStyleBackColor = true;
			this.Dugme3.Click += new System.EventHandler(this.Dugme3Click);
			// 
			// TextBox3
			// 
			this.TextBox3.Location = new System.Drawing.Point(390, 102);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(100, 20);
			this.TextBox3.TabIndex = 11;
			// 
			// Dugme4
			// 
			this.Dugme4.Location = new System.Drawing.Point(352, 308);
			this.Dugme4.Name = "Dugme4";
			this.Dugme4.Size = new System.Drawing.Size(119, 23);
			this.Dugme4.TabIndex = 12;
			this.Dugme4.Text = "Dugme za formu";
			this.Dugme4.UseVisualStyleBackColor = true;
			this.Dugme4.Click += new System.EventHandler(this.Dugme4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(846, 366);
			this.Controls.Add(this.Dugme4);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.Dugme3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.radio4);
			this.Controls.Add(this.radio3);
			this.Controls.Add(this.radio2);
			this.Controls.Add(this.radio1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Dugme2);
			this.Controls.Add(this.Dugme1);
			this.Name = "MainForm";
			this.Text = "Predavanje_1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
