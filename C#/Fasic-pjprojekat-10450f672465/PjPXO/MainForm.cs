
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace PjPXO
{
	public partial class MainForm : Form
	{
		int[][] matrica = new int[3][];
		int koIgra;
		int prethodnoPrvi;
		public int xR, oR;
		String n1, n2;
		
		
		public MainForm(String s1, String s2)
		{
			InitializeComponent();
			n1 = s1;
			n2 = s2;
			prethodnoPrvi = 1;
			restart();
			xR = oR = 0;
			ispisRezultata();
		}
		
	
		//Ispis rezultata u 2 lable-a
			
		void Click(object sender, EventArgs e)
		{
			Button b = (Button) sender;
			int x = int.Parse(b.Name.Substring(1,1));
			int i = (int) (x-1) / 3;
			int j = x - (i*3) - 1;
		
			
			if(matrica[i][j] == 0){
				matrica[i][j] = koIgra%2 + 1;
				if(koIgra % 2 == 0){
					b.Text = "X";
					if(Pobeda()){
						MessageBox.Show(n1 + " je pobedio");
						xR++;
						ispisRezultata();
						restart();
						return;
					}
				}
				else{
					b.Text = "O";
					if(Pobeda()){
						MessageBox.Show(n2 + " je pobedio");
						oR++;
						ispisRezultata();
						restart();
						return;
					}
					
				}
				koIgra ++; 
			}
			
		}
		
		bool Pobeda(){
			int ko = koIgra%2 + 1;
			int red, kol;
			int d1, d2;
			d1 = d2 = 0;

			for(int i = 0; i < 3; i++){
				kol = red = 0;
				for(int j = 0; j < 3; j++){
					if(matrica[i][j] == ko) red++;
					if(matrica[j][i] == ko) kol++;
				}
				if(red == 3 || kol == 3) return true;
				
				if(matrica[i][i] == ko) d1++;
				if(matrica[i][2-i] == ko) d2++;
			}
			if(d1 == 3 || d2 == 3) return true;
			return false;
		}
		
		void restart(){
			for (int k = 0; k < 3; k++){
				matrica[k] = new int[3] {0,0,0};
			}
			foreach (var control in this.Controls){
				if (control.GetType() == typeof(Button)){
				   Button q = (Button) control;
				   q.Text = "";
				}
			}
			
			koIgra = prethodnoPrvi + 1;
			prethodnoPrvi = koIgra;
		}
		
		void ispisRezultata(){
			nick1.Text = n1;
			nick2.Text = n2;
			xRezultat.Text = "" + xR;
			oRezultat.Text = "" + oR;
		}
	
	}
}
