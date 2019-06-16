/*
 * Created by SharpDevelop.
 * User: Nikola
 * Date: 30.10.2018
 * Time: 19:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Predavanje_1
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1(string s)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			TextBox1.Text=s;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Dugme1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
