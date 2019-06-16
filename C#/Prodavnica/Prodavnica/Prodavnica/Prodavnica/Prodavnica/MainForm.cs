using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Prodavnica{
using System.Data.SQLite;

	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		}
			void Button1Click(object sender, EventArgs e){
			
		}
		void Button1MouseClick(object sender, MouseEventArgs e){
			Button b1= (Button) this.Controls ["Form1"];
			Button b2= (Button) this.Controls ["Form2"];
			Button b3 = (Button) this.Controls ["Form3"];
			
			
		}
		void Klik1(object s, EventArgs ea){
			Button b1 = (Button) this.Controls ["Form1"];
			Form1 form1 = new Form1();
			form1.Show();
			
		}
		void Klik2(object s, EventArgs ea){
			Button b2 = (Button) this.Controls ["Form2"];
			Form2 form2 = new Form2();
			form2.Show();
		}
		 void Klik3(object s, EventArgs ea){
			Button b3 = (Button) this.Controls ["Form3"];
			Form3 form3 = new Form3();
			form3.Show();
		}
		 
		
		void MainFormLoad(object sender, EventArgs e)
		{
					
		}
		void Button3Click(object sender, EventArgs e){
			
		}
		void Button3(object sender, EventArgs e){
			
		}
	}
}