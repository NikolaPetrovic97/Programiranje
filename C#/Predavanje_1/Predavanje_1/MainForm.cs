/*
 * Created by SharpDevelop.
 * User: student
 * Date: 09.10.2018.
 * Time: 13:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Predavanje_1
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Dugme1Click(object sender, EventArgs e)
		{
			string message="Da li ste sigurni da zelite da iskljucite aplikaciju?";
			string caption="Provera";
			MessageBoxButtons buttons=MessageBoxButtons.YesNo;
			DialogResult result;
			
			
			
			result=MessageBox.Show(message, caption, buttons);
			
			if(result== System.Windows.Forms.DialogResult.Yes)
			{
				this.Close();
			}
		}
		void Poruka(object sender, EventArgs e)
		{
			
			try
			{
			
				int broj1=int.Parse(TextBox1.Text);
				int broj2=int.Parse(TextBox2.Text);
			
			
				
				if (radio1.Checked)
				{
					TextBox3.Text=(broj1 + broj2)+ "";
				}
				
				else if(radio2.Checked)
				{
					TextBox3.Text=(broj1 - broj2)+ "";
				}
				
				else if(radio3.Checked)
				{
					TextBox3.Text=(broj1 * broj2)+ "";
				}
				
				else if(radio4.Checked)
				{
					TextBox3.Text=(broj1 / broj2)+ "";
				}
				
				
				else
				{
					MessageBox.Show("Izaberi jednu od opcija");
				}
			
				
			}
			
			catch(Exception error)
			{
				MessageBox.Show("Unos nije dobar");
			}
	}
		void Dugme3Click(object sender, EventArgs e)
		{
			TextBox1.Clear();
			TextBox2.Clear();
			TextBox3.Clear();
			
		}
		void Dugme4Click(object sender, EventArgs e)
		{
			Form1 f1=new Form1(TextBox3.Text);
			f1.ShowDialog();
		}
		
		
		
	}
}
