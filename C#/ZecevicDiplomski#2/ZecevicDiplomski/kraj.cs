/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/3/2018
 * Time: 2:53 PM
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
	/// Description of kraj.
	/// </summary>
	public partial class kraj : Form
	{
		public kraj()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			label2.Text = Bodovi();
			label3.Text = Polozio();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		String Bodovi(){
			SQLiteConnection db = new SQLiteConnection("Data Source=baza.db;Version=3;");
			db.Open();
			String ime = resursi.GetIme()+"";
			int put = int.Parse(resursi.GetPut()+"");
			String datum = DateTime.Today+"";
			using(SQLiteCommand komanda = db.CreateCommand()){
				
				komanda.CommandText = @"SELECT poeni FROM bodovi WHERE user = '"+ime+"' AND Pokusaj = '"+ put +"' AND datum = '"+datum+"'";
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
		String Polozio(){
			int brp = resursi.GetBrP();
			int rez = int.Parse(Bodovi()+"");
			if((brp*3)/2 <= rez){
				return "Polozili ste";
			}
			else{
				return "niste polozili";
			}
		}
	}
}
