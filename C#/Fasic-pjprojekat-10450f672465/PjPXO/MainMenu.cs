using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace PjPXO
{
	public partial class MainMenu : Form
	{
		//Unos imena pod kojim igrac igra i preneos u narednu formu, i vracanje rezultata nazad
		public MainMenu()
		{
			InitializeComponent();
			DrawTable();
            
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm m = new MainForm(nickName1.Text, nickName2.Text);
			
			CheckUser(nickName1.Text);
			CheckUser(nickName2.Text);
			
			this.Hide();
			m.ShowDialog();
			
			UpdateScore(nickName1.Text, m.xR);	
			UpdateScore(nickName2.Text, m.oR);
			DrawTable();
		
			this.Show();
		}
		
		void UpdateScore(String name, int bodovi){
			using(SQLiteConnection x = new SQLiteConnection("Data Source=Baza.db;Version=3;")){
				x.Open();
				string sql = "UPDATE User SET Bodovi = Bodovi + "+bodovi+" " +
					"WHERE Username = '" + name + "'";
				 SQLiteCommand command = new SQLiteCommand(sql, x);
	            command.ExecuteNonQuery();
	            x.Close();
			}
			
		}
		
		void CheckUser(String ime){
			using(SQLiteConnection x = new SQLiteConnection("Data Source=Baza.db;Version=3;")){
				x.Open();
            
	            int brojUsera = 0;
	            
	            string sql = "select * from User WHERE Username = '" + ime + "'";
	            using(SQLiteCommand command = new SQLiteCommand(sql, x)){
	            	using(SQLiteDataReader reader = command.ExecuteReader()){
	            	while (reader.Read())
	            		brojUsera++;
	            	}
	            }	
	            
	            if(brojUsera == 0){
	            	sql = "insert into User (Username, Bodovi) values ('" + ime + "', 0)";
	            	using(SQLiteCommand command = new SQLiteCommand(sql, x)){
	            		command.ExecuteNonQuery();
	            	}
	            }
			}
		}	
		
		void DrawTable(){
			using(SQLiteConnection x = new SQLiteConnection("Data Source=Baza.db;Version=3;")){
				x.Open();
	            string sql = "select * from User";
	            using(SQLiteCommand command = new SQLiteCommand(sql, x)){
	            	using(SQLiteDataReader reader = command.ExecuteReader()){
	            		if (reader.HasRows){
			                DataTable dt = new DataTable();
			                dt.Load(reader);
			                dataSql.DataSource = dt;
	            		}
	               	}
	            }
			}
		}
	
		
	}
}