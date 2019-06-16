/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/3/2018
 * Time: 2:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace ZecevicDiplomski
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			logreg lr = new logreg();
			lr.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			rezultati rr = new rezultati();
			rr.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
