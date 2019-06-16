/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package automobil;

/**
 *
 * @author student
 */
class TestAutomobil 
{
    public static void main(String[] args)
    {
        Automobil a1=new Automobil();
        Automobil a2=new Automobil();
        Automobil a3=new Automobil();
        
        a1.MarkaAutomobila="Audi";
        a1.cena=2500;
        a1.GodinaProizvodnje=2006;
        
        System.out.println(a1.MarkaAutomobila);
        System.out.println(a1.cena);
        System.out.println(a1.GodinaProizvodnje);
        
        a2.MarkaAutomobila="BMW";
        a2.cena=3500;
        a2.GodinaProizvodnje=2008;
        
        System.out.println(a2.MarkaAutomobila);
        System.out.println(a2.cena);
        System.out.println(a2.GodinaProizvodnje);
        
        a3.MarkaAutomobila="Mercedes";
        a3.cena=4500;
        a3.GodinaProizvodnje=2010;
        
        System.out.println(a3.MarkaAutomobila);
        System.out.println(a3.cena);
        System.out.println(a3.GodinaProizvodnje);
        
        a4.UnesiNovAuto("Opel", 2000, 2001);
        
        System.out.println(a4.MarkaAutomobila);
        System.out.println(a4.cena);
        System.out.println(a4.GodinaProizvodnje);
    }
    
}
