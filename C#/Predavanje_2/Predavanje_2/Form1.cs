/*
 * Created by SharpDevelop.
 * User: Nikola
 * Date: 30.10.2018
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Predavanje_2
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		
		public String rezultat;
		int broj1;
		int broj2;
		public Form1(int broj1, int broj2)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.broj1=broj1;
			this.broj2=broj2;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			if(radioButton1.Checked==true)
			{
				rezultat=(broj1 + broj2)+ "";
				this.Close();
			}
			
			else if(radioButton2.Checked==true)
			{
				rezultat=(broj1 - broj2)+ "";
				this.Close();
			}
			
			else if(radioButton3.Checked==true)
			{
				rezultat=(broj1 * broj2)+ "";
				this.Close();
			}
			
			else if(radioButton4.Checked==true)
			{
				rezultat=(broj1 / broj2)+ "";
				this.Close();
			}
			
			
		}
	}
}
