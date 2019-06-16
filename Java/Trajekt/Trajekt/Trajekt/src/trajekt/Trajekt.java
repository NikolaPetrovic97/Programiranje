/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package trajekt;

/**
 *
 * @author student
 */
public class Trajekt 
{
    boolean[] sedista_i_mesta;
    
    int ukupan_broj_sedista;
    int ukupan_broj_mesta_za_automobile;

    public Trajekt(int broj_sedista, int broj_mesta_za_automobile) 
    {
        if(broj_sedista<0 || broj_mesta_za_automobile<0)
        {
            ukupan_broj_sedista=60;
            sedista_i_mesta=new boolean[120];
            System.out.println("Greska pri unosu");
        }
        
        else
        {
            ukupan_broj_sedista=broj_sedista;
            sedista_i_mesta=new boolean[broj_sedista+broj_mesta_za_automobile];
        }
        
        for(int i=0; i<sedista_i_mesta.length; i++)
        {
          sedista_i_mesta[i]=true;  
        }
    }
    
    
    void uvedi_auto(int redni_broj_mesta)
    {
        if(sedista_i_mesta[ukupan_broj_sedista + redni_broj_mesta-1]==true)
        {
            sedista_i_mesta[ukupan_broj_sedista + redni_broj_mesta-1]=false;
        }
        
        else
        {
            if(ukupan_broj_sedista + redni_broj_mesta-1<sedista_i_mesta.length-1 && sedista_i_mesta[ukupan_broj_sedista + redni_broj_mesta]==true)
            {
                System.out.println("Mesto je zauzeto");
            }    
            
            else
            {
                System.out.println("Greska");
            }    
        }
    }
    
    boolean ima_li_ima_mesta_na_trajektu_za_autobus()
    {
        for(int i=ukupan_broj_sedista; i<sedista_i_mesta.length-3; i++)
        
        if(sedista_i_mesta[i]==true && sedista_i_mesta[i+1]==true && sedista_i_mesta[i+2]==true && sedista_i_mesta[i+3]==true)
        {
            return true;  
        }  
     return false;
    }
}  
    
    
    
    
    
   class TestTrajekt
   {
        public static void main(String[] args) 
        {
            Trajekt t1=new Trajekt(120, 50);
            Trajekt t2=new Trajekt(70, 40);
            Trajekt t3=new Trajekt(80, 10);
            
            if(t3.ima_li_ima_mesta_na_trajektu_za_autobus())
            {
                System.out.println("U trecem trajektu ima mesta za autobus");
            }
            else
            {
                System.out.println("U trecem trajektu nema mesta za autobus");
            }
        }
   }    
    

    
