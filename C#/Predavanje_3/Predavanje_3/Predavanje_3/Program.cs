/*
 * Created by SharpDevelop.
 * User: student
 * Date: 04.12.2018.
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Predavanje_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("*** Server ***");
			
			byte[]data=new byte[1024];
			IPEndPoint ipep=new IPEndPoint(IPAddress.Any, 1111);
			UdpClient sock=new UdpClient(ipep);
			
			IPEndPoint sender=new IPEndPoint(IPAddress.Any, 0);
			
			Console.WriteLine("Ceka se podatak...");
			data=sock.Receive(ref sender);
			
			Console.WriteLine("Poruka od: " + sender.ToString());
			Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
			
			Thread.Sleep(10000);
			
			string odgovor="Super";
			data=Encoding.ASCII.GetBytes(odgovor);
			sock.Send(data, data.Length, sender);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}