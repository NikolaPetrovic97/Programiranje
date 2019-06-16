/*
 * Created by SharpDevelop.
 * User: Fujitsu E752
 * Date: 11/7/2017
 * Time: 12:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prodavnica
{
	partial class Form3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(38, 74);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(445, 267);
			this.dataGridView1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(538, 100);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(118, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(538, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Naziv";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(538, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Sifra";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(538, 180);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(118, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(538, 234);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Kolicina";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(538, 260);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(118, 20);
			this.textBox3.TabIndex = 6;
			// 
			// radioButton1
			// 
			this.radioButton1.BackColor = System.Drawing.Color.Transparent;
			this.radioButton1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.ForeColor = System.Drawing.Color.Yellow;
			this.radioButton1.Location = new System.Drawing.Point(719, 123);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 7;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Zaduzi";
			this.radioButton1.UseVisualStyleBackColor = false;
			// 
			// radioButton2
			// 
			this.radioButton2.BackColor = System.Drawing.Color.Transparent;
			this.radioButton2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.ForeColor = System.Drawing.Color.Yellow;
			this.radioButton2.Location = new System.Drawing.Point(719, 180);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 8;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Razduzi";
			this.radioButton2.UseVisualStyleBackColor = false;
			// 
			// radioButton3
			// 
			this.radioButton3.BackColor = System.Drawing.Color.Transparent;
			this.radioButton3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.ForeColor = System.Drawing.Color.Yellow;
			this.radioButton3.Location = new System.Drawing.Point(719, 234);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 9;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Prodaj";
			this.radioButton3.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Yellow;
			this.button1.Location = new System.Drawing.Point(719, 372);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 37);
			this.button1.TabIndex = 10;
			this.button1.Text = "Uradi";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Yellow;
			this.button2.Location = new System.Drawing.Point(538, 372);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 37);
			this.button2.TabIndex = 11;
			this.button2.Text = "Prikazi";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(851, 447);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form3";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
