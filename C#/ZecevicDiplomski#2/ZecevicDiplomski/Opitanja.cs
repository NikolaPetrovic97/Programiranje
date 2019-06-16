/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/14/2018
 * Time: 10:37 AM
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
	/// Description of Opitanja.
	/// </summary>
	public partial class Opitanja : Form
	{
		public Opitanja()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			radioButton6.Checked = true;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			if(resursi.GetKategorija()+"" == "1"){
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM Muzika WHERE ID = '"+textBox5.Text+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();
						textBox1.Text = re;						
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorim WHERE pitanje = '"+textBox5.Text+"' AND o = '"+1+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();
						textBox2.Text = re;							
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorim WHERE pitanje = '"+textBox5.Text+"' AND o = '"+2+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();	
						textBox3.Text = re;							
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorim WHERE pitanje = '"+textBox5.Text+"' AND o = '"+3+"' ";
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
				catch{}
			}
			else if(resursi.GetKategorija()+"" == "2"){
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM Opste WHERE ID = '"+textBox5.Text+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();
						textBox1.Text = re;						
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorio WHERE pitanje = '"+textBox5.Text+"' AND o = '"+1+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();
						textBox2.Text = re;							
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorio WHERE pitanje = '"+textBox5.Text+"' AND o = '"+2+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();	
						textBox3.Text = re;							
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorio WHERE pitanje = '"+textBox5.Text+"' AND o = '"+3+"' ";
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
				catch{}
			}
			else if(resursi.GetKategorija()+"" == "3"){
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM Racunari WHERE ID = '"+textBox5.Text+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();
						textBox1.Text = re;						
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorir WHERE pitanje = '"+textBox5.Text+"' AND o = '"+1+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();
						textBox2.Text = re;							
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorir WHERE pitanje = '"+textBox5.Text+"' AND o = '"+2+"' ";
						SQLiteDataReader r = komanda.ExecuteReader();
						String re = "";
						while (r.Read()){
							re = r.GetValue(0)+"";
						}
						r.Close();
						db.Close();	
						textBox3.Text = re;							
					}
				}
				catch{}
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
				
					using(SQLiteCommand komanda = db.CreateCommand()){
					
						komanda.CommandText = @"SELECT text FROM odgovorir WHERE pitanje = '"+textBox5.Text+"' AND o = '"+3+"' ";
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
				catch{}
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
		
		void Button1Click(object sender, EventArgs e)
		{
			if(resursi.GetKategorija()+"" == "1"){
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"DELETE FROM Muzika WHERE ID = '"+textBox5.Text+"'";
						SQLiteDataReader r = komanda.ExecuteReader();
					}
					db.Close();
					SQLiteConnection dba = new SQLiteConnection("Data Source=baza.db;Version=3;");
					dba.Open();
					using(SQLiteCommand komanda = dba.CreateCommand()){
						komanda.CommandText = @"DELETE FROM odgovorim WHERE pitanje = '"+textBox5.Text+"'";
						SQLiteDataReader r = komanda.ExecuteReader();
					}
					dba.Close();
				}
				catch{
					MessageBox.Show("Pitanje sa tim ID ne postoji !");
				}
			}
			else if(resursi.GetKategorija()+"" == "2"){
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"DELETE FROM Opste WHERE ID = '"+textBox5.Text+"'";
						SQLiteDataReader r = komanda.ExecuteReader();
					}
					db.Close();
					SQLiteConnection dba = new SQLiteConnection("Data Source=baza.db;Version=3;");
					dba.Open();
					using(SQLiteCommand komanda = dba.CreateCommand()){
						komanda.CommandText = @"DELETE FROM odgovorio WHERE pitanje = '"+textBox5.Text+"'";
						SQLiteDataReader r = komanda.ExecuteReader();
					}
					dba.Close();
				}
				catch{
					MessageBox.Show("Pitanje sa tim ID ne postoji !");
				}
			}
			else if(resursi.GetKategorija()+"" == "3"){
				try{
					SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
					db.Open();
					using(SQLiteCommand komanda = db.CreateCommand()){
						komanda.CommandText = @"DELETE FROM Racunari WHERE ID = '"+textBox5.Text+"'";
						SQLiteDataReader r = komanda.ExecuteReader();
					}
					db.Close();
					SQLiteConnection dba = new SQLiteConnection("Data Source=baza.db;Version=3;");
					dba.Open();
					using(SQLiteCommand komanda = dba.CreateCommand()){
						komanda.CommandText = @"DELETE FROM odgovorir WHERE pitanje = '"+textBox5.Text+"'";
						SQLiteDataReader r = komanda.ExecuteReader();
					}
					dba.Close();
				}
				catch{
					MessageBox.Show("Pitanje sa tim ID ne postoji !");
				}
			}
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Ppitanja pp = new Ppitanja();
			pp.Show();
		}
	}
}
