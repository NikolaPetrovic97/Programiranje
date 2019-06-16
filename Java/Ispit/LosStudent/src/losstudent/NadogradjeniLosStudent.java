/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package losstudent;

/**
 *
 * @author student
 */
public class NadogradjeniLosStudent extends LosStudent
{
   int JMBG;

    public NadogradjeniLosStudent(String ime, String prezime, int broj_predmeta_sa_ocenom_sest, int broj_ne_polozenih_predmeta) {
        super(ime, prezime, broj_predmeta_sa_ocenom_sest, broj_ne_polozenih_predmeta);
    }

    public NadogradjeniLosStudent(String ime, String prezime) {
        super(ime, prezime);
    }

    
   
   
}
