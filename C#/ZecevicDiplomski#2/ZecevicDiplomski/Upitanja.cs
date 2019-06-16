/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/13/2018
 * Time: 11:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ZecevicDiplomski
{
	/// <summary>
	/// Description of Upitanja.
	/// </summary>
	public partial class Upitanja : Form
	{
		public Upitanja()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			radioButton1.Checked = true;
			resursi.SetUod(1);
			radioButton6.Checked = true;
			resursi.SetKategorija(1);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetUod(1);
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetUod(2);
		}
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetUod(3);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int t1 = 0;
			int t2 = 0;
			int t3 = 0;
			int t = int.Parse(resursi.GetUod()+"");
			if(t == 1){
				t1 = 1;
			}
			else if(t == 2){
				t2 = 1;
			}
			else if(t == 3){
				t3 = 1;
			}
			if(resursi.GetKategorija()+"" == "1"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"INSERT INTO Muzika (text,tip) VALUES ('"+textBox1.Text+"','"+1+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				int pitid = int.Parse(ProveraM(textBox1.Text)+"");
				SQLiteConnection db1 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db1.Open();
				using(SQLiteCommand komanda = db1.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorim (text,pitanje,tacan,o) VALUES ('"+textBox2.Text+"','"+pitid+"','"+t1+"','"+1+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				SQLiteConnection db2 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db2.Open();
				using(SQLiteCommand komanda = db2.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorim (text,pitanje,tacan,o) VALUES ('"+textBox3.Text+"','"+pitid+"','"+t2+"','"+2+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				SQLiteConnection db3 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db3.Open();
				using(SQLiteCommand komanda = db3.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorim (text,pitanje,tacan,o) VALUES ('"+textBox4.Text+"','"+pitid+"','"+t3+"','"+3+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
			}
			else if(resursi.GetKategorija()+"" == "2"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"INSERT INTO Opste (text,tip) VALUES ('"+textBox1.Text+"','"+2+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				int pitid = int.Parse(ProveraO(textBox1.Text)+"");
				SQLiteConnection db1 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db1.Open();
				using(SQLiteCommand komanda = db1.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorio (text,pitanje,tacan,o) VALUES ('"+textBox2.Text+"','"+pitid+"','"+t1+"','"+1+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				SQLiteConnection db2 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db2.Open();
				using(SQLiteCommand komanda = db2.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorio (text,pitanje,tacan,o) VALUES ('"+textBox3.Text+"','"+pitid+"','"+t2+"','"+2+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				SQLiteConnection db3 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db3.Open();
				using(SQLiteCommand komanda = db3.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorio (text,pitanje,tacan,o) VALUES ('"+textBox4.Text+"','"+pitid+"','"+t3+"','"+3+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
			}
			else if(resursi.GetKategorija()+"" == "3"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"INSERT INTO Racunari (text,tip) VALUES ('"+textBox1.Text+"','"+3+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				int pitid = int.Parse(ProveraR(textBox1.Text)+"");
				SQLiteConnection db1 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db1.Open();
				using(SQLiteCommand komanda = db1.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorir (text,pitanje,tacan,o) VALUES ('"+textBox2.Text+"','"+pitid+"','"+t1+"','"+1+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				SQLiteConnection db2 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db2.Open();
				using(SQLiteCommand komanda = db2.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorir (text,pitanje,tacan,o) VALUES ('"+textBox3.Text+"','"+pitid+"','"+t2+"','"+2+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				SQLiteConnection db3 = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db3.Open();
				using(SQLiteCommand komanda = db3.CreateCommand()){
					komanda.CommandText = @"INSERT INTO odgovorir (text,pitanje,tacan,o) VALUES ('"+textBox4.Text+"','"+pitid+"','"+t3+"','"+3+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
			}
			this.Close();
					
		}
		String ProveraM(String text){
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();
			
			using(SQLiteCommand komanda = db.CreateCommand()){
				
				komanda.CommandText = @"SELECT ID FROM Muzika WHERE text = '"+text+"'";
				SQLiteDataReader r = komanda.ExecuteReader();
				String re = "";
				while (r.Read()){
					re = r.GetValue(0)+"";
				}
				r.Close();
				db.Close();
				return (re);
			
			}
		}
		String ProveraO(String text){
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();
			
			using(SQLiteCommand komanda = db.CreateCommand()){
				
				komanda.CommandText = @"SELECT ID FROM Opste WHERE text = '"+text+"'";
				SQLiteDataReader r = komanda.ExecuteReader();
				String re = "";
				while (r.Read()){
					re = r.GetValue(0)+"";
				}
				r.Close();
				db.Close();
				return (re);
			
			}
		}
		String ProveraR(String text){
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();
			
			using(SQLiteCommand komanda = db.CreateCommand()){
				
				komanda.CommandText = @"SELECT ID FROM Racunari WHERE text = '"+text+"'";
				SQLiteDataReader r = komanda.ExecuteReader();
				String re = "";
				while (r.Read()){
					re = r.GetValue(0)+"";
				}
				r.Close();
				db.Close();
				return (re);
			
			}
		}
		
		void RadioButton6CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetKategorija(1);
		}
		
		void RadioButton4CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetKategorija(2);
		}
		
		void RadioButton5CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetKategorija(3);
		}
	}
}
