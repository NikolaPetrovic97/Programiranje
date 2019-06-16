/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package televizor;

/**
 *
 * @author student
 */
public class Televizor
{
    int jacina_tona;
    int trenutni_program;
    boolean ukljucen;

    public Televizor()
    {
        this.jacina_tona=10;
        this.trenutni_program=1;
        this.ukljucen=false;
    }

    public Televizor(int jacina_tona, int trenutni_program, boolean ukljucen) 
    {
        this.jacina_tona = jacina_tona;
        this.trenutni_program = trenutni_program;
        this.ukljucen = ukljucen;
    }
    
   
    
    public void ispis()
    {
        System.out.println("--------------------------------------------");
         if(ukljucen==true)
         {
            System.out.println("Program: "+ trenutni_program);
            System.out.println("Zvuk: "+ jacina_tona); 
         }
         
         else
         {
             System.out.println("TV je iskljucen");
         }
         
         System.out.println("--------------------------------------------");
    
        
        System.out.println("Trenutni program: "+ trenutni_program);
        System.out.println("Jacina tona: "+ jacina_tona);
        System.out.println("Ukljucen: "+ ukljucen);
    }
    
    public void ukljuci()
    {
        this.ukljucen=true;
    }
   
     public void iskljuci()
    {
        this.ukljucen=false;
    }
   
    public void pojacaj_ton()
    {
        this.jacina_tona ++;
    }
    
    
    public void smanji_ton()
    {
        this.jacina_tona --;
    }
    
    public void iskljuci_ton()
    {
        this.jacina_tona=0;
    }
    
    public void promeni_program_napred()
    {
        this.trenutni_program ++;
    }
    
    public void promeni_program_nazad()
    {
        this.trenutni_program --;
    }
    
    
    public int vrati_ton()
    {
        return jacina_tona;
    }
    
    public int vrati_program()
    {
        return trenutni_program;
    }
    
    public boolean vrati_ukljucen_iskljucen()
    {
        return ukljucen;
    }
    
    public static void main(String[] args)
    {
        Televizor t1=new Televizor();
        Televizor t2=new Televizor(20, 15, true);
        Televizor t3=new Televizor();
        
        t1.ispis();
        t2.ispis();
        
        t3.ispis();
        t3.ukljuci();
        t3.ispis();
        t3.pojacaj_ton();
        t3.pojacaj_ton();
        t3.pojacaj_ton();
        t3.pojacaj_ton();
        t3.ispis();
        t3.iskljuci_ton();
        t3.ispis();
        t3.promeni_program_napred();
        t3.promeni_program_napred();
        t3.promeni_program_napred();
        t3.ispis();
        t3.iskljuci();
        t3.ispis();
        
    }
    
}
