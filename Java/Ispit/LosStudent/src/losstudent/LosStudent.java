/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package losstudent;

/**
 *
 * @author student
 */
public class LosStudent 
{
    String ime;
    String prezime;
    int broj_predmeta_sa_ocenom_sest;
    int broj_ne_polozenih_predmeta;

    public LosStudent(String ime, String prezime) 
    {
        this.ime = ime;
        this.prezime = prezime;
    }

    public LosStudent(String ime, String prezime, int broj_predmeta_sa_ocenom_sest, int broj_ne_polozenih_predmeta) 
    {
        this.ime = ime;
        this.prezime = prezime;
        this.broj_predmeta_sa_ocenom_sest = broj_predmeta_sa_ocenom_sest;
        this.broj_ne_polozenih_predmeta = broj_ne_polozenih_predmeta;
    }
    
    
    @Override
    public String toString()
    {
        String s=String.format("%s (%s) - %s (%s)", ime, prezime, broj_predmeta_sa_ocenom_sest, broj_ne_polozenih_predmeta);
        return s;
    }
    
    void ispis_sestica()
    {
        for(int i=0; i<=broj_predmeta_sa_ocenom_sest; i++)
        {
            System.out.println("6");
        }
    }
    
    
    

    public static void main(String[] args) 
    {
      
    }
    
}
