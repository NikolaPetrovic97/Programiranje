/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/3/2018
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZecevicDiplomski
{
	partial class kviz
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kviz));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(9, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(262, 92);
			this.textBox1.TabIndex = 0;
			// 
			// radioButton1
			// 
			this.radioButton1.BackColor = System.Drawing.Color.Transparent;
			this.radioButton1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.ForeColor = System.Drawing.Color.OldLace;
			this.radioButton1.Location = new System.Drawing.Point(9, 126);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(172, 24);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = false;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.BackColor = System.Drawing.Color.Transparent;
			this.radioButton2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.ForeColor = System.Drawing.Color.OldLace;
			this.radioButton2.Location = new System.Drawing.Point(9, 170);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(172, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "radioButton2";
			this.radioButton2.UseVisualStyleBackColor = false;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.BackColor = System.Drawing.Color.Transparent;
			this.radioButton3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.ForeColor = System.Drawing.Color.OldLace;
			this.radioButton3.Location = new System.Drawing.Point(9, 216);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(172, 24);
			this.radioButton3.TabIndex = 3;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "radioButton3";
			this.radioButton3.UseVisualStyleBackColor = false;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3CheckedChanged);
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.OldLace;
			this.button1.Location = new System.Drawing.Point(187, 209);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "Dalјe";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// kviz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.textBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "kviz";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "kviz";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
