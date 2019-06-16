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
public class Automobil
{
    String MarkaAutomobila="nepoznata";
    int cena=0;
    int GodinaProizvodnje=0;
    
    void UnesiNovAuto(String marka, int cena1, int godina)
    {
      MarkaAutomobila=marka;
      cena=cena1;
      GodinaProizvodnje=godina;
    }
    
   
    
}
