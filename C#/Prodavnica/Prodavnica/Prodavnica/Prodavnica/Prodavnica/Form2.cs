using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Prodavnica
{
	
	public partial class Form2 : Form
	{
		public Form2()
		{
			
			InitializeComponent();
			
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			konekcija.Open();
			
			
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox2.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox1.Text = r.GetValue(1) + "";
					textBox11.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox4.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox3.Text = r.GetValue(1) + "";
					textBox12.Text = r.GetValue(2) + "";
				
					
				
				
				}
				}
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox6.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox5.Text = r.GetValue(1) + "";
					textBox13.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox8.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox7.Text = r.GetValue(1) + "";
					textBox14.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox9.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox10.Text = r.GetValue(1) + "";
					textBox15.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			Int32 val1 = Convert.ToInt32(textBox17.Text);
            Int32 val2 = Convert.ToInt32(textBox18.Text);
            Int32 val3 = Convert.ToInt32(textBox19.Text);
			Int32 val4 = Convert.ToInt32(textBox11.Text);
            Int32 val5 = Convert.ToInt32(textBox12.Text);
            Int32 val6 = Convert.ToInt32(textBox13.Text);
            Int32 val7 = Convert.ToInt32(textBox14.Text);
            Int32 val8 = Convert.ToInt32(textBox15.Text);
            Int32 val9 = Convert.ToInt32(textBox20.Text);
            Int32 val10 = Convert.ToInt32(textBox21.Text);
            Int32 val11 = val4 * val1 + val5*val2 + val6*val3 + val7*val9 +val8*val10;
            textBox16.Text = val11.ToString();
		}
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text="";
          	textBox2.Text="";
          	textBox3.Text="";
          	textBox4.Text="";
          	textBox5.Text="";
          	textBox6.Text="";
          	textBox7.Text="";
          	textBox8.Text="";
          	textBox9.Text="";
          	textBox10.Text="";
          	textBox11.Text="";
          	textBox12.Text="";
          	textBox13.Text="";
          	textBox14.Text="";
          	textBox15.Text="";
          	textBox16.Text="";
          	textBox17.Text="";
          	textBox18.Text="";
          	textBox19.Text="";
          	textBox20.Text="";
          	textBox21.Text="";
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			konekcija.Open();
			
			
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox2.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox1.Text = r.GetValue(1) + "";
					textBox11.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			konekcija.Open();
			
			
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox4.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox3.Text = r.GetValue(1) + "";
					textBox12.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
		}
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			konekcija.Open();
			
			
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox6.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox5.Text = r.GetValue(1) + "";
					textBox13.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
		}
		void TextBox8TextChanged(object sender, EventArgs e)
		{
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			konekcija.Open();
			
			
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox8.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox7.Text = r.GetValue(1) + "";
					textBox14.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
		}
		void TextBox9TextChanged(object sender, EventArgs e)
		{
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			konekcija.Open();
			
			
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox9.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox10.Text = r.GetValue(1) + "";
					textBox15.Text = r.GetValue(2) + "";
					
					
				
				
				}
				}
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		
		
	}
}
