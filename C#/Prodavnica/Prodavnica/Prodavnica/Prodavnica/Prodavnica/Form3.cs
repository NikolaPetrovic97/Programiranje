using System;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Prodavnica
{
	
	public partial class Form3 : Form
	{
		public Form3()
		{
			
			InitializeComponent();
			
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			konekcija.Open();
			
			dataGridView1.Columns.Add("SifraArtikla", "Sifra artikla");
			dataGridView1.Columns.Add("NazivArtikla", "Naziv artikla");
			dataGridView1.Columns.Add("CenaArtikla", "Cena artikla");
			dataGridView1.Columns.Add("Kolicina", "Kolicina");
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
				
					String s1 = r.GetValue(0) + "";
					String s2 = r.GetValue(1) + "";
					dataGridView1.Rows.Add(new object[]{
					                       	r.GetValue(0),
					                       	r.GetValue(1),
					                       	r.GetValue(2),
					                       	r.GetValue(3),
					                       	
					                       });
				}
			}
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		//int Provera()
		//{
			
		//SQLiteConnection konekcija4;
		//	konekcija4 = new SQLiteConnection("Data Source = Baza.db; Version = 3");
		//	konekcija4.Open();
			
			
			
		//	using(SQLiteCommand komanda = konekcija4. CreateCommand()){
		//		komanda.CommandText = @"SELECT Kolicina FROM Artikli where Sifra_artikla = '" + textBox2.Text + "'";
		//		SQLiteDataReader r = komanda.ExecuteReader();
		//		while(r.Read()){
		//			int k = int.Parse(r.GetValue(0)+"");
		//			konekcija4.Close();
		//			return k;
		//		}
		//		konekcija4.Close();
		//		return 0;
		//	}
			
		//}
		void Button2Click(object sender, EventArgs e)
		{
		SQLiteConnection konekcija;
			konekcija = new SQLiteConnection("Data Source = Baza.db; Version = 3");
			konekcija.Open();
			
			
			using(SQLiteCommand komanda = konekcija. CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli where Sifra_artikla = '" + textBox2.Text + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					textBox1.Text = r.GetValue(1) + "";


		}
	}
}
		void Button1Click(object sender, EventArgs e)
		{
			SQLiteConnection konekcija;
			konekcija = new SQLiteConnection ("Data Source =Baza.db; Version = 3");
			konekcija.Open();
			RadioButton rb = (RadioButton) this.Controls["radioButton1"];
			if(radioButton1.Checked == true)
			{
				String zaduzi = "update Artikli set Kolicina = Kolicina + '"+textBox3.Text+"'  where Sifra_artikla = '" + textBox2.Text + "'";
			
				SQLiteCommand komanda = new SQLiteCommand(zaduzi, konekcija);
				komanda.ExecuteNonQuery();
			}
			RadioButton rb1 = (RadioButton) this.Controls["radioButton2"];
			if(radioButton2.Checked == true)
			{
				String razaduzi = "update Artikli set Kolicina = Kolicina- '"+textBox3.Text+"' where Sifra_artikla = '" + textBox2.Text + "'";
			
				SQLiteCommand komanda1 = new SQLiteCommand(razaduzi, konekcija);
				komanda1.ExecuteNonQuery();
			}
			RadioButton rb2 = (RadioButton) this.Controls["radioButton3"];
			
			if(radioButton3.Checked == true){
				String prodaj = "update Artikli set Kolicina = Kolicina- '"+textBox3.Text+"' where Sifra_artikla = '" + textBox2.Text + "'";
				//if(Provera() >= int.Parse(textBox3.Text)){
					SQLiteCommand komanda2 = new SQLiteCommand(prodaj, konekcija);
					komanda2.ExecuteNonQuery();
			//}
			}
			
			while(dataGridView1.Rows.Count-1>0) dataGridView1.Rows.RemoveAt(0);
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT * FROM Artikli";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
				
					String s1 = r.GetValue(0) + "";
					String s2 = r.GetValue(1) + "";
					dataGridView1.Rows.Add(new object[]{
					                       	r.GetValue(0),
					                       	r.GetValue(1),
					                       	r.GetValue(2),
					                       	r.GetValue(3),
					                       });
				}
			}
		}
		
		
		
}
}
