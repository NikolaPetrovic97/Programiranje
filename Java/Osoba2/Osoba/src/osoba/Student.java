/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package osoba;



public class Student extends Osoba
{
    String naziv_fakulteta;
    String naziv_smera;
    int godina_upisa;
    int godina_studija;

    @Override
    void markica() 
    {
        System.out.println("Zelena makica");
    }

   
    static prosecna_ocena() 
    {
        System.out.println(godina_studija);
    }    

    @Override
    public String toString() 
    {
        String s=super.toString()+ " ";
        s+=String.format("%s, (%s), %d, -%d)", naziv_fakulteta, naziv_smera, godina_upisa, godina_studija);
        return s;
    }

    




}

