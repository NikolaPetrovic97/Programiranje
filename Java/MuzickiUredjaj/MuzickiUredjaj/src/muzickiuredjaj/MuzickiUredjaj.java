
package muzickiuredjaj;


public abstract class MuzickiUredjaj 
{
    
    boolean ukljucen;
    int jacina_tona;
    
    
    public void ukljuci()
    {
        this.ukljucen=true;
    }
   
     public void iskljuci()
    {
        this.ukljucen=false;
    }
   
    public void pojacaj_ton()
    {
        this.jacina_tona ++;
    }
    
    
    public void smanji_ton()
    {
        this.jacina_tona --;
    }
    
    abstract void ispis();
   



    
    
    
    public static void main(String[] args) 
    {
      
    }
    
}
