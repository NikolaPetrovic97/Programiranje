/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package predavanje5;


import java.util.Scanner;


public class Predavanje5 
{

    
    
    public static void main(String[] args) 
    {
        Scanner in=new Scanner(System.in);
        System.out.print("Unesi poruku: ");
        String s=in.nextLine();
        System.out.println(s);
        
        System.out.print("Unesi broj: ");
        int i=in.nextInt();
        System.out.print("Unesi broj: ");
        int j=in.nextInt();
        System.out.println(i*j);
        
        System.out.print("Unesi a: ");
        double a=in.nextDouble();
        System.out.print("Unesi b: ");
        double b=in.nextDouble();
        
        double stranica=b-a;
        System.out.print("Stranica= ");
        System.out.println(stranica);
       
        double pola=stranica/2;
        
        double h=Math.sqrt(stranica*stranica - pola*pola);
        System.out.println("Visina je: " +h);
                
         
       
        
        
    }
    
}
