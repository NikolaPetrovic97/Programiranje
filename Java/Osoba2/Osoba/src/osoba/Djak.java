/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package osoba;

public class Djak extends Osoba
{
    String naziv_skole;
    int razred;
    double prosecna_ocena;

    @Override
    void markica() 
    {
        System.out.println("Plava makica");
    }

    
    static prosecna_ocena() 
    {
        System.out.println(prosecna_ocena);
    }
    
    @Override
    public String toString() 
    {
        String s=super.toString()+ " ";
        s+=String.format("%s, (%s), -%s)", naziv_skole, razred, prosecna_ocena);
        return s;
    }
}
