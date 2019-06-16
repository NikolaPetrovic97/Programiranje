/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nizbrojeva;



class TestBrojeva 
{

    public static void main(String[] args) 
    {
       NizBrojeva n=new NizBrojeva();
       
     n.dodavanje_elemenata(10);
     n.dodavanje_elemenata(10);
     n.dodavanje_elemenata(10);
     n.dodavanje_elemenata(10);
     n.dodavanje_elemenata(10);
     n.dodavanje_elemenata(10);
     
     n.ispisi_element(3);
     n.ispisi_niz();
     
     System.out.println(n.suma_niza);
     System.out.println(n.proizvod_niza);
     System.out.println(n.max);
     
    
       
    }
    
}
