/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package predavanje4;

/**
 *
 * @author student
 */
public class Predavanje4 
{

    
    
          
    public static void main(String[] args) 
    {
        int[] niz=new int [5];
        niz[0]=10;
        niz[3]=15;
        
        for(int i=0; i<niz.length; i++)
        {
            System.out.println(niz[i]);
          
        }
        
        
        
        int broj_kolona=5;
        int broj_redova=5;
        int[][] matrica=new int [broj_kolona][broj_redova];
        
        for(int i=0; i<broj_redova; i++)
        {
            for(int j=0; j<broj_kolona; j++)
            {
                matrica[i][j]=i+j;
                
                System.out.print(matrica[i][j]+ " ");
            }
            
            System.out.println("");
        }
        
        for(int i=0; i<broj_redova; i++)
        {
            for(int j=0; j<broj_kolona; j++)
            {
                
                System.out.print(matrica[i][j]+ " ");
            }
        
        
    }
    
    }


//matrica 1 2 3 4 5
//        6 7 8 9 10

//matrica N*N

/*
1 6
2 7
3 8
4 9
5 10

*/

//ispis niza unazad
    
/*
    klasa ucenik i dnevnik
    uceniku niz ucenika
    
    */