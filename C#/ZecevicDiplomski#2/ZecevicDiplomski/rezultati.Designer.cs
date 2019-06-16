/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/7/2018
 * Time: 7:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZecevicDiplomski
{
	partial class rezultati
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezultati));
			this.Baza = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.Baza)).BeginInit();
			this.SuspendLayout();
			// 
			// Baza
			// 
			this.Baza.AllowUserToOrderColumns = true;
			this.Baza.BackgroundColor = System.Drawing.Color.White;
			this.Baza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Baza.Location = new System.Drawing.Point(12, 12);
			this.Baza.Name = "Baza";
			this.Baza.RowHeadersVisible = false;
			this.Baza.Size = new System.Drawing.Size(503, 237);
			this.Baza.TabIndex = 11;
			// 
			// rezultati
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(527, 261);
			this.Controls.Add(this.Baza);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "rezultati";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "rezultati";
			((System.ComponentModel.ISupportInitialize)(this.Baza)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView Baza;
	}
}
