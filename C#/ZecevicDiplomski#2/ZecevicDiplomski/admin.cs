/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/7/2018
 * Time: 4:02 PM
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
	/// Description of admin.
	/// </summary>
	public partial class admin : Form
	{
		public admin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetAdmin(1);
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetAdmin(0);
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			if(Provera4(textBox1.Text)== textBox1.Text){
				string pass = "";
				HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
				byte[] a = Encoding.ASCII.GetBytes(textBox2.Text);
				byte[] result = sha256.ComputeHash(a);
				string rezultat = BitConverter.ToString(result);
				pass = rezultat;
				int ad = int.Parse(resursi.GetAdmin()+"");
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
				
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"UPDATE user SET password = '"+pass+"', admin = '"+ad+"' WHERE username = '"+textBox1.Text+"'" ;
					SQLiteDataReader r = komanda.ExecuteReader();
				}
			}
			else if(Provera4(textBox1.Text)!= textBox1.Text){
				try{
					string pass = "";
					HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
					byte[] a = Encoding.ASCII.GetBytes(textBox2.Text);
					byte[] result = sha256.ComputeHash(a);
					string rezultat = BitConverter.ToString(result);
					pass = rezultat;
					int ad = resursi.GetAdmin();
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
					
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"INSERT INTO user (username,password,admin) VALUES ('"+textBox1.Text+"','"+pass+"','"+ad+"')";
						SQLiteDataReader r = komanda.ExecuteReader();
					}
				}
				catch{};
			}
			this.Close();
		}
		String Provera4(String ime){
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
		db.Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Upitanja up = new Upitanja();
			up.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Opitanja op = new Opitanja();
			op.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			try{
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"DELETE FROM user WHERE ID = '"+textBox3.Text+"'";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				db.Close();
			}
			catch{
				MessageBox.Show("Korisnik sa tim ID ne postoji");
			}
			this.Close();
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();
			
			using(SQLiteCommand komanda = db.CreateCommand()){
				
				komanda.CommandText = @"SELECT username FROM user WHERE id = '"+textBox3.Text+"'";
				SQLiteDataReader r = komanda.ExecuteReader();
				String re = "";
				while (r.Read()){
					re = r.GetValue(0)+"";
				}
				r.Close();
				db.Close();
				textBox4.Text = re;
			}
		}
	}
}
