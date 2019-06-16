/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/18/2018
 * Time: 2:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZecevicDiplomski
{
	partial class Ppitanja
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ppitanja));
			this.Baza1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.Baza1)).BeginInit();
			this.SuspendLayout();
			// 
			// Baza1
			// 
			this.Baza1.BackgroundColor = System.Drawing.Color.White;
			this.Baza1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Baza1.Location = new System.Drawing.Point(12, 12);
			this.Baza1.Name = "Baza1";
			this.Baza1.RowHeadersVisible = false;
			this.Baza1.Size = new System.Drawing.Size(290, 237);
			this.Baza1.TabIndex = 0;
			// 
			// Ppitanja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(314, 261);
			this.Controls.Add(this.Baza1);
			this.Name = "Ppitanja";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ppitanja";
			((System.ComponentModel.ISupportInitialize)(this.Baza1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView Baza1;
	}
}
