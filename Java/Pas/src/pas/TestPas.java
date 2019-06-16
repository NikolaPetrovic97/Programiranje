/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pas;

/**
 *
 * @author student
 */
   
    class TestPas
    {
        public static void main(String[] args) 
        {
            Pas p1=new Pas();
            Pas p2=new Pas();
            Pas p3=new Pas();
            
            p1.RasaPsa="Maltezer";
            p1.cena=500;
            
            p2.RasaPsa="Zlatni retriver";
            p2.cena=1000;
             
            p3.RasaPsa="Vucjak";
            p3.cena=2000;
                    
            System.out.println(p1.RasaPsa);
            System.out.println(p1.cena);
                    
            System.out.println(p2.RasaPsa);
            System.out.println(p2.cena);
                    
            System.out.println(p3.RasaPsa);
            System.out.println(p3.cena);  
                   
           
         }
    
}
