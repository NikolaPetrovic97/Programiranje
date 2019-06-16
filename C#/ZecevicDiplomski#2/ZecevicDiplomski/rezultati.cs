/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/7/2018
 * Time: 7:38 PM
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
	/// Description of rezultati.
	/// </summary>
	public partial class rezultati : Form
	{
		public rezultati()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();
			
			Baza.Columns.Add("user" , "USER");
			Baza.Columns.Add("poeni" , "POENI");
			Baza.Columns.Add("pokusaj" , "POKUSAJ");
			Baza.Columns.Add("datum" , "DATUM");
			Baza.Columns.Add("kviz" , "KVIZ");
			
			using(SQLiteCommand komanda = db.CreateCommand()){
				komanda.CommandText = @"SELECT * FROM bodovi ORDER BY poeni DESC;";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					Baza.Rows.Add(new object[]{
					              	r.GetValue(1),
					              	r.GetValue(2),
					              	r.GetValue(4),
					              	r.GetValue(3),
					              	r.GetValue(5)
					              });
				}
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
