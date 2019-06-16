/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package testautomat;

/**
 *
 * @author student
 */

class AutomatNovca 
{

    double stanje=5000.00;
    
    void ulozi_novac(double iznos)
    {
        stanje=stanje+iznos;
    }
    
    void podigni_novac(double iznos)
    {
        if(iznos>stanje)
        {
            System.out.println("Nemate dovoljno novca na racunu.");
        }
        else
        {
            stanje=stanje-iznos;
        }
        
    }
    
  
    void ispisi_stanje()
    {
        System.out.println("Na racunu trenutno imate: " +stanje);
    }

}

public class TestAutomat 
{
   
    public static void main(String[] args) 
    {
        AutomatNovca a=new AutomatNovca();
        
        a.ulozi_novac(3000.00);
        a.podigni_novac(5000.00);
        a.ispisi_stanje();
    }
    
}
