/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/16/2018
 * Time: 4:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ZecevicDiplomski
{
	/// <summary>
	/// Description of Izbor.
	/// </summary>
	public partial class Izbor : Form
	{
		public Izbor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			radioButton1.Checked = true;
			resursi.SetBrP(5);
			radioButton3.Checked = true;
			resursi.SetKategorija(1);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		int Count(int kategorija){
			if(resursi.GetKategorija()+"" == "1"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT COUNT(ID) FROM Muzika WHERE tip = '"+ kategorija +"' ";
					SQLiteDataReader r = komanda.ExecuteReader();
					int re = 0;
					while (r.Read()){
						re += int.Parse(r.GetValue(0)+"");
					}
					r.Close();
					db.Close();
					return re;				
				}
				return 0;
			}
			else if(resursi.GetKategorija()+"" == "2"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT COUNT(ID) FROM Opste WHERE tip = '"+ kategorija +"' ";
					SQLiteDataReader r = komanda.ExecuteReader();
					int re = 0;
					while (r.Read()){
						re += int.Parse(r.GetValue(0)+"");
					}
					r.Close();
					db.Close();
					return re;				
				}
				return 0;
			}
			else if(resursi.GetKategorija()+"" == "3"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT COUNT(ID) FROM Racunari WHERE tip = '"+ kategorija +"' ";
					SQLiteDataReader r = komanda.ExecuteReader();
					int re = 0;
					while (r.Read()){
						re += int.Parse(r.GetValue(0)+"");
					}
					r.Close();
					db.Close();
					return re;				
				}
				return 0;
			}
			else{
				return 0;
			}
		}
		
		
		string Moguca(int kategorija){
			if(resursi.GetKategorija()+"" == "1"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT ID FROM Muzika WHERE tip = '"+ kategorija +"' ";
					SQLiteDataReader r = komanda.ExecuteReader();
					String re = "";
					while (r.Read()){
						re += r.GetValue(0)+" ";
					}
					r.Close();
					db.Close();
					return re;				
				}
				return "";
			}
			else if(resursi.GetKategorija()+"" == "2"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT ID FROM Opste WHERE tip = '"+ kategorija +"' ";
					SQLiteDataReader r = komanda.ExecuteReader();
					String re = "";
					while (r.Read()){
						re += r.GetValue(0)+" ";
					}
					r.Close();
					db.Close();
					return re;				
				}
				return "";
			}
			else if(resursi.GetKategorija()+"" == "3"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT ID FROM Racunari WHERE tip = '"+ kategorija +"' ";
					SQLiteDataReader r = komanda.ExecuteReader();
					String re = "";
					while (r.Read()){
						re += r.GetValue(0)+" ";
					}
					r.Close();
					db.Close();
					return re;				
				}
				return "";
			}
			else{
				return "";
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			String ime = resursi.GetIme()+"";
			String datum = DateTime.Today+"";
			int put = int.Parse(Put(ime,datum))+1;
			resursi.SetPut(put);
			String kviz = "";
			if(resursi.GetKategorija()+"" == "1"){
				kviz = "Muzika";
			}
			if(resursi.GetKategorija()+"" == "2"){
				kviz = "Ostalo";
			}
			if(resursi.GetKategorija()+"" == "3"){
				kviz = "Racunari";
			}
			int ukp = Count(int.Parse(resursi.GetKategorija()+""));
			int brp = resursi.GetBrP();
			if(ukp>=brp){
	        	SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"INSERT INTO bodovi (user,poeni,datum,pokusaj,kviz) VALUES ('"+ime+"', '"+0+"', '"+datum+"', '"+put+"', '"+kviz+"')";
					SQLiteDataReader r = komanda.ExecuteReader();
				}
				db.Close();
				String moguca = Moguca(int.Parse(resursi.GetKategorija()+""));
				String s = "";
				List<int> rca = new List<int>();
	        	Random randa = new Random();
	        	int b = 0;
	        	while (b<brp){
	       			int a = randa.Next(1,ukp+1);
	            	int k = 0;
	            	foreach(int i in rca){
	            		if(a == i){
	            			k+=1;
	            		}
	           		}
	            	if(k==0){
	            		rca.Add(a);
	            		s += a+" ";
	            		b+=1;
	            	}
	            	k=0;
	        	}
	        	resursi.SetMoguca(moguca);
	        	resursi.SetLista(s);
				resursi.SetPitanje(0);
				this.Close();				
				kviz kv = new kviz();
				kv.Show();
			}
			else{
				MessageBox.Show("Nema dovoljno pitanja u toj kategoriji.");
			}
			
						
		}
		String Put(String ime, String datum){
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();	
			using(SQLiteCommand komanda = db.CreateCommand()){	
				komanda.CommandText = @"SELECT pokusaj FROM bodovi WHERE user = '"+ime+"' AND datum= '"+datum+"' ";
				SQLiteDataReader r = komanda.ExecuteReader();
				String re = "0";
				while (r.Read()){
					re = r.GetValue(0)+"";
				}
				r.Close();
				db.Close();
				return (re);
			}
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetBrP(5);
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			resursi.SetBrP(10);
		}
		
		void RadioButton3CheckedChanged(object sender, EventArgs e)
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
