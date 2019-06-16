using System;
using System.Windows.Forms;

namespace PjPXO
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu());
		}
		
	}
}