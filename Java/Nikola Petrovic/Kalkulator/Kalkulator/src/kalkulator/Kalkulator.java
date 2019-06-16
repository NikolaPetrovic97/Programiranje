/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kalkulator;

/**
 *
 * @author student
 */
public class Kalkulator 
{
   
    static int suma(int n)
    {
       int sum=0;
       for(int i=0; i<=n; i++) 
       {
           sum=sum+i;
       }
       return sum;
    }
    
    static int suma2(int n)
    {
        int s=0;
        for(int i=0; i<=n; i++)
        {
            s=s*i;
        }
        return s;
    }
    
    static int suma_celih_brojeva(int a, int b)
    {
       int scb=0;
       for(int i=a; i<=b; i++)
       {
         scb=scb+i;  
       }
       return scb;
       
    }
    
    static int suma_parnih_borjeva(int a, int b)
    {
        int spb=0;
        for(int i=a; i<=b; i++)
        {
            if(i%2==0)
            {
                spb=spb+i;
            }
        } 
         return spb;          
        
    }
    
    static int suma_neparnih_borjeva(int a, int b)
    {
        int snb=0;
        for(int i=a; i<=b; i++)
        {
            if(i%2!=0)
            {
                snb=snb+i;
            }
        } 
         return snb;  
        
    }
    
    static int faktorijel(int n)
    {
        int f=0;
        for(int i=0; i<n; i++)
        {
            f=f*i;
        }
        
        return f;
    }   
    
    
    
    public static void main(String[] args)
    {
       
        
    }
    
}
