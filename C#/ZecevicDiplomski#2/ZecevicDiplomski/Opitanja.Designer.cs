/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/14/2018
 * Time: 10:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZecevicDiplomski
{
	partial class Opitanja
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opitanja));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioButton5);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton6);
			this.groupBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.OldLace;
			this.groupBox1.Location = new System.Drawing.Point(184, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(91, 112);
			this.groupBox1.TabIndex = 24;
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
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(9, 203);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(155, 22);
			this.textBox4.TabIndex = 20;
			this.textBox4.Text = "unesite odgovor 3";
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(10, 177);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(154, 22);
			this.textBox3.TabIndex = 19;
			this.textBox3.Text = "unesite odgovor 2";
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(10, 151);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(154, 22);
			this.textBox2.TabIndex = 18;
			this.textBox2.Text = "unesite odgovor 1";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(9, 39);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(155, 86);
			this.textBox1.TabIndex = 17;
			this.textBox1.Text = "Unesite pitanje";
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.OldLace;
			this.button1.Location = new System.Drawing.Point(184, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 39);
			this.button1.TabIndex = 25;
			this.button1.Text = "Obrisi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(13, 13);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(57, 22);
			this.textBox5.TabIndex = 26;
			this.textBox5.TextChanged += new System.EventHandler(this.TextBox5TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.OldLace;
			this.label1.Location = new System.Drawing.Point(77, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 27;
			this.label1.Text = "ID pitanja";
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.OldLace;
			this.button2.Location = new System.Drawing.Point(184, 169);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 39);
			this.button2.TabIndex = 28;
			this.button2.Text = "Pitanja";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Opitanja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Opitanja";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Opitanja";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
