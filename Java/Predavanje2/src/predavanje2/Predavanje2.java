/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package predavanje2;

/**
 *
 * @author student
 */
public class Predavanje2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        int a=10;
        
        if(a<10)
        {
            System.out.println("Manje od 10");
        }
        
        else if(a>10)
        {
            System.out.println("Vece od 10");
        }
        
        else
        {
            System.out.println("10 je");
        }
        
        double DuzinaStranice=6;
        
        double pola= DuzinaStranice/2;
        
        double h2=DuzinaStranice * DuzinaStranice - pola * pola;
        
        double h=Math.sqrt(h2);
        
        System.err.println(h);
        
        
        int xa=1;
        int xb=3;
        int ya=7;
        int yb=6; 
           
        int x=xb-xa;
        int y=yb-ya;
        
        int x2=x*x;
        int y2=y*y;
        
        double ab=Math.sqrt(x2+y2);
        
        System.out.println(ab);
        
        
        int ocena=6;
        
          
        if(ocena <11 && ocena>5)
        {
            System.out.println("Fakultet:" + ocena);
        }
        
        else
        {
            switch(ocena)
            {

                case 1: System.out.println("Nedoovoljan");break;
                case 2: System.out.println("Dovoljan");break;
                case 3: System.out.println("Dobar");break;
                case 4: System.out.println("Vrlo dobar");break;
                case 5: System.out.println("Odlican ili pao");break;
               default: System.out.println("Ocena nije validna");break;
             }
        }
        
        
        for(int i=1; i<100; i++)
        {
            System.out.println(i);
        }
        

        for(int i=-100; i<100; i+=2)
        {
            System.out.println(i);
            if(i==0)
            {
                i++;
            }
        }
        
       
        
        for(int i=0; i<5; i++)
        {
          for(int j=0; j<5; j++)
            {
                System.out.print(1+ " ");
            } 
          System.out.println("");
        }
            
        int r=10;
        
        while(r<10)
        {
            System.out.println(r);
            r--;
        }
       
        do
        {
            System.out.println("nesto");
        } while(r!=10);
}   
    
}