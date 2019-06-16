package test;

import java.util.Scanner;


public class Test 
{

    
    public static void main(String[] args) 
    {
        Student s1=new Student("Nikola Petrovic", 2, 6.5);
        
        int ocena=0;
        Scanner s=new Scanner(System.in);
        
        while(ocena==0)
        {
            try
            {

            System.out.println("Ocena: ");
            ocena=s.nextInt();
            }
            catch(Exception e)
            {
                 System.out.println("Greska pri unosu");
                 s.next();
            }
        }    
            
        Predmet p1=new Predmet("Programiranje1", "dr Miroslav Markovic", ocena);
        
        ocena=0;
        
        while(ocena==0)
        {
            try
            {
                System.out.println("Ocena: ");
                ocena=s.nextInt();
            }
            catch(Exception e)
            {
                 System.out.println("Greska pri unosu");
                 s.next();
            }
        }
         
        Predmet p2=new Predmet("Programiranje2", "Tijana Matejic", ocena);
        
        s1.dodaj_predmet(p1);
        s1.dodaj_predmet(p2);
        
        s1.prosecna_ocena();
        
        System.out.println(s1);
    }
    
}
