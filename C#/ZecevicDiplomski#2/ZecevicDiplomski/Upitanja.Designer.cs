/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/13/2018
 * Time: 11:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZecevicDiplomski
{
	partial class Upitanja
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upitanja));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.OldLace;
			this.button1.Location = new System.Drawing.Point(186, 218);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 31);
			this.button1.TabIndex = 9;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(11, 18);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(155, 86);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "Unesite pitanje";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(12, 130);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(154, 22);
			this.textBox2.TabIndex = 10;
			this.textBox2.Text = "unesite odgovor 1";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(12, 156);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(154, 22);
			this.textBox3.TabIndex = 11;
			this.textBox3.Text = "unesite odgovor 2";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(11, 182);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(155, 22);
			this.textBox4.TabIndex = 12;
			this.textBox4.Text = "unesite odgovor 3";
			// 
			// radioButton1
			// 
			this.radioButton1.BackColor = System.Drawing.Color.Transparent;
			this.radioButton1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.ForeColor = System.Drawing.Color.OldLace;
			this.radioButton1.Location = new System.Drawing.Point(173, 130);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 13;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Oznacite ";
			this.radioButton1.UseVisualStyleBackColor = false;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.BackColor = System.Drawing.Color.Transparent;
			this.radioButton2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.ForeColor = System.Drawing.Color.OldLace;
			this.radioButton2.Location = new System.Drawing.Point(173, 156);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 14;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "tacan";
			this.radioButton2.UseVisualStyleBackColor = false;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.BackColor = System.Drawing.Color.Transparent;
			this.radioButton3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.ForeColor = System.Drawing.Color.OldLace;
			this.radioButton3.Location = new System.Drawing.Point(173, 182);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 15;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "odgovor";
			this.radioButton3.UseVisualStyleBackColor = false;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioButton5);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton6);
			this.groupBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.OldLace;
			this.groupBox1.Location = new System.Drawing.Point(186, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(91, 112);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Izaberite tip";
			// 
			// radioButton5
			// 
			this.radioButton5.Location = new System.Drawing.Point(6, 79);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(71, 24);
			this.radioButton5.TabIndex = 8;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Racunari";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(6, 49);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(71, 24);
			this.radioButton4.TabIndex = 7;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Opste";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4CheckedChanged);
			// 
			// radioButton6
			// 
			this.radioButton6.Location = new System.Drawing.Point(6, 19);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(71, 24);
			this.radioButton6.TabIndex = 6;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Muzika";
			this.radioButton6.UseVisualStyleBackColor = true;
			this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButton6CheckedChanged);
			// 
			// Upitanja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Upitanja";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Upitanja";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}
