/*
 * Created by SharpDevelop.
 * User: Nikola
 * Date: 30.10.2018
 * Time: 20:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Predavanje_2
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			int broj1;
			int broj2;
			
			bool dal1 = int.TryParse(textBox1.Text, out broj1);
			bool dal2 = int.TryParse(textBox2.Text, out broj2);
			
			if(dal1 && dal2)
			{
				Form1 settingsForm = new Form1(broj1, broj2);
				settingsForm.ShowDialog();
				textBox3.Text = settingsForm.rezultat;
			}
				
			//Form1 f1 = new Form1(Rezulat.Text);
       	 	//f1.ShowDialog();
		}
	}
}
