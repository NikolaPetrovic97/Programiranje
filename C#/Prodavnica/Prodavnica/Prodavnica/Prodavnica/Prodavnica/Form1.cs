using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Prodavnica
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			
			InitializeComponent();
		}
			void Button1Click(object sender, EventArgs e)
		{
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			//konekcija.Open();
			//using(SQLiteCommand komanda = konekcija. CreateCommand()){
			//	komanda.CommandText = @"UPDATE Artikli SET Cena_artikla = '"+textBox5.Text+"'  WHERE Sifra_artikla = '" + textBox2.Text + "'";
			//	SQLiteDataReader r = komanda.ExecuteReader();
			//	konekcija.Close();
			//	}
				konekcija.Open();
				using(SQLiteCommand komanda = konekcija. CreateCommand()){
					komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox2.Text + "'";
				
				SQLiteDataReader s = komanda.ExecuteReader();
				while(s.Read()){
					textBox1.Text = s.GetValue(1) + "";
					textBox3.Text = s.GetValue(3) + "";
					textBox4.Text = s.GetValue(2) + "";
				
				
				}
				
				}
			
			
			
		}
		void Form1Load(object sender, EventArgs e)
		{
		
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
		//	SQLiteConnection konekcija;
		//	konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
		//	konekcija.Open();
		//	
		//	
		//	using(SQLiteCommand komanda = konekcija. CreateCommand()){
		//		komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox2.Text + "'";
		//		SQLiteDataReader r = komanda.ExecuteReader();
		//		while(r.Read()){
		//			textBox1.Text = r.GetValue(1) + "";
		//			textBox3.Text = r.GetValue(3) + "";
		//			textBox4.Text = r.GetValue(2) + "";
		//		
		//		
		//		}
		//		}
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		
	}
}
