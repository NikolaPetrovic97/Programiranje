/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nizbrojeva;



 class NizBrojeva 
{
   int niz []=new int [20];
   int brojac=0;
   
   void dodavanje_elemenata(int broj)
   {
      niz[brojac]=broj;
      brojac++;
   }
    
 
   void ispisi_element(int indeks)
   {
       if(indeks<20 && indeks>=0)
       {
           System.out.println(niz[indeks]);
       }
       else
       {
           System.out.println("Indeks nije odgovarajuc. ");
       }
   }
   
   void ispis_niza()
   {
       for(int i: niz)
       {
            System.out.print("[" + i + " ");
       }
       System.out.println("]");
   }
   
   
int suma_niza()
{
    int suma=0;
    for(int i:niz)
    {
       suma+=i; 
    }
      return 0;
}

   long proizvod_niza()
{
    long proizvod=1;
    for(int i=0; i<brojac; i++)
    {
       proizvod*=niz[i]; 
    }
    return proizvod;
}

   
   int max()
   {
       int max_vrednost=niz[0];
       for(int i:niz)
       {
          if(max_vrednost<i)
          {
              max_vrednost=i;
          }
       }
       return max_vrednost;  
   }

 int max_deljiv_sa_3()
   {
       int max_vrednost=1;
       for(int i=0; i<brojac; i++)
       {
          if(niz[i]%3==0)
          {
              max_vrednost=niz[i];
              break;
          }
       }
       if(max_vrednost==1)
       {
           System.out.println("Nema deljivih sa 3");
           return -1;
       }
       else
       {
           for(int i=0; i<brojac; i++)
           {
              if(max_vrednost<niz[i] && niz[i]%3==0)
              {
                  max_vrednost=niz[i];
              }
              
           }
           return max_vrednost;
       }
       
   }
 
 
 long proizvod_parnih()
 {
     long proizvod=1;
     for(int i=0; i<brojac; i++)
     {
         if(niz[i]%2==0)
         {
           proizvod*=niz[i];          
         }   
     }
     if(brojac==0)
     {
         System.out.println("Niz je prazan ");
     }
     
     return proizvod;
     
 }

 boolean pretraga(int trazi)
 {
     for(int i:niz)
     {
         if (i==trazi)
         {
             return true;
         }
     }
     return false;
 }

 double prosecna_vrednost()
 {
     if(brojac==0)
     {
         System.out.println("Niz je prazan");
         return 0;
     }
    return suma_niza()/(brojac*1.0);
 }
 
 void obrnuti_ispis()
   {
       System.out.println("[");
       for(int i=brojac-1; i>=0; i--)
       {
           System.out.println(niz[i]+ ",");
       }
       System.out.println("]");
   }  
      




}