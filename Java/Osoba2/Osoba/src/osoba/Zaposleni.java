/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package osoba;


public class Zaposleni extends Osoba
{
    String naziv_firme;
    String naziv_odeljenja;
    double mesecna_plata;

    @Override
    void markica() 
    {
        System.out.println("Crvena makica");
    }

    
    static prosecna_ocena() 
    {
        System.out.println(mesecna_plata);
    }
    
    
    @Override
    public String toString() 
    {
        String s=super.toString()+ " ";
        s+=String.format("%s, (%s), -s,)", naziv_firme, naziv_odeljenja, mesecna_plata);
        return s;
    }
    
}
