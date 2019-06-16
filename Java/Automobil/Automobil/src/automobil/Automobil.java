/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package automobil;


import java.util.Scanner;


class Automobil 
{
    String marka;
    String model;
    int kubikaza;
    int godina_proizvodnje;
    
    public Automobil(String marka, String model, int kubikaza, int godina_proizvodnje) 
        {
            this.marka = marka;
            this.model = model;
            this.kubikaza = kubikaza;
            this.godina_proizvodnje = godina_proizvodnje;
        }
        
        public Automobil() 
        {
            Scanner in=new Scanner(System.in);
            
            System.out.println("Unesi marku: ");
            String ma=in.nextLine();
            this.marka=ma;
            
            System.out.println("Unesi model: ");
            String mo=in.nextLine();
            this.model=mo;
            
            System.out.println("Unesi kubikazu: ");
            int kub=in.nextInt();
            this.kubikaza=kub;
            
            System.out.println("Unesi godinu proizvodnje: ");
            int god_proizvodnje=in.nextInt();
            this.godina_proizvodnje=god_proizvodnje;
        }

        
    @Override
    public String toString() 
    {
        return "Automobil-->" + "marke: " + marka + ", model: " + model + ", kubikaza: " + kubikaza + ", (" + godina_proizvodnje + ')';
    }
    
    void Porez(double kvota)
    {
        System.out.println(kvota*this.kubikaza);
    }
    
    public static void main(String[] args)
    {
        Automobil a1=new Automobil();
        Automobil a2=new Automobil("BMW", "X6", 3000, 2016);
        
        System.out.println(a1);
        System.out.println(a2);
        
        a1.Porez(5.5);
        a2.Porez(5.5);
    } 

   
}
