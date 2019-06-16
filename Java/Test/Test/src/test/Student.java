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
public class Student 
{
    String ime;
    int godina_studija;
    double prosecna_ocena;
    
    private int brojac=0;
    
    private Predmet[] predmeti=new Predmet[20];

    public Student() 
    {
        for(int i=0; i<brojac; i++)
        {
            predmeti[i]=new Predmet();
        }
    }

    public Student(String ime, int godina_studija, double prosecna_ocena) 
    {
        this();
        this.ime = ime;
        this.godina_studija = godina_studija;
        this.prosecna_ocena = prosecna_ocena;
    }
    
    
   @Override
   public String toString()
   {
       String s=ime+ "(" +godina_studija +")-"+ prosecna_ocena +"\n";
       s+="------------------------------------------------------------------------------\n";
       for(int i=0; i<brojac; i++)
       {
           s+=predmeti[i].toString()+ "\n";
       }
       return s;
   }
   
   public void dodaj_predmet(Predmet p)
   {
       predmeti[brojac]=p;
       brojac++;
   }
   
   public void prosecna_ocena()
   {
       double suma=0;
       for(int i=0; i<brojac; i++)
       {
           suma+=predmeti[i].ocena;
       }
       prosecna_ocena=suma/brojac;
   }
    
   
}
