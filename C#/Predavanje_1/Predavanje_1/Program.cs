/*
 * Created by SharpDevelop.
 * User: student
 * Date: 09.10.2018.
 * Time: 13:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Predavanje_1
{
	
	internal sealed class Program
	{
		
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
