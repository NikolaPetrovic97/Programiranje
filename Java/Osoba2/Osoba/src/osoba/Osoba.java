/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package osoba;


public abstract class Osoba
{
    
    String ime;
    String prezime;
    String datum_rodjenja;
    String adresa_stanovanja;
    
    abstract void markica();
    
    @Override
    public String toString()
    {
        String s=String.format("%s (%s) - %s (%s)", ime, prezime, datum_rodjenja, adresa_stanovanja);
        return s;
    }

    public Osoba(String ime, String prezime, String datum_rodjenja, String adresa_stanovanja) {
        this.ime = ime;
        this.prezime = prezime;
        this.datum_rodjenja = datum_rodjenja;
        this.adresa_stanovanja = adresa_stanovanja;
    }
    
    
    
}
