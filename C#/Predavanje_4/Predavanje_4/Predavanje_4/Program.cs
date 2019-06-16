/*
 * Created by SharpDevelop.
 * User: student
 * Date: 04.12.2018.
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Predavanje_4
{
	class Program
	{
		public static void ReceiveDataSync(object sock)
		{
			Socket so=(Socket)sock;
			byte[]receive_buffer= new byte[1024];
			int size=so.Receive(receive_buffer);
			Console.WriteLine(Encoding.ASCII.GetString(receive_buffer, 0, size));
		}
		
		public static void SendDataSync(object poruka)
		{
			
			Socket sock=new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			IPAddress adresa_servera= IPAddress.Parse("127.0.0.1");
			IPEndPoint end_point=new IPEndPoint(adresa_servera, 1111);
			
			string s=(string) poruka;
			byte[]send_buffer=Encoding.ASCII.GetBytes(s);
			sock.SendTo(send_buffer, end_point);
			
			
			Thread t=new Thread(SendDataSync);
			t.Start(sock);
			t.Join();
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("*** Klijent ***");
			Console.ReadKey(true);
			
			while(true)
			{
				Console.Write(">");
				string poruka=Console.ReadLine();
				
				if(poruka=="Exit")
				{
					break;
				}
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}