/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package automatnovca;

/**
 *
 * @author student
 */
public class AutomatNovca
{
    double stanje=10000.00;
    
    void podigni_iznos(double iznos)
    {
        stanje=stanje-iznos;
    }
    
    void ulozi_iznos(double iznos)
    {
        stanje=stanje+iznos;
    }
    
    double vrati_stanje()
    {
        return stanje;
    }
    
    void ispisi_stanje()
    {
        System.out.println("Trenuto stanje na racunu je :" +stanje);
    }
    
    
    
    public static void main(String[] args)
    {
        
        
    }
    
}
