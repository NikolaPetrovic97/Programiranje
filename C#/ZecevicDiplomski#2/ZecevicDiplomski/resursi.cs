/*
 * Created by SharpDevelop.
 * User: Zeka
 * Date: 9/7/2018
 * Time: 7:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ZecevicDiplomski
{
	/// <summary>
	/// Description of resursi.
	/// </summary>
	public class resursi
	{
		public static string Moguca;
		public static string Ime;
		public static int Admin;
		public static int Pitanje;
		public static string Lista;
		public static int Odgovor;
		public static int Uod;
		public static int BrP;
		public static int Kategorija;
		public static int Put;
		public static void SetMoguca(String moguca){
			Moguca = moguca;
		}
		public static string GetMoguca(){
			return Moguca;
		}
		public static void SetPut(int put){
			Put = put;
		}
		public static int GetPut(){
			return Put;
		}
		public static void SetKategorija(int kategorija){
			Kategorija = kategorija;
		}
		public static int GetKategorija(){
			return Kategorija;
		}
		public static void SetBrP(int brp){
			BrP = brp;
		}
		public static int GetBrP(){
			return BrP;
		}
		public static void SetUod(int uod){
			Uod = uod;
		}
		public static int GetUod(){
			return Uod;
		}
		public static void SetOdgovor(int odgovor){
			Odgovor = odgovor;
		}
		public static int GetOdgovor(){
			return Odgovor;
		}
		public static void SetLista(String lista){
			Lista = lista;
		}
		public static string GetLista(){
			return Lista;
		}
		public static void SetIme(String ime){
			Ime = ime;
		}
		public static string GetIme(){
			return Ime;
		}
		public static void SetAdmin(int admin){
			Admin = admin;
		}
		public static int GetAdmin(){
			return Admin;
		}
		
        public static void SetPitanje(int pitanje){
			
        	Pitanje = pitanje;
		}
		public static int GetPitanje(){
			return Pitanje;
		}
	}
}
