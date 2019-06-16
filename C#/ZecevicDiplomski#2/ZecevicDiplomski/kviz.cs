/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/3/2018
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ZecevicDiplomski
{
	/// <summary>
	/// Description of kviz.
	/// </summary>
	public partial class kviz : Form
	{
		public kviz()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			int pit = int.Parse(resursi.GetPitanje()+"");
			String Mog = resursi.GetMoguca()+"";
			List<string> m = Mog.Split(' ').ToList();
			String lis =resursi.GetLista()+"";
			List<string> li = lis.Split(' ').ToList();
			List<int> rc = new List<int>();
            Random rand = new Random();
            int b = 0;
            while (b<3){
            	int a = rand.Next(1,4);
            	//Console.WriteLine(a);
            	int k = 0;
            	foreach(int i in rc){
            		if(a == i){
            			k+=1;
            		}
            	}
            	if(k==0){
            		rc.Add(a);
            		b+=1;
            	}
            	
            	k=0;
            }
            int aa = int.Parse(li[pit])-1;
            textBox1.Text = Pitanje(m[aa]+"");
			
            radioButton1.Text = Odgovor(m[aa]+"",rc[0]+"");
            radioButton2.Text = Odgovor(m[aa]+"",rc[1]+"");
            radioButton3.Text = Odgovor(m[aa]+"",rc[2]+"");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e){
			resursi.SetOdgovor(1);
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e){
			resursi.SetOdgovor(2);
		}
		void RadioButton3CheckedChanged(object sender, EventArgs e){
			resursi.SetOdgovor(3);
		}
        
		String Pitanje(String rb){
			if(resursi.GetKategorija()+"" == "1"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT text FROM Muzika WHERE ID = '"+rb+"' ";
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
			else if(resursi.GetKategorija()+"" == "2"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT text FROM Opste WHERE ID = '"+rb+"' ";
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
			else if(resursi.GetKategorija()+"" == "3"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT text FROM Racunari WHERE ID = '"+rb+"' ";
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
			else{
				return "";
			}
		}
		String Odgovor(String rb, String rb1){
			if(resursi.GetKategorija()+"" == "1"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT text FROM odgovorim WHERE pitanje = '"+rb+"' AND o= '"+rb1+"' ";
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
			else if(resursi.GetKategorija()+"" == "2"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT text FROM odgovorio WHERE pitanje = '"+rb+"' AND o= '"+rb1+"' ";
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
			else if(resursi.GetKategorija()+"" == "3"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT text FROM odgovorir WHERE pitanje = '"+rb+"' AND o= '"+rb1+"' ";
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
			else{
				return "";
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			String datum = DateTime.Today+"";
			int put = resursi.GetPut();
			int br = 1;
			br = br +  int.Parse(resursi.GetPitanje()+"");
			resursi.SetPitanje(br);
			if(resursi.GetOdgovor()+"" == "1"){
				
				if(Provera5(radioButton1.Text)+"" == "1"){
					String ime = resursi.GetIme()+"";
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"UPDATE bodovi SET poeni = poeni+3 WHERE user = '"+ime+"' AND datum = '"+datum+"' AND Pokusaj = '"+put+"'" ;
						SQLiteDataReader r = komanda.ExecuteReader();
						
					}
				}
				else{
					String ime = resursi.GetIme()+"";
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"UPDATE bodovi SET poeni = poeni-1 WHERE user = '"+ime+"' AND datum = '"+datum+"' AND Pokusaj = '"+put+"'" ;
						SQLiteDataReader r = komanda.ExecuteReader();
						
					}
				}
			}
			else if(resursi.GetOdgovor()+"" == "2"){
				if(Provera5(radioButton2.Text)+"" == "1"){
					String ime = resursi.GetIme()+"";
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"UPDATE bodovi SET poeni = poeni+3 WHERE user = '"+ime+"' AND datum = '"+datum+"' AND Pokusaj = '"+put+"'" ;
						SQLiteDataReader r = komanda.ExecuteReader();
						
					}
				}
				else{
					String ime = resursi.GetIme()+"";
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"UPDATE bodovi SET poeni = poeni-1 WHERE user = '"+ime+"' AND datum = '"+datum+"' AND Pokusaj = '"+put+"'" ;
						SQLiteDataReader r = komanda.ExecuteReader();
						
					}
				}
			
			}
			else if(resursi.GetOdgovor()+"" == "3"){
				if(Provera5(radioButton3.Text)+"" == "1"){
					String ime = resursi.GetIme()+"";
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"UPDATE bodovi SET poeni = poeni+3 WHERE user = '"+ime+"' AND datum = '"+datum+"' AND Pokusaj = '"+put+"'" ;
						SQLiteDataReader r = komanda.ExecuteReader();
						
					}
				}
				else{
					String ime = resursi.GetIme()+"";
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"UPDATE bodovi SET poeni = poeni-1 WHERE user = '"+ime+"' AND datum = '"+datum+"' AND Pokusaj = '"+put+"'" ;
						SQLiteDataReader r = komanda.ExecuteReader();
						
					}
				}
			
			}
			this.Close();
			int l = resursi.GetBrP();
			if(br<l){
				kviz k = new kviz();
				k.Show();
			}
			else{
				kraj kr = new kraj();
				kr.Show();
			}
				
		}
		String Provera5(String o){
			if(resursi.GetKategorija()+"" == "1"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT tacan FROM odgovorim WHERE text = '"+o+"'";
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
			else if(resursi.GetKategorija()+"" == "2"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT tacan FROM odgovorio WHERE text = '"+o+"'";
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
			else if(resursi.GetKategorija()+"" == "3"){
				SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
				db.Open();
			
				using(SQLiteCommand komanda = db.CreateCommand()){
				
					komanda.CommandText = @"SELECT tacan FROM odgovorir WHERE text = '"+o+"'";
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
			else{
				return "";
			}
		}
			
	}
}
