/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package predavanje3;

/**
 *
 * @author student
 */
public class Predavanje3 
{
    
    
    
    public static void main(String[] args) 
    {
        int n=100;

        if(n<100)
        {
          if(n%12==0 && n%15==0)
          {
            System.out.println("Da");   
          }
          else
          {
             System.out.println("Ne"); 
          }
          
         }
           else if(n<100.)
            {
             if(n%111==0)
             {
                System.out.println("Deljiv"); 
             }
             else
             {
                System.out.println("NIje deljiv");
             }
            }
        else
        {
          System.out.println();
        }
        }
    }
    

