/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/18/2018
 * Time: 2:31 AM
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
	/// Description of Ppitanja.
	/// </summary>
	public partial class Ppitanja : Form
	{
		public Ppitanja()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			int a = int.Parse(resursi.GetKategorija()+"");
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();
			
			Baza1.Columns.Add("id" , "ID");
			Baza1.Columns.Add("text" , "TEXT");
			Baza1.Columns.Add("kategorija" , "KATEGORIJA");			
			if(a == 1){
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"SELECT * FROM Muzika ORDER BY ID ASC;";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						Baza1.Rows.Add(new object[]{
						              	r.GetValue(0),
						              	r.GetValue(1),
						              	r.GetValue(2)
						              });
					}
				}
			}
			else if(a == 2){
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"SELECT * FROM Opste ORDER BY ID ASC;";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						Baza1.Rows.Add(new object[]{
						              	r.GetValue(0),
						              	r.GetValue(1)
						              	
						              });
					}
				}
			}
			else if(a == 3){
				using(SQLiteCommand komanda = db.CreateCommand()){
					komanda.CommandText = @"SELECT * FROM Racunari ORDER BY ID ASC;";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						Baza1.Rows.Add(new object[]{
						              	r.GetValue(0),
						              	r.GetValue(1)
						              	
						              });
					}
				}
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
