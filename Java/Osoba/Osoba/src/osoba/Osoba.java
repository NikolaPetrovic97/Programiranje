/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package osoba;

/**
 *
 * @author student
 */
public class Osoba
{
   
    String ime;
    String prezime;
    int GodinaRodjenja;
    double kilaza;
    double visina;
    boolean BracnoStanje;
    
    void porastao(int x)
    {
        visina+=x;
    }

    public Osoba(String ime, String prezime, int GodinaRodjenja, double kilaza, double visina, boolean BracnoStanje) {
        this.ime = ime;
        this.prezime = prezime;
        this.GodinaRodjenja = GodinaRodjenja;
        this.kilaza = kilaza;
        this.visina = visina;
        this.BracnoStanje = BracnoStanje;
    }
    
    
 public static void main(String[] args) 
 {
     Osoba o1=new Osoba("Nikola", "Simonovic", 1996, 80, 190, true);
     
     System.out.println(o1);
 }
    
    
    
}
