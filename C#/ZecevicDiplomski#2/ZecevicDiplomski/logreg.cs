/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/3/2018
 * Time: 2:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace ZecevicDiplomski
{
	/// <summary>
	/// Description of logreg.
	/// </summary>
	public partial class logreg : Form
	{
		public logreg()
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
			
			if (textBox1.Text == ""){
				MessageBox.Show("Morate uneti korisnicko ime",
   	 				"Critical Warning");
			}
			else if(textBox1.Text != Provera(textBox1.Text)){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
				string pass = "";
				HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
				byte[] a = Encoding.ASCII.GetBytes(textBox2.Text);
				byte[] result = sha256.ComputeHash(a);
				string rezultat = BitConverter.ToString(result);
				pass = rezultat;
					
				using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"INSERT INTO user (username,password) VALUES ('"+textBox1.Text+"', '"+pass+"')";
						SQLiteDataReader r = komanda.ExecuteReader();
				
					}
				resursi.SetIme(textBox1.Text);
				start s = new start();
				s.Show();
			}
			else{
				MessageBox.Show("Korisnicko ime vec postoji",
   	 				"Critical Warning");
				
			}
			this.Close();
		}
		String Provera(String ime){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT username FROM user WHERE username = '"+ime+"'";
					SQLiteDataReader r = komanda.ExecuteReader();
					String re = "";
					while (r.Read()){
						re = r.GetValue(0)+"";
					}
					r.Close();
					db.Close();
					return (re);
				}
				return "";
			}
		String Provera2(String ime){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT password FROM user WHERE username = '"+ime+"'";
					SQLiteDataReader r = komanda.ExecuteReader();
					String re = "";
					while (r.Read()){
						re = r.GetValue(0)+"";
					}
					r.Close();
					db.Close();
					return (re);
				}
				return "";
			}
		
		void Button2Click(object sender, EventArgs e)
		{
			if(textBox1.Text == Provera(textBox1.Text)){
				string sif = "";
				HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
				byte[] a = Encoding.ASCII.GetBytes(textBox2.Text);
				byte[] result = sha256.ComputeHash(a);
				string rezultat = BitConverter.ToString(result);
				sif = rezultat;
				if(sif == Provera2(textBox1.Text)){
					resursi.SetIme(textBox1.Text);
					start s = new start();
					s.Show();
				}
				else{
					MessageBox.Show("Pogresna sifra",
   	 				"Critical Warning");
				}
			}
			else{
				MessageBox.Show("Korisnik ne postoji",
   	 				"Critical Warning");
			}
			this.Close();
						
		}
	}
}
