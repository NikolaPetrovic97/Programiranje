/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package test;

/**
 *
 * @author student
 */
public class Predmet 
{
    String naziv_predmeta;
    String profesor;
    int ocena;

    public Predmet() 
    {
        
    }

    public Predmet(String naziv_predmeta, String profesor, int ocena) 
    {
        this.naziv_predmeta = naziv_predmeta;
        this.profesor = profesor;
        this.ocena = ocena;
    }
    
    
    @Override
    public String toString()
    {
        return naziv_predmeta +"(" + profesor + ")"+ " " + ocena;
    }
    
    
}
