/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/7/2018
 * Time: 7:44 PM
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

namespace ZecevicDiplomski
{
	/// <summary>
	/// Description of start.
	/// </summary>
	public partial class start : Form
	{
		public start()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		String ime = resursi.GetIme()+"";
		String Provera3(String ime){
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();
			
			using(SQLiteCommand komanda = db.CreateCommand()){
				
				komanda.CommandText = @"SELECT admin FROM user WHERE username = '"+ime+"'";
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
		
		void Button1Click(object sender, EventArgs e)
		{
			Izbor iz = new Izbor();
			iz.Show();
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if(Provera3(ime)+"" == "1"){
				admin a = new admin();
				a.Show();
			}
		}
		
	}
}
