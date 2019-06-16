/*
 * Created by SharpDevelop.
 * User: gpc2
 * Date: 13.11.2018
 * Time: 14:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PjPXO
{
	partial class MainMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox nickName1;
		private System.Windows.Forms.TextBox nickName2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataSql;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.nickName1 = new System.Windows.Forms.TextBox();
			this.nickName2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataSql = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataSql)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(199, 36);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// nickName1
			// 
			this.nickName1.Location = new System.Drawing.Point(63, 12);
			this.nickName1.Name = "nickName1";
			this.nickName1.Size = new System.Drawing.Size(100, 20);
			this.nickName1.TabIndex = 1;
			// 
			// nickName2
			// 
			this.nickName2.Location = new System.Drawing.Point(63, 38);
			this.nickName2.Name = "nickName2";
			this.nickName2.Size = new System.Drawing.Size(100, 20);
			this.nickName2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ime 1:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ime 2:";
			// 
			// dataSql
			// 
			this.dataSql.AllowUserToAddRows = false;
			this.dataSql.AllowUserToDeleteRows = false;
			this.dataSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataSql.Location = new System.Drawing.Point(13, 69);
			this.dataSql.Name = "dataSql";
			this.dataSql.ReadOnly = true;
			this.dataSql.Size = new System.Drawing.Size(261, 180);
			this.dataSql.TabIndex = 5;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.dataSql);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nickName2);
			this.Controls.Add(this.nickName1);
			this.Controls.Add(this.button1);
			this.Name = "MainMenu";
			this.Text = "MainMenu";
			((System.ComponentModel.ISupportInitialize)(this.dataSql)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
