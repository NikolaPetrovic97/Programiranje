/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proveraautomata;

/**
 *
 * @author student
 */
class ProveraAutomata 
{
 
    
    public static void main(String[] args) 
    {
        AutomatNovca a1=new AutomatNovca();
        AutomatNovca a2=new AutomatNovca();
        
        a1.ispisi_stanje();
        a1.ulozi_iznos(5000.00);
        a1.ispisi_stanje();
        a2.podigni_iznos(3500.00);
        a1.ispisi_stanje();
    }
    
}
